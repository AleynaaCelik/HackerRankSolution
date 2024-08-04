using System;
using System.Collections.Generic;
using System.Linq;

class Result
{
    /*
     * Complete the 'cutTheSticks' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static List<int> cutTheSticks(List<int> arr)
    {
        List<int> result = new List<int>();

        while (arr.Count > 0)
        {
            result.Add(arr.Count);
            int minVal = arr.Min();
            arr = arr.Where(x => x > minVal).ToList();
        }

        return result;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> result = Result.cutTheSticks(arr);

        Console.WriteLine(string.Join("\n", result));
    }
}
