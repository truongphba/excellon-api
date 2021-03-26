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
using eProject.Models;
using PagedList;

namespace eProject.Controllers
{
    public class ServicesController : ApiController
    {
        private ExcelDbContext db = new ExcelDbContext();

        // GET: api/Services
        [System.Web.Http.HttpGet]
        public IHttpActionResult GetServices(int limit, int? page, string keyword = "", int? status = null)
        {
            var services = from s in db.Services
                           select s;
            if (!String.IsNullOrEmpty(keyword))
            {
                services = services.Where(s => s.Name.Contains(keyword));
            }
            if (status.HasValue)
            {
                services = services.Where(s => s.Status == (ServiceStatus)status);
            }
            int pageNumber = (page ?? 1);
            var data = services.OrderByDescending(s => s.CreatedAt).ToPagedList(pageNumber, limit);
            var total = services.ToList().Count();
            return Ok(new
            {
                data,
                total
            });
        }

        // GET: api/Services/5
        [ResponseType(typeof(Service))]
        public IHttpActionResult GetService(int id)
        {
            Service service = db.Services.Find(id);
            if (service == null)
            {
                return NotFound();
            }

            return Ok(service);
        }

        // PUT: api/Services/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutService(int id, Service service)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != service.Id)
            {
                return BadRequest();
            }
            service.UpdatedAt = DateTime.Now;
            db.Entry(service).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ServiceExists(id))
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

        // POST: api/Services
        [ResponseType(typeof(Service))]
        public IHttpActionResult PostService(Service service)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            service.Status = ServiceStatus.Active;
            service.CreatedAt = DateTime.Now;
            service.UpdatedAt = DateTime.Now;
            db.Services.Add(service);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = service.Id }, service);
        }

        // DELETE: api/Services/5
        [ResponseType(typeof(Service))]
        public IHttpActionResult DeleteService(int id)
        {
            Service service = db.Services.Find(id);
            if (service == null)
            {
                return NotFound();
            }
            service.UpdatedAt = DateTime.Now;
            service.Status = ServiceStatus.Deactive;
            //db.Services.Remove(service);
            db.SaveChanges();

            return Ok(service);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ServiceExists(int id)
        {
            return db.Services.Count(e => e.Id == id) > 0;
        }
    }
}