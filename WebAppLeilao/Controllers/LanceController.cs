using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PL.Model;
using PL.Model.POCO;

namespace WebAppLeilao.Controllers
{
    public class LanceController : Controller
    {
        private LeilaoContext db = new LeilaoContext();

        // GET: Lance
        public ActionResult Index()
        {
            return View(db.Lances.ToList());
        }

        // GET: Lance/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lance lance = db.Lances.Find(id);
            if (lance == null)
            {
                return HttpNotFound();
            }
            return View(lance);
        }

        // GET: Lance/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Lance/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LanceId,Momento,Valor,IdUsuario")] Lance lance)
        {
            if (ModelState.IsValid)
            {
                db.Lances.Add(lance);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lance);
        }

        // GET: Lance/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lance lance = db.Lances.Find(id);
            if (lance == null)
            {
                return HttpNotFound();
            }
            return View(lance);
        }

        // POST: Lance/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LanceId,Momento,Valor,IdUsuario")] Lance lance)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lance).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lance);
        }

        // GET: Lance/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lance lance = db.Lances.Find(id);
            if (lance == null)
            {
                return HttpNotFound();
            }
            return View(lance);
        }

        // POST: Lance/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Lance lance = db.Lances.Find(id);
            db.Lances.Remove(lance);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
