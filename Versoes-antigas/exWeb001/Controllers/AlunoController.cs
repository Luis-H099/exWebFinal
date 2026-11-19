using Microsoft.AspNetCore.Mvc;

namespace exWeb001.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
