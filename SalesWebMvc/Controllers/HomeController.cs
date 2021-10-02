using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models.ViewsModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutMe()
        {
            ViewData["Message"] = "Welcome to my first page!";
            ViewData["Learn"] = "Hi! This is my first academic project, with a .NET ASP Core MVC framework." +
                                " It may sound simple, but it's already a great achievement for me.";
            ViewData["Learn1"] = "I hope in the future, not too far away, to be planning even bolder and more structured solutions.";
            ViewData["Learn2"] = "Feel free to navigate between pages! :)";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new Models.ViewsModels.ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
