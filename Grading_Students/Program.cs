using System;

class Program
{
    static void Main()
    {
        // Öğrenci sayısını oku
        int n = int.Parse(Console.ReadLine());

        // Öğrenci notlarını tutmak için dizi oluştur
        int[] grades = new int[n];

        // Öğrenci notlarını oku
        for (int i = 0; i < n; i++)
        {
            grades[i] = int.Parse(Console.ReadLine());
        }

        // Notları yuvarla ve ekrana yazdır
        for (int i = 0; i < n; i++)
        {
            int finalGrade = RoundGrade(grades[i]);
            Console.WriteLine(finalGrade);
        }
    }

    static int RoundGrade(int grade)
    {
        // Not 40'ın altındaysa, yuvarlanmaz
        if (grade < 38)
        {
            return grade;
        }

        // En yakın üst çokluğunu bul
        int nextMultipleOfFive = ((grade / 5) + 1) * 5;

        // Eğer fark 3 veya daha küçükse, yuvarla
        if (nextMultipleOfFive - grade < 3)
        {
            return nextMultipleOfFive;
        }
        else
        {
            return grade;
        }
    }
}
