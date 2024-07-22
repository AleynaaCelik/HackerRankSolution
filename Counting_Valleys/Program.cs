using System;
using System.IO;

class Result
{
    /*
     * Complete the 'countingValleys' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER steps
     *  2. STRING path
     */
    public static int countingValleys(int steps, string path)
    {
        int seaLevel = 0;
        int valleys = 0;
        int currentLevel = 0;

        foreach (char step in path)
        {
            if (step == 'U')
            {
                currentLevel++;
                // Eğer deniz seviyesine geri dönülürse, bir vadi tamamlanmıştır.
                if (currentLevel == 0)
                {
                    valleys++;
                }
            }
            else if (step == 'D')
            {
                currentLevel--;
            }
        }

        return valleys;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int steps = Convert.ToInt32(Console.ReadLine().Trim());

        string path = Console.ReadLine();

        int result = Result.countingValleys(steps, path);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
