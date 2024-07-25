using System;

class Solution
{
    static void Main(String[] args)
    {
        int q = int.Parse(Console.ReadLine()); // number of queries

        for (int i = 0; i < q; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int x = int.Parse(inputs[0]); // position of Cat A
            int y = int.Parse(inputs[1]); // position of Cat B
            int z = int.Parse(inputs[2]); // position of Mouse C

            Console.WriteLine(CatAndMouse(x, y, z));
        }
    }

    static string CatAndMouse(int x, int y, int z)
    {
        int distanceCatA = Math.Abs(z - x);
        int distanceCatB = Math.Abs(z - y);

        if (distanceCatA < distanceCatB)
        {
            return "Cat A";
        }
        else if (distanceCatB < distanceCatA)
        {
            return "Cat B";
        }
        else
        {
            return "Mouse C";
        }
    }
}
