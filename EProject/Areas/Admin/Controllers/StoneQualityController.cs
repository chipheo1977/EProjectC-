﻿using EProject.Models.EF;
using EProject.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EProject.Areas.Admin.Controllers
{
    public class StoneQualityController : Controller
    {
        IRepository<StoneQltyMst> db = new Repository<StoneQltyMst>();

        // GET: Admin/StoneQuality
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
        public ActionResult Create(StoneQltyMst quality)
        {
            if (ModelState.IsValid)
            {
                db.Add(quality);
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
        public ActionResult Edit(StoneQltyMst quality)
        {
            if (ModelState.IsValid)
            {
                db.Edit(quality);
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