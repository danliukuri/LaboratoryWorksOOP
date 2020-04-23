#pragma once
class Expression
{
public:
    Expression(int a, int c, int d);
    double GetResult();
private:
    int a, c, d;
};