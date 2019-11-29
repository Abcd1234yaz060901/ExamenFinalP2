using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ExamenFinalP2.Models;

namespace ExamenFinalP2.Controllers
{
    public class VisitantesController : Controller
    {
        private EP2Context db = new EP2Context();

        // GET: Visitantes
        public ActionResult Index()
        {
            return View(db.Visitantes.ToList());
        }

        // GET: Visitantes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Visitante visitante = db.Visitantes.Find(id);
            if (visitante == null)
            {
                return HttpNotFound();
            }
            return View(visitante);
        }

        // GET: Visitantes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Visitantes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDVisitante,Nombre,Apellido,Direccion,Telefono,Correo")] Visitante visitante)
        {
            if (ModelState.IsValid)
            {
                db.Visitantes.Add(visitante);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(visitante);
        }

        // GET: Visitantes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Visitante visitante = db.Visitantes.Find(id);
            if (visitante == null)
            {
                return HttpNotFound();
            }
            return View(visitante);
        }

        // POST: Visitantes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDVisitante,Nombre,Apellido,Direccion,Telefono,Correo")] Visitante visitante)
        {
            if (ModelState.IsValid)
            {
                db.Entry(visitante).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(visitante);
        }

        // GET: Visitantes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Visitante visitante = db.Visitantes.Find(id);
            if (visitante == null)
            {
                return HttpNotFound();
            }
            return View(visitante);
        }

        // POST: Visitantes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Visitante visitante = db.Visitantes.Find(id);
            db.Visitantes.Remove(visitante);
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
