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
    public class ProductsController : ApiController
    {
        private ExcelDbContext db = new ExcelDbContext();

        // GET: api/Products
        [System.Web.Http.HttpGet]
        public IHttpActionResult GetProducts(int limit, int? page, string keyword = "", int? status = null)
        {
            var products = from s in db.Products
                              select s;
            if (!String.IsNullOrEmpty(keyword))
            {
                products = products.Where(s => s.Name.Contains(keyword));
            }
            if (status.HasValue)
            {
                products = products.Where(s => s.Status == (ProductService)status);
            }
            int pageNumber = (page ?? 1);
            var data = products.OrderByDescending(s => s.CreatedAt).ToPagedList(pageNumber, limit);
            var total = products.ToList().Count();
            return Ok(new
            {
                data,
                total
            });
        }

        // GET: api/Products/5
        [ResponseType(typeof(Product))]
        public IHttpActionResult GetProduct(int id)
        {
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        // PUT: api/Products/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProduct(int id, Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != product.Id)
            {
                return BadRequest();
            }
            product.UpdatedAt = DateTime.Now;
            db.Entry(product).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(id))
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

        // POST: api/Products
        [ResponseType(typeof(Product))]
        public IHttpActionResult PostProduct(Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            product.Status = ProductService.Active;
            product.CreatedAt = DateTime.Now;
            product.UpdatedAt = DateTime.Now;
            db.Products.Add(product);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = product.Id }, product);
        }

        // DELETE: api/Products/5
        [ResponseType(typeof(Product))]
        public IHttpActionResult DeleteProduct(int id)
        {
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }

            product.UpdatedAt = DateTime.Now;
            product.Status = ProductService.Deactive;
            //db.Products.Remove(product);
            db.SaveChanges();

            return Ok(product);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProductExists(int id)
        {
            return db.Products.Count(e => e.Id == id) > 0;
        }
    }
}