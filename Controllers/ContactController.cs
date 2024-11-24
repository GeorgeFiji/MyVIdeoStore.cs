using Microsoft.AspNetCore.Mvc;

namespace MyVideostore.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
