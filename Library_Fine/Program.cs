﻿using System;

class Result
{
    /*
     * Complete the 'libraryFine' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER d1
     *  2. INTEGER m1
     *  3. INTEGER y1
     *  4. INTEGER d2
     *  5. INTEGER m2
     *  6. INTEGER y2
     */

    public static int libraryFine(int d1, int m1, int y1, int d2, int m2, int y2)
    {
        // Eğer kitap zamanında veya erken iade edilmişse, ceza yoktur
        if (y1 < y2 || (y1 == y2 && m1 < m2) || (y1 == y2 && m1 == m2 && d1 <= d2))
        {
            return 0;
        }
        // Eğer kitap aynı yılda ama geç bir ayda iade edildiyse
        else if (y1 == y2 && m1 > m2)
        {
            return 500 * (m1 - m2);
        }
        // Eğer kitap aynı ayda ama geç bir günde iade edildiyse
        else if (y1 == y2 && m1 == m2 && d1 > d2)
        {
            return 15 * (d1 - d2);
        }
        // Eğer kitap geç bir yılda iade edildiyse
        else if (y1 > y2)
        {
            return 10000;
        }

        return 0;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int d1 = Convert.ToInt32(firstMultipleInput[0]);
        int m1 = Convert.ToInt32(firstMultipleInput[1]);
        int y1 = Convert.ToInt32(firstMultipleInput[2]);

        string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int d2 = Convert.ToInt32(secondMultipleInput[0]);
        int m2 = Convert.ToInt32(secondMultipleInput[1]);
        int y2 = Convert.ToInt32(secondMultipleInput[2]);

        int result = Result.libraryFine(d1, m1, y1, d2, m2, y2);

        Console.WriteLine(result);
    }
}
