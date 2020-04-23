#include <iostream>
#include <string>
#include <time.h> 
#include "Expression.h"
using namespace std;
int main()
{
    const int Length = 100;
    Expression* exampleArr[Length];
    double* result = new double[Length];
    string* logList = new string[Length];

    srand(time(NULL));
    for (int i = 0; i < Length; i++)
    {
        try
        {
            exampleArr[i] = new Expression(rand() % 10 - 5, rand() % 10 - 5, rand() % 10 - 5);
        }
        catch (out_of_range ex)
        {
            logList[i] = ex.what();
        }
    }

    for (int i = 0; i < Length; i++)
    {
        try
        {
            result[i] = exampleArr[i]->GetResult();
            logList[i] = "Success";
        }
        catch (exception &ex)
        {
            logList[i] = ex.what();
        }
    }

    for (int i = 0; i < Length; i++)
        cout << i+1 << ")  " << logList[i]<< endl;


    delete[] result;
    delete[] logList;
    for (int i = 0; i < Length; i++)
        delete exampleArr[i];
}