using System;

class Program
{
    static void Main(string[] args)
    {
        // Giriş verilerini oku
        string[] inputs = Console.ReadLine().Split(' ');
        int x1 = int.Parse(inputs[0]);
        int v1 = int.Parse(inputs[1]);
        int x2 = int.Parse(inputs[2]);
        int v2 = int.Parse(inputs[3]);

        // Sonucu belirle ve ekrana yazdır
        string result = Kangaroo(x1, v1, x2, v2);
        Console.WriteLine(result);
    }

    static string Kangaroo(int x1, int v1, int x2, int v2)
    {
        // v1 == v2 olduğunda, x1 == x2 olmalı yoksa "NO"
        if (v1 == v2)
        {
            return x1 == x2 ? "YES" : "NO";
        }
        else
        {
            // (x1 - x2) / (v2 - v1) tam sayı ve pozitif olmalı
            if ((x1 - x2) % (v2 - v1) == 0 && (x1 - x2) / (v2 - v1) >= 0)
            {
                return "YES";
            }
            else
            {
                return "NO";
            }
        }
    }
}

//problem, iki kangurunun aynı anda aynı konuma ulaşıp ulaşamayacağını belirlemeyi gerektiriyor. 