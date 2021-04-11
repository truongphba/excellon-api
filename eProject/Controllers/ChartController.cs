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
        [Route("api/Chart/monthPayment")]
        public IHttpActionResult GetDataPaymentMonth()
        {
            var month = DateTime.Now.Month;
            var year = DateTime.Now.Year;
            var firstDayOfMonth = new DateTime(year, month, 1);
            var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
            var totalCost = db.Payments.AsEnumerable().GroupBy(p => p.CreatedAt.ToString("dd/MM/yyyy"))
                .Select(s => new { CreateDate = s.Key, TotalCost = s.Sum(p => p.TotalCost) })
                .Where(s => DateTime.Parse(s.CreateDate) <= lastDayOfMonth && DateTime.Parse(s.CreateDate) >= firstDayOfMonth);

            var totalCount = db.Payments.AsEnumerable().GroupBy(p => p.CreatedAt.ToString("dd/MM/yyyy"))
                .Select(s => new { CreateDate = s.Key, Count = s.Count() })
                .Where(s => DateTime.Parse(s.CreateDate) <= lastDayOfMonth && DateTime.Parse(s.CreateDate) >= firstDayOfMonth);

            return Ok(new
            {
                totalCost,
                totalCount
            });
        }


        [HttpGet]
        [Route("api/Chart/yearPayment")]
        public IHttpActionResult GetDataPaymentYear()
        {
            var month = DateTime.Now.Month;
            var year = DateTime.Now.Year;
            var firstMonth = "01/" + year.ToString();
            var lastMonth = "12/" + year.ToString();

            var totalCost = db.Payments.AsEnumerable().GroupBy(p => p.CreatedAt.ToString("MM/yyyy"))
                .Select(s => new { CreateDate = s.Key, TotalCost = s.Sum(p => p.TotalCost) })
            .Where(s => DateTime.Parse(s.CreateDate) <= DateTime.Parse(lastMonth) && DateTime.Parse(s.CreateDate) >= DateTime.Parse(firstMonth)).OrderBy(s => s.CreateDate);


            var totalCount = db.Payments.AsEnumerable().GroupBy(p => p.CreatedAt.ToString("MM/yyyy"))
                           .Select(s => new { CreateDate = s.Key, Count = s.Count() })
                            .Where(s => DateTime.Parse(s.CreateDate) <= DateTime.Parse(lastMonth) && DateTime.Parse(s.CreateDate) >= DateTime.Parse(firstMonth)).OrderBy(s => s.CreateDate);

            return Ok(new
            {
                totalCost,
                totalCount
            });
        }



        //[HttpGet]
        //[Route("api/Chart/monthServicePayment")]
        //public IHttpActionResult ServicePayment()
        //{
        //    var listPayment = db.Payments.ToList();
        //    var month = DateTime.Now.Month;
        //    var year = DateTime.Now.Year;
        //    var listService = db.Services.ToList();
        //    var firstDayOfMonth = new DateTime(year, month, 1);
        //    var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
        //    List<PaymentDetailService> inBound = new List<PaymentDetailService>();
        //    List<PaymentDetailService> outBound = new List<PaymentDetailService>();
        //    List<PaymentDetailService> teleMarketing = new List<PaymentDetailService>();

        //    for (int i = 0; i < listPayment.Count; i++)
        //    {
        //        var paymentId = listPayment[i].Id;

        //        var query1 = db.PaymentDetails.AsEnumerable().Where(s => s.PaymentId == paymentId && s.ServiceId == 1 && s.Status == PaymentDetailStatus.Active)
        //            .GroupBy(p => p.CreatedAt.ToString("dd/MM/yyyy"))
        //            .Select(s => new PaymentDetailService { CreateDate = s.Key, Count = s.Count() })
        //            .Where(s => DateTime.Parse(s.CreateDate) <= lastDayOfMonth && DateTime.Parse(s.CreateDate) >= firstDayOfMonth).ToList();

        //        foreach (var item in query1)
        //        {
        //            inBound.Add(new PaymentDetailService()
        //            {
        //                CreateDate = item.CreateDate,
        //                Count = item.Count
        //            });
        //        }

        //        var query2 = db.PaymentDetails.AsEnumerable().Where(s => s.PaymentId == paymentId && s.ServiceId == 2 && s.Status == PaymentDetailStatus.Active)
        //            .GroupBy(p => p.CreatedAt.ToString("dd/MM/yyyy"))
        //            .Select(s => new PaymentDetailService { CreateDate = s.Key, Count = s.Count() })
        //            .Where(s => DateTime.Parse(s.CreateDate) <= lastDayOfMonth && DateTime.Parse(s.CreateDate) >= firstDayOfMonth).ToList();

        //        foreach (var item in query2)
        //        {
        //            teleMarketing.Add(new PaymentDetailService()
        //            {
        //                CreateDate = item.CreateDate,
        //                Count = item.Count
        //            });
        //        }

        //        var query3 = db.PaymentDetails.AsEnumerable().Where(s => s.PaymentId == paymentId && s.ServiceId == 3 && s.Status == PaymentDetailStatus.Active)
        //            .GroupBy(p => p.CreatedAt.ToString("dd/MM/yyyy"))
        //            .Select(s => new PaymentDetailService { CreateDate = s.Key, Count = s.Count() })
        //            .Where(s => DateTime.Parse(s.CreateDate) <= lastDayOfMonth && DateTime.Parse(s.CreateDate) >= firstDayOfMonth).ToList();

        //        foreach (var item in query3)
        //        {
        //            outBound.Add(new PaymentDetailService()
        //            {
        //                CreateDate = item.CreateDate,
        //                Count = item.Count
        //            });
        //        }

        //    }

        //    return Ok(new
        //    {
        //        inBound,
        //        outBound,
        //        teleMarketing
        //    });
        //}



        [HttpGet]
        [Route("api/Chart/yearServicePayment")]
        public IHttpActionResult YearServicePayment()
        {
            var listPayment = db.Payments.ToList();
            var month = DateTime.Now.Month;
            var year = DateTime.Now.Year;
            var listService = db.Services.ToList();
            var firstMonth = "01/" + year.ToString();
            var lastMonth = "12/" + year.ToString();
            List<PaymentDetailService> inBound = new List<PaymentDetailService>();
            List<PaymentDetailService> outBound = new List<PaymentDetailService>();
            List<PaymentDetailService> teleMarketing = new List<PaymentDetailService>();

            for (int i = 0; i < listPayment.Count; i++)
            {
                var paymentId = listPayment[i].Id;

                var query1 = db.PaymentDetails.AsEnumerable().Where(s => s.PaymentId == paymentId && s.ServiceId == 1 && s.Status == PaymentDetailStatus.Active)
                    .GroupBy(p => p.CreatedAt.ToString("MM/yyyy"))
                    .Select(s => new PaymentDetailService { CreateDate = s.Key, InBoundCount = s.Count() })
                    .Where(s => DateTime.Parse(s.CreateDate) <= DateTime.Parse(lastMonth) && DateTime.Parse(s.CreateDate) >= DateTime.Parse(firstMonth)).ToList();

                foreach (var item in query1)
                {
                    inBound.Add(new PaymentDetailService()
                    {
                        CreateDate = item.CreateDate,
                        InBoundCount = item.InBoundCount
                    });
                }

                var query2 = db.PaymentDetails.AsEnumerable().Where(s => s.PaymentId == paymentId && s.ServiceId == 2 && s.Status == PaymentDetailStatus.Active)
                    .GroupBy(p => p.CreatedAt.ToString("MM/yyyy"))
                    .Select(s => new PaymentDetailService { CreateDate = s.Key, TeleCount = s.Count() })
                    .Where(s => DateTime.Parse(s.CreateDate) <= DateTime.Parse(lastMonth) && DateTime.Parse(s.CreateDate) >= DateTime.Parse(firstMonth)).ToList();

                foreach (var item in query2)
                {
                    teleMarketing.Add(new PaymentDetailService()
                    {
                        CreateDate = item.CreateDate,
                        TeleCount = item.TeleCount
                    });
                }

                var query3 = db.PaymentDetails.AsEnumerable().Where(s => s.PaymentId == paymentId && s.ServiceId == 3 && s.Status == PaymentDetailStatus.Active)
                    .GroupBy(p => p.CreatedAt.ToString("MM/yyyy"))
                    .Select(s => new PaymentDetailService { CreateDate = s.Key, OutBoundCount = s.Count() })
                    .Where(s => DateTime.Parse(s.CreateDate) <= DateTime.Parse(lastMonth) && DateTime.Parse(s.CreateDate) >= DateTime.Parse(firstMonth)).ToList();

                foreach (var item in query3)
                {
                    outBound.Add(new PaymentDetailService()
                    {
                        CreateDate = item.CreateDate,
                        OutBoundCount = item.OutBoundCount
                    });
                }

            }
            //var query = from i in inBound
            //            join o in outBound on i.CreateDate equals o.CreateDate
            //            join t in teleMarketing on i.CreateDate equals t.CreateDate
            //            select new AllService
            //            {
            //                InBoundCount = i.Count,
            //                OutBoundCount = o.Count,
            //                TeleCount = t.Count
            //            };
            var data = inBound.Union(outBound).Union(teleMarketing);
            return Ok(new
            {
                data
            });
        }


        [HttpGet]
        [Route("api/Chart/monthServicePaymentCost")]
        public IHttpActionResult ServicePaymentCost()
        {
            var listPayment = db.Payments.ToList();
            var month = DateTime.Now.Month;
            var year = DateTime.Now.Year;
            var listService = db.Services.ToList();
            var firstDayOfMonth = new DateTime(year, month, 1);
            var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
            List<PaymentDetailServiceCost> inBound = new List<PaymentDetailServiceCost>();
            List<PaymentDetailServiceCost> outBound = new List<PaymentDetailServiceCost>();
            List<PaymentDetailServiceCost> teleMarketing = new List<PaymentDetailServiceCost>();


            var query1 = db.PaymentDetails.AsEnumerable().Where(s => s.ServiceId == 1 && s.Status == PaymentDetailStatus.Active)
                .GroupBy(p => p.CreatedAt.ToString("dd/MM/yyyy"))
                .Select(s => new PaymentDetailServiceCost { CreateDate = s.Key, Total = s.Sum(p => p.Cost) })
                .Where(s => DateTime.Parse(s.CreateDate) <= lastDayOfMonth && DateTime.Parse(s.CreateDate) >= firstDayOfMonth).ToList();

            foreach (var item in query1)
            {
                inBound.Add(new PaymentDetailServiceCost()
                {
                    CreateDate = item.CreateDate,
                    Total = item.Total
                });
            }

            var query2 = db.PaymentDetails.AsEnumerable().Where(s => s.ServiceId == 2 && s.Status == PaymentDetailStatus.Active)
                .GroupBy(p => p.CreatedAt.ToString("dd/MM/yyyy"))
                .Select(s => new PaymentDetailServiceCost { CreateDate = s.Key, Total = s.Sum(p => p.Cost) })
                .Where(s => DateTime.Parse(s.CreateDate) <= lastDayOfMonth && DateTime.Parse(s.CreateDate) >= firstDayOfMonth).ToList();

            foreach (var item in query2)
            {
                teleMarketing.Add(new PaymentDetailServiceCost()
                {
                    CreateDate = item.CreateDate,
                    Total = item.Total
                });
            }

            var query3 = db.PaymentDetails.AsEnumerable().Where(s => s.ServiceId == 3 && s.Status == PaymentDetailStatus.Active)
                .GroupBy(p => p.CreatedAt.ToString("dd/MM/yyyy"))
                .Select(s => new PaymentDetailServiceCost { CreateDate = s.Key, Total = s.Sum(p => p.Cost) })
                .Where(s => DateTime.Parse(s.CreateDate) <= lastDayOfMonth && DateTime.Parse(s.CreateDate) >= firstDayOfMonth).ToList();

            foreach (var item in query3)
            {
                outBound.Add(new PaymentDetailServiceCost()
                {
                    CreateDate = item.CreateDate,
                    Total = item.Total
                });
            }

            return Ok(new
            {
                inBound,
                outBound,
                teleMarketing
            });
        }


        [HttpGet]
        [Route("api/Chart/yearServicePaymentCost")]
        public IHttpActionResult YearServicePaymentCost()
        {
            var listPayment = db.Payments.ToList();
            var month = DateTime.Now.Month;
            var year = DateTime.Now.Year;
            var listService = db.Services.ToList();
            var firstMonth = "01/" + year.ToString();
            var lastMonth = "12/" + year.ToString();
            List<PaymentDetailServiceCost> inBound = new List<PaymentDetailServiceCost>();
            List<PaymentDetailServiceCost> outBound = new List<PaymentDetailServiceCost>();
            List<PaymentDetailServiceCost> teleMarketing = new List<PaymentDetailServiceCost>();


            var query1 = db.PaymentDetails.AsEnumerable().Where(s => s.ServiceId == 1 && s.Status == PaymentDetailStatus.Active)
                .GroupBy(p => p.CreatedAt.ToString("MM/yyyy"))
                .Select(s => new PaymentDetailServiceCost { CreateDate = s.Key, Total = s.Sum(p => p.Cost) })
                .Where(s => DateTime.Parse(s.CreateDate) <= DateTime.Parse(lastMonth) && DateTime.Parse(s.CreateDate) >= DateTime.Parse(firstMonth)).ToList();

            foreach (var item in query1)
            {
                inBound.Add(new PaymentDetailServiceCost()
                {
                    CreateDate = item.CreateDate,
                    Total = item.Total
                });
            }

            var query2 = db.PaymentDetails.AsEnumerable().Where(s => s.ServiceId == 2 && s.Status == PaymentDetailStatus.Active)
                .GroupBy(p => p.CreatedAt.ToString("MM/yyyy"))
                .Select(s => new PaymentDetailServiceCost { CreateDate = s.Key, Total = s.Sum(p => p.Cost) })
                .Where(s => DateTime.Parse(s.CreateDate) <= DateTime.Parse(lastMonth) && DateTime.Parse(s.CreateDate) >= DateTime.Parse(firstMonth)).ToList();

            foreach (var item in query2)
            {
                teleMarketing.Add(new PaymentDetailServiceCost()
                {
                    CreateDate = item.CreateDate,
                    Total = item.Total
                });
            }

            var query3 = db.PaymentDetails.AsEnumerable().Where(s => s.ServiceId == 3 && s.Status == PaymentDetailStatus.Active)
                .GroupBy(p => p.CreatedAt.ToString("MM/yyyy"))
                .Select(s => new PaymentDetailServiceCost { CreateDate = s.Key, Total = s.Sum(p => p.Cost) })
                .Where(s => DateTime.Parse(s.CreateDate) <= DateTime.Parse(lastMonth) && DateTime.Parse(s.CreateDate) >= DateTime.Parse(firstMonth)).ToList();

            foreach (var item in query3)
            {
                outBound.Add(new PaymentDetailServiceCost()
                {
                    CreateDate = item.CreateDate,
                    Total = item.Total
                });
            }

            return Ok(new
            {
                inBound,
                outBound,
                teleMarketing
            });
        }

        [HttpGet]
        [Route("api/Chart/serviceTotalCost")]
        public IHttpActionResult AllServiceCostPercent()
        {
            var totalCost = db.PaymentDetails.AsEnumerable().Sum(s => s.Cost);
            var inBound = db.PaymentDetails.Where(s => s.ServiceId == 1).Sum(s => s.Cost);
            var outBound = db.PaymentDetails.Where(s => s.ServiceId == 3).Sum(s => s.Cost);
            var tele = db.PaymentDetails.Where(s => s.ServiceId == 2).Sum(s => s.Cost);
            var inBoundPercent = inBound / totalCost * 100;
            var outBoundPercent = outBound / totalCost * 100;
            var telePercent = tele / totalCost * 100;
            return Ok(new
            {
                inBoundPercent,
                outBoundPercent,
                telePercent
            });
        }

        [HttpGet]
        [Route("api/Chart/serviceTotalCount")]
        public IHttpActionResult AllServiceCountPercent()
        {
            var totalCount = db.PaymentDetails.AsEnumerable().Count();
            var inBound = db.PaymentDetails.Where(s => s.ServiceId == 1).Count();
            var outBound = db.PaymentDetails.Where(s => s.ServiceId == 3).Count();
            var tele = db.PaymentDetails.Where(s => s.ServiceId == 2).Count();
          
            return Ok(new
            {
                totalCount,
                inBound,
                outBound,
                tele
            });
        }

        [HttpGet]
        [Route("api/Chart/allTotal")]
        public IHttpActionResult GetAllTotal()
        {
            var totalCost = db.Payments.Sum(s => s.TotalCost);
            var totalClient = db.Clients.Count();
            var totalEmployee = db.Employees.Count();
            var totalPayment = db.Payments.Count();
            var totalPaymentDetail = db.PaymentDetails.Count();

            return Ok(new
            {
                totalCost,
                totalClient,
                totalEmployee,
                totalPayment,
                totalPaymentDetail
            });
        }
    }
}
