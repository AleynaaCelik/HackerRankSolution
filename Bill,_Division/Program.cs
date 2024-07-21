//Problem, iki kişinin bir restoranda yedikleri yemeklerin faturasını nasıl böleceklerini ve birinin diğerine fazla para verip vermediğini kontrol etmekle ilgilidir


using System;
using System.Collections.Generic;
using System.Linq;

class Result
{
    /*
     * Complete the 'bonAppetit' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY bill
     *  2. INTEGER k
     *  3. INTEGER b
     */

    public static void bonAppetit(List<int> bill, int k, int b)
    {
        // Anna'nın yemedigi öğeyi hariç tutarak toplam maliyeti hesaplayın
        int totalCost = bill.Sum() - bill[k];
        int annaShare = totalCost / 2;

        if (b == annaShare)
        {
            Console.WriteLine("Bon Appetit");
        }
        else
        {
            Console.WriteLine(b - annaShare);
        }
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);
        int k = Convert.ToInt32(firstMultipleInput[1]);

        List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();

        int b = Convert.ToInt32(Console.ReadLine().Trim());

        Result.bonAppetit(bill, k, b);
    }
}
