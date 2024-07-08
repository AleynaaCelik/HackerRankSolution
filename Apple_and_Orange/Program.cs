using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Giriş değerlerini oku
        string[] st = Console.ReadLine().Split(' ');
        int s = Convert.ToInt32(st[0]);  // Ev başlangıç noktası
        int t = Convert.ToInt32(st[1]);  // Ev bitiş noktası

        string[] ab = Console.ReadLine().Split(' ');
        int a = Convert.ToInt32(ab[0]);  // Elma ağacı konumu
        int b = Convert.ToInt32(ab[1]);  // Portakal ağacı konumu

        string[] mn = Console.ReadLine().Split(' ');
        int m = Convert.ToInt32(mn[0]);  // Düşen elma sayısı
        int n = Convert.ToInt32(mn[1]);  // Düşen portakal sayısı

        string[] applesTemp = Console.ReadLine().Split(' ');
        int[] apples = Array.ConvertAll(applesTemp, Int32.Parse);  // Elma düşme mesafeleri

        string[] orangesTemp = Console.ReadLine().Split(' ');
        int[] oranges = Array.ConvertAll(orangesTemp, Int32.Parse);  // Portakal düşme mesafeleri

        // Ev üzerine düşen elma sayısını hesapla
        int applesOnHouse = CountFruitsOnHouse(s, t, a, apples);

        // Ev üzerine düşen portakal sayısını hesapla
        int orangesOnHouse = CountFruitsOnHouse(s, t, b, oranges);

        // Sonuçları yazdır
        Console.WriteLine(applesOnHouse);
        Console.WriteLine(orangesOnHouse);
    }

    // Ev üzerine düşen meyve sayısını hesaplayan fonksiyon
    private static int CountFruitsOnHouse(int s, int t, int treePos, int[] distances)
    {
        int count = 0;
        foreach (var distance in distances)
        {
            int meyvePos = treePos + distance;
            if (meyvePos >= s && meyvePos <= t)
                count++;
        }
        return count;
    }
}
