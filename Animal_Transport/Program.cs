//using System.Runtime.ConstrainedExecution;

//Cygnus, hayvanları belirli bir sırayla taşımak zorundadır ve her bir taşıma işlemi belirli kurallara tabidir. Taşıma sırasındaki kısıtlamalar ve adımlar aşağıdaki gibidir:

//Her bir hayvan belirli bir aralıkta taşınmalıdır ve diğer hayvanların sıralaması buna göre yapılmalıdır.
//Her bir hayvan, diğer belirli bir hayvanla birlikte veya ondan önce taşınmalıdır.
//Bu kurallara göre, verilen işlemleri yapmak için:

//E->D
//D->C
//C->M
using System;
using System.Collections.Generic;

class Solution
{
    public static void Main(string[] args)
    {
        int t = int.Parse(Console.ReadLine().Trim());

        Dictionary<string, string> transportRules = new Dictionary<string, string>();

        for (int i = 0; i < t; i++)
        {
            string[] rule = Console.ReadLine().Split(' ');
            transportRules[rule[2]] = rule[0];
        }

        string[] transports = new string[] { "E", "D", "C", "M" };
        bool isPossible = true;

        for (int i = 1; i < transports.Length; i++)
        {
            if (transportRules.ContainsKey(transports[i]))
            {
                if (transportRules[transports[i]] != "1" || transports[i - 1] != transports[i])
                {
                    isPossible = false;
                    break;
                }
            }
        }

        if (isPossible)
            Console.WriteLine("0");
        else
            Console.WriteLine("1");
    }
}
