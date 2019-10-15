using System;

public class CarSalesman : Salesman
{
    public CarSalesman(string firstName, string lastName) : base(firstName, lastName)
    {

    }

    public override void Sell()
    {
        Console.WriteLine(string.Format("Hi! Mi name is {0}, I would recommend you to buy this car", this.Fullname));
    }
}