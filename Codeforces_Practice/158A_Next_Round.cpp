#include <iostream>

int main()
{
    int n, k;
    std::cin >> n >> k;
    int arr[n];
    for (int i = 0; i < n; i++)
    {
        std::cin >> arr[i];
    }
    int pass = arr[k - 1];
    int count = 0;
    for (int i = 0; i < n; i++)
    {
        if (arr[i] >= pass && arr[i] > 0)
        {
            count++;
        }
    }
    std::cout << count;
}

/* problem link: https://codeforces.com/problemset/problem/158/A */
