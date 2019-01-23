using System;

namespace CarProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Car NewCar = new Car();
            NewCar.AskData();
            NewCar.ShowCarInfo();
            Console.WriteLine("Lisää nopeutta");
            NewCar.Accelerate(int.Parse(Console.ReadLine()));
            NewCar.Brake();

            Console.WriteLine("\n-----------------------------\n");

            Car NewCar1 = new Car();
            NewCar1.AskData();
            NewCar1.ShowCarInfo();
            Console.WriteLine("Lisää nopeutta");
            NewCar1.Accelerate(int.Parse(Console.ReadLine()));
            NewCar1.Brake();

        }
    }
}
