using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace kirja_kirjailija
{
    class Book
    {
        public string nimi;
        public string kirjailija;
        public string julkaisija;
        public double _hinta;
        public static string teema;

        public Book(string nimi, string kirjailija, string julkaisija, double hinta, string kirjanTeema)
        {
            this.nimi = nimi;
            this.kirjailija = kirjailija;
            this.julkaisija = julkaisija;
            _hinta = hinta;
            teema = kirjanTeema;
        }

        public Book()
        {
        }

        public void GetBook(string title)
        {
            string s = string.Empty;
            if (this.nimi == title)
                s = $"Nimi:\t\t{title}\nKirjailija:\t\t{kirjailija}\nJulkaisija:\t{julkaisija}\n" +
                    $"Hinta:\t\t{_hinta.ToString("c", CultureInfo.CurrentCulture)}\n" +
                    $"Teema:\t\t{teema}\n------------------------------------\n";
            else
                s = $"Kirjaa {title} ei löydy hakemistosta!";
            Console.WriteLine(s);
        }

        public void PrintBook()
        {
            Console.WriteLine($"Nimi:\t\t{nimi}\nJulkaisija:\t{julkaisija}\n" +
                   $"Hinta:\t\t{_hinta.ToString("c", CultureInfo.CurrentCulture)}\n" +
                   $"Teema:\t\t{teema}\n------------------------------------\n");
        }

        public static void ChangeTheme()
        {
            Console.WriteLine("Anna uusi teema");
            teema = Console.ReadLine();
        }

        public double Price
        {
            get { return _hinta; }
            set
            {
                if (value > 30)
                {
                    _hinta = value * 0.9;
                }
                else
                {
                    _hinta = value;
                }
            }
        }

        public string Author
        {
            get
            {
                return kirjailija;
            }
        }
    }
}
