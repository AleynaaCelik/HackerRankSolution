using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Read the input values
        int n = int.Parse(Console.ReadLine());
        int[] s = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] dm = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int d = dm[0];
        int m = dm[1];

        // Calculate the number of ways the chocolate can be divided
        int result = Birthday(s, d, m);
        Console.WriteLine(result);
    }

    static int Birthday(int[] s, int d, int m)
    {
        int count = 0;

        // Iterate through the chocolate squares
        for (int i = 0; i <= s.Length - m; i++)
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
