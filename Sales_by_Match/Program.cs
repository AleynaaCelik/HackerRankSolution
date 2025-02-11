﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    /*
     * Complete the 'sockMerchant' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY ar
     */
    public static int sockMerchant(int n, List<int> ar)
    {
        Dictionary<int, int> colorCounts = new Dictionary<int, int>();
        int pairs = 0;

        foreach (var sock in ar)
        {
            if (colorCounts.ContainsKey(sock))
            {
                colorCounts[sock]++;
            }
            else
            {
                colorCounts[sock] = 1;
            }
        }

        foreach (var count in colorCounts.Values)
        {
            pairs += count / 2;
        }

        return pairs;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        int result = Result.sockMerchant(n, ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
