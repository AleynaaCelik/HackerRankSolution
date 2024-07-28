using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{

    // Complete the migratoryBirds function below.
    static int migratoryBirds(int[] arr)
    {
        Dictionary<int, int> birdCounts = new Dictionary<int, int>();

        // Count the frequency of each bird type
        foreach (var bird in arr)
        {
            if (birdCounts.ContainsKey(bird))
            {
                birdCounts[bird]++;
            }
            else
            {
                birdCounts[bird] = 1;
            }
        }

        // Find the bird type with the highest frequency
        int maxCount = 0;
        int minTypeId = int.MaxValue;

        foreach (var kvp in birdCounts)
        {
            if (kvp.Value > maxCount)
            {
                maxCount = kvp.Value;
                minTypeId = kvp.Key;
            }
            else if (kvp.Value == maxCount && kvp.Key < minTypeId)
            {
                minTypeId = kvp.Key;
            }
        }

        return minTypeId;
    }

    static void Main(string[] args)
    {
        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        int result = migratoryBirds(arr);

        Console.WriteLine(result);
    }
}
