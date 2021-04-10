using ClosedXML.Excel;
using eProject.Models;
using MailKit.Net.Smtp;
using MimeKit;
using Newtonsoft.Json;
using PagedList;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Mvc;

namespace eProject.Controllers
{
    public class PaymentsController : ApiController
    {
        private ExcelDbContext db = new ExcelDbContext();

        // GET: api/Payments
        [System.Web.Http.HttpGet]
        public IHttpActionResult GetPayments(int limit, int? page, double? maxCost = null, double? minCost = null, int? status = null, int? id = null)
        {
            var payments = from s in db.Payments
                              select s;
            if (id.HasValue)
            {
                payments = payments.Where(s => s.Id == id);
            }
            if (maxCost.HasValue)
            {
                payments = payments.Where(s => s.TotalCost >= minCost);
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

        [System.Web.Http.Route("api/Payments/Export")]
        [System.Web.Http.HttpGet]
        public void ExportToExcel(int limit, int? page, double? maxCost, double? minCost, int? status = null)
        {
            var payments = from s in db.Payments
                           select s;
            if (maxCost.HasValue)
            {
                payments = payments.Where(s => s.TotalCost >= minCost);
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
            XLWorkbook wb = new XLWorkbook();
            var worksheet = wb.Worksheets.Add("Payments");
            var currentRow = 1;
            worksheet.Cell(currentRow, 1).Value = "Id";
            worksheet.Cell(currentRow, 2).Value = "TotalCost";
            worksheet.Cell(currentRow, 3).Value = "Client";
            worksheet.Cell(currentRow, 4).Value = "Employee";
            worksheet.Cell(currentRow, 6).Value = "Create At";
            worksheet.Cell(currentRow, 7).Value = "Status";

            foreach (Payment payment in data)
            {
                currentRow++;
                worksheet.Cell(currentRow, 1).Value = payment.Id;
                worksheet.Cell(currentRow, 2).Value = payment.TotalCost;
                worksheet.Cell(currentRow, 3).Value = payment.Client.Name;
                worksheet.Cell(currentRow, 4).Value = payment.Employee.UserName;
                worksheet.Cell(currentRow, 6).Value = payment.CreatedAt;
                worksheet.Cell(currentRow, 7).Value = payment.Status;


            }


            HttpContext.Current.Response.Clear();
            HttpContext.Current.Response.Buffer = true;
            HttpContext.Current.Response.Charset = "";
            HttpContext.Current.Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            HttpContext.Current.Response.AddHeader("content-disposition", "attachment;filename=Payments.xlsx");
            MemoryStream stream = new MemoryStream();
            wb.SaveAs(stream);
            HttpContext.Current.Response.AddHeader("content-length", stream.ToArray().Length.ToString());
            stream.WriteTo(HttpContext.Current.Response.OutputStream);
            HttpContext.Current.Response.Flush();
            HttpContext.Current.Response.End();

            XLWorkbook wbPaymentDetail = new XLWorkbook();
            var worksheetPaymentDetail = wb.Worksheets.Add("Payment Detail");
            var row = 1;
            worksheetPaymentDetail.Cell(row, 1).Value = "Id";
            worksheetPaymentDetail.Cell(row, 2).Value = "Amout Employee";
            worksheetPaymentDetail.Cell(row, 3).Value = "Start Date";
            worksheetPaymentDetail.Cell(row, 4).Value = "End Date";
            worksheetPaymentDetail.Cell(row, 5).Value = "Payment";
            worksheetPaymentDetail.Cell(row, 6).Value = "Product";
            worksheetPaymentDetail.Cell(row, 7).Value = "Service";
            worksheetPaymentDetail.Cell(row, 8).Value = "Cost";
            worksheetPaymentDetail.Cell(row, 9).Value = "Create At";
            worksheetPaymentDetail.Cell(row, 10).Value = "Status";
            foreach (Payment payment in data)
            {
                foreach (PaymentDetail paymentDetail in payment.PaymentDetails)
                {
                    row++;
                    worksheetPaymentDetail.Cell(row, 1).Value = paymentDetail.Id;
                    worksheetPaymentDetail.Cell(row, 2).Value = paymentDetail.AmoutEmployee;
                    worksheetPaymentDetail.Cell(row, 3).Value = paymentDetail.StartDate;
                    worksheetPaymentDetail.Cell(row, 4).Value = paymentDetail.EndDate;
                    worksheetPaymentDetail.Cell(row, 5).Value = paymentDetail.Payment.Id;
                    worksheetPaymentDetail.Cell(row, 6).Value = paymentDetail.Product.Name;
                    worksheetPaymentDetail.Cell(row, 7).Value = paymentDetail.Service.Name;
                    worksheetPaymentDetail.Cell(row, 8).Value = paymentDetail.Cost;
                    worksheetPaymentDetail.Cell(row, 9).Value = paymentDetail.CreatedAt;
                    worksheetPaymentDetail.Cell(row, 10).Value = paymentDetail.Status;
                }
            }
            HttpContext.Current.Response.Clear();
            HttpContext.Current.Response.Buffer = true;
            HttpContext.Current.Response.Charset = "";
            HttpContext.Current.Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            HttpContext.Current.Response.AddHeader("content-disposition", "attachment;filename=PaymentsDetail.xlsx");
            MemoryStream streamPD = new MemoryStream();
            wbPaymentDetail.SaveAs(stream);
            HttpContext.Current.Response.AddHeader("content-length", streamPD.ToArray().Length.ToString());
            streamPD.WriteTo(HttpContext.Current.Response.OutputStream);
            HttpContext.Current.Response.Flush();
            HttpContext.Current.Response.End();

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

            var detail = db.PaymentDetails.Where(s => s.PaymentId == payment.Id).ToList();

            return Ok(payment);
        }

        // PUT: api/Payments/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPayment(int id, [FromBody] dynamic value)
        {
            var payment = db.Payments.Find(id);
            if (payment == null)
            {
                return BadRequest();
            }
            payment.UpdatedAt = DateTime.Now;
            payment.Status = (PaymentStatus)(int) value.status.Value;
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
        public IHttpActionResult PostPayment([FromBody] dynamic value)
        {
            using (System.Data.Entity.DbContextTransaction dbTran = db.Database.BeginTransaction())
            {
                try
                {
                    var payment = new Payment();
                    payment.ClientId = (int)value.clientId.Value;
                    payment.EmployeeId = value.employeeId.Value.ToString();
                    payment.CreatedAt = DateTime.Now;
                    payment.UpdatedAt = DateTime.Now;
                    payment.Status = PaymentStatus.Pending;
                    var paymentDetails = value.detail;
                    for (int i = 0; i < paymentDetails.Count; i++)
                    {
                        int serviceId = (int)paymentDetails[i].serviceId.Value;
                        var price = db.Services.Where(s => s.Id == serviceId).First().Price;

                        DateTime dt1 = DateTime.Parse(paymentDetails[i].startDate.Value);
                        DateTime dt2 = DateTime.Parse(paymentDetails[i].endDate.Value);

                        TimeSpan x = dt2.Subtract(dt1);
                        int days = x.Days;
                        payment.TotalCost += price * Int32.Parse(paymentDetails[i].amoutEmployee.Value) * days;


                    }
                    db.Payments.Add(payment);


                    for (int i = 0; i < paymentDetails.Count; i++)
                    {
                        DateTime dt1 = DateTime.Parse(paymentDetails[i].startDate.Value);
                        DateTime dt2 = DateTime.Parse(paymentDetails[i].endDate.Value);
                        var paymentDetail = new PaymentDetail();
                        paymentDetail.ProductId = (int)paymentDetails[i].productId.Value;
                        paymentDetail.PaymentId = payment.Id;
                        paymentDetail.ServiceId = (int)paymentDetails[i].serviceId.Value;
                        paymentDetail.AmoutEmployee = Int32.Parse(paymentDetails[i].amoutEmployee.Value);
                        paymentDetail.StartDate = dt1;
                        paymentDetail.EndDate = dt2;
                        paymentDetail.Status = PaymentDetailStatus.Active;
                        paymentDetail.CreatedAt = DateTime.Now;
                        paymentDetail.UpdatedAt = DateTime.Now;
                        db.PaymentDetails.Add(paymentDetail);


                    }
                    db.SaveChanges();


                    dbTran.Commit();
                    return Ok();
                }
                catch (Exception ex)
                {
                    //Rollback transaction if exception occurs    
                    dbTran.Rollback();
                    return BadRequest(ex.ToString());
                }
            }
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
            payment.Status = PaymentStatus.Cancel ;
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