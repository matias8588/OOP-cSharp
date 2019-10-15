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
}