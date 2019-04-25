#include <iostream>
#include <vector>			//To God be the Glory for code coming together!
#include <string>			//System::Convert::ToDouble(textBox1->

using namespace std;

//Global Variables:
	vector<string> names1, names2; 
	vector<double> list;

//Prototypes:
	void wants(char);
	bool yesOrNo(char&); 
	char getResponse();
	void read_input(double&, int, int);
	void addGrades(vector<double>& v, vector<string>& n, vector<string>& n2);
	void postGrades(vector<double> v, vector<string> n, vector<string> n2);
	/* This code was written by Lee Douglas for Prof Brown in July of 2016 for the advanced C++ class*/

int main() {
	
	wants(getResponse());	
	cin.get();
	cin.get();
}

/**************************** Function to Determine the Menu Option for the User ******************************************/
char getResponse() {
	/* This code was written by Lee Douglas for Prof Brown in July of 2016 for the advanced C++ class*/
	char desire, answer='a';							//answer doesn't have to be 'a', it just needed to be initialized
	bool grades = true;

	while (grades) {
		puts("\nWould you like to...:\n\t (S)ee all the names and grades\n\t (E)nter another name / grade\n\t (Q)uit");
		cin >> desire;
			if (desire != 'q') {						//anything but 'q' can be inputted, but once it's 'q' everything's done
				if (desire == 's' || desire == 'e') {
					grades = false;						//good response, stop the loop
				}else {
					cout << "...Invalid input, please choose s,e or q...\n" << endl;
					cin.ignore(40, '\n');
					wants(getResponse());				//repeat the menu options
				}//end of nested if/else statement
			}else{
				grades = false;							//stops the loops
				desire = 'q';							// & executes the exit
			}//end of if/else statement
	}//end of while loop 
	return desire;
}//end of function getResponse

/**************************** Method for Menu Options ******************************************/
void wants(char ans) {								//takes the result of getResponse() & uses it as a parameter
	/* This code was written by Lee Douglas for Prof Brown in July of 2016 for the advanced C++ class*/
	switch (ans) {
	case 's': postGrades(list, names1, names2);		//methods that are called
		break;
	case 'e': addGrades(list, names1, names2);		//methods that are called
		break;
	case 'q': exit(0);								//if this program was not Visual Basic, <cstdlib> would be needed
		break;
	default: puts("\n\nChoose s,e or q, please!\n");//if this program was not Visual Basic, <cstdio> would be needed
		break;
	}//end switch
}//end wants

/**************************** Method to Add Student Names & Grades ******************************************/
void addGrades(vector<double>& vec, vector <string>& fnames, vector <string>& lnames) {
	/* This code was written by Lee Douglas for Prof Brown in July of 2016 for the advanced C++ class*/
	string name; 
	double score;
	char takeAnotherScore = 'y';

	while (takeAnotherScore == 'y') {
		puts("What's the student's LAST name?");
		cin >> name;
		fnames.push_back(name);											//started with an empty vector, then pushed data
		puts("\nWhat's the student's FIRST name?");
		cin >> name;													//used the same string, but to different vectors
		lnames.push_back(name);
		do {															//do/while loop needed for validation
		printf("\nWhat was %s's score?\n", name.c_str());
			read_input(score, 0, 100);
		} while (score < 0 || score>100);
	vec.push_back(score);
	puts("Would you like to input another score?");
	yesOrNo(takeAnotherScore);
	if (takeAnotherScore == 'n' || takeAnotherScore == 'N') {			//so that the main menu would show again
		cout << endl;
		wants(getResponse());
	}//end of if statement
	}//end while loop
}//end of method addGrades

/**************************** Method to Post the Grades of the Students ******************************************/
void postGrades(vector<double> vec, vector<string> nam, vector<string> nam2) {
	/* This code was written by Lee Douglas for Prof Brown in July of 2016 for the advanced C++ class*/
	printf("%s \t%s: \t%s\n", "Last Name", "First Name", "Score");					//displays the header for the scores
	
	for (unsigned int i = 0; i < vec.size(); i++) {
		
		printf("\n%s \t\t%s: \t\t%0.2f", nam[i].c_str(), nam2[i].c_str(), vec[i]);	//displays the names & scores
	}
	cout << endl;
	wants(getResponse());									//after the grades are posted, the main menu would show again
}//end of method postGrades

/**************************** User Validation for Yes or No Choice ******************************************/
bool yesOrNo(char& answer) {
	/* This code was written by Lee Douglas for Prof Brown in June of 2016 for the advanced C++ class*/
	do {
		cin >> answer;
		if (answer == 'y' || answer == 'Y') {
			return true;
		}
		else if (answer == 'n' || answer == 'N') {
			cout << "\nThank you!\n";
			return false;
		}
		else {
			cerr << "y or n, please try again:" << endl;
			cin.clear();										//clears the initial response,I think
			cin.ignore(40, '\n');								//if they just want to blurt, got it covered!
		}								
	} while (answer != 'y' || answer != 'Y' || answer != 'n' || answer != 'N');
}//end of function yesOrNo

/**************************** User Validation for Doubles ******************************************/
void read_input(double& choice, int lowerLimits, int upperLimits) {
	//this code was shared by Djon at the site: http://stackoverflow.com/questions/16934183/integer-validation-for-input
	/* This code was edited by Lee Douglas for Prof Brown in July of 2016 for the advanced C++ class*/
	//I edited the code to be able to be used with any input choice made after a number choice question is proposed.
	//I took away the return statement and made the output a referenced object
	choice = -1;
	bool valid = false;
	do
	{
		cin >> choice;
		if (cin.good())
		{
			//everything went well, we'll get out of the loop and return the value
			valid = true;

			if(choice < lowerLimits || choice > upperLimits){
			printf ("\n%0.2f is not within the limits of %d and %d. \n\t", choice, lowerLimits, upperLimits);
			}				//make sure that you are using a do while loop!
		}
		else
		{
			//something went wrong, we reset the buffer's state to good
			cin.clear();
			//and empty it
			cin.ignore(numeric_limits<streamsize>::max(), '\n');			//have you included the <limits> library?
			cout << "\nInvalid choice; please re-enter." << endl;
		}
	} while (!valid);
}//end of method read_input
/********************************************************************************************/
