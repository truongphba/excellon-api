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
    public class PaymentDetailsController : ApiController
    {
        private ExcelDbContext db = new ExcelDbContext();

        // GET: api/PaymentDetails
        [System.Web.Http.HttpGet]
        public IHttpActionResult GetPaymentDetails(int limit, int? page, DateTime? startDate=null,DateTime? endDate=null, int? status = null)
        {
            var paymentDetails = from s in db.PaymentDetails
                           select s;
            if (startDate.HasValue)
            {
                paymentDetails = paymentDetails.Where(s => s.StartDate>=startDate);
            }
            if (endDate.HasValue)
            {
                paymentDetails = paymentDetails.Where(s => s.StartDate <= endDate);
            }
            if (status.HasValue)
            {
                paymentDetails = paymentDetails.Where(s => s.Status == (PaymentDetailStatus) status);
            }
            int pageNumber = (page ?? 1);
            var data = paymentDetails.OrderByDescending(s => s.CreatedAt).ToPagedList(pageNumber, limit);
            var total = paymentDetails.ToList().Count();
            return Ok(new
            {
                data,
                total
            });
        }

        // GET: api/PaymentDetails/5
        [ResponseType(typeof(PaymentDetail))]
        public IHttpActionResult GetPaymentDetail(int id)
        {
            PaymentDetail paymentDetail = db.PaymentDetails.Find(id);
            if (paymentDetail == null)
            {
                return NotFound();
            }

            return Ok(paymentDetail);
        }

        // PUT: api/PaymentDetails/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPaymentDetail(int id, PaymentDetail paymentDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != paymentDetail.Id)
            {
                return BadRequest();
            }
            paymentDetail.UpdatedAt = DateTime.Now;
            db.Entry(paymentDetail).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PaymentDetailExists(id))
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

        // POST: api/PaymentDetails
        [ResponseType(typeof(PaymentDetail))]
        public IHttpActionResult PostPaymentDetail(PaymentDetail paymentDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            paymentDetail.Status = PaymentDetailStatus.Active;
            paymentDetail.CreatedAt = DateTime.Now;
            paymentDetail.UpdatedAt = DateTime.Now;
            db.PaymentDetails.Add(paymentDetail);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = paymentDetail.Id }, paymentDetail);
        }

        // DELETE: api/PaymentDetails/5
        [ResponseType(typeof(PaymentDetail))]
        public IHttpActionResult DeletePaymentDetail(int id)
        {
            PaymentDetail paymentDetail = db.PaymentDetails.Find(id);
            if (paymentDetail == null)
            {
                return NotFound();
            }

            paymentDetail.UpdatedAt = DateTime.Now;
            paymentDetail.Status = PaymentDetailStatus.Deactive;
            //db.PaymentDetails.Remove(paymentDetail);
            db.SaveChanges();

            return Ok(paymentDetail);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PaymentDetailExists(int id)
        {
            return db.PaymentDetails.Count(e => e.Id == id) > 0;
        }
    }
}