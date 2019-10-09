using Microsoft.AspNetCore.Mvc;

namespace BigfootTracker.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}