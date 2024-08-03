using System;

class Result
{
    public static int squares(int a, int b)
    {
        int lowerBound = (int)Math.Ceiling(Math.Sqrt(a));
        int upperBound = (int)Math.Floor(Math.Sqrt(b));

        // Üst ve alt sınır arasında karesel sayı varsa, karesel sayıların sayısı
        // Üst sınırdan alt sınırı çıkartıp 1 ekleyerek bulunur
        if (lowerBound <= upperBound)
        {
            return upperBound - lowerBound + 1;
        }
        else
        {
            return 0; // Karesel sayı yoksa
        }
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int testCases = Convert.ToInt32(Console.ReadLine().Trim());

        for (int i = 0; i < testCases; i++)
        {
            string[] inputs = Console.ReadLine().Trim().Split(' ');

            int a = Convert.ToInt32(inputs[0]);
            int b = Convert.ToInt32(inputs[1]);

            int result = Result.squares(a, b);

            Console.WriteLine(result);
        }
    }
}
//Math.Sqrt(a): Alt sınır olan a'nın karekökünü alır.
//Math.Ceiling ve Math.Floor: a'nın karekökünü yukarı yuvarlamak ve b'nin karekökünü aşağı yuvarlamak için kullanılır.
//Karesel Sayıları Sayma: Eğer alt sınırdan (yukarı yuvarlanan) küçük veya eşit olan karesel sayılar, üst sınırdan (aşağı yuvarlanan) büyükse, bu iki sayı arasında kaç tane karesel sayı olduğunu buluruz.