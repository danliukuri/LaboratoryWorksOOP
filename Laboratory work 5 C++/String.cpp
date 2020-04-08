#include "String.h"
#include <iostream>
using namespace std;

Str::Str(char* line)
{
    str = new char[strlen(line) + 1];
    str = _strdup(line);
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
    intStr = new int[GetDigitLength()];
    int i = 0, j = 0;
    while (j < GetLength())
    {
        if (isdigit(str[j]))
        {
            intStr[i] = str[j] - '0';
            i++;
        }
        j++;
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
int DigitalStr::GetDigitLength()
{
    int len = 0;
    for (int i = 0; i < GetLength(); i++)
        if (isdigit(str[i]))
            len++;
    return len;
}
void DigitalStr::ReverseDigitStr()
{
    for (int i = 0; i < GetDigitLength()/2; i++)
    {
        int temp = intStr[i];
        intStr[i] = intStr[GetDigitLength() - 1 - i];
        intStr[GetDigitLength() - 1 - i] = temp;
    }
}