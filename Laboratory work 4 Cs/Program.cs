
namespace Laboratory_work_4_Cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Square k1 = new Square();

            double[,] coordS2 = { { 0, 2 }, { 2, 2 }, { 2, 0 }, { 0, 0 } };
            Square k2 = new Square(coordS2);
            double a2 = k2.Area();
            double p2 = k2.Perimeter();

            Square k3 = 5 + k2;
            double a3 = k3.Area();

            Square k4 = k3 / k2;
            double a4 = k4.Area();
        }
    }
}
