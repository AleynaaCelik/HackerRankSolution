using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{
    /*
     * Complete the 'getMoneySpent' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY keyboards
     *  2. INTEGER_ARRAY drives
     *  3. INTEGER b
     */

    public static int getMoneySpent(List<int> keyboards, List<int> drives, int b)
    {
        int maxSpend = -1;

        foreach (int keyboard in keyboards)
        {
            foreach (int drive in drives)
            {
                int total = keyboard + drive;
                if (total <= b && total > maxSpend)
                {
                    maxSpend = total;
                }
            }
        }

        return maxSpend;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        string[] bnm = Console.ReadLine().TrimEnd().Split(' ');

        int b = Convert.ToInt32(bnm[0]);

        int n = Convert.ToInt32(bnm[1]);

        int m = Convert.ToInt32(bnm[2]);

        List<int> keyboards = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(keyboardsTemp => Convert.ToInt32(keyboardsTemp)).ToList();

        List<int> drives = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(drivesTemp => Convert.ToInt32(drivesTemp)).ToList();

        int moneySpent = Result.getMoneySpent(keyboards, drives, b);

        Console.WriteLine(moneySpent);
    }
}
