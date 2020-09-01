#include <iostream>
#include <set>

int main()
{
    int n;
    std::set <int> s;
    std::cin >> n;
    for (int i = 0; i < n; i++)
    {
        int type, x;
        std::cin >> type >> x;
        if (type == 1)
        {
            s.insert(x);
        }
        else if (type == 2)
        {
            if (s.find(x) == s.end())
            {
                std::cout << "NO\n";
            }
            else
            {
                std::cout << "YES\n";
            }
        }
        else
        {
            s.erase(x);
        }
    }
    return 0;
}
