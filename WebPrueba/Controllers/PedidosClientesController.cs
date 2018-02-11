using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebPruebaData.Entities;
using Newtonsoft.Json;

namespace WebPrueba.Controllers
{
    public class PedidosClientesController : ApiController
    {
        private DataModel db = new DataModel();

        // GET: api/PedidosClientes
        public IQueryable<tblPedidosCliente> GettblPedidosClientes()
        {
            return db.tblPedidosClientes;
        }

        // GET: api/PedidosClientes/5
        [ResponseType(typeof(tblPedidosCliente))]
        public IHttpActionResult GettblPedidosCliente(int id)
        {
            tblPedidosCliente tblPedidosCliente = db.tblPedidosClientes.Find(id);
            if (tblPedidosCliente == null)
            {
                return NotFound();
            }
            PedidoCliente pedidoCliente = new PedidoCliente(tblPedidosCliente);
            var pedidosCliente=JsonConvert.SerializeObject(pedidoCliente);
            return Ok(pedidosCliente);
        }

        // PUT: api/PedidosClientes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PuttblPedidosCliente(int id, tblPedidosCliente tblPedidosCliente)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblPedidosCliente.idPedidoCliente)
            {
                return BadRequest();
            }

            db.Entry(tblPedidosCliente).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblPedidosClienteExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/PedidosClientes
        [ResponseType(typeof(tblPedidosCliente))]
        public IHttpActionResult PosttblPedidosCliente(tblPedidosCliente tblPedidosCliente)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tblPedidosClientes.Add(tblPedidosCliente);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tblPedidosCliente.idPedidoCliente }, tblPedidosCliente);
        }

        // DELETE: api/PedidosClientes/5
        [ResponseType(typeof(tblPedidosCliente))]
        public IHttpActionResult DeletetblPedidosCliente(int id)
        {
            tblPedidosCliente tblPedidosCliente = db.tblPedidosClientes.Find(id);
            if (tblPedidosCliente == null)
            {
                return NotFound();
            }

            db.tblPedidosClientes.Remove(tblPedidosCliente);
            db.SaveChanges();

            return Ok(tblPedidosCliente);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tblPedidosClienteExists(int id)
        {
            return db.tblPedidosClientes.Count(e => e.idPedidoCliente == id) > 0;
        }
    }
}