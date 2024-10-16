using Microsoft.AspNetCore.Mvc;
using PeopleManager.Ui.Mvc.Core;


namespace PeopleManager.Ui.Mvc.Controllers;

public class PeopleController(Database database) : Controller
{
    private readonly Database _database = database;
    
    public IActionResult Index()
    {
        var people = _database.People;
        return View(people);

    }
}