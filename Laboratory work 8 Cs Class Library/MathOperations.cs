using System;

namespace Laboratory_work_8_Cs_Class_Library
{
    public class MathOperations
    {
        public delegate double Operation(double value1, double value2);
        public delegate void OperationHandler(string message);
        public event OperationHandler IntegerDivision;

        public double DoOperation(double value1, double value2, Operation operation)
        {
            if (operation == null)
                throw new NullReferenceException("Operation must not be null");
            return operation(value1, value2);
        }

        public double Add(double value1, double value2) => value1 + value2;
        public double Subtract(double value1, double value2) => value1 - value2;
        public double Multiply(double value1, double value2) => value1 * value2;
        public double Divide(double value1, double value2)
        {
            if (value2 == 0)
                throw new DivideByZeroException("Value2 must not be 0");
            if (value1 - (int)value1 == 0 && value2 - (int)value2 == 0)
            {
                if (IntegerDivision != null)
                    IntegerDivision("Integer division");
                else
                    throw new NullReferenceException("Event IntegerDivision must not be null");
            }

            return value1 / value2;
        }
        public double Pow(double value1, double value2) => Math.Pow(value1, value2);
    }
}
