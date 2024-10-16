using PeopleManager.Ui.Mvc.Models;

namespace PeopleManager.Ui.Mvc.Core;

public class Database
{
    public IList<Person> People { get; set; } = new List<Person>();

    public void Seed()
    {
        People = new List<Person>();

    }
}