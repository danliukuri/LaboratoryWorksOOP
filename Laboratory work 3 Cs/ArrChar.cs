namespace Laboratory_work_3_Cs
{
    class ArrChar
    {
        public char this[int index]
        {
            set
            {
                int length = (index > 0 && arr != null) ? arr.Length : 0;

                //if (index > 0 && arr != null)
                //    length = arr.Length;
                //else
                //    length = 0;

                if (index == length)
                {
                    char[] temp = arr;
                    arr = new char[index + 1];

                    for (int i = 0; i < length; i++)
                        arr[i] = temp[i];

                    this.index = index;
                    arr[index] = value;
                }
            }
            get
            {
                if (arr != null)
                    if ((index >= 0) && (index < arr.Length))
                        return char.ToUpper(arr[index]);
                return '0';
            }
        }
        public int NumberOfVowels
        {
            get
            {
                char[] vowels = { 'й', 'у', 'е', 'ъ', 'ы', 'а', 'о', 'э', 'я', 'и', 'ь', 'ю',//ru
                                  'е', 'и', 'і', 'о', 'у', 'я', 'ю', 'є', 'ї',               //ukr
                                  'a', 'e', 'i', 'o', 'u', 'y' };                            //eng

                for (int i = 0; i < arr.Length; i++)
                    if (arr[i] != '\0')
                        for (int j = 0; j < vowels.Length; j++)
                            if (char.ToLower(arr[i]) == vowels[j])
                                numberOfVowels++;
                return numberOfVowels;
            }
        }
        private char[] arr;
        private int index;
        private int numberOfVowels;
    }

    class ArrCharTwoRealization
    {
        public ArrCharTwoRealization(int lenght)
        {
            arr = new char[lenght];
        }
        public char this[int index]
        {
            set
            {
                if ((index >= 0) && (index < arr.Length))
                {
                    this.index = index;
                    arr[index] = value;
                }
            }
            get
            {
                if ((index >= 0) && (index < arr.Length))
                    return char.ToUpper(arr[index]);
                return '0';
            }

        }
        public int NumberOfVowels
        {
            get
            {
                char[] vowels = { 'й', 'у', 'е', 'ъ', 'ы', 'а', 'о', 'э', 'я', 'и', 'ь', 'ю',
                                  'е', 'и', 'і', 'о', 'у', 'я', 'ю', 'є', 'ї',
                                  'a', 'e', 'i', 'o', 'u', 'y' };

                for (int i = 0; i < arr.Length; i++)
                    if (arr[i] != '\0')
                        for (int j = 0; j < vowels.Length; j++)
                            if (char.ToLower(arr[i]) == vowels[j])
                                numberOfVowels++;
                return numberOfVowels;
            }
        }
        private char[] arr;
        private int index;
        private int numberOfVowels;
    }
}