using Microsoft.AspNetCore.Mvc;

namespace Front_to_back__Connect_to_SQL__EF.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();  
        }
        
    }
}
