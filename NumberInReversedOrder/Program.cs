namespace NumberInReversedOrder
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            decimal output = Reverse(input);
            Console.WriteLine(output);

        }

        private static decimal Reverse(string input)
        {

            decimal reversed = decimal.Parse(string.Join("", input.Reverse().ToArray()));
            return reversed;
        }
    }
}
