using System;

class Program
{
    static void Main()
    {
        // Read the input size of the staircase
        Console.Write("Enter the size of the staircase: ");
        int n = int.Parse(Console.ReadLine());

        // Call the staircase function
        Staircase(n);
    }

    static void Staircase(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            // Print the spaces
            for (int j = 0; j < n - i; j++)
            {
                Console.Write(" ");
            }

            // Print the hashes
            for (int k = 0; k < i; k++)
            {
                Console.Write("#");
            }

            // Move to the next line
            Console.WriteLine();
        }
    }
}
