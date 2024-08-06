<<<<<<< HEAD
// 231A
#include <iostream>

//Use std::cin and std::cout instead of scanf and printf.
//Declare the functions xor, or, and and before the main function.
//Pass the array row properly to these functions.
//Fix the increment condition in the nested loop.
//Properly handle the array size within the functions.

int xorFunc(int row[3]);
int orFunc(int row[3]);
int andFunc(int row[3]);

int main(int argc, char** argv) {
    int n;
    std::cin >> n;
    int arr[n][3];

    for (int i = 0; i < n; i++) {
        for (int j = 0; j < 3; j++) {  // Fixing the increment condition
            std::cin >> arr[i][j];
        }
    }

    int count = 0;
    for (int i = 0; i < n; i++) {
        // (xor = 1 && and = 1) or (xor = 0 && or = 1)
        if ((xorFunc(arr[i]) == 1 && andFunc(arr[i]) == 1) || (xorFunc(arr[i]) == 0 && orFunc(arr[i]) == 1)) {
            count++;
        }
    }

    std::cout << count << std::endl;
}

int xorFunc(int row[3]) {
    int result = row[0];
    for (int j = 1; j < 3; j++) {
        result = result ^ row[j];
    }
    return result;
}

int orFunc(int row[3]) {
    int result = row[0];
    for (int j = 1; j < 3; j++) {
        result = result | row[j];
    }
    return result;
}

int andFunc(int row[3]) {
    int result = row[0];
    for (int j = 1; j < 3; j++) {
        result = result & row[j];
    }
    return result;
}

// problem link: https://codeforces.com/problemset/problem/231/A

=======
#include <iostream>
using namespace std;
int main ()
{
	int n,s,ans,temp,i;
	while (cin >> n){
		s=0;
		while(n--){
			ans = 0;
			for(i=0; i<3; i++){
				cin >> temp;
				if(temp == 1){
					ans++;
				}
			}
			if(ans>=2){
				s++;
			}
		}
		cout << s << endl;
	}
	return 0;
}
>>>>>>> 0c8e96d5fe95e34f3bebc6ca851bdbbb8afeb350
