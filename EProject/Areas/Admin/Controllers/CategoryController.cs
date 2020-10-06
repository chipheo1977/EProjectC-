using EProject.Models.EF;
using EProject.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EProject.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        IRepository<CatMst> db = new Repository<CatMst>();
        // GET: Admin/Category
        public ActionResult Index()
        {
            var data = db.Get().ToList();
            return View(data);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(CatMst cat)
        {
            if (ModelState.IsValid)
            {
                db.Add(cat);
                return RedirectToAction("Index");
            }
            return View();
        } 

        public ActionResult Edit(string id)
        {
            var data = db.Get(id);
            return View(data);
        }
        [HttpPost]
        public ActionResult Edit(CatMst cat)
        {
            if (ModelState.IsValid)
            {
                db.Edit(cat);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(string id)
        {
            db.Remove(id);
            return RedirectToAction("Index");
        }
    }
}