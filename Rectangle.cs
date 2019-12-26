using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Rectangle
    {
        private double side1, side2;
        private double square, perimeter;

        public double Side1
        {
            get
            { return side1; }
            set
            {
                side1 = value;
            }

        }
        public double Side2
        {
            get
            { return side2; }
            set
            {
                side2 = value;
            }

        }

        public double Square
        {
            get
            { return square; }
        }
        public double Perimeter
        {
            get
            { return perimeter; }
        }
        public Rectangle()
        { }
        public Rectangle(double x, double y)
        {
            Side1 = x;
            Side2 = y;
        }
        public void SquareCalculation(double x, double y)
        {
            if (x > 0 && y > 0)
                square = x * y;
            else
                square = -1;
        }
        public void PerimeterCalculation(double x, double y)
        {
            if (x > 0 && y > 0)
                perimeter = 2 * (x + y);
            else
                perimeter = -1;
        }

    }
}
