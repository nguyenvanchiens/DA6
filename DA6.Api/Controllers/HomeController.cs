using Microsoft.AspNetCore.Mvc;

namespace DA6.Api.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
