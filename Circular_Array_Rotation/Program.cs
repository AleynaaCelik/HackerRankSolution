using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static int[] CircularArrayRotation(int[] a, int k, int[] queries)
    {
        int n = a.Length;
        k = k % n; // Döndürme sayısını optimize et
        int[] rotatedArray = new int[n];

        // Diziyi sağa doğru döndür
        for (int i = 0; i < n; i++)
        {
            rotatedArray[(i + k) % n] = a[i];
        }

        // İstenen indekslerdeki elemanları döndür
        int[] result = new int[queries.Length];
        for (int i = 0; i < queries.Length; i++)
        {
            result[i] = rotatedArray[queries[i]];
        }

        return result;
    }

    static void Main(string[] args)
    {
        string[] firstLine = Console.ReadLine().Split(' ');
        int n = int.Parse(firstLine[0]);
        int k = int.Parse(firstLine[1]);
        int q = int.Parse(firstLine[2]);

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int[] queries = new int[q];
        for (int i = 0; i < q; i++)
        {
            queries[i] = int.Parse(Console.ReadLine());
        }

        int[] result = CircularArrayRotation(a, k, queries);

        foreach (int res in result)
        {
            Console.WriteLine(res);
        }
    }
}


//CircularArrayRotation fonksiyonu:
//k sayısını dizinin uzunluğuna göre mod alarak optimize ediyoruz.
//Diziyi k kez sağa doğru döndürmek için her elemanı yeni pozisyonuna yerleştiriyoruz.
//İstenen indekslerdeki elemanları döndürüyoruz.
