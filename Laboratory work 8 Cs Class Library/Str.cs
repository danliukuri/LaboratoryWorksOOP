using System;

namespace Laboratory_work_8_Cs_Class_Library
{
    public class Str
    {
        public delegate int Method(string str, char symbol);
        public Str(string str)
        {
            if (str == null)
                throw new NullReferenceException("Str must not be null");
            this.str = str;
        }
        public int UseMethod(char symbol, Method method) => (method != null) ? method(this.str, symbol) : throw new ArgumentException("Method must not be null");
        public int SearchNumberOfUsesSymbol(char symbol) => SearchNumberOfUsesSymbol(this.str, symbol);
        public static int SearchNumberOfUsesSymbol(string str, char symbol)
        {
            if (str == null)
                throw new NullReferenceException("Str must not be null");
            int numberOfUses = 0;
            for (int i = 0; i < str.Length; i++)
                if (str[i] == symbol)
                    numberOfUses++;
            return numberOfUses;
        }
        private string str;
    }
}
