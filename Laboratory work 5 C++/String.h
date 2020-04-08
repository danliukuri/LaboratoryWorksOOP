#pragma once
class Str
{
public:
    Str(char* line);
    ~Str();
    int GetLength();
    char* GetString();
protected:
    char* str;
};

class DigitalStr : public Str
{
public:
    ~DigitalStr();
    DigitalStr(char* line);
    int* GetDigitStr();
    int GetDigitLength();
    void ReverseDigitStr();
private:
    int* intStr;
};