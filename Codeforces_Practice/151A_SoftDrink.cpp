#include <iostream>
#include <algorithm>

bool comp(int a, int b)
{
    return (a < b);
}
int main()
{
    int n, k, l, c, d, p, nl, np;
    std::cin >> n >> k >> l >> c >> d >> p >> nl >> np;

    // min possible toasts
    int possibleBySoftDrink = (k * l) / nl;
    int possibleByLime = c * d;
    int possibleBySalt = p / np;

    int result = std::min({possibleByLime, possibleBySalt, possibleBySoftDrink}, comp) / n;

    std::cout << result;
}

/* problem link: https://codeforces.com/problemset/problem/151/A */
