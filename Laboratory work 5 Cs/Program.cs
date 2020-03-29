
namespace Laboratory_work_5_Cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Task2();
        }

        static void Task1()
        {
            char[] line = { 'a', 'b', 'c', 'd', 'e', '!' };
            Str s = new Str(line);
            int len = s.GetLength();

            char[] digitLine = { '5', '4', '4', '1', '2' };
            DigitalStr dS = new DigitalStr(digitLine);
            len = dS.GetLength();

            int[] ds = dS.GetDigitStr();
            dS.ReverseDigitStr();
            int[] dsRev = dS.GetDigitStr();
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
