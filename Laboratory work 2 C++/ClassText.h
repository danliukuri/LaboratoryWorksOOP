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
    void AddNewLine(char* newLine); // ��������� ����� �� ������ 
    void DelLine(int lineNumber); // ��������� ����� � ������ 
    void DelLinesWithSubline(char* subline); // ��������� �����, �� ������ ������� ������� 
    void Clear(); // �������� ������ 
    int GetMaxLength(); // ��������� ������� ���������� ����� 
    void UppFirstLetter(); // ���������� ������ ���� ��� ��� ������ �� ��������� �������
};