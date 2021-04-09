using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using ClosedXML.Excel;
using eProject.Models;
using PagedList;

namespace eProject.Controllers
{
    public class EmployeesController : ApiController
    {
        private ExcelDbContext db = new ExcelDbContext();

        // GET: api/Employees
        public IHttpActionResult GetEmployees(int limit, int? page, string keyword = "", int? status = null, int? departmentId = null)
        {
            var employees = from s in db.Employees
                              select s;
            if (!String.IsNullOrEmpty(keyword))
            {
                employees = employees.Where(s => s.UserName.Contains(keyword) || s.Email.Contains(keyword));
            }
            if (status.HasValue)
            {
                employees = employees.Where(s => s.Status == (EmployeeStatus)status);
            }
            if (departmentId.HasValue)
            {
                employees = employees.Where(p => p.DepartmentId == departmentId);
            }
            int pageNumber = (page ?? 1);
            var data = employees.Include(c => c.Department).OrderByDescending(s => s.CreatedAt).ToPagedList(pageNumber, limit);
            var total = employees.ToList().Count();
            return Ok(new
            {
                data,
                total
            });
        }

        [System.Web.Http.Route("api/Employees/Export")]
        [System.Web.Http.HttpGet]
        public void ExportToExcel(int limit, int? page, string keyword = "", int? status = null)
        {
            var employees = from s in db.Employees select s;
            if (!String.IsNullOrEmpty(keyword))
            {
                employees = employees.Where(s => s.UserName.Contains(keyword) || s.Email.Contains(keyword));
            }
            if (status.HasValue)
            {
                employees = employees.Where(s => s.Status == (EmployeeStatus)status);
            }
            int pageNumber = (page ?? 1);
            var data = employees.Include(c => c.Department).OrderByDescending(s => s.CreatedAt).ToPagedList(pageNumber, limit);
            XLWorkbook wb = new XLWorkbook();
            var worksheet = wb.Worksheets.Add("Employee");
            var currentRow = 1;
            worksheet.Cell(currentRow, 1).Value = "Name";
            worksheet.Cell(currentRow, 2).Value = "Email";
            worksheet.Cell(currentRow, 3).Value = "Phone Number";
            worksheet.Cell(currentRow, 4).Value = "Address";
            worksheet.Cell(currentRow, 5).Value = "Department";
            worksheet.Cell(currentRow, 6).Value = "Create At";
            worksheet.Cell(currentRow, 7).Value = "Status";

            foreach (Employee employee in data)
            {
                currentRow++;
                worksheet.Cell(currentRow, 1).Value = employee.UserName;
                worksheet.Cell(currentRow, 2).Value = employee.Email;
                worksheet.Cell(currentRow, 3).Value = employee.PhoneNumber;
                worksheet.Cell(currentRow, 4).Value = employee.Address;
                worksheet.Cell(currentRow, 5).Value = employee.Department.Name;
                worksheet.Cell(currentRow, 6).Value = employee.CreatedAt;
                worksheet.Cell(currentRow, 7).Value = employee.Status;
            }


            HttpContext.Current.Response.Clear();
            HttpContext.Current.Response.Buffer = true;
            HttpContext.Current.Response.Charset = "";
            HttpContext.Current.Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            HttpContext.Current.Response.AddHeader("Content-disposition", "attachment;filename=Employee.xlsx");
            MemoryStream stream = new MemoryStream();
            wb.SaveAs(stream);
            HttpContext.Current.Response.AddHeader("Content-length", stream.ToArray().Length.ToString());
            stream.WriteTo(HttpContext.Current.Response.OutputStream);
            HttpContext.Current.Response.Flush();
            HttpContext.Current.Response.End();

        }

        [Route("api/Employees/All")]
        [HttpGet]
        public IHttpActionResult GetAllEmployees(int? departmentId = null)
        {
            var employees = from s in db.Employees
                            select s;
            if (departmentId.HasValue)
            {
                employees = employees.Where(p => p.DepartmentId == departmentId);
            }
            var data = employees.OrderByDescending(s => s.CreatedAt).ToList();
            return Ok(new
            {
                data
            });
        }
        // GET: api/Employees/5
        [ResponseType(typeof(Employee))]
        public IHttpActionResult GetEmployee(string id)
        {
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }

        // PUT: api/Employees/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEmployee(string id, Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != employee.Id)
            {
                return BadRequest();
            }

            employee.UpdatedAt = DateTime.Now;
            db.Entry(employee).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeExists(id))
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

        // POST: api/Employees
        [ResponseType(typeof(Employee))]
        public IHttpActionResult PostEmployee(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            employee.Status = EmployeeStatus.Active;
            employee.CreatedAt = DateTime.Now;
            employee.UpdatedAt = DateTime.Now;
            db.Employees.Add(employee);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (EmployeeExists(employee.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = employee.Id }, employee);
        }

        // DELETE: api/Employees/5
        [ResponseType(typeof(Employee))]
        public IHttpActionResult DeleteEmployee(string id)
        {
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }
            employee.UpdatedAt = DateTime.Now;
            employee.Status = EmployeeStatus.Deactive;
            //db.Employees.Remove(employee);
            db.SaveChanges();

            return Ok(employee);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EmployeeExists(string id)
        {
            return db.Employees.Count(e => e.Id == id) > 0;
        }
    }
}