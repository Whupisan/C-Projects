#include <iostream>
#include <fstream>
#include <vector>

using namespace std;

class Accounts {
private:
	int acctNum;
	double dlrAmnt, currBal;
	string n1;

public:
	int getAcctNum() {
		return acctNum;
	}
	void setAcctNum(int accountNum) {
		acctNum = accountNum;
	}

	double getDollarAmount() {
		return dlrAmnt;
	}
	void setDollarAmount(double dollarAmount) {
		dlrAmnt = dollarAmount;
	}

	double getCurrentBalance() {
		return currBal;
	}
	void setCurrentBalance(double currentBalance) {
		currBal = currentBalance;
	}

	string getName() {
		return n1;
	}
	void setName(string name) {
		n1 = name;
	}

	//default constructor
	Accounts() { int acctNum = 0; double dlrAmnt = 0.0; double currBal = 0.0; string n1 = " "; }

	//filled constructor		
	Accounts(int n, double d, double e, string s) {
		int acctNum = n; double dlrAmnt = d; double currBal = e; string n1 = s;
	}
};

int main() {

	string name, accountNum, balance, line;		
	ifstream readFile("oldmaster.txt");			//reading from the original to manipulate trans data to send to the latest account
	ofstream writeTrans("trans.txt");			//writing to the account that sends the latest transactions
	ofstream writeFile("oldmaster.txt");		//writing to the original account
	ofstream newMaster("newmaster.txt");		//writing to the latest account
	
	vector <Accounts> clients(4), trans(4);		//decided to make a vector even though I knew it wouldn't grow

/*************************************** the object called Accounts incorporates all of what I would ***********************************************/
/*************************************** need to capture the nuisances of the transactions *********************************************************/
/************************************************** This code was written by Lee Douglas for Prof Brown in July of 2016 for the advanced C++ class */
	clients.at(0).setAcctNum(100);
	clients.at(0).setName(" Alan Jones ");
	clients.at(0).setCurrentBalance(37.6); 
	clients.at(1).setAcctNum(300); 
	clients.at(1).setName(" Mary Smith "); 
	clients.at(1).setCurrentBalance(42.67);
	clients.at(2).setAcctNum(500);
	clients.at(2).setName(" Sam Sharp ");
	clients.at(2).setCurrentBalance(0);
	clients.at(3).setAcctNum(700); 
	clients.at(3).setName(" Suzy Green "); 
	clients.at(3).setCurrentBalance(-14.22);

/*************************************** using a loop to print the results to the user's screen as well as populate the original file **************/
/************************************************** This code was written by Lee Douglas for Prof Brown in July of 2016 for the advanced C++ class */
	for (int i = 0; i < 4; ++i) {
		printf("Client %d account number is %d, account name is %s & account balance is %0.2f", i+1, clients.at(i).getAcctNum(), clients.at(i).getName().c_str(), clients.at(i).getCurrentBalance());
		if (i < 3) { cout << endl; }

		writeFile << /*"Client " << i+1 << " account number is " << */clients.at(i).getAcctNum() << /*", account name is " << */clients.at(i).getName().c_str() << /*" & account balance is " << */clients.at(i).getCurrentBalance();
		if (i < 3) { writeFile << endl; }
	}//end of for loop

/*************************************** assigning transactional values to the clients *************************************************************/
/************************************************** This code was written by Lee Douglas for Prof Brown in July of 2016 for the advanced C++ class */
	trans.at(0).setAcctNum(100);
	trans.at(0).setName(" ");
	trans.at(0).setDollarAmount(27.14); 
	trans.at(1).setAcctNum(300); 
	trans.at(1).setName(" "); 
	trans.at(1).setDollarAmount(62.11);
	trans.at(2).setAcctNum(400);
	trans.at(2).setName(" ");
	trans.at(2).setDollarAmount(100.56);
	trans.at(3).setAcctNum(900); 
	trans.at(3).setName(" "); 
	trans.at(3).setDollarAmount(82.17);
	
/*************************************** writing the data to the transactions file *****************************************************************/
/************************************************** This code was written by Lee Douglas for Prof Brown in July of 2016 for the advanced C++ class */
	for (int i = 0; i < 4; i++) {
		writeTrans << trans.at(i).getAcctNum() <<" "<< trans.at(i).getDollarAmount();
		if (i < 3) { writeTrans << endl; }
	}//end of for loop

/*************************************** comparing the original account to the recent account customer transactions ********************************/
/*************************************** and setting the values equal to the sum of the transactions, the result ***********************************/
/*************************************** is then printing to the new master file *******************************************************************/
/************************************************** This code was written by Lee Douglas for Prof Brown in July of 2016 for the advanced C++ class */
	for (int i = 0; i < 4; i++) {
		if(clients.at(i).getAcctNum()==trans.at(i).getAcctNum()){
			clients.at(i).setCurrentBalance(trans.at(i).getDollarAmount() + clients.at(i).getCurrentBalance());
			newMaster << clients.at(i).getCurrentBalance();
			if (i < 3) { newMaster << endl; }
		}
		else
		{
			newMaster << "Unmatched transaction record for account number " << trans.at(i).getAcctNum();
			if (i < 3) { newMaster << endl; }
		}
	}//end of for loop
	//cin.get();
	
	//always remember to close the files
	writeTrans.close();		
	writeFile.close();	
	newMaster.close();
}
