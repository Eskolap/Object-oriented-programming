using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace FileManagerProgram
{
    class FileManager
    {
        private readonly string _filePath;
        private List<Product> _productList;

        public FileManager(string filePath)
        {
            _filePath = filePath;
        }

        public string ReadWords()
        {
            try
            {
                string content = ReadFile();
                return content;
            }
            catch (Exception x)
            {
                return x.Message;
            }
        }

        private string ReadFile()
        {
            StreamReader r = new StreamReader(_filePath);
            string json = r.ReadToEnd();
            _productList = JsonConvert.DeserializeObject<List<Product>>(json);
            r.Close();
            return PrintJson();
        }

        private string PrintJson()
        {
            string content = "";
            foreach (Product p in _productList)
            {
                content += p.ToString() + "\n";
            }

            return content;
        }

        public string IdAndNamePrint()
        {
            string content = String.Empty;
            try
            {
                foreach (Product p in _productList)
                {
                    content += $"Id: {p.Id}\tNimi: {p.Name}\n";
                }

                return content;
            }
            catch (Exception x)
            {
                return $"{x.Message} Onko oikea tiedosto?";
            }
        }

        public string FindId(int id)
        {
            try
            {
                foreach (Product p in _productList)
                {
                    if (id == p.Id)
                    {
                        return p.ToString() + $"\nHinta: {p.Price} €\nMäärä: {p.Amount}\nKommentti: {p.Comment}";
                    }
                }
            }
            catch (Exception x)
            {
                return $"{x.Message} Onko oikea tiedosto?";
            }

            return "Tätä tuotetta kuvaavaa Id:tä ei löydy!";
        }

        public string ProductsAndStock()
        {
            bool productFound = false;
            string content = string.Empty;
            Console.WriteLine("Tulostetaan loppuneet tuotteet");
            try
            {
                foreach (Product p in _productList)
                {
                    if (p.Amount == 0)
                    {
                        productFound = true;
                        content += p.ToString() + "\n";
                    }
                }

                if (!productFound)
                {
                    content = "Mikään tuote ei ole loppunut";
                }

                return content;
            }
            catch (Exception x)
            {
                return $"{x.Message} Onko oikea tiedosto?";
            }
        }

        public string Category(int choose)
        {
            string category = string.Empty;
            string content = string.Empty;
            switch (choose)
            {
                case 1:
                    category = "Lajittelu ja säilytys";
                    break;
                case 2:
                    category = "Paperit ja lehtiöt";
                    break;
                case 3:
                    category = "Kynät";
                    break;
                case 4:
                    category = "Kortit ja kirjekuoret";
                    break;
            }

            try
            {
                foreach (Product p in _productList)
                {
                    if (category == p.GroupName)
                    {
                        content += p.ToString() + "\n";
                    }
                }

                return content;
            }
            catch (Exception x)
            {
                return $"{x.Message} Onko oikea tiedosto?";
            }

            ;
        }

        public void AddComment(int id)
        {
            bool productFound = false;
            try
            {
                foreach (Product p in _productList)
                {
                    if (id == p.Id)
                    {
                        productFound = true;
                        Console.WriteLine($"Löytyi tuote {p.Name} kommentilla '{p.Comment}'");
                        Console.Write("Kirjoita kommentti ");
                        string comment = Console.ReadLine();
                        if (p.Comment.Contains(comment))
                        {
                            Console.WriteLine($"Kommentti '{comment}' on jo kommenteissa!");
                        }
                        else
                        {
                            p.Comment += " " + comment;
                            Console.WriteLine($"Lisätty kommentti '{comment}' tuotteeseen '{p.Name}'." +
                                              $"\nTuotteen kommentit: '{p.Comment}'.");
                        }
                    }
                }

                if (!productFound)
                {
                    Console.WriteLine("Id:tä vastaavaa tuotetta ei löytynyt");
                }
            }
            catch (Exception x)
            {
                Console.WriteLine($"{x.Message} Onko oikea tiedosto?");
            }
        }

        public void CommentDeletion(int id)
        {
            bool productFound = false;
            try
            {
                foreach (Product p in _productList)
                {
                    if (id == p.Id)
                    {
                        productFound = true;
                        Console.WriteLine($"Tuote {p.Name} kommentilla '{p.Comment}'");
                        Console.Write("Tahdotko poistaa tämän kommentin? K tai E]");
                        ConsoleKeyInfo cki = Console.ReadKey();
                        switch (cki.Key)
                        {
                            case ConsoleKey.K:
                                p.Comment = "";
                                Console.WriteLine("\nKommentti poistettu");
                                break;
                            case ConsoleKey.E:
                                Console.WriteLine("\n");
                                break;
                            default:
                                Console.WriteLine("\nVäärä syöte!");
                                break;
                        }
                    }
                }

                if (!productFound)
                {
                    Console.WriteLine("Id:tä vastaavaa tuotetta ei löytynyt");
                }
            }
            catch (Exception x)
            {
                Console.WriteLine($"{x.Message} Onko oikea tiedosto?");
            }
        }

        public void AmountUpdating(int id)
        {
            bool productFound = false;
            try
            {
                foreach (Product p in _productList)
                {
                    if (id == p.Id)
                    {
                        productFound = true;
                        Console.WriteLine($"Löytyi tuote: {p.Name}\nMäärä: {p.Amount}");
                        while (true)
                        {
                            Console.Write("Syötä uusi määrä: ");
                            if (int.TryParse(Console.ReadLine(), out int amount))
                            {
                                p.Amount = amount;
                                Console.WriteLine($"Tuotteen {p.Name} uusi määrä on {p.Amount}.");
                                CommentDeletion(p.Id);
                                break;
                            }

                            Console.WriteLine("Syöte ei ollut numero!");
                        }
                    }
                }

                if (!productFound)
                {
                    Console.WriteLine("Id:tä vastaavaa tuotetta ei löytynyt");
                }
            }
            catch (Exception x)
            {
                Console.WriteLine($"{x.Message} Onko oikea tiedosto?");
            }
        }

        public void Update()
        {
            string json = JsonConvert.SerializeObject(_productList);
            StreamWriter w = new StreamWriter(_filePath);
            w.Write(json);
            w.Close();
        }
    }
}
