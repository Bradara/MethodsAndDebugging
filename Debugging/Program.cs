using System;
using System.Linq;

public class SequenceOfCommands_broken
{
    private const char ArgumentsDelimiter = ' ';

    public static void Main()
    {
        int sizeOfArray = int.Parse(Console.ReadLine());

        long[] array = Console.ReadLine()
            .Split(ArgumentsDelimiter)
            .Select(long.Parse)
            .ToArray();

        string command = Console.ReadLine();

        while (command != "stop")
        {
            string[] line = command.Split(ArgumentsDelimiter);
            int[] args = new int[2];

            if (line[0] == ("add") ||
                line[0] == ("subtract") ||
                line[0] == ("multiply"))
            {
                //string[] stringParams = line.Split(ArgumentsDelimiter);
                args[0] = int.Parse(line[1]);
                args[1] = int.Parse(line[2]);

                array = PerformAction(array, line[0], args);
            }
            else
            {
                array = PerformAction(array, line[0], args);
            }
            PrintArray(array);
            //Console.WriteLine('\n');

            command = Console.ReadLine();
        }
    }

    static long[] PerformAction(long[] arr, string action, int[] args)
    {
        //long[] array = arr.Clone() as long[];
        int pos = args[0] - 1;
        int value = args[1];

        switch (action)
        {
            case "multiply":
                arr[pos] *= value;
                break;
            case "add":
                arr[pos] += value;
                break;
            case "subtract":
                arr[pos] -= value;
                break;
            case "lshift":
                arr = ArrayShiftLeft(arr);
                break;
            case "rshift":
                arr = ArrayShiftRight(arr);
                break;
        }
        return arr;
    }

    private static long[] ArrayShiftRight(long[] array)
    {
        long temp = array[array.Length - 1];
        for (int i = array.Length - 1; i >= 1; i--)
        {
            array[i] = array[i - 1];
        }
        array[0] = temp;
        return array;
    }

    private static long[] ArrayShiftLeft(long[] array)
    {
        long temp = array[0];
        for (int i = 0; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }
        array[array.Length - 1] = temp;
        return array;
    }

    private static void PrintArray(long[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}
