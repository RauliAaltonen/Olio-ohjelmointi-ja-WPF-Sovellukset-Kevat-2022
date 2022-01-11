using System;
using System.Collections.Generic;
using System.Text;

namespace Perintä
{
    class Opiskelija : Henkilö
    {
        public int opiskelijaID;
        public string koulu;

        public Opiskelija(string nimi, int ikä, int henkilötunnus, int _opiskelijaID, string _koulu)
    }
}
