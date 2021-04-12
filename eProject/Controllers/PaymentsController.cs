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
using System.Globalization;
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
        public IHttpActionResult GetPayments(int limit, int? page, int? status = null, int? id = null,int? clientId = null, string employeeId = null, string createdAt = null)
        {
            var payments = from s in db.Payments
                              select s;
            if (id.HasValue)
            {
                payments = payments.Where(s => s.Id == id);
            }
            if (clientId.HasValue)
            {
                payments = payments.Where(s => s.ClientId == clientId);
            }
            if (!String.IsNullOrEmpty(employeeId))
            {
                payments = payments.Where(s => s.EmployeeId == employeeId);
            }
            if (!String.IsNullOrEmpty(createdAt))
            {
                var from = DateTime.ParseExact(createdAt.Split('_')[0], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                var to = DateTime.ParseExact(createdAt.Split('_')[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                payments = payments.Where(s => s.CreatedAt >= from && s.CreatedAt <= to);
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


            if ((PaymentStatus)(int)value.status.Value == PaymentStatus.Done)
            {
                MimeMessage message = new MimeMessage();
                message.From.Add(new MailboxAddress("Excellon", "vuongthanh0111@gmail.com"));
                message.To.Add(new MailboxAddress("User", payment.Client.Email));
                message.Subject = "Thank you for using Excellon-Service";
                BodyBuilder bodyBuilder = new BodyBuilder();
                bodyBuilder.HtmlBody =
                       string.Format(
                           "<div>" +
                                "<h3> Your order number " + "{0}" + " has been confirmed thank you for using our service.</h3>" +
                           "</div>",payment.Id);
                message.Body = bodyBuilder.ToMessageBody();
                SmtpClient client = new SmtpClient();
                client.Connect("smtp.gmail.com", 465, true);
                client.Authenticate("vuongthanh0111@gmail.com", "iscgdhmbfhzfqkrp");
                client.Send(message);
                client.Disconnect(true);
            }
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
                    BodyBuilder bodyBuilderPaymentDetail = new BodyBuilder();
                    bodyBuilderPaymentDetail.HtmlBody = string.Format(
                        "<h1>Payment Detail</h1>" +
                        "<table style=\"font - family: arial, sans - serif; border - collapse: collapse;\" > " +
                            "<tr>" +
                                "<th style=\"border: 1px solid #dddddd;text-align:left;padding: 8px;\">Cost</th>" +
                                "<th style=\"border: 1px solid #dddddd;text-align:left;padding: 8px;\">Service</th>" +
                                "<th style=\"border: 1px solid #dddddd;text-align:left;padding: 8px;\">Product</th>" +
                                "<th style=\"border: 1px solid #dddddd;text-align:left;padding: 8px;\">Amout Employee</th>" +
                                "<th style=\"border: 1px solid #dddddd;text-align:left;padding: 8px;\">End Date</th>" +
                                "<th style=\"border: 1px solid #dddddd;text-align:left;padding: 8px;\">Start Date</th>" +
                            "</tr>");
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
                        int serviceId = (int)paymentDetails[i].serviceId.Value;
                        var price = db.Services.Where(s => s.Id == serviceId).First().Price;
                        TimeSpan x = dt2.Subtract(dt1);
                        int days = x.Days;
                        paymentDetail.Cost = price * Int32.Parse(paymentDetails[i].amoutEmployee.Value) * days;
                        paymentDetail.StartDate = dt1;
                        paymentDetail.EndDate = dt2;
                        paymentDetail.Status = PaymentDetailStatus.Active;
                        paymentDetail.CreatedAt = DateTime.Now;
                        paymentDetail.UpdatedAt = DateTime.Now;
                        db.PaymentDetails.Add(paymentDetail);

                        var Service = db.Services.Find((int)paymentDetails[i].serviceId.Value);
                        var Product = db.Products.Find((int)paymentDetails[i].productId.Value);
                        bodyBuilderPaymentDetail.HtmlBody += string.Format("<tr>" +
                                "<th style=\"border: 1px solid #dddddd;text-align:left;padding: 8px;\">" + "{0}" + "</th>" +
                                "<th style=\"border: 1px solid #dddddd;text-align:left;padding: 8px;\">" + "{1}" + "</th>" +
                                "<th style=\"border: 1px solid #dddddd;text-align:left;padding: 8px;\">" + "{2}" + "</th>" +
                                "<th style=\"border: 1px solid #dddddd;text-align:left;padding: 8px;\">" + "{3}" + "</th>" +
                                "<th style=\"border: 1px solid #dddddd;text-align:left;padding: 8px;\">" + "{4}" + "</th>" +
                                "<th style=\"border: 1px solid #dddddd;text-align:left;padding: 8px;\">" + "{5}" + "</th>" +
                            "</tr>", price * Int32.Parse(paymentDetails[i].amoutEmployee.Value) * days, Service.Name, Product.Name, Int32.Parse(paymentDetails[i].amoutEmployee.Value), DateTime.Parse(paymentDetails[i].startDate.Value), DateTime.Parse(paymentDetails[i].endDate.Value));
                    }
                    db.SaveChanges();
                    //Mail
                    bodyBuilderPaymentDetail.HtmlBody += string.Format("</table>");
                    var ct = db.Clients.Find((int)value.clientId.Value);
                    Employee employee = db.Employees.Find(value.employeeId.Value.ToString());
                    MimeMessage message = new MimeMessage();
                    message.From.Add(new MailboxAddress("Excellon", "vuongthanh0111@gmail.com"));
                    message.To.Add(new MailboxAddress("User", ct.Email));
                    message.Subject = "Successful support request";
                    BodyBuilder bodyBuilder = new BodyBuilder();
                    bodyBuilder.HtmlBody =
                       string.Format("<div>" +
                            "<h1>Payment</h1> " +
                            "<table style=\"font - family: arial, sans - serif; border - collapse: collapse;\" > " +
                                "<tr>" +
                                    "<th style=\"border: 1px solid #dddddd;text-align:left;padding: 8px;\">ID</th>" +
                                    "<th style=\"border: 1px solid #dddddd;text-align:left;padding: 8px;\">" + "{0}" + "</th>" +
                                "</tr>" +
                                "<tr>" +
                                    "<th style=\"border: 1px solid #dddddd;text-align:left;padding: 8px;\">Total Cost ($)</th>" +
                                    "<th style=\"border: 1px solid #dddddd;text-align:left;padding: 8px;\">" + "{1}" + "</th>" +
                                    
                                "</tr>" +
                                 
                                "<tr>" +
                                    "<th style=\"border: 1px solid #dddddd;text-align:left;padding: 8px;\">Client Name</th>" +
                                    "<th style=\"border: 1px solid #dddddd;text-align:left;padding: 8px;\">" + "{2}" + "</th>" +
                                    
                                "</tr>" +
                                 
                                "<tr>" +
                                    "<th style=\"border: 1px solid #dddddd;text-align:left;padding: 8px;\">Employee Name</th>" +
                                    "<th style=\"border: 1px solid #dddddd;text-align:left;padding: 8px;\">" + "{3}" + "</th>" +
                                    
                                "</tr>" +
                            "</table>" +
                        "</div>" +
                        "<div>" +
                            bodyBuilderPaymentDetail.HtmlBody +
                        "</div>" +
                        "<div>" +
                            "<h2>Please make a transfer to complete the transaction.</ h5 >" +
                            "<h3>Account number:</h6>" +
                            "<div style=\"margin-left: 30px\">" +
                                "<h6> - 19036480090018 (VUONG HA THANH - TECHCOMBANK).</h6>" +
                                "<h6> - 19022318829901 (NGUYEN MINH DUC - TECHCOMBANK).</h6>" +
                                "<h6> - 19033281193217 (PHAN HONG TRUONG - TECHCOMBANK). </h6>" +
                            "</div>" +
                            "<h3>Transfer text: \"Excellon_(PaymentId)_(ClientName)\"</h6>" +
                            "<div><p>For example: Excellon_100_30</p></div>" +
                        "</div>", payment.Id, payment.TotalCost, ct.Name, employee.UserName);
                    message.Body = bodyBuilder.ToMessageBody();
                    SmtpClient client = new SmtpClient();
                    client.Connect("smtp.gmail.com", 465, true);
                    client.Authenticate("vuongthanh0111@gmail.com", "iscgdhmbfhzfqkrp");
                    client.Send(message);
                    client.Disconnect(true);
                    //Close mail
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