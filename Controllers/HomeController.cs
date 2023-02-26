using Microsoft.AspNetCore.Mvc;
using MvcWelcomeApp.Models;
using System.Diagnostics;

namespace MvcWelcomeApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        
        public string Index(string[] users) //(User user)
        {
            //var contextController = this.ControllerContext;

            //return View();

            //return $"Name: {user.Name}, Age: {user.Age}";
            string str = "";
            foreach (var s in users)
                str += s + ", ";
            return str;
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
}