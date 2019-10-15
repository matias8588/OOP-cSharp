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

            RetailSalesPerson bruceTheRetailSalesPerson = new RetailSalesPerson("Bruce", "Banner");
            Console.WriteLine(bruceTheRetailSalesPerson.Fullname);
            bruceTheRetailSalesPerson.Sell();
            bruceTheRetailSalesPerson.Develop();

            WebDeveloper mikeTheWebDeveloper = new WebDeveloper("React");
            mikeTheWebDeveloper.Code();
            mikeTheWebDeveloper.Develop();
        }
    }
}
