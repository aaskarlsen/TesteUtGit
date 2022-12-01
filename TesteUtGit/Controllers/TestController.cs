using Microsoft.AspNetCore.Mvc;

namespace TesteUtGit.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
