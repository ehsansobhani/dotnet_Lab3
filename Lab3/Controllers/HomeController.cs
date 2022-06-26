using Lab3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Lab3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        






        public IActionResult SongForm() => View();

        [HttpPost]
        public IActionResult Sing()
        {
            // you will complete this

            
            ViewBag.numberOfBottels = Request.Form["numberOfBottels"];
            ViewData["numberOfBottels"] = Request.Form["numberOfBottels"];
            return View();
        }

        public IActionResult CreatePerson() => View();

        [HttpPost]
        public IActionResult DisplayPerson(Person person)
        {
            // you will complete this
            return View(person);
        }
        public IActionResult Error()
        {
            return View();
        }

    }
}

