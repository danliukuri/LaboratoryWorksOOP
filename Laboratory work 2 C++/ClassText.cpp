#include "ClassText.h"
#include <iostream>
using namespace std;

Str::Str()
{}
Str::Str(char* line)
{
    str = new char[strlen(line)+1];
    str[strlen(line)] = '\0';
    for (int i = 0; i < strlen(line); i++)
        str[i] = line[i];
}
void Str::UppFirstLetter() // Приведення першої літери до верхнього регістру
{
    for (int i = 0; i < strlen(str); i++)
        if (isalpha(str[i]))
        {
            str[i] = toupper(str[i]);
            for (int j = i; j < strlen(str); j++)
            {
                if (isspace(str[j]))
                {
                    i = j;
                    j = strlen(str);
                }
                else
                    i = strlen(str);
            }
        }
}
bool Str::ConsistSubline(char* subline)
{
    if (strlen(subline) > strlen(str))
        return false;
    bool flag = false;
    for (int i = 0, j = 0; i < strlen(str) && j < strlen(subline); i++, j++)
    {
        if (str[i] != subline[j])
        {
            j = -1;
            flag = false;
        }
        else
            flag = true;
        if (j != strlen(subline) - 1)
            flag = false;
    }
    return flag;
}

Text::Text(char** strArr, int textLenght)
{
    this->textLength = textLenght;
    text = new Str[textLenght];
    for (int i = 0; i < textLenght; i++)
        text[i] = Str(strArr[i]);
}
void Text::AddNewLine(char* newLine) // Додавання рядка до тексту 
{
    Str* temp = new Str[textLength + 1];
    for (int i = 0; i < textLength; i++)
        temp[i] = text[i];
    temp[textLength] = Str(newLine);
    delete[] text;
    textLength++;
    text = temp;
}
void Text::DelLine(int lineNumber) // Видалення рядка з тексту 
{
    for (int i = 0; i < textLength; i++)
        if (i == lineNumber - 1)
        {
            Str* temp = new Str[textLength - 1];
            for (int a = 0, b = 0; a < textLength; a++, b++)
            {
                if (a == i)
                    b--;
                else
                    temp[b] = text[a];
            }
            delete[] text;
            textLength--;
            text = temp;
        }
}
void Text::DelLinesWithSubline(char* subline) // Видалення рядків, що містять заданий підрядок 
{
    for (int i = 0; i < textLength; i++)
        if (text[i].ConsistSubline(subline))
            DelLine(i + 1);
}
void Text::Clear() // Очищення тексту 
{
    for (int i = 0; i < textLength; i++)
        delete[] text[i].str;
    delete[] text;
} 
int Text::GetMaxLength() // Отримання довжини найдовшого рядка 
{
    int maxLen = strlen(text[0].str);
    for (int i = 1; i < textLength; i++)
        if (strlen(text[i].str) > maxLen)
            maxLen = strlen(text[i].str);
    return maxLen;
}
void Text::UppFirstLetter() // Приведення перших літер усіх слів тексту до верхнього регістру 
{
    for (int i = 0; i < textLength; i++)
        text[i].UppFirstLetter();
}