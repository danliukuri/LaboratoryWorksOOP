
using System.Runtime.InteropServices;

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
            for (int i = 0; i < Marshal.SizeOf(value)*8; i++)
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
            int size = Marshal.SizeOf(value1) * 8;
            if ((value1 & 1 << size - 1) != 0 || (value2 & 1 << size - 1) != 0)
                for (int i = 0; i < size; i++)
                {
                    if ((value1 & 1 << i) != 0 && (value2 & 1 << i) == 0)
                        return true;
                    if ((value2 & 1 << i) != 0 && (value1 & 1 << i) == 0)
                        return false;
                }
            else
                for (int i = size - 1; i >= 0; i--)
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