
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP04Prog.Models;

namespace TP04Prog.Controllers;

public class FiguritasController : Controller
{
    
    public IActionResult MisFiguritas()
    {
        int? idUsuario = HttpContext.Session.GetInt32("UsuarioId");
            if (idUsuario == null)
            {
                return RedirectToAction("index", "Account");
            }
            int id = idUsuario.Value;
            ViewBag.Figuritas = DB.getFiguritasByUsuario(id);
            return View("Figuritas");
    }
    public IActionResult AbrirSobre()
    {
        return  View();
    }
}


