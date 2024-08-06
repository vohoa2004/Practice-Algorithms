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
