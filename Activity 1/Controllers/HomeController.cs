using System.Diagnostics;
using ASPCoreFirstApp2.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPCoreFirstApp2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            ViewData["Message"] = "This is going to be a great day.";
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "This is the about page.";
            return View("AboutMe");
        }
        public IActionResult Projects()
        {
            return View();
        }
        public IActionResult FAQs()
        {
            ViewData["Message"] = "A list of frequently asked questions to address common inquiries about the project.";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
