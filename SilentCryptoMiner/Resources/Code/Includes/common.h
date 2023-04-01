#pragma once

#include <windows.h>

PROCESS_INFORMATION create_new_process_internal(LPWSTR programPath, LPWSTR cmdLine, LPWSTR startDir, LPWSTR runtimeData, DWORD processFlags, DWORD threadFlags);

bool has_gpu();

void run_program(bool wait, wchar_t* startDir, wchar_t* programPath, wchar_t* cmdLine, ...);

bool check_mutex(wchar_t* mutex);

void combine_path(wchar_t* src, wchar_t* base_path, wchar_t* ext_path);

wchar_t* get_env(wchar_t* env, wchar_t* env_name);

HANDLE create_directory(wchar_t* dir_path);

void create_recursive_directory(wchar_t* dir_path);

HANDLE create_file(wchar_t* file_path);

HANDLE open_file(wchar_t* file_path, bool read_only);

PVOID read_file(wchar_t* file_path, ULONG* outFileSize);

bool write_file(wchar_t* file_path, PVOID paylad_buf, ULONG payload_size);

bool delete_file(wchar_t* file_path);

bool check_file_exists(wchar_t* file_path);

bool check_administrator();

bool set_value_registry(wchar_t* key, wchar_t* value, ULONG type, PVOID data, ULONG datasize);

bool check_key_registry(wchar_t* key);

bool rename_key_registry(wchar_t* current_key, wchar_t* new_key);

bool delete_key_registry(wchar_t* key);