using Microsoft.AspNetCore.Mvc;
using awasur.Models;
using Microsoft.EntityFrameworkCore;

namespace awasur.Controllers;

public class AppController: Controller
{
    private AwasurContext db;
    public AppController(AwasurContext _db)
    {
        db=_db;
    }
    
    public IActionResult CreateCustomer()
    {
        ViewBag.Title = "Create customer";
        CustomerViewModel cvm = new CustomerViewModel();
        cvm.InsuranceTypes = db.InsuranceTypes;
        return View(cvm);
    }
    [HttpPost]
    public IActionResult CreateCustomer(CustomerViewModel customerviewmodel)
    {
        
        
        db.Customers.Add(customerviewmodel.Customer);
        db.SaveChanges();

        int cId = customerviewmodel.Customer.Id;
        
        customerviewmodel.Policy.CoverageDetails = customerviewmodel.InsuranceType.Name;
        customerviewmodel.Policy.CustomerId = cId;
            
            customerviewmodel.Contact.CustomerId = cId;
            db.Contacts.Add(customerviewmodel.Contact);
        
        
            customerviewmodel.Address.CustomerId = cId;
            db.Addresses.Add(customerviewmodel.Address);

            db.Policies
            .Add(customerviewmodel.Policy);

        db.SaveChanges();
        

        return RedirectToAction("MenuCustomers", "Menu");
        
        
    }

    public IActionResult CustomerList()
    {
        return View(db.Customers);
    }
    public IActionResult SearchCustomer()
    {
        return View();
    }
    [HttpPost]
    public IActionResult SearchCustomer(string firstname, string lastname)
    {
        if(!string.IsNullOrEmpty(lastname))
        {
            return View(db.Customers.Where(c => c.LastName == lastname));
        }
        
        return View();
    }
    
    public IActionResult EditCustomer(int id)
    {
        
        return View(db.Customers.SingleOrDefault(c=>c.Id==id));
    }

    public IActionResult CustomerDetails(int id)
    {
        return View(db.Customers.SingleOrDefault(c=>c.Id==id));
    }


}
