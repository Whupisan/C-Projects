#include <iostream>

using namespace std;

//Global Variables
double tally;
bool thirsty = true;

//Prototypes
void sodaChoice();
double coke(int);
double pepsi(int);
double mtDew(int);
double drPepper(int);
void getTotal();
int asking4Soda(string, double);
double chooseaSoda(int);

int main() {

	sodaChoice();
	
}

void sodaChoice(){
	int soda=0;
	while (thirsty) {
		if (soda == 5) {
			cin.get();
			getTotal();
			//thirsty = false;
		} else {
			puts("What kind of refreshing beverage would you like?\n\t1. Coke\n\t2. Pepsi\n\t3. Mountain Dew\n\t4. Dr. Pepper\n\t5. Exit");
			cin >> soda;
			chooseaSoda(soda);
		}//end of if/else statement
	}//end while
}//end method sodaChoice

double chooseaSoda(int choice) {

	switch (choice)	{
		case 1:	tally+=coke(choice = asking4Soda("Coke",1.5));
			printf("Your subtotal will be $%0.2f\n\n", tally);
			break;
		case 2: tally+=pepsi(choice = asking4Soda("Pepsi",1));
			printf("Your subtotal will be $%0.2f\n\n", tally);
			break;
		case 3:	tally+=mtDew(choice = asking4Soda("Mountain Dew",0.75));
			printf("Your subtotal will be $%0.2f\n\n", tally);
			break;
		case 4: tally+=drPepper(choice = asking4Soda("Dr. Pepper", 1.25));
			printf("Your subtotal will be $%0.2f\n\n", tally);
			break;
		case 5: 
			break;
		default: puts("\nPlease choose a value between 1 - 5 or press 9 to quit\n");
			break;
	}
	return tally;
}

int asking4Soda(string s, double price){
	int number;
	printf("%ss are $%0.2f each. How many would you like? ", s.c_str(), price);
	cin >> number;
	return number;
}

double coke(int num) {
	double subTote = 1.5*num;
	return subTote;
}
double pepsi(int num) {
	double subTote = num;
	return subTote;
}
double mtDew(int num) {
	double subTote = 0.75*num;
	return subTote;
}
double drPepper(int num) {
	double subTote = 1.25*num;
	return subTote;
}

void getTotal() {
	int answer;
	if (tally!=0) {
		printf("Thank you for your order. Your total is $%0.2f\n", tally + tally*.0825);
	}
	else {
		puts("If you would like to exit, please press 9, if not please choose below!\n");
		cin >> answer;
		if (answer != 9) {
			sodaChoice();
		}
		else { exit(0); }
	}
}
