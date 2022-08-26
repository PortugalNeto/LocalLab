using Microsoft.AspNetCore.Mvc;

namespace LocalLab.Controllers
{
    public class VisitanteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
