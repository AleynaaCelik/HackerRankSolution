using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    /*
     * Complete the 'birthday' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. List<int> s
     *  2. int d
     *  3. int m
     */
    public static int birthday(List<int> s, int d, int m)
    {
        int count = 0;

        // Iterate through the chocolate squares
        for (int i = 0; i <= s.Count - m; i++)
        {
            // Calculate the sum of the current segment
            int sum = 0;
            for (int j = i; j < i + m; j++)
            {
                sum += s[j];
            }

            // Check if the sum matches Ron's birthday
            if (sum == d)
            {
                count++;
            }
        }

        return count;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        // Girdiyi dosyadan değil, konsoldan okuyacak şekilde ayarladık.
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> s = Console.ReadLine().TrimEnd().Split(' ').Select(int.Parse).ToList();

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int d = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);

        int result = Result.birthday(s, d, m);

        Console.WriteLine(result);
    }
}
