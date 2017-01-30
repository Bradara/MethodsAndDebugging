using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] masterNumber = Simetric(n);
            masterNumber = DivideTo7(masterNumber);
            masterNumber = EvenList(masterNumber);
            foreach (var item in masterNumber)
            {
                Console.WriteLine(item);
            }
        }

        private static int[] EvenList(int[] input)
        {
            List<int> even = new List<int>();
            foreach (var item in input)
            {
                var testForEven = item;
                while (testForEven>0)
                {                    
                    if (testForEven%2 == 0)
                    {
                        even.Add(item);
                        break;
                    }
                    testForEven /= 10;
                }
            }
            int[] result = even.ToArray();
            even.Clear();
            return result;
        }

        private static int[] DivideTo7(int[] input)
        {
            var sumDivideTo7 = new List<int>();
            foreach (int item in input)
            {
                int sum = 0, num = item;
                while (num > 0)
                {
                    sum += num % 10;
                    num /= 10;
                }
                if (sum%7==0)
                {
                    sumDivideTo7.Add(item);
                }
            }
            int[] result = sumDivideTo7.ToArray();
            sumDivideTo7.Clear();
            return result;
        }

        private static int[] Simetric(int n)
        {
            List<int> palindrom = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                var j = Convert.ToString(i);
                bool isPalindrom = true;
                for (int k = 0; k < j.Length; k++)
                {                    
                    if (j[k]!=j[j.Length-1-k])
                    {
                        isPalindrom = false;
                        break;
                    }
                }
                if (isPalindrom)
                {
                    palindrom.Add(i);
                }
            }
            int[] palArray = palindrom.ToArray();
            return palArray;
        }
    }
}
