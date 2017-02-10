using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GummyBearsForever.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace GummyBearsForever.Controllers
{
    public class InventoryController : Controller
    {
        private GummyBearsForeverDbContext db = new GummyBearsForeverDbContext();
        public IActionResult Index()
        {
            return View(db.Inventories.ToList());
            
        }
        public IActionResult Details(int id)
        {
            var thisGummy = db.Inventories
                .FirstOrDefault(inventories => inventories.GummyId == id);
            return View(thisGummy);
       }
    //    public ActionResult Create()
    //    {
    //        ViewBag.LocationId = new SelectList(db.Locations, "LocationId", "LocationName");

    //        ViewBag.MealTypeId = new SelectList(db.MealTypes, "MealTypeId", "MealTypeName");
    //        return View();
    //    }
    //    [HttpPost]
    //    public ActionResult Create(Experience experience)
    //    {
    //        db.Experiences.Add(experience);
    //        db.SaveChanges();
    //        return RedirectToAction("Index");
    //    }
    //    public ActionResult Update(int id)
    //    {
    //        var thisExperience = db.Experiences.FirstOrDefault(experience => experience.ExperienceId == id);
    //        ViewBag.LocationId = new SelectList(db.Locations, "LocationId", "LocationName");

    //        ViewBag.MealTypeId = new SelectList(db.MealTypes, "MealTypeId", "MealTypeName");
    //        return View(thisExperience);
    //    }
    //    [HttpPost]
    //    public ActionResult Update(Experience experience)
    //    {
    //        db.Entry(experience).State = EntityState.Modified;
    //        db.SaveChanges();
    //        return RedirectToAction("Index");
    //    }
    //    public ActionResult Delete(int id)
    //    {
    //        var thisExperience = db.Experiences.FirstOrDefault(experiences => experiences.ExperienceId == id);
    //        return View(thisExperience);
    //    }

    //    [HttpPost, ActionName("Delete")]
    //    public ActionResult DeleteConfirmed(int id)
    //    {
    //        var thisExperience = db.Experiences.FirstOrDefault(experiences => experiences.ExperienceId == id);
    //        db.Experiences.Remove(thisExperience);
    //        db.SaveChanges();
    //        return RedirectToAction("Index");
    //    }



    }
}