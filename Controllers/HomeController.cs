using Microsoft.AspNetCore.Mvc;
using SimpleDotNetApp.Models;

namespace SimpleDotNetApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var message = new Message { Content = "Hello from Azure App Service!" };
            return View(message);
        }
    }
}