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
    public class LeilaoController : Controller
    {
        private LeilaoContext db = new LeilaoContext();

        // GET: Leilao
        public ActionResult Index()
        {
            return View(db.Leiloes.ToList());
        }

        // GET: Leilao/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Leilao leilao = db.Leiloes.Find(id);
            if (leilao == null)
            {
                return HttpNotFound();
            }
            return View(leilao);
        }

        // GET: Leilao/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Leilao/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LeilaoId,Natureza,Privacidade,MomentoInicio,MomentoFim,IdUsuarioResponsavel,LanceLimite")] Leilao leilao)
        {
            if (ModelState.IsValid)
            {
                db.Leiloes.Add(leilao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(leilao);
        }

        // GET: Leilao/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Leilao leilao = db.Leiloes.Find(id);
            if (leilao == null)
            {
                return HttpNotFound();
            }
            return View(leilao);
        }

        // POST: Leilao/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LeilaoId,Natureza,Privacidade,MomentoInicio,MomentoFim,IdUsuarioResponsavel,LanceLimite")] Leilao leilao)
        {
            if (ModelState.IsValid)
            {
                db.Entry(leilao).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(leilao);
        }

        // GET: Leilao/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Leilao leilao = db.Leiloes.Find(id);
            if (leilao == null)
            {
                return HttpNotFound();
            }
            return View(leilao);
        }

        // POST: Leilao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Leilao leilao = db.Leiloes.Find(id);
            db.Leiloes.Remove(leilao);
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
