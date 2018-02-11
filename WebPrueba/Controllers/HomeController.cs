using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebPruebaData.Entities;

namespace WebPrueba.Controllers
{
    public class HomeController : Controller
    {
        private DataModel db = new DataModel();

        // GET: Home
        public ActionResult Index()
        {
            return View(db.tblEmpresas.ToList());
        }

        // GET: Home/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblEmpresa tblEmpresa = db.tblEmpresas.Find(id);
            if (tblEmpresa == null)
            {
                return HttpNotFound();
            }
            return View(tblEmpresa);
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdEmpresa,NIFEmpresa,NomComercial,DesEmpresa,DirEmpresa,IdPoblacion,TelEmpresa,CelEmpresa,FaxEmpresa,EmailEmpresa,WebEmpresa,DirImagEmpresa,DirCopiaTickets,ActivoEmpresa,LogoEmpresa,LogoTickets,LogoReducido")] tblEmpresa tblEmpresa)
        {
            if (ModelState.IsValid)
            {
                db.tblEmpresas.Add(tblEmpresa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblEmpresa);
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblEmpresa tblEmpresa = db.tblEmpresas.Find(id);
            if (tblEmpresa == null)
            {
                return HttpNotFound();
            }
            return View(tblEmpresa);
        }

        // POST: Home/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdEmpresa,NIFEmpresa,NomComercial,DesEmpresa,DirEmpresa,IdPoblacion,TelEmpresa,CelEmpresa,FaxEmpresa,EmailEmpresa,WebEmpresa,DirImagEmpresa,DirCopiaTickets,ActivoEmpresa,LogoEmpresa,LogoTickets,LogoReducido")] tblEmpresa tblEmpresa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblEmpresa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblEmpresa);
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblEmpresa tblEmpresa = db.tblEmpresas.Find(id);
            if (tblEmpresa == null)
            {
                return HttpNotFound();
            }
            return View(tblEmpresa);
        }

        // POST: Home/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblEmpresa tblEmpresa = db.tblEmpresas.Find(id);
            db.tblEmpresas.Remove(tblEmpresa);
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
