using System;

namespace Figures
{
    public class Triangle : Figure
    {
        private double Side1 { get; set; }

        private double Side2 { get; set; }

        private double Side3 { get; set; }

        public Triangle() { }

        public Triangle(double a, double b, double c)
        {
            if (IsValid(a, b, c))
                (Side1, Side2, Side3) = (a, b, c);
            else
                throw new ArgumentException("Incorrect values");
        }

        private bool IsValid(double a, double b, double c)
        {
            if (a >= b + c)
                return false;

            if (b >= a + c)
                return false;

            if (c >= a + b)
                return false;

            return a > 0 && b > 0 && c > 0;
        }

        public bool IsRightTriangle()
        {
            if (Side1 * Side1 == Side2 * Side2 + Side3 * Side3)
                return true;

            if (Side2 * Side2 == Side1 * Side1 + Side3 * Side3)
                return true;

            if (Side3 * Side3 == Side2 * Side2 + Side1 * Side1)
                return true;

            return false;
        }

        public override double Perimeter()
        {
            return Side1 + Side2 + Side3;
        }

        public override double Square()
        {
            var p = this.Perimeter() / 2;

            return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
        }
    }
}
