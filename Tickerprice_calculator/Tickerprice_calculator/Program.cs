using System;

namespace Tickerprice_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Moi");
            PersonAndTicket Ticket = new PersonAndTicket();
            Ticket.AskDetails();
            Ticket.Price();
        }
    }
}
