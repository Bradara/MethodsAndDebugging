using System;

namespace LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var x3 = double.Parse(Console.ReadLine());
            var y3 = double.Parse(Console.ReadLine());
            var x4 = double.Parse(Console.ReadLine());
            var y4 = double.Parse(Console.ReadLine());
            double line1 = CalcRange(x1, y1, x2, y2);
            double line2 = CalcRange(x3, y3, x4, y4);

            if (line2 > line1)
            {
                PrintClosePoint(x3, y3, x4, y4);
                PrintFarPoint(x3, y3, x4, y4);
            }
            else
            {
                PrintClosePoint(x1, y1, x2, y2);
                PrintFarPoint(x1, y1, x2, y2);
            }
        }

        private static void PrintFarPoint(double x1, double y1, double x2, double y2)
        {
            var distance1 = Math.Sqrt(Math.Abs(x1 * x1) + Math.Abs(y1 * y1));
            var distance2 = Math.Sqrt(Math.Abs(x2 * x2) + Math.Abs(y2 * y2));
            if (distance2 >= distance1)
            {
                Console.Write("({0}, {1})", x2, y2);
            }
            else
            {
                Console.Write("({0}, {1})", x1, y1);
            }
        }

        private static double CalcRange(double x1, double y1, double x2, double y2)
        {
            var x = Math.Abs(x1 - x2);
            var y = Math.Abs(y1 - y2);
            var range = Math.Sqrt(x * x + y * y);
            return range;
        }

        private static void PrintClosePoint(double x1, double y1, double x2, double y2)
        {
            var distance1 = Math.Sqrt(Math.Abs(x1 * x1) + Math.Abs(y1 * y1));
            var distance2 = Math.Sqrt(Math.Abs(x2 * x2) + Math.Abs(y2 * y2));
            if (distance2 < distance1)
            {
                Console.Write("({0}, {1})", x2, y2);
            }
            else
            {
                Console.Write("({0}, {1})", x1, y1);
            }

        }
    }
}
