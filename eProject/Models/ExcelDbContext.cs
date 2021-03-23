using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace eProject.Models
{
    public class ExcelDbContext : IdentityDbContext
    {
        public ExcelDbContext() : base("MyConnectionString")
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentDetail> PaymentDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Service> Services { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>()
                .HasRequired(e => e.Department)
                .WithMany(department => department.Employees)
                .HasForeignKey(e => e.DepartmentId);

            modelBuilder.Entity<Service>()
                .HasRequired(s => s.Department)
                .WithMany(department => department.Services)
                .HasForeignKey(s => s.DepartmentId);

            modelBuilder.Entity<Payment>()
                .HasRequired(p => p.Employee)
                .WithMany(employee => employee.Payments)
                .HasForeignKey(p => p.EmployeeId);

            modelBuilder.Entity<Payment>()
                .HasRequired(p => p.Client)
                .WithMany(client => client.Payments)
                .HasForeignKey(p => p.ClientId);

            modelBuilder.Entity<Product>()
                .HasRequired(p => p.Client)
                .WithMany(client => client.Products)
                .HasForeignKey(p => p.ClientId);

            modelBuilder.Entity<PaymentDetail>()
                .HasRequired(p => p.Payment)
                .WithMany(payment => payment.PaymentDetails)
                .HasForeignKey(p => p.PaymentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PaymentDetail>()
                .HasRequired(p => p.Product)
                .WithMany(product => product.PaymentDetails)
                .HasForeignKey(p => p.ProductId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PaymentDetail>()
                .HasRequired(p => p.Service)
                .WithMany(service => service.PaymentDetails)
                .HasForeignKey(p => p.ServiceId)
                .WillCascadeOnDelete(false);
        }
    }
}