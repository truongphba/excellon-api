using eProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace eProject.Controllers
{
    public class ChartController : ApiController
    {
        private ExcelDbContext db = new ExcelDbContext();

        [System.Web.Http.HttpGet]
        public IHttpActionResult GetPayments()
        {
            var payments = from s in db.Payments
                           select s;

            var data = payments.Select(s => new { s.TotalCost, s.CreatedAt });
            return Ok(new
            {
                data
            });
        }
    }
}
