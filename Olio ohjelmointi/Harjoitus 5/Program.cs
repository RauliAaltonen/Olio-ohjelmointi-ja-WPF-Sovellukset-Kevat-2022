using System;

namespace Harjoitus_5
{

    class Program
    {

        static void Main(string[] args)
        {
            float a = 15;
            float b = 30;

            Console.WriteLine(Laskin.Summa(a, b));
            Console.WriteLine(Laskin.Erotus(a, b));
            Console.WriteLine(Laskin.Kertolasku(a, b));
            Console.WriteLine(Laskin.Jakolasku(a, b));
        }
    }   
}
