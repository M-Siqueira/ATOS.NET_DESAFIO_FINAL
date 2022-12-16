using Microsoft.AspNetCore.Mvc;

namespace SeboFinalAtos.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
