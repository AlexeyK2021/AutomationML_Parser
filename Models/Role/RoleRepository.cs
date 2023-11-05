using System.Xml.Linq;
using Aml.Engine.CAEX;
using Aml.Engine.CAEX.Extensions;

namespace amlWeb.Models.Role;

public class RoleRepository
{
    private readonly CAEXDocument file;
    private List<RoleClassLib> roleClassLibsList = new List<RoleClassLib>();

    public RoleRepository(CAEXDocument file)
    {
        this.file = file;
        parse();
    }

    public void parse()
    {
        foreach (var rcl in file.CAEXFile.RoleClassLib)
        {
            var roleClassList = new List<RoleClass>();
            foreach (var rc in rcl.CAEXChildren("RoleClass"))
            {
                var attributes = new List<Attribute>();

                foreach (var a in rc.Descendants<AttributeType>())
                {
                    if (a["Value"] != null)
                    {
                        attributes.Add(new Attribute(name: a.Name(), value: a["Value"].ToString()));
                    }
                }

                roleClassList.Add(new RoleClass(name: rc.Name(), attributes: attributes));

                // foreach (var VARIABLE in attributes)
                // {
                //     System.Diagnostics.Debug.WriteLine(VARIABLE.);
                // }
            }

            roleClassLibsList.Add(new RoleClassLib(
                name: rcl.Name(),
                version: rcl.Version,
                rolesList: roleClassList)
            );
        }
    }

    public List<RoleClassLib> getRoles()
    {
        return roleClassLibsList;
    }
}