using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    /*
     * Complete the pickingNumbers function below.
     */
    static int pickingNumbers(List<int> a)
    {
        int[] frequency = new int[101];
        foreach (int number in a)
        {
            frequency[number]++;
        }

        int maxLength = 0;
        for (int i = 1; i < 100; i++)
        {
            maxLength = Math.Max(maxLength, frequency[i] + frequency[i + 1]);
        }

        return maxLength;
    }

    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = pickingNumbers(a);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
