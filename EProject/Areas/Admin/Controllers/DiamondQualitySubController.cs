using EProject.Models.EF;
using EProject.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EProject.Areas.Admin.Controllers
{
    public class DiamondQualitySubController : Controller
    {
        Repository<DimQlySubMst> subQuanlity = new Repository<DimQlySubMst>();
        // GET: Admin/DiamondQuanlitySub
        public ActionResult Index()
        {
            var data = subQuanlity.Get().ToList();
            return View(data);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(DimQlySubMst quality)
        {
            if (ModelState.IsValid)
            {
                subQuanlity.Add(quality);
                return RedirectToAction("index");
            }
            return View();
        }

        public ActionResult Edit(string id)
        {
            var data = subQuanlity.Get(id);
            return View(data);
        }
        [HttpPost]
        public ActionResult Edit(DimQlySubMst quanlity)
        {
            if (ModelState.IsValid)
            {
                subQuanlity.Edit(quanlity);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(string id)
        {
            subQuanlity.Remove(id);
            return RedirectToAction("Index");
        }
    }
}