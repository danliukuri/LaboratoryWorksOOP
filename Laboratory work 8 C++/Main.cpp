#include <iostream>
#include "../Laboratory work 8 C++ Class Library/MathOperations.h"

int Str(char* str, char symbol);
void Display(std::string message);

int main()
{
    char* s = new char[34]{ "Now, I submits 8 laboratory work\0" };
    int (*func)(char* str, char symbol) = Str;
    int number = func(s, 'o');
    delete[] s;


    MathOperations mathOperations = MathOperations();
    mathOperations.RegisterHandler(Display);

    double(MathOperations:: * operation)(double value1, double value2) = &MathOperations::Divide;
    double result = mathOperations.DoOperation(9, 1.5, operation);
    result = mathOperations.DoOperation(6, 0.125, operation);
    result = mathOperations.DoOperation(11, 2, operation);
}

void Display(std::string message)
{
    std::cout << message;
}

int Str(char* str, char symbol)
{
    if (str == nullptr)
        throw  ("Str must not be null");
    int numberOfUses = 0;
    for (unsigned int i = 0; i < strlen(str); i++)
        if (str[i] == symbol)
            numberOfUses++;
    return numberOfUses;
}