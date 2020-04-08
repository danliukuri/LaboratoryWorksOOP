
namespace Laboratory_work_5_Cs
{
    public class Str
    {
        public Str(char[] line)
        {
            str = new char[line.Length+1];
            line.CopyTo(str, 0);
        }
        public int GetLength()
        {
            int strLength = 0;
            while (str[strLength] != '\0')
                strLength++;
            return strLength;
        }
        public char[] GetString()
        {
            return str;
        }
        protected char[] str;
    }

    public class DigitalStr : Str
    {
        public DigitalStr(char[] line) : base(line)
        {
            intStr = new int[GetDigitLength()];
            int i = 0, j = 0;
            while (j < GetLength())
            {
                if (char.IsDigit(str[j]))
                {
                    intStr[i] = str[j] - '0';
                    i++;
                }
                j++;
            }
        }
        public int[] GetDigitStr()
        {
            return intStr;
        }
        public int GetDigitLength()
        {
            int len = 0;
            for (int i = 0; i < GetLength(); i++)
                if (char.IsDigit(str[i]))
                    len++;
            return len;
        }
        public void ReverseDigitStr()
        {
            for (int i = 0; i < GetDigitLength() / 2; i++)
            {
                int temp = intStr[i];
                intStr[i] = intStr[GetDigitLength() - 1 - i];
                intStr[GetDigitLength() - 1 - i] = temp;
            }
        }
        private int[] intStr;
    }
}
