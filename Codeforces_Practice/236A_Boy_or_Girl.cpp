#include <iostream>
using namespace std;

int cntDistinct(string s)
{
    int n = s.length(); // size of string
    int a[26] = {0}; // an array of size 26, initialize with 0
 
    // iterate over the string s
    for (int i = 0; i < n; i++) {
        int index = s[i] - 'a'; // calculate index by (s[i] - 'a') in ASCII value
        a[index] = 1; // Set the value at index to 1
    }
 
    int count = 0; // Take a counter with 0
     
    for (int i = 0; i < 26; i++) { // Loop to 26
        // count no. of index having value 1
        if (a[i] == 1) {
            count += 1;
        }
    }
    return count;
}

int main ()
{
	string name;
	cin >> name;
	
	if(cntDistinct(name)%2 == 1){
		cout << "IGNORE HIM!";
	}else{
		cout << "CHAT WITH HER!";
	}
	
	return 0;
}



