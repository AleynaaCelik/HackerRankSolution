using System;

public class Program
{
    public static void Main()
    {
        // Örnek girdiler
        int[] a = { 5, 6, 7 };
        int[] b = { 3, 6, 10 };

        int[] result = CompareTriplets(a, b);
        Console.WriteLine(string.Join(" ", result));  // Çıktı: 1 1

        int[] a2 = { 17, 28, 30 };
        int[] b2 = { 99, 16, 8 };

        int[] result2 = CompareTriplets(a2, b2);
        Console.WriteLine(string.Join(" ", result2));  // Çıktı: 2 1
    }

    public static int[] CompareTriplets(int[] a, int[] b)
    {
        int alicePoints = 0;
        int bobPoints = 0;

        for (int i = 0; i < 3; i++)
        {
            if (a[i] > b[i])
                alicePoints++;
            else if (a[i] < b[i])
                bobPoints++;
        }

        return new int[] { alicePoints, bobPoints };
    }
}

//CompareTriplets fonksiyonu kullanılarak iki tane int dizisi (a ve b) parametre olarak alınır. Fonksiyon içinde bir döngü ile her iki dizi elemanları karşılaştırılır ve Alice'in ve Bob'un puanlarına göre ilgili değişkenler (alicePoints ve bobPoints) artırılır. Döngü sonunda ise new int[] { alicePoints, bobPoints } şeklinde bir int dizisi döndürülür, bu da Alice'in ve Bob'un puanlarını içerir.