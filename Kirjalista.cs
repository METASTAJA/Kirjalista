using System;
using System.Runtime.InteropServices;

namespace Kirjalista
{
    public class Kirjalista
    {
        public List<Kirja> Kirjat;
        public Kirjalista()
        {
            Kirjat = new List<Kirja>();
        }

        public void LisaaKirja()
        {
            Console.WriteLine("Anna kirjan nimi");
            string? nimi = Console.ReadLine();

            Console.WriteLine("Anna kirjoittaja");
            string? kirjoittaja = Console.ReadLine();

            Console.WriteLine("Anna julkaisu vuosi");
            int vuosi = int.Parse(Console.ReadLine());

            Console.WriteLine("Anna kirjan genre");
            string? genre = Console.ReadLine();

            Kirjat.Add(new Kirja(nimi, kirjoittaja, vuosi, genre));

        }

        public void PoistaKirja()
        {
            Console.WriteLine("Anna poistettavan kirjan nimi");
            string? poistonimi = Console.ReadLine();

            foreach (Kirja kirja in Kirjat)
            {
                if (kirja.Nimi == poistonimi)
                {
                    Kirjat.Remove(kirja);

                    break;
                }
            }

        }

        public void ListaaKirjat()
        {
            if (Kirjat.Count == 0)
            {
                Console.WriteLine("Listalla ei ole kirjoja");
            }
            else
            {
                foreach (Kirja book in Kirjat)
                {
                    Console.WriteLine(book);
                }
            }
        }

        public void GenreLista()
        {
            Console.WriteLine("Anna genre");
            string? genrenimi = Console.ReadLine();

            foreach (Kirja book in Kirjat)
            {
                if (genrenimi == book.Genre)
                {
                    Console.WriteLine(book);
                }
            }
        }

        public void EtsiKirja()
        {
            Console.WriteLine("Anna kirjan nimi tai kirjailian nimi");
            string? nimi = Console.ReadLine();

            foreach (Kirja kirja in Kirjat)
            {
                if (nimi == kirja.Nimi || nimi == kirja.Kirjoittaja)
                {
                    Console.WriteLine(kirja);
                    break;
                }
            }
        }
        


         
    }
}