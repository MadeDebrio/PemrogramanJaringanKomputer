#include <iostream>
using namespace std;

int main() {
	//game loop
	bool isPlay = true;

	//Array of integer to store money, each array store one digit (0-9)
	int money[24];

	//Integer to store temporary amount of money
	int temp = 0;

	//Varible for increment
	unsigned int randomValue = 9 , waveLoops = 3000;

	//Loop for array definition
	for (int i = 0; i <= 24; i++) {

		money[i] = 0;
	}
	

	//Start loop
	while (isPlay) {
		//Add random amount of money at index addFromIndex
		money[0] += (rand() % randomValue) + 1;

		//checking digit of array for data manipulation
		for (int i = 0; i <= 24; i++) {

			if (money[i] > 9) {

				temp = money[i];
				temp /= 10;
				money[i + 1] = money[i + 1] + temp;
				money[i] = money[i] - temp * 10;
			}
		}

		//print out
		for (int i = 24; i >= 0; i--) {	
			cout << money[i];
		}

		cout << endl;

		waveLoops--;

		//branch for increment
		if (waveLoops == 0) {
			if (randomValue < 100000) {
				randomValue *= 10;
			}
			else {
				randomValue = 4294967295;
			}
			waveLoops = 3000;
		}
		
	}
}