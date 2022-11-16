// Day11.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <vector>
using namespace std;//considered to be unprofessional

typedef double batwoman;


enum Powers
{
	Money, Flight, Speed, Strength, Brains, Will
};

void PrintMyPowers(Powers myPowers)
{
	switch (myPowers)
	{
	case Money:
		break;
	case Flight:
		break;
	case Speed:
		break;
	case Strength:
		break;
	case Brains:
		cout << "BRAINNNNNS";
		break;
	case Will:
		break;
	default:
		break;
	}
}
int main()
{
	batwoman bidNum = 5;

	//std -- standard namespace
	// :: -- scope resolution operator
	//cout -- console output stream
	//<< -- insertion operator
	std::cout << "Hello Gotham!\n" << "I am the hero you need. ~" << 5 << "\n";

	//<type> <name>
	int num = 5;
	bool isGood = true;
	double dVal = 5;
	float fVal = 5.3f;
	char b = 'b';
	std::cout << "Size of char: " << sizeof(char) << " (bytes)\n";

	char best[] = "Batgirl";//adds \0 (null terminator)
	char ok[] = { 'A','q','u','a','g','i','r','l','\0' };//does not add a \0
	cout << best << "\n" << ok << "\n";

	for (int i = 0; i < 7; i++)
	{
		cout << best[i] << " ";
	}
	cout << "\n";

	srand(time(NULL));
	int rNum = rand();//0-32767 (RAND_MAX)
	//0-100
	rNum = rand() % 101;//remainder of dividing

	Powers myPowers = Brains;
	cout << myPowers << "\n";
	PrintMyPowers(myPowers);

	std::vector<int> scores;//a stack instance
	scores.push_back(5);//List.Add method
	scores.push_back(rand());
	scores.push_back(rand());
	scores.push_back(rand());
	cout << "\nHigh Scores:\n";
	for (size_t i = 0; i < scores.size(); i++)
	{
		cout << scores[i] << "\n";
	}
}