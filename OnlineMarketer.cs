using System;

public class OnlineMarketer : Salesman
{
    public OnlineMarketer(string firstName, string lastName) : base(firstName, lastName)
    {

    }

    public override void Sell()
    {
        Console.WriteLine(string.Format("Hi! Mi name is {0}, I would recommend you to buy this online product", this.Fullname));
    }
}