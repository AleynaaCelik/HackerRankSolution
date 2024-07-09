using System;

public class Program
{
    public static void Main()
    {
        // Reading the size of the matrix (assuming it's a square matrix)
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        // Initializing the matrix
        int[,] arr = new int[n, n];

        // Reading matrix elements
        for (int i = 0; i < n; i++)
        {
            string[] arrRowTempItems = Console.ReadLine().Trim().Split(' ');
            for (int j = 0; j < n; j++)
            {
                arr[i, j] = Convert.ToInt32(arrRowTempItems[j]);
            }
        }

        // Calculating the sum of the primary diagonal
        int primaryDiagonalSum = 0;
        for (int i = 0; i < n; i++)
        {
            primaryDiagonalSum += arr[i, i];
        }

        // Calculating the sum of the secondary diagonal
        int secondaryDiagonalSum = 0;
        for (int i = 0; i < n; i++)
        {
            secondaryDiagonalSum += arr[i, n - 1 - i];
        }

        // Calculating the absolute difference between the sums
        int absoluteDifference = Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);

        // Outputting the result
        Console.WriteLine(absoluteDifference);
    }
}
