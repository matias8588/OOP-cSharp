using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            CarSalesman steveTheSalesman = new CarSalesman("Steve", "Rogers");
            Console.WriteLine(steveTheSalesman.Fullname);
            steveTheSalesman.Sell();
        }
    }
}
