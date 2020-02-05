using Microsoft.AspNetCore.Mvc;

namespace Temp.Web.Controllers
{
    public class AdminController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return
            View();
        }
    }
}