#pragma once

#include <windows.h>

HANDLE transacted_hollowing(wchar_t* tmpFile, wchar_t* programPath, wchar_t* cmdLine, wchar_t* runtimeData, BYTE* payladBuf, DWORD payloadSize, wchar_t* startDir);