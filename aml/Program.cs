using System;
using Aml.Engine.CAEX;
using static System.Console;

class Hello
{
    public static void Main()
    {
        var document = CAEXDocument.LoadFromFile("..\\..\\..\\TestAML.aml");
        var elements = document.CAEXFile.InstanceHierarchy.Elements;
        foreach(var el in elements){
            WriteLine(el.ToString());
        }
    }
}
