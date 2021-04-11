﻿using eProject.Models;
using MailKit.Net.Smtp;
using MimeKit;
using Newtonsoft.Json;
using PagedList;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
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
                    //Mail
                    var ct = db.Clients.Find((int)value.clientId.Value);
                    Employee employee = db.Employees.Find(value.employeeId.Value.ToString());
                    MimeMessage message = new MimeMessage();
                    message.From.Add(new MailboxAddress("Excellon", "vuongthanh0111@gmail.com"));
                    message.To.Add(new MailboxAddress("User", ct.Email));
                    message.Subject = "Successful support request";
                    BodyBuilder bodyBuilder = new BodyBuilder();
                    bodyBuilder.HtmlBody =
                       string.Format("<div>" +
                            "<h1>Payment Detail</h1> " +
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
                            "<h2>Please make a transfer to complete the transaction.</ h5 >" +
                            "<h3>Account number: 19036480090018 (VUONG HA THANH). </h6>" +
                            "<h3>Transfer text: \"Excellon + PaymentId + ClientName\"</h6>" +
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