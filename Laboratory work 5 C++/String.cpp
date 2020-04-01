#include "String.h"
#include <iostream>
using namespace std;

Str::Str(char* line)
{
    str = new char[strlen(line) + 1];
    str[strlen(line)] = '\0';
    for (int i = 0; i < strlen(line); i++)
        str[i] = line[i];
}
Str::~Str()
{
    delete[] str;
}
int Str::GetLength()
{
    int strLength = 0;
    while (str[strLength] != '\0')
        strLength++;
    return strLength;
}
char* Str::GetString()
{
    return str;
}

DigitalStr::DigitalStr(char* line) : Str(line)
{
    intStr = new int[this->GetLength()];
    for (int i = 0; i < this->GetLength(); i++)
    {
        if (isdigit(str[i]))
            intStr[i] = str[i] - '0';
        else
            intStr[i] = 0;
    }
}
DigitalStr::~DigitalStr()
{
    delete[] intStr;
}
int* DigitalStr::GetDigitStr()
{
    return intStr;
}
void DigitalStr::ReverseDigitStr()
{
    for (int i = 0; i < this->GetLength()/2; i++)
    {
        int temp = intStr[i];
        intStr[i] = intStr[this->GetLength() - 1 - i];
        intStr[this->GetLength() - 1 - i] = temp;
    }
}