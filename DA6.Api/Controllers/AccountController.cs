using Microsoft.AspNetCore.Mvc;

namespace DA6.Api.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
