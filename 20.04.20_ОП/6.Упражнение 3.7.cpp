#include <iostream>
#include <string>

using namespace std;

/**
�������, ������ �., ���� ������, ������� �. ��
���� ���������������� C++. ������� ����, 4-� �������
4. ���������� 3.5. �������� ���������, �������� �� ������������ ���������� ����� ����� ������.
�������� ��������� ���, ����� ��� ������ ��������� �����.
������� ϸ��
*/

int main()
{
    string str1;
    string str2;
    int str1_length, str2_length;
    cin >> str1 >> str2;
    str1_length = str1.size();
    str2_length = str2.size();
    if (str1_length > str2_length){
        cout << "string 1 more string 2" << endl;
    }
    else if (str1_length < str2_length){
        cout << "string 2 more string 1" << endl;
    }
    else if (str1_length == str2_length){
        cout << "string equal" << endl;
    }

    //cout << str1.length() << " " << str2.length() << endl;
    return 0;
}
