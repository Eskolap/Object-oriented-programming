using System;
using System.Collections.Generic;
using System.Text;

namespace bookprogram
{
    class bookinfo
    {
        public string title;
        public string author;
        public string id;
        public decimal price;

        public bookinfo(string title, string author, string id, decimal price)
        {
            this.title = title;
            this.author = author;
            this.id = id;
            this.price = price;

        }
        public string PrintInfo()
        {
            return            $"Nimi: {this.title}\n" +
                              $"Kirjailija: {this.author}\n" +
                              $"Id: {this.id}\n" +
                              $"Hinta: {this.price}\n";

        }
        public string bookcompare(bookinfo book)
        {
            string text;
            Console.WriteLine($"Nimi: {this.title} - Hinta: {this.price.ToString()}");
            Console.WriteLine($"Nimi: {book.title} - Hinta: {book.price.ToString()}");
            if (this.price > book.price)
            {
                text = $"{this.title} on kalliimpi kuin {book.title}";
            }
            else if (this.price == book.price)
            {
                text= $"{this.title} ja {book.title} ovat saman hintaisia.";
            }
            else
            {
                text = $"{book.title} on kalliimpi kuin {this.title}";
            }
            return text;
        }
    }
}

