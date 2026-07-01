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
    public IActionResult Login(string username, string password)
    {
        if (DB.Login(username, password))
        {
            return RedirectToAction("Index", "Album");
        }

        ViewBag.Error = "Usuario o contraseña incorrectos";
        return View("Index");
    }

}
