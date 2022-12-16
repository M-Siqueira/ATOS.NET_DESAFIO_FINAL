using Microsoft.AspNetCore.Mvc;

namespace SeboFinalAtos.Controllers
{
    public class CategoriumController : Controller
    {
        private readonly ILogger<CategoriumController> _logger;

        public CategoriumController(ILogger<CategoriumController> logger)
        {
            _logger = logger;
        }

        public IActionResult teste()
        {
            return View();
        }
    }
}
