using Aml.Engine.CAEX;
using amlWeb.Models.Role;
using Microsoft.AspNetCore.Mvc;

namespace amlWeb.Controllers;

public class RoleController : Controller
{

    public ViewResult rolesList()
    {
        var roleRepository = new RoleRepository(CAEXDocument.LoadFromFile("TestAML.aml"));
        return View(roleRepository.getRoles());
    }
}