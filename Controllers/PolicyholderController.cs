using Microsoft.AspNetCore.Mvc;

namespace awasur.Controllers;

public class PolicyholderController: Controller
{
    public IActionResult Create()
    {
        return View();
    }
}