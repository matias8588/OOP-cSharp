using System;

public abstract class Developer
{
    private string _mainDevLanguage;

    public Developer(string mainDevLanguage)
    {
        this._mainDevLanguage = mainDevLanguage;
    }

    public virtual void Code()
    {
        Console.WriteLine(string.Format("Hi! I'm coding using {0}", this._mainDevLanguage));
    }
}