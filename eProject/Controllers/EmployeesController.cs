using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
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