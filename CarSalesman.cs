using System;

public class CarSalesman : Salesman
{
    public CarSalesman(string firstName, string lastName) : base(firstName, lastName)
    {

    }

    protected override void AddressConcerns()
    {
        Console.WriteLine("Buy your first car with 10% discount");
    }

    protected override void Close()
    {
        Console.WriteLine("Buy this car!");
    }

    protected override void DemoValue()
    {
        Console.WriteLine("We give a guarantee of 3 years");
    }

    protected override void Engage()
    {
        Console.WriteLine(string.Format("Hi! Mi name is {0}, I would recommend you to buy this car", this.Fullname));
    }

    protected override void EstablishTrusts()
    {
        Console.WriteLine("Do you want to take a test drive?");
    }
}