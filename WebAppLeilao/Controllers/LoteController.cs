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
    public class LoteController : Controller
    {
        private LeilaoContext db = new LeilaoContext();

        // GET: Lote
        public ActionResult Index()
        {
            return View(db.Lotes.ToList());
        }

        // GET: Lote/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lote lote = db.Lotes.Find(id);
            if (lote == null)
            {
                return HttpNotFound();
            }
            return View(lote);
        }

        // GET: Lote/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Lote/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LoteId")] Lote lote)
        {
            if (ModelState.IsValid)
            {
                db.Lotes.Add(lote);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lote);
        }

        // GET: Lote/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lote lote = db.Lotes.Find(id);
            if (lote == null)
            {
                return HttpNotFound();
            }
            return View(lote);
        }

        // POST: Lote/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LoteId")] Lote lote)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lote).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lote);
        }

        // GET: Lote/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lote lote = db.Lotes.Find(id);
            if (lote == null)
            {
                return HttpNotFound();
            }
            return View(lote);
        }

        // POST: Lote/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Lote lote = db.Lotes.Find(id);
            db.Lotes.Remove(lote);
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
