namespace Kirjalista;

class Program
{
    static void Main(string[] args)
    {
        Kirjalista kirjalista = new Kirjalista();
        bool Kaynnissa = true;

        while (Kaynnissa)
        {
            Console.WriteLine("\nValitse toiminto:");
            Console.WriteLine("1 = Lisää kirja");
            Console.WriteLine("2 = Poista kirja");
            Console.WriteLine("3 = Listaa kirjat");
            Console.WriteLine("4 = Listaa kirjat genren mukaan");
            Console.WriteLine("5 = Etsi kirja nimen perusteella");
            Console.WriteLine("6 = lopeta");
            Console.Write("Anna valintasi: ");

            String? Valinta = Console.ReadLine();

             switch (Valinta)
            {
                case "1":
                    kirjalista.LisaaKirja();
                    break;

                case "2":
                    kirjalista.PoistaKirja();
                    
                    break;

                case "3":
                    kirjalista.ListaaKirjat();
                    
                    break;

                case "4":
                    kirjalista.GenreLista();

                    break;

                case "5":
                    kirjalista.EtsiKirja();

                    break;

                case "6":
                    Kaynnissa = false;
                    Console.WriteLine("Ohjelma on suljettu");
                    break;
            }

        }

        }
    }

