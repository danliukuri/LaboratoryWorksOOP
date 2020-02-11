#include "Functions.h"

void Decrement(int &value)
{
    for (int i = 0; i < sizeof(value) * 8; i++)
    {
        value ^= 1 << i;
        if (!bool(value & 1 << i))
            break;
    }
}

bool Equality(int value1, int value2)
{
    return !bool(value1 ^ value2);
}