﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    /*
     * Complete the 'pageCount' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER p
     */
    public static int pageCount(int n, int p)
    {
        // Kitabın başından kaç sayfa çevrilmesi gerektiğini hesaplayın
        int frontFlips = p / 2;

        // Kitabın sonundan kaç sayfa çevrilmesi gerektiğini hesaplayın
        int backFlips = (n / 2) - (p / 2);

        // Minimum sayfa çevirme sayısını döndürün
        return Math.Min(frontFlips, backFlips);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        int p = Convert.ToInt32(Console.ReadLine().Trim());

        int result = Result.pageCount(n, p);

        Console.WriteLine(result);
    }
}
