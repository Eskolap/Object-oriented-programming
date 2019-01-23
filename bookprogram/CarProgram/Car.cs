using System;
using System.Collections.Generic;
using System.Text;

namespace CarProgram
{
    class Car
    {
        public string  Brand;
        public double Speed;
        

        public Car()
        {
        }
        public void AskData()
        {
            Console.Write("Syötä merkki: ");
            Brand = Console.ReadLine();
            Console.Write("Syötä huippunopeus: ");
            string speedValue = Console.ReadLine();
            if (!string.IsNullOrEmpty(speedValue))
            {
                Speed = int.Parse(speedValue);
            }
        }    
        public void ShowCarInfo()
        {
            Console.WriteLine($"{Brand} huippunopeus on {Speed}");
        }
        public void Accelerate(int iSpeed)
        {
            if (iSpeed > 0)
            {
                this.Speed += iSpeed;
                Console.WriteLine($"Nopeutta lisättiin {iSpeed}, uusi nopeus on {this.Speed} km/h\n");
            }
            else if (iSpeed == 0)
            {
                Console.WriteLine("Ei muutosta");
            }
            else
            {
                Console.WriteLine("Hidastusta ei sallita");
            }
           
        }
        public void Brake()
        {
            Speed = 90 * Speed / 100;
            Console.WriteLine($"Jarrutit ja nopeutesi on {Speed} km/h");
        }
    }
}
