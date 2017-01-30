using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();
            double side, height, radius;

            switch (figureType)
            {
                case "triangle":
                    side = double.Parse(Console.ReadLine());
                    height = double.Parse(Console.ReadLine());
                    PrintArea(side, height, figureType); break;
                case "rectangle":
                    side = double.Parse(Console.ReadLine());
                    height = double.Parse(Console.ReadLine());
                    PrintArea(side, height, figureType); break;   
                case "square":
                    side = double.Parse(Console.ReadLine());
                    PrintArea(side, figureType);break;
                case "circle":
                    radius = double.Parse(Console.ReadLine());
                    PrintArea(radius, figureType); break;
                default:
                    break;
            }
        }

        private static void PrintArea(double side, string figureType)
        {
            if (figureType == "square")
            {
                Console.WriteLine("{0:f2}", side*side);
            }
            else
            {
                Console.WriteLine("{0:f2}", Math.PI*side*side);
            }
        }

        private static void PrintArea(double side, double height, string figureType)
        {
            if (figureType == "triangle")
            {
                Console.WriteLine("{0:f2}", side*height/2);
            }
            else
            {
                Console.WriteLine("{0:f2}", side*height);
            }
        }
    }
}
