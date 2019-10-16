using System;

public class RetailSalesPerson : Salesman, SelfDeveloping
{
    public RetailSalesPerson(string firstName, string lastName) : base(firstName, lastName)
    {
    }

    public void Develop()
    {
        Console.WriteLine("I develop myself watching retail sales training videos.");
    }

    protected override void AddressConcerns()
    {
        Console.WriteLine("Everything is 80% discount");
    }

    protected override void Close()
    {
        Console.WriteLine("Buy this pen!");
    }

    protected override void DemoValue()
    {
        Console.WriteLine("Our customers love it!");
    }

    protected override void Engage()
    {
        Console.WriteLine(string.Format("Hi! Mi name is {0}, I would recommend you to buy this pen", this.Fullname));
    }

    protected override void EstablishTrusts()
    {
        Console.WriteLine("I just want to help you :)");
    }
}