using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP04Prog.Models;

namespace TP04Prog.Controllers;

public class AccountController : Controller
{
    public IActionResult Index()
    {
        return View("LogIn");
    }
    [HttpPost]
    public IActionResult Login(string Usuario, string password)
    {
        if (DB.Login(usuario, password))
        {
            return RedirectToAction("Index", "Album");
        }
        else
        {
            return View("LogIn");

        }
    }

}
