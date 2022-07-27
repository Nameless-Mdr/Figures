using System;

namespace Figures
{
    public class Circle : Figure
    {
        private double Radius { get; set; }

        public Circle() { }

        public Circle(double rad)
        {
            if (IsValid(rad))
                Radius = rad;
            else
                throw new ArgumentException("Incorrect values");
        }

        private bool IsValid(double r)
        {
            return r > 0;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override double Square()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
