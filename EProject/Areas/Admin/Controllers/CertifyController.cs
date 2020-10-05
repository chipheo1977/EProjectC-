using EProject.Models.EF;
using EProject.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EProject.Areas.Admin.Controllers
{
    public class CertifyController : Controller
    {
        IRepository<CertifyMst> db = new Repository<CertifyMst>();

        // GET: Admin/Certify
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
        public ActionResult Create(CertifyMst certify)
        {
            if (ModelState.IsValid)
            {
                db.Add(certify);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(string id)
        {
            var data = db.Get(id);
            return View(data);
        }
    }
}