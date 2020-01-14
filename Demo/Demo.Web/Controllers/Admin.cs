using Microsoft.AspNetCore.Mvc;

namespace Demo.Web.Controllers
{
    public class Admin : Controller
    {
        // GET
        public IActionResult Index()
        {
            return
            View();
        }
    }
}