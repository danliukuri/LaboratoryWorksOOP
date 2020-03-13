using System;

namespace Laboratory_work_3_Cs
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrChar arr = new ArrChar();
            ArrChar arr2 = new ArrChar();

            arr2[1] = arr[1];

            arr[1] = 'f';
            arr[0] = 'a';
            arr[1] = 'E';

            arr2[0] = arr[2];

            int numberOfVowels = arr.NumberOfVowels;
        }

        static void MainTwoRealization(string[] args)
        {
            ArrCharTwoRealization a = new ArrCharTwoRealization(2);
            a[-1] = 'f';
            a[1] = 'f';
            a[0] = 'a';
            ArrCharTwoRealization c = new ArrCharTwoRealization(1);
            c[0] = a[1];

            int b = a.NumberOfVowels;
        }
    }
}
