 using System;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        int t = int.Parse(Console.ReadLine());
        List<int> cycles = new List<int>();

        for (int i = 0; i < t; i++)
        {
            int n = int.Parse(Console.ReadLine());
            cycles.Add(n);
        }

        foreach (int n in cycles)
        {
            int result = UtopianTree(n);
            Console.WriteLine(result);
        }
    }

    static int UtopianTree(int n)
    {
        int height = 1;

        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 1) // İlkbahar (i tekse)
            {
                height *= 2;
            }
            else // Yaz (i çiftse)
            {
                height += 1;
            }
        }

        return height;
    }
}


//Main Fonksiyonu:
//İlk olarak, test senaryolarının sayısını (t) okur.
//cycles isimli bir listeye her bir test senaryosundaki büyüme döngüsü sayısını ekler.
//Her bir büyüme döngüsü sayısı için UtopianTree fonksiyonunu çağırır ve sonucu ekrana yazar.

//UtopianTree Fonksiyonu:
//Başlangıçta ağacın yüksekliği 1 metre olarak ayarlanır.
//n büyüme döngüsü boyunca döngü kurar. Her döngüde:
//Eğer döngü numarası tek ise (ilkbahar), ağacın yüksekliği iki katına çıkar.
//Eğer döngü numarası çift ise (yaz), ağacın yüksekliği 1 metre artar.
//Son olarak, hesaplanan yüksekliği döndürür.