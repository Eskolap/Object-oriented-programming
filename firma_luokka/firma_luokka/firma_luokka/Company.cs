using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace firma_luokka
{
    class Company
    {
        public string Title;
        public string Address;
        public string Phone;
        public int Income;
        public int Expense;
        public Company()
        {
            
        }
        public Company(string title, string address, string phone, int income, int expense)
        {
            this.Title = title;
            this.Address = address;
            this.Phone = phone;
            this.Income = income;
            this.Expense = expense;
        }
        public string profit()
        {
            string s = string.Empty;
            decimal profit = (this.Income - this.Expense) / this.Expense;
            if (profit < 1)

                s = "Menee kehnosti";
            else if (profit <= 2)
                s = "Menee välttävästi";
            else if (profit <= 3)
                s = "Menee tyydyttävästi";
            else
                s = "Menee hyvin";
            return $"Voittoprosentti on: {profit.ToString("p")}. {s}";
            

        }

        public override string ToString()
        {
            return "Firma:\t" + this.Title + "\nOsoite:\t" + this.Address + "\nPuhelin:" + this.Phone + "\nTulot:\t" + this.Income.ToString("c", CultureInfo.CurrentCulture) + "\nMenot: \t" + this.Expense.ToString("c", CultureInfo.CurrentCulture);

        }

        public Company(Company copyCompany)
        {
            Title = copyCompany.Title;
            Address = copyCompany.Address;
            Phone = copyCompany.Phone;
            Income = copyCompany.Income;
            Expense = copyCompany.Expense;

        }

    }
}
