using ClosedXML.Excel;
using eProject.Models;
using PagedList;
using System;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;

namespace eProject.Controllers
{
    public class ClientsController : ApiController
    {
        private ExcelDbContext db = new ExcelDbContext();

        // GET: api/Clients
        [System.Web.Http.HttpGet]
        public IHttpActionResult GetClients(int limit, int? page, string keyword = "", int? status = null)
        {
            var clients = from s in db.Clients
                              select s;
            if (!String.IsNullOrEmpty(keyword))
            {
                clients = clients.Where(s => s.Name.Contains(keyword));
            }
            if (status.HasValue)
            {
                clients = clients.Where(s => s.Status == (ClientStatus)status);
            }
            int pageNumber = (page ?? 1);
            var data = clients.OrderByDescending(s => s.CreatedAt).ToPagedList(pageNumber, limit);
            var total = clients.ToList().Count();
            return Ok(new
            {
                data,
                total
            });
        }

        [System.Web.Http.Route("api/Client/Export")]
        [System.Web.Http.HttpGet]
        public void ExportToExcel(int limit, int? page, string keyword = "", int? status = null)
        {
            var clients = from s in db.Clients
                          select s;
            if (!String.IsNullOrEmpty(keyword))
            {
                clients = clients.Where(s => s.Name.Contains(keyword));
            }
            if (status.HasValue)
            {
                clients = clients.Where(s => s.Status == (ClientStatus)status);
            }
            int pageNumber = (page ?? 1);
            var data = clients.OrderByDescending(s => s.CreatedAt).ToPagedList(pageNumber, limit);
            XLWorkbook wb = new XLWorkbook();
            var worksheet = wb.Worksheets.Add("Client");
            var currentRow = 1;
            worksheet.Cell(currentRow, 1).Value = "Name";
            worksheet.Cell(currentRow, 3).Value = "Phone Number";
            worksheet.Cell(currentRow, 4).Value = "Address";
            worksheet.Cell(currentRow, 7).Value = "Status";
            worksheet.Cell(currentRow, 6).Value = "Create At";

            foreach (Client client in data)
            {
                currentRow++;
                worksheet.Cell(currentRow, 1).Value = client.Name;
                worksheet.Cell(currentRow, 3).Value = client.PhoneNumber;
                worksheet.Cell(currentRow, 4).Value = client.Address;
                worksheet.Cell(currentRow, 7).Value = client.Status;
                worksheet.Cell(currentRow, 6).Value = client.CreatedAt;

            }


            HttpContext.Current.Response.Clear();
            HttpContext.Current.Response.Buffer = true;
            HttpContext.Current.Response.Charset = "";
            HttpContext.Current.Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            HttpContext.Current.Response.AddHeader("content-disposition", "attachment;filename=Client.xlsx");
            MemoryStream stream = new MemoryStream();
            wb.SaveAs(stream);
            HttpContext.Current.Response.AddHeader("content-length", stream.ToArray().Length.ToString());
            stream.WriteTo(HttpContext.Current.Response.OutputStream);
            HttpContext.Current.Response.Flush();
            HttpContext.Current.Response.End();
        }

        [Route("api/Clients/All")]
        [HttpGet]
        public IHttpActionResult GetAllClients()
        {
            var data = db.Clients.ToList();
            return Ok(new
            {
                data
            });
        }

        // GET: api/Clients/5
        [ResponseType(typeof(Client))]
        public IHttpActionResult GetClient(int id)
        {
            Client client = db.Clients.Find(id);
            if (client == null)
            {
                return NotFound();
            }

            return Ok(client);
        }

        // PUT: api/Clients/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutClient(int id, Client client)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != client.Id)
            {
                return BadRequest();
            }
            client.UpdatedAt = DateTime.Now;
            db.Entry(client).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClientExists(id))
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

        // POST: api/Clients
        [ResponseType(typeof(Client))]
        public IHttpActionResult PostClient(Client client)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            client.Status = ClientStatus.Active;
            client.CreatedAt = DateTime.Now;
            client.UpdatedAt = DateTime.Now;
            db.Clients.Add(client);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = client.Id }, client);
        }

        // DELETE: api/Clients/5
        [ResponseType(typeof(Client))]
        public IHttpActionResult DeleteClient(int id)
        {
            Client client = db.Clients.Find(id);
            if (client == null)
            {
                return NotFound();
            }

            client.UpdatedAt = DateTime.Now;
            client.Status = ClientStatus.Deactive;
            //db.Clients.Remove(client);
            db.SaveChanges();

            return Ok(client);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ClientExists(int id)
        {
            return db.Clients.Count(e => e.Id == id) > 0;
        }
    }
}