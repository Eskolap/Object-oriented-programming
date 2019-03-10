using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagerProgram
{
    class Product
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string GroupName { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
        public string Comment { get; set; }
        public override string ToString()
        {
            return $"__________\nNimi: {Name}\nId: {Id}\nRyhmä nimi: {GroupName}";
        }
    }
}
