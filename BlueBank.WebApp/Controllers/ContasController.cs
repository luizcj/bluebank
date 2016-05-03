using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BlueBank.WebApp.Models;
using System.Text;

namespace BlueBank.WebApp.Controllers
{
    public class ContasController : Controller
    {
        private bluebankdbEntities db = new bluebankdbEntities();

        // GET: Contas
        public ActionResult Index()
        {
            return View(db.Conta.ToList());
        }

        // GET: Contas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Conta conta = db.Conta.Find(id);
            if (conta == null)
            {
                return HttpNotFound();
            }
            return View(conta);
        }

        // GET: Contas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Agencia,Numero,Saldo")] Conta conta)
        {
            if (ModelState.IsValid)
            {
                db.Conta.Add(conta);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(conta);
        }

        // GET: Contas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Conta conta = db.Conta.Find(id);
            if (conta == null)
            {
                return HttpNotFound();
            }
            return View(conta);
        }

        // POST: Contas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Agencia,Numero,Saldo")] Conta conta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(conta).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(conta);
        }

        // GET: Contas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Conta conta = db.Conta.Find(id);
            if (conta == null)
            {
                return HttpNotFound();
            }
            return View(conta);
        }

        // POST: Contas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Conta conta = db.Conta.Find(id);
            db.Conta.Remove(conta);
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
