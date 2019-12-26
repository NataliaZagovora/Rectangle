using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle R = new Rectangle(1, 3);
            R.SquareCalculation(R.Side1, R.Side2);
            Console.Write("Square rectangle: " + R.Square);
            R.PerimeterCalculation(R.Side1, R.Side2);
            Console.WriteLine();
            Console.Write("Perimeter rectangle: " + R.Perimeter);
            Console.WriteLine();
            Console.WriteLine("**********************************");
            Console.Write("Enter x=");
            R.Side1 = double.Parse(Console.ReadLine());
            Console.Write("Enter y=");
            R.Side2 = double.Parse(Console.ReadLine());
            R.SquareCalculation(R.Side1, R.Side2);
            Console.Write("Square rectangle: " + R.Square);
            R.PerimeterCalculation(R.Side1, R.Side2);
            Console.WriteLine();
            Console.Write("Perimeter rectangle: " + R.Perimeter);
            Console.WriteLine();
        }
    }
}
