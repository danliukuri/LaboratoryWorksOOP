#include <iostream>
#include <string>
#include "ClassText.h"

using namespace std;

void TestUnit();
char* ConvertStrToCharArr(string str);

int main()
{
    TestUnit();
} 

void TestUnit()
{
    const int size = 4;
    char** examplStr = new char* [size];
    examplStr[0] = ConvertStrToCharArr("I'm must be deleted\0");
    examplStr[1] = ConvertStrToCharArr("hello everybody, i'm yura !!!\0");
    examplStr[2] = ConvertStrToCharArr("  yeap\0");
    examplStr[3] = ConvertStrToCharArr("!!! letter =)\0");

    Text exampleText = Text(examplStr, size);

    for (int i = 0; i < size; i++)
        delete[] examplStr[i];
    delete[] examplStr;
    int exampleMaxLen = exampleText.GetMaxLength();
    exampleText.DelLine(1);
    exampleText.AddNewLine(ConvertStrToCharArr("i'm new line"));
    exampleText.UppFirstLetter();
    exampleText.DelLinesWithSubline(ConvertStrToCharArr("!!!"));
    exampleText.Clear(); 
}

char* ConvertStrToCharArr(string str)
{
    char* temp = new char[str.length()+1];
    temp[str.length()] = '\0';
    for (int j = 0; j < str.length(); j++)
        temp[j] = str[j];
    return temp;
}