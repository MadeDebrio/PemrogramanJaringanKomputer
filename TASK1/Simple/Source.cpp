#pragma warning( disable : 4507 34; once : 4385; error : 164 )
#include <iostream>
#include <string>
using namespace std;

//Global Var
bool isSingleDigitUSER, isSingleDigitPASS;
string username, password, package;

//Global Function
string process(string a, string b, string c);
void input();
string output(bool checkUSER, bool checkPASS, string Data);
void start();

int main() {
	start();
	input();

	package = process(username, password, package);
	cout << "***********************Sending Data to Server***********************\n\n";
	cout << "Username = " << username << endl;
	cout << "Password = " << password << endl;
	cout << "Package  = " << package << endl;

	package = output(isSingleDigitUSER, isSingleDigitPASS, package);

	cout << "***********************Checking Data *****************************\n\n";
	cout << "Username = " << username << endl;
	cout << "Password = " << password << endl;
	cout << "Package  = " << package << endl;


	cout << endl;
	system("PAUSE");
	return 0;
}

void input() {
	cout << "++++++++++++++++++SOSIAL MEDIA WEBSITE++++++++++++++++++";
	cout << "\n\n\nLOGIN : ";
	getline(cin, username);

	cout << "PASSWORD : ";
	getline(cin, password);
}

string process(string a, string b, string c) {
	int temp;
	temp = a.size();
	c += to_string(temp) + a;
	temp = b.size();
	c += to_string(temp) + b;

	//Check the number of Username n password
	if (a.size() > 9)
	{
		isSingleDigitUSER = false;
	}

	if (b.size() > 9)
	{
		isSingleDigitPASS = false;
	}

	//Delete username n password
	username.erase();
	password.erase();

	return c;
}

string output(bool checkUSER, bool checkPASS, string Data) {
	string temp;
	if (checkUSER == true) {//username single digit
		temp = Data[0];//Take the first string 
		Data = Data.erase(0, 1);
		for (int i = 0; i < stoi(temp); i++) {
			username += Data[i];
		}
		Data = Data.erase(0, stoi(temp));

		if (checkPASS == true)//password single digit
		{
			temp = Data[0];//Take the first string 
			Data = Data.erase(0, 1);
			for (int i = 0; i < stoi(temp); i++) {
				password += Data[i];
			}
		}
		else if (checkPASS == false) {
			temp = Data[0] + Data[1];//Take the first string 
			Data = Data.erase(0, 2);
			for (int i = 0; i < stoi(temp); i++) {
				password += Data[i];
			}
		}

	}
	else {
		temp = Data[0] + Data[1];//Take the first string 
		Data = Data.erase(0, 2);
		for (int i = 0; i < stoi(temp); i++) {
			username += Data[i];
		}
		Data = Data.erase(0, stoi(temp));

		if (checkPASS == true)//password single digit
		{
			temp = Data[0];//Take the first string 
			Data = Data.erase(0, 1);
			for (int i = 0; i < stoi(temp); i++) {
				password += Data[i];
			}
		}
		else if (checkPASS == false) {
			temp = Data[0] + Data[1];//Take the first string 
			Data = Data.erase(0, 2);
			for (int i = 0; i < stoi(temp); i++) {
				password += Data[i];
			}
		}
	}
	Data.erase();
	return Data;
}

void start()
{
	isSingleDigitUSER = true;
	isSingleDigitPASS = true;
}
