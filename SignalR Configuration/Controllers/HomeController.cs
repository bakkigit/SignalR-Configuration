using Microsoft.AspNetCore.Mvc;

namespace SignalR_Configuration.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
