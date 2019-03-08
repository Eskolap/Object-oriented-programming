using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Rajapinta
{
    interface ICustomer
    {
        Customer GetCustomer(string name);
        string GetBonus();
    }
    class Customer
    {
        public string name;
        public double purchases;

        public Customer(string name, double purchases)
        {
            this.name = name;
            this.purchases = purchases;
        }

        public override string ToString()
        {
            return $"Nimi: {name}\tOstot: {purchases:F2} €";
        }

        public Customer GetCustomer(string name)
        {
            if (name == this.name)
                return this;
            else
                return null;
        }

        public string GetBonus()
        {
            if (purchases <= 1000)
                return (purchases * 0.02).ToString("c", CultureInfo.CurrentCulture);
            else if (purchases <= 2000)
                return (purchases * 0.03).ToString("c", CultureInfo.CurrentCulture);
            else
                return (purchases * 0.05).ToString("c", CultureInfo.CurrentCulture);
        }
    }
}
