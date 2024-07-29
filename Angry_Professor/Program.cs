using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    public static void Main(string[] args)
    {
        // Test durumu sayısını oku
        int t = Convert.ToInt32(Console.ReadLine().Trim());

        // Her test durumu için işlemleri yap
        for (int tItr = 0; tItr < t; tItr++)
        {
            // n ve k'yı oku
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]); // Öğrenci sayısı
            int k = Convert.ToInt32(firstMultipleInput[1]); // İptal edilmeme eşiği

            // Öğrencilerin geliş zamanlarını oku
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            // Zamanında veya erken gelen öğrencileri say
            int ontimeCount = a.Count(arrivalTime => arrivalTime <= 0);

            // Ders iptal mi edilecek?
            string result = ontimeCount >= k ? "NO" : "YES";

            // Sonucu yazdır
            Console.WriteLine(result);
        }
    }
}
