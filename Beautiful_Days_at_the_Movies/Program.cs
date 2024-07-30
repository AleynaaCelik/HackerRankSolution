using System;
using System.IO;

class Result
{
    /*
     * Complete the 'beautifulDays' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER i (starting day number)
     *  2. INTEGER j (ending day number)
     *  3. INTEGER k (divisor)
     */
    public static int beautifulDays(int i, int j, int k)
    {
        int beautifulCount = 0;

        for (int day = i; day <= j; day++)
        {
            int reversedDay = ReverseNumber(day);
            int difference = Math.Abs(day - reversedDay);

            if (difference % k == 0)
            {
                beautifulCount++;
            }
        }

        return beautifulCount;
    }

    // Helper function to reverse the digits of a number
    public static int ReverseNumber(int num)
    {
        int reversed = 0;
        while (num > 0)
        {
            int remainder = num % 10;
            reversed = (reversed * 10) + remainder;
            num /= 10;
        }
        return reversed;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        // Sample input: "20 23 6"
        string[] input = Console.ReadLine().Trim().Split(' ');

        int i = Convert.ToInt32(input[0]);
        int j = Convert.ToInt32(input[1]);
        int k = Convert.ToInt32(input[2]);

        int result = Result.beautifulDays(i, j, k);

        Console.WriteLine(result);
    }
}
