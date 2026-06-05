using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BoletimNotas.Models;

namespace BoletimNotas.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
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

    public IActionResult Boletim()
    {
        List<string> disciplinas = new List<string>
        {
            "Matemática",
            "Português",
            "História",
            "Geografia",
            "Física"
        };

        List<double> notas = new List<double>
        {
            9.5,
            8.0,
            6.5,
            4.0,
            7.5
        };

        ViewBag.Disciplinas = disciplinas;
        ViewBag.Notas = notas;

        return View();
    }
}
