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
    public IActionResult Profile()
    {
        int? usuarioId = HttpContext.Session.GetInt32("UsuarioId");
        
        if (usuarioId == null)
        {
            return RedirectToAction("Index");
        }
        
        ViewBag.usuario = DB.GetUsuarioById(usuarioId.Value);
        return View();
    }
    public IActionResult ChangePassword()
    {
        return View();
    }
    
    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index", "Home");
    }


    [HttpPost]
    public IActionResult Login(LogInViewModel l)
    {
        Usuarios u = DB.Login(l);

        if(u != null)
        {
            HttpContext.Session.SetInt32("UsuarioId", u.ID);

            return RedirectToAction("Index", "Album");
        }
        ViewBag.Error = "Usuario o contraseña incorrectos";
        return View("LogIn");
    }
    [HttpPost]
    public IActionResult Register(Usuarios u)
    {
        DB.Register(u);
        HttpContext.Session.SetInt32("UsuarioId", u.ID);
        return RedirectToAction("Index", "Album");

    }

    [HttpPost]

    public IActionResult ChangePassword(string currentPassword, string newPassword, string confirmPassword)
    {
        int? usuarioId = HttpContext.Session.GetInt32("UsuarioId");
        Usuarios usuario = DB.GetUsuarioById(usuarioId.Value);

        if (usuario == null)
        {
            return RedirectToAction("Index", "Account");
        }

        if (usuario.Password != currentPassword)
        {
            ViewBag.Error = "La contraseña actual es incorrecta.";
            return View();
        }

        if (newPassword != confirmPassword)
        {
            ViewBag.Error = "Las nuevas contraseñas no coinciden.";
            return View();
        }

        usuario.Password = newPassword;
        DB.UpdateUsuario(usuario);

        ViewBag.Message = "Contraseña cambiada exitosamente.";
        return View();
    }


    
}
