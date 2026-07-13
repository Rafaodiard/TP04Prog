using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP04Prog.Models;

namespace TP04Prog.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;

    }

    public IActionResult Index()
    {
int? IdUsuario = HttpContext.Session.GetInt32("UsuarioId");

if (IdUsuario != null)
{
    ViewBag.Cantidad = DB.GetCantidadPegadas(IdUsuario.Value);
}
        return View();
    }
    public IActionResult Login()
    {
        int? usuarioId = HttpContext.Session.GetInt32("UsuarioId");
int? IdUsuario = HttpContext.Session.GetInt32("UsuarioId");

if (IdUsuario != null)
{
    ViewBag.Cantidad = DB.GetCantidadPegadas(IdUsuario.Value);
}
        if (usuarioId == null)
        {
            return RedirectToAction("Index", "Account");
        }
        else
        {
            return RedirectToAction("Profile", "Account");
        }
    }
    public IActionResult Register()
    {
        int? usuarioId = HttpContext.Session.GetInt32("UsuarioId");
int? IdUsuario = HttpContext.Session.GetInt32("UsuarioId");

if (IdUsuario != null)
{
    ViewBag.Cantidad = DB.GetCantidadPegadas(IdUsuario.Value);
}
        if (usuarioId == null)
        {
            return RedirectToAction("Register", "Account");
        }
        else
        {
            return RedirectToAction("Profile", "Account");
        }
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
