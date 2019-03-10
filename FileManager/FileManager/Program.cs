using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Net;
namespace FileManagerProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string filePath = @"D:\json\items.json";
            FileManager file = new FileManager(filePath);
            ConsoleKeyInfo cki;

            if (File.Exists(filePath))
            {
                file.ReadWords();
                do
                {
                    Console.WriteLine("Valitse haluamasi vaihtoehto");
                    cki = Intro();
                    Console.WriteLine();
                    switch (cki.Key)
                    {
                        case ConsoleKey.D1:
                            Console.WriteLine(file.ReadWords());
                            break;
                        case ConsoleKey.D2:
                            Console.WriteLine(file.Category(Intro2()));
                            break;
                        case ConsoleKey.D3:
                            Console.WriteLine(file.ProductsAndStock());
                            break;
                        case ConsoleKey.D4:
                            Console.WriteLine(file.IdAndNamePrint());
                            Console.WriteLine(file.FindId(IdInt()));
                            break;                     
                        default:
                            Console.WriteLine("Ei mahdollista!");
                            break;
                    }

                    file.Update();
                    Console.WriteLine("Paina jotain jatkaaksesi!");
                    Console.ReadKey();
                    Console.Clear();
                } while (cki.Key != ConsoleKey.Escape);
            }
            else
            {
                Console.WriteLine("Tiedostoa ei ole olemassa!");
            }
        }

        private static ConsoleKeyInfo Intro()
        {
            Console.WriteLine("[1] Tulosta kaikki tuotteet.");
            Console.WriteLine("[2] Tulosta tuotteet kategorian mukaan.");
            Console.WriteLine("[3] Tulosta loppuneet tuotteet.");
            Console.WriteLine("[4] Lisää tai poista tuotteen kommentti.");        
            return Console.ReadKey();
        }

        private static int IdInt()
        {
            while (true)
            {
                Console.Write("Syötä tuotteen id numeroin: ");
                if (int.TryParse(Console.ReadLine(), out int input))
                {
                    return input;
                }

                Console.WriteLine("Syöte ei ollut numero!");
            }
        }

        private static int Intro2()
        {
            Console.WriteLine("[1] Lajittelu ja säilytys\n");
            Console.WriteLine("[2] Paperit ja lehtiöt\n");
            Console.WriteLine("[3] Kynät\n");
            Console.WriteLine("[4] Kortit ja kirjekuoret\n");
            while (true)
            {
                Console.Write("Valitse tuotekategoria.");
                if (int.TryParse(Console.ReadLine(), out int input) && input < 5 && input > 0)
                {
                    return input;
                }
                Console.WriteLine("Syöte ei ollut ryhmästä 1 - 4!");
            }
        }
    }
}
