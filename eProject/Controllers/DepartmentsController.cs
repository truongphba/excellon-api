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
    public class DepartmentsController : ApiController
    {
        private ExcelDbContext db = new ExcelDbContext();

        // GET: api/Departments
        [System.Web.Http.HttpGet]
        public IHttpActionResult GetDepartments(int limit, int? page, string keyword="", int? status = null)
        {
            var departments = from s in db.Departments
                           select s;
            if (!String.IsNullOrEmpty(keyword))
            {
                departments = departments.Where(s => s.Name.Contains(keyword));
            }
            if (status.HasValue)
            {
                departments = departments.Where(s => s.Status == (DepartmentStatus) status);
            }
            int pageNumber = (page ?? 1);
            var data = departments.OrderByDescending(s => s.CreatedAt).ToPagedList(pageNumber, limit);
            var total = departments.ToList().Count();
            return Ok(new
            {
                data,
                total
            });
        }

        // GET: api/Departments/5
        [ResponseType(typeof(Department))]
        public IHttpActionResult GetDepartment(int id)
        {
            Department department = db.Departments.Find(id);
            if (department == null)
            {
                return NotFound();
            }

            return Ok(department);
        }

        // PUT: api/Departments/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutDepartment(int id, Department department)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != department.Id)
            {
                return BadRequest();
            }
            department.UpdatedAt = DateTime.Now;
            db.Entry(department).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DepartmentExists(id))
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

        // POST: api/Departments
        [ResponseType(typeof(Department))]
        public IHttpActionResult PostDepartment(Department department)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            department.Status = DepartmentStatus.Active;
            department.CreatedAt = DateTime.Now;
            department.UpdatedAt = DateTime.Now;
            db.Departments.Add(department);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = department.Id }, department);
        }

        // DELETE: api/Departments/5
        [ResponseType(typeof(Department))]
        public IHttpActionResult DeleteDepartment(int id)
        {
            Department department = db.Departments.Find(id);
            if (department == null)
            {
                return NotFound();
            }

            department.UpdatedAt = DateTime.Now;
            department.Status = DepartmentStatus.Deactive;
            //db.Departments.Remove(department);
            db.SaveChanges();

            return Ok(department);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DepartmentExists(int id)
        {
            return db.Departments.Count(e => e.Id == id) > 0;
        }
    }
}