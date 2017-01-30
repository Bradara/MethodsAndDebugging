namespace IsPrime
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            long startNum = long.Parse(Console.ReadLine());
            long endNum = long.Parse(Console.ReadLine());

            List<long> primeInRange = new List<long>();
            primeInRange = Prime(startNum, endNum);
            Console.WriteLine(String.Join(", ", primeInRange));
        }
        private static List<long> Prime(long n, long m)
        {
            List<long> prime = new List<long>();
            
            for (long i = n; i <=m; i++)
            {
                if (IsPrime(i))
                {
                    prime.Add(i);
                }
                
            }
            return prime; 
        }

        private static bool IsPrime(long x)
        {
            bool isPrime = true;
            if (x < 2) isPrime = false;
            for (long i = 2 ; i <= Math.Sqrt(x); i++)
            {
                if (x%i ==0)
                {
                    isPrime = false;
                }
            }
            return isPrime;
        }
    }
}
