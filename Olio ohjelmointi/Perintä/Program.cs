using System;

namespace Perintä
{
    class Program
    {
        static void Main(string[] args)
        {
            Henkilö henkilö = new Henkilö("Matti", 20, 192385);
            Opiskelija opiskelija = new Opiskelija("Pekka", 16, 015893, 12345, "Careeria")

            henkilö.TulostaTiedot();
            opiskelija.TulostaTiedot();
        }
    }
}
