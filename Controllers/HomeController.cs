using Microsoft.AspNet.Mvc;
using MvcSample.Web.Models;

namespace MvcSample.Web
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(Countdown());
        }

         public ChristmasCount Countdown()
        {
            ChristmasCount user = new ChristmasCount();

            return user;
        }
    }
}