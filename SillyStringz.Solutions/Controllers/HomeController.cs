using Microsoft.AspNetCore.Mvc;

namespace SillyStringz.Solutions.Controllers 
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