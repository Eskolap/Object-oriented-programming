using System;
using System.Collections.Generic;
using System.Globalization;

namespace Rajapinta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<Product> productList = new List<Product>()
            {
                new Product("Banaani", 1.00, 858),
                new Product("Kirja", 20.00, 333),
                new Product("Hiiri", 15, 338),
            };

            List<Customer> customerList = new List<Customer>()
            {
                new Customer("Ake", 666),
                new Customer("Make", 444),
                new Customer("Pera", 555)
            };

            Store store = new Store("Kauppa Kauppanen", 78500);


            foreach (var item in productList)
            {
                store.AddProduct(item);
            }

            foreach (var item in customerList)
            {
                store.AddCustomer(item);
            }

            while (true)
            {
                Console.Clear();
                Intro();
                var input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Console.WriteLine(store.ToString());
                        Console.WriteLine("-------------------------\n");
                        Console.WriteLine("Paina jotain jatkaaksesi...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D2:
                        Console.Clear();
                        store.PrintCustomers();
                        Console.WriteLine("Paina jotain jatkaaksesi...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D3:
                        Console.Clear();
                        store.PrintProducts();
                        Console.WriteLine("Paina jotain jatkaaksesi...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.X:
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                }
            }
        }

        static void Intro()
        {
            Console.WriteLine("Ohjelma kertoo kaupan tietoja.\n" +
                "1. Tulosta yleiset tiedot\n" +
                "2. Tulosta asiakkaiden tiedot\n" +
                "3. Tulosta tuotetiedot\n" +
                "X. Poistu ohjelmasta");
        }
    }
}

