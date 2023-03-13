using Microsoft.AspNetCore.Mvc;

namespace SharpSystem.Web.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
