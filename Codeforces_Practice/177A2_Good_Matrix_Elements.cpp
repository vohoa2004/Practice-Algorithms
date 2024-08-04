#include <iostream>
int main()
{
    int n;

    std::cin >> n;
    int matrix[n][n];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            std::cin >> matrix[i][j];
        }
    }
    int sum = 0;
    for (int i = 0; i < n; i++)
    {
        sum += matrix[i][i] + matrix[i][n - 1 - i] + matrix[(n - 1) / 2][i] + matrix[i][(n - 1) / 2];
    }
    sum -= 3 * matrix[(n - 1) / 2][(n - 1) / 2];
    std::cout << sum;
}