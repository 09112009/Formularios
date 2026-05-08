using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Formularios.Models;

namespace Formularios.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index(int edad, string trabajo , int ingreso ,  int monto , int deudas , string terminos)
    {
        if (edad < 18 || trabajo = "no" || ingreso < 250.000 || monto < 5 * ingreso || deudas = "si" || terminos = "no")
        {
          return View("noApto.cshtml");
        }
        return View("apto.cshtml");
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
