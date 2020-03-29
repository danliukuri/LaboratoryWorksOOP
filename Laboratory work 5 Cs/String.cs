
namespace Laboratory_work_5_Cs
{
    public class Str
    {
        public Str(char[] line)
        {
            str = new char[line.Length + 1];
            str[line.Length] = '\0';
            for (int i = 0; i < line.Length; i++)
                str[i] = line[i];
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
            intStr = new int[this.GetLength()];
            for (int i = 0; i < this.GetLength(); i++)
            {
                if (char.IsDigit(str[i]))
                    intStr[i] = str[i] - '0';
                else
                    intStr[i] = 0;
            }
        }
        public int[] GetDigitStr()
        {
            return intStr;
        }
        public void ReverseDigitStr()
        {
            for (int i = 0; i < this.GetLength() / 2; i++)
            {
                int temp = intStr[i];
                intStr[i] = intStr[this.GetLength() - 1 - i];
                intStr[this.GetLength() - 1 - i] = temp;
            }
        }
        private int[] intStr;
    }
}
