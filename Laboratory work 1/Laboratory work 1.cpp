
#include "Functions.h"

int main()
{
    int exampleValue1 = 16;
    int exampleValue2 = 61;
    int exampleValue3 = -37;

    Decrement(exampleValue1);
    Decrement(exampleValue2);
    Decrement(exampleValue3);

    bool exampleEquality1 = Equality(100, 100);
    bool exampleEquality2 = Equality(-8, 125);
    bool exampleEquality3 = Equality(132, 131);
}
