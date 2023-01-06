using Microsoft.AspNetCore.Mvc;
using SillyStringz.Models;
using System.Collections.Generic;

namespace SillyStringz.Controllers
{
    public class HomeController : Controller
    {

    private readonly SillyStringzContext _db;

    public HomeController(SillyStringzContext db)
    {
      _db = db;
    }

      [HttpGet("/")]
      public ActionResult Index()
      {
        ViewBag.Machine = new List<Machine>(_db.Machines);
        ViewBag.Engineer = new List<Engineer>(_db.Engineers);
        return View(ViewBag.Machine);
      }

    }
}