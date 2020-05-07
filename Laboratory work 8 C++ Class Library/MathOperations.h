#pragma once
#include "pch.h"
#include <iostream>
#include "string.h"


class MathOperations
{
public:
    double DoOperation(double value1, double value2, double (MathOperations::* operation)(double value1, double value2));
    double Add(double value1, double value2);
    double Subtract(double value1, double value2);
    double Multiply(double value1, double value2);
    double Divide(double value1, double value2);
    double Pow(double value1, double value2);
    void RegisterHandler(void(*operation)(std::string message));
private:
    double (*operation)(double value1, double value2);
    void (*operationHandler)(std::string message);
};