using System;
using System.Collections.Generic;
using System.Text;

namespace Kotitehtävä_3
{
    class Kiuas
    {
        private string Nimi { get; set; }
        private bool Tila { get; set; }
        private int Lämpötila { get; set; }
        private int Kosteus { get; set; }

        public Kiuas(string _nimi)
        {
            Nimi = _nimi;

            Tila = false;
            Lämpötila = 20;
            Kosteus = 60;
        }

        public void TulostaData()
        {
            Console.WriteLine("Kiuas: ");
            Console.WriteLine("-- Nimi: " + Nimi);
            Console.WriteLine("-- Tila: " + NäytäTila());
            Console.WriteLine("-- Lämpötila: " + Lämpötila + "Celsius");
            Console.WriteLine("-- Kosteus: " + Kosteus + "%");
            Console.WriteLine();
        }

        public string NäytäTila()
        {
            string nykyinenTila = "Pois Päältä";

            if (Tila == true)
            {
                nykyinenTila = "Päällä";
            }

            return nykyinenTila;
        }

        public void KiuasOnOff(bool t)
        {
            Tila = t;

            Console.Write("Kiuas on nyt " + NäytäTila() + "\n");
        }

        public void MuutaLämpötilaa(int uusiLämpötila)
        {
            if (Tila == false)
            {
                Console.WriteLine("Kiuas ei ole päällä, lämpötilaa ei voida muuttaa\n");
                return;
            }

            Lämpötila = uusiLämpötila;

            if (Lämpötila < 10)
            {
                Lämpötila = 10;
            }
            else if (Lämpötila > 150)
            {
                Lämpötila = 150;
            }

            Console.WriteLine("Lämpötila muutettu. Uusi lämpötila: " + Lämpötila + " Celsius\n");
        }

        public void MuutaKosteutta(int uusiKosteus)
        {
            if (Tila == false)
            {
                Console.WriteLine("Kiuas ei ole päällä, kosteutta ei voida muuttaa\n");
                return;
            }

            Kosteus = uusiKosteus;

            if (Kosteus < 0)
            {
                Kosteus = 0;
            }
            else if (Kosteus > 100)
            {
                Kosteus = 100;
            }
            Console.WriteLine("Kosteutta muutettu. Uusi kosteus: " + Kosteus + "%\n");
        }
    }
}
