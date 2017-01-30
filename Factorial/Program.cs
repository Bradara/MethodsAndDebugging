using System;
using System.Numerics;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger  n = int.Parse(Console.ReadLine());
           // Console.WriteLine(Factorial(n));
            Console.WriteLine(TrailingZeros(Factorial(n)));
        }

        private static int TrailingZeros(BigInteger input)
        {
            int count = 0;
            for (BigInteger i = input; i > 0; i=i/10)
            {
                if (i%10==0)
                {
                    count++;
                }
                else
                {
                    return count;
                }
            }
            return count;
        }

        private static BigInteger Factorial(BigInteger n)
        {
            if (n<2)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
    }
}
