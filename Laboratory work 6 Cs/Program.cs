using System;

namespace Laboratory_work_6_Cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Expression[] exampleArr = new Expression[100];
            double[] result = new double[exampleArr.Length];
            string[] logList = new string[exampleArr.Length + 1];

            var rand = new Random();
            for (int i = 0; i < exampleArr.Length; i++)
                exampleArr[i] = new Expression(rand.Next(-5, 5), rand.Next(-5, 5), rand.Next(-5, 5));

            
            try
            {
                int value = 10;
                exampleArr[0] = new Expression(-1, 0, checked(2147483647 + value));
            }
            catch (OverflowException ex)
            {
                logList[0] = ex.Message;
            }

            for (int i = 1; i < exampleArr.Length + 1; i++)
            {
                try
                {
                    result[i] = exampleArr[i].GetResult();
                    logList[i] = "Success";
                }
                catch (Exception ex)
                {
                    logList[i] = ex.Message;
                }
            }
        }
    }
}
