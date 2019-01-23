using System;

namespace bookprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjat:");
            Console.WriteLine("___________________");

            bookinfo newbook = new bookinfo("Kesähessumies","Aki","0001", 12.50M);

            Console.WriteLine(newbook.PrintInfo());
            Console.ReadKey();
            Console.WriteLine("___________________");
            bookinfo newbook2 = new bookinfo("Mitä kuuluu", "kimmo", "0002", 22.50M);
            Console.WriteLine(newbook2.PrintInfo());
            Console.ReadKey();
            Console.WriteLine("__________________________________");
            Console.WriteLine(newbook.bookcompare(newbook2));
        }
    }
}
