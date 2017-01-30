using System;

namespace CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            PrintClosePoint (x1,y1,x2,y2);
        }

        private static void PrintClosePoint(double x1, double y1, double x2, double y2)
        {
            var distance1 = Math.Sqrt(Math.Abs(x1 * x1) + Math.Abs(y1 * y1));
            var distance2 = Math.Sqrt(Math.Abs(x2 * x2) + Math.Abs(y2 * y2));
            if (distance2<distance1)
            {
                Console.WriteLine("({0}, {1})", x2, y2);
            }
            else
            {
                Console.WriteLine("({0}, {1})", x1, y1);
            }

        }
    }
}
