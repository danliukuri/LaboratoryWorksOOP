using System;

namespace Laboratory_work_4_Cs
{
    class Square
    {
        public Square()
        {
            double[,] defaultCoord = { { 0, 1 }, { 1, 1 }, { 1, 0 }, { 0, 0 } };
            coordinatesSquare = defaultCoord;
        }
        public Square(double[,] coordinatesSquare)
        {
            this.coordinatesSquare = coordinatesSquare;
        }
        public Square(double area)
        {
            double l = Math.Sqrt(area);
            double[,] defaultCoord = { { 0, l }, { l, l }, { l, 0 }, { 0, 0 } };
            coordinatesSquare = defaultCoord;
        }
        public Square(Square other)
        {
            coordinatesSquare = new double[4,2];
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 2; j++)
                    coordinatesSquare[i, j] = other.coordinatesSquare[i, j];
        }

        public double Area()
        {
            double[] vecLength = { coordinatesSquare[1, 0] - coordinatesSquare[0, 0], coordinatesSquare[1, 1] - coordinatesSquare[0, 1] };
            double length = Math.Sqrt(Math.Pow(vecLength[0], 2) + Math.Pow(vecLength[1], 2));
            return Math.Pow(length, 2);
        }
        public double Perimeter()
        {
            double[] vecLength = { coordinatesSquare[1, 0] - coordinatesSquare[0, 0], coordinatesSquare[1, 1] - coordinatesSquare[0, 1] };
            double length = Math.Sqrt(Math.Pow(vecLength[0], 2) + Math.Pow(vecLength[1], 2));
            return length * 4;
        }
        public double[,] GetCoordinates()
        {
            return coordinatesSquare;
        }

        public static Square operator +(Square sq, int squareUnits)
        {
            double l = (Math.Sqrt(sq.Area() + squareUnits) - Math.Sqrt(sq.Area())) / 2;
            Square newsq = new Square(sq);

            newsq.coordinatesSquare[0, 0] -= l;
            newsq.coordinatesSquare[0, 1] += l;
            newsq.coordinatesSquare[1, 0] += l;
            newsq.coordinatesSquare[1, 1] += l;
            newsq.coordinatesSquare[2, 0] += l;
            newsq.coordinatesSquare[2, 1] -= l;
            newsq.coordinatesSquare[3, 0] -= l;
            newsq.coordinatesSquare[3, 1] -= l;

            return newsq;
        }
        public static Square operator +(int squareUnits, Square sq)
        {
            return sq + squareUnits;
        }
        public static Square operator /(Square sq1, Square sq2)
        {
            Square newsq = new Square(sq1.Area() / sq2.Area());
            return newsq;
        }

        private double[,] coordinatesSquare;
    }
}