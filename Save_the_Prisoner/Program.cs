using System;
using System.IO;

class Result
{
    public static int saveThePrisoner(int n, int m, int s)
    {
        // Tatlıların en son hangi mahkûma gideceğini hesapla
        int warningPrisoner = (s - 1 + m - 1) % n + 1;
        return warningPrisoner;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        // Çıktıyı bir dosyaya veya belirtilen yola yazmak için StreamWriter kullanılıyor
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        // Test durumlarının sayısını oku
        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            // Mahkum sayısı, tatlı sayısı ve başlangıç koltuğunu oku
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);
            int m = Convert.ToInt32(firstMultipleInput[1]);
            int s = Convert.ToInt32(firstMultipleInput[2]);

            // Çözümü hesapla
            int result = Result.saveThePrisoner(n, m, s);

            // Sonucu yazdır
            textWriter.WriteLine(result);
        }

        // Çıkışı temizle ve kapat
        textWriter.Flush();
        textWriter.Close();
    }
}



//Başlangıç koltuğundan(s) başlayarak m adet tatlı dağıtılacak.
//Dairesel bir yapıda olduğu için tatlı dağıtılırken son mahkumdan sonra ilk mahkûma dönülecek.
//Tatlı dağıtımının son alıcısı, (s + m - 1) % n ile hesaplanır. Eğer hesaplama sonucu 0 çıkarsa, en son mahkûm tatlı alır, yani n.
