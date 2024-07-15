using System;
using System.Collections.Generic;
using System.Linq;

class Result
{
    /*
     * Complete the 'getTotalX' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */
    public static int getTotalX(List<int> a, List<int> b)
    {
        int lcmA = a.Aggregate(Lcm);
        int gcdB = b.Aggregate(Gcd);

        int count = 0;
        for (int i = lcmA, j = 2; i <= gcdB; i = lcmA * j, j++)
        {
            if (gcdB % i == 0)
            {
                count++;
            }
        }

        return count;
    }

    private static int Gcd(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    private static int Lcm(int a, int b)
    {
        return (a * b) / Gcd(a, b);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);
        int m = Convert.ToInt32(firstMultipleInput[1]);

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(int.Parse).ToList();
        List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(int.Parse).ToList();

        int total = Result.getTotalX(arr, brr);

        Console.WriteLine(total);
    }
}
//Bu problemi çözmek için iki koşulu kontrol etmeliyiz:

//Bir sayı, a dizisindeki tüm elemanların tam böleni olmalıdır.
//Bu sayı, b dizisindeki tüm elemanları tam bölebilmelidir.


//Bu kodun çalışma mantığı şu şekildedir:

//a dizisinin tüm elemanlarının ortak katını (LCM) hesaplar.
//b dizisinin tüm elemanlarının ortak bölenini (GCD) hesaplar.
//LCM ile GCD arasında yer alan ve LCM'nin katı olan tüm sayıları kontrol eder ve GCD'nin böleni olup olmadığını kontrol eder.
//Bu koşulları sağlayan sayıların sayısını döndürür.