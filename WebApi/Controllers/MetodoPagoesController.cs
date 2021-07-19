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
using WebApi.Models;

namespace WebApi.Controllers
{
    public class MetodoPagoesController : ApiController
    {
        private DBClienteApiEntities1 db = new DBClienteApiEntities1();

        // GET: api/MetodoPagoes
        public IQueryable<MetodoPago> GetMetodoPagoes()
        {
            return db.MetodoPagoes;
        }

        // GET: api/MetodoPagoes/5
        [ResponseType(typeof(MetodoPago))]
        public IHttpActionResult GetMetodoPago(int id)
        {
            MetodoPago metodoPago = db.MetodoPagoes.Find(id);
            if (metodoPago == null)
            {
                return NotFound();
            }

            return Ok(metodoPago);
        }

        // PUT: api/MetodoPagoes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMetodoPago(int id, MetodoPago metodoPago)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != metodoPago.PagoId)
            {
                return BadRequest();
            }

            db.Entry(metodoPago).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MetodoPagoExists(id))
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

        // POST: api/MetodoPagoes
        [ResponseType(typeof(MetodoPago))]
        public IHttpActionResult PostMetodoPago(MetodoPago metodoPago)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.MetodoPagoes.Add(metodoPago);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (MetodoPagoExists(metodoPago.PagoId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = metodoPago.PagoId }, metodoPago);
        }

        // DELETE: api/MetodoPagoes/5
        [ResponseType(typeof(MetodoPago))]
        public IHttpActionResult DeleteMetodoPago(int id)
        {
            MetodoPago metodoPago = db.MetodoPagoes.Find(id);
            if (metodoPago == null)
            {
                return NotFound();
            }

            db.MetodoPagoes.Remove(metodoPago);
            db.SaveChanges();

            return Ok(metodoPago);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MetodoPagoExists(int id)
        {
            return db.MetodoPagoes.Count(e => e.PagoId == id) > 0;
        }
    }
}