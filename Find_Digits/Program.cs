using System;
using System.Collections.Generic;

class Solution
{
    public static int findDigits(int n)
    {
        int count = 0;
        int temp = n;

        while (temp > 0)
        {
            int digit = temp % 10;
            if (digit != 0 && n % digit == 0)
            {
                count++;
            }
            temp /= 10;
        }

        return count;
    }

    public static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> results = new List<int>();

        for (int i = 0; i < t; i++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            int result = findDigits(n);
            results.Add(result);
        }

        foreach (int result in results)
        {
            Console.WriteLine(result);
        }
    }
}
