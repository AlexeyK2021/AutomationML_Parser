using System.Xml.Linq;

namespace amlWeb.Models;

public class Attribute
{
    public string name { get; private set; }
    public string value { get; private set; }

    public Attribute(string name, string value)
    {
        this.name = name;
        this.value = value;
    }

    public Attribute(XElement roleAttr)
    {
        name = roleAttr.Attribute("Name").Value;
        value = roleAttr.Value;
    }
}