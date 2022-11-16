// Day11.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;//considered to be unprofessional

typedef double batwoman;

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
    char ok[] = { 'A','q','u','a','g','i','r','l','\0'};//does not add a \0
    cout << best << "\n" << ok << "\n";

    for (int i = 0; i < 7; i++)
    {
        cout << best[i] << " ";
    }
    cout << "\n";
}