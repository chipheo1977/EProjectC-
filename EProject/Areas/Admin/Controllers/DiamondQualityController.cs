using EProject.Models.EF;
using EProject.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EProject.Areas.Admin.Controllers
{
    public class DiamondQualityController : Controller
    {
        IReppository<DimQltyMst> qualities = new Repository<DimQltyMst>();

        // GET: Admin/DiaQlty
        public ActionResult Index()
        {
            var data = qualities.Get().ToList();
            return View(data);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(DimQltyMst qlty)
        {
            if (ModelState.IsValid)
            {
                qualities.Add(qlty);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(string id)
        {
            var data = qualities.Get(id);
            return View(data);
        }
        [HttpPost]
        public ActionResult Edit(DimQltyMst dim)
        {
            if (ModelState.IsValid)
            {
                qualities.Edit(dim);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(string id)
        {
            qualities.Remove(id);
            return RedirectToAction("Index");
        }
    }
}