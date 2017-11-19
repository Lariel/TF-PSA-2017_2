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
    public class BemController : Controller
    {
        private LeilaoContext db = new LeilaoContext();

        // GET: Bem
        public ActionResult Index()
        {
            return View(db.Bens.ToList());
        }

        // GET: Bem/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bem bem = db.Bens.Find(id);
            if (bem == null)
            {
                return HttpNotFound();
            }
            return View(bem);
        }

        // GET: Bem/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Bem/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BemId,DescricaoBreve,DescricaoCompleta,Categoria")] Bem bem)
        {
            if (ModelState.IsValid)
            {
                db.Bens.Add(bem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bem);
        }

        // GET: Bem/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bem bem = db.Bens.Find(id);
            if (bem == null)
            {
                return HttpNotFound();
            }
            return View(bem);
        }

        // POST: Bem/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BemId,DescricaoBreve,DescricaoCompleta,Categoria")] Bem bem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bem);
        }

        // GET: Bem/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bem bem = db.Bens.Find(id);
            if (bem == null)
            {
                return HttpNotFound();
            }
            return View(bem);
        }

        // POST: Bem/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Bem bem = db.Bens.Find(id);
            db.Bens.Remove(bem);
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
