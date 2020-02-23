#pragma once

class Str
{
public:
    char* str;
    Str();
    Str(char* line);
    void UppFirstLetter();
    bool ConsistSubline(char* subline);
};

class Text
{
public:
    Str* text;
    int textLength;
    Text(char** strArr, int size);
    void AddNewLine(char* newLine); // Додавання рядка до тексту 
    void DelLine(int lineNumber); // Видалення рядка з тексту 
    void DelLinesWithSubline(char* subline); // Видалення рядків, що містять заданий підрядок 
    void Clear(); // Очищення тексту 
    int GetMaxLength(); // Отримання довжини найдовшого рядка 
    void UppFirstLetter(); // Приведення перших літер усіх слів тексту до верхнього регістру
};