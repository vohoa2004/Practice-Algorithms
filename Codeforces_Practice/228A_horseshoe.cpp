#include <iostream>
#include <algorithm>

using namespace std;

int main(int argc, char** argv) {
    int arr[4];

    for (int i = 0; i < 4; i++) {
        std::cin >> arr[i];
    }

	sort(arr, arr + 4);
//	for (int i = 0; i < 4; i++) {
//        std::cout << arr[i];
//    }
    int count = 4;
    
    // find no of different values
    for (int i = 0; i < 3; i++) {
        if (arr[i + 1] == arr[i]) {
        	count--;
		}
    }

    std::cout << 4 - count << std::endl;
}

/* https://codeforces.com/problemset/problem/228/A */
