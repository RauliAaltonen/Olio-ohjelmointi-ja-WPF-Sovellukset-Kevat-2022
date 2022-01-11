using System;
using System.Collections.Generic;
using System.Text;

namespace Test_app
{
    class Program1
    {

        static void Main(string[] args)
        {

            float km = 45f;

            float mailit = Muuntaja.KmToMiles(km);

            Console.WriteLine(km + "kilometriä on yhtä kuin" + mailit + "mailia");
        }
    }
}
