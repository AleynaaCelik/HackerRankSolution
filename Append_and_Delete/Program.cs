using System;

class Solution
{
    static string AppendAndDelete(string s, string t, int k)
    {
        int commonLength = 0;

        // Ortak prefix uzunluğunu bul
        for (int i = 0; i < Math.Min(s.Length, t.Length); i++)
        {
            if (s[i] == t[i])
                commonLength++;
            else
                break;
        }

        int minOperations = (s.Length - commonLength) + (t.Length - commonLength);

        // Eğer gereken işlem sayısı k'dan küçükse ve (k - minOperations) çiftse ya da 
        // `s` ve `t` nin toplam uzunluğundan daha fazla işlem yapılabiliyorsa, "Yes" döndür
        if (minOperations == k ||
            (minOperations < k && (k - minOperations) % 2 == 0) ||
            (s.Length + t.Length) <= k)
        {
            return "Yes";
        }

        return "No";
    }

    static void Main(string[] args)
    {
        string s = Console.ReadLine();
        string t = Console.ReadLine();
        int k = int.Parse(Console.ReadLine());

        string result = AppendAndDelete(s, t, k);
        Console.WriteLine(result);
    }
}
