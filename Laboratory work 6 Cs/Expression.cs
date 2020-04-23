using System;

namespace Laboratory_work_6_Cs
{
    class Expression
    {
        public Expression(int a, int c, int d)
        {
            this.a = a;
            this.c = c;
            this.d = d;
        }
        public double GetResult()
        {
            if (2 * c - a <= 0)
                throw new ArithmeticException("Expression 2*c-a must be more than 0");

            double divider = (double)(a) / 4 + c;

            if (divider == 0)
                throw new DivideByZeroException("Expression a/4+c should not be 0");

            double dividend = Math.Log10(2 * c - a) + d - 152;
            return dividend / divider;
        }
        private int a, c, d;
    }
}
