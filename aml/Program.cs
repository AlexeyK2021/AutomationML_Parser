using System.Collections.Generic;
using System.IO;
using System.Reflection.PortableExecutable;
using Aml.Engine.CAEX;
using Aml.Engine.CAEX.Extensions;
using static System.Console;

class Hello
{
    public static void Main()
    {
        // WriteLine("Current Dir:" + Directory.GetCurrentDirectory());
        var document = CAEXDocument.LoadFromFile("../../../../TestAML.aml");
        var elements = document.CAEXFile.InstanceHierarchy;

        // foreach (var el in elements)
        // {
        //     WriteLine(el.CAEXChild("InternalElement").CAEXChild("InternalElement").CAEXChild("ExternalInterface").CAEXChild("ExternalInterface").Name());
        // }


        foreach (var instanceHierarchy in document.CAEXFile.InstanceHierarchy)
        {
            WriteLine($"1{instanceHierarchy}: ");
            foreach (var internalElement in instanceHierarchy.CAEXChildren("InternalElement"))
            {
                WriteLine("\tIE: "+internalElement.Name() + ":");
                foreach (var ei in internalElement.Descendants<ExternalInterfaceType>())
                {
                    WriteLine("\t\tEI: " + ei.Name);
                }
                foreach (var rc in internalElement.Descendants<RoleClassType>())
                {
                    WriteLine("\t\tRC: " + rc.Name);
                }
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
