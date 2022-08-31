#include <iostream>
#include <string>
using namespace std;

string username, password, package;
int stringCounter;

void input();
string process(string a, string b, string c);
void output();

int main() {

	input();
	output();


	cout << endl;
	system("PAUSE");
	return 0;
}

void input() {
	cout << "++++++++++++++++++WEBSITE SOSIAL MEDIA++++++++++++++++++";
		cout << "\n\n\nLOGIN : ";
	cin >> username;

	cout << "PASSWORD : ";
	cin >> password;
}

string process(string a, string b, string c) {
	int temp;
	temp =  a.size();
	c += to_string(temp) + a;
	temp = b.size();
	c += to_string(temp) + b;

	return c;
}

void output() {;
	package = process(username, password, package);
	cout << "***********************Data yang terkirim***********************\n\n";
	cout << "Package = " << package;
}
