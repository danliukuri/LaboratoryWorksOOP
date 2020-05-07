#include "pch.h"
#include "pch.h"
#include "MathOperations.h"

double MathOperations::DoOperation(double value1, double value2, double(MathOperations::* operation)(double value1, double value2))
{
	if (operation == nullptr)
		throw new std::exception("Operation must not be null");
	return (this->*operation)(value1, value2);
}
double MathOperations::Add(double value1, double value2)
{
	return value1 + value2;
}
double MathOperations::Subtract(double value1, double value2)
{
	return value1 - value2;
}
double MathOperations::Multiply(double value1, double value2)
{
	return value1 * value2;
}
double MathOperations::Divide(double value1, double value2)
{
	if (value2 == 0)
		throw new std::exception("Value2 must not be 0");
	if (value1 - (int)value1 == 0 && value2 - (int)value2 == 0)
	{
		if (operationHandler != nullptr)
			operationHandler("Integer division");
		else
			throw new std::exception("OperationHandler not defined");
	}
	return value1 / value2;
}
double MathOperations::Pow(double value1, double value2)
{
	return pow(value1, value2);
}
void MathOperations::RegisterHandler(void(*operation)(std::string message))
{
	if (operation == nullptr)
		throw new std::exception("Operation must not be null");
	operationHandler = operation;
}
