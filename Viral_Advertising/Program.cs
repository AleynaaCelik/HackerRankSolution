using System;
using System.IO;
using System.Runtime.ConstrainedExecution;

class Result
{
    public static int viralAdvertising(int n)
    {
        int shared = 5;  // İlk gün paylaşılan kişi sayısı
        int cumulativeLikes = 0;  // Toplam beğeni sayısı

        for (int day = 1; day <= n; day++)
        {
            int liked = shared / 2;  // Beğenen kişi sayısı
            cumulativeLikes += liked;  // Toplam beğeniye ekle
            shared = liked * 3;  // Ertesi gün paylaşılacak kişi sayısı
        }

        return cumulativeLikes;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = Console.Out; // Çıkışı konsola yazdır

        int n = Convert.ToInt32(Console.ReadLine().Trim()); // Gün sayısını oku

        int result = Result.viralAdvertising(n); // Fonksiyonu çağır

        textWriter.WriteLine(result); // Sonucu yazdır

        textWriter.Flush();
        textWriter.Close();
    }
}


//Başlangıç Durumu:

//İlk gün reklam 5 kişiye gösterilir.
//Reklamı görenlerin yarısı (tam sayıya yuvarlanmış olarak) beğenir ve ertesi gün için paylaşır.
//Döngü:

//Her gün için, reklamı gören kişi sayısı 2'ye bölünerek beğenen kişi sayısı hesaplanır.
//Beğenen kişi sayısı, ertesi gün için paylaşacak kişi sayısını belirler (liked * 3).
//Her gün beğenen kişi sayısı cumulativeLikes değişkenine eklenir.
//Sonuç:

//Döngü tamamlandığında, toplam beğeni sayısı döndürülür.