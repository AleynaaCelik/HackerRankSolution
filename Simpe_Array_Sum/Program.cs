using System;
using System.Collections.Generic;
using System.Linq;

class Result
{
    /*
     * Complete the 'simpleArraySum' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY ar as parameter.
     */

    public static int simpleArraySum(List<int> ar)
    {
        int result = 0;
        foreach (int element in ar)
        {
            result += element;
        }
        return result;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        // Kullanıcıdan dizinin boyutunu al
        int arCount = Convert.ToInt32(Console.ReadLine().Trim());

        // Kullanıcıdan dizi elemanlarını al ve tam sayıya çevir
        List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        // simpleArraySum fonksiyonunu çağır ve sonucu al
        int result = Result.simpleArraySum(ar);

        // Sonucu ekrana yazdır
        Console.WriteLine(result);
    }
}
