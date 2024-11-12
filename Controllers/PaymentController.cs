using Microsoft.AspNetCore.Mvc;
using awasur.Models;

namespace awasur.Controllers;

public class PaymentController: Controller
{
    private AwasurContext db;
    public PaymentController(AwasurContext _db)
    {
        db = _db;
    }
    public IActionResult Create()
    {       
        return View();
    }
}