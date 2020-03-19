namespace Laboratory_work_3_Cs
{
    class ArrChar
    {
        public ArrChar(int lenght)
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