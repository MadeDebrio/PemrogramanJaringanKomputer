#include <iostream>
using namespace std;

int main() {
	//code ini khusus untuk menguji ketahanan memory :)
	bool gameOn = true;
	long double money = 0.0;
	long double moneyTEMP = 1;
	int increment=1;
	
	while (gameOn) {
		if (money > moneyTEMP * 10) {
			increment *= 5;
			moneyTEMP = money;
		}
		money+=increment;
		cout << money << endl;
	}
}