using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kirja_kirjailija
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Book book1 = new Book("Heinähattu ja vilttitossu ja vaari", "Sinikka Nopola", "Tammi", 22.50, "Fiktio");
            Book book2 = new Book("A Game of thrones", "George R.R Martin", "Bantam Spectra", 30, "Fantasia");

            Author author = new Author
            {
                Name = "Sinikka Nopola",
                Birthday = "26.11.1953",
                Book = book1
            };

            Author author2 = new Author
            {
                Name = "George R.R Martin",
                Birthday = "20.9.1948",
                Book = book2
            };

            while (true)
            {
                Intro();

                var input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        book1.GetBook(book1.nimi);
                        book2.GetBook(book2.nimi);
                        Console.WriteLine("Paina jotain palataksesi alkuvalikkoon...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D2:
                        Console.Clear();
                        Book.ChangeTheme();
                        Console.WriteLine("Paina jotain vaihtaaksesi teemaa");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D3:
                        Console.Clear();
                        book1.Price = book1._hinta;
                        book2.Price = book2._hinta;
                        Console.WriteLine("Kirjojen uudet hinnat ovat nyt laskettu!");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D4:
                        Console.Clear();
                        author.PrintAuthor();
                        author2.PrintAuthor();
                        Console.WriteLine("Paina jotain jatkaaksesi...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.X:
                        Console.Clear();
                        Environment.Exit(0);
                        break;

                }
                Console.Clear();
            }
        }

        static void Intro()
        {
            Console.WriteLine("1. tulosta lista kirjoista\n" +
                              "2. vaihda kirjojen teema\n" +
                              "3. laske kirjoille alennus\n" +
                              "4. tulosta kirjailijoiden tiedot\n" +
                              "X. poistu ohjelmasta");
        }
    
    }
}
