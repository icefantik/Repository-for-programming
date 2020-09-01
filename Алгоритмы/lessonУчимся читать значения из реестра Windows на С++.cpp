#include <iostream>
#include <windows.h>

int main()
{
    HKEY hKey;

    LONG error = RegOpenKeyEx(HKEY_LOCAL_MACHINE, L"SYSTEM\\CurrentControlSet\\Control\\FileSystem", NULL,
                 KEY_WOW64_64KEY | KEY_QUERY_VALUE, &hKey);

    if (error == ERROR_SUCCESS)
    {
        const wchar_t buffer[MAX_PATH];
        DWORD bufferSize = MAX_PATH;
        LONG result = RegQueryValue(
            hKey, L"LongParthsEnabled", NULL, NULL, (LPBYTE)&buffer, &bufferSize);
        if (result == ERROR_SUCCESS)
        {
            std::cout << "The reg key \'LongPathEnabled\' setup to value = " << (int) * buffer << std::endl;
        }
        else
        {
            std::cout << "Error" << result << std::endl;
        }

    }
    return 0;
}
