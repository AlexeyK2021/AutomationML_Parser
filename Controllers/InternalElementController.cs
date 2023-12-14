using Aml.Engine.CAEX;
using amlWeb.Models.InternalElement;
using Microsoft.AspNetCore.Mvc;

namespace amlWeb.Controllers;

public class InternalElementController: Controller
{
    public ViewResult ieList()
    {
        var internalElementRepository = new InternalElementRepository(CAEXDocument.LoadFromFile("TestAML.aml"));
        return View(internalElementRepository.getInternalElements());
    }
}