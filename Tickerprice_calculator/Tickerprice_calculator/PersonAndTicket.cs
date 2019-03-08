using System;
using System.Collections.Generic;
using System.Text;

namespace Tickerprice_calculator
{
    class PersonAndTicket
    {
        public string age;
        public string conscript;
        public string mtk;
        public string student;
        public double cost;
        public double reduction;
        public int number;

        public PersonAndTicket()
        {
            this.cost = 16;
            this.reduction = 0;
            this.student = "";
            this.mtk = "";
            this.conscript = "";
            this.age = "";

        }
        public void Price()
        {
            if (number < 8)
            {
                this.reduction = 100;
            }
            else if (number > 64)
            {
                this.reduction = 50;
            }
            else if (number > 7 && number < 65)
            {
                this.cost = 16;
            }

            this.cost = (100 - this.reduction) * this.cost / 100;

            if (this.reduction == 0)
            {
                this.cost = 16;
            }
            Console.WriteLine($"Lippusi hinta on {this.cost}e");
        }
        public void AskDetails()
        {
            Console.WriteLine("Oletko varusmies? Paina K jos olet ja E jos et");
            this.conscript = Console.ReadLine();
            if (this.student.ToLower() == "k")
            {
                this.reduction = 50;
            }

            Console.WriteLine("Oletko opiskelija? Paina K jos olet ja E jos et");
            this.student = Console.ReadLine();
            if (this.student.ToLower() == "k")
            {
                this.reduction = 45;
            }
            Console.WriteLine("Oletko MTK jäsen? Paina K jos olet ja E jos et");
            this.mtk = Console.ReadLine();
            if (this.student.ToLower() == "k")
            {
                this.reduction += 15;
            }

            Console.WriteLine("Syötä ikäsi");
            age = Console.ReadLine();
            while (!Int32.TryParse(this.age, out number))
            {
                Console.WriteLine($"Syötitkö oikean iän? '{this.age}'");
                Console.WriteLine("Syötä ikäsi numeroina");
                this.age = Console.ReadLine();
            }

        }
    }
}

   