namespace amlWeb.Models.Role;

public class RoleClass
{
    public string name { get; private set; }

    public RoleClass(string name)
    {
        this.name = name;
    }
}