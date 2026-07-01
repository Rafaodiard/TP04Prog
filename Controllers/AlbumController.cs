using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP04Prog.Models;

namespace TP04Prog.Controllers;

public class AlbumController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

}
