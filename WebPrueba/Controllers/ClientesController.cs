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
    public class ClientesController : Controller
    {
        private DataModel db = new DataModel();

        // GET: Clientes
        public ActionResult Index()
        {
            var tblClientes = db.tblClientes.Include(t => t.tblDondeNosConocio);
            return View(tblClientes.ToList());
        }

        // GET: Clientes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblCliente tblCliente = db.tblClientes.Find(id);
            if (tblCliente == null)
            {
                return HttpNotFound();
            }
            return View(tblCliente);
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            ViewBag.idDonde = new SelectList(db.tblDondeNosConocios, "idDonde", "DesDonde");
            return View();
        }

        // POST: Clientes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdCliente,NombreCliente,TelCliente,idDonde,ObsCliente,ActivoCliente")] tblCliente tblCliente)
        {
            if (ModelState.IsValid)
            {
                db.tblClientes.Add(tblCliente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idDonde = new SelectList(db.tblDondeNosConocios, "idDonde", "DesDonde", tblCliente.idDonde);
            return View(tblCliente);
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblCliente tblCliente = db.tblClientes.Find(id);
            if (tblCliente == null)
            {
                return HttpNotFound();
            }
            ViewBag.idDonde = new SelectList(db.tblDondeNosConocios, "idDonde", "DesDonde", tblCliente.idDonde);
            return View(tblCliente);
        }

        // POST: Clientes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdCliente,NombreCliente,TelCliente,idDonde,ObsCliente,ActivoCliente")] tblCliente tblCliente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblCliente).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idDonde = new SelectList(db.tblDondeNosConocios, "idDonde", "DesDonde", tblCliente.idDonde);
            return View(tblCliente);
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblCliente tblCliente = db.tblClientes.Find(id);
            if (tblCliente == null)
            {
                return HttpNotFound();
            }
            return View(tblCliente);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblCliente tblCliente = db.tblClientes.Find(id);
            db.tblClientes.Remove(tblCliente);
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
