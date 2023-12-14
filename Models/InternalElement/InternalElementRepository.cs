using Aml.Engine.CAEX;
using Aml.Engine.CAEX.Extensions;
using amlWeb.Models.Role;
using Attribute = amlWeb.Models.Attribute;

namespace AML.Models.InternalElement;

public class InternalElementRepository
{
    private readonly CAEXDocument file;
    private List<InternalElement> internalElementsList = new List<InternalElement>();

    public InternalElementRepository(CAEXDocument file)
    {
        this.file = file;
        parse();
    }

    private void parse()
    {
        var instanceHierarchy = file.CAEXFile.InstanceHierarchy.First;
        internalElementsList = getChildren(instanceHierarchy);
        foreach (var ie in internalElementsList)
        {
            Console.WriteLine(ie.ToString());
        }
    }

    private static List<Attribute> getAttrs(CAEXWrapper caex)
    {
        var attrsList = new List<Attribute>();

        foreach (var attrs in caex.Descendants<AttributeType>())
            // foreach (var attrs in caex.CAEXChildren("Attribute"))
        {
            // Console.WriteLine($"{attrs}");
            // Console.WriteLine($"{caex} -> {attrs.Name()}={attrs.Value}");
            foreach (var attrName in caex.CAEXChildren("Attribute"))
            {
                if (attrName.Name() == attrs.Name())
                {
                    // Console.WriteLine($"{caex} -> {attrs.Name()}={attrs.Value}");
                    attrsList.Add(new Attribute(attrs.Name(), attrs.Value));
                }
            }
        }

        // caex.TagName;
        return attrsList;
    }

    private static List<InternalElement> getChildren(CAEXWrapper caex)
    {
        var ieList = new List<InternalElement>();
        foreach (var i in caex.CAEXChildren("InternalElement"))
        {
            // Console.WriteLine($"{caex} -> {i}");
            ieList.Add(new InternalElement(i.Name(), getChildren(i), getAttrs(i)));
        }

        return ieList;
    }

    public List<InternalElement> getInternalElements()
    {
        return internalElementsList;
    }
}