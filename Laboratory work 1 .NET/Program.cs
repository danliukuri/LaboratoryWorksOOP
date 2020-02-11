
using System;
using System.Runtime.InteropServices;

namespace LaboratoryWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int exampleValue1 = 16;
            int exampleValue2 = 61;
            int exampleValue3 = -37;

            Decrement(ref exampleValue1);
            Decrement(ref exampleValue2);
            Decrement(ref exampleValue3);

            bool exampleEquality1 = Equality(100, 100);
            bool exampleEquality2 = Equality(-8, 125);
            bool exampleEquality3 = Equality(132, 131); 
        }

        static void Decrement(ref int value)
        {
            for (int i = 0; i < Marshal.SizeOf(value) * 8; i++)
            {
                value ^= 1 << i;
                if (!Convert.ToBoolean(value & 1 << i))
                    break;
            }
        }

        static bool Equality(int value1, int value2)
        {
            return !Convert.ToBoolean(value1 ^ value2);
        }
    }
}