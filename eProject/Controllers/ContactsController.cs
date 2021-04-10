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
    public class ContactsController : ApiController
    {
        private ExcelDbContext db = new ExcelDbContext();

        // GET: api/Contacts
        public IHttpActionResult GetContacts (int limit, int? page, string keyword = "", int? status = null)
        {
            var contacts = from s in db.Contacts
                          select s;
            if (!String.IsNullOrEmpty(keyword))
            {
                contacts = contacts.Where(s => s.Name.Contains(keyword));
            }
            if (status.HasValue)
            {
                contacts = contacts.Where(s => s.Status == (ContactStatus)status);
            }
            int pageNumber = (page ?? 1);
            var data = contacts.OrderByDescending(s => s.CreatedAt).ToPagedList(pageNumber, limit);
            var total = contacts.ToList().Count();
            return Ok(new
            {
                data,
                total
            });
        }

        // GET: api/Contacts/5
        [ResponseType(typeof(Contact))]
        public IHttpActionResult GetContact(int id)
        {
            Contact contact = db.Contacts.Find(id);
            if (contact == null)
            {
                return NotFound();
            }

            return Ok(contact);
        }

        // PUT: api/Contacts/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutContact(int id, [FromBody] dynamic value)
        {
            var contact = db.Contacts.Find(id);
            if (contact == null)
            {
                return BadRequest();
            }
            contact.UpdatedAt = DateTime.Now;
            contact.Status = (ContactStatus)(int)value.status.Value;
            db.Entry(contact).State = EntityState.Modified;

           
            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContactExists(id))
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

        // POST: api/Contacts
        [ResponseType(typeof(Contact))]
        public IHttpActionResult PostContact(Contact contact)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            contact.Status = ContactStatus.Pending;
            contact.CreatedAt = DateTime.Now;
            contact.UpdatedAt = DateTime.Now;

            db.Contacts.Add(contact);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = contact.Id }, contact);
        }

        // DELETE: api/Contacts/5
        [ResponseType(typeof(Contact))]
        public IHttpActionResult DeleteContact(int id)
        {
            Contact contact = db.Contacts.Find(id);
            if (contact == null)
            {
                return NotFound();
            }

            db.Contacts.Remove(contact);
            db.SaveChanges();

            return Ok(contact);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ContactExists(int id)
        {
            return db.Contacts.Count(e => e.Id == id) > 0;
        }
    }
}