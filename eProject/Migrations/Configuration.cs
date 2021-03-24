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

            //Client_________________________________________________________________
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 1,
                Name = "Long Vân",
                PhoneNumber = "0987654321",
                Address = "Long Biên, Hà Nội",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 2,
                Name = "Bizman",
                PhoneNumber = "0987654322",
                Address = "Long Biên, Hà Nội",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 3,
                Name = "Goldsun",
                PhoneNumber = "0987654323",
                Address = "Long Biên, Hà Nội",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 4,
                Name = "Bibica",
                PhoneNumber = "0987654324",
                Address = "Long Biên, Hà Nội",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 5,
                Name = "Hoàng phúc",
                PhoneNumber = "0987654325",
                Address = "Long Biên, Hà Nội",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 6,
                Name = "Đại phát",
                PhoneNumber = "0987654326",
                Address = "Long Biên, Hà Nội",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 7,
                Name = "Hòa phát",
                PhoneNumber = "0987654327",
                Address = "Long Biên, Hà Nội",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 8,
                Name = "Kim tín",
                PhoneNumber = "0987654328",
                Address = "Long Biên, Hà Nội",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 9,
                Name = "Đại Hải",
                PhoneNumber = "0987654329",
                Address = "Long Biên, Hà Nội",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 10,
                Name = "Hoàng Long",
                PhoneNumber = "0987654320",
                Address = "Long Biên, Hà Nội",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
            });
            context.SaveChanges();
            //Department_________________________________________________________________
            context.Departments.AddOrUpdate(new Department()
            {
                Id = 1,
                Name = "Admin",
                Status = DepartmentStatus.Active,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
            });
            context.Departments.AddOrUpdate(new Department()
            {
                Id = 2,
                Name = "Service",
                Status = DepartmentStatus.Active,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
            });
            context.Departments.AddOrUpdate(new Department()
            {
                Id = 3,
                Name = "HR",
                Status = DepartmentStatus.Active,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
            });
            context.Departments.AddOrUpdate(new Department()
            {
                Id = 4,
                Name = "Auditors",
                Status = DepartmentStatus.Active,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
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
            //Payment___________________________________________________________________
            context.Products.AddOrUpdate(new Product()
            {
                Id = 1,
                Name = "Quảng cáo ngoài trời",
                Description = "Cho thuê biển quảng cáo ngoài trời",
                ClientId = 2,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 2,
                Name = "Bánh chưng",
                Description = "Bánh chưng nhân thịt lợn",
                ClientId = 3,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 3,
                Name = "Ghế gấp",
                Description = "Sản xuất kinh doanh bàn ghê",
                ClientId = 4,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 4,
                Name = "Cặp học sinh",
                Description = "Sản xuất cặp da túi sách",
                ClientId = 5,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 5,
                Name = "Bao cao su",
                Description = "Bao cao hen mết siêu bền",
                ClientId = 6,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
            });
            context.SaveChanges();
            //Service______________________________________________________________________
            context.Services.AddOrUpdate(new Service()
            {
                Id = 1,
                Name = "In-bound",
                Price = 4500,
                DepartmentId = 1,
                Status = ServiceStatus.Active,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
            });
            context.Services.AddOrUpdate(new Service()
            {
                Id = 2,
                Name = "Out-bound",
                Price = 6000,
                DepartmentId = 1,
                Status = ServiceStatus.Active,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
            });
            context.Services.AddOrUpdate(new Service()
            {
                Id = 1,
                Name = "Telemarketing",
                Price = 5500,
                DepartmentId = 1,
                Status = ServiceStatus.Active,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
            });
            context.SaveChanges();
        }
    }
}
