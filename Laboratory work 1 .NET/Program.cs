using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int exampleValue1 = 63;
            int exampleValue2 = -18;
            int exampleValue3 = 92;

            Increment(ref exampleValue1);
            Increment(ref exampleValue2);
            Increment(ref exampleValue3);

            bool exampleIsbigger1 = IsBigger(88, 88);
            bool exampleIsbigger2 = IsBigger(34, 2);
            bool exampleIsbigger3 = IsBigger(23, 57);
        }

        static void Increment(ref int value)
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

        static bool IsBigger(int value1, int value2)
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
    }
}