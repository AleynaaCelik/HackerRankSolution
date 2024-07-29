using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // İlk satırdaki girişleri okuyalım: n ve k
        var inputs = Console.ReadLine().Split(' ');
        int n = int.Parse(inputs[0]);
        int k = int.Parse(inputs[1]);

        // İkinci satırdaki yükseklikleri okuyalım
        var heights = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        // En yüksek engeli bul
        int maxHeight = heights.Max();

        // Gerekli iksir sayısını hesapla
        int dosesRequired = Math.Max(0, maxHeight - k);

        // Sonucu yazdır
        Console.WriteLine(dosesRequired);
    }
}
