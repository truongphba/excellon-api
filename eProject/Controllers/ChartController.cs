using eProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Globalization;
using System.Data.Entity.SqlServer;

namespace eProject.Controllers
{
    public class ChartController : ApiController
    {
        private ExcelDbContext db = new ExcelDbContext();

        [HttpGet]
        [Route("api/Chart/sevenday")]
        public IHttpActionResult GetDataPaymentSevenDay()
        {
            var today = DateTime.Now.Date;
            var sevenDayAgo = DateTime.Now.Date.AddDays(-7);
            var data = db.Payments.AsEnumerable().GroupBy(p => p.CreatedAt.ToString("dd/MM/yyyy"))
                .Select(s => new { CreateDate = s.Key, TotalCost = s.Sum(p => p.TotalCost)})
                .Where(s => DateTime.Parse(s.CreateDate) <= today && DateTime.Parse(s.CreateDate) >= sevenDayAgo);

            return Ok(new
            {
                data
            });
        }

        [HttpGet]
        [Route("api/Chart/month")]
        public IHttpActionResult GetDataPaymentMonth()
        {
            var month = DateTime.Now.Month;
            var year = DateTime.Now.Year;
            var firstDayOfMonth = new DateTime(year, month, 1);
            var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
            var data = db.Payments.AsEnumerable().GroupBy(p => p.CreatedAt.ToString("dd/MM/yyyy"))
                .Select(s => new { CreateDate = s.Key, TotalCost = s.Sum(p => p.TotalCost) })
                .Where(s => DateTime.Parse(s.CreateDate) <= lastDayOfMonth && DateTime.Parse(s.CreateDate) >= firstDayOfMonth);

            return Ok(new
            {
              data
            });
        }
    }
}
