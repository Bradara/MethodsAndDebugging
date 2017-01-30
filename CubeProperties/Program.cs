using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            var side = double.Parse(Console.ReadLine());
            var property = Console.ReadLine();

            Console.WriteLine("{0:f2}", CalcProperties(side, property));
        }

        private static double CalcProperties(double side, string property)
        {
            double result = 0;
            switch (property.ToLower())
            {
                case "area":
                    result = side * side*6; break;
                case "face":
                    result = Math.Sqrt(2 * side * side);break;
                case "volume":
                    result = side * side * side;break;
                case "space":
                    var faceDiagonal = Math.Sqrt(2 * side * side);
                    result = Math.Sqrt(faceDiagonal * faceDiagonal + side * side); break;
                default: Console.WriteLine("Enter correct property"); break;
            }
            return result;
        }
    }
}
