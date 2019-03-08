using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace Rajapinta
{
    interface IProduct
    {
        Product GetProduct(string name);
        string CalculateTotal();
    }
    class Product : IProduct
    {
        public string name;
        public double price;
        public int amount;


        public Product(string name, double price, int amount)
        {
            this.name = name;
            this.price = price;
            this.amount = amount;
        }

        public override string ToString()
        {
            return $"Name: {name}\tPrice: {price:F2} €\tAmount: {amount}";
        }

        public Product GetProduct(string name)
        {
            if (this.name == name)
                return this;
            else
                return null;
        }

        public string CalculateTotal()
        {
            return (price * Convert.ToDouble(amount)).ToString("c", CultureInfo.CurrentCulture);
        }
    }
}
