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
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Inventory inventory)
        {
            db.Inventories.Add(inventory);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Update(int id)
        {
            var thisGummy = db.Inventories.FirstOrDefault(inventory => inventory.GummyId == id);
            return View(thisGummy);
        }
        [HttpPost]
        public ActionResult Update(Inventory inventory)
        {
            db.Entry(inventory).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
       public ActionResult Delete(int id)
        {
            var thisGummy = db.Inventories.FirstOrDefault(inventories => inventories.GummyId == id);
            return View(thisGummy);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var thisGummy = db.Inventories.FirstOrDefault(inventories => inventories.GummyId == id);
            db.Inventories.Remove(thisGummy);
            db.SaveChanges();
            return RedirectToAction("Index");
        }



    }
}