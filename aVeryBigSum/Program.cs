using System;
using System.Collections.Generic;
using System.Linq;

class Result
{
   

    public static long aVeryBigSum(List<long> ar)
    {
        long totalSum = 0;
        foreach (long num in ar)
        {
            totalSum += num;
        }
        return totalSum;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int arCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<long> ar = Console.ReadLine().TrimEnd().Split(' ').Select(long.Parse).ToList();

        long result = Result.aVeryBigSum(ar);

        Console.WriteLine(result);
    }
}

