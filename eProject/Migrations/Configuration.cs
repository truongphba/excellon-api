namespace eProject.Migrations
{
    using eProject.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<eProject.Models.ExcelDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(eProject.Models.ExcelDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Database.ExecuteSqlCommand("DELETE FROM [AspNetUsers]");
            //context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('AspNetUsers', RESEED, 0)");
            context.Database.ExecuteSqlCommand("DELETE FROM [Clients]");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Clients', RESEED, 0)");
            context.Database.ExecuteSqlCommand("DELETE FROM [Departments]");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Departments', RESEED, 0)");
            context.Database.ExecuteSqlCommand("DELETE FROM [Payments]");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Payments', RESEED, 0)");
            context.Database.ExecuteSqlCommand("DELETE FROM [PaymentDetails]");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('PaymentDetails', RESEED, 0)");
            context.Database.ExecuteSqlCommand("DELETE FROM [Products]");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Products', RESEED, 0)");
            context.Database.ExecuteSqlCommand("DELETE FROM [Services]");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Services', RESEED, 0)");

            //Department_________________________________________________________________
            context.Departments.AddOrUpdate(new Department()
            {
                Id = 1,
                Name = "Admin",
                Status = DepartmentStatus.Active
            });
            context.Departments.AddOrUpdate(new Department()
            {
                Id = 2,
                Name = "Service",
                Status = DepartmentStatus.Active
            });
            context.Departments.AddOrUpdate(new Department()
            {
                Id = 3,
                Name = "HR",
                Status = DepartmentStatus.Active
            });
            context.Departments.AddOrUpdate(new Department()
            {
                Id = 4,
                Name = "Auditors",
                Status = DepartmentStatus.Active
            });
            context.SaveChanges();
            //User_________________________________________________________________
            context.Employees.AddOrUpdate(new Employee()
            {
                Id = "1",
                UserName = "bangnd",
                PhoneNumber = "0912345670",
                Email = "bangnd@gmail.com",
                PasswordHash = "123456",
                Address = "Gia Lâm, Hà Nội",
                DepartmentId=3,
                Status = EmployeeStatus.Active,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
            });
            context.Employees.AddOrUpdate(new Employee()
            {
                Id = "2",
                UserName = "truongnd",
                PhoneNumber = "0912345671",
                Email = "truongnd@gmail.com",
                PasswordHash = "123456",
                Address = "Gia Lâm, Hà Nội",
                DepartmentId = 1,
                Status = EmployeeStatus.Active,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
            });
            context.Employees.AddOrUpdate(new Employee()
            {
                Id = "3",
                UserName = "ducnd",
                PhoneNumber = "0912345672",
                Email = "ducnd@gmail.com",
                PasswordHash = "123456",
                Address = "Gia Lâm, Hà Nội",
                DepartmentId = 2,
                Status = EmployeeStatus.Active,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
            });
            context.Employees.AddOrUpdate(new Employee()
            {
                Id = "4",
                UserName = "thanhnd",
                PhoneNumber = "0912345673",
                Email = "thanhnd@gmail.com",
                PasswordHash = "123456",
                Address = "Gia Lâm, Hà Nội",
                DepartmentId = 1,
                Status = EmployeeStatus.Active,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
            });
            context.Employees.AddOrUpdate(new Employee()
            {
                Id = "5",
                UserName = "kiennd",
                PhoneNumber = "0912345674",
                Email = "kiennd@gmail.com",
                PasswordHash = "123456",
                Address = "Gia Lâm, Hà Nội",
                DepartmentId = 1,
                Status = EmployeeStatus.Active,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
            });
            context.Employees.AddOrUpdate(new Employee()
            {
                Id = "6",
                UserName = "longnd",
                PhoneNumber = "0912345675",
                Email = "longnd@gmail.com",
                PasswordHash = "123456",
                Address = "Gia Lâm, Hà Nội",
                DepartmentId = 3,
                Status = EmployeeStatus.Active,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
            });
            context.Employees.AddOrUpdate(new Employee()
            {
                Id = "7",
                UserName = "namnd",
                PhoneNumber = "0912345676",
                Email = "namnd@gmail.com",
                PasswordHash = "123456",
                Address = "Gia Lâm, Hà Nội",
                DepartmentId = 1,
                Status = EmployeeStatus.Active,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
            });
            context.Employees.AddOrUpdate(new Employee()
            {
                Id = "8",
                UserName = "hoangnd",
                PhoneNumber = "0912345677",
                Email = "hoangnd@gmail.com",
                PasswordHash = "123456",
                Address = "Gia Lâm, Hà Nội",
                DepartmentId = 1,
                Status = EmployeeStatus.Active,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
            });
            context.Employees.AddOrUpdate(new Employee()
            {
                Id = "9",
                UserName = "manhnd",
                PhoneNumber = "0912345678",
                Email = "manhnd@gmail.com",
                PasswordHash = "123456",
                Address = "Gia Lâm, Hà Nội",
                DepartmentId = 1,
                Status = EmployeeStatus.Active,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
            });
            context.Employees.AddOrUpdate(new Employee()
            {
                Id = "10",
                UserName = "hungnd",
                PhoneNumber = "0912345679",
                Email = "hungnd@gmail.com",
                PasswordHash = "123456",
                Address = "Gia Lâm, Hà Nội",
                DepartmentId = 1,
                Status = EmployeeStatus.Active,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
            });
            context.SaveChanges();
        }
    }
}
