using System;
using System.Collections.Generic;
using System.Text;

namespace Test_app
{
    class Koira
    {
        public string nimi;
        public int ikä;
        public string rotu;

        public Koira(string _nimi, int _ikä, string _rotu)
        {
            nimi = _nimi;
            ikä = _ikä;
            rotu = _rotu;

            Hauku();
        }

        public Koira()
        {

        }

        public void TulostaData()
        {
            Console.WriteLine("Koiran nimi: " + nimi + ", Ikä: " + ikä + ", Rotu:" + rotu);
        }

        public void Hauku()

        {
            Console.WriteLine("Woof Woof");
        }
    }
}
