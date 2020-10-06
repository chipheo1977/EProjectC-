using EProject.Models.EF;
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



    }
}