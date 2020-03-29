using System;

namespace Laboratory_work_5_Cs
{
    abstract class Shape
    {
        public abstract double GetArea();
        public abstract double GetPerimeter();
    }

    class Triangle:Shape
    {
        public Triangle(double[,] coordinates)
        {
            if(coordinates.GetLength(dimension: 0) != 3 || coordinates.GetLength(dimension: 1) != 2)
                throw new Exception("This is not a triangle");
            this.coordinates = coordinates;
        }
        public override double GetArea()
        {
            return Math.Abs(0.5 * (coordinates[0, 0] * coordinates[0, 1] - coordinates[0, 1] * coordinates[1, 0] + coordinates[1, 0] * coordinates[2, 1] -
                                   coordinates[1, 1] * coordinates[2, 0] + coordinates[2, 0] * coordinates[0, 1] - coordinates[2, 1] * coordinates[0, 0]));
        }
        public override double GetPerimeter()
        {
            return Math.Sqrt(Math.Pow(coordinates[0, 0] - coordinates[1, 0], 2) + Math.Pow(coordinates[0, 1] - coordinates[1, 1], 2)) +
                   Math.Sqrt(Math.Pow(coordinates[1, 0] - coordinates[2, 0], 2) + Math.Pow(coordinates[1, 1] - coordinates[2, 1], 2)) +
                   Math.Sqrt(Math.Pow(coordinates[2, 0] - coordinates[0, 0], 2) + Math.Pow(coordinates[2, 1] - coordinates[0, 1], 2));
        }
        private double[,] coordinates;
    }

    class Circle : Shape
    {
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new Exception("This is not a circle");
            this.radius = radius;
        }
        public override double GetArea()
        {
            return Math.Pow(radius, 2);
        }
        public override double GetPerimeter()
        {
            return 2 * Math.PI * radius;
        }
        private double radius;
    }
}
