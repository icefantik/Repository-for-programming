#include <iostream>
#include <string>

using namespace std;

/**
Липпман, Стенли Б., Жози Лажойе, Барбара Э. Му
Язык программирования C++. Вводный курс, 4-е издание
4. Упражнение 3.5. Напишите программу, читающую со стандартного устройства ввода целые строки.
Измените программу так, чтобы она читала отдельные слова.
Митюшин Пётр
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
