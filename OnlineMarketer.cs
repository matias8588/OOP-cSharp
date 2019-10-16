using System;

public class OnlineMarketer : Salesman
{
    public OnlineMarketer(string firstName, string lastName) : base(firstName, lastName)
    {

    }

    protected override void AddressConcerns()
    {
        Console.WriteLine("Take two by the price of one!");
    }

    protected override void Close()
    {
        Console.WriteLine("Buy this online product!");
    }

    protected override void DemoValue()
    {
        Console.WriteLine("Our company is one of the best in the market");
    }

    protected override void Engage()
    {
        Console.WriteLine(string.Format("Hi! Mi name is {0}, I would recommend you to buy this online product", this.Fullname));
    }

    protected override void EstablishTrusts()
    {
        Console.WriteLine("Let's talk for a few minutes");
    }
}