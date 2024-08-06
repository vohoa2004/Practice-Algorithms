#include <iostream>
using namespace std;
int main ()
{
	int n, have[5], color[5];
	int s,i,j;
	bool exist = false;
	s = 0;
	for (i=0; i<4; i++){
		cin >> have[i];
	}
	
	for (i=0; i<4; i++){
		color[i] = 0;
	}
	
	for (i=0; i<4; i++){
		exist = false;
		
		for(j=0; j<4; j++){
			if(color[j] == have[i]){
				exist = true;
				break;
			}
		}
		
		if(!exist){
			color[i] = have[i];
		}else{
			color[i] = 0;
		}
	}
	
	for (i=0; i<4; i++){
		if(color[i] != 0){
			s++;
		}
	}
	
	cout << (4-s);
	
	return 0;
}
