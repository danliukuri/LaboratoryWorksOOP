#include "Expression.h"
#include <iostream>
#include <Math.h>

Expression::Expression(int a, int c, int d)
{
    this->a = a;
    this->c = c;
    this->d = d;
}
double Expression::GetResult()
{
    if (2 * c - a <= 0)
        throw  std::invalid_argument("Expression 2*c-a must be more than 0");

    double divider = (double)(a) / 4 + c;

    if (divider == 0)
        throw std::invalid_argument("Expression a/4+c should not be 0");

    double dividend = log10(2 * c - a) + d - 152;
    return dividend / divider;
}
