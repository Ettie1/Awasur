using Microsoft.AspNetCore.Mvc;

namespace awasur.Controllers;

public class MenuController: Controller
{
    public IActionResult MainMenu()
    {
        ViewBag.Title = $"Main menu";
        return View();
    }
    public IActionResult MenuCustomers()
    {

        ViewBag.Title = "Customer Menu";
        return View();

    }
}