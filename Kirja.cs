using System;

namespace Kirjalista
{
    public class Kirja
    {
        public string Nimi { get; set; }
        public string Kirjoittaja { get; set; }
        public int Julkaisuvuosi { get; set; }
        public string Genre { get; set; }

        public Kirja(string nimi, string kirjoittaja, int julkaisuvuosi, string genre)
        {
            this.Nimi = nimi;
            this.Kirjoittaja = kirjoittaja;
            this.Julkaisuvuosi = julkaisuvuosi;
            this.Genre = genre;
        }

        public override string ToString()
        {
            return Nimi + "-" + Kirjoittaja + "(" + Julkaisuvuosi + ")" + Genre;
        }
    }
}