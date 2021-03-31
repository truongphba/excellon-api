using eProject.Models;
using PagedList;
using System;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;

namespace eProject.Controllers
{
    public class PaymentsController : ApiController
    {
        private ExcelDbContext db = new ExcelDbContext();

        // GET: api/Payments
        [System.Web.Http.HttpGet]
        public IHttpActionResult GetPayments(int limit, int? page, double? maxCost,double? minCost, int? status = null)
        {
            var payments = from s in db.Payments
                              select s;
            if (maxCost.HasValue)
            {
                payments = payments.Where(s => s.TotalCost >=minCost);
            }
            if (maxCost.HasValue)
            {
                payments = payments.Where(s => s.TotalCost >= maxCost);
            }
            if (status.HasValue)
            {
                payments = payments.Where(s => s.Status == (PaymentStatus)status);
            }
            int pageNumber = (page ?? 1);
            var data = payments.OrderByDescending(s => s.CreatedAt).ToPagedList(pageNumber, limit);
            var total = payments.ToList().Count();
            return Ok(new
            {
                data,
                total
            });
        }

        // GET: api/Payments/5
        [ResponseType(typeof(Payment))]
        public IHttpActionResult GetPayment(int id)
        {
            Payment payment = db.Payments.Find(id);
            if (payment == null)
            {
                return NotFound();
            }

            return Ok(payment);
        }

        // PUT: api/Payments/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPayment(int id, Payment payment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != payment.Id)
            {
                return BadRequest();
            }
            payment.UpdatedAt = DateTime.Now;
            db.Entry(payment).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PaymentExists(id))
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

        // POST: api/Payments
        [ResponseType(typeof(Payment))]
        public IHttpActionResult PostPayment(Payment payment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            payment.Status = PaymentStatus.Pending;
            payment.CreatedAt = DateTime.Now;
            payment.UpdatedAt = DateTime.Now;
            db.Payments.Add(payment);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = payment.Id }, payment);
        }

        // DELETE: api/Payments/5
        [ResponseType(typeof(Payment))]
        public IHttpActionResult DeletePayment(int id)
        {
            Payment payment = db.Payments.Find(id);
            if (payment == null)
            {
                return NotFound();
            }

            payment.UpdatedAt = DateTime.Now;
            payment.Status = PaymentStatus.Cancle;
            //db.Payments.Remove(payment);
            db.SaveChanges();

            return Ok(payment);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PaymentExists(int id)
        {
            return db.Payments.Count(e => e.Id == id) > 0;
        }
    }
}