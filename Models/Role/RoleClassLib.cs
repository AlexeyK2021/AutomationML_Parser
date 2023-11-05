namespace amlWeb.Models.Role;

public class RoleClassLib
{
    public string name { get; private set; }
    public string version { get; private set; }
    public List<RoleClass> rolesList { get; private set; }

    public RoleClassLib(List<RoleClass> rolesList, string name, string version)
    {
        this.rolesList = rolesList;
        this.name = name;
        this.version = version;
    }
}