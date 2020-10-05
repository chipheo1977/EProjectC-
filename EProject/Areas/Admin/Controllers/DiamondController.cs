using EProject.Models.EF;
using EProject.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EProject.Areas.Admin.Controllers
{
    public class DiamondController : Controller
    {
        IRepository<DimMst> db = new Repository<DimMst>();

        // GET: Admin/Diamond
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
        public ActionResult Create(DimMst dim)
        {
            if (ModelState.IsValid)
            {
                db.Add(dim);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}