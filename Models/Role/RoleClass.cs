namespace amlWeb.Models.Role;

public class RoleClass
{
    public string name { get; private set; }
    public List<Attribute> attributes { get; private set; }

    public RoleClass(string name, List<Attribute> attributes)
    {
        this.name = name;
        this.attributes = attributes;
    }

    public RoleClass()
    {
    }
}