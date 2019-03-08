using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kirja_kirjailija
{
    class Author
    {
        private string _name;
        private string _birthday;
        public Book _book;

        public Author()
        {
            this._name = string.Empty;
            this._birthday = string.Empty;
            this._book = new Book();
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Birthday
        {
            get { return _birthday; }
            set { _birthday = value; }
        }
        public Book Book
        {
            get { return _book; }
            set { _book = value; }
        }

        public void PrintAuthor()
        {
            Console.WriteLine($"Kirjailija:\t\t{this.Name}\n" +
                $"Syntymäpäivä:\t{this.Birthday}");
            this.Book.PrintBook();
        }
    }
}
