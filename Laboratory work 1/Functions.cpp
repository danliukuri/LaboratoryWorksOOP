#include "Functions.h"

void Decrement(int &value)
{
    for (int i = 0; i < sizeof(value) * 8; i++)
    {
        value ^= 1 << i;
        if (!bool(value & 1 << i))
            i = sizeof(value) * 8;
    }
}

bool Equality(int value1, int value2)
{
    for (int i = sizeof(value1) * 8; i >= 0; i++)
    {
        if (bool((value1 ^ 1 << i) ^ (value2 ^ 1 << i)))
            return false;
    }
    return true;
}