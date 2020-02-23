using System;

namespace Laboratory_work_2
{
    class Program
    {
        static void Main(string[] args)
        {
            TestUnit();
        }
        static void TestUnit()
        {
            char[][] examplStr = { ConvertStrToCharArr("I'm must be deleted"),
                                   ConvertStrToCharArr("hello everybody, i'm yura !!!"),
                                   ConvertStrToCharArr("  yeap"),
                                   ConvertStrToCharArr("!!! letter =)" )};

            Text exampleText = new Text(examplStr);

            int exampleMaxLen = exampleText.GetMaxLength();

            exampleText.DelLine(1);

            PrintText(exampleText);

            exampleText.AddNewLine(ConvertStrToCharArr("i'm new line"));

            PrintText(exampleText);

            exampleText.UppFirstLetter();

            PrintText(exampleText);

            exampleText.DelLinesWithSubline(ConvertStrToCharArr("!!!"));

            PrintText(exampleText);

            bool flag = exampleText.text[0].ConsistSubline(ConvertStrToCharArr("!!!"));

            exampleText.Clear();
        }
        static char[] ConvertStrToCharArr(string str)
        {
            char[] temp = new char[str.Length];
            for (int j = 0; j < str.Length; j++)
                temp[j] = str[j];
            return temp;
        }
        static void PrintText(Text text)
        {
            for (int i = 0; i < text.text.Length; i++)
            {
                for (int j = 0; j < text.text[i].str.Length; j++)
                    Console.Write(text.text[i].str[j]);
                Console.WriteLine();
            }
        }
    }
}