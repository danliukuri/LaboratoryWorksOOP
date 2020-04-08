
namespace Laboratory_work_5_Cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
        }

        static void Task1()
        {
            char[] line = { 'a', 'b', 'c', 'd', 'e', '!' };
            Str s = new Str(line);
            int len = s.GetLength();

            char[] digitLine = { '1', '2', 'a', '3', 'b', 'c', '4', '5' };
            DigitalStr dS = new DigitalStr(digitLine);
            len = dS.GetDigitLength();

            int[] ds = dS.GetDigitStr();
            dS.ReverseDigitStr();
        }

        static void Task2()
        {
            double[,] coord = { { 0, 0 }, { 0, 1 }, { 1, 0 } };
            Shape t = new Triangle(coord);
            double at = t.GetArea();
            double pt = t.GetPerimeter();

            Shape c = new Circle(5);
            double ac = c.GetArea();
            double pc = c.GetPerimeter();
        }
    }
}
