using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Salesman> salesmen = new List<Salesman>() { new CarSalesman("Steve", "Rogers"), new RetailSalesPerson("Bruce", "Banner"), new CarSalesman("Peter", "Parker"), new InsuranceBroker("Wanda", "Maximoff"), new OnlineMarketer("Natasha", "Romanoff") };

            foreach (var item in salesmen)
            {
                ShowHowToSell(item);
            }

            List<SelfDeveloping> selfDeveloping = new List<SelfDeveloping>() { new RetailSalesPerson("Bruce", "Banner"), new WebDeveloper("Javascript") };

            foreach (var item in selfDeveloping)
            {
                ShowHowDevelop(item);
            }
        }

        static void ShowHowToSell(Salesman salesman)
        {
            salesman.Sell();
        }

        static void ShowHowDevelop(SelfDeveloping selfDeveloping)
        {
            selfDeveloping.Develop();
        }
    }
}
