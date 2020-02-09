#include "Functions.h"

void Increment(int &value)
{
    for (int i = 0; i < 32; i++)
    {
        if ((value & 1 << i) == 0)
        {
            value ^= 1 << i;
            break;
        }
        value ^= 1 << i;
    }
}

bool IsBigger(int value1, int value2)
{
    if ((value1 & 1 << 32 - 1) != 0 || (value2 & 1 << 32 - 1) != 0)
        for (int i = 0; i < 32; i++)
        {
            if ((value1 & 1 << i) != 0 && (value2 & 1 << i) == 0)
                return true;
            if ((value2 & 1 << i) != 0 && (value1 & 1 << i) == 0)
                return false;
        }
    else
        for (int i = 32 - 1; i >= 0; i--)
        {
            if ((value1 & 1 << i) != 0 && (value2 & 1 << i) == 0)
                return true;
            if ((value2 & 1 << i) != 0 && (value1 & 1 << i) == 0)
                return false;
        }
    return false;
}