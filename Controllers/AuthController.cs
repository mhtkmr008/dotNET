using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EStoreWebApp.Models;
using HRAPP.Entities;

namespace EStoreWebApp.Controllers;

public class AuthController : Controller
{


    [HttpGet]
    public IActionResult SignIn()
    {
        return View();

    }

    

    [HttpPost]
    public IActionResult SignIn(string uname, string psw)
    {
        if(uname=="ravi" && psw=="seed"){
          return RedirectToAction("Bar","Dashboard",null);
        }
        return View();
    }

    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Register(string Id, string name)
    {   
          int id=int.Parse(Id);

        Employee emp=new Employee(id,name);
        return RedirectToAction("addEmployee","Employees",emp);
    }

    

    public IActionResult ChangePassword(){
        return View();
    }
    
}
