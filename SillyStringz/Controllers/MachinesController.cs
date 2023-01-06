using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using SillyStringz.Models;
using System.Collections.Generic;
using System.Linq;

namespace SillyStringz.Controllers
{
  public class MachinesController : Controller
  {
    private readonly SillyStringzContext _db;

    public MachinesController(SillyStringzContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Machine> model = _db.Machines.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Machine machine)
    {
      _db.Machines.Add(machine);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Machine thisMachine = _db.Machines
                              .Include(machine => machine.JoinEntities)
                              .ThenInclude(join => join.Engineer)
                              .FirstOrDefault(machine => machine.MachineId == id);
      return View(thisMachine);
    }

  }
}
