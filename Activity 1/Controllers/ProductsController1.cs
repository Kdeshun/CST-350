using Microsoft.AspNetCore.Mvc;

namespace ASPCoreFirstApp2.Controllers
{
    public class ProductsController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Message() 
        {
            return View();
        }
        public IActionResult Details(string name, int personality = 9)
        {
            ViewData["Name"] = name;
            ViewData["Personality"] = personality;
            return View("Message");
        }

        // return some json data
        public IActionResult Data(int OrderNumber, float Price, int qty) 
        {
            return Json(new { OrderNumber = OrderNumber, Price = Price, qty = qty });
        }
    }
}
