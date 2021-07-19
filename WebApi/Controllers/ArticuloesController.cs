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
    public class ArticuloesController : ApiController
    {
        private DBClienteApiEntities1 db = new DBClienteApiEntities1();

        // GET: api/Articuloes
        public IQueryable<Articulo> GetArticuloes()
        {
            return db.Articuloes;
        }

        // GET: api/Articuloes/5
        [ResponseType(typeof(Articulo))]
        public IHttpActionResult GetArticulo(int id)
        {
            Articulo articulo = db.Articuloes.Find(id);
            if (articulo == null)
            {
                return NotFound();
            }

            return Ok(articulo);
        }

        // PUT: api/Articuloes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutArticulo(int id, Articulo articulo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != articulo.ArticuloId)
            {
                return BadRequest();
            }

            db.Entry(articulo).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArticuloExists(id))
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

        // POST: api/Articuloes
        [ResponseType(typeof(Articulo))]
        public IHttpActionResult PostArticulo(Articulo articulo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Articuloes.Add(articulo);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (ArticuloExists(articulo.ArticuloId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = articulo.ArticuloId }, articulo);
        }

        // DELETE: api/Articuloes/5
        [ResponseType(typeof(Articulo))]
        public IHttpActionResult DeleteArticulo(int id)
        {
            Articulo articulo = db.Articuloes.Find(id);
            if (articulo == null)
            {
                return NotFound();
            }

            db.Articuloes.Remove(articulo);
            db.SaveChanges();

            return Ok(articulo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ArticuloExists(int id)
        {
            return db.Articuloes.Count(e => e.ArticuloId == id) > 0;
        }
    }
}