using System;

public class CarSalesman
{
    private string _firstName;
    private string _lastName;
    public string Fullname
    {
        get
        {
            return string.Format("{0} {1}", this._firstName, this._lastName);
        }
    }
    public CarSalesman(string firstName, string lastName)
    {
        this._firstName = firstName;
        this._lastName = lastName;
    }

    public void Sell()
    {
        Console.WriteLine(string.Format("Hi! My name is {0}. I would recommend you to buy this car.", this.Fullname));
    }
}