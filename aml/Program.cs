using System.Collections.Generic;
using Aml.Engine.CAEX;
using Aml.Engine.CAEX.Extensions;
using static System.Console;

class Hello
{
    public static void Main()
    {
        var document = CAEXDocument.LoadFromFile("..\\..\\..\\TestAML.aml");
        var elements = document.CAEXFile.InstanceHierarchy;

        // foreach (var el in elements)
        // {
        //     WriteLine(el.CAEXChild("InternalElement").CAEXChild("InternalElement").CAEXChild("ExternalInterface").CAEXChild("ExternalInterface").Name());
        // }


        foreach (var instanceHierarchy in document.CAEXFile.SystemUnitClassLib)
        {
            foreach (var internalElement in instanceHierarchy.Descendants<SystemUnitClassType>())
            {
                WriteLine(internalElement.Name);
            }
        }
    }

    private static void printSome(List<CAEXWrapper> Element)
    {
        foreach (var el in Element)
        {
            WriteLine(el.Name());
        }
    }
}
