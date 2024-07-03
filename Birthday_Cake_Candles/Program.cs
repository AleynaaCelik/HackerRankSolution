using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split(' ');
        int[] candles = Array.ConvertAll(input, int.Parse);

        int maxHeight = int.MinValue;
        int count = 0;

        foreach (int height in candles)
        {
            if (height > maxHeight)
            {
                maxHeight = height;
                count = 1;
            }
            else if (height == maxHeight)
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}

//Bu problemde, bir çocuğun doğum günü pastasında çocuğun yaşı kadar mum olduğu ve çocuğun sadece en yüksek mumları üfleyebileceği anlatılıyor. Görevimiz, en yüksek boydaki mumların sayısını bulmak.