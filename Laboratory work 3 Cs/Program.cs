using System;

namespace Laboratory_work_3_Cs
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrChar a = new ArrChar(2);
            a[-1] = 'f';
            a[1] = 'f';
            a[0] = 'a';
            ArrChar c = new ArrChar(1);
            c[0] = a[1];

            int b = a.NumberOfVowels;
        }
    }
}
