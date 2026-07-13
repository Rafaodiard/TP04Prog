
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP04Prog.Models;

namespace TP04Prog.Controllers;

public class FiguritasController : Controller
{
    
    public IActionResult MisFiguritas()
    {
int? IdUsuario = HttpContext.Session.GetInt32("UsuarioId");

if (IdUsuario != null)
{
    ViewBag.Cantidad = DB.GetCantidadPegadas(IdUsuario.Value);
}        int? idUsuario = HttpContext.Session.GetInt32("UsuarioId");
            if (idUsuario == null)
            {
                return RedirectToAction("index", "Account");
            }
            int id = idUsuario.Value;
            ViewBag.Figuritas = DB.getFiguritasByUsuario(id);
            return View("Figuritas");
    }
    public IActionResult Sobre()
    {
int? IdUsuario = HttpContext.Session.GetInt32("UsuarioId");

if (IdUsuario != null)
{
    ViewBag.Cantidad = DB.GetCantidadPegadas(IdUsuario.Value);
}        string? sobre = HttpContext.Session.GetString("SobreActual");
        int? usuarioId = HttpContext.Session.GetInt32("UsuarioId");

        if(sobre != null)
        {
            ViewBag.hayFiguritas = true;

        }
        else
        {
            ViewBag.hayfiguritas = false;
        }

        if (usuarioId == null)
        {
            return RedirectToAction("Index", "Account");
        }
        else
        {
            return  View();
        }
    }
    public IActionResult AbrirSobre()
    {
int? IdUsuario = HttpContext.Session.GetInt32("UsuarioId");

if (IdUsuario != null)
{
    ViewBag.Cantidad = DB.GetCantidadPegadas(IdUsuario.Value);
}        List<Figuritas> figus = DB.getFiguritasx5();
        string ids = "";

        foreach(Figuritas f in figus)
        {
            ids += f.ID + ",";
        }

        HttpContext.Session.SetString("SobreActual", ids);

        return Json(figus);
    }
    public IActionResult Cargar()
    { 
int? IdUsuario = HttpContext.Session.GetInt32("UsuarioId");

if (IdUsuario != null)
{
    ViewBag.Cantidad = DB.GetCantidadPegadas(IdUsuario.Value);
}        string ids = HttpContext.Session.GetString("SobreActual");
        List<Figuritas> figuritas = new List<Figuritas>();

        foreach(string id in ids.Split(','))
        {
            if(id != "")
            {
                Figuritas f = DB.GetFiguritaById(int.Parse(id));
                f.Jugador = DB.GetJugador(f.idJugador);

                figuritas.Add(f);
            }
        }

        return Json(figuritas);
    }
    [HttpPost]

    public IActionResult GuardarFiguritas()
    {
int? IdUsuario = HttpContext.Session.GetInt32("UsuarioId");

if (IdUsuario != null)
{
    ViewBag.Cantidad = DB.GetCantidadPegadas(IdUsuario.Value);
}       int idUsuario = HttpContext.Session.GetInt32("UsuarioId").Value;
        string ids = HttpContext.Session.GetString("SobreActual");
        string[] lista = ids.Split(',');
        foreach(string id in lista)
        {
            if(id != "")
            {
                DB.AgregarFigurita(idUsuario, int.Parse(id));
            }
        }
        HttpContext.Session.Remove("SobreActual");
        return Ok();
    }
}


