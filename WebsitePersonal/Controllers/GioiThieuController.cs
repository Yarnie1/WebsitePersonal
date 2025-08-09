using Microsoft.AspNetCore.Mvc;

namespace WebsitePersonal.Controllers
{
    public class GioiThieuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}