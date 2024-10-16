using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PeopleManager.Ui.Mvc.Models;
using PeopleManager.Ui.Mvc.Core;

namespace PeopleManager.Ui.Mvc.Controllers;

public class HomeController : Controller
{
    private readonly Database _database;
    public HomeController(Database database)
    {
        _database = database;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Piano()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}