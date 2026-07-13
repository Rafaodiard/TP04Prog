using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP04Prog.Models;

namespace TP04Prog.Controllers;

public class AlbumController : Controller
{
    public IActionResult Index()
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
        ViewBag.Selecciones = DB.GetSelecciones(id);
        return View();
    }
[HttpPost]
public IActionResult Pegar([FromBody] PegarViewModel datos)
{
    ViewBag.Cantidad = DB.GetCantidadPegadas(HttpContext.Session.GetInt32("UsuarioId").Value);
    int idUsuario = HttpContext.Session.GetInt32("UsuarioId").Value;

    DB.PegarFigurita(idUsuario, datos.idFigurita);

    return Ok();
}

}
