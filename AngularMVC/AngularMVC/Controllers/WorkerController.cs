using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AngularMVC.Models;
using System.Data.Entity;

namespace AngularMVC.Controllers
{
    public class WorkerController : Controller
    {
        WorkerContext db = new WorkerContext();
        // GET: Worker
        [Authorize]
        public ActionResult ShowWorkers()
        {
           
            return View();
        }

        public JsonResult GetWorkers()
        {
            var workers = db.Workers.Include(w => w.Guild);
            var result = workers.ToList();
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}