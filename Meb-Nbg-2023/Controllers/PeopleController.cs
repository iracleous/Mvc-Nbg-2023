using Meb_Nbg_2023.Models;
using Microsoft.AspNetCore.Mvc;

namespace Meb_Nbg_2023.Controllers
{
    public class PeopleController : Controller
    {
        public IActionResult Index()
        {
            Person person = new() { Id = 70, Name = "D", Description = "my description" };
            return View(person);
        }
    }
}
