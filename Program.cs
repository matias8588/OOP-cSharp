using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            WebDeveloper mikeTheWebDeveloper = new WebDeveloper("React");
            mikeTheWebDeveloper.Code();
            mikeTheWebDeveloper.Code("C#");
            mikeTheWebDeveloper.Code("C#", "HTML");
            mikeTheWebDeveloper.Code(null, "HTML");
        }
    }
}
