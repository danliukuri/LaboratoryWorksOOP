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
            exampleText.AddNewLine(ConvertStrToCharArr("i'm new line"));
            exampleText.UppFirstLetter();
            exampleText.DelLinesWithSubline(ConvertStrToCharArr("!!!"));
            exampleText.Clear();
        }
        static char[] ConvertStrToCharArr(string str)
        {
            char[] temp = new char[str.Length];
            for (int j = 0; j < str.Length; j++)
                temp[j] = str[j];
            return temp;
        }
    }
}