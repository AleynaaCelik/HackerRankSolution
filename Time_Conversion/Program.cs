using System;

class Program
{
    static void Main()
    {
        string time12HourFormat = Console.ReadLine();
        string time24HourFormat = TimeConversion(time12HourFormat);
        Console.WriteLine(time24HourFormat);
    }

    static string TimeConversion(string s)
    {
        // Saat, dakika, saniye ve AM/PM bilgilerini çıkart
        string period = s.Substring(s.Length - 2);
        int hour = int.Parse(s.Substring(0, 2));
        string minuteSecond = s.Substring(2, 6);

        // AM ise ve saat 12 ise 0 olarak ayarla
        if (period == "AM" && hour == 12)
        {
            hour = 0;
        }
        // PM ise ve saat 12'den küçükse, 12 ekle
        else if (period == "PM" && hour < 12)
        {
            hour += 12;
        }

        // Yeni saat değerini 24 saatlik formatta stringe dönüştür
        return $"{hour:D2}{minuteSecond}";
    }
}
