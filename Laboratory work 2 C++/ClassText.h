#pragma once

class Str
{
public:
    Str();
    Str(char* line);
    void UppFirstLetter();
    void ClearStr();
    int GetLength();
    bool ConsistSubline(char* subline);
private:
    char* str;
};

class Text
{
public:
    int textLength;
    Text(char** strArr, int size);
    void AddNewLine(char* newLine); // ��������� ����� �� ������ 
    void DelLine(int lineNumber); // ��������� ����� � ������ 
    void DelLinesWithSubline(char* subline); // ��������� �����, �� ������ ������� ������� 
    void Clear(); // �������� ������ 
    int GetMaxLength(); // ��������� ������� ���������� ����� 
    void UppFirstLetter(); // ���������� ������ ���� ��� ��� ������ �� ��������� �������
private:
    Str* text;
};