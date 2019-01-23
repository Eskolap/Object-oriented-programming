using System;

namespace firma_luokka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Firman tiedot");
            Console.WriteLine("----------------------------");
            Company company = new Company("Lika-Akin makasiini", "Akinkuja 9", "0405040521", 1000050, 94234);
            Company enterprise = new Company(company);
            Console.WriteLine(company.ToString());

            Console.WriteLine(company.profit());
            Console.WriteLine("\nKopiointi:\n");
            Console.WriteLine(enterprise.ToString());


        }
    }
}
