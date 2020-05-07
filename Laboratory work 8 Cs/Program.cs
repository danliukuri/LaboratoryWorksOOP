using System;
using Laboratory_work_8_Cs_Class_Library;

namespace Laboratory_work_8_Cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Str s = new Str("Now, I submits 8 laboratory work");
            int[] number = new int[5];
            number[0] = s.SearchNumberOfUsesSymbol('a');
            number[1] = s.SearchNumberOfUsesSymbol('b');
            number[2] = s.SearchNumberOfUsesSymbol('c');

            Str.Method method = Str.SearchNumberOfUsesSymbol;
            number[3] = s.UseMethod('w', method);

            number[4] = Str.SearchNumberOfUsesSymbol("Yuriy", 'r');


            double[] result = new double[3];
            MathOperations mathOperations = new MathOperations();
            mathOperations.IntegerDivision += Display;
            MathOperations.Operation operation = mathOperations.Divide;
            result[0] = mathOperations.DoOperation(9, 1.5, operation);
            result[1] = mathOperations.DoOperation(6, 0.125, operation);
            result[2] = mathOperations.DoOperation(11, 2, operation);
        }

        static void Display(string message)
        {
            Console.WriteLine(message);
        }
    }
}
