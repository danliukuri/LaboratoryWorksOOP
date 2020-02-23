#include <iostream>
#include <string>
#include "ClassText.h"

using namespace std;

void TestUnit();
char* ConvertStrToCharArr(string str);
void PrintText(Text &text);

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

    for (int i = 0; i < size ; i++)
    {
        for (int j = 0; j < strlen(examplStr[i]); j++)
            cout << examplStr[i][j];
        cout << endl;
    }

    Text exampleText = Text(examplStr, size);

    for (int i = 0; i < size; i++)
        delete[] examplStr[i];
    delete[] examplStr;


    int exampleMaxLen = exampleText.GetMaxLength();

    exampleText.DelLine(1);

    PrintText(exampleText);

    exampleText.AddNewLine(ConvertStrToCharArr("i'm new line"));

    PrintText(exampleText);

    exampleText.UppFirstLetter();

    PrintText(exampleText);

    exampleText.DelLinesWithSubline(ConvertStrToCharArr("!!!"));

    PrintText(exampleText);

    bool flag = exampleText.text[0].ConsistSubline(ConvertStrToCharArr("!!!"));

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
void PrintText(Text &text)
{
    for (int i = 0; i < text.textLength; i++)
    {
        for (int j = 0; j < strlen(text.text[i].str) ; j++)
            cout << text.text[i].str[j];
        cout << endl;
    }
}