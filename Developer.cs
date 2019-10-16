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

    public virtual void Code(string extraDevLanguage)
    {
        Console.WriteLine(string.Format("Hi! I'm coding using {0}. Aditionally, I'm using {1} as extra language.", this._mainDevLanguage, extraDevLanguage));
    }

    public virtual void Code(string firstExtraDevLanguage, string secondExtraDevLanguage)
    {
        Console.WriteLine(string.Format("Hi! I'm coding using {0}. Aditionally, I'm using {1} and {2}as extra language.", this._mainDevLanguage, firstExtraDevLanguage, secondExtraDevLanguage));
    }
}