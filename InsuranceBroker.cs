using System;

public class InsuranceBroker : Salesman
{
    public InsuranceBroker(string firstName, string lastName) : base(firstName, lastName)
    {
    }

    protected override void AddressConcerns()
    {
        Console.WriteLine("Buy now and get two months discount");
    }

    protected override void Close()
    {
        Console.WriteLine("Buy this insurance!");
    }

    protected override void DemoValue()
    {
        Console.WriteLine("Our clients love us");
    }

    protected override void Engage()
    {
        Console.WriteLine(string.Format("Hi! Mi name is {0}, I would recommend you to buy this insurance", this.Fullname));
    }

    protected override void EstablishTrusts()
    {
        Console.WriteLine("Can I show you our benefits?");
    }
}