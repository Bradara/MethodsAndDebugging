namespace EngNameLastDigit
{
    using System;
    class EngNameLastDigit
    {
        public enum Digit
        {
            zero, one, two, three, four, five, six, seven, eight, nine
        }
        static void Main()
        {
            string num = Console.ReadLine();
            int lastDigit = int.Parse(num[num.Length - 1].ToString());
            Console.WriteLine((Digit)lastDigit);

        }
    }
}
