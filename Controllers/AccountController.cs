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
    public IActionResult Register()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Login(LogInViewModel l)
    {
        Usuarios u = DB.Login(l);

        if(u != null)
        {
            return RedirectToAction("Index", "Album", new { idUsuario = u.ID });
        }
        ViewBag.Error = "Usuario o contraseña incorrectos";
        return View("LogIn");
    }
    
}
