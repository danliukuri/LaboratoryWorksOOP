
namespace Laboratory_work_2
{
    public class Str
    {
        private char[] str;
        public Str(char[] line)
        {
            str = new char[line.Length];
            str = line;
        }
        public bool ConsistSubline(char[] subline) // Перевірка чи рядок містить заданий підрядок
        {
            if (subline.Length > str.Length)
                return false;
            bool flag = false;
            int i = 0, j = 0;
            while (i < str.Length && j < subline.Length)
            {
                if (str[i] != subline[j])
                {
                    j--;
                    flag = false;
                }
                else
                    flag = true;
                if (j != subline.Length - 1)
                    flag = false;
                i++;
                j++;
            }
            return flag;
        }
        public void ClearStr()
        {
            str = null;
        }
        public int GetLength() // Отримання довжини рядка
        {
            return str.Length;
        }
        public void UppFirstLetter() // Приведення першої літери до верхнього регістру
        {
            for (int i = 0; i < str.Length; i++)
                if (char.IsLetter(str[i]))
                {
                    str[i] = char.ToUpper(str[i]);
                    for (int j = i; j < str.Length; j++)
                    {
                        if (char.IsSeparator(str[j]))
                        {
                            i = j;
                            j = str.Length;
                        }
                        else
                            i = str.Length;
                    }
                }
        }
    }
    public class Text
    {
        private Str[] text;
        public Text(char[][] strArr)
        {
            text = new Str[strArr.Length];
            for (int i = 0; i < strArr.Length; i++)
                text[i] = new Str(strArr[i]);
        }
        public void AddNewLine(char[] newLine) // Додавання рядка до тексту 
        {
            Str[] temp = new Str[text.Length + 1];
            for (int i = 0; i < text.Length; i++)
                temp[i] = text[i];
            temp[text.Length] = new Str(newLine);
            text = temp;
        }
        public void DelLine(int lineNumber) // Видалення рядка з тексту 
        {
            for (int i = 0; i < text.Length; i++)
                if (i == lineNumber - 1)
                {
                    Str[] temp = new Str[text.Length - 1];
                    for (int a = 0, b = 0; a < text.Length; a++, b++)
                    {
                        if (a == i)
                            b--;
                        else
                            temp[b] = text[a];
                    }
                    text = temp;
                }
        }
        public void DelLinesWithSubline(char[] subline) // Видалення рядків, що містять заданий підрядок 
        {
            for (int i = 0; i < text.Length; i++)
                if (text[i].ConsistSubline(subline))
                    DelLine(i + 1);
        }
        public void Clear() // Очищення тексту 
        {
            for (int i = 0; i < text.Length; i++)
            {
                text[i].ClearStr();
            }
            text = null;
        }
        public int GetMaxLength() // Отримання довжини найдовшого рядка 
        {
            int maxLen = text[0].GetLength();
            for (int i = 1; i < text.Length; i++)
                if (text[i].GetLength() > maxLen)
                    maxLen = text[i].GetLength();
            return maxLen;
        }
        public void UppFirstLetter() // Приведення перших літер усіх слів тексту до верхнього регістру 
        {
            for (int i = 0; i < text.Length; i++)
                text[i].UppFirstLetter();
        }
    }
}