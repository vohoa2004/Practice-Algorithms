#include <iostream>
#include <stdbool.h>
int main()
{
    int n;
    std::cin >> n;

    int arr[n];
    for (int i = 0; i < n; i++)
    {
        std::cin >> arr[i];
    }

    int amazingGood = 0;
    int amazingBad = 0;
    for (int i = 1; i < n; i++)
    {
        bool ok = true;
        for (int j = 0; j < i; j++)
        {
            if (arr[i] <= arr[j])
            {
                ok = false;
                break;
            }
        }
        if (ok == true)
            amazingGood++;
    }
    for (int i = 1; i < n; i++)
    {
        bool ok = true;
        for (int j = 0; j < i; j++)
        {

            if (arr[i] >= arr[j])
            {
                ok = false;
                break;
            }
        }
        if (ok == true)
            amazingBad++;
    }
    std::cout << amazingGood + amazingBad;
}

/* problem link: https://codeforces.com/problemset/problem/155/A*/
