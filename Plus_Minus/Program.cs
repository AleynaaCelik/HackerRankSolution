using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        PlusMinus(arr);
    }

    static void PlusMinus(int[] arr)
    {
        int length = arr.Length;
        double positiveCount = arr.Count(x => x > 0);
        double negativeCount = arr.Count(x => x < 0);
        double zeroCount = arr.Count(x => x == 0);

        Console.WriteLine((positiveCount / length).ToString("F6"));
        Console.WriteLine((negativeCount / length).ToString("F6"));
        Console.WriteLine((zeroCount / length).ToString("F6"));
    }
}
