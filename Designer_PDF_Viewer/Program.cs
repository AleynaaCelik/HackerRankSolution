using System;

class Program
{
    static void Main()
    {
        // Example input
        int[] heights = { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 1, 1, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
        string word = "abc";

        int area = DesignerPdfViewer(heights, word);
        Console.WriteLine(area); // Output: 9
    }

    static int DesignerPdfViewer(int[] h, string word)
    {
        int maxHeight = 0;

        foreach (char c in word)
        {
            int index = c - 'a';
            if (h[index] > maxHeight)
            {
                maxHeight = h[index];
            }
        }

        return maxHeight * word.Length;
    }
}
