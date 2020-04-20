#include <iostream>
#include <string>

using namespace std;

int main()
{
    string line;
    string str;
    cin >> str;
    while(getline(cin, line)){
        str = str + " " + line;
        cout << str << endl;
    }
    return 0;
}
