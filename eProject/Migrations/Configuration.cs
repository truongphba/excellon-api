﻿namespace eProject.Migrations
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
            context.Database.ExecuteSqlCommand("DELETE FROM [PaymentDetails]");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Payments', RESEED, 0)");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('PaymentDetails', RESEED, 0)");
            context.Database.ExecuteSqlCommand("DELETE FROM [Products]");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Products', RESEED, 0)");
            context.Database.ExecuteSqlCommand("DELETE FROM [Services]");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Services', RESEED, 0)");
            context.Database.ExecuteSqlCommand("DELETE FROM [Contacts]");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Contacts', RESEED, 0)");

            //Department_________________________________________________________________
            context.Departments.AddOrUpdate(new Department()
            {
                Id = 1,
                Name = "Adminstator",
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
                Name = "Human Resource",
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
                Id = 3,
                Name = "Telemarketing",
                Price = 5500,
                DepartmentId = 1,
                Status = ServiceStatus.Active,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
            });
            context.SaveChanges();

            //____________________Client______________________
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 1,
                Name = "Công ty Cổ phần Tập đoàn Masterise",
                TaxCode = "304840018",
                ClientCode = "Masterise",
                ClientSource = "Hotline",
                PhoneNumber = "0989850321",
                Address = "Số 19, Tòa nhà Masteri An Phú, 179 Xa lộ Hà Nội, Tp.HCM",
                Career = "VLXD",
                Email = "AnhA@gmail.com",
                PointOfContact = "Anh A",
                Position = "GĐ",
                Description = "Công ty Cổ phần Tập đoàn Masterise có mã số thuế 304840018. Địa chỉ tại: Số 19, Tòa nhà Masteri An Phú, 179 Xa lộ Hà Nội, Tp.HCM Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: VLXD",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-204),
                UpdatedAt
             = DateTime.Now.AddDays(-204)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 2,
                Name = "Công ty cổ phần XNK Van vòi Minh Hòa",
                TaxCode = "109348074",
                ClientCode = "Van vòi Minh Hòa",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850322",
                Address = "Hà Nội",
                Career = "VLXD",
                Email = "Ms.Duong@gmail.com",
                PointOfContact = "Ms.Dương",
                Position = "MKT",
                Description = "Công ty cổ phần XNK Van vòi Minh Hòa có mã số thuế 109348074. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: VLXD",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-203),
                UpdatedAt
             = DateTime.Now.AddDays(-203)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 3,
                Name = "Tập Đoàn An Phát Holdings",
                TaxCode = "801210129",
                ClientCode = "APH",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850323",
                Address = "148 Hoàng Quốc Việt, Nghĩa Tân, Từ Liêm, Hà Nội",
                Career = "VLXD",
                Email = "ms.Thien@gmail.com",
                PointOfContact = "ms. Thiên",
                Position = "TP Thương hiệu",
                Description = "Tập Đoàn An Phát Holdings có mã số thuế 801210129. Địa chỉ tại: 148 Hoàng Quốc Việt, Nghĩa Tân, Từ Liêm, Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: VLXD",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-202),
                UpdatedAt
             = DateTime.Now.AddDays(-202)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 4,
                Name = "Công Ty Cổ Phần Amaccao",
                TaxCode = "700446110",
                ClientCode = "Amaccao",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850324",
                Address = "4 Tòa nhà Vườn Đào, Ngõ 689 Đ. Lạc Long Quân, Phú Thượng, Tây Hồ, Hà Nội",
                Career = "Bất động sản",
                Email = "Mr.TuanAnh@gmail.com",
                PointOfContact = "Mr. Tuấn Anh",
                Position = "OOH Planner",
                Description = "Công Ty Cổ Phần Amaccao có mã số thuế 700446110. Địa chỉ tại: 4 Tòa nhà Vườn Đào, Ngõ 689 Đ. Lạc Long Quân, Phú Thượng, Tây Hồ, Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bất động sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-201),
                UpdatedAt
             = DateTime.Now.AddDays(-201)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 5,
                Name = "Công Ty Cổ Phần Đầu Tư Phát Triển Bất Động Sản Tnr Holdings Việt Nam",
                TaxCode = "107462896",
                ClientCode = "TNR Holdings",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850325",
                Address = "54 Nguyễn Chí Thanh, Láng Thượng, Đống Đa, Hà Nội",
                Career = "Bất động sản",
                Email = "Mr.Trung@gmail.com",
                PointOfContact = "Mr. Trung",
                Position = "Giám đốc MKT",
                Description = "Công Ty Cổ Phần Đầu Tư Phát Triển Bất Động Sản Tnr Holdings Việt Nam có mã số thuế 107462896. Địa chỉ tại: 54 Nguyễn Chí Thanh, Láng Thượng, Đống Đa, Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bất động sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-200),
                UpdatedAt
             = DateTime.Now.AddDays(-200)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 6,
                Name = "Ngân Hàng Thương Mại Cổ Phần Đại Chúng Việt Nam",
                TaxCode = "101057919",
                ClientCode = "PVCOMBANK",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850326",
                Address = "22 Ngô Quyền",
                Career = "Ngân hàng",
                Email = "Mr.An@gmail.com",
                PointOfContact = "Mr. An",
                Position = "Giám đốc MKT",
                Description = "Ngân Hàng Thương Mại Cổ Phần Đại Chúng Việt Nam có mã số thuế 101057919. Địa chỉ tại: 22 Ngô Quyền Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Ngân hàng",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-199),
                UpdatedAt
             = DateTime.Now.AddDays(-199)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 7,
                Name = "Công ty TNHH Thương mại Dịch vụ Tân Huyền Phát",
                TaxCode = "314244127",
                ClientCode = "Lavish H",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850327",
                Address = "96A Nam Kỳ Khởi Nghĩa, Quận 1, TP. HCM",
                Career = "Mỹ phẩm, lam đẹp, cssk",
                Email = "Ms.Huyen@gmail.com",
                PointOfContact = "Ms. Huyền",
                Position = "Founder",
                Description = "Công ty TNHH Thương mại Dịch vụ Tân Huyền Phát có mã số thuế 314244127. Địa chỉ tại: 96A Nam Kỳ Khởi Nghĩa, Quận 1, TP. HCM Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Mỹ phẩm, lam đẹp, cssk",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-198),
                UpdatedAt
             = DateTime.Now.AddDays(-198)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 8,
                Name = "Công ty TNHH Điện thoại Petro Electricity Viêt Nam",
                TaxCode = "106843546",
                ClientCode = "Petro Electricity Viêt Nam (Mi Việt Nam)",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850328",
                Address = "Số 31L Láng Hạ, Phường Thành Công, Quận Ba Đình, Hà Nội",
                Career = "Điện tử, điện thoại & linh kiện",
                Email = "Mr.Duong@gmail.com",
                PointOfContact = "Mr. Dương",
                Position = "MKT manager",
                Description = "Công ty TNHH Điện thoại Petro Electricity Viêt Nam có mã số thuế 106843546. Địa chỉ tại: Số 31L Láng Hạ, Phường Thành Công, Quận Ba Đình, Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Điện tử, điện thoại & linh kiện",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-197),
                UpdatedAt
             = DateTime.Now.AddDays(-197)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 9,
                Name = "Công Ty TNHH Tập Đoàn Đầu Tư Châu Á",
                TaxCode = "4101148419",
                ClientCode = "Agency",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850329",
                Address = "Hà Nội",
                Career = "Gia dụng",
                Email = "MrThanh@gmail.com",
                PointOfContact = "Mr Thành",
                Position = "Giám Đốc",
                Description = "Công Ty TNHH Tập Đoàn Đầu Tư Châu Á có mã số thuế 4101148419. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Gia dụng",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-196),
                UpdatedAt
             = DateTime.Now.AddDays(-196)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 10,
                Name = "Công Ty TNHH Nguyên Linh Lâm Thao",
                TaxCode = "2600855882",
                ClientCode = "supe lâm thao",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850330",
                Address = "Hà Nội",
                Career = "Hóa chất",
                Email = "Mr.Anh@gmail.com",
                PointOfContact = "Mr. Ánh",
                Position = "GĐ MKT",
                Description = "Công Ty TNHH Nguyên Linh Lâm Thao có mã số thuế 2600855882. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Hóa chất",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-195),
                UpdatedAt
             = DateTime.Now.AddDays(-195)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 11,
                Name = "Công Ty TNHH Nguyên Linh Lâm Thao",
                TaxCode = "2600855882",
                ClientCode = "Supe Lâm Thao",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850331",
                Address = "Hà Nội",
                Career = "Hóa chất",
                Email = "Mr.Anh@gmail.com",
                PointOfContact = "Mr. Ánh",
                Position = "GĐ MKT",
                Description = "Công Ty TNHH Nguyên Linh Lâm Thao có mã số thuế 2600855882. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Hóa chất",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-194),
                UpdatedAt
             = DateTime.Now.AddDays(-194)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 12,
                Name = "Công Ty TNHH Ferroli Asean",
                TaxCode = "500579201",
                ClientCode = "Ferolli",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850332",
                Address = "Hà Nội",
                Career = "Gia dụng",
                Email = "Ms.Hanh@gmail.com",
                PointOfContact = "Ms. Hạnh",
                Position = "MKT",
                Description = "Công Ty TNHH Ferroli Asean có mã số thuế 500579201. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Gia dụng",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-193),
                UpdatedAt
             = DateTime.Now.AddDays(-193)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 13,
                Name = "Công Ty Cổ Phần Y Dược Phẩm Vimedimex",
                TaxCode = "300479760",
                ClientCode = "Dược Vimedimex",
                ClientSource = "Hotline",
                PhoneNumber = "0989850333",
                Address = "Hà Nội",
                Career = "Bất động sản",
                Email = "Mr.Hieu@gmail.com",
                PointOfContact = "Mr. Hiếu",
                Position = "MKT",
                Description = "Công Ty Cổ Phần Y Dược Phẩm Vimedimex có mã số thuế 300479760. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bất động sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-192),
                UpdatedAt
             = DateTime.Now.AddDays(-192)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 14,
                Name = "ông ty Cổ phần Đầu tư và Phát triển hạ tầng PPC An Thịnh Việt Nam",
                TaxCode = "108239354",
                ClientCode = "PPC An Thịnh",
                ClientSource = "Công ty",
                PhoneNumber = "0989850334",
                Address = "Hà Nội",
                Career = "Bất động sản",
                Email = "Ms.Duyen@gmail.com",
                PointOfContact = "Ms. Duyên",
                Position = "MKT manager",
                Description = "ông ty Cổ phần Đầu tư và Phát triển hạ tầng PPC An Thịnh Việt Nam có mã số thuế 108239354. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bất động sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-191),
                UpdatedAt
             = DateTime.Now.AddDays(-191)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 15,
                Name = "Công Ty Cổ Phần Tập Đoàn Avland Việt Nam",
                TaxCode = "109073415",
                ClientCode = "AVLand",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850335",
                Address = "Tầng 7, Tòa Nhà Star Tower, Số 68 Đ. Đình Nghệ, Yên Hoà, Cầu Giấy, Hà Nội",
                Career = "Bất động sản",
                Email = "Mr.Kiem@gmail.com",
                PointOfContact = "Mr. Kiểm",
                Position = "TGD",
                Description = "Công Ty Cổ Phần Tập Đoàn Avland Việt Nam có mã số thuế 109073415. Địa chỉ tại: Tầng 7, Tòa Nhà Star Tower, Số 68 Đ. Đình Nghệ, Yên Hoà, Cầu Giấy, Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bất động sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-190),
                UpdatedAt
             = DateTime.Now.AddDays(-190)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 16,
                Name = "Văn Phú Invest",
                TaxCode = "102702590",
                ClientCode = "Công Ty Cổ Phần Đầu Tư Văn Phú - Invest",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850336",
                Address = "104 Thái Thịnh, Hà Nội",
                Career = "Bất động sản",
                Email = "Ms.HaiAnh@gmail.com",
                PointOfContact = "Ms. Hải Anh",
                Position = "Trưởng phòng MKT",
                Description = "Văn Phú Invest có mã số thuế 102702590. Địa chỉ tại: 104 Thái Thịnh, Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bất động sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-189),
                UpdatedAt
             = DateTime.Now.AddDays(-189)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 17,
                Name = "Công Ty CP Thực Phẩm Xuất Khẩu Đồng Giao",
                TaxCode = "2700224457",
                ClientCode = "Doveco",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850337",
                Address = "Hà Nội",
                Career = "FMCG",
                Email = "Mr.Khue@gmail.com",
                PointOfContact = "Mr. Khuê",
                Position = "Chủ tịch",
                Description = "Công Ty CP Thực Phẩm Xuất Khẩu Đồng Giao có mã số thuế 2700224457. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: FMCG",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-188),
                UpdatedAt
             = DateTime.Now.AddDays(-188)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 18,
                Name = "Tập đoàn Công nghiệp – Viễn thông Quân đội (Viettel)",
                TaxCode = "100109106",
                ClientCode = "Viettel Group",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850338",
                Address = "Lô D26, Khu đô thị mới Cầu Giấy",
                Career = "Viễn Thông",
                Email = "Ms.Thanh@gmail.com",
                PointOfContact = "Ms. Thành",
                Position = "Giám đốc thương hiệu",
                Description = "Tập đoàn Công nghiệp – Viễn thông Quân đội (Viettel) có mã số thuế 100109106. Địa chỉ tại: Lô D26, Khu đô thị mới Cầu Giấy Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Viễn Thông",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-187),
                UpdatedAt
             = DateTime.Now.AddDays(-187)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 19,
                Name = "Công Ty TNHH Cg Food",
                TaxCode = "109302908",
                ClientCode = "CG Food",
                ClientSource = "Hotline",
                PhoneNumber = "0989850339",
                Address = "Hà Nội",
                Career = "FMCG",
                Email = "Mr.Hoa@gmail.com",
                PointOfContact = "Mr. Hòa",
                Position = "Giám đốc",
                Description = "Công Ty TNHH Cg Food có mã số thuế 109302908. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: FMCG",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-186),
                UpdatedAt
             = DateTime.Now.AddDays(-186)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 20,
                Name = "Công ty cổ phần Mutosi",
                TaxCode = "108468756",
                ClientCode = "Mutosi",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850340",
                Address = "Hà Nội",
                Career = "gia dụng",
                Email = "Mr.Dung@gmail.com",
                PointOfContact = "Mr. Dũng",
                Position = "Chủ tịch",
                Description = "Công ty cổ phần Mutosi có mã số thuế 108468756. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: gia dụng",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-185),
                UpdatedAt
             = DateTime.Now.AddDays(-185)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 21,
                Name = "Tập đoàn Xăng dầu Việt Nam",
                TaxCode = "100107370",
                ClientCode = "petrolimex",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850341",
                Address = "Số 9 Đòa Duy Anh",
                Career = "nhiên liệu",
                Email = "Mr.Chinh@gmail.com",
                PointOfContact = "Mr. Chính",
                Position = "trưởng ban truyền thông",
                Description = "Tập đoàn Xăng dầu Việt Nam có mã số thuế 100107370. Địa chỉ tại: Số 9 Đòa Duy Anh Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: nhiên liệu",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-184),
                UpdatedAt
             = DateTime.Now.AddDays(-184)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 22,
                Name = "Công ty Cổ phần Tập đoàn C.E.O",
                TaxCode = "101183550",
                ClientCode = "SONASEA VÂN ĐỒN",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850342",
                Address = "Tầng 5, Tháp CEO, Đường Phạm Hùng, Hà Nội",
                Career = "bất động sản",
                Email = "Mr.Ha@gmail.com",
                PointOfContact = "Mr. Hà",
                Position = "MKT manager",
                Description = "Công ty Cổ phần Tập đoàn C.E.O có mã số thuế 101183550. Địa chỉ tại: Tầng 5, Tháp CEO, Đường Phạm Hùng, Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: bất động sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-183),
                UpdatedAt
             = DateTime.Now.AddDays(-183)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 23,
                Name = "Công ty TNHH phát triển công nghệ Thái Sơn",
                TaxCode = "101300842",
                ClientCode = "ThaiSon Soft",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850343",
                Address = "Hà Nội",
                Career = "công nghệ",
                Email = "Ms.Hai@gmail.com",
                PointOfContact = "Ms. Hải",
                Position = "MKT manager",
                Description = "Công ty TNHH phát triển công nghệ Thái Sơn có mã số thuế 101300842. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: công nghệ",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-182),
                UpdatedAt
             = DateTime.Now.AddDays(-182)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 24,
                Name = "Công ty HONDA Việt Nam",
                TaxCode = "2500150543",
                ClientCode = "Honda xe máy",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850344",
                Address = "Số 1 Thái Hà",
                Career = "Ô tô xe máy",
                Email = "Mr.Son@gmail.com",
                PointOfContact = "Mr. Sơn",
                Position = "MKT manager",
                Description = "Công ty HONDA Việt Nam có mã số thuế 2500150543. Địa chỉ tại: Số 1 Thái Hà Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Ô tô xe máy",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-181),
                UpdatedAt
             = DateTime.Now.AddDays(-181)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 25,
                Name = "Công ty Cổ phần Đầu tư An Lạc",
                TaxCode = "101219535",
                ClientCode = "An Lạc",
                ClientSource = "Hotline",
                PhoneNumber = "0989850345",
                Address = "Hà Nội",
                Career = "Bất động sản",
                Email = "Ms.Van@gmail.com",
                PointOfContact = "Ms. Vân",
                Position = "TP MKT",
                Description = "Công ty Cổ phần Đầu tư An Lạc có mã số thuế 101219535. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bất động sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-180),
                UpdatedAt
             = DateTime.Now.AddDays(-180)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 26,
                Name = "Công Ty TNHH Odk Mikazuki Việt Na",
                TaxCode = "400510460",
                ClientCode = "mikazuki",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850346",
                Address = "Hà Nội",
                Career = "Ô tô xe máy",
                Email = "@gmail.com",
                PointOfContact = "",
                Position = "",
                Description = "Công Ty TNHH Odk Mikazuki Việt Na có mã số thuế 400510460. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Ô tô xe máy",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-179),
                UpdatedAt
             = DateTime.Now.AddDays(-179)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 27,
                Name = "Công ty Cổ phần BĐS Khải Hoàn Land",
                TaxCode = "309139261",
                ClientCode = "Khải Hoàn Land",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850347",
                Address = "R4- 93 Đường Hưng Gia 4, Khu đô thị Phú Mỹ Hưng",
                Career = "Bất động sản",
                Email = "Ms.Hai@gmail.com",
                PointOfContact = "Ms. Hải",
                Position = "CV MKT",
                Description = "Công ty Cổ phần BĐS Khải Hoàn Land có mã số thuế 309139261. Địa chỉ tại: R4- 93 Đường Hưng Gia 4, Khu đô thị Phú Mỹ Hưng Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bất động sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-178),
                UpdatedAt
             = DateTime.Now.AddDays(-178)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 28,
                Name = "Công ty Cổ phần Tập đoàn Hà Đô",
                TaxCode = "100283802",
                ClientCode = "Hà Đô",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850348",
                Address = "Số 8 Láng Hạ - Phường Thành Công - Quận Ba Đình",
                Career = "Bất động sản",
                Email = "Ms.Lua@gmail.com",
                PointOfContact = "Ms. Lụa",
                Position = "CV MKT",
                Description = "Công ty Cổ phần Tập đoàn Hà Đô có mã số thuế 100283802. Địa chỉ tại: Số 8 Láng Hạ - Phường Thành Công - Quận Ba Đình Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bất động sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-177),
                UpdatedAt
             = DateTime.Now.AddDays(-177)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 29,
                Name = "Công ty TNHH Panasonic Việt Nam",
                TaxCode = "101824243",
                ClientCode = "Panasonic",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850349",
                Address = "Charmvit Tower",
                Career = "Điện máy",
                Email = "Ms.Huyen@gmail.com",
                PointOfContact = "Ms. Huyền",
                Position = "GĐMKT",
                Description = "Công ty TNHH Panasonic Việt Nam có mã số thuế 101824243. Địa chỉ tại: Charmvit Tower Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Điện máy",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-176),
                UpdatedAt
             = DateTime.Now.AddDays(-176)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 30,
                Name = "CÔNG TY CỔ PHẦN ĐẦU TƯ TNG HOLDINGS VIỆT NAM",
                TaxCode = "106684712",
                ClientCode = "TNG Holdings",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850350",
                Address = "Tòa nhà TNR, số 54A, đường Nguyễn Chí Thanh",
                Career = "Bất động sản",
                Email = "Ms.Duyen@gmail.com",
                PointOfContact = "Ms. Duyên",
                Position = "TP MKT",
                Description = "CÔNG TY CỔ PHẦN ĐẦU TƯ TNG HOLDINGS VIỆT NAM có mã số thuế 106684712. Địa chỉ tại: Tòa nhà TNR, số 54A, đường Nguyễn Chí Thanh Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bất động sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-175),
                UpdatedAt
             = DateTime.Now.AddDays(-175)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 31,
                Name = "Công ty Cổ phần Đạt Phương",
                TaxCode = "101218757",
                ClientCode = "Đạt Phương",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850351",
                Address = "Hà Nội",
                Career = "Bất động sản",
                Email = "Ms.Trang@gmail.com",
                PointOfContact = "Ms. Trang",
                Position = "CV MKT",
                Description = "Công ty Cổ phần Đạt Phương có mã số thuế 101218757. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bất động sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-174),
                UpdatedAt
             = DateTime.Now.AddDays(-174)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 32,
                Name = "Công Ty Cổ Phần Vicostone",
                TaxCode = "500469512",
                ClientCode = "Vicostone",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850352",
                Address = "Hà Nội",
                Career = "Vật liệu xây dựng",
                Email = "Ms.Ha@gmail.com",
                PointOfContact = "Ms. Hà",
                Position = "Phó Phòng MKT",
                Description = "Công Ty Cổ Phần Vicostone có mã số thuế 500469512. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Vật liệu xây dựng",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-173),
                UpdatedAt
             = DateTime.Now.AddDays(-173)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 33,
                Name = "Công Ty TNHH Tập Đoàn Bim",
                TaxCode = "5701942544",
                ClientCode = "Bim Group",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850353",
                Address = "Hà Nội",
                Career = "Bất động sản",
                Email = "Ms.Giang@gmail.com",
                PointOfContact = "Ms. Giang",
                Position = "Giám đốc MKT",
                Description = "Công Ty TNHH Tập Đoàn Bim có mã số thuế 5701942544. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bất động sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-172),
                UpdatedAt
             = DateTime.Now.AddDays(-172)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 34,
                Name = "Công ty cổ phần tập đoàn Danko",
                TaxCode = "3702070613",
                ClientCode = "Danko Group",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850354",
                Address = "Hà Nội",
                Career = "Bất động sản",
                Email = "Ms.Sam@gmail.com",
                PointOfContact = "Ms. Sâm",
                Position = "Phó GĐ MKT",
                Description = "Công ty cổ phần tập đoàn Danko có mã số thuế 3702070613. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bất động sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-171),
                UpdatedAt
             = DateTime.Now.AddDays(-171)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 35,
                Name = "Công ty Cổ phần Địa ốc Châu Á Thái Bình Dương Group",
                TaxCode = "314878772",
                ClientCode = "Apec Corp",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850355",
                Address = "Hà Nội",
                Career = "Bất động sản",
                Email = "Mr.XuanAnh@gmail.com",
                PointOfContact = "Mr. Xuân Anh",
                Position = "Marketing",
                Description = "Công ty Cổ phần Địa ốc Châu Á Thái Bình Dương Group có mã số thuế 314878772. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bất động sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-170),
                UpdatedAt
             = DateTime.Now.AddDays(-170)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 36,
                Name = "Công ty Cổ phần Đầu tư và phát triển Bất động sản Peakhomes",
                TaxCode = "109471060",
                ClientCode = "Peakhomes",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850356",
                Address = "Hà Nội",
                Career = "Bất động sản",
                Email = "Mr.Vinh@gmail.com",
                PointOfContact = "Mr. Vinh",
                Position = "Marketing",
                Description = "Công ty Cổ phần Đầu tư và phát triển Bất động sản Peakhomes có mã số thuế 109471060. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bất động sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-169),
                UpdatedAt
             = DateTime.Now.AddDays(-169)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 37,
                Name = "Công Ty Cổ Phần Acecook Việt Nam",
                TaxCode = "300808687",
                ClientCode = "ACECOOK",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850357",
                Address = "Hà Nội",
                Career = "Ẩm thực",
                Email = "MsQuynh@gmail.com",
                PointOfContact = "Ms Quỳnh",
                Position = "Phó Phòng Media",
                Description = "Công Ty Cổ Phần Acecook Việt Nam có mã số thuế 300808687. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Ẩm thực",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-168),
                UpdatedAt
             = DateTime.Now.AddDays(-168)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 38,
                Name = "Chi Nhánh Công Ty TNHH Nhà Nước Một Thành Viên Thương Mại Và Xuất Nhập Khẩu Viettel (Viettel Store)",
                TaxCode = "0104831030-091",
                ClientCode = "Viettel Store",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850358",
                Address = "Hà Nội",
                Career = "Bán lẻ",
                Email = "Mr.Tung@gmail.com",
                PointOfContact = "Mr. Tùng",
                Position = "Trưởng phòng MKT",
                Description = "Chi Nhánh Công Ty TNHH Nhà Nước Một Thành Viên Thương Mại Và Xuất Nhập Khẩu Viettel (Viettel Store) có mã số thuế 0104831030-091. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bán lẻ",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-167),
                UpdatedAt
             = DateTime.Now.AddDays(-167)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 39,
                Name = "ACECOOK",
                TaxCode = "23525311377",
                ClientCode = "ACECOOK",
                ClientSource = "Công ty",
                PhoneNumber = "0989850359",
                Address = "Láng Hạ, Đống Đa, Hà Nội",
                Career = "Ẩm thực",
                Email = "NguyenAnhQuan@gmail.com",
                PointOfContact = "Nguyễn Anh Quân",
                Position = "Marketing",
                Description = "ACECOOK có mã số thuế 23525311377. Địa chỉ tại: Láng Hạ, Đống Đa, Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Ẩm thực",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-166),
                UpdatedAt
             = DateTime.Now.AddDays(-166)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 40,
                Name = "THE GOLDEN GATE",
                TaxCode = "11342353463",
                ClientCode = "THE GOLDEN GATE",
                ClientSource = "Hotline",
                PhoneNumber = "0989850360",
                Address = "Láng Hạ, Đống Đa, Hà Nội",
                Career = "Logistics",
                Email = "PhungThiQuyen@gmail.com",
                PointOfContact = "Phùng Thị Quyên",
                Position = "Marketing",
                Description = "THE GOLDEN GATE có mã số thuế 11342353463. Địa chỉ tại: Láng Hạ, Đống Đa, Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Logistics",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-165),
                UpdatedAt
             = DateTime.Now.AddDays(-165)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 41,
                Name = "THE COFFEE HOUSE",
                TaxCode = "23524645742",
                ClientCode = "THE COFFEE HOUSE",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850361",
                Address = "Hà Nội",
                Career = "Logistics",
                Email = "HuaThiHoai@gmail.com",
                PointOfContact = "Hứa Thị Hoài",
                Position = "Phó Phòng Media",
                Description = "THE COFFEE HOUSE có mã số thuế 23524645742. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Logistics",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-164),
                UpdatedAt
             = DateTime.Now.AddDays(-164)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 42,
                Name = "TAXI GROUP",
                TaxCode = "45465767222",
                ClientCode = "TAXI GROUP",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850362",
                Address = "Láng Hạ, Đống Đa, Hà Nội",
                Career = "Logistics",
                Email = "LaiPhuongAnh@gmail.com",
                PointOfContact = "Lại Phương Anh",
                Position = "Trưởng phòng MKT",
                Description = "TAXI GROUP có mã số thuế 45465767222. Địa chỉ tại: Láng Hạ, Đống Đa, Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Logistics",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-163),
                UpdatedAt
             = DateTime.Now.AddDays(-163)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 43,
                Name = "KH 014",
                TaxCode = "36634666211",
                ClientCode = "KH 014",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850363",
                Address = "Láng Hạ, Đống Đa, Hà Nội",
                Career = "Logistics",
                Email = "NguyenVanAnh@gmail.com",
                PointOfContact = "Nguyễn Vân Anh",
                Position = "Marketing",
                Description = "KH 014 có mã số thuế 36634666211. Địa chỉ tại: Láng Hạ, Đống Đa, Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Logistics",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-162),
                UpdatedAt
             = DateTime.Now.AddDays(-162)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 44,
                Name = "TÂN Á ĐẠI THÀNH",
                TaxCode = "12244774455",
                ClientCode = "TÂN Á ĐẠI THÀNH",
                ClientSource = "Hotline",
                PhoneNumber = "0989850364",
                Address = "Hà Nội",
                Career = "Logistics",
                Email = "BuiMinhAnh@gmail.com",
                PointOfContact = "Bùi Minh Anh",
                Position = "Marketing",
                Description = "TÂN Á ĐẠI THÀNH có mã số thuế 12244774455. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Logistics",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-161),
                UpdatedAt
             = DateTime.Now.AddDays(-161)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 45,
                Name = "HEINEKEN",
                TaxCode = "34351154546",
                ClientCode = "HEINEKEN",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850365",
                Address = "Láng Hạ, Đống Đa, Hà Nội",
                Career = "Logistics",
                Email = "KhongTienAnh@gmail.com",
                PointOfContact = "Khổng Tiến Anh",
                Position = "Phó Phòng Media",
                Description = "HEINEKEN có mã số thuế 34351154546. Địa chỉ tại: Láng Hạ, Đống Đa, Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Logistics",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-160),
                UpdatedAt
             = DateTime.Now.AddDays(-160)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 46,
                Name = "VIETNAM AIRLINES",
                TaxCode = "13423534666",
                ClientCode = "VIETNAM AIRLINES",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850366",
                Address = "Láng Hạ, Đống Đa, Hà Nội",
                Career = "Logistics",
                Email = "TranVietAnh@gmail.com",
                PointOfContact = "Trần Việt Anh",
                Position = "Trưởng phòng MKT",
                Description = "VIETNAM AIRLINES có mã số thuế 13423534666. Địa chỉ tại: Láng Hạ, Đống Đa, Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Logistics",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-159),
                UpdatedAt
             = DateTime.Now.AddDays(-159)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 47,
                Name = "K+",
                TaxCode = "12355758999",
                ClientCode = "K+",
                ClientSource = "Công ty",
                PhoneNumber = "0989850367",
                Address = "Hà Nội",
                Career = "Logistics",
                Email = "VuPhuongAnh@gmail.com",
                PointOfContact = "Vũ Phương Anh",
                Position = "Marketing",
                Description = "K+ có mã số thuế 12355758999. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Logistics",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-158),
                UpdatedAt
             = DateTime.Now.AddDays(-158)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 48,
                Name = "THẾ GIỚI DI ĐỘNG",
                TaxCode = "13543654888",
                ClientCode = "THẾ GIỚI DI ĐỘNG",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850368",
                Address = "Láng Hạ, Đống Đa, Hà Nội",
                Career = "Logistics",
                Email = "HaThiThu@gmail.com",
                PointOfContact = "Hà Thị Thu",
                Position = "Marketing",
                Description = "THẾ GIỚI DI ĐỘNG có mã số thuế 13543654888. Địa chỉ tại: Láng Hạ, Đống Đa, Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Logistics",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-157),
                UpdatedAt
             = DateTime.Now.AddDays(-157)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 49,
                Name = "M25",
                TaxCode = "1234578813",
                ClientCode = "M25",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850369",
                Address = "Láng Hạ, Đống Đa, Hà Nội",
                Career = "Ô tô xe máy",
                Email = "NguyenThiPhuongLinh@gmail.com",
                PointOfContact = "Nguyễn Thị Phương Linh",
                Position = "Phó Phòng Media",
                Description = "M25 có mã số thuế 1234578813. Địa chỉ tại: Láng Hạ, Đống Đa, Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Ô tô xe máy",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-156),
                UpdatedAt
             = DateTime.Now.AddDays(-156)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 50,
                Name = "KNOSS",
                TaxCode = "25341256888",
                ClientCode = "KNOSS",
                ClientSource = "Hotline",
                PhoneNumber = "0989850370",
                Address = "Hà Nội",
                Career = "Logistics",
                Email = "PhamTuanTu@gmail.com",
                PointOfContact = "Phạm Tuấn Tú",
                Position = "Marketing",
                Description = "KNOSS có mã số thuế 25341256888. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Logistics",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-155),
                UpdatedAt
             = DateTime.Now.AddDays(-155)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 51,
                Name = "IVYMODA",
                TaxCode = "23534557674",
                ClientCode = "IVYMODA",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850371",
                Address = "Láng Hạ, Đống Đa, Hà Nội",
                Career = "Logistics",
                Email = "LeThanhNga@gmail.com",
                PointOfContact = "Lê Thanh Nga",
                Position = "Marketing",
                Description = "IVYMODA có mã số thuế 23534557674. Địa chỉ tại: Láng Hạ, Đống Đa, Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Logistics",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-154),
                UpdatedAt
             = DateTime.Now.AddDays(-154)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 52,
                Name = "CẦU DẤT",
                TaxCode = "22256572254",
                ClientCode = "CẦU DẤT",
                ClientSource = "Hotline",
                PhoneNumber = "0989850372",
                Address = "Hà Nội",
                Career = "Ngân hàng",
                Email = "VuThuyNga@gmail.com",
                PointOfContact = "Vũ Thuý Nga",
                Position = "Phó Phòng Media",
                Description = "CẦU DẤT có mã số thuế 22256572254. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Ngân hàng",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-153),
                UpdatedAt
             = DateTime.Now.AddDays(-153)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 53,
                Name = "TIKI",
                TaxCode = "3457676754",
                ClientCode = "TIKI",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850373",
                Address = "Láng Hạ, Đống Đa, Hà Nội",
                Career = "Ngân hàng",
                Email = "MaiTuongLinh@gmail.com",
                PointOfContact = "Mai Tường Linh",
                Position = "Marketing",
                Description = "TIKI có mã số thuế 3457676754. Địa chỉ tại: Láng Hạ, Đống Đa, Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Ngân hàng",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-152),
                UpdatedAt
             = DateTime.Now.AddDays(-152)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 54,
                Name = "LAZADA",
                TaxCode = "58534563633",
                ClientCode = "LAZADA",
                ClientSource = "Công ty",
                PhoneNumber = "0989850374",
                Address = "Hà Nội",
                Career = "Ngân hàng",
                Email = "HoangTrungAnh@gmail.com",
                PointOfContact = "Hoàng Trung Anh",
                Position = "Trưởng phòng",
                Description = "LAZADA có mã số thuế 58534563633. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Ngân hàng",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-151),
                UpdatedAt
             = DateTime.Now.AddDays(-151)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 55,
                Name = "TOYOTA",
                TaxCode = "4574765685",
                ClientCode = "TOYOTA",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850375",
                Address = "Hà Nội",
                Career = "Ngân hàng",
                Email = "NguyenDangBang@gmail.com",
                PointOfContact = "Nguyễn Đăng Bằng",
                Position = "Trưởng phòng",
                Description = "TOYOTA có mã số thuế 4574765685. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Ngân hàng",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-150),
                UpdatedAt
             = DateTime.Now.AddDays(-150)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 56,
                Name = "HONDA",
                TaxCode = "3423453534",
                ClientCode = "HONDA",
                ClientSource = "Hotline",
                PhoneNumber = "0989850376",
                Address = "Láng Hạ, Đống Đa, Hà Nội",
                Career = "Ô tô xe máy",
                Email = "NguyenPhuongLinh@gmail.com",
                PointOfContact = "Nguyễn Phương Linh",
                Position = "Trưởng phòng",
                Description = "HONDA có mã số thuế 3423453534. Địa chỉ tại: Láng Hạ, Đống Đa, Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Ô tô xe máy",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-149),
                UpdatedAt
             = DateTime.Now.AddDays(-149)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 57,
                Name = "CÔNG TY CỔ PHẦN PHÁT TRIỂN NÔNG NGHIỆP GFS VIỆT NAM",
                TaxCode = "106654059",
                ClientCode = "106654059",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850377",
                Address = "Số 508 Đường Trường Chinh, Phường Ngã Tư Sở, Quận Đống Đa, Thành Phố Hà Nội, Việt Nam",
                Career = "Bất động sản",
                Email = "Ms.Ngan@gmail.com",
                PointOfContact = "Ms.Ngân",
                Position = "Trợ lý tổng giám đốc",
                Description = "CÔNG TY CỔ PHẦN PHÁT TRIỂN NÔNG NGHIỆP GFS VIỆT NAM có mã số thuế 106654059. Địa chỉ tại: Số 508 Đường Trường Chinh, Phường Ngã Tư Sở, Quận Đống Đa, Thành Phố Hà Nội, Việt Nam Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bất động sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-148),
                UpdatedAt
             = DateTime.Now.AddDays(-148)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 58,
                Name = "Công Ty Cổ Phần Tập Đoàn Thế Kỷ CEN GROUP .,JSC",
                TaxCode = "104556472",
                ClientCode = "104556472",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850378",
                Address = "16A Nguyễn Công Trứ",
                Career = "Bất động sản",
                Email = "Ms.Linh@gmail.com",
                PointOfContact = "Ms. Linh",
                Position = "GĐ Marketing",
                Description = "Công Ty Cổ Phần Tập Đoàn Thế Kỷ CEN GROUP .,JSC có mã số thuế 104556472. Địa chỉ tại: 16A Nguyễn Công Trứ Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bất động sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-147),
                UpdatedAt
             = DateTime.Now.AddDays(-147)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 59,
                Name = "LoLO La LA",
                TaxCode = "12344",
                ClientCode = "12344",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850379",
                Address = "Hà Nội",
                Career = "Ô tô xe máy",
                Email = "MrToan@gmail.com",
                PointOfContact = "Mr Toán",
                Position = "GD",
                Description = "LoLO La LA có mã số thuế 12344. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Ô tô xe máy",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-146),
                UpdatedAt
             = DateTime.Now.AddDays(-146)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 60,
                Name = "TẬP ĐOÀN ĐẦU TƯ BẤT ĐỘNG SẢN, GIÁO DỤC, KẾT NỐI ĐẦU TƯ QUỐC TẾ IDJ (IDJ GROUP)",
                TaxCode = "102186593",
                ClientCode = "102186593",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850380",
                Address = "Hà Nội",
                Career = "FMCG",
                Email = "MrToan@gmail.com",
                PointOfContact = "Mr Toàn",
                Position = "Phòng Mua",
                Description = "TẬP ĐOÀN ĐẦU TƯ BẤT ĐỘNG SẢN, GIÁO DỤC, KẾT NỐI ĐẦU TƯ QUỐC TẾ IDJ (IDJ GROUP) có mã số thuế 102186593. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: FMCG",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-145),
                UpdatedAt
             = DateTime.Now.AddDays(-145)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 61,
                Name = "CÔNG TY TNHH CÔNG NGHIỆP NẶNG DOOSAN VIỆT NAM",
                TaxCode = "4300345073",
                ClientCode = "4300345073",
                ClientSource = "Hotline",
                PhoneNumber = "0989850381",
                Address = "Hà Nội",
                Career = "FMCG",
                Email = "MrManh@gmail.com",
                PointOfContact = "Mr Mạnh",
                Position = "MKT",
                Description = "CÔNG TY TNHH CÔNG NGHIỆP NẶNG DOOSAN VIỆT NAM có mã số thuế 4300345073. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: FMCG",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-144),
                UpdatedAt
             = DateTime.Now.AddDays(-144)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 62,
                Name = "Công ty TNHH TM & DV Đông Hoa",
                TaxCode = "301923097",
                ClientCode = "Đông Hoa CO., LTD",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850382",
                Address = "24 Đất Thánh, P.6, Q. Tân Bình, TP.HCM",
                Career = "Ngân hàng",
                Email = "Ms.Hue@gmail.com",
                PointOfContact = "Ms. Huệ",
                Position = "Phụ trách Sale & MKT",
                Description = "Công ty TNHH TM & DV Đông Hoa có mã số thuế 301923097. Địa chỉ tại: 24 Đất Thánh, P.6, Q. Tân Bình, TP.HCM Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Ngân hàng",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-143),
                UpdatedAt
             = DateTime.Now.AddDays(-143)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 63,
                Name = "Công ty cổ phần Dubai Paint",
                TaxCode = "108611389",
                ClientCode = "Dubai Paint",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850383",
                Address = "86 Cù Chính Lan, Khương Mai, Thanh Xuân, Hà Nội",
                Career = "FMCG",
                Email = "MrCuong@gmail.com",
                PointOfContact = "Mr Cường",
                Position = "Phó GĐ",
                Description = "Công ty cổ phần Dubai Paint có mã số thuế 108611389. Địa chỉ tại: 86 Cù Chính Lan, Khương Mai, Thanh Xuân, Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: FMCG",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-142),
                UpdatedAt
             = DateTime.Now.AddDays(-142)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 64,
                Name = "Công ty cổ phần Tập đoàn Tiến Bộ",
                TaxCode = "4600359768",
                ClientCode = "Tienbogroup",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850384",
                Address = "Số 01 Đường Bắc Kạn - TP Thái Nguyên",
                Career = "FMCG",
                Email = "MsHang@gmail.com",
                PointOfContact = "Ms Hằng",
                Position = "Trưởng ban truyền thông",
                Description = "Công ty cổ phần Tập đoàn Tiến Bộ có mã số thuế 4600359768. Địa chỉ tại: Số 01 Đường Bắc Kạn - TP Thái Nguyên Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: FMCG",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-141),
                UpdatedAt
             = DateTime.Now.AddDays(-141)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 65,
                Name = "Công ty Cổ phần tư vấn đầu tư và kinh doanh bất động sản Thành Đạt",
                TaxCode = "1702180274",
                ClientCode = "Meyland",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850385",
                Address = "124 Tôn Đức Thắng",
                Career = "FMCG",
                Email = "Ms.My@gmail.com",
                PointOfContact = "Ms. My",
                Position = "Phòng mua",
                Description = "Công ty Cổ phần tư vấn đầu tư và kinh doanh bất động sản Thành Đạt có mã số thuế 1702180274. Địa chỉ tại: 124 Tôn Đức Thắng Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: FMCG",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-140),
                UpdatedAt
             = DateTime.Now.AddDays(-140)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 66,
                Name = "Công ty TNHH Tribeco Miền Bắc",
                TaxCode = "900269243",
                ClientCode = "NTRI",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850386",
                Address = "Km 22, Thị trấn Bần Yên Nhân, Huyện Mỹ Hào, Tỉnh Hưng Yên",
                Career = "FMCG",
                Email = "MsThuong@gmail.com",
                PointOfContact = "Ms Thương",
                Position = "Phòng mua",
                Description = "Công ty TNHH Tribeco Miền Bắc có mã số thuế 900269243. Địa chỉ tại: Km 22, Thị trấn Bần Yên Nhân, Huyện Mỹ Hào, Tỉnh Hưng Yên Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: FMCG",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-139),
                UpdatedAt
             = DateTime.Now.AddDays(-139)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 67,
                Name = "Tổng Công ty Cổ phần Bảo hiểm Ngân hàng TMCP Công Thương Việt Nam (Bảo hiểm VietinBank - VBI)",
                TaxCode = "101335193",
                ClientCode = "101335193",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850387",
                Address = "126 Đội Cấn, Ba Đình, Hà Nội",
                Career = "FMCG",
                Email = "Ms.Mai@gmail.com",
                PointOfContact = "Ms. Mai",
                Position = "Chuyên viên Marketing",
                Description = "Tổng Công ty Cổ phần Bảo hiểm Ngân hàng TMCP Công Thương Việt Nam (Bảo hiểm VietinBank - VBI) có mã số thuế 101335193. Địa chỉ tại: 126 Đội Cấn, Ba Đình, Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: FMCG",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-138),
                UpdatedAt
             = DateTime.Now.AddDays(-138)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 68,
                Name = "Công ty cổ phần TRUYỀN THÔNG & SỰ KIỆN Hoa Hồng",
                TaxCode = "2901591496",
                ClientCode = "2901591496",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850388",
                Address = "307 Bắc Cầu, Ngọc Thụy, Long Biên, Hà Nội",
                Career = "Bất động sản",
                Email = "Mr.LeTuanAnh@gmail.com",
                PointOfContact = "Mr. Lê Tuấn Anh",
                Position = "Giám đốc Mỹ Thuật",
                Description = "Công ty cổ phần TRUYỀN THÔNG & SỰ KIỆN Hoa Hồng có mã số thuế 2901591496. Địa chỉ tại: 307 Bắc Cầu, Ngọc Thụy, Long Biên, Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bất động sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-137),
                UpdatedAt
             = DateTime.Now.AddDays(-137)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 69,
                Name = "CÔNG TY CỔ PHẦN MEDIAMART VIỆT NAM",
                TaxCode = "102516308",
                ClientCode = "102516308",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850389",
                Address = "Số 29F Hai Bà Trưng, Phường Tràng Tiền, Quận Hoàn Kiếm, Thành phố Hà Nội, Việt Nam",
                Career = "Y tế",
                Email = "Mr.Tung@gmail.com",
                PointOfContact = "Mr.Tùng",
                Position = "TP Marketing",
                Description = "CÔNG TY CỔ PHẦN MEDIAMART VIỆT NAM có mã số thuế 102516308. Địa chỉ tại: Số 29F Hai Bà Trưng, Phường Tràng Tiền, Quận Hoàn Kiếm, Thành phố Hà Nội, Việt Nam Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Y tế",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-136),
                UpdatedAt
             = DateTime.Now.AddDays(-136)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 70,
                Name = "CÔNG TY TNHH CUCKOO VINA",
                TaxCode = "108515678",
                ClientCode = "108515678",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850390",
                Address = "Tầng 15 Tháp C, Tòa nhà Central Point, 219 phố Trung Kính, Phường Yên Hoà, Quận Cầu Giấy, Thành phố Hà Nội, Việt Nam",
                Career = "VLXD",
                Email = "Mr.Hung@gmail.com",
                PointOfContact = "Mr.Hưng",
                Position = "Trưởng phòng phát triển thị trường",
                Description = "CÔNG TY TNHH CUCKOO VINA có mã số thuế 108515678. Địa chỉ tại: Tầng 15 Tháp C, Tòa nhà Central Point, 219 phố Trung Kính, Phường Yên Hoà, Quận Cầu Giấy, Thành phố Hà Nội, Việt Nam Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: VLXD",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-135),
                UpdatedAt
             = DateTime.Now.AddDays(-135)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 71,
                Name = "CÔNG TY CỔ PHẦN VIỆT NAM CATERING",
                TaxCode = "312635407",
                ClientCode = "312635407",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850391",
                Address = "Hà Nội",
                Career = "VLXD",
                Email = "NguyenHoangNam@gmail.com",
                PointOfContact = "Nguyễn Hoàng Nam",
                Position = "Tổng giám đốc",
                Description = "CÔNG TY CỔ PHẦN VIỆT NAM CATERING có mã số thuế 312635407. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: VLXD",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-134),
                UpdatedAt
             = DateTime.Now.AddDays(-134)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 72,
                Name = "CÔNG TY CỔ PHẦN TẬP ĐOÀN G",
                TaxCode = "107285693",
                ClientCode = "107285693",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850392",
                Address = "Phòng 207-01, tầng M, toà nhà N01A - Golden Land, số 275 Nguyễn Trãi, Phường Thanh Xuân Trung, Quận Thanh Xuân, Thành phố Hà Nội",
                Career = "Bât Động Sản",
                Email = "Mr.Tien@gmail.com",
                PointOfContact = "Mr. Tiến",
                Position = "Trưởng phòng",
                Description = "CÔNG TY CỔ PHẦN TẬP ĐOÀN G có mã số thuế 107285693. Địa chỉ tại: Phòng 207-01, tầng M, toà nhà N01A - Golden Land, số 275 Nguyễn Trãi, Phường Thanh Xuân Trung, Quận Thanh Xuân, Thành phố Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bât Động Sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-133),
                UpdatedAt
             = DateTime.Now.AddDays(-133)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 73,
                Name = "CÔNG TY CỔ PHẦN VIỆT NAM CATERING",
                TaxCode = "312635407",
                ClientCode = "312635407",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850393",
                Address = "Hà Nội",
                Career = "Bán lẻ",
                Email = "NguyenHoangNam@gmail.com",
                PointOfContact = "Nguyễn Hoàng Nam",
                Position = "Tổng Giám đốc",
                Description = "CÔNG TY CỔ PHẦN VIỆT NAM CATERING có mã số thuế 312635407. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bán lẻ",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-132),
                UpdatedAt
             = DateTime.Now.AddDays(-132)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 74,
                Name = "CÔNG TY CỔ PHẦN TẬP ĐOÀN G",
                TaxCode = "107285693",
                ClientCode = "107285693",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850394",
                Address = "Phòng 207-01, tầng M, toà nhà N01A - Golden Land, số 275 Nguyễn Trãi, Phường Thanh Xuân Trung, Quận Thanh Xuân, Thành phố Hà Nội",
                Career = "Bất Động sản",
                Email = "Mr.Tien@gmail.com",
                PointOfContact = "Mr. Tiến",
                Position = "Trưởng phòng",
                Description = "CÔNG TY CỔ PHẦN TẬP ĐOÀN G có mã số thuế 107285693. Địa chỉ tại: Phòng 207-01, tầng M, toà nhà N01A - Golden Land, số 275 Nguyễn Trãi, Phường Thanh Xuân Trung, Quận Thanh Xuân, Thành phố Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bất Động sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-131),
                UpdatedAt
             = DateTime.Now.AddDays(-131)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 75,
                Name = "CÔNG TY CỔ PHẦN TƯ VẤN ĐẦU TƯ THẮNG LỢI GROUP",
                TaxCode = "314680765",
                ClientCode = "314680765",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850395",
                Address = "Hà Nội",
                Career = "Bất động sản",
                Email = "LeVanTuan@gmail.com",
                PointOfContact = "Lê Văn Tuấn",
                Position = "Giám đốc",
                Description = "CÔNG TY CỔ PHẦN TƯ VẤN ĐẦU TƯ THẮNG LỢI GROUP có mã số thuế 314680765. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bất động sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-130),
                UpdatedAt
             = DateTime.Now.AddDays(-130)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 76,
                Name = "CÔNG TY CỔ PHẦN DỆT LỤA NAM ĐỊNH",
                TaxCode = "600016097",
                ClientCode = "600016097",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850396",
                Address = "Số 4 Hà Huy Tập, Phường Trần Hưng Đạo, Thành phố Nam Định, Tỉnh Nam Định, Việt Nam",
                Career = "Bất Động Sản",
                Email = "Mr.VietAnh@gmail.com",
                PointOfContact = "Mr. Việt Anh",
                Position = "MKT",
                Description = "CÔNG TY CỔ PHẦN DỆT LỤA NAM ĐỊNH có mã số thuế 600016097. Địa chỉ tại: Số 4 Hà Huy Tập, Phường Trần Hưng Đạo, Thành phố Nam Định, Tỉnh Nam Định, Việt Nam Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bất Động Sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-129),
                UpdatedAt
             = DateTime.Now.AddDays(-129)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 77,
                Name = "CÔNG TY CỔ PHẦN MOBICAST",
                TaxCode = "107591436",
                ClientCode = "mobicast",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850397",
                Address = "V1 toà Home city - 177 Trung Kính, Yên Hoà, Cầu Giấy, Hà Nội",
                Career = "Bất động sản",
                Email = "MsQuy@gmail.com",
                PointOfContact = "Ms Quý",
                Position = "Branding Manager",
                Description = "CÔNG TY CỔ PHẦN MOBICAST có mã số thuế 107591436. Địa chỉ tại: V1 toà Home city - 177 Trung Kính, Yên Hoà, Cầu Giấy, Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bất động sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-128),
                UpdatedAt
             = DateTime.Now.AddDays(-128)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 78,
                Name = "CÔNG TY CỔ PHẦN VEGA VIỆT NAM",
                TaxCode = "107605696",
                ClientCode = "Vegajsc",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850398",
                Address = "Hà Nội",
                Career = "Bất Động Sản",
                Email = "MrNhan@gmail.com",
                PointOfContact = "Mr Nhàn",
                Position = "Giám đốc",
                Description = "CÔNG TY CỔ PHẦN VEGA VIỆT NAM có mã số thuế 107605696. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bất Động Sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-127),
                UpdatedAt
             = DateTime.Now.AddDays(-127)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 79,
                Name = "Công ty cổ phần vinhomes",
                TaxCode = "102671977",
                ClientCode = "102671977",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850399",
                Address = "",
                Career = "Bán Lẻ",
                Email = "Ms.Thao@gmail.com",
                PointOfContact = "Ms. Thảo",
                Position = "Phòng mua",
                Description = "Công ty cổ phần vinhomes có mã số thuế 102671977. Địa chỉ tại:  Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bán Lẻ",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-126),
                UpdatedAt
             = DateTime.Now.AddDays(-126)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 80,
                Name = "Công Ty Cổ Phần Phân Bón Bình Điền",
                TaxCode = "302975517",
                ClientCode = "302975517",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850400",
                Address = "C12/21 Tân Kiên, huyện Bình Chánh, thành phố Hồ Chí Minh",
                Career = "công nghệ",
                Email = "Mr.Tam@gmail.com",
                PointOfContact = "Mr. Tâm",
                Position = "Tổng Giám Đốc",
                Description = "Công Ty Cổ Phần Phân Bón Bình Điền có mã số thuế 302975517. Địa chỉ tại: C12/21 Tân Kiên, huyện Bình Chánh, thành phố Hồ Chí Minh Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: công nghệ",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-125),
                UpdatedAt
             = DateTime.Now.AddDays(-125)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 81,
                Name = "Công Ty Cổ Phần Y Dược Phẩm Vimedimex",
                TaxCode = "300479760",
                ClientCode = "300479760",
                ClientSource = "Hotline",
                PhoneNumber = "0989850401",
                Address = "46 Bà Triệu - Hoàn Kiếm - Hà Nội",
                Career = "Ô tô xe máy",
                Email = "Mr.Hieu@gmail.com",
                PointOfContact = "Mr. Hiếu",
                Position = "CV MKT",
                Description = "Công Ty Cổ Phần Y Dược Phẩm Vimedimex có mã số thuế 300479760. Địa chỉ tại: 46 Bà Triệu - Hoàn Kiếm - Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Ô tô xe máy",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-124),
                UpdatedAt
             = DateTime.Now.AddDays(-124)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 82,
                Name = "Công ty TNHH Asia Media partners Việt Nam",
                TaxCode = "313157827",
                ClientCode = "313157827",
                ClientSource = "Công ty",
                PhoneNumber = "0989850402",
                Address = "Hà Nội",
                Career = "Bất động sản",
                Email = "Mr.Thanh@gmail.com",
                PointOfContact = "Mr. Thành",
                Position = "Giám đốc",
                Description = "Công ty TNHH Asia Media partners Việt Nam có mã số thuế 313157827. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bất động sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-123),
                UpdatedAt
             = DateTime.Now.AddDays(-123)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 83,
                Name = "ông ty Cổ phần Đầu tư và Phát triển hạ tầng PPC An Thịnh Việt Nam",
                TaxCode = "108239354",
                ClientCode = "108239354",
                ClientSource = "Công ty",
                PhoneNumber = "0989850403",
                Address = "Hà Nội",
                Career = "Bất động sản",
                Email = "Ms.Duyen@gmail.com",
                PointOfContact = "Ms. Duyên",
                Position = "MKT manager",
                Description = "ông ty Cổ phần Đầu tư và Phát triển hạ tầng PPC An Thịnh Việt Nam có mã số thuế 108239354. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bất động sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-122),
                UpdatedAt
             = DateTime.Now.AddDays(-122)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 84,
                Name = "Công Ty CP Thực Phẩm Xuất Khẩu Đồng Giao",
                TaxCode = "2700224457",
                ClientCode = "2700224457",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850404",
                Address = "Hà Nội",
                Career = "Bất động sản",
                Email = "Mr.Nghia@gmail.com",
                PointOfContact = "Mr. Nghĩa",
                Position = "Phó tổng giám đốc",
                Description = "Công Ty CP Thực Phẩm Xuất Khẩu Đồng Giao có mã số thuế 2700224457. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bất động sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-121),
                UpdatedAt
             = DateTime.Now.AddDays(-121)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 85,
                Name = "CÔNG TY CỔ PHẦN HERBIO",
                TaxCode = "316152626",
                ClientCode = "HERBIO",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850405",
                Address = "257 Tân Sơn Nhì, P. Tân Sơn Nhì, Q. Tân Phú, TP. Hồ Chí Minh",
                Career = "Dược",
                Email = "Mr.Vu@gmail.com",
                PointOfContact = "Mr. Vũ",
                Position = "Head of Marketing",
                Description = "CÔNG TY CỔ PHẦN HERBIO có mã số thuế 316152626. Địa chỉ tại: 257 Tân Sơn Nhì, P. Tân Sơn Nhì, Q. Tân Phú, TP. Hồ Chí Minh Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Dược",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-120),
                UpdatedAt
             = DateTime.Now.AddDays(-120)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 86,
                Name = "Công ty cổ phần Mutosi",
                TaxCode = "108468756",
                ClientCode = "108468756",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850406",
                Address = "số 25, Lô TT8 khu đấu giá Tứ Hiệp, Ngũ Hiệp, Thanh Trì, Hà Nội",
                Career = "gia dụng",
                Email = "Mr.Dung@gmail.com",
                PointOfContact = "Mr. Dũng",
                Position = "Tổng giám đốc",
                Description = "Công ty cổ phần Mutosi có mã số thuế 108468756. Địa chỉ tại: số 25, Lô TT8 khu đấu giá Tứ Hiệp, Ngũ Hiệp, Thanh Trì, Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: gia dụng",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-119),
                UpdatedAt
             = DateTime.Now.AddDays(-119)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 87,
                Name = "CÔNG TY CỔ PHẦN GONSA",
                TaxCode = "309829522",
                ClientCode = "GONSA",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850407",
                Address = "88 Đường Phạm Thị Tánh, Phường 4, Quận 8, Thành phố Hồ Chí Minh Read more: http://masocongty.vn/company/567386/cong-ty-co-phan-gonsa.html#ixzz6lUNJxf5J",
                Career = "DƯỢC",
                Email = "Mr.Dong@gmail.com",
                PointOfContact = "Mr. Đồng",
                Position = "Brand Manager",
                Description = "CÔNG TY CỔ PHẦN GONSA có mã số thuế 309829522. Địa chỉ tại: 88 Đường Phạm Thị Tánh, Phường 4, Quận 8, Thành phố Hồ Chí Minh Read more: http://masocongty.vn/company/567386/cong-ty-co-phan-gonsa.html#ixzz6lUNJxf5J Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: DƯỢC",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-118),
                UpdatedAt
             = DateTime.Now.AddDays(-118)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 88,
                Name = "DIC",
                TaxCode = "312162623",
                ClientCode = "DIC",
                ClientSource = "Công ty",
                PhoneNumber = "0989850408",
                Address = "265 Lê Hồng Phong, Phường 8, Tp. Vũng Tàu",
                Career = "Bất Động Sản",
                Email = "MrNhu@gmail.com",
                PointOfContact = "Mr Nhu",
                Position = "Phụ trách OOH",
                Description = "DIC có mã số thuế 312162623. Địa chỉ tại: 265 Lê Hồng Phong, Phường 8, Tp. Vũng Tàu Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bất Động Sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-117),
                UpdatedAt
             = DateTime.Now.AddDays(-117)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 89,
                Name = "Đất Việt Vac",
                TaxCode = "305749499",
                ClientCode = "Dat Viet",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850409",
                Address = "222 Pasteur, Phường 6, Quận 3, Thành phố Hồ Chí Minh",
                Career = "Agency",
                Email = "Mr.Hao@gmail.com",
                PointOfContact = "Mr. Hào",
                Position = "Planning Manager",
                Description = "Đất Việt Vac có mã số thuế 305749499. Địa chỉ tại: 222 Pasteur, Phường 6, Quận 3, Thành phố Hồ Chí Minh Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Agency",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-116),
                UpdatedAt
             = DateTime.Now.AddDays(-116)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 90,
                Name = "TEST 04",
                TaxCode = "40404",
                ClientCode = "TEST 04",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850410",
                Address = "Hà Nội",
                Career = "Giáo dục",
                Email = "TrinhVanC@gmail.com",
                PointOfContact = "Trịnh Văn C",
                Position = "Giám đốc",
                Description = "TEST 04 có mã số thuế 40404. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Giáo dục",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-115),
                UpdatedAt
             = DateTime.Now.AddDays(-115)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 91,
                Name = "TEST 03",
                TaxCode = "30303",
                ClientCode = "TEST 03",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850411",
                Address = "Hà Nội",
                Career = "Logistics",
                Email = "HoangQuocB@gmail.com",
                PointOfContact = "Hoàng Quốc B",
                Position = "Giám đốc",
                Description = "TEST 03 có mã số thuế 30303. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Logistics",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-114),
                UpdatedAt
             = DateTime.Now.AddDays(-114)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 92,
                Name = "TEST 02",
                TaxCode = "20202",
                ClientCode = "TEST 02",
                ClientSource = "Hotline",
                PhoneNumber = "0989850412",
                Address = "Hà Nội",
                Career = "Ẩm thực",
                Email = "NguyenThiA@gmail.com",
                PointOfContact = "Nguyễn Thị A",
                Position = "Giám đốc",
                Description = "TEST 02 có mã số thuế 20202. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Ẩm thực",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-113),
                UpdatedAt
             = DateTime.Now.AddDays(-113)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 93,
                Name = "IVY MODA",
                TaxCode = "10101",
                ClientCode = "IVY MODA",
                ClientSource = "Công ty",
                PhoneNumber = "0989850413",
                Address = "91 NCT",
                Career = "Thời trang",
                Email = "NguyenDieuLinh@gmail.com",
                PointOfContact = "Nguyễn Diệu Linh",
                Position = "Giám đốc",
                Description = "IVY MODA có mã số thuế 10101. Địa chỉ tại: 91 NCT Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Thời trang",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-112),
                UpdatedAt
             = DateTime.Now.AddDays(-112)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 94,
                Name = "Công Ty Cổ Phần Tây Bắc - Bqp",
                TaxCode = "801036223",
                ClientCode = "Sơn Kantech",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850414",
                Address = "Hà Nội",
                Career = "Sơn",
                Email = "MsLinh@gmail.com",
                PointOfContact = "Ms Linh",
                Position = "GĐ Marketing",
                Description = "Công Ty Cổ Phần Tây Bắc - Bqp có mã số thuế 801036223. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Sơn",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-111),
                UpdatedAt
             = DateTime.Now.AddDays(-111)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 95,
                Name = "Công ty TNHH Truyền thông Note Việt Nam",
                TaxCode = "2900600860",
                ClientCode = "Agency",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850415",
                Address = "Hà Nội",
                Career = "Agency",
                Email = "MsHuong@gmail.com",
                PointOfContact = "Ms Hương",
                Position = "Planner",
                Description = "Công ty TNHH Truyền thông Note Việt Nam có mã số thuế 2900600860. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Agency",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-110),
                UpdatedAt
             = DateTime.Now.AddDays(-110)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 96,
                Name = "Công Ty Cổ Phần Tập Đoàn Địa Ốc Cát Tường",
                TaxCode = "1101389698",
                ClientCode = "Cát Tường Group",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850416",
                Address = "789 Ấp mới 1, Mỹ Hạnh Na, Đức Hòa Long An",
                Career = "BDS",
                Email = "Ms.PhucAnh@gmail.com",
                PointOfContact = "Ms. Phúc Anh",
                Position = "Trợ lý khối GĐMKT",
                Description = "Công Ty Cổ Phần Tập Đoàn Địa Ốc Cát Tường có mã số thuế 1101389698. Địa chỉ tại: 789 Ấp mới 1, Mỹ Hạnh Na, Đức Hòa Long An Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: BDS",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-109),
                UpdatedAt
             = DateTime.Now.AddDays(-109)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 97,
                Name = "Công ty cổ phần dược phẩm Nam Hà",
                TaxCode = "600206147",
                ClientCode = "Dược Nam Hà",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850417",
                Address = "423 Vũ Tông Phan, Hà Nội",
                Career = "Dược phẩm",
                Email = "Mr.Thuan@gmail.com",
                PointOfContact = "Mr. Thuận",
                Position = "GD MKT",
                Description = "Công ty cổ phần dược phẩm Nam Hà có mã số thuế 600206147. Địa chỉ tại: 423 Vũ Tông Phan, Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Dược phẩm",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-108),
                UpdatedAt
             = DateTime.Now.AddDays(-108)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 98,
                Name = "Công Ty Cổ Phần Địa Ốc Kim Tinh",
                TaxCode = "316058158",
                ClientCode = "Kim Tinh Group",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850418",
                Address = "108-110 Nguyễn Văn Trỗi, Phú Nhuận, HCM",
                Career = "BDS",
                Email = "Mr.Vy@gmail.com",
                PointOfContact = "Mr. Vỹ",
                Position = "Phụ trách MKT + OOH",
                Description = "Công Ty Cổ Phần Địa Ốc Kim Tinh có mã số thuế 316058158. Địa chỉ tại: 108-110 Nguyễn Văn Trỗi, Phú Nhuận, HCM Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: BDS",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-107),
                UpdatedAt
             = DateTime.Now.AddDays(-107)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 99,
                Name = "Công Ty Cổ Phần Ô Tô Bắc Âu",
                TaxCode = "313532348",
                ClientCode = "Bắc Âu Auto",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850419",
                Address = "340 Nguyễn Văn Linh, Quận 7, HCM",
                Career = "Ô tô xe máy",
                Email = "Mr.Thanh@gmail.com",
                PointOfContact = "Mr. Thành",
                Position = "Phó phòng MKT",
                Description = "Công Ty Cổ Phần Ô Tô Bắc Âu có mã số thuế 313532348. Địa chỉ tại: 340 Nguyễn Văn Linh, Quận 7, HCM Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Ô tô xe máy",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-106),
                UpdatedAt
             = DateTime.Now.AddDays(-106)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 100,
                Name = "Công Ty Cổ Phần Greenpan",
                TaxCode = "314809049",
                ClientCode = "VLXD / Greenpan",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850420",
                Address = "Hà Nội",
                Career = "vách ngăn",
                Email = "MsHien@gmail.com",
                PointOfContact = "Ms Hiền",
                Position = "Chuyên viên MKT",
                Description = "Công Ty Cổ Phần Greenpan có mã số thuế 314809049. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: vách ngăn",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-105),
                UpdatedAt
             = DateTime.Now.AddDays(-105)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 101,
                Name = "Công Ty Cổ Phần Đầu Tư Kỹ Thuật Berjaya Gia Thịnh (Vietlott)",
                TaxCode = "311715794",
                ClientCode = "BGT",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850421",
                Address = "Tầng 17, Tòa Nhà Lim 2, Số 62A Cách Mạng Tháng Tám, Phường 06, Quận 3, TP Hồ Chí Minh",
                Career = "Giải trí",
                Email = "Ms.HaoAnh@gmail.com",
                PointOfContact = "Ms. Hạo Anh",
                Position = "Trưởng phòng MKT",
                Description = "Công Ty Cổ Phần Đầu Tư Kỹ Thuật Berjaya Gia Thịnh (Vietlott) có mã số thuế 311715794. Địa chỉ tại: Tầng 17, Tòa Nhà Lim 2, Số 62A Cách Mạng Tháng Tám, Phường 06, Quận 3, TP Hồ Chí Minh Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Giải trí",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-104),
                UpdatedAt
             = DateTime.Now.AddDays(-104)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 102,
                Name = "Công ty Cổ phần xuất nhập khẩu và xây dựng Tân Trường Sơn",
                TaxCode = "101131390",
                ClientCode = "VLXD / Bossdoor",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850422",
                Address = "Hà Nội",
                Career = "nhôm định hình",
                Email = "MrSon@gmail.com",
                PointOfContact = "Mr Sơn",
                Position = "Phó tổng giám đốc",
                Description = "Công ty Cổ phần xuất nhập khẩu và xây dựng Tân Trường Sơn có mã số thuế 101131390. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: nhôm định hình",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-103),
                UpdatedAt
             = DateTime.Now.AddDays(-103)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 103,
                Name = "Công ty cổ phần nhựa Duy Tân",
                TaxCode = "306151768",
                ClientCode = "Nhựa Duy Tân",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850423",
                Address = "298 Hồ Học Lãm, Phường An Lạc, Quận Bình Tân, TP. HCM",
                Career = "VLXD",
                Email = "Mr.LeAnh@gmail.com",
                PointOfContact = "Mr. Lê Anh",
                Position = "Phó Tổng GĐ",
                Description = "Công ty cổ phần nhựa Duy Tân có mã số thuế 306151768. Địa chỉ tại: 298 Hồ Học Lãm, Phường An Lạc, Quận Bình Tân, TP. HCM Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: VLXD",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-102),
                UpdatedAt
             = DateTime.Now.AddDays(-102)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 104,
                Name = "Công ty cổ phần BASE ENTERPRISE",
                TaxCode = "107526719",
                ClientCode = "Base.vn",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850424",
                Address = "Tầng 3, Tòa Autumn, Gold Season, số 47 Nguyễn Tuân, Thanh Xuân, Hà Nội",
                Career = "Phần mềm",
                Email = "Mr.Vuong@gmail.com",
                PointOfContact = "Mr. Vương",
                Position = "GĐ MKT",
                Description = "Công ty cổ phần BASE ENTERPRISE có mã số thuế 107526719. Địa chỉ tại: Tầng 3, Tòa Autumn, Gold Season, số 47 Nguyễn Tuân, Thanh Xuân, Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Phần mềm",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-101),
                UpdatedAt
             = DateTime.Now.AddDays(-101)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 105,
                Name = "Công ty cổ phần Zion",
                TaxCode = "101659783",
                ClientCode = "Zalo Pay",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850425",
                Address = "1F – VNG Campus, Z06, Street No 13, Tan Thuan Export Processing Zone, Tan Thuan Dong Ward, Dist.7, HCMC, Vietnam",
                Career = "Thanh toán điện tử",
                Email = "Ms.Hang@gmail.com",
                PointOfContact = "Ms. Hằng",
                Position = "CV MKT",
                Description = "Công ty cổ phần Zion có mã số thuế 101659783. Địa chỉ tại: 1F – VNG Campus, Z06, Street No 13, Tan Thuan Export Processing Zone, Tan Thuan Dong Ward, Dist.7, HCMC, Vietnam Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Thanh toán điện tử",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-100),
                UpdatedAt
             = DateTime.Now.AddDays(-100)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 106,
                Name = "Công ty cổ phần thẩm mỹ Xuân Hương",
                TaxCode = "104765243",
                ClientCode = "TMV",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850426",
                Address = "Hà Nội",
                Career = "Thẩm mỹ",
                Email = "MrNhung@gmail.com",
                PointOfContact = "Mr Nhung",
                Position = "Marketing Manager",
                Description = "Công ty cổ phần thẩm mỹ Xuân Hương có mã số thuế 104765243. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Thẩm mỹ",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-99),
                UpdatedAt
             = DateTime.Now.AddDays(-99)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 107,
                Name = "Cty TNHH Dầu nhờn Chevron",
                TaxCode = "200115417",
                ClientCode = "Dầu",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850427",
                Address = "Hà Nội",
                Career = "Dầu nhớt",
                Email = "Ms.Hien@gmail.com",
                PointOfContact = "Ms. Hiền",
                Position = "Marketing Manager",
                Description = "Cty TNHH Dầu nhờn Chevron có mã số thuế 200115417. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Dầu nhớt",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-98),
                UpdatedAt
             = DateTime.Now.AddDays(-98)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 108,
                Name = "Công ty Cổ Phần Tập Đoàn Flamingo",
                TaxCode = "101117565",
                ClientCode = "101117565",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850428",
                Address = "Hà Nội",
                Career = "Bất động sản",
                Email = "MsNguyet@gmail.com",
                PointOfContact = "Ms Nguyệt",
                Position = "Marketing Manager",
                Description = "Công ty Cổ Phần Tập Đoàn Flamingo có mã số thuế 101117565. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bất động sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-97),
                UpdatedAt
             = DateTime.Now.AddDays(-97)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 109,
                Name = "Công Ty Cổ Phần Thanh Toán G",
                TaxCode = "108176464",
                ClientCode = "108176464",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850429",
                Address = "Hà Nội",
                Career = "Fintech",
                Email = "MrLuan@gmail.com",
                PointOfContact = "Mr Luân",
                Position = "Marketing Leader",
                Description = "Công Ty Cổ Phần Thanh Toán G có mã số thuế 108176464. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Fintech",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-96),
                UpdatedAt
             = DateTime.Now.AddDays(-96)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 110,
                Name = "Công ty TNHH dầu nhờn IDEMITSU Việt Nam",
                TaxCode = "201275452",
                ClientCode = "201275452",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850430",
                Address = "Hà Nội",
                Career = "Dầu nhớt",
                Email = "MsHa@gmail.com",
                PointOfContact = "Ms Hà",
                Position = "Marketing Manager",
                Description = "Công ty TNHH dầu nhờn IDEMITSU Việt Nam có mã số thuế 201275452. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Dầu nhớt",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-95),
                UpdatedAt
             = DateTime.Now.AddDays(-95)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 111,
                Name = "Công ty cổ phần thương mại Nam Á (SACOM JSC)",
                TaxCode = "200675433",
                ClientCode = "SACOM JSC",
                ClientSource = "Hotline",
                PhoneNumber = "0989850431",
                Address = "Số nhà 9A, ngách 269/1, ngõ 269 Giáp Bát, P. Giáp Bát, Q. Hoàng Mai, Hà Nội.",
                Career = "Logistics",
                Email = "Mr.Mien@gmail.com",
                PointOfContact = "Mr. Miên",
                Position = "TGĐ",
                Description = "Công ty cổ phần thương mại Nam Á (SACOM JSC) có mã số thuế 200675433. Địa chỉ tại: Số nhà 9A, ngách 269/1, ngõ 269 Giáp Bát, P. Giáp Bát, Q. Hoàng Mai, Hà Nội. Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Logistics",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-94),
                UpdatedAt
             = DateTime.Now.AddDays(-94)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 112,
                Name = "Công ty Cổ phần Tập đoàn Sơn Kova",
                TaxCode = "302960687",
                ClientCode = "Sơn Kova",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850432",
                Address = "92G - 92H Nguyễn Hữu Cảnh, Quận Bình Thạnh, TP. HCM",
                Career = "Vật liệu xây dựng",
                Email = "Ms.Thy@gmail.com",
                PointOfContact = "Ms. Thy",
                Position = "CV MKT",
                Description = "Công ty Cổ phần Tập đoàn Sơn Kova có mã số thuế 302960687. Địa chỉ tại: 92G - 92H Nguyễn Hữu Cảnh, Quận Bình Thạnh, TP. HCM Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Vật liệu xây dựng",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-93),
                UpdatedAt
             = DateTime.Now.AddDays(-93)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 113,
                Name = "Tổng công ty Dịch vụ số Viettel",
                TaxCode = "0100109106-478",
                ClientCode = "0100109106-478",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850433",
                Address = "1 Giang Văn Minh",
                Career = "Điện tử",
                Email = "Ms.Thanh@gmail.com",
                PointOfContact = "Ms. Thanh",
                Position = "TP MKT",
                Description = "Tổng công ty Dịch vụ số Viettel có mã số thuế 0100109106-478. Địa chỉ tại: 1 Giang Văn Minh Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Điện tử",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-92),
                UpdatedAt
             = DateTime.Now.AddDays(-92)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 114,
                Name = "Công ty Cổ phần Tập đoàn Hoa Sen",
                TaxCode = "3700381324",
                ClientCode = "Tôn Hoa Sen",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850434",
                Address = "Số 9, Đại lộ Thống Nhất, Khu công nghiệp Sóng Thần II, Phường Dĩ An, TX Dĩ An, Bình Dương",
                Career = "Vật liệu xây dựng",
                Email = "Mr.Vu@gmail.com",
                PointOfContact = "Mr. Vụ",
                Position = "Giám đốc MKT",
                Description = "Công ty Cổ phần Tập đoàn Hoa Sen có mã số thuế 3700381324. Địa chỉ tại: Số 9, Đại lộ Thống Nhất, Khu công nghiệp Sóng Thần II, Phường Dĩ An, TX Dĩ An, Bình Dương Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Vật liệu xây dựng",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-91),
                UpdatedAt
             = DateTime.Now.AddDays(-91)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 115,
                Name = "Công ty Cổ phần Đầu Tư Nam Long",
                TaxCode = "301438936",
                ClientCode = "Nam Long",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850435",
                Address = "Số 6 Nguyễn Khắc Viện, Tân Phú, Quận 7, TP. Hồ Chí Minh",
                Career = "Bất động sản",
                Email = "Mr.Binh@gmail.com",
                PointOfContact = "Mr. Bình",
                Position = "Giám đốc MKT",
                Description = "Công ty Cổ phần Đầu Tư Nam Long có mã số thuế 301438936. Địa chỉ tại: Số 6 Nguyễn Khắc Viện, Tân Phú, Quận 7, TP. Hồ Chí Minh Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bất động sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-90),
                UpdatedAt
             = DateTime.Now.AddDays(-90)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 116,
                Name = "Công ty Cổ phần Tập đoàn Mặt trời",
                TaxCode = "305016195",
                ClientCode = "Sungroup",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850436",
                Address = "65 Trần Hưng Đạo, Hoàn Kiếm, Hà Nội",
                Career = "Vật liệu xây dựng",
                Email = "Ms.KieuAnh@gmail.com",
                PointOfContact = "Ms. Kiều Anh",
                Position = "GDMKT",
                Description = "Công ty Cổ phần Tập đoàn Mặt trời có mã số thuế 305016195. Địa chỉ tại: 65 Trần Hưng Đạo, Hoàn Kiếm, Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Vật liệu xây dựng",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-89),
                UpdatedAt
             = DateTime.Now.AddDays(-89)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 117,
                Name = "Công ty Cổ phần Tập đoàn Karofi",
                TaxCode = "105866879",
                ClientCode = "Karofi",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850437",
                Address = "Tầng 8, Tòa nhà HUDLAND Tower, lô A-CC7, KDVTH Linh Đàm, đường Nguyễn Hữu Thọ, Phường Hoàng Liệt, Quận Hoàng Mai, Thành Phố Hà Nội",
                Career = "Điện tử",
                Email = "Ms,Thuy@gmail.com",
                PointOfContact = "Ms, Thủy",
                Position = "Phó TP MKT",
                Description = "Công ty Cổ phần Tập đoàn Karofi có mã số thuế 105866879. Địa chỉ tại: Tầng 8, Tòa nhà HUDLAND Tower, lô A-CC7, KDVTH Linh Đàm, đường Nguyễn Hữu Thọ, Phường Hoàng Liệt, Quận Hoàng Mai, Thành Phố Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Điện tử",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-88),
                UpdatedAt
             = DateTime.Now.AddDays(-88)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 118,
                Name = "Công ty TNHH Tập đoàn Bitexco",
                TaxCode = "1000214123",
                ClientCode = "1000214123",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850438",
                Address = "Tầng 2, Tháp The Manor, đường Mễ Trì, Phường Mỹ Đình 1, Quận Nam Từ Liêm",
                Career = "Vật liệu xây dựng",
                Email = "Ms,Hang@gmail.com",
                PointOfContact = "Ms, Hằng",
                Position = "CV MKT",
                Description = "Công ty TNHH Tập đoàn Bitexco có mã số thuế 1000214123. Địa chỉ tại: Tầng 2, Tháp The Manor, đường Mễ Trì, Phường Mỹ Đình 1, Quận Nam Từ Liêm Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Vật liệu xây dựng",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-87),
                UpdatedAt
             = DateTime.Now.AddDays(-87)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 119,
                Name = "Công ty TNHH Trường Đại học Anh Quốc Việt Nam",
                TaxCode = "102848568",
                ClientCode = "BUV",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850439",
                Address = "Ecopark, Văn Giang Hưng Yên",
                Career = "Giáo dục",
                Email = "Mr.Kien@gmail.com",
                PointOfContact = "Mr. Kiên",
                Position = "PT MKT",
                Description = "Công ty TNHH Trường Đại học Anh Quốc Việt Nam có mã số thuế 102848568. Địa chỉ tại: Ecopark, Văn Giang Hưng Yên Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Giáo dục",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-86),
                UpdatedAt
             = DateTime.Now.AddDays(-86)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 120,
                Name = "Công ty TNHH Đầu tư DHA",
                TaxCode = "311328019",
                ClientCode = "DHA",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850440",
                Address = "Số nhà 253 Hoàng Văn Thụ, Phường 2, Quận Tân Bình, Thành Phố Hồ Chí Minh, Việt Nam",
                Career = "Bất động sản",
                Email = "MsUyen@gmail.com",
                PointOfContact = "Ms Uyên",
                Position = "Giam đốc MKT",
                Description = "Công ty TNHH Đầu tư DHA có mã số thuế 311328019. Địa chỉ tại: Số nhà 253 Hoàng Văn Thụ, Phường 2, Quận Tân Bình, Thành Phố Hồ Chí Minh, Việt Nam Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bất động sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-85),
                UpdatedAt
             = DateTime.Now.AddDays(-85)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 121,
                Name = "Công ty sữa đậu nành Vinasoy",
                TaxCode = "4300205943-001",
                ClientCode = "Vinasoy",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850441",
                Address = "Đường TS 5, Khu CN Tiên Sơn - Phường Đồng Nguyên - Thị xã Từ Sơn - Bắc Ninh",
                Career = "FMCG",
                Email = "MsPhuong@gmail.com",
                PointOfContact = "Ms Phương",
                Position = "CV MKT",
                Description = "Công ty sữa đậu nành Vinasoy có mã số thuế 4300205943-001. Địa chỉ tại: Đường TS 5, Khu CN Tiên Sơn - Phường Đồng Nguyên - Thị xã Từ Sơn - Bắc Ninh Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: FMCG",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-84),
                UpdatedAt
             = DateTime.Now.AddDays(-84)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 122,
                Name = "Công ty Cổ phần tập đoàn Kido",
                TaxCode = "302705302",
                ClientCode = "KIDO",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850442",
                Address = "Số 138 -142 Hai Bà Trưng - Phường Đa Kao - Quận 1 - TP Hồ Chí Minh.",
                Career = "FMCG",
                Email = "MrBao@gmail.com",
                PointOfContact = "Mr Bảo",
                Position = "giám đốc MKT tập đoàn",
                Description = "Công ty Cổ phần tập đoàn Kido có mã số thuế 302705302. Địa chỉ tại: Số 138 -142 Hai Bà Trưng - Phường Đa Kao - Quận 1 - TP Hồ Chí Minh. Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: FMCG",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-83),
                UpdatedAt
             = DateTime.Now.AddDays(-83)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 123,
                Name = "Công Ty Tnhh Thương Mại - Dịch Vụ Tân Hiệp Phát",
                TaxCode = "301387752",
                ClientCode = "Tân Hiệp Phát",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850443",
                Address = "219 Đại lộ Bình Dương, Phường Vĩnh Phú, Thành phố Thuận An, Tỉnh Bình Dương, Việt Nam",
                Career = "FMCG",
                Email = "MrVu@gmail.com",
                PointOfContact = "Mr Vũ",
                Position = "Giam đốc phòng mua",
                Description = "Công Ty Tnhh Thương Mại - Dịch Vụ Tân Hiệp Phát có mã số thuế 301387752. Địa chỉ tại: 219 Đại lộ Bình Dương, Phường Vĩnh Phú, Thành phố Thuận An, Tỉnh Bình Dương, Việt Nam Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: FMCG",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-82),
                UpdatedAt
             = DateTime.Now.AddDays(-82)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 124,
                Name = "Ngân Hàng Thương Mại Cổ Phần Phát Triển Thành Phố Hồ Chí Minh.",
                TaxCode = "300608092",
                ClientCode = "HDBank",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850444",
                Address = "Số 25Bis (Một phần diện tích sử dụng tầng hầm 1 (B1) và các tầng 1,2,3,4,11,12,12A), Nguyễn Thị Minh Khai, Phường Bến Nghé, Quận 1, Thành phố Hồ Chí Minh",
                Career = "Ngân hàng",
                Email = "MrNghiep@gmail.com",
                PointOfContact = "Mr Nghiệp",
                Position = "Phó giám đốc thương hiệu",
                Description = "Ngân Hàng Thương Mại Cổ Phần Phát Triển Thành Phố Hồ Chí Minh. có mã số thuế 300608092. Địa chỉ tại: Số 25Bis (Một phần diện tích sử dụng tầng hầm 1 (B1) và các tầng 1,2,3,4,11,12,12A), Nguyễn Thị Minh Khai, Phường Bến Nghé, Quận 1, Thành phố Hồ Chí Minh Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Ngân hàng",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-81),
                UpdatedAt
             = DateTime.Now.AddDays(-81)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 125,
                Name = "Công Ty TNHH Một Thành Viên New Image Việt Nam",
                TaxCode = "311114017",
                ClientCode = "New Image",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850445",
                Address = "Tầng 4, Số 4 Nguyễn Đình Chiểu - Phường Đa Kao - Quận 1 - TP Hồ Chí Minh.",
                Career = "FMCG",
                Email = "MrDuong@gmail.com",
                PointOfContact = "Mr Dương",
                Position = "Giam đốc MKT",
                Description = "Công Ty TNHH Một Thành Viên New Image Việt Nam có mã số thuế 311114017. Địa chỉ tại: Tầng 4, Số 4 Nguyễn Đình Chiểu - Phường Đa Kao - Quận 1 - TP Hồ Chí Minh. Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: FMCG",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-80),
                UpdatedAt
             = DateTime.Now.AddDays(-80)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 126,
                Name = "Công Ty TNHH Red Bull (Việt Nam)",
                TaxCode = "3700236687",
                ClientCode = "Red Bull",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850446",
                Address = "Xa Lộ Hà Nội - Xã Bình Thắng - Huyện Dĩ An - Tỉnh Bình Dương",
                Career = "FMCG",
                Email = "MrGiang@gmail.com",
                PointOfContact = "Mr Giang",
                Position = "CV Phòng mua",
                Description = "Công Ty TNHH Red Bull (Việt Nam) có mã số thuế 3700236687. Địa chỉ tại: Xa Lộ Hà Nội - Xã Bình Thắng - Huyện Dĩ An - Tỉnh Bình Dương Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: FMCG",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-79),
                UpdatedAt
             = DateTime.Now.AddDays(-79)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 127,
                Name = "Công ty cổ phần bất động sản Son Kim",
                TaxCode = "305390717",
                ClientCode = "Sơn Kim Land",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850447",
                Address = "30A Đường số 11, Phường Thảo Điền, Quận 2, Thành phố Hồ Chí Minh, Việt Nam",
                Career = "Bất động sản",
                Email = "MsHuyen@gmail.com",
                PointOfContact = "Ms Huyền",
                Position = "TP MKT",
                Description = "Công ty cổ phần bất động sản Son Kim có mã số thuế 305390717. Địa chỉ tại: 30A Đường số 11, Phường Thảo Điền, Quận 2, Thành phố Hồ Chí Minh, Việt Nam Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bất động sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-78),
                UpdatedAt
             = DateTime.Now.AddDays(-78)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 128,
                Name = "Công ty TNHH Nestle Việt Nam",
                TaxCode = "3600235305",
                ClientCode = "Nestle",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850448",
                Address = "Số 7, Đường 17A, Khu Công nghiệp Biên Hòa 2, Phường An Bình, Thành phố Biên Hoà, Tỉnh Đồng Nai, Việt Nam",
                Career = "FMCG",
                Email = "MsTramAnh@gmail.com",
                PointOfContact = "Ms Trâm Anh",
                Position = "TP Phòng mua",
                Description = "Công ty TNHH Nestle Việt Nam có mã số thuế 3600235305. Địa chỉ tại: Số 7, Đường 17A, Khu Công nghiệp Biên Hòa 2, Phường An Bình, Thành phố Biên Hoà, Tỉnh Đồng Nai, Việt Nam Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: FMCG",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-77),
                UpdatedAt
             = DateTime.Now.AddDays(-77)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 129,
                Name = "Công ty cổ phần bia - rượu - nước giải khát Sài gòn",
                TaxCode = "300583659",
                ClientCode = "sabeco",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850449",
                Address = "187 Nguyễn Chí Thanh, Phường 12, Quận 5, Thành phố Hồ Chí Minh, Việt Nam",
                Career = "FMCG",
                Email = "MrLuyen@gmail.com",
                PointOfContact = "Mr Luyện",
                Position = "Trưởng nhãn 333",
                Description = "Công ty cổ phần bia - rượu - nước giải khát Sài gòn có mã số thuế 300583659. Địa chỉ tại: 187 Nguyễn Chí Thanh, Phường 12, Quận 5, Thành phố Hồ Chí Minh, Việt Nam Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: FMCG",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-76),
                UpdatedAt
             = DateTime.Now.AddDays(-76)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 130,
                Name = "Công ty Cổ phần Uniben",
                TaxCode = "301442989",
                ClientCode = "Uniben",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850450",
                Address = "Số 32 VSIP II-A đường số 30, Khu công nghiệp Việt Nam - Singapore II-A, Phường Vĩnh Tân, Thị xã Tân Uyên, Tỉnh Bình Dương, Việt Nam",
                Career = "FMCG",
                Email = "MrTheAnh@gmail.com",
                PointOfContact = "Mr Thế Anh",
                Position = "TP PHòng mua",
                Description = "Công ty Cổ phần Uniben có mã số thuế 301442989. Địa chỉ tại: Số 32 VSIP II-A đường số 30, Khu công nghiệp Việt Nam - Singapore II-A, Phường Vĩnh Tân, Thị xã Tân Uyên, Tỉnh Bình Dương, Việt Nam Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: FMCG",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-75),
                UpdatedAt
             = DateTime.Now.AddDays(-75)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 131,
                Name = "Công Ty Cổ Phần Phát Triển Và Kinh Doanh Nhà",
                TaxCode = "300446236",
                ClientCode = "HDTC",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850451",
                Address = "36 Bùi Thị Xuân, Phường Bến Thành, Quận 1, Thành Phố Hồ Chí Minh, Việt Nam",
                Career = "Bất động sản",
                Email = "MrKhanh@gmail.com",
                PointOfContact = "Mr Khánh",
                Position = "TP MKT",
                Description = "Công Ty Cổ Phần Phát Triển Và Kinh Doanh Nhà có mã số thuế 300446236. Địa chỉ tại: 36 Bùi Thị Xuân, Phường Bến Thành, Quận 1, Thành Phố Hồ Chí Minh, Việt Nam Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bất động sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-74),
                UpdatedAt
             = DateTime.Now.AddDays(-74)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 132,
                Name = "Cty TNHH Y Tế Viễn Đông Việt Nam",
                TaxCode = "302215724",
                ClientCode = "FV Hospital",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850452",
                Address = "số 6, đường Nguyễn Lương Bằng, (lô Md5-1, khu A Đô thị Phú Mỹ Hưng), Đô thị mới Nam thành phố, Phường Tân Phú, Quận 7, Thành Phố Hồ Chí Minh, Việt Nam",
                Career = "Y tế",
                Email = "MsThu@gmail.com",
                PointOfContact = "Ms Thu",
                Position = "CV MKT",
                Description = "Cty TNHH Y Tế Viễn Đông Việt Nam có mã số thuế 302215724. Địa chỉ tại: số 6, đường Nguyễn Lương Bằng, (lô Md5-1, khu A Đô thị Phú Mỹ Hưng), Đô thị mới Nam thành phố, Phường Tân Phú, Quận 7, Thành Phố Hồ Chí Minh, Việt Nam Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Y tế",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-73),
                UpdatedAt
             = DateTime.Now.AddDays(-73)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 133,
                Name = "Công Ty TNHH Sơn AKZO NOBEL Việt Nam",
                TaxCode = "3700687873",
                ClientCode = "akzo nobel",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850453",
                Address = "Lô E-1-CN, khu công nghiệp Mỹ Phước 2, Phường Mỹ Phước, Thị xã Bến Cát, Tỉnh Bình Dương, Việt Nam",
                Career = "VLXD",
                Email = "MsLinh@gmail.com",
                PointOfContact = "Ms Linh",
                Position = "TP MKT",
                Description = "Công Ty TNHH Sơn AKZO NOBEL Việt Nam có mã số thuế 3700687873. Địa chỉ tại: Lô E-1-CN, khu công nghiệp Mỹ Phước 2, Phường Mỹ Phước, Thị xã Bến Cát, Tỉnh Bình Dương, Việt Nam Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: VLXD",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-72),
                UpdatedAt
             = DateTime.Now.AddDays(-72)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 134,
                Name = "Công ty TNHH Saint-Gobain Vietnam",
                TaxCode = "304078329",
                ClientCode = "Saint Gobain",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850454",
                Address = "Lô C23B, Đường số 11 ,Khu Công nghiệp Hiệp Phước - Xã Hiệp Phước - Huyện Nhà Bè - TP Hồ Chí Minh.",
                Career = "VLXD",
                Email = "MrTri@gmail.com",
                PointOfContact = "Mr Trí",
                Position = "GD TT",
                Description = "Công ty TNHH Saint-Gobain Vietnam có mã số thuế 304078329. Địa chỉ tại: Lô C23B, Đường số 11 ,Khu Công nghiệp Hiệp Phước - Xã Hiệp Phước - Huyện Nhà Bè - TP Hồ Chí Minh. Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: VLXD",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-71),
                UpdatedAt
             = DateTime.Now.AddDays(-71)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 135,
                Name = "Công ty liên doanh TNHH Khu công nghiệp Việt Nam - Singapore",
                TaxCode = "3700230075",
                ClientCode = "VSIP",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850455",
                Address = "Số 8 - Đại Lộ Hữu Nghị - KCN VISP - Xã Bình Hòa - Xã Thuận An - Tỉnh Bình Dương",
                Career = "Bât Động Sản",
                Email = "MsXuan@gmail.com",
                PointOfContact = "Ms Xuân",
                Position = "TP MKT",
                Description = "Công ty liên doanh TNHH Khu công nghiệp Việt Nam - Singapore có mã số thuế 3700230075. Địa chỉ tại: Số 8 - Đại Lộ Hữu Nghị - KCN VISP - Xã Bình Hòa - Xã Thuận An - Tỉnh Bình Dương Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bât Động Sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-70),
                UpdatedAt
             = DateTime.Now.AddDays(-70)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 136,
                Name = "Công Ty Cổ Phần Vàng Bạc Đá Quý Phú Nhuận (PNJ)",
                TaxCode = "300521758",
                ClientCode = "PNJ",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850456",
                Address = "170E Phan Đăng Lưu - Phường 03 - Quận Phú Nhuận - TP Hồ Chí Minh",
                Career = "Bán lẻ",
                Email = "MrTu@gmail.com",
                PointOfContact = "Mr Từ",
                Position = "Giam Đốc truyền thông",
                Description = "Công Ty Cổ Phần Vàng Bạc Đá Quý Phú Nhuận (PNJ) có mã số thuế 300521758. Địa chỉ tại: 170E Phan Đăng Lưu - Phường 03 - Quận Phú Nhuận - TP Hồ Chí Minh Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bán lẻ",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-69),
                UpdatedAt
             = DateTime.Now.AddDays(-69)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 137,
                Name = "Công ty Cổ phần Setiabecamex",
                TaxCode = "3700848665",
                ClientCode = "Setiabecamex",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850457",
                Address = "Khu nhà văn phòng, đường R11-1, EcoLakes Mỹ Phước, Khu phố 6, Phường Thới Hòa, Thị xã Bến Cát, Tỉnh Bình Dương, Việt Nam",
                Career = "Bất Động sản",
                Email = "MrKhanh@gmail.com",
                PointOfContact = "Mr Khánh",
                Position = "Giam đốc MKT",
                Description = "Công ty Cổ phần Setiabecamex có mã số thuế 3700848665. Địa chỉ tại: Khu nhà văn phòng, đường R11-1, EcoLakes Mỹ Phước, Khu phố 6, Phường Thới Hòa, Thị xã Bến Cát, Tỉnh Bình Dương, Việt Nam Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bất Động sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-68),
                UpdatedAt
             = DateTime.Now.AddDays(-68)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 138,
                Name = "Công ty Cổ phần phát triển bất động sản Filmore",
                TaxCode = "312169442",
                ClientCode = "Fillmore",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850458",
                Address = "357-359 An Dương Vương, Phường 03, Quận 5, Thành phố Hồ Chí Minh, Việt Nam",
                Career = "Bất động sản",
                Email = "MrThinh@gmail.com",
                PointOfContact = "Mr Thịnh",
                Position = "Giam đốc Thương hiệu",
                Description = "Công ty Cổ phần phát triển bất động sản Filmore có mã số thuế 312169442. Địa chỉ tại: 357-359 An Dương Vương, Phường 03, Quận 5, Thành phố Hồ Chí Minh, Việt Nam Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bất động sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-67),
                UpdatedAt
             = DateTime.Now.AddDays(-67)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 139,
                Name = "Công ty Cổ phần tập đoàn Hưng Thịnh",
                TaxCode = "305410561",
                ClientCode = "Hưng Thịnh",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850459",
                Address = "110-112 Đường Trần Quốc Toản, Phường 07, Quận 3, Thành Phố Hồ Chí Minh, Việt Nam",
                Career = "Bất Động Sản",
                Email = "MrHung@gmail.com",
                PointOfContact = "Mr Hưng",
                Position = "Giam đốc MKT",
                Description = "Công ty Cổ phần tập đoàn Hưng Thịnh có mã số thuế 305410561. Địa chỉ tại: 110-112 Đường Trần Quốc Toản, Phường 07, Quận 3, Thành Phố Hồ Chí Minh, Việt Nam Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bất Động Sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-66),
                UpdatedAt
             = DateTime.Now.AddDays(-66)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 140,
                Name = "Công ty Cổ phần Tập đoàn C.E.O",
                TaxCode = "101183550",
                ClientCode = "101183550",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850460",
                Address = "Tòa nhà CEO Tower, Phạm Hùng, Q. Nam Từ Liêm",
                Career = "Bất động sản",
                Email = "Mr.Ha@gmail.com",
                PointOfContact = "Mr. Hà",
                Position = "MKT",
                Description = "Công ty Cổ phần Tập đoàn C.E.O có mã số thuế 101183550. Địa chỉ tại: Tòa nhà CEO Tower, Phạm Hùng, Q. Nam Từ Liêm Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bất động sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-65),
                UpdatedAt
             = DateTime.Now.AddDays(-65)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 141,
                Name = "Công ty Cổ phần đầu tư Khương Thịnh",
                TaxCode = "312586220",
                ClientCode = "Khương Thịnh",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850461",
                Address = "68-70 Nguyễn Gia Trí, Phường 25, Quận Bình Thạnh, Thành Phố Hồ Chí Minh, Việt Nam",
                Career = "Bất Động Sản",
                Email = "MrKhoa@gmail.com",
                PointOfContact = "Mr Khoa",
                Position = "TP MKT",
                Description = "Công ty Cổ phần đầu tư Khương Thịnh có mã số thuế 312586220. Địa chỉ tại: 68-70 Nguyễn Gia Trí, Phường 25, Quận Bình Thạnh, Thành Phố Hồ Chí Minh, Việt Nam Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bất Động Sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-64),
                UpdatedAt
             = DateTime.Now.AddDays(-64)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 142,
                Name = "Công ty Cổ phần Tập đoàn Picenza VN",
                TaxCode = "2500227965",
                ClientCode = "picenza",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850462",
                Address = "Số 20 phố Cát Linh, Phường Cát Linh, Quận Đống Đa, Thành phố Hà Nội, Việt Nam",
                Career = "Bán Lẻ",
                Email = "MrHuy@gmail.com",
                PointOfContact = "Mr Huy",
                Position = "CV MKT",
                Description = "Công ty Cổ phần Tập đoàn Picenza VN có mã số thuế 2500227965. Địa chỉ tại: Số 20 phố Cát Linh, Phường Cát Linh, Quận Đống Đa, Thành phố Hà Nội, Việt Nam Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bán Lẻ",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-63),
                UpdatedAt
             = DateTime.Now.AddDays(-63)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 143,
                Name = "Công ty TNHH phát triển công nghệ Thái Sơn",
                TaxCode = "101300842",
                ClientCode = "101300842",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850463",
                Address = "11 Dang Thuy Tram, Hoang Quoc Viet, Cau Giay, Ha Noi",
                Career = "công nghệ",
                Email = "Mr.Hai@gmail.com",
                PointOfContact = "Mr. Hải",
                Position = "MKT",
                Description = "Công ty TNHH phát triển công nghệ Thái Sơn có mã số thuế 101300842. Địa chỉ tại: 11 Dang Thuy Tram, Hoang Quoc Viet, Cau Giay, Ha Noi Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: công nghệ",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-62),
                UpdatedAt
             = DateTime.Now.AddDays(-62)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 144,
                Name = "Công ty HONDA Việt Nam",
                TaxCode = "2500150543",
                ClientCode = "2500150543",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850464",
                Address = "Só 1 Thái Hà - Đống Đa - Hà Nội",
                Career = "Ô tô xe máy",
                Email = "Mr.Son@gmail.com",
                PointOfContact = "Mr. Sơn",
                Position = "MKT Manager",
                Description = "Công ty HONDA Việt Nam có mã số thuế 2500150543. Địa chỉ tại: Só 1 Thái Hà - Đống Đa - Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Ô tô xe máy",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-61),
                UpdatedAt
             = DateTime.Now.AddDays(-61)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 145,
                Name = "Công ty Cổ phần PropertyGuru Việt Nam (batdongsan.com.vn)",
                TaxCode = "03103-3108",
                ClientCode = "Batdongsan.com.vn",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850465",
                Address = "Keangnam Landmark Tower, đường Phạm Hùng, Mễ Trì, Nam Từ Liêm, Hà Nội",
                Career = "Bất động sản",
                Email = "Ms.Phuong@gmail.com",
                PointOfContact = "Ms. Phượng",
                Position = "Planer",
                Description = "Công ty Cổ phần PropertyGuru Việt Nam (batdongsan.com.vn) có mã số thuế 03103-3108. Địa chỉ tại: Keangnam Landmark Tower, đường Phạm Hùng, Mễ Trì, Nam Từ Liêm, Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bất động sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-60),
                UpdatedAt
             = DateTime.Now.AddDays(-60)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 146,
                Name = "Công Ty Tnhh Phát Triển & Kinh Doanh Bất Động Sản Weland",
                TaxCode = "107814259",
                ClientCode = "Weland",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850466",
                Address = "SO06, Tầng 2, Tòa R2, KĐT Royal City, 72A Nguyễn Trãi, Hà Nội",
                Career = "Bất động sản",
                Email = "Ms.Hoa@gmail.com",
                PointOfContact = "Ms. Hoa",
                Position = "Planer",
                Description = "Công Ty Tnhh Phát Triển & Kinh Doanh Bất Động Sản Weland có mã số thuế 107814259. Địa chỉ tại: SO06, Tầng 2, Tòa R2, KĐT Royal City, 72A Nguyễn Trãi, Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bất động sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-59),
                UpdatedAt
             = DateTime.Now.AddDays(-59)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 147,
                Name = "Cty Cổ Phần IFF Holdings (IFF Holdings)",
                TaxCode = "314943615",
                ClientCode = "IFF Holding",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850467",
                Address = "17 Nguyễn Thị Diệu, Phường 06, Quận 3, Hồ Chí Minh, Vietnam.",
                Career = "Bất động sản",
                Email = "Mr.Vu@gmail.com",
                PointOfContact = "Mr. Vũ",
                Position = "Planer",
                Description = "Cty Cổ Phần IFF Holdings (IFF Holdings) có mã số thuế 314943615. Địa chỉ tại: 17 Nguyễn Thị Diệu, Phường 06, Quận 3, Hồ Chí Minh, Vietnam. Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bất động sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-58),
                UpdatedAt
             = DateTime.Now.AddDays(-58)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 148,
                Name = "Công ty CP Tập đoàn Mavin",
                TaxCode = "900841823",
                ClientCode = "Mavin",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850468",
                Address = "Tầng 1+8, tòa nhà Hudland, 6, Nguyễn Hữu Thọ, Hoàng Liệt, Hoàng Mai, Hà Nội",
                Career = "Thức ăn chăn nuôi",
                Email = "Ms.Toan@gmail.com",
                PointOfContact = "Ms. Toan",
                Position = "Trưởng phòng MKT",
                Description = "Công ty CP Tập đoàn Mavin có mã số thuế 900841823. Địa chỉ tại: Tầng 1+8, tòa nhà Hudland, 6, Nguyễn Hữu Thọ, Hoàng Liệt, Hoàng Mai, Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Thức ăn chăn nuôi",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-57),
                UpdatedAt
             = DateTime.Now.AddDays(-57)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 149,
                Name = "Công Ty TNHH Thiết Bị Và Công Nghệ Tekcom",
                TaxCode = "105351661",
                ClientCode = "Tekcom",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850469",
                Address = "Phúc Đồng, Long Biên, Hà Nội",
                Career = "Máy lọc nước",
                Email = "Mr.Cuong@gmail.com",
                PointOfContact = "Mr. Cương",
                Position = "Tổng Giám Đốc",
                Description = "Công Ty TNHH Thiết Bị Và Công Nghệ Tekcom có mã số thuế 105351661. Địa chỉ tại: Phúc Đồng, Long Biên, Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Máy lọc nước",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-56),
                UpdatedAt
             = DateTime.Now.AddDays(-56)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 150,
                Name = "Ngân hàng Thương mại Cổ phần Bưu điện Liên Việt",
                TaxCode = "6300048638",
                ClientCode = "Liên Việt Pos Bank",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850470",
                Address = "Tòa nhà Thaiholdings, số 210 Trần Quang Khải, Q. Hoàn Kiếm, Hà Nội",
                Career = "Ngân hàng",
                Email = "Ms.Hien@gmail.com",
                PointOfContact = "Ms. Hiền",
                Position = "Trưởng nhãn thương hiệu",
                Description = "Ngân hàng Thương mại Cổ phần Bưu điện Liên Việt có mã số thuế 6300048638. Địa chỉ tại: Tòa nhà Thaiholdings, số 210 Trần Quang Khải, Q. Hoàn Kiếm, Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Ngân hàng",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-55),
                UpdatedAt
             = DateTime.Now.AddDays(-55)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 151,
                Name = "Nhà Máy Nước Khoáng Thạch Bích",
                TaxCode = "4300205943-018",
                ClientCode = "Nước khoáng Thạch Bích",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850471",
                Address = "2 Nguyễn Chí Thanh, Quảng Phú, Quảng Ngãi",
                Career = "FMCG",
                Email = "Mr.Tan@gmail.com",
                PointOfContact = "Mr. Tân",
                Position = "Planer",
                Description = "Nhà Máy Nước Khoáng Thạch Bích có mã số thuế 4300205943-018. Địa chỉ tại: 2 Nguyễn Chí Thanh, Quảng Phú, Quảng Ngãi Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: FMCG",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-54),
                UpdatedAt
             = DateTime.Now.AddDays(-54)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 152,
                Name = "Quỹ nhi đồng Liên Hợp Quốc",
                TaxCode = "101151742",
                ClientCode = "101151742",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850472",
                Address = "Hà Nội",
                Career = "NGOs",
                Email = "MrHoang@gmail.com",
                PointOfContact = "Mr Hoàng",
                Position = "Marketing Officer",
                Description = "Quỹ nhi đồng Liên Hợp Quốc có mã số thuế 101151742. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: NGOs",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-53),
                UpdatedAt
             = DateTime.Now.AddDays(-53)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 153,
                Name = "Công ty TNHH Thiết bị điện và chiếu sáng Châu Á",
                TaxCode = "106800119",
                ClientCode = "Asialighting",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850473",
                Address = "C2, Nơ 19, Khu Đô Thị Định Công, Phường Định Công, Quận Hoàng Mai, Thành Phố Hà Nội, Định Công, Hoàng Mai, Hà Nội",
                Career = "Vật lệu xây dựng ( đèn led)",
                Email = "Mr.Cuong@gmail.com",
                PointOfContact = "Mr. Cường",
                Position = "Planer",
                Description = "Công ty TNHH Thiết bị điện và chiếu sáng Châu Á có mã số thuế 106800119. Địa chỉ tại: C2, Nơ 19, Khu Đô Thị Định Công, Phường Định Công, Quận Hoàng Mai, Thành Phố Hà Nội, Định Công, Hoàng Mai, Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Vật lệu xây dựng ( đèn led)",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-52),
                UpdatedAt
             = DateTime.Now.AddDays(-52)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 154,
                Name = "Công Ty Cổ Phần Tập Đoàn Austdoor",
                TaxCode = "101306139",
                ClientCode = "Austdoor",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850474",
                Address = "Hà Nội",
                Career = "Vật liệu xây dựng (cửa cuốn)",
                Email = "Ms.Hien@gmail.com",
                PointOfContact = "Ms. Hiền",
                Position = "Chuyên viên MKT",
                Description = "Công Ty Cổ Phần Tập Đoàn Austdoor có mã số thuế 101306139. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Vật liệu xây dựng (cửa cuốn)",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-51),
                UpdatedAt
             = DateTime.Now.AddDays(-51)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 155,
                Name = "Công Ty Cổ Phần Mía Đường Lam Sơn",
                TaxCode = "2800463346",
                ClientCode = "Lasuco",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850475",
                Address = "Hà Nội",
                Career = "Xuất khẩu",
                Email = "MrChung@gmail.com",
                PointOfContact = "Mr Chung",
                Position = "Phó Giám Đốc",
                Description = "Công Ty Cổ Phần Mía Đường Lam Sơn có mã số thuế 2800463346. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Xuất khẩu",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-50),
                UpdatedAt
             = DateTime.Now.AddDays(-50)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 156,
                Name = "Ngân hàng TMCP Hàng hải Việt Nam",
                TaxCode = "200124891",
                ClientCode = "MSB",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850476",
                Address = "54A Nguyễn Chí Thanh, Đống Đa, Hà Nội",
                Career = "Ngân hàng",
                Email = "Mr.Dung@gmail.com",
                PointOfContact = "Mr. Dung",
                Position = "Giám đốc Khối MKT",
                Description = "Ngân hàng TMCP Hàng hải Việt Nam có mã số thuế 200124891. Địa chỉ tại: 54A Nguyễn Chí Thanh, Đống Đa, Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Ngân hàng",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-49),
                UpdatedAt
             = DateTime.Now.AddDays(-49)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 157,
                Name = "Công ty Cổ phần Tập đoàn Nagakawa chi nhánh Hà Nội",
                TaxCode = "2500217389-002",
                ClientCode = "Nagakawa",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850477",
                Address = "16A Định Công, Hoàng Mai, HN",
                Career = "Điện máy",
                Email = "Mr.Nam@gmail.com",
                PointOfContact = "Mr. Nam",
                Position = "CV MKT",
                Description = "Công ty Cổ phần Tập đoàn Nagakawa chi nhánh Hà Nội có mã số thuế 2500217389-002. Địa chỉ tại: 16A Định Công, Hoàng Mai, HN Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Điện máy",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-48),
                UpdatedAt
             = DateTime.Now.AddDays(-48)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 158,
                Name = "Công Ty Cổ Phần Đầu Tư Bất Động Sản Taseco",
                TaxCode = "104079036",
                ClientCode = "Taseco",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850478",
                Address = "Tầng 1, toà nhà N02-T1, khu Đoàn Ngoại Giao, phố Đỗ Nhuận, phường Xuân Tảo, quận Bắc Từ Liêm, thành phố Hà Nội.",
                Career = "Bất động sản",
                Email = "Ms.Huong@gmail.com",
                PointOfContact = "Ms. Hương",
                Position = "Trưởng phòng truyền thông",
                Description = "Công Ty Cổ Phần Đầu Tư Bất Động Sản Taseco có mã số thuế 104079036. Địa chỉ tại: Tầng 1, toà nhà N02-T1, khu Đoàn Ngoại Giao, phố Đỗ Nhuận, phường Xuân Tảo, quận Bắc Từ Liêm, thành phố Hà Nội. Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bất động sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-47),
                UpdatedAt
             = DateTime.Now.AddDays(-47)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 159,
                Name = "Công Ty Cổ Phần Đầu Tư Bất Động Sản Taseco",
                TaxCode = "104079036",
                ClientCode = "Taseco",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850479",
                Address = "Tầng 1, toà nhà N02-T1, khu Đoàn Ngoại Giao, phố Đỗ Nhuận, phường Xuân Tảo, quận Bắc Từ Liêm, thành phố Hà Nội.",
                Career = "Bất động sản",
                Email = "Ms.Huong@gmail.com",
                PointOfContact = "Ms. Hương",
                Position = "Trưởng phòng truyền thông",
                Description = "Công Ty Cổ Phần Đầu Tư Bất Động Sản Taseco có mã số thuế 104079036. Địa chỉ tại: Tầng 1, toà nhà N02-T1, khu Đoàn Ngoại Giao, phố Đỗ Nhuận, phường Xuân Tảo, quận Bắc Từ Liêm, thành phố Hà Nội. Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bất động sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-46),
                UpdatedAt
             = DateTime.Now.AddDays(-46)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 160,
                Name = "Công Ty TNHH Điều Hòa Fujiaire Việt Nam",
                TaxCode = "107798374",
                ClientCode = "Fujiaire",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850480",
                Address = "Số 69, Ga Hà đông, Tổ 10, Phường Phú La, Quận Hà Đông, Thành phố Hà Nội",
                Career = "Bán lẻ",
                Email = "MrNgan@gmail.com",
                PointOfContact = "Mr Ngân",
                Position = "Trưởng phòng MKT",
                Description = "Công Ty TNHH Điều Hòa Fujiaire Việt Nam có mã số thuế 107798374. Địa chỉ tại: Số 69, Ga Hà đông, Tổ 10, Phường Phú La, Quận Hà Đông, Thành phố Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bán lẻ",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-45),
                UpdatedAt
             = DateTime.Now.AddDays(-45)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 161,
                Name = "Công ty TNHH bia Carlsbeg Việt Nam",
                TaxCode = "3300100586",
                ClientCode = "Carlsberg",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850481",
                Address = "Lô B8, Khu Công nghiệp Phú Bài, Phường Phú Bài, Thị xã Hương Thuỷ, Tỉnh Thừa Thiên Huế, Việt Nam",
                Career = "FMCG",
                Email = "MrChinh@gmail.com",
                PointOfContact = "Mr Chính",
                Position = "Trưởng phòng MKT",
                Description = "Công ty TNHH bia Carlsbeg Việt Nam có mã số thuế 3300100586. Địa chỉ tại: Lô B8, Khu Công nghiệp Phú Bài, Phường Phú Bài, Thị xã Hương Thuỷ, Tỉnh Thừa Thiên Huế, Việt Nam Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: FMCG",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-44),
                UpdatedAt
             = DateTime.Now.AddDays(-44)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 162,
                Name = "Công ty Cổ phần FPT",
                TaxCode = "101248141",
                ClientCode = "FPT",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850482",
                Address = "Số 17 phố Duy Tân, Phường Dịch Vọng Hậu, Quận Cầu Giấy, Thành phố Hà Nội, Việt Nam",
                Career = "Viễn thông",
                Email = "MrCuong@gmail.com",
                PointOfContact = "Mr Cường",
                Position = "Giam đốc Đối ngoại",
                Description = "Công ty Cổ phần FPT có mã số thuế 101248141. Địa chỉ tại: Số 17 phố Duy Tân, Phường Dịch Vọng Hậu, Quận Cầu Giấy, Thành phố Hà Nội, Việt Nam Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Viễn thông",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-43),
                UpdatedAt
             = DateTime.Now.AddDays(-43)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 163,
                Name = "Công ty Cổ phần KLB",
                TaxCode = "800754253",
                ClientCode = "KLB",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850483",
                Address = "Tầng 14 Tòa nhà Licogi13, Số 164 Khuất Duy Tiến - Phường Nhân Chính - Quận Thanh Xuân - Hà Nội.",
                Career = "Bất động sản",
                Email = "MsYen@gmail.com",
                PointOfContact = "Ms Yến",
                Position = "TP MKT",
                Description = "Công ty Cổ phần KLB có mã số thuế 800754253. Địa chỉ tại: Tầng 14 Tòa nhà Licogi13, Số 164 Khuất Duy Tiến - Phường Nhân Chính - Quận Thanh Xuân - Hà Nội. Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bất động sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-42),
                UpdatedAt
             = DateTime.Now.AddDays(-42)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 164,
                Name = "Công ty CP Nhôm Đô Thành",
                TaxCode = "100510501",
                ClientCode = "Grando",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850484",
                Address = "Khu Công nghiệp vừa và nhỏ, Xã Phú Thị, Huyện Gia Lâm, Hà Nội",
                Career = "VLXD",
                Email = "MrSon@gmail.com",
                PointOfContact = "Mr Sơn",
                Position = "Giam đốc kinh doanh",
                Description = "Công ty CP Nhôm Đô Thành có mã số thuế 100510501. Địa chỉ tại: Khu Công nghiệp vừa và nhỏ, Xã Phú Thị, Huyện Gia Lâm, Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: VLXD",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-41),
                UpdatedAt
             = DateTime.Now.AddDays(-41)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 165,
                Name = "Công ty TNHH sản xuất thương mại Kim Hoàn Vũ",
                TaxCode = "301424549",
                ClientCode = "Kim Hoàn Vũ",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850485",
                Address = "100 Đường A4, Phường 12, Quận Tân Bình, Thành Phố Hồ Chí Minh, Việt Nam",
                Career = "VLXD",
                Email = "MrTri@gmail.com",
                PointOfContact = "Mr Trí",
                Position = "TP MKT",
                Description = "Công ty TNHH sản xuất thương mại Kim Hoàn Vũ có mã số thuế 301424549. Địa chỉ tại: 100 Đường A4, Phường 12, Quận Tân Bình, Thành Phố Hồ Chí Minh, Việt Nam Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: VLXD",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-40),
                UpdatedAt
             = DateTime.Now.AddDays(-40)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 166,
                Name = "Công Ty Cổ Phần Chăn Nuôi C.p. Việt Nam",
                TaxCode = "3600224423",
                ClientCode = "CP Corp",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850486",
                Address = "KCN Biên Hòa II, Phường Long Bình Tân, Thành phố Biên Hoà, Tỉnh Đồng Nai",
                Career = "FMCG",
                Email = "MsDoan@gmail.com",
                PointOfContact = "Ms Đoan",
                Position = "Planner",
                Description = "Công Ty Cổ Phần Chăn Nuôi C.p. Việt Nam có mã số thuế 3600224423. Địa chỉ tại: KCN Biên Hòa II, Phường Long Bình Tân, Thành phố Biên Hoà, Tỉnh Đồng Nai Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: FMCG",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-39),
                UpdatedAt
             = DateTime.Now.AddDays(-39)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 167,
                Name = "Công ty Cổ phần Bệnh viện quốc tế Bernard",
                TaxCode = "316341020",
                ClientCode = "Bernard",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850487",
                Address = "192/19 Phan Văn Hân, Phường 17, Quận Bình Thạnh, Thành Phố Hồ Chí Minh, Việt Nam",
                Career = "Y tế",
                Email = "MrHuy@gmail.com",
                PointOfContact = "Mr Huy",
                Position = "CEO",
                Description = "Công ty Cổ phần Bệnh viện quốc tế Bernard có mã số thuế 316341020. Địa chỉ tại: 192/19 Phan Văn Hân, Phường 17, Quận Bình Thạnh, Thành Phố Hồ Chí Minh, Việt Nam Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Y tế",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-38),
                UpdatedAt
             = DateTime.Now.AddDays(-38)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 168,
                Name = "Công Ty Cổ Phần Dược Phẩm Eco ( Nhãn Ritana)",
                TaxCode = "102637020",
                ClientCode = "Eco - nhãn Ritana",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850488",
                Address = "148 Hoàng Hoa Thám, P.12, Q.Tân Bình, TP.HCM",
                Career = "Dược phẩm",
                Email = "MsThao@gmail.com",
                PointOfContact = "Ms Thảo",
                Position = "TP MKT",
                Description = "Công Ty Cổ Phần Dược Phẩm Eco ( Nhãn Ritana) có mã số thuế 102637020. Địa chỉ tại: 148 Hoàng Hoa Thám, P.12, Q.Tân Bình, TP.HCM Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Dược phẩm",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-37),
                UpdatedAt
             = DateTime.Now.AddDays(-37)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 169,
                Name = "Ngân Hàng Thương Mại Cổ Phần Sài Gòn ( SCB)",
                TaxCode = "311449990",
                ClientCode = "SCB",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850489",
                Address = "927 Trần Hưng Đạo - Phường 01 - Quận 5 - TP Hồ Chí Minh",
                Career = "Ngân hàng",
                Email = "MrMan@gmail.com",
                PointOfContact = "Mr Mẫn",
                Position = "Giam đốc thương hiệu",
                Description = "Ngân Hàng Thương Mại Cổ Phần Sài Gòn ( SCB) có mã số thuế 311449990. Địa chỉ tại: 927 Trần Hưng Đạo - Phường 01 - Quận 5 - TP Hồ Chí Minh Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Ngân hàng",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-36),
                UpdatedAt
             = DateTime.Now.AddDays(-36)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 170,
                Name = "Công ty TNHH Nước giải khát Suntory Pepsico",
                TaxCode = "300816663",
                ClientCode = "Suntory Pepsico",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850490",
                Address = "Cao ốc Sheraton, số 88 đường Đồng Khởi , Phường Bến Nghé, Quận 1, Thành phố Hồ Chí Minh, Việt Nam",
                Career = "FMCG",
                Email = "MrKiet@gmail.com",
                PointOfContact = "Mr Kiệt",
                Position = "Trưởng nhãn Revive, Aquafina, Gatorade",
                Description = "Công ty TNHH Nước giải khát Suntory Pepsico có mã số thuế 300816663. Địa chỉ tại: Cao ốc Sheraton, số 88 đường Đồng Khởi , Phường Bến Nghé, Quận 1, Thành phố Hồ Chí Minh, Việt Nam Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: FMCG",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-35),
                UpdatedAt
             = DateTime.Now.AddDays(-35)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 171,
                Name = "Công ty Cổ phần Casper Việt Nam",
                TaxCode = "107009894",
                ClientCode = "Casper",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850491",
                Address = "643 Phạm Văn Đồng, Nam Từ Liêm, HN",
                Career = "Điện máy",
                Email = "Ms.Thanh@gmail.com",
                PointOfContact = "Ms. Thanh",
                Position = "TP MKT",
                Description = "Công ty Cổ phần Casper Việt Nam có mã số thuế 107009894. Địa chỉ tại: 643 Phạm Văn Đồng, Nam Từ Liêm, HN Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Điện máy",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-34),
                UpdatedAt
             = DateTime.Now.AddDays(-34)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 172,
                Name = "Công ty Cổ phẩn Truyền thông Đa phương tiện 122 Việt Nam",
                TaxCode = "109117013",
                ClientCode = "122 Media",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850492",
                Address = "Số 22, ngõ 235 Yên hòa, Phường Yên Hoà, Quận Cầu Giấy, Hà Nội",
                Career = "Agency",
                Email = "Mr.Tung@gmail.com",
                PointOfContact = "Mr. Tùng",
                Position = "Trưởng nhóm KD",
                Description = "Công ty Cổ phẩn Truyền thông Đa phương tiện 122 Việt Nam có mã số thuế 109117013. Địa chỉ tại: Số 22, ngõ 235 Yên hòa, Phường Yên Hoà, Quận Cầu Giấy, Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Agency",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-33),
                UpdatedAt
             = DateTime.Now.AddDays(-33)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 173,
                Name = "Công ty Cổ phần Eurowindow Holding",
                TaxCode = "2500271160",
                ClientCode = "BĐS Eurowindow",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850493",
                Address = "02 Tôn Thất Tùng, Đống Đa, Hà Nội",
                Career = "bất động sản",
                Email = "Ms.Thao@gmail.com",
                PointOfContact = "Ms. Thảo",
                Position = "CV MKT",
                Description = "Công ty Cổ phần Eurowindow Holding có mã số thuế 2500271160. Địa chỉ tại: 02 Tôn Thất Tùng, Đống Đa, Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: bất động sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-32),
                UpdatedAt
             = DateTime.Now.AddDays(-32)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 174,
                Name = "Công ty cổ phần công nghiệp và thiết bị chiếu sáng Duhal",
                TaxCode = "1200512952",
                ClientCode = "Duhal",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850494",
                Address = "30-31 Cụm Công Nghiệp Tân Mỹ Chánh, Phường 9, Thành phố Mỹ Tho, Tiền Giang",
                Career = "Vật liệu xây dựng ( đèn led)",
                Email = "Mr.Luat@gmail.com",
                PointOfContact = "Mr. Luật",
                Position = "Chuyên viên MKT",
                Description = "Công ty cổ phần công nghiệp và thiết bị chiếu sáng Duhal có mã số thuế 1200512952. Địa chỉ tại: 30-31 Cụm Công Nghiệp Tân Mỹ Chánh, Phường 9, Thành phố Mỹ Tho, Tiền Giang Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Vật liệu xây dựng ( đèn led)",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-31),
                UpdatedAt
             = DateTime.Now.AddDays(-31)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 175,
                Name = "Công ty TNHH Grab",
                TaxCode = "312650437",
                ClientCode = "Grab",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850495",
                Address = "Tòa nhà Mapletree Business Center, Số 1060 Đại lộ Nguyễn Văn Linh, Phường Tân Phong, Quận 7, Thành phố Hồ Chí Minh",
                Career = "Logistics",
                Email = "Mr.Thu@gmail.com",
                PointOfContact = "Mr. Thư",
                Position = "CV MKT",
                Description = "Công ty TNHH Grab có mã số thuế 312650437. Địa chỉ tại: Tòa nhà Mapletree Business Center, Số 1060 Đại lộ Nguyễn Văn Linh, Phường Tân Phong, Quận 7, Thành phố Hồ Chí Minh Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Logistics",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-30),
                UpdatedAt
             = DateTime.Now.AddDays(-30)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 176,
                Name = "Công Ty Tnhh Truyền Hình Số Việt Nam",
                TaxCode = "109138782",
                ClientCode = "K+",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850496",
                Address = "Hà Nội",
                Career = "dịch vụ",
                Email = "MsDieu@gmail.com",
                PointOfContact = "Ms Diệu",
                Position = "director",
                Description = "Công Ty Tnhh Truyền Hình Số Việt Nam có mã số thuế 109138782. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: dịch vụ",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-29),
                UpdatedAt
             = DateTime.Now.AddDays(-29)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 177,
                Name = "Công Ty Cổ Phần Thương Hiệu Và Truyền Thông Brandbiz",
                TaxCode = "108502534",
                ClientCode = "Brandbiz",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850497",
                Address = "Toà Nhà Gelex, 52 Lê Đại Hành, Hà Nội",
                Career = "Bất động sản",
                Email = "Ms.Hoa@gmail.com",
                PointOfContact = "Ms. Hòa",
                Position = "Trưởng nhãn",
                Description = "Công Ty Cổ Phần Thương Hiệu Và Truyền Thông Brandbiz có mã số thuế 108502534. Địa chỉ tại: Toà Nhà Gelex, 52 Lê Đại Hành, Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bất động sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-28),
                UpdatedAt
             = DateTime.Now.AddDays(-28)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 178,
                Name = "Công ty Cổ phần Daikin Air Conditioning",
                TaxCode = "301450108",
                ClientCode = "Daikin",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850498",
                Address = "14-15,Tòa nhà VP Nam á, Số 201-203 Đường Cách Mạng Tháng 8",
                Career = "Điện máy",
                Email = "Mr.Vinh@gmail.com",
                PointOfContact = "Mr. Vinh",
                Position = "Giám đốc MKT",
                Description = "Công ty Cổ phần Daikin Air Conditioning có mã số thuế 301450108. Địa chỉ tại: 14-15,Tòa nhà VP Nam á, Số 201-203 Đường Cách Mạng Tháng 8 Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Điện máy",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-27),
                UpdatedAt
             = DateTime.Now.AddDays(-27)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 179,
                Name = "Tập đoàn Bảo Việt",
                TaxCode = "100111761",
                ClientCode = "100111761",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850499",
                Address = "Hà Nội",
                Career = "Bảo hiểm",
                Email = "MsHoa@gmail.com",
                PointOfContact = "Ms Hoa",
                Position = "Giám đốc thương hiệu",
                Description = "Tập đoàn Bảo Việt có mã số thuế 100111761. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bảo hiểm",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-26),
                UpdatedAt
             = DateTime.Now.AddDays(-26)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 180,
                Name = "Công Ty TNHH Cửa Sổ Việt Châu Á Aseanwindow",
                TaxCode = "308779300",
                ClientCode = "Asean Window",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850500",
                Address = "A7/40, 31 Đường Võ Văn Vân, ấp 1, Bình Tân",
                Career = "Vật liệu xây dựng",
                Email = "Ms.Van@gmail.com",
                PointOfContact = "Ms. Vân",
                Position = "TP MKT",
                Description = "Công Ty TNHH Cửa Sổ Việt Châu Á Aseanwindow có mã số thuế 308779300. Địa chỉ tại: A7/40, 31 Đường Võ Văn Vân, ấp 1, Bình Tân Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Vật liệu xây dựng",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-25),
                UpdatedAt
             = DateTime.Now.AddDays(-25)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 181,
                Name = "Công ty Cổ phần Tập đoàn Tonmat",
                TaxCode = "2300238060",
                ClientCode = "Tonmat",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850501",
                Address = "KCN Tiên Sơn, Bắc Ninh",
                Career = "Vật liệu xây dựng",
                Email = "Mr.Linh@gmail.com",
                PointOfContact = "Mr. Linh",
                Position = "TP MKT",
                Description = "Công ty Cổ phần Tập đoàn Tonmat có mã số thuế 2300238060. Địa chỉ tại: KCN Tiên Sơn, Bắc Ninh Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Vật liệu xây dựng",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-24),
                UpdatedAt
             = DateTime.Now.AddDays(-24)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 182,
                Name = "Công Ty Cổ Phần Thương Mại Vngroup Việt Nam",
                TaxCode = "801286495",
                ClientCode = "VNGroup",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850502",
                Address = "Tầng 5, Tòa Diamond Flower Tower, Hoàng Đạo Thúy,Phường Nhân Chính, Quận Thanh Xuân, Hà Nội",
                Career = "Bất động sản",
                Email = "Mr.HaiAnh@gmail.com",
                PointOfContact = "Mr. Hải Anh",
                Position = "Planer",
                Description = "Công Ty Cổ Phần Thương Mại Vngroup Việt Nam có mã số thuế 801286495. Địa chỉ tại: Tầng 5, Tòa Diamond Flower Tower, Hoàng Đạo Thúy,Phường Nhân Chính, Quận Thanh Xuân, Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bất động sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-23),
                UpdatedAt
             = DateTime.Now.AddDays(-23)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 183,
                Name = "Công ty Cổ phần Tập đoàn Đại Việt",
                TaxCode = "304513557",
                ClientCode = "Daikio",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850503",
                Address = "Lô IV.11, Đường số 4, Khu Công Nghiệp Tân Bình, Phường Tây Thạnh, Quận Tân Phú, TP. Hồ Chí Minh",
                Career = "Điện máy",
                Email = "Ms.Tuyen@gmail.com",
                PointOfContact = "Ms. Tuyến",
                Position = "CV MKT",
                Description = "Công ty Cổ phần Tập đoàn Đại Việt có mã số thuế 304513557. Địa chỉ tại: Lô IV.11, Đường số 4, Khu Công Nghiệp Tân Bình, Phường Tây Thạnh, Quận Tân Phú, TP. Hồ Chí Minh Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Điện máy",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-22),
                UpdatedAt
             = DateTime.Now.AddDays(-22)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 184,
                Name = "Công Ty Cổ Phần Ahcom Việt Nam ( Subaru Long Biên)",
                TaxCode = "104580718",
                ClientCode = "AHCom",
                ClientSource = "Hotline",
                PhoneNumber = "0989850504",
                Address = "Hà Nội",
                Career = "Ô tô xe máy",
                Email = "Ms.Hoa@gmail.com",
                PointOfContact = "Ms. Hòa",
                Position = "Planer",
                Description = "Công Ty Cổ Phần Ahcom Việt Nam ( Subaru Long Biên) có mã số thuế 104580718. Địa chỉ tại: Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Ô tô xe máy",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-21),
                UpdatedAt
             = DateTime.Now.AddDays(-21)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 185,
                Name = "Chi nhánh Công ty Cổ phần Nero",
                TaxCode = "0108677460-001",
                ClientCode = "Nero",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850505",
                Address = "786B Nguyễn Kiệm, Phường 3, Quận Gò Vấp, Thành phố Hồ Chí Minh",
                Career = "Thẩm mỹ",
                Email = "Mr.Nhan@gmail.com",
                PointOfContact = "Mr. Nhân",
                Position = "Phụ trách KD &MKT",
                Description = "Chi nhánh Công ty Cổ phần Nero có mã số thuế 0108677460-001. Địa chỉ tại: 786B Nguyễn Kiệm, Phường 3, Quận Gò Vấp, Thành phố Hồ Chí Minh Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Thẩm mỹ",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-20),
                UpdatedAt
             = DateTime.Now.AddDays(-20)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 186,
                Name = "Công Ty Cổ Phần Tổng Công Ty Mbland",
                TaxCode = "102631822",
                ClientCode = "MB Land",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850506",
                Address = "Tầng 4, Tháp A, Keangnam Hanoi Landmark Tower, Khu E6 Đô thị mới Cầu Giấy, Phường Mễ Trì, Quận Nam Từ Liêm, Hà Nội",
                Career = "Bất động sản",
                Email = "Mr.Hai@gmail.com",
                PointOfContact = "Mr. Hải",
                Position = "Giám đốc kinh doanh",
                Description = "Công Ty Cổ Phần Tổng Công Ty Mbland có mã số thuế 102631822. Địa chỉ tại: Tầng 4, Tháp A, Keangnam Hanoi Landmark Tower, Khu E6 Đô thị mới Cầu Giấy, Phường Mễ Trì, Quận Nam Từ Liêm, Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bất động sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-19),
                UpdatedAt
             = DateTime.Now.AddDays(-19)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 187,
                Name = "Bất động sản Không Gian Xanh",
                TaxCode = "1801648147",
                ClientCode = "1801648147",
                ClientSource = "Hotline",
                PhoneNumber = "0989850507",
                Address = "Royal City",
                Career = "Bất động sản",
                Email = "Mr.Dung@gmail.com",
                PointOfContact = "Mr. Dũng",
                Position = "Phụ trách MKT & KD",
                Description = "Bất động sản Không Gian Xanh có mã số thuế 1801648147. Địa chỉ tại: Royal City Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bất động sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-18),
                UpdatedAt
             = DateTime.Now.AddDays(-18)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 188,
                Name = "Công Ty Cổ Phần Dây Và Cáp Điện Thượng Đình",
                TaxCode = "100892628",
                ClientCode = "Cadisun",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850508",
                Address = "Ngõ 320 Ngõ 320 Khương Đình, Cụm 3, P, Thanh Xuân, Hà Nội",
                Career = "Dây cáp điện",
                Email = "Mr.Quyen@gmail.com",
                PointOfContact = "Mr. Quyền",
                Position = "Phó Tổng Giám Đốc",
                Description = "Công Ty Cổ Phần Dây Và Cáp Điện Thượng Đình có mã số thuế 100892628. Địa chỉ tại: Ngõ 320 Ngõ 320 Khương Đình, Cụm 3, P, Thanh Xuân, Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Dây cáp điện",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-17),
                UpdatedAt
             = DateTime.Now.AddDays(-17)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 189,
                Name = "CÔNG TY TNHH SẢN XUẤT HÀNG TIÊU DÙNG BÌNH TIÊN - CHI NHÁNH BITI'S TẠI MIỀN NAM",
                TaxCode = "0301340497-035",
                ClientCode = "Bitis",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850509",
                Address = "22 Lý Chiêu Hoàng, Phường 10, Quận 6, TP HCM",
                Career = "Tiêu dùng",
                Email = "Mr.Cuong@gmail.com",
                PointOfContact = "Mr. Cường",
                Position = "Giám đốc MKT",
                Description = "CÔNG TY TNHH SẢN XUẤT HÀNG TIÊU DÙNG BÌNH TIÊN - CHI NHÁNH BITI'S TẠI MIỀN NAM có mã số thuế 0301340497-035. Địa chỉ tại: 22 Lý Chiêu Hoàng, Phường 10, Quận 6, TP HCM Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Tiêu dùng",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-16),
                UpdatedAt
             = DateTime.Now.AddDays(-16)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 190,
                Name = "Công ty Cổ phần Foody",
                TaxCode = "311828036",
                ClientCode = "Foody",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850510",
                Address = "Lầu 8, Tòa nhà Jabes 1, số 244 đường Cống Quỳnh, Phường Phạm Ngũ Lão, Quận 1, TP Hồ Chí Minh",
                Career = "Ẩm thực",
                Email = "Ms.Chi@gmail.com",
                PointOfContact = "Ms. Chi",
                Position = "TP Phát triển thương hiệu",
                Description = "Công ty Cổ phần Foody có mã số thuế 311828036. Địa chỉ tại: Lầu 8, Tòa nhà Jabes 1, số 244 đường Cống Quỳnh, Phường Phạm Ngũ Lão, Quận 1, TP Hồ Chí Minh Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Ẩm thực",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-15),
                UpdatedAt
             = DateTime.Now.AddDays(-15)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 191,
                Name = "Công Ty TNHH Điện Máy Aqua Việt Nam",
                TaxCode = "3600257517",
                ClientCode = "AQUA",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850511",
                Address = "Số 8, đường 17A, KCN Biên Hòa 2, Phường An Bình, Thành phố Biên Hoà, Tỉnh Đồng Nai, Việt Nam",
                Career = "Tiêu dùng",
                Email = "MrTan@gmail.com",
                PointOfContact = "Mr Tân",
                Position = "Giam đốc MKT & Sales",
                Description = "Công Ty TNHH Điện Máy Aqua Việt Nam có mã số thuế 3600257517. Địa chỉ tại: Số 8, đường 17A, KCN Biên Hòa 2, Phường An Bình, Thành phố Biên Hoà, Tỉnh Đồng Nai, Việt Nam Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Tiêu dùng",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-14),
                UpdatedAt
             = DateTime.Now.AddDays(-14)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 192,
                Name = "Công ty Cổ phần Bệnh viện Thẩm mỹ Kangnam Hà Nội",
                TaxCode = "106521588",
                ClientCode = "TMV Keangnam",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850512",
                Address = "190 Trường Chinh, Đống Đa, Hà Nội",
                Career = "Thẩm mỹ",
                Email = "Mr.Hai@gmail.com",
                PointOfContact = "Mr. Hải",
                Position = "TP MKT",
                Description = "Công ty Cổ phần Bệnh viện Thẩm mỹ Kangnam Hà Nội có mã số thuế 106521588. Địa chỉ tại: 190 Trường Chinh, Đống Đa, Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Thẩm mỹ",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-13),
                UpdatedAt
             = DateTime.Now.AddDays(-13)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 193,
                Name = "Công ty Cổ phần tập đoàn đầu tư Tân Hoàng Minh",
                TaxCode = "109024009",
                ClientCode = "Tân Hoàn Minh",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850513",
                Address = "24 Quang Trung, Phường Trần Hưng Đạo, Quận Hoàn Kiếm, Thành Phố Hà Nội, Việt Nam",
                Career = "bất động sản",
                Email = "MrDung@gmail.com",
                PointOfContact = "Mr Dũng",
                Position = "Phó Tổng Giam đốc",
                Description = "Công ty Cổ phần tập đoàn đầu tư Tân Hoàng Minh có mã số thuế 109024009. Địa chỉ tại: 24 Quang Trung, Phường Trần Hưng Đạo, Quận Hoàn Kiếm, Thành Phố Hà Nội, Việt Nam Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: bất động sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-12),
                UpdatedAt
             = DateTime.Now.AddDays(-12)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 194,
                Name = "Công ty Cổ phần hàng tiêu dùng Masan",
                TaxCode = "302017440",
                ClientCode = "Masan",
                ClientSource = "Công ty",
                PhoneNumber = "0989850514",
                Address = "99 Nguyễn Thị Minh Khai",
                Career = "Ẩm thực",
                Email = "Ms.Giao@gmail.com",
                PointOfContact = "Ms. Giao",
                Position = "OOH leader",
                Description = "Công ty Cổ phần hàng tiêu dùng Masan có mã số thuế 302017440. Địa chỉ tại: 99 Nguyễn Thị Minh Khai Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Ẩm thực",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-11),
                UpdatedAt
             = DateTime.Now.AddDays(-11)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 195,
                Name = "Công ty Cổ phần Cơ điện Trần Phú",
                TaxCode = "100106063",
                ClientCode = "Trần Phú",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850515",
                Address = "41 Phương Liệt, Đống Đa, Hà Nội",
                Career = "Vật liệu xây dựng",
                Email = "Mr.Thanh@gmail.com",
                PointOfContact = "Mr. Thành",
                Position = "Giám đốc Marketing",
                Description = "Công ty Cổ phần Cơ điện Trần Phú có mã số thuế 100106063. Địa chỉ tại: 41 Phương Liệt, Đống Đa, Hà Nội Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Vật liệu xây dựng",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-10),
                UpdatedAt
             = DateTime.Now.AddDays(-10)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 196,
                Name = "Công ty Cổ phần Đầu tư Nam Long",
                TaxCode = "301438936",
                ClientCode = "Nam Long",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850516",
                Address = "Số 6 Nguyễn Khắc Viện, P. Tân Phú, Quận 7, TP.HCM",
                Career = "bất động sản",
                Email = "Mr.Binh@gmail.com",
                PointOfContact = "Mr. Bình",
                Position = "Giám đốc Marketing",
                Description = "Công ty Cổ phần Đầu tư Nam Long có mã số thuế 301438936. Địa chỉ tại: Số 6 Nguyễn Khắc Viện, P. Tân Phú, Quận 7, TP.HCM Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: bất động sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-9),
                UpdatedAt
             = DateTime.Now.AddDays(-9)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 197,
                Name = "Công ty Cổ phần đầu tư Nhà và thương mại Hưng Ngân",
                TaxCode = "0102460581",
                ClientCode = "102460581",
                ClientSource = "Hotline",
                PhoneNumber = "0989850517",
                Address = "Tôn Thất Tùng",
                Career = "Bất động sản",
                Email = "Ms.Lieu@gmail.com",
                PointOfContact = "Ms. Liễu",
                Position = "CV MKT",
                Description = "Công ty Cổ phần đầu tư Nhà và thương mại Hưng Ngân có mã số thuế 0102460581. Địa chỉ tại: Tôn Thất Tùng Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bất động sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-8),
                UpdatedAt
             = DateTime.Now.AddDays(-8)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 198,
                Name = "Công ty Cổ phần Tập đoàn Ecopark",
                TaxCode = "0101395308",
                ClientCode = "101395308",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850518",
                Address = "Ecopark, Văn Giang, Hưng Yên",
                Career = "Bất động sản",
                Email = "Mr.Diep@gmail.com",
                PointOfContact = "Mr. Diệp",
                Position = "Giám đốc MKT",
                Description = "Công ty Cổ phần Tập đoàn Ecopark có mã số thuế 0101395308. Địa chỉ tại: Ecopark, Văn Giang, Hưng Yên Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bất động sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-7),
                UpdatedAt
             = DateTime.Now.AddDays(-7)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 199,
                Name = "Công Ty TNHH Yamaha Motor Việt Nam",
                TaxCode = "100774342",
                ClientCode = "Yamaha Motor",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850519",
                Address = "Thôn Bình An, Xã Trung Giã, Huyện Sóc Sơn, Thành Phố Hà Nội, Việt Nam",
                Career = "Ô tô xe máy",
                Email = "MrLam@gmail.com",
                PointOfContact = "Mr Lâm",
                Position = "Giam đốc MKT",
                Description = "Công Ty TNHH Yamaha Motor Việt Nam có mã số thuế 100774342. Địa chỉ tại: Thôn Bình An, Xã Trung Giã, Huyện Sóc Sơn, Thành Phố Hà Nội, Việt Nam Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Ô tô xe máy",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-6),
                UpdatedAt
             = DateTime.Now.AddDays(-6)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 200,
                Name = "TNG Holdings",
                TaxCode = "0106684712",
                ClientCode = "106684712",
                ClientSource = "Công ty",
                PhoneNumber = "0989850520",
                Address = "54 Nguyễn Chí Thanh",
                Career = "Bất động sản",
                Email = "Ms.Duyen@gmail.com",
                PointOfContact = "Ms. Duyên",
                Position = "Trưởng ban MKT",
                Description = "TNG Holdings có mã số thuế 0106684712. Địa chỉ tại: 54 Nguyễn Chí Thanh Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Bất động sản",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-5),
                UpdatedAt
             = DateTime.Now.AddDays(-5)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 201,
                Name = "Công ty TNHH Panasonic Việt Nam",
                TaxCode = "0101824243",
                ClientCode = "101824243",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850521",
                Address = "117 Trần Duy Hưng",
                Career = "Điện máy",
                Email = "Ms.Huyen@gmail.com",
                PointOfContact = "Ms. Huyền",
                Position = "Giám đốc Marketing",
                Description = "Công ty TNHH Panasonic Việt Nam có mã số thuế 0101824243. Địa chỉ tại: 117 Trần Duy Hưng Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Điện máy",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-4),
                UpdatedAt
             = DateTime.Now.AddDays(-4)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 202,
                Name = "Công ty TNHH Nestle Việt Nam",
                TaxCode = "3600235305",
                ClientCode = "3600235305",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850522",
                Address = "Lầu 5, Empress Tower, 138 – 142 Hai Bà Trưng, Phường Đa Kao, Quận 1, Tp.Hồ Chí Minh",
                Career = "Ẩm thực",
                Email = "Ms.Uyen@gmail.com",
                PointOfContact = "Ms. Uyên",
                Position = "Trưởng nhãn Milo",
                Description = "Công ty TNHH Nestle Việt Nam có mã số thuế 3600235305. Địa chỉ tại: Lầu 5, Empress Tower, 138 – 142 Hai Bà Trưng, Phường Đa Kao, Quận 1, Tp.Hồ Chí Minh Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Ẩm thực",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-3),
                UpdatedAt
             = DateTime.Now.AddDays(-3)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 203,
                Name = "Ngân hàng TMCP Sài Gòn Thương Tín",
                TaxCode = "301103908",
                ClientCode = "301103908",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850523",
                Address = "66 Nam Kỳ Khởi Nghĩa",
                Career = "Ngân hàng",
                Email = "Ms.KimLan@gmail.com",
                PointOfContact = "Ms. Kim Lan",
                Position = "Phó trưởng ban truyền thông",
                Description = "Ngân hàng TMCP Sài Gòn Thương Tín có mã số thuế 301103908. Địa chỉ tại: 66 Nam Kỳ Khởi Nghĩa Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Ngân hàng",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-2),
                UpdatedAt
             = DateTime.Now.AddDays(-2)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 204,
                Name = "Công Ty Cổ Phần Công Nghệ Vi Mô",
                TaxCode = "106393463",
                ClientCode = "Nextpay",
                ClientSource = "Tự khai thác",
                PhoneNumber = "0989850524",
                Address = "Tầng 12A, tòa nhà VTC Online, Số 18, đường Tam Trinh, Phường Minh Khai, Quận Hai Bà Trưng, Thành phố Hà Nội Nguồn: https://www.thongtincongty.com/company/3f812ca1-cong-ty-co-phan-cong-nghe-vi-mo/#ixzz6ko3EYNr3",
                Career = "Ngân hàng",
                Email = "Mr.Cuong@gmail.com",
                PointOfContact = "Mr. Cường",
                Position = "Giám đốc MKT",
                Description = "Công Ty Cổ Phần Công Nghệ Vi Mô có mã số thuế 106393463. Địa chỉ tại: Tầng 12A, tòa nhà VTC Online, Số 18, đường Tam Trinh, Phường Minh Khai, Quận Hai Bà Trưng, Thành phố Hà Nội Nguồn: https://www.thongtincongty.com/company/3f812ca1-cong-ty-co-phan-cong-nghe-vi-mo/#ixzz6ko3EYNr3 Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Ngân hàng",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-1),
                UpdatedAt
             = DateTime.Now.AddDays(-1)
            ,
            });
            context.Clients.AddOrUpdate(new Client()
            {
                Id = 205,
                Name = "LOGIVAN",
                TaxCode = "9876543",
                ClientCode = "LOGIVAN",
                ClientSource = "Hotline",
                PhoneNumber = "0989850525",
                Address = "91 NCT",
                Career = "Logistics",
                Email = "PhamThiA@gmail.com",
                PointOfContact = "Phạm Thị A",
                Position = "Giám đốc",
                Description = "LOGIVAN có mã số thuế 9876543. Địa chỉ tại: 91 NCT Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: Logistics",
                Status = ClientStatus.Active,
                CreatedAt = DateTime.Now.AddDays(0),
                UpdatedAt
             = DateTime.Now.AddDays(0),
            });
            context.SaveChanges();
            //____________________Contact______________________
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 1,
                Name = "Vũ Đức Vương",
                PhoneNumber = "0963287596",
                Email = "VuDucVuong@gmail.com",
                CompanyName = "Công ty Cổ phần Tập đoàn Masterise",
                Description = "Vũ Đức Vương Là nhân viên của Công ty Cổ phần Tập đoàn Masterise Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-204),
                UpdatedAt
             = DateTime.Now.AddDays(-204)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 2,
                Name = "Vũ Đức Sơn",
                PhoneNumber = "0963287597",
                Email = "VuDucSon@gmail.com",
                CompanyName = "Công ty cổ phần XNK Van vòi Minh Hòa",
                Description = "Vũ Đức Sơn Là nhân viên của Công ty cổ phần XNK Van vòi Minh Hòa Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-203),
                UpdatedAt
             = DateTime.Now.AddDays(-203)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 3,
                Name = "Nguyễn Huy Hoàng",
                PhoneNumber = "0963287598",
                Email = "NguyenHuyHoang@gmail.com",
                CompanyName = "Tập Đoàn An Phát Holdings",
                Description = "Nguyễn Huy Hoàng Là nhân viên của Tập Đoàn An Phát Holdings Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-202),
                UpdatedAt
             = DateTime.Now.AddDays(-202)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 4,
                Name = "Nguyễn Thanh Bình",
                PhoneNumber = "0963287599",
                Email = "NguyenThanhBinh@gmail.com",
                CompanyName = "Công Ty Cổ Phần Amaccao",
                Description = "Nguyễn Thanh Bình Là nhân viên của Công Ty Cổ Phần Amaccao Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-201),
                UpdatedAt
             = DateTime.Now.AddDays(-201)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 5,
                Name = "Phạm Duy Đoán",
                PhoneNumber = "0963287600",
                Email = "PhamDuyDoan@gmail.com",
                CompanyName = "Công Ty Cổ Phần Đầu Tư Phát Triển Bất Động Sản Tnr Holdings Việt Nam",
                Description = "Phạm Duy Đoán Là nhân viên của Công Ty Cổ Phần Đầu Tư Phát Triển Bất Động Sản Tnr Holdings Việt Nam Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-200),
                UpdatedAt
             = DateTime.Now.AddDays(-200)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 6,
                Name = "Vũ Thanh Giang",
                PhoneNumber = "0963287601",
                Email = "VuThanhGiang@gmail.com",
                CompanyName = "Ngân Hàng Thương Mại Cổ Phần Đại Chúng Việt Nam",
                Description = "Vũ Thanh Giang Là nhân viên của Ngân Hàng Thương Mại Cổ Phần Đại Chúng Việt Nam Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-199),
                UpdatedAt
             = DateTime.Now.AddDays(-199)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 7,
                Name = "Trần Thị Thanh Phương",
                PhoneNumber = "0963287602",
                Email = "TranThiThanhPhuong@gmail.com",
                CompanyName = "Công ty TNHH Thương mại Dịch vụ Tân Huyền Phát",
                Description = "Trần Thị Thanh Phương Là nhân viên của Công ty TNHH Thương mại Dịch vụ Tân Huyền Phát Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-198),
                UpdatedAt
             = DateTime.Now.AddDays(-198)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 8,
                Name = "Lê Minh Ngọc",
                PhoneNumber = "0963287603",
                Email = "LeMinhNgoc@gmail.com",
                CompanyName = "Công ty TNHH Điện thoại Petro Electricity Viêt Nam",
                Description = "Lê Minh Ngọc Là nhân viên của Công ty TNHH Điện thoại Petro Electricity Viêt Nam Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-197),
                UpdatedAt
             = DateTime.Now.AddDays(-197)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 9,
                Name = "Hà Văn Thế",
                PhoneNumber = "0963287604",
                Email = "HaVanThe@gmail.com",
                CompanyName = "Công Ty TNHH Tập Đoàn Đầu Tư Châu Á",
                Description = "Hà Văn Thế Là nhân viên của Công Ty TNHH Tập Đoàn Đầu Tư Châu Á Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-196),
                UpdatedAt
             = DateTime.Now.AddDays(-196)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 10,
                Name = "Nguyễn Văn Ngọc",
                PhoneNumber = "0963287605",
                Email = "NguyenVanNgoc@gmail.com",
                CompanyName = "Công Ty TNHH Nguyên Linh Lâm Thao",
                Description = "Nguyễn Văn Ngọc Là nhân viên của Công Ty TNHH Nguyên Linh Lâm Thao Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-195),
                UpdatedAt
             = DateTime.Now.AddDays(-195)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 11,
                Name = "Nguyễn Thị Hằng Nga",
                PhoneNumber = "0963287606",
                Email = "NguyenThiHangNga@gmail.com",
                CompanyName = "Công Ty TNHH Nguyên Linh Lâm Thao",
                Description = "Nguyễn Thị Hằng Nga Là nhân viên của Công Ty TNHH Nguyên Linh Lâm Thao Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-194),
                UpdatedAt
             = DateTime.Now.AddDays(-194)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 12,
                Name = "Nguyễn Thị Lệ",
                PhoneNumber = "0963287607",
                Email = "NguyenThiLe@gmail.com",
                CompanyName = "Công Ty TNHH Ferroli Asean",
                Description = "Nguyễn Thị Lệ Là nhân viên của Công Ty TNHH Ferroli Asean Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-193),
                UpdatedAt
             = DateTime.Now.AddDays(-193)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 13,
                Name = "Bùi Minh Tuấn",
                PhoneNumber = "0963287608",
                Email = "BuiMinhTuan@gmail.com",
                CompanyName = "Công Ty Cổ Phần Y Dược Phẩm Vimedimex",
                Description = "Bùi Minh Tuấn Là nhân viên của Công Ty Cổ Phần Y Dược Phẩm Vimedimex Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-192),
                UpdatedAt
             = DateTime.Now.AddDays(-192)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 14,
                Name = "Nguyễn Mạnh Tuấn",
                PhoneNumber = "0963287609",
                Email = "NguyenManhTuan@gmail.com",
                CompanyName = "ông ty Cổ phần Đầu tư và Phát triển hạ tầng PPC An Thịnh Việt Nam",
                Description = "Nguyễn Mạnh Tuấn Là nhân viên của ông ty Cổ phần Đầu tư và Phát triển hạ tầng PPC An Thịnh Việt Nam Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-191),
                UpdatedAt
             = DateTime.Now.AddDays(-191)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 15,
                Name = "Đỗ Đôn Duy",
                PhoneNumber = "0963287610",
                Email = "DoDonDuy@gmail.com",
                CompanyName = "Công Ty Cổ Phần Tập Đoàn Avland Việt Nam",
                Description = "Đỗ Đôn Duy Là nhân viên của Công Ty Cổ Phần Tập Đoàn Avland Việt Nam Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-190),
                UpdatedAt
             = DateTime.Now.AddDays(-190)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 16,
                Name = "Trần Hải Yến",
                PhoneNumber = "0963287611",
                Email = "TranHaiYen@gmail.com",
                CompanyName = "Văn Phú Invest",
                Description = "Trần Hải Yến Là nhân viên của Văn Phú Invest Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-189),
                UpdatedAt
             = DateTime.Now.AddDays(-189)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 17,
                Name = "Ngô Xuân Chuyên",
                PhoneNumber = "0963287612",
                Email = "NgoXuanChuyen@gmail.com",
                CompanyName = "Công Ty CP Thực Phẩm Xuất Khẩu Đồng Giao",
                Description = "Ngô Xuân Chuyên Là nhân viên của Công Ty CP Thực Phẩm Xuất Khẩu Đồng Giao Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-188),
                UpdatedAt
             = DateTime.Now.AddDays(-188)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 18,
                Name = "Nguyễn Thanh Huyền",
                PhoneNumber = "0963287613",
                Email = "NguyenThanhHuyen@gmail.com",
                CompanyName = "Tập đoàn Công nghiệp – Viễn thông Quân đội (Viettel)",
                Description = "Nguyễn Thanh Huyền Là nhân viên của Tập đoàn Công nghiệp – Viễn thông Quân đội (Viettel) Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-187),
                UpdatedAt
             = DateTime.Now.AddDays(-187)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 19,
                Name = "Nguyễn Văn Dương",
                PhoneNumber = "0963287614",
                Email = "NguyenVanDuong@gmail.com",
                CompanyName = "Công Ty TNHH Cg Food",
                Description = "Nguyễn Văn Dương Là nhân viên của Công Ty TNHH Cg Food Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-186),
                UpdatedAt
             = DateTime.Now.AddDays(-186)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 20,
                Name = "Đỗ Thế Linh",
                PhoneNumber = "0963287615",
                Email = "DoTheLinh@gmail.com",
                CompanyName = "Công ty cổ phần Mutosi",
                Description = "Đỗ Thế Linh Là nhân viên của Công ty cổ phần Mutosi Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-185),
                UpdatedAt
             = DateTime.Now.AddDays(-185)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 21,
                Name = "Trịnh Thị Dung",
                PhoneNumber = "0963287616",
                Email = "TrinhThiDung@gmail.com",
                CompanyName = "Tập đoàn Xăng dầu Việt Nam",
                Description = "Trịnh Thị Dung Là nhân viên của Tập đoàn Xăng dầu Việt Nam Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-184),
                UpdatedAt
             = DateTime.Now.AddDays(-184)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 22,
                Name = "Nguyễn Thị Lan Anh",
                PhoneNumber = "0963287617",
                Email = "NguyenThiLanAnh@gmail.com",
                CompanyName = "Công ty Cổ phần Tập đoàn C.E.O",
                Description = "Nguyễn Thị Lan Anh Là nhân viên của Công ty Cổ phần Tập đoàn C.E.O Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-183),
                UpdatedAt
             = DateTime.Now.AddDays(-183)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 23,
                Name = "Lê Quang Thắng",
                PhoneNumber = "0963287618",
                Email = "LeQuangThang@gmail.com",
                CompanyName = "Công ty TNHH phát triển công nghệ Thái Sơn",
                Description = "Lê Quang Thắng Là nhân viên của Công ty TNHH phát triển công nghệ Thái Sơn Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-182),
                UpdatedAt
             = DateTime.Now.AddDays(-182)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 24,
                Name = "Lê Duy Lộc",
                PhoneNumber = "0963287619",
                Email = "LeDuyLoc@gmail.com",
                CompanyName = "Công ty HONDA Việt Nam",
                Description = "Lê Duy Lộc Là nhân viên của Công ty HONDA Việt Nam Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-181),
                UpdatedAt
             = DateTime.Now.AddDays(-181)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 25,
                Name = "Nguyễn Quân",
                PhoneNumber = "0963287620",
                Email = "NguyenQuan@gmail.com",
                CompanyName = "Công ty Cổ phần Đầu tư An Lạc",
                Description = "Nguyễn Quân Là nhân viên của Công ty Cổ phần Đầu tư An Lạc Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-180),
                UpdatedAt
             = DateTime.Now.AddDays(-180)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 26,
                Name = "Chia Quang Chiêu",
                PhoneNumber = "0963287621",
                Email = "ChiaQuangChieu@gmail.com",
                CompanyName = "Công Ty TNHH Odk Mikazuki Việt Na",
                Description = "Chia Quang Chiêu Là nhân viên của Công Ty TNHH Odk Mikazuki Việt Na Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-179),
                UpdatedAt
             = DateTime.Now.AddDays(-179)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 27,
                Name = "Nguyễn Văn Vui",
                PhoneNumber = "0963287622",
                Email = "NguyenVanVui@gmail.com",
                CompanyName = "Công ty Cổ phần BĐS Khải Hoàn Land",
                Description = "Nguyễn Văn Vui Là nhân viên của Công ty Cổ phần BĐS Khải Hoàn Land Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-178),
                UpdatedAt
             = DateTime.Now.AddDays(-178)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 28,
                Name = "Đoàn Văn Cường",
                PhoneNumber = "0963287623",
                Email = "DoanVanCuong@gmail.com",
                CompanyName = "Công ty Cổ phần Tập đoàn Hà Đô",
                Description = "Đoàn Văn Cường Là nhân viên của Công ty Cổ phần Tập đoàn Hà Đô Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-177),
                UpdatedAt
             = DateTime.Now.AddDays(-177)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 29,
                Name = "Ma Đào Chức",
                PhoneNumber = "0963287624",
                Email = "MaDaoChuc@gmail.com",
                CompanyName = "Công ty TNHH Panasonic Việt Nam",
                Description = "Ma Đào Chức Là nhân viên của Công ty TNHH Panasonic Việt Nam Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-176),
                UpdatedAt
             = DateTime.Now.AddDays(-176)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 30,
                Name = "Hoàng Minh Thành",
                PhoneNumber = "0963287625",
                Email = "HoangMinhThanh@gmail.com",
                CompanyName = "CÔNG TY CỔ PHẦN ĐẦU TƯ TNG HOLDINGS VIỆT NAM",
                Description = "Hoàng Minh Thành Là nhân viên của CÔNG TY CỔ PHẦN ĐẦU TƯ TNG HOLDINGS VIỆT NAM Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-175),
                UpdatedAt
             = DateTime.Now.AddDays(-175)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 31,
                Name = "Vũ Mạnh Trường",
                PhoneNumber = "0963287626",
                Email = "VuManhTruong@gmail.com",
                CompanyName = "Công ty Cổ phần Đạt Phương",
                Description = "Vũ Mạnh Trường Là nhân viên của Công ty Cổ phần Đạt Phương Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-174),
                UpdatedAt
             = DateTime.Now.AddDays(-174)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 32,
                Name = "Nghiêm Văn Toàn",
                PhoneNumber = "0963287627",
                Email = "NghiemVanToan@gmail.com",
                CompanyName = "Công Ty Cổ Phần Vicostone",
                Description = "Nghiêm Văn Toàn Là nhân viên của Công Ty Cổ Phần Vicostone Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-173),
                UpdatedAt
             = DateTime.Now.AddDays(-173)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 33,
                Name = "Phạm Thanh An",
                PhoneNumber = "0963287628",
                Email = "PhamThanhAn@gmail.com",
                CompanyName = "Công Ty TNHH Tập Đoàn Bim",
                Description = "Phạm Thanh An Là nhân viên của Công Ty TNHH Tập Đoàn Bim Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-172),
                UpdatedAt
             = DateTime.Now.AddDays(-172)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 34,
                Name = "Trần Hải Giang",
                PhoneNumber = "0963287629",
                Email = "TranHaiGiang@gmail.com",
                CompanyName = "Công ty cổ phần tập đoàn Danko",
                Description = "Trần Hải Giang Là nhân viên của Công ty cổ phần tập đoàn Danko Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-171),
                UpdatedAt
             = DateTime.Now.AddDays(-171)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 35,
                Name = "Vũ Đức Hiển",
                PhoneNumber = "0963287630",
                Email = "VuDucHien@gmail.com",
                CompanyName = "Công ty Cổ phần Địa ốc Châu Á Thái Bình Dương Group",
                Description = "Vũ Đức Hiển Là nhân viên của Công ty Cổ phần Địa ốc Châu Á Thái Bình Dương Group Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-170),
                UpdatedAt
             = DateTime.Now.AddDays(-170)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 36,
                Name = "Hoàng Ngọc Nhiện",
                PhoneNumber = "0963287631",
                Email = "HoangNgocNhien@gmail.com",
                CompanyName = "Công ty Cổ phần Đầu tư và phát triển Bất động sản Peakhomes",
                Description = "Hoàng Ngọc Nhiện Là nhân viên của Công ty Cổ phần Đầu tư và phát triển Bất động sản Peakhomes Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-169),
                UpdatedAt
             = DateTime.Now.AddDays(-169)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 37,
                Name = "Nguyễn Văn Cường",
                PhoneNumber = "0963287632",
                Email = "NguyenVanCuong@gmail.com",
                CompanyName = "Công Ty Cổ Phần Acecook Việt Nam",
                Description = "Nguyễn Văn Cường Là nhân viên của Công Ty Cổ Phần Acecook Việt Nam Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-168),
                UpdatedAt
             = DateTime.Now.AddDays(-168)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 38,
                Name = "Vũ Đức Quỳnh",
                PhoneNumber = "0963287633",
                Email = "VuDucQuynh@gmail.com",
                CompanyName = "Chi Nhánh Công Ty TNHH Nhà Nước Một Thành Viên Thương Mại Và Xuất Nhập Khẩu Viettel (Viettel Store)",
                Description = "Vũ Đức Quỳnh Là nhân viên của Chi Nhánh Công Ty TNHH Nhà Nước Một Thành Viên Thương Mại Và Xuất Nhập Khẩu Viettel (Viettel Store) Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-167),
                UpdatedAt
             = DateTime.Now.AddDays(-167)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 39,
                Name = "Dương Thị Trang",
                PhoneNumber = "0963287634",
                Email = "DuongThiTrang@gmail.com",
                CompanyName = "ACECOOK",
                Description = "Dương Thị Trang Là nhân viên của ACECOOK Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-166),
                UpdatedAt
             = DateTime.Now.AddDays(-166)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 40,
                Name = "Nguyễn Thị Thúy Hằng",
                PhoneNumber = "0963287635",
                Email = "NguyenThiThuyHang@gmail.com",
                CompanyName = "THE GOLDEN GATE",
                Description = "Nguyễn Thị Thúy Hằng Là nhân viên của THE GOLDEN GATE Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-165),
                UpdatedAt
             = DateTime.Now.AddDays(-165)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 41,
                Name = "Đặng Thị Quỳnh Trang",
                PhoneNumber = "0963287636",
                Email = "DangThiQuynhTrang@gmail.com",
                CompanyName = "THE COFFEE HOUSE",
                Description = "Đặng Thị Quỳnh Trang Là nhân viên của THE COFFEE HOUSE Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-164),
                UpdatedAt
             = DateTime.Now.AddDays(-164)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 42,
                Name = "Lê Thị Khánh Thiên",
                PhoneNumber = "0963287637",
                Email = "LeThiKhanhThien@gmail.com",
                CompanyName = "TAXI GROUP",
                Description = "Lê Thị Khánh Thiên Là nhân viên của TAXI GROUP Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-163),
                UpdatedAt
             = DateTime.Now.AddDays(-163)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 43,
                Name = "Lê Văn Bằng",
                PhoneNumber = "0963287638",
                Email = "LeVanBang@gmail.com",
                CompanyName = "KH 014",
                Description = "Lê Văn Bằng Là nhân viên của KH 014 Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-162),
                UpdatedAt
             = DateTime.Now.AddDays(-162)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 44,
                Name = "Đỗ Văn Tuyên",
                PhoneNumber = "0963287639",
                Email = "DoVanTuyen@gmail.com",
                CompanyName = "TÂN Á ĐẠI THÀNH",
                Description = "Đỗ Văn Tuyên Là nhân viên của TÂN Á ĐẠI THÀNH Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-161),
                UpdatedAt
             = DateTime.Now.AddDays(-161)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 45,
                Name = "Bùi Thị Liễu",
                PhoneNumber = "0963287640",
                Email = "BuiThiLieu@gmail.com",
                CompanyName = "HEINEKEN",
                Description = "Bùi Thị Liễu Là nhân viên của HEINEKEN Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-160),
                UpdatedAt
             = DateTime.Now.AddDays(-160)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 46,
                Name = "Vũ Thị Hiền",
                PhoneNumber = "0963287641",
                Email = "VuThiHien@gmail.com",
                CompanyName = "VIETNAM AIRLINES",
                Description = "Vũ Thị Hiền Là nhân viên của VIETNAM AIRLINES Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-159),
                UpdatedAt
             = DateTime.Now.AddDays(-159)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 47,
                Name = "Vũ Thị Giang",
                PhoneNumber = "0963287642",
                Email = "VuThiGiang@gmail.com",
                CompanyName = "K+",
                Description = "Vũ Thị Giang Là nhân viên của K+ Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-158),
                UpdatedAt
             = DateTime.Now.AddDays(-158)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 48,
                Name = "Phan Thị Ngọc",
                PhoneNumber = "0963287643",
                Email = "PhanThiNgoc@gmail.com",
                CompanyName = "THẾ GIỚI DI ĐỘNG",
                Description = "Phan Thị Ngọc Là nhân viên của THẾ GIỚI DI ĐỘNG Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-157),
                UpdatedAt
             = DateTime.Now.AddDays(-157)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 49,
                Name = "Vũ Thị Hà",
                PhoneNumber = "0963287644",
                Email = "VuThiHa@gmail.com",
                CompanyName = "M25",
                Description = "Vũ Thị Hà Là nhân viên của M25 Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-156),
                UpdatedAt
             = DateTime.Now.AddDays(-156)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 50,
                Name = "Vũ Thị Nguyên",
                PhoneNumber = "0963287645",
                Email = "VuThiNguyen@gmail.com",
                CompanyName = "KNOSS",
                Description = "Vũ Thị Nguyên Là nhân viên của KNOSS Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-155),
                UpdatedAt
             = DateTime.Now.AddDays(-155)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 51,
                Name = "Bùi Hải Uyên Ly",
                PhoneNumber = "0963287646",
                Email = "BuiHaiUyenLy@gmail.com",
                CompanyName = "IVYMODA",
                Description = "Bùi Hải Uyên Ly Là nhân viên của IVYMODA Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-154),
                UpdatedAt
             = DateTime.Now.AddDays(-154)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 52,
                Name = "Nguyễn Cửu Quốc Việt",
                PhoneNumber = "0963287647",
                Email = "NguyenCuuQuocViet@gmail.com",
                CompanyName = "CẦU DẤT",
                Description = "Nguyễn Cửu Quốc Việt Là nhân viên của CẦU DẤT Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-153),
                UpdatedAt
             = DateTime.Now.AddDays(-153)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 53,
                Name = "Phan Thanh Long",
                PhoneNumber = "0963287648",
                Email = "PhanThanhLong@gmail.com",
                CompanyName = "TIKI",
                Description = "Phan Thanh Long Là nhân viên của TIKI Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-152),
                UpdatedAt
             = DateTime.Now.AddDays(-152)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 54,
                Name = "Huỳnh Hữu Thắng",
                PhoneNumber = "0963287649",
                Email = "HuynhHuuThang@gmail.com",
                CompanyName = "LAZADA",
                Description = "Huỳnh Hữu Thắng Là nhân viên của LAZADA Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-151),
                UpdatedAt
             = DateTime.Now.AddDays(-151)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 55,
                Name = "Nguyễn Thành Chiến",
                PhoneNumber = "0963287650",
                Email = "NguyenThanhChien@gmail.com",
                CompanyName = "TOYOTA",
                Description = "Nguyễn Thành Chiến Là nhân viên của TOYOTA Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-150),
                UpdatedAt
             = DateTime.Now.AddDays(-150)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 56,
                Name = "Trần Ngũ Châu",
                PhoneNumber = "0963287651",
                Email = "TranNguChau@gmail.com",
                CompanyName = "HONDA",
                Description = "Trần Ngũ Châu Là nhân viên của HONDA Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-149),
                UpdatedAt
             = DateTime.Now.AddDays(-149)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 57,
                Name = "Nguyễn Văn Hoan",
                PhoneNumber = "0963287652",
                Email = "NguyenVanHoan@gmail.com",
                CompanyName = "CÔNG TY CỔ PHẦN PHÁT TRIỂN NÔNG NGHIỆP GFS VIỆT NAM",
                Description = "Nguyễn Văn Hoan Là nhân viên của CÔNG TY CỔ PHẦN PHÁT TRIỂN NÔNG NGHIỆP GFS VIỆT NAM Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-148),
                UpdatedAt
             = DateTime.Now.AddDays(-148)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 58,
                Name = "Nguyễn Thị Huyền Trang",
                PhoneNumber = "0963287653",
                Email = "NguyenThiHuyenTrang@gmail.com",
                CompanyName = "Công Ty Cổ Phần Tập Đoàn Thế Kỷ CEN GROUP .,JSC",
                Description = "Nguyễn Thị Huyền Trang Là nhân viên của Công Ty Cổ Phần Tập Đoàn Thế Kỷ CEN GROUP .,JSC Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-147),
                UpdatedAt
             = DateTime.Now.AddDays(-147)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 59,
                Name = "Nguyễn Thanh Đạt",
                PhoneNumber = "0963287654",
                Email = "NguyenThanhDat@gmail.com",
                CompanyName = "LoLO La LA",
                Description = "Nguyễn Thanh Đạt Là nhân viên của LoLO La LA Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-146),
                UpdatedAt
             = DateTime.Now.AddDays(-146)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 60,
                Name = "Ngô Phương Linh",
                PhoneNumber = "0963287655",
                Email = "NgoPhuongLinh@gmail.com",
                CompanyName = "TẬP ĐOÀN ĐẦU TƯ BẤT ĐỘNG SẢN, GIÁO DỤC, KẾT NỐI ĐẦU TƯ QUỐC TẾ IDJ (IDJ GROUP)",
                Description = "Ngô Phương Linh Là nhân viên của TẬP ĐOÀN ĐẦU TƯ BẤT ĐỘNG SẢN, GIÁO DỤC, KẾT NỐI ĐẦU TƯ QUỐC TẾ IDJ (IDJ GROUP) Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-145),
                UpdatedAt
             = DateTime.Now.AddDays(-145)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 61,
                Name = "Trần Anh Tuấn",
                PhoneNumber = "0963287656",
                Email = "TranAnhTuan@gmail.com",
                CompanyName = "CÔNG TY TNHH CÔNG NGHIỆP NẶNG DOOSAN VIỆT NAM",
                Description = "Trần Anh Tuấn Là nhân viên của CÔNG TY TNHH CÔNG NGHIỆP NẶNG DOOSAN VIỆT NAM Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-144),
                UpdatedAt
             = DateTime.Now.AddDays(-144)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 62,
                Name = "Phạm Bích Thảo",
                PhoneNumber = "0963287657",
                Email = "PhamBichThao@gmail.com",
                CompanyName = "Công ty TNHH TM & DV Đông Hoa",
                Description = "Phạm Bích Thảo Là nhân viên của Công ty TNHH TM & DV Đông Hoa Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-143),
                UpdatedAt
             = DateTime.Now.AddDays(-143)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 63,
                Name = "Bùi Đăng Kiên",
                PhoneNumber = "0963287658",
                Email = "BuiDangKien@gmail.com",
                CompanyName = "Công ty cổ phần Dubai Paint",
                Description = "Bùi Đăng Kiên Là nhân viên của Công ty cổ phần Dubai Paint Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-142),
                UpdatedAt
             = DateTime.Now.AddDays(-142)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 64,
                Name = "Lê Thanh Huyền",
                PhoneNumber = "0963287659",
                Email = "LeThanhHuyen@gmail.com",
                CompanyName = "Công ty cổ phần Tập đoàn Tiến Bộ",
                Description = "Lê Thanh Huyền Là nhân viên của Công ty cổ phần Tập đoàn Tiến Bộ Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-141),
                UpdatedAt
             = DateTime.Now.AddDays(-141)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 65,
                Name = "Nguyễn Thị Minh Nguyệt",
                PhoneNumber = "0963287660",
                Email = "NguyenThiMinhNguyet@gmail.com",
                CompanyName = "Công ty Cổ phần tư vấn đầu tư và kinh doanh bất động sản Thành Đạt",
                Description = "Nguyễn Thị Minh Nguyệt Là nhân viên của Công ty Cổ phần tư vấn đầu tư và kinh doanh bất động sản Thành Đạt Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-140),
                UpdatedAt
             = DateTime.Now.AddDays(-140)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 66,
                Name = "Đặng Hoàng Giang",
                PhoneNumber = "0963287661",
                Email = "DangHoangGiang@gmail.com",
                CompanyName = "Công ty TNHH Tribeco Miền Bắc",
                Description = "Đặng Hoàng Giang Là nhân viên của Công ty TNHH Tribeco Miền Bắc Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-139),
                UpdatedAt
             = DateTime.Now.AddDays(-139)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 67,
                Name = "Nguyễn Anh Đức",
                PhoneNumber = "0963287662",
                Email = "NguyenAnhDuc@gmail.com",
                CompanyName = "Tổng Công ty Cổ phần Bảo hiểm Ngân hàng TMCP Công Thương Việt Nam (Bảo hiểm VietinBank - VBI)",
                Description = "Nguyễn Anh Đức Là nhân viên của Tổng Công ty Cổ phần Bảo hiểm Ngân hàng TMCP Công Thương Việt Nam (Bảo hiểm VietinBank - VBI) Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-138),
                UpdatedAt
             = DateTime.Now.AddDays(-138)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 68,
                Name = "Nguyễn Kiên Cường",
                PhoneNumber = "0963287663",
                Email = "NguyenKienCuong@gmail.com",
                CompanyName = "Công ty cổ phần TRUYỀN THÔNG & SỰ KIỆN Hoa Hồng",
                Description = "Nguyễn Kiên Cường Là nhân viên của Công ty cổ phần TRUYỀN THÔNG & SỰ KIỆN Hoa Hồng Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-137),
                UpdatedAt
             = DateTime.Now.AddDays(-137)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 69,
                Name = "Vũ Mạnh Hùng",
                PhoneNumber = "0963287664",
                Email = "VuManhHung@gmail.com",
                CompanyName = "CÔNG TY CỔ PHẦN MEDIAMART VIỆT NAM",
                Description = "Vũ Mạnh Hùng Là nhân viên của CÔNG TY CỔ PHẦN MEDIAMART VIỆT NAM Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-136),
                UpdatedAt
             = DateTime.Now.AddDays(-136)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 70,
                Name = "Nguyễn Thị Như",
                PhoneNumber = "0963287665",
                Email = "NguyenThiNhu@gmail.com",
                CompanyName = "CÔNG TY TNHH CUCKOO VINA",
                Description = "Nguyễn Thị Như Là nhân viên của CÔNG TY TNHH CUCKOO VINA Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-135),
                UpdatedAt
             = DateTime.Now.AddDays(-135)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 71,
                Name = "Nguyễn Thanh Tuấn",
                PhoneNumber = "0963287666",
                Email = "NguyenThanhTuan@gmail.com",
                CompanyName = "CÔNG TY CỔ PHẦN VIỆT NAM CATERING",
                Description = "Nguyễn Thanh Tuấn Là nhân viên của CÔNG TY CỔ PHẦN VIỆT NAM CATERING Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-134),
                UpdatedAt
             = DateTime.Now.AddDays(-134)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 72,
                Name = "Demo Admin",
                PhoneNumber = "0963287667",
                Email = "DemoAdmin@gmail.com",
                CompanyName = "CÔNG TY CỔ PHẦN TẬP ĐOÀN G",
                Description = "Demo Admin Là nhân viên của CÔNG TY CỔ PHẦN TẬP ĐOÀN G Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-133),
                UpdatedAt
             = DateTime.Now.AddDays(-133)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 73,
                Name = "Beta User",
                PhoneNumber = "0963287668",
                Email = "BetaUser@gmail.com",
                CompanyName = "CÔNG TY CỔ PHẦN VIỆT NAM CATERING",
                Description = "Beta User Là nhân viên của CÔNG TY CỔ PHẦN VIỆT NAM CATERING Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-132),
                UpdatedAt
             = DateTime.Now.AddDays(-132)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 74,
                Name = "Lâm Minh Phước",
                PhoneNumber = "0963287669",
                Email = "LamMinhPhuoc@gmail.com",
                CompanyName = "CÔNG TY CỔ PHẦN TẬP ĐOÀN G",
                Description = "Lâm Minh Phước Là nhân viên của CÔNG TY CỔ PHẦN TẬP ĐOÀN G Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-131),
                UpdatedAt
             = DateTime.Now.AddDays(-131)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 75,
                Name = "Mai Thị Thu Hương",
                PhoneNumber = "0963287670",
                Email = "MaiThiThuHuong@gmail.com",
                CompanyName = "CÔNG TY CỔ PHẦN TƯ VẤN ĐẦU TƯ THẮNG LỢI GROUP",
                Description = "Mai Thị Thu Hương Là nhân viên của CÔNG TY CỔ PHẦN TƯ VẤN ĐẦU TƯ THẮNG LỢI GROUP Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-130),
                UpdatedAt
             = DateTime.Now.AddDays(-130)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 76,
                Name = "Lê Thị Yến",
                PhoneNumber = "0963287671",
                Email = "LeThiYen@gmail.com",
                CompanyName = "CÔNG TY CỔ PHẦN DỆT LỤA NAM ĐỊNH",
                Description = "Lê Thị Yến Là nhân viên của CÔNG TY CỔ PHẦN DỆT LỤA NAM ĐỊNH Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-129),
                UpdatedAt
             = DateTime.Now.AddDays(-129)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 77,
                Name = "Nguyễn Thị Bích Phương",
                PhoneNumber = "0963287672",
                Email = "NguyenThiBichPhuong@gmail.com",
                CompanyName = "CÔNG TY CỔ PHẦN MOBICAST",
                Description = "Nguyễn Thị Bích Phương Là nhân viên của CÔNG TY CỔ PHẦN MOBICAST Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-128),
                UpdatedAt
             = DateTime.Now.AddDays(-128)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 78,
                Name = "Đỗ Thế Anh",
                PhoneNumber = "0963287673",
                Email = "DoTheAnh@gmail.com",
                CompanyName = "CÔNG TY CỔ PHẦN VEGA VIỆT NAM",
                Description = "Đỗ Thế Anh Là nhân viên của CÔNG TY CỔ PHẦN VEGA VIỆT NAM Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-127),
                UpdatedAt
             = DateTime.Now.AddDays(-127)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 79,
                Name = "Trần Thị Hường",
                PhoneNumber = "0963287674",
                Email = "TranThiHuong@gmail.com",
                CompanyName = "Công ty cổ phần vinhomes",
                Description = "Trần Thị Hường Là nhân viên của Công ty cổ phần vinhomes Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-126),
                UpdatedAt
             = DateTime.Now.AddDays(-126)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 80,
                Name = "Lê Tuấn Anh",
                PhoneNumber = "0963287675",
                Email = "LeTuanAnh@gmail.com",
                CompanyName = "Công Ty Cổ Phần Phân Bón Bình Điền",
                Description = "Lê Tuấn Anh Là nhân viên của Công Ty Cổ Phần Phân Bón Bình Điền Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-125),
                UpdatedAt
             = DateTime.Now.AddDays(-125)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 81,
                Name = "Đỗ Hữu Hiệp",
                PhoneNumber = "0963287676",
                Email = "DoHuuHiep@gmail.com",
                CompanyName = "Công Ty Cổ Phần Y Dược Phẩm Vimedimex",
                Description = "Đỗ Hữu Hiệp Là nhân viên của Công Ty Cổ Phần Y Dược Phẩm Vimedimex Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-124),
                UpdatedAt
             = DateTime.Now.AddDays(-124)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 82,
                Name = "Nguyễn Minh Trang",
                PhoneNumber = "0963287677",
                Email = "NguyenMinhTrang@gmail.com",
                CompanyName = "Công ty TNHH Asia Media partners Việt Nam",
                Description = "Nguyễn Minh Trang Là nhân viên của Công ty TNHH Asia Media partners Việt Nam Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-123),
                UpdatedAt
             = DateTime.Now.AddDays(-123)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 83,
                Name = "Đoàn Tuấn Dũng",
                PhoneNumber = "0963287678",
                Email = "DoanTuanDung@gmail.com",
                CompanyName = "ông ty Cổ phần Đầu tư và Phát triển hạ tầng PPC An Thịnh Việt Nam",
                Description = "Đoàn Tuấn Dũng Là nhân viên của ông ty Cổ phần Đầu tư và Phát triển hạ tầng PPC An Thịnh Việt Nam Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-122),
                UpdatedAt
             = DateTime.Now.AddDays(-122)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 84,
                Name = "Nguyễn Hồng Ngọc",
                PhoneNumber = "0963287679",
                Email = "NguyenHongNgoc@gmail.com",
                CompanyName = "Công Ty CP Thực Phẩm Xuất Khẩu Đồng Giao",
                Description = "Nguyễn Hồng Ngọc Là nhân viên của Công Ty CP Thực Phẩm Xuất Khẩu Đồng Giao Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-121),
                UpdatedAt
             = DateTime.Now.AddDays(-121)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 85,
                Name = "Trần Ngọc Việt",
                PhoneNumber = "0963287680",
                Email = "TranNgocViet@gmail.com",
                CompanyName = "CÔNG TY CỔ PHẦN HERBIO",
                Description = "Trần Ngọc Việt Là nhân viên của CÔNG TY CỔ PHẦN HERBIO Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-120),
                UpdatedAt
             = DateTime.Now.AddDays(-120)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 86,
                Name = "Nguyễn Thị Hương",
                PhoneNumber = "0963287681",
                Email = "NguyenThiHuong@gmail.com",
                CompanyName = "Công ty cổ phần Mutosi",
                Description = "Nguyễn Thị Hương Là nhân viên của Công ty cổ phần Mutosi Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-119),
                UpdatedAt
             = DateTime.Now.AddDays(-119)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 87,
                Name = "Nguyễn Tá Tấn",
                PhoneNumber = "0963287682",
                Email = "NguyenTaTan@gmail.com",
                CompanyName = "CÔNG TY CỔ PHẦN GONSA",
                Description = "Nguyễn Tá Tấn Là nhân viên của CÔNG TY CỔ PHẦN GONSA Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-118),
                UpdatedAt
             = DateTime.Now.AddDays(-118)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 88,
                Name = "Hoàng Tiến Quang",
                PhoneNumber = "0963287683",
                Email = "HoangTienQuang@gmail.com",
                CompanyName = "Công ty TNHH Truyền thông Note Việt Nam",
                Description = "Hoàng Tiến Quang Là nhân viên của Công ty TNHH Truyền thông Note Việt Nam Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-117),
                UpdatedAt
             = DateTime.Now.AddDays(-117)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 89,
                Name = "Nguyễn Sỹ Dũng",
                PhoneNumber = "0963287684",
                Email = "NguyenSyDung@gmail.com",
                CompanyName = "Công Ty Cổ Phần Tập Đoàn Địa Ốc Cát Tường",
                Description = "Nguyễn Sỹ Dũng Là nhân viên của Công Ty Cổ Phần Tập Đoàn Địa Ốc Cát Tường Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-116),
                UpdatedAt
             = DateTime.Now.AddDays(-116)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 90,
                Name = "Lê Quang Huy",
                PhoneNumber = "0963287685",
                Email = "LeQuangHuy@gmail.com",
                CompanyName = "Công ty cổ phần dược phẩm Nam Hà",
                Description = "Lê Quang Huy Là nhân viên của Công ty cổ phần dược phẩm Nam Hà Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-115),
                UpdatedAt
             = DateTime.Now.AddDays(-115)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 91,
                Name = "Phan Hoàng Dương",
                PhoneNumber = "0963287686",
                Email = "PhanHoangDuong@gmail.com",
                CompanyName = "Công Ty Cổ Phần Địa Ốc Kim Tinh",
                Description = "Phan Hoàng Dương Là nhân viên của Công Ty Cổ Phần Địa Ốc Kim Tinh Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-114),
                UpdatedAt
             = DateTime.Now.AddDays(-114)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 92,
                Name = "Lê Thị Bích Ngọc",
                PhoneNumber = "0963287687",
                Email = "LeThiBichNgoc@gmail.com",
                CompanyName = "Công Ty Cổ Phần Ô Tô Bắc Âu",
                Description = "Lê Thị Bích Ngọc Là nhân viên của Công Ty Cổ Phần Ô Tô Bắc Âu Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-113),
                UpdatedAt
             = DateTime.Now.AddDays(-113)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 93,
                Name = "Hoàng Đại Hiệp",
                PhoneNumber = "0963287688",
                Email = "HoangDaiHiep@gmail.com",
                CompanyName = "Công Ty Cổ Phần Greenpan",
                Description = "Hoàng Đại Hiệp Là nhân viên của Công Ty Cổ Phần Greenpan Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-112),
                UpdatedAt
             = DateTime.Now.AddDays(-112)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 94,
                Name = "Vũ Trung Hiếu",
                PhoneNumber = "0963287689",
                Email = "VuTrungHieu@gmail.com",
                CompanyName = "Công Ty Cổ Phần Đầu Tư Kỹ Thuật Berjaya Gia Thịnh (Vietlott)",
                Description = "Vũ Trung Hiếu Là nhân viên của Công Ty Cổ Phần Đầu Tư Kỹ Thuật Berjaya Gia Thịnh (Vietlott) Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-111),
                UpdatedAt
             = DateTime.Now.AddDays(-111)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 95,
                Name = "Hoàng Thị Lệ Chi",
                PhoneNumber = "0963287690",
                Email = "HoangThiLeChi@gmail.com",
                CompanyName = "Công ty Cổ phần xuất nhập khẩu và xây dựng Tân Trường Sơn",
                Description = "Hoàng Thị Lệ Chi Là nhân viên của Công ty Cổ phần xuất nhập khẩu và xây dựng Tân Trường Sơn Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-110),
                UpdatedAt
             = DateTime.Now.AddDays(-110)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 96,
                Name = "Trần Quang Mạnh",
                PhoneNumber = "0963287691",
                Email = "TranQuangManh@gmail.com",
                CompanyName = "Công Ty Cổ Phần Tập Đoàn Địa Ốc Cát Tường",
                Description = "Trần Quang Mạnh Là nhân viên của Công Ty Cổ Phần Tập Đoàn Địa Ốc Cát Tường Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-109),
                UpdatedAt
             = DateTime.Now.AddDays(-109)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 97,
                Name = "Ngô Thị Thùy Dung",
                PhoneNumber = "0963287692",
                Email = "NgoThiThuyDung@gmail.com",
                CompanyName = "Công ty cổ phần dược phẩm Nam Hà",
                Description = "Ngô Thị Thùy Dung Là nhân viên của Công ty cổ phần dược phẩm Nam Hà Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-108),
                UpdatedAt
             = DateTime.Now.AddDays(-108)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 98,
                Name = "Ngô Mai Linh",
                PhoneNumber = "0963287693",
                Email = "NgoMaiLinh@gmail.com",
                CompanyName = "Công Ty Cổ Phần Địa Ốc Kim Tinh",
                Description = "Ngô Mai Linh Là nhân viên của Công Ty Cổ Phần Địa Ốc Kim Tinh Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-107),
                UpdatedAt
             = DateTime.Now.AddDays(-107)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 99,
                Name = "Phạm Phương Anh",
                PhoneNumber = "0963287694",
                Email = "PhamPhuongAnh@gmail.com",
                CompanyName = "Công Ty Cổ Phần Ô Tô Bắc Âu",
                Description = "Phạm Phương Anh Là nhân viên của Công Ty Cổ Phần Ô Tô Bắc Âu Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-106),
                UpdatedAt
             = DateTime.Now.AddDays(-106)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 100,
                Name = "Mạc Thị Phương Thảo",
                PhoneNumber = "0963287695",
                Email = "MacThiPhuongThao@gmail.com",
                CompanyName = "Công Ty Cổ Phần Greenpan",
                Description = "Mạc Thị Phương Thảo Là nhân viên của Công Ty Cổ Phần Greenpan Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-105),
                UpdatedAt
             = DateTime.Now.AddDays(-105)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 101,
                Name = "Lê Thông Linh",
                PhoneNumber = "0963287696",
                Email = "LeThongLinh@gmail.com",
                CompanyName = "Công Ty Cổ Phần Đầu Tư Kỹ Thuật Berjaya Gia Thịnh (Vietlott)",
                Description = "Lê Thông Linh Là nhân viên của Công Ty Cổ Phần Đầu Tư Kỹ Thuật Berjaya Gia Thịnh (Vietlott) Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-104),
                UpdatedAt
             = DateTime.Now.AddDays(-104)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 102,
                Name = "Phạm Đoàn Quỳnh Như",
                PhoneNumber = "0963287697",
                Email = "PhamDoanQuynhNhu@gmail.com",
                CompanyName = "Công ty Cổ phần xuất nhập khẩu và xây dựng Tân Trường Sơn",
                Description = "Phạm Đoàn Quỳnh Như Là nhân viên của Công ty Cổ phần xuất nhập khẩu và xây dựng Tân Trường Sơn Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-103),
                UpdatedAt
             = DateTime.Now.AddDays(-103)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 103,
                Name = "Phạm Hữu Lộc",
                PhoneNumber = "0963287698",
                Email = "PhamHuuLoc@gmail.com",
                CompanyName = "Công ty cổ phần nhựa Duy Tân",
                Description = "Phạm Hữu Lộc Là nhân viên của Công ty cổ phần nhựa Duy Tân Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-102),
                UpdatedAt
             = DateTime.Now.AddDays(-102)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 104,
                Name = "Hoàng Lê Anh Quốc",
                PhoneNumber = "0963287699",
                Email = "HoangLeAnhQuoc@gmail.com",
                CompanyName = "Công ty cổ phần BASE ENTERPRISE",
                Description = "Hoàng Lê Anh Quốc Là nhân viên của Công ty cổ phần BASE ENTERPRISE Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-101),
                UpdatedAt
             = DateTime.Now.AddDays(-101)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 105,
                Name = "Nguyễn Hoàng Hải",
                PhoneNumber = "0963287700",
                Email = "NguyenHoangHai@gmail.com",
                CompanyName = "Công ty cổ phần Zion",
                Description = "Nguyễn Hoàng Hải Là nhân viên của Công ty cổ phần Zion Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-100),
                UpdatedAt
             = DateTime.Now.AddDays(-100)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 106,
                Name = "La Hùng Vĩ",
                PhoneNumber = "0963287701",
                Email = "LaHungVi@gmail.com",
                CompanyName = "Công ty cổ phần thẩm mỹ Xuân Hương",
                Description = "La Hùng Vĩ Là nhân viên của Công ty cổ phần thẩm mỹ Xuân Hương Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-99),
                UpdatedAt
             = DateTime.Now.AddDays(-99)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 107,
                Name = "Nguyễn Vũ Trường",
                PhoneNumber = "0963287702",
                Email = "NguyenVuTruong@gmail.com",
                CompanyName = "Cty TNHH Dầu nhờn Chevron",
                Description = "Nguyễn Vũ Trường Là nhân viên của Cty TNHH Dầu nhờn Chevron Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-98),
                UpdatedAt
             = DateTime.Now.AddDays(-98)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 108,
                Name = "Bùi Lê Phương Duy",
                PhoneNumber = "0963287703",
                Email = "BuiLePhuongDuy@gmail.com",
                CompanyName = "Công ty Cổ Phần Tập Đoàn Flamingo",
                Description = "Bùi Lê Phương Duy Là nhân viên của Công ty Cổ Phần Tập Đoàn Flamingo Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-97),
                UpdatedAt
             = DateTime.Now.AddDays(-97)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 109,
                Name = "Trần Thị Ngọc Huyền",
                PhoneNumber = "0963287704",
                Email = "TranThiNgocHuyen@gmail.com",
                CompanyName = "Công Ty Cổ Phần Thanh Toán G",
                Description = "Trần Thị Ngọc Huyền Là nhân viên của Công Ty Cổ Phần Thanh Toán G Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-96),
                UpdatedAt
             = DateTime.Now.AddDays(-96)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 110,
                Name = "Nguyễn Linh Quý",
                PhoneNumber = "0963287705",
                Email = "NguyenLinhQuy@gmail.com",
                CompanyName = "Công ty TNHH dầu nhờn IDEMITSU Việt Nam",
                Description = "Nguyễn Linh Quý Là nhân viên của Công ty TNHH dầu nhờn IDEMITSU Việt Nam Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-95),
                UpdatedAt
             = DateTime.Now.AddDays(-95)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 111,
                Name = "Trần Đức Tài",
                PhoneNumber = "0963287706",
                Email = "TranDucTai@gmail.com",
                CompanyName = "Công ty cổ phần thương mại Nam Á (SACOM JSC)",
                Description = "Trần Đức Tài Là nhân viên của Công ty cổ phần thương mại Nam Á (SACOM JSC) Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-94),
                UpdatedAt
             = DateTime.Now.AddDays(-94)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 112,
                Name = "Nguyễn Hữu Nghĩa",
                PhoneNumber = "0963287707",
                Email = "NguyenHuuNghia@gmail.com",
                CompanyName = "Công ty Cổ phần Tập đoàn Sơn Kova",
                Description = "Nguyễn Hữu Nghĩa Là nhân viên của Công ty Cổ phần Tập đoàn Sơn Kova Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-93),
                UpdatedAt
             = DateTime.Now.AddDays(-93)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 113,
                Name = "Phạm Hằng Vi",
                PhoneNumber = "0963287708",
                Email = "PhamHangVi@gmail.com",
                CompanyName = "Tổng công ty Dịch vụ số Viettel",
                Description = "Phạm Hằng Vi Là nhân viên của Tổng công ty Dịch vụ số Viettel Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-92),
                UpdatedAt
             = DateTime.Now.AddDays(-92)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 114,
                Name = "Trần Tấn Đạt",
                PhoneNumber = "0963287709",
                Email = "TranTanDat@gmail.com",
                CompanyName = "Công ty Cổ phần Tập đoàn Hoa Sen",
                Description = "Trần Tấn Đạt Là nhân viên của Công ty Cổ phần Tập đoàn Hoa Sen Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-91),
                UpdatedAt
             = DateTime.Now.AddDays(-91)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 115,
                Name = "Hoàng Ngọc Huy",
                PhoneNumber = "0963287710",
                Email = "HoangNgocHuy@gmail.com",
                CompanyName = "Công ty Cổ phần Đầu Tư Nam Long",
                Description = "Hoàng Ngọc Huy Là nhân viên của Công ty Cổ phần Đầu Tư Nam Long Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-90),
                UpdatedAt
             = DateTime.Now.AddDays(-90)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 116,
                Name = "Nguyễn Trung Tín",
                PhoneNumber = "0963287711",
                Email = "NguyenTrungTin@gmail.com",
                CompanyName = "Công ty Cổ phần Tập đoàn Mặt trời",
                Description = "Nguyễn Trung Tín Là nhân viên của Công ty Cổ phần Tập đoàn Mặt trời Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-89),
                UpdatedAt
             = DateTime.Now.AddDays(-89)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 117,
                Name = "Trần Phát Giàu",
                PhoneNumber = "0963287712",
                Email = "TranPhatGiau@gmail.com",
                CompanyName = "Công ty Cổ phần Tập đoàn Karofi",
                Description = "Trần Phát Giàu Là nhân viên của Công ty Cổ phần Tập đoàn Karofi Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-88),
                UpdatedAt
             = DateTime.Now.AddDays(-88)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 118,
                Name = "Nguyễn Thị Hồng Trang",
                PhoneNumber = "0963287713",
                Email = "NguyenThiHongTrang@gmail.com",
                CompanyName = "Công ty TNHH Tập đoàn Bitexco",
                Description = "Nguyễn Thị Hồng Trang Là nhân viên của Công ty TNHH Tập đoàn Bitexco Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-87),
                UpdatedAt
             = DateTime.Now.AddDays(-87)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 119,
                Name = "Nguyễn Thị Lan Phương",
                PhoneNumber = "0963287714",
                Email = "NguyenThiLanPhuong@gmail.com",
                CompanyName = "Công ty TNHH Trường Đại học Anh Quốc Việt Nam",
                Description = "Nguyễn Thị Lan Phương Là nhân viên của Công ty TNHH Trường Đại học Anh Quốc Việt Nam Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-86),
                UpdatedAt
             = DateTime.Now.AddDays(-86)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 120,
                Name = "Đàm Thị Trang",
                PhoneNumber = "0963287715",
                Email = "DamThiTrang@gmail.com",
                CompanyName = "Công ty TNHH Đầu tư DHA",
                Description = "Đàm Thị Trang Là nhân viên của Công ty TNHH Đầu tư DHA Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-85),
                UpdatedAt
             = DateTime.Now.AddDays(-85)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 121,
                Name = "Phạm Hồng Long",
                PhoneNumber = "0963287716",
                Email = "PhamHongLong@gmail.com",
                CompanyName = "Công ty sữa đậu nành Vinasoy",
                Description = "Phạm Hồng Long Là nhân viên của Công ty sữa đậu nành Vinasoy Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-84),
                UpdatedAt
             = DateTime.Now.AddDays(-84)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 122,
                Name = "Trần Thu Thủy",
                PhoneNumber = "0963287717",
                Email = "TranThuThuy@gmail.com",
                CompanyName = "Công ty Cổ phần tập đoàn Kido",
                Description = "Trần Thu Thủy Là nhân viên của Công ty Cổ phần tập đoàn Kido Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-83),
                UpdatedAt
             = DateTime.Now.AddDays(-83)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 123,
                Name = "Lê Tuyết My",
                PhoneNumber = "0963287718",
                Email = "LeTuyetMy@gmail.com",
                CompanyName = "Công Ty Tnhh Thương Mại - Dịch Vụ Tân Hiệp Phát",
                Description = "Lê Tuyết My Là nhân viên của Công Ty Tnhh Thương Mại - Dịch Vụ Tân Hiệp Phát Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-82),
                UpdatedAt
             = DateTime.Now.AddDays(-82)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 124,
                Name = "Hà Thị Hồng",
                PhoneNumber = "0963287719",
                Email = "HaThiHong@gmail.com",
                CompanyName = "Ngân Hàng Thương Mại Cổ Phần Phát Triển Thành Phố Hồ Chí Minh.",
                Description = "Hà Thị Hồng Là nhân viên của Ngân Hàng Thương Mại Cổ Phần Phát Triển Thành Phố Hồ Chí Minh. Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-81),
                UpdatedAt
             = DateTime.Now.AddDays(-81)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 125,
                Name = "Trần Hoàng Anh",
                PhoneNumber = "0963287720",
                Email = "TranHoangAnh@gmail.com",
                CompanyName = "Công Ty TNHH Một Thành Viên New Image Việt Nam",
                Description = "Trần Hoàng Anh Là nhân viên của Công Ty TNHH Một Thành Viên New Image Việt Nam Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-80),
                UpdatedAt
             = DateTime.Now.AddDays(-80)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 126,
                Name = "Lý Thị Hiếu Thục",
                PhoneNumber = "0963287721",
                Email = "LyThiHieuThuc@gmail.com",
                CompanyName = "Công Ty TNHH Red Bull (Việt Nam)",
                Description = "Lý Thị Hiếu Thục Là nhân viên của Công Ty TNHH Red Bull (Việt Nam) Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-79),
                UpdatedAt
             = DateTime.Now.AddDays(-79)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 127,
                Name = "Trần Trung Toàn",
                PhoneNumber = "0963287722",
                Email = "TranTrungToan@gmail.com",
                CompanyName = "Công ty cổ phần bất động sản Son Kim",
                Description = "Trần Trung Toàn Là nhân viên của Công ty cổ phần bất động sản Son Kim Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-78),
                UpdatedAt
             = DateTime.Now.AddDays(-78)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 128,
                Name = "Trần Thị Oanh",
                PhoneNumber = "0963287723",
                Email = "TranThiOanh@gmail.com",
                CompanyName = "Công ty TNHH Nestle Việt Nam",
                Description = "Trần Thị Oanh Là nhân viên của Công ty TNHH Nestle Việt Nam Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-77),
                UpdatedAt
             = DateTime.Now.AddDays(-77)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 129,
                Name = "Đỗ Thị Linh",
                PhoneNumber = "0963287724",
                Email = "DoThiLinh@gmail.com",
                CompanyName = "Công ty cổ phần bia - rượu - nước giải khát Sài gòn",
                Description = "Đỗ Thị Linh Là nhân viên của Công ty cổ phần bia - rượu - nước giải khát Sài gòn Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-76),
                UpdatedAt
             = DateTime.Now.AddDays(-76)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 130,
                Name = "Đỗ Khánh Linh",
                PhoneNumber = "0963287725",
                Email = "DoKhanhLinh@gmail.com",
                CompanyName = "Công ty Cổ phần Uniben",
                Description = "Đỗ Khánh Linh Là nhân viên của Công ty Cổ phần Uniben Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-75),
                UpdatedAt
             = DateTime.Now.AddDays(-75)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 131,
                Name = "Phạm Mạnh Khương",
                PhoneNumber = "0963287726",
                Email = "PhamManhKhuong@gmail.com",
                CompanyName = "Công Ty Cổ Phần Phát Triển Và Kinh Doanh Nhà",
                Description = "Phạm Mạnh Khương Là nhân viên của Công Ty Cổ Phần Phát Triển Và Kinh Doanh Nhà Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-74),
                UpdatedAt
             = DateTime.Now.AddDays(-74)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 132,
                Name = "Vũ Thị Hương Giang",
                PhoneNumber = "0963287727",
                Email = "VuThiHuongGiang@gmail.com",
                CompanyName = "Cty TNHH Y Tế Viễn Đông Việt Nam",
                Description = "Vũ Thị Hương Giang Là nhân viên của Cty TNHH Y Tế Viễn Đông Việt Nam Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-73),
                UpdatedAt
             = DateTime.Now.AddDays(-73)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 133,
                Name = "Phạm Thị Thu",
                PhoneNumber = "0963287728",
                Email = "PhamThiThu@gmail.com",
                CompanyName = "Công Ty TNHH Sơn AKZO NOBEL Việt Nam",
                Description = "Phạm Thị Thu Là nhân viên của Công Ty TNHH Sơn AKZO NOBEL Việt Nam Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-72),
                UpdatedAt
             = DateTime.Now.AddDays(-72)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 134,
                Name = "Phạm Thu Hương",
                PhoneNumber = "0963287729",
                Email = "PhamThuHuong@gmail.com",
                CompanyName = "Công ty TNHH Saint-Gobain Vietnam",
                Description = "Phạm Thu Hương Là nhân viên của Công ty TNHH Saint-Gobain Vietnam Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-71),
                UpdatedAt
             = DateTime.Now.AddDays(-71)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 135,
                Name = "Nguyễn Thanh Hải",
                PhoneNumber = "0963287730",
                Email = "NguyenThanhHai@gmail.com",
                CompanyName = "Công ty liên doanh TNHH Khu công nghiệp Việt Nam - Singapore",
                Description = "Nguyễn Thanh Hải Là nhân viên của Công ty liên doanh TNHH Khu công nghiệp Việt Nam - Singapore Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-70),
                UpdatedAt
             = DateTime.Now.AddDays(-70)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 136,
                Name = "Ao Thủy Tiên",
                PhoneNumber = "0963287731",
                Email = "AoThuyTien@gmail.com",
                CompanyName = "Công Ty Cổ Phần Vàng Bạc Đá Quý Phú Nhuận (PNJ)",
                Description = "Ao Thủy Tiên Là nhân viên của Công Ty Cổ Phần Vàng Bạc Đá Quý Phú Nhuận (PNJ) Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-69),
                UpdatedAt
             = DateTime.Now.AddDays(-69)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 137,
                Name = "Lê Anh Khoa",
                PhoneNumber = "0963287732",
                Email = "LeAnhKhoa@gmail.com",
                CompanyName = "Công ty Cổ phần Setiabecamex",
                Description = "Lê Anh Khoa Là nhân viên của Công ty Cổ phần Setiabecamex Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-68),
                UpdatedAt
             = DateTime.Now.AddDays(-68)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 138,
                Name = "Trần Thị Mỹ Hạnh",
                PhoneNumber = "0963287733",
                Email = "TranThiMyHanh@gmail.com",
                CompanyName = "Công ty Cổ phần phát triển bất động sản Filmore",
                Description = "Trần Thị Mỹ Hạnh Là nhân viên của Công ty Cổ phần phát triển bất động sản Filmore Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-67),
                UpdatedAt
             = DateTime.Now.AddDays(-67)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 139,
                Name = "Nguyễn Thị Hồng Trang",
                PhoneNumber = "0963287734",
                Email = "NguyenThiHongTrang@gmail.com",
                CompanyName = "Công ty Cổ phần tập đoàn Hưng Thịnh",
                Description = "Nguyễn Thị Hồng Trang Là nhân viên của Công ty Cổ phần tập đoàn Hưng Thịnh Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-66),
                UpdatedAt
             = DateTime.Now.AddDays(-66)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 140,
                Name = "Đỗ Thị Lan Anh",
                PhoneNumber = "0963287735",
                Email = "DoThiLanAnh@gmail.com",
                CompanyName = "Công ty Cổ phần Tập đoàn C.E.O",
                Description = "Đỗ Thị Lan Anh Là nhân viên của Công ty Cổ phần Tập đoàn C.E.O Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-65),
                UpdatedAt
             = DateTime.Now.AddDays(-65)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 141,
                Name = "Ngô Duy Tân",
                PhoneNumber = "0963287736",
                Email = "NgoDuyTan@gmail.com",
                CompanyName = "Công ty Cổ phần đầu tư Khương Thịnh",
                Description = "Ngô Duy Tân Là nhân viên của Công ty Cổ phần đầu tư Khương Thịnh Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-64),
                UpdatedAt
             = DateTime.Now.AddDays(-64)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 142,
                Name = "Mai Văn Phúc",
                PhoneNumber = "0963287737",
                Email = "MaiVanPhuc@gmail.com",
                CompanyName = "Công ty Cổ phần Tập đoàn Picenza VN",
                Description = "Mai Văn Phúc Là nhân viên của Công ty Cổ phần Tập đoàn Picenza VN Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-63),
                UpdatedAt
             = DateTime.Now.AddDays(-63)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 143,
                Name = "Nguyễn Thành Đạt",
                PhoneNumber = "0963287738",
                Email = "NguyenThanhDat@gmail.com",
                CompanyName = "Công ty TNHH phát triển công nghệ Thái Sơn",
                Description = "Nguyễn Thành Đạt Là nhân viên của Công ty TNHH phát triển công nghệ Thái Sơn Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-62),
                UpdatedAt
             = DateTime.Now.AddDays(-62)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 144,
                Name = "Nguyễn Minh Trí",
                PhoneNumber = "0963287739",
                Email = "NguyenMinhTri@gmail.com",
                CompanyName = "Công ty HONDA Việt Nam",
                Description = "Nguyễn Minh Trí Là nhân viên của Công ty HONDA Việt Nam Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-61),
                UpdatedAt
             = DateTime.Now.AddDays(-61)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 145,
                Name = "Nguyễn Thị Ngọc Huyền",
                PhoneNumber = "0963287740",
                Email = "NguyenThiNgocHuyen@gmail.com",
                CompanyName = "Công ty Cổ phần PropertyGuru Việt Nam (batdongsan.com.vn)",
                Description = "Nguyễn Thị Ngọc Huyền Là nhân viên của Công ty Cổ phần PropertyGuru Việt Nam (batdongsan.com.vn) Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-60),
                UpdatedAt
             = DateTime.Now.AddDays(-60)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 146,
                Name = "Nguyễn Văn Tiến",
                PhoneNumber = "0963287741",
                Email = "NguyenVanTien@gmail.com",
                CompanyName = "Công Ty Tnhh Phát Triển & Kinh Doanh Bất Động Sản Weland",
                Description = "Nguyễn Văn Tiến Là nhân viên của Công Ty Tnhh Phát Triển & Kinh Doanh Bất Động Sản Weland Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-59),
                UpdatedAt
             = DateTime.Now.AddDays(-59)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 147,
                Name = "Chu Duy Phương",
                PhoneNumber = "0963287742",
                Email = "ChuDuyPhuong@gmail.com",
                CompanyName = "Cty Cổ Phần IFF Holdings (IFF Holdings)",
                Description = "Chu Duy Phương Là nhân viên của Cty Cổ Phần IFF Holdings (IFF Holdings) Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-58),
                UpdatedAt
             = DateTime.Now.AddDays(-58)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 148,
                Name = "Đoàn Nam Dũng",
                PhoneNumber = "0963287743",
                Email = "DoanNamDung@gmail.com",
                CompanyName = "Công ty CP Tập đoàn Mavin",
                Description = "Đoàn Nam Dũng Là nhân viên của Công ty CP Tập đoàn Mavin Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-57),
                UpdatedAt
             = DateTime.Now.AddDays(-57)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 149,
                Name = "Hoàng Mạnh Cường",
                PhoneNumber = "0963287744",
                Email = "HoangManhCuong@gmail.com",
                CompanyName = "Công Ty TNHH Thiết Bị Và Công Nghệ Tekcom",
                Description = "Hoàng Mạnh Cường Là nhân viên của Công Ty TNHH Thiết Bị Và Công Nghệ Tekcom Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-56),
                UpdatedAt
             = DateTime.Now.AddDays(-56)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 150,
                Name = "Đoàn Duy Thành",
                PhoneNumber = "0963287745",
                Email = "DoanDuyThanh@gmail.com",
                CompanyName = "Ngân hàng Thương mại Cổ phần Bưu điện Liên Việt",
                Description = "Đoàn Duy Thành Là nhân viên của Ngân hàng Thương mại Cổ phần Bưu điện Liên Việt Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-55),
                UpdatedAt
             = DateTime.Now.AddDays(-55)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 151,
                Name = "Trần Đồng Toàn",
                PhoneNumber = "0963287746",
                Email = "TranDongToan@gmail.com",
                CompanyName = "Nhà Máy Nước Khoáng Thạch Bích",
                Description = "Trần Đồng Toàn Là nhân viên của Nhà Máy Nước Khoáng Thạch Bích Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-54),
                UpdatedAt
             = DateTime.Now.AddDays(-54)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 152,
                Name = "Hoàng Gia Sơn",
                PhoneNumber = "0963287747",
                Email = "HoangGiaSon@gmail.com",
                CompanyName = "Quỹ nhi đồng Liên Hợp Quốc",
                Description = "Hoàng Gia Sơn Là nhân viên của Quỹ nhi đồng Liên Hợp Quốc Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-53),
                UpdatedAt
             = DateTime.Now.AddDays(-53)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 153,
                Name = "Trần Thị Huệ",
                PhoneNumber = "0963287748",
                Email = "TranThiHue@gmail.com",
                CompanyName = "Công ty TNHH Thiết bị điện và chiếu sáng Châu Á",
                Description = "Trần Thị Huệ Là nhân viên của Công ty TNHH Thiết bị điện và chiếu sáng Châu Á Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-52),
                UpdatedAt
             = DateTime.Now.AddDays(-52)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 154,
                Name = "Nguyễn Thị Kim Ngân",
                PhoneNumber = "0963287749",
                Email = "NguyenThiKimNgan@gmail.com",
                CompanyName = "Công Ty Cổ Phần Tập Đoàn Austdoor",
                Description = "Nguyễn Thị Kim Ngân Là nhân viên của Công Ty Cổ Phần Tập Đoàn Austdoor Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-51),
                UpdatedAt
             = DateTime.Now.AddDays(-51)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 155,
                Name = "Vũ Đức Thanh",
                PhoneNumber = "0963287750",
                Email = "VuDucThanh@gmail.com",
                CompanyName = "Công Ty Cổ Phần Mía Đường Lam Sơn",
                Description = "Vũ Đức Thanh Là nhân viên của Công Ty Cổ Phần Mía Đường Lam Sơn Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-50),
                UpdatedAt
             = DateTime.Now.AddDays(-50)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 156,
                Name = "Lại Huy Hà",
                PhoneNumber = "0963287751",
                Email = "LaiHuyHa@gmail.com",
                CompanyName = "Ngân hàng TMCP Hàng hải Việt Nam",
                Description = "Lại Huy Hà Là nhân viên của Ngân hàng TMCP Hàng hải Việt Nam Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-49),
                UpdatedAt
             = DateTime.Now.AddDays(-49)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 157,
                Name = "Nguyễn Thị Khánh Ly",
                PhoneNumber = "0963287752",
                Email = "NguyenThiKhanhLy@gmail.com",
                CompanyName = "Công ty Cổ phần Tập đoàn Nagakawa chi nhánh Hà Nội",
                Description = "Nguyễn Thị Khánh Ly Là nhân viên của Công ty Cổ phần Tập đoàn Nagakawa chi nhánh Hà Nội Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-48),
                UpdatedAt
             = DateTime.Now.AddDays(-48)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 158,
                Name = "Bùi Thị Thu Hà",
                PhoneNumber = "0963287753",
                Email = "BuiThiThuHa@gmail.com",
                CompanyName = "Công Ty Cổ Phần Đầu Tư Bất Động Sản Taseco",
                Description = "Bùi Thị Thu Hà Là nhân viên của Công Ty Cổ Phần Đầu Tư Bất Động Sản Taseco Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-47),
                UpdatedAt
             = DateTime.Now.AddDays(-47)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 159,
                Name = "Hồ Thị Bích Tuyết",
                PhoneNumber = "0963287754",
                Email = "HoThiBichTuyet@gmail.com",
                CompanyName = "Công Ty Cổ Phần Đầu Tư Bất Động Sản Taseco",
                Description = "Hồ Thị Bích Tuyết Là nhân viên của Công Ty Cổ Phần Đầu Tư Bất Động Sản Taseco Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-46),
                UpdatedAt
             = DateTime.Now.AddDays(-46)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 160,
                Name = "Trần Đắc Hưng",
                PhoneNumber = "0963287755",
                Email = "TranDacHung@gmail.com",
                CompanyName = "Công Ty TNHH Điều Hòa Fujiaire Việt Nam",
                Description = "Trần Đắc Hưng Là nhân viên của Công Ty TNHH Điều Hòa Fujiaire Việt Nam Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-45),
                UpdatedAt
             = DateTime.Now.AddDays(-45)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 161,
                Name = "Nguyễn Trung Hiếu",
                PhoneNumber = "0963287756",
                Email = "NguyenTrungHieu@gmail.com",
                CompanyName = "Công ty TNHH bia Carlsbeg Việt Nam",
                Description = "Nguyễn Trung Hiếu Là nhân viên của Công ty TNHH bia Carlsbeg Việt Nam Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-44),
                UpdatedAt
             = DateTime.Now.AddDays(-44)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 162,
                Name = "Nguyễn Thanh Hoàng",
                PhoneNumber = "0963287757",
                Email = "NguyenThanhHoang@gmail.com",
                CompanyName = "Công ty Cổ phần FPT",
                Description = "Nguyễn Thanh Hoàng Là nhân viên của Công ty Cổ phần FPT Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-43),
                UpdatedAt
             = DateTime.Now.AddDays(-43)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 163,
                Name = "Phạm Nguyễn Anh Khôi",
                PhoneNumber = "0963287758",
                Email = "PhamNguyenAnhKhoi@gmail.com",
                CompanyName = "Công ty Cổ phần KLB",
                Description = "Phạm Nguyễn Anh Khôi Là nhân viên của Công ty Cổ phần KLB Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-42),
                UpdatedAt
             = DateTime.Now.AddDays(-42)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 164,
                Name = "Nguyễn Bích Phương",
                PhoneNumber = "0963287759",
                Email = "NguyenBichPhuong@gmail.com",
                CompanyName = "Công ty CP Nhôm Đô Thành",
                Description = "Nguyễn Bích Phương Là nhân viên của Công ty CP Nhôm Đô Thành Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-41),
                UpdatedAt
             = DateTime.Now.AddDays(-41)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 165,
                Name = "Đỗ Thị Liễu",
                PhoneNumber = "0963287760",
                Email = "DoThiLieu@gmail.com",
                CompanyName = "Công ty TNHH sản xuất thương mại Kim Hoàn Vũ",
                Description = "Đỗ Thị Liễu Là nhân viên của Công ty TNHH sản xuất thương mại Kim Hoàn Vũ Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-40),
                UpdatedAt
             = DateTime.Now.AddDays(-40)
            ,
            });
            context.Contacts.AddOrUpdate(new Contact()
            {
                Id = 166,
                Name = "Nguyễn Văn Mô",
                PhoneNumber = "0963287761",
                Email = "NguyenVanMo@gmail.com",
                CompanyName = "Công Ty Cổ Phần Chăn Nuôi C.p. Việt Nam",
                Description = "Nguyễn Văn Mô Là nhân viên của Công Ty Cổ Phần Chăn Nuôi C.p. Việt Nam Liên hệ để tìm hiểu thêm về dịch vụ.",
                Status = ContactStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-39),
                UpdatedAt
             = DateTime.Now.AddDays(-39),
            });
            context.SaveChanges();

            //____________________ Department______________________

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
            //__________________Employee__________________
            context.Employees.AddOrUpdate(new Employee()
            {
                Id = "1",
                UserName = "bangnd",
                PhoneNumber = "0912345670",
                Email = "bangnd@gmail.com",
                PasswordHash = "123456",
                Address = "Gia Lâm, Hà Nội",
                DepartmentId = 3,
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
                UserName = "banglv",
                PhoneNumber = "0912345679",
                Email = "banglv@gmail.com",
                PasswordHash = "123456",
                Address = "Gia Lâm, Hà Nội",
                DepartmentId = 1,
                Status = EmployeeStatus.Active,
                CreatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
                UpdatedAt = DateTime.Now.AddDays(new Random().Next(-10, -5)),
            });
            //____________________Product______________________
            context.Products.AddOrUpdate(new Product()
            {
                Id = 1,
                Name = "Dự án The Filmore Đà Nẵng",
                Description = "Diện tích khu đất 1.504,2 m2 với quy mô 25 tầng nổi, 3 tầng hầm và 206 căn hộ cao cấp (gồm các căn hộ 1 phòng ngủ, 2 phòng ngủ, 3 phòng ngủ - Duplex, Dual Key). Tổng diện tích sàn xây dựng hơn 22.600 m2, diện tích sàn nhà ở khoảng 12.876 m2, diện tích sàn sử dụng thương mại dịch vụ gần 300 m2. Mật độ xây dựng khối đế 55,6%, khối tháp 47,8%. Dự án dự kiến hoàn thành và bàn giao vào quý IV/2022.",
                ClientId = 1,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-204),
                UpdatedAt
             = DateTime.Now.AddDays(-204)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 2,
                Name = "Ô tô điện thông minh vf-e34",
                Description = "Thuộc phân khúc C, từng được công bố vào tháng 1/2021 với tên mã VF31. Xe có chiều dài cơ sở 2.611mm, kích thước các chiều dài x rộng x cao là 4.300 x 1.793 x 1.613 (mm), khoảng sáng gầm xe 180mm, trọng lượng không tải 1.490kg. VinFast VF e34 được trang bị một động cơ điện có công suất tối đa 110 kW ( 147 HP), mô-men xoắn cực đại 242 Nm cùng hệ dẫn động cầu trước, hệ thống treo trước MacPherson, hệ thống treo sau dạng thanh xoắn. Xe sử dụng một bộ pin dung lượng 42kWh, có thể đi được quãng đường 300km sau mỗi lần sạc đầy. Để minh chứng cho đẳng cấp, chất lượng và tạo sự an tâm cho khách hàng, VinFast tiên phong áp dụng chính sách bảo hành lên tới 10 năm cho xe VF e34",
                ClientId = 2,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-203),
                UpdatedAt
             = DateTime.Now.AddDays(-203)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 3,
                Name = "Xi măng Nghi Sơn đa dụng",
                Description = "chất lượng PCB40, được sản xuất từ công nghệ Nhật tiên tiến, chất lượng được kiểm soát bởi các chuyên gia Nhật Bản",
                ClientId = 3,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-202),
                UpdatedAt
             = DateTime.Now.AddDays(-202)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 4,
                Name = "Gạch bê tông AAC",
                Description = "Gạch bê tông AAC (viết tắt của ba từ tiếng Anh là “Aerated Autoclaved Concrete”) hay còn có tên là “gạch bê tông khí chưng áp” đây là loại vật liệu mới trong xây dựng với kết cấu bê tông gồm các bọt khí nhỏ. Mặc dù đã xuất hiện và bắt đầu sử dụng trên Thế Giới gần 1 thế kỷ trước. Tuy nhiên đến năm 2008 Việt Nam mới bắt đầu nhập khẩu và sử dụng loại vật liệu này.Đây được xem là vật liệu xanh vì có thể tái sử dụng. Được sản xuất bằng công nghệ khí chưng áp từ các nguyên liệu như cát, vôi, thạch cao, xi măng, bột nhôm và không gây ô nhiễm nên thân thiện môi trường.",
                ClientId = 4,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-201),
                UpdatedAt
             = DateTime.Now.AddDays(-201)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 5,
                Name = "Tấm panel ALC",
                Description = "ALC (Autoclaced Lightweight Aerated Concrete) hay được gọi là “Bê tông gia khí chưng áp. Tấm tường Panel được sản xuất bằng các nguyên liệu giống với nguyên liệu tạo ra sản phẩm gạch nhẹ AAC. Với khả năng chịu lực cao, tấm ALC được chế tạo bằng 2 lớp thép (thép nguội), cấu trúc không gian 3 chiều nên tạo ra một bộ khung cứng và vững chắc. Ứng dụng để làm tường, sàn, cầu thang, mái,… Có thể gia công cưa, cắt, khoan hay đóng đinh một cách đơn giản, tốn ít thời gian, quá trình lắp đặt nhanh chóng thuận tiện.",
                ClientId = 5,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-200),
                UpdatedAt
             = DateTime.Now.AddDays(-200)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 6,
                Name = "Xi măng công nghệ nano",
                Description = "Đây là sản phẩm vật liệu mới trong xây dựng nhà ở và công trình. Sản phẩm có độ cứng và độ bền vượt trội. Với công thức độc đáo đây là công nghệ vật liệu mới trong xây dựng – công nghệ độc quyền của SCG giúp cải tiến chất lượng xi măng, các phân tử xi măng tạo ra ở kích thước nano nên tạo ra liên kết vô cùng chặt chẽ nên giảm thiểu khả năng nứt, rò rỉ của công trình một trong những nguyên nhân gây ra chính là do các lỗ rỗng trong quá trình trộn bê tông tạo ra khi sử dụng xi măng cũ tiếp xúc với các tác nhân môi trường như nắng, gió, mưa,..",
                ClientId = 6,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-199),
                UpdatedAt
             = DateTime.Now.AddDays(-199)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 7,
                Name = "Tấm tường bê tông đúc sẵn",
                Description = "Ưu điểm dễ dàng thi công lắp đặt với 6m2 tường chỉ cần 3 công nhân làm việc trong 1 giờ đồng hồ nên giúp tiết kiệm nhân lực lao động. So với các loại truyền thống như tường gạch, block bê tông thì tấm tường bê tông đúc sẵn này có tuổi thọ cao hơn, giảm chi phí sử dụng vật liệu hơn do có chiều dày nhỏ hơn chỉ khoảng 68 – 140 mm nên còn giúp tiết kiệm không gian lắp đặt tăng diện tích sử dụng cho nhà ở hoặc công trình.",
                ClientId = 7,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-198),
                UpdatedAt
             = DateTime.Now.AddDays(-198)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 8,
                Name = "Gạch men và sứ vệ sinh kháng khuẩn",
                Description = "Đây là dòng sản phẩm với khả năng tự tiêu diệt vi khuẩn khi bám trên bề mặt sản phẩm. Ở nước ngoài đây là loại vật liệu chủ yếu dùng trong các cơ sở y tế và bệnh viện. Với lớp men Nano phun trực tiếp lên sản phẩm và nung ở nhiệt độ 1200 – 1250 độ C, giúp cho lớp men này trở nên siêu bền trên bề mặt, chống bám dính, ổ bẩn cũng như góp phần tăng độ nhẵn mịn bóng loáng cho sản phẩm.",
                ClientId = 8,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-197),
                UpdatedAt
             = DateTime.Now.AddDays(-197)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 9,
                Name = "METRO STAR",
                Description = "Metro Star có vị trí đắc địa ở địa chỉ 360 Xa Lộ Hà Nội, nằm trong khu dân cư đông đúc, sôi động của cửa ngõ phía Đông Sài Gòn - nơi có hai mặt tiền đường là Xa lộ Hà Nội và Nam Hòa cùng với công viên cỏ xanh  rộng rãi, thoáng đãng, đặc biệt là dự án hiếm hoi có cầu bộ hành kết nối trực tiếp từ ga Metro số 10 đi vào tầng 2 khu dân cư.Metro Star được đầu tư phát triển bởi Công ty Metro Star, trực thuộc Tổng Công ty C.T Land (thành viên Tập đoàn C.T Group - Tập đoàn đa ngành hàng đầu Việt Nam), mang đến một “siêu phẩm” độc đáo về kiến trúc, chất lượng xây dựng tiêu chuẩn Singapore và 100+ tiện ích đậm chất quốc đảo sư tử.",
                ClientId = 9,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-196),
                UpdatedAt
             = DateTime.Now.AddDays(-196)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 10,
                Name = "C.T PLAZA",
                Description = "C.T Plaza là một thương hiệu nhà ở và thương mại văn phòng rất đặc biệt, là sự kết hợp hài hòa giữa 3 đỉnh cao: Nghệ thuật của Tạo hóa là Thiên nhiên tươi đẹp, Nghệ thuật của Nhân loại là Kiến trúc, Hội họa, Âm nhạc, Phim ảnh…và đẹp hơn hết là Con người với cái đẹp của thân thể và tâm hồn…nơi con người có thể nâng cuộc sống hằng ngày lên thành Nghệ thuật sống cuộc đời (Living Art) để mỗi người hạnh phúc tuyệt vời theo cách riêng trong ngôi nhà của mình (A Life Style Home Brand).",
                ClientId = 10,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-195),
                UpdatedAt
             = DateTime.Now.AddDays(-195)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 11,
                Name = "I-HOME",
                Description = "Thương hiệu I-Home cực kỳ mới lạ và đặc biệt yêu thích bởi giới trẻ với concept rất thú vị và giá rất nice. Là sự kết hợp giữa Home và Internet trong 1 thế giới phẳng. Khu I-Home tại 359 Phạm Văn Chiêu, Q.Gò Vấp với vị trí thuận lợi, tiện ích nội khu vượt trội, thiết kế thông minh, nội thất cao cấp nhưng giá chỉ bằng giá nhà ở xã hội, Khai trương và vận hành chính thức tòa nhà vào đầu tháng 04/2017.",
                ClientId = 11,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-194),
                UpdatedAt
             = DateTime.Now.AddDays(-194)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 12,
                Name = "The Zen Park",
                Description = "Tổng diện tích đất: 28.834 m2 Tổng số tòa: 4 (R1.01, R1.02, R1.03, R1.05) Số tầng mỗi tòa: 31 tầng nổi Diện tích tầng hầm: ~ 24.000 m2 Diện tích cây xanh: 6.208 m2 Diện tích mặt nước Hồ cá Koi: 692 m2 Toà mở bán: 2 toà (R1.02 & R1.05) Số lượng mở bán - 7 loại căn hộ: Studio (52 căn) : 1PN: 271 căn, 1PN+1: 263 căn, 2PN: 224 căn, 2PN+1: 85 căn, 3PN: 31 căn, 3PN+1: 35 cănCác loại căn hộ diện tích linh hoạt (từ 28m2 đến 95 m2)",
                ClientId = 12,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-193),
                UpdatedAt
             = DateTime.Now.AddDays(-193)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 13,
                Name = "Vinhome Ocean Park",
                Description = "Được quy hoạch bởi đơn vị tư vấn thiết kế hàng đầu thế giới EDSA, với mật độ xây dựng thấp chỉ gần 19% Vinhomes Ocean Park mang tầm vóc một đại đô thị đồng bộ tiện ích như Đảo quốc Singapore. Và hơn thế nữa, dự án sở hữu những đại tiện ích và cảnh quan quy mô tầm cỡ, mới mẻ như Công viên Gym ngoài trời, Công viên BBQ rộng lớn trên nền tảng không gian cây xanh, mặt nước đa dạng.",
                ClientId = 13,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-192),
                UpdatedAt
             = DateTime.Now.AddDays(-192)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 14,
                Name = "VegaCity",
                Description = "Với muôn vàn cung bậc của trái tim, từ êm đềm thảnh thơi đến cháy bừng hứng khởi, Vega Continental Shopping Plaza mang đậm cảm hứng cuộc đại hải trình vĩ đại, nơi nhịp sống rộn ràng không ngừng nghỉ, thắp sáng lên một khung trời lễ hội.",
                ClientId = 14,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-191),
                UpdatedAt
             = DateTime.Now.AddDays(-191)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 15,
                Name = "Shophouse Bình Minh Garden",
                Description = "Vị trí: Số 93 phố Đức Giang, phường Đức Giang, quận Long Biên, Hà Nội Chủ đầu tư: Công ty cổ phần đầu tư và phát triển BĐS Thế Kỷ - Cen Invest Diện tích khu thấp tầng: 9.511m2 Mật độ xây dựng thấp tầng: 70% Nhà thầu thiết kế: Công ty CP tư vấn AA (AA – Corp)",
                ClientId = 15,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-190),
                UpdatedAt
             = DateTime.Now.AddDays(-190)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 16,
                Name = "Chung cư Bình Minh Garden",
                Description = "Được định hướng phát triển cuộc sống năng động, đầy đủ, mọi tiện ích phục vụ nhu cầu hàng ngày của cư dân được bố trí ngay trong nội khu dự án từ ăn uống, mua sắm, dịch vụ làm đẹp, ngân hàng,…",
                ClientId = 16,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-189),
                UpdatedAt
             = DateTime.Now.AddDays(-189)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 17,
                Name = "Chung Cư Cao Cấp I Tower Quy Nhơn",
                Description = "I–Tower Quy Nhơn là dự án chung cư căn hộ thương mại cao cấp được UBND tỉnh chấp thuận chủ trương đầu tư từ đầu năm 2015 do Công ty CP Đầu tư Phát triển bất động sản Đô Thành làm chủ đầu tư. Đây là dự án sở hữu vị trí “Vàng” ngay trung tâm Tp biển Quy Nhơn.",
                ClientId = 17,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-188),
                UpdatedAt
             = DateTime.Now.AddDays(-188)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 18,
                Name = "La Queenara Hội An",
                Description = "Lấy cảm hứng thiết kế từ câu chuyện di sản và con người Hội An, La Queenara gây ấn tượng  với hệ sinh thái 200 tiện ích phức hợp, tạo nên tổng thể hài hòa kiến tạo cộng đồng tinh hoa ngay trong lòng thành phố di sản: ",
                ClientId = 18,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-187),
                UpdatedAt
             = DateTime.Now.AddDays(-187)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 19,
                Name = "Samsora Premier 105",
                Description = "Samsora Premier là dự án chung cư nằm ngay trên mặt đường Chu Văn An huyết mạch kết nối giao thông phía Đông Bắc và Tây Nam thành phố. Dự án được nhiều khách hàng biết tới với quy hoạch hiện đại và hạ tầng tiện ích đầu tư chất lượng.",
                ClientId = 19,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-186),
                UpdatedAt
             = DateTime.Now.AddDays(-186)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 20,
                Name = "Vườn Vua Resort & Villas",
                Description = "Từ thủ đô Hà Nội đi theo đường Đại Lộ Thăng Long, qua Làng Văn hóa các Dân tộc Việt Nam, lên thẳng Đá Chông (khu di tích K9), qua Cầu Đồng Quang - Phà Đá Chông vượt Sông Đà 2km là đến Vườn Vua, với khoảng 65km từ Hà Nội. Nếu đi theo đường quốc lộ 32 qua cầu Trung Hà, qua huyện lỵ Thanh Thuỷ đến Vườn Vua khoảng 85km.",
                ClientId = 20,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-185),
                UpdatedAt
             = DateTime.Now.AddDays(-185)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 21,
                Name = "Khai Sơn Town",
                Description = "Nằm cách phố cổ chỉ 10 phút di chuyển, dự án Khai Sơn Town thuộc quần thể đô thị Khai Sơn City Long Biên được thừa hưởng nhiều ưu thế để phát triển mạnh mẽ trong tương lai. Dự án không chỉ có ưu thế về liên kết hạ tầng giao thông, tiện ích, mà còn có nhiều tiềm năng tăng giá, xứng đáng là khoản đầu tư không thể bỏ qua của các nhà đầu tư.",
                ClientId = 21,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-184),
                UpdatedAt
             = DateTime.Now.AddDays(-184)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 22,
                Name = "Mercedes-Benz GLS 600 Maybach",
                Description = "Tình trạng Mới Năm sản xuất 2021 Kiểu dáng SUV Xuất xứ Nhập khẩu Hộp số Số tự động",
                ClientId = 22,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-183),
                UpdatedAt
             = DateTime.Now.AddDays(-183)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 23,
                Name = "Toyota Crown Royal Saloon 3.0 MT bản full",
                Description = "Tình trạng Đã qua sử dụng Số km đã đi 32.000 km Năm sản xuất 1998 Kiểu dáng Sedan Xuất xứ Nhập khẩu Hộp số Số tay",
                ClientId = 23,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-182),
                UpdatedAt
             = DateTime.Now.AddDays(-182)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 24,
                Name = "Xe tải Hino FG tải 8 tấn thùng dài",
                Description = "Tình trạng Mới Năm sản xuất 2020 Kiểu dáng Truck Xuất xứ Lắp ráp Hộp số Số tay Địa chỉ rao bán Tp.HCM",
                ClientId = 24,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-181),
                UpdatedAt
             = DateTime.Now.AddDays(-181)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 25,
                Name = "Kia Cerato 2.0AT",
                Description = "Tình trạng Đã qua sử dụng Số km đã đi 12.000 km Năm sản xuất 2019 Kiểu dáng Sedan Hộp số Số tự động Địa chỉ rao bán Tp.HCM",
                ClientId = 25,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-180),
                UpdatedAt
             = DateTime.Now.AddDays(-180)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 26,
                Name = "Toyota Land Cruiser 1998",
                Description = "Tình trạng Đã qua sử dụng Số km đã đi 18.000 km Năm sản xuất 1998 Kiểu dáng SUV Xuất xứ Nhập khẩu Hộp số Số tay Địa chỉ rao bán Hà Nội",
                ClientId = 26,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-179),
                UpdatedAt
             = DateTime.Now.AddDays(-179)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 27,
                Name = "Lexus RX 350 F-Sport 2016",
                Description = "Tình trạng Đã qua sử dụngSố km đã đi22.000 kmNăm sản xuất2016Kiểu dángSUVXuất xứNhập khẩuHộp sốSố tự động",
                ClientId = 27,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-178),
                UpdatedAt
             = DateTime.Now.AddDays(-178)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 28,
                Name = "Mercedes G63 Edition 1",
                Description = "Tình trạng Mới Năm sản xuất 2021 Kiểu dáng SUV Xuất xứ Nhập khẩu Hộp số Số tự động Địa chỉ rao bán Hà Nội",
                ClientId = 28,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-177),
                UpdatedAt
             = DateTime.Now.AddDays(-177)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 29,
                Name = "Mazda CX 5 2019",
                Description = "Tình trạng Đã qua sử dụng Số km đã đi 27.000 km Năm sản xuất 2019 Kiểu dáng SUV Hộp số Số tự động Địa chỉ rao bán Tp.HCM",
                ClientId = 29,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-176),
                UpdatedAt
             = DateTime.Now.AddDays(-176)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 30,
                Name = "Volkswagen T-Cross",
                Description = "Cùng với Teramont, Volkswagen T-Cross 2021 được đồn đoán là mẫu xe hoàn toàn mới sẽ gia nhập đội hình sản phẩm xe hơi của Volkswagen (VW) tại Việt Nam trong năm 2021. Hiện tại, VW Việt Nam vẫn chưa tiết lộ bất cứ thông tin nào về kế hoạch ra mắt T-Cross 2021 tại Việt Nam.",
                ClientId = 30,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-175),
                UpdatedAt
             = DateTime.Now.AddDays(-175)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 31,
                Name = "Dự án The Filmore Đà Nẵng",
                Description = "Diện tích khu đất 1.504,2 m2 với quy mô 25 tầng nổi, 3 tầng hầm và 206 căn hộ cao cấp (gồm các căn hộ 1 phòng ngủ, 2 phòng ngủ, 3 phòng ngủ - Duplex, Dual Key). Tổng diện tích sàn xây dựng hơn 22.600 m2, diện tích sàn nhà ở khoảng 12.876 m2, diện tích sàn sử dụng thương mại dịch vụ gần 300 m2. Mật độ xây dựng khối đế 55,6%, khối tháp 47,8%. Dự án dự kiến hoàn thành và bàn giao vào quý IV/2022.",
                ClientId = 31,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-204),
                UpdatedAt
             = DateTime.Now.AddDays(-204)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 32,
                Name = "Ô tô điện thông minh vf-e35",
                Description = "Thuộc phân khúc C, từng được công bố vào tháng 1/2021 với tên mã VF31. Xe có chiều dài cơ sở 2.611mm, kích thước các chiều dài x rộng x cao là 4.300 x 1.793 x 1.613 (mm), khoảng sáng gầm xe 180mm, trọng lượng không tải 1.490kg. VinFast VF e34 được trang bị một động cơ điện có công suất tối đa 110 kW ( 147 HP), mô-men xoắn cực đại 242 Nm cùng hệ dẫn động cầu trước, hệ thống treo trước MacPherson, hệ thống treo sau dạng thanh xoắn. Xe sử dụng một bộ pin dung lượng 42kWh, có thể đi được quãng đường 300km sau mỗi lần sạc đầy. Để minh chứng cho đẳng cấp, chất lượng và tạo sự an tâm cho khách hàng, VinFast tiên phong áp dụng chính sách bảo hành lên tới 10 năm cho xe VF e35",
                ClientId = 32,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-203),
                UpdatedAt
             = DateTime.Now.AddDays(-203)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 33,
                Name = "Xi măng Nghi Sơn đa dụng",
                Description = "chất lượng PCB40, được sản xuất từ công nghệ Nhật tiên tiến, chất lượng được kiểm soát bởi các chuyên gia Nhật Bản",
                ClientId = 33,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-202),
                UpdatedAt
             = DateTime.Now.AddDays(-202)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 34,
                Name = "Gạch bê tông AAC",
                Description = "Gạch bê tông AAC (viết tắt của ba từ tiếng Anh là “Aerated Autoclaved Concrete”) hay còn có tên là “gạch bê tông khí chưng áp” đây là loại vật liệu mới trong xây dựng với kết cấu bê tông gồm các bọt khí nhỏ. Mặc dù đã xuất hiện và bắt đầu sử dụng trên Thế Giới gần 1 thế kỷ trước. Tuy nhiên đến năm 2008 Việt Nam mới bắt đầu nhập khẩu và sử dụng loại vật liệu này.Đây được xem là vật liệu xanh vì có thể tái sử dụng. Được sản xuất bằng công nghệ khí chưng áp từ các nguyên liệu như cát, vôi, thạch cao, xi măng, bột nhôm và không gây ô nhiễm nên thân thiện môi trường.",
                ClientId = 34,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-201),
                UpdatedAt
             = DateTime.Now.AddDays(-201)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 35,
                Name = "Tấm panel ALC",
                Description = "ALC (Autoclaced Lightweight Aerated Concrete) hay được gọi là “Bê tông gia khí chưng áp. Tấm tường Panel được sản xuất bằng các nguyên liệu giống với nguyên liệu tạo ra sản phẩm gạch nhẹ AAC. Với khả năng chịu lực cao, tấm ALC được chế tạo bằng 2 lớp thép (thép nguội), cấu trúc không gian 3 chiều nên tạo ra một bộ khung cứng và vững chắc. Ứng dụng để làm tường, sàn, cầu thang, mái,… Có thể gia công cưa, cắt, khoan hay đóng đinh một cách đơn giản, tốn ít thời gian, quá trình lắp đặt nhanh chóng thuận tiện.",
                ClientId = 35,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-200),
                UpdatedAt
             = DateTime.Now.AddDays(-200)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 36,
                Name = "Xi măng công nghệ nano",
                Description = "Đây là sản phẩm vật liệu mới trong xây dựng nhà ở và công trình. Sản phẩm có độ cứng và độ bền vượt trội. Với công thức độc đáo đây là công nghệ vật liệu mới trong xây dựng – công nghệ độc quyền của SCG giúp cải tiến chất lượng xi măng, các phân tử xi măng tạo ra ở kích thước nano nên tạo ra liên kết vô cùng chặt chẽ nên giảm thiểu khả năng nứt, rò rỉ của công trình một trong những nguyên nhân gây ra chính là do các lỗ rỗng trong quá trình trộn bê tông tạo ra khi sử dụng xi măng cũ tiếp xúc với các tác nhân môi trường như nắng, gió, mưa,..",
                ClientId = 36,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-199),
                UpdatedAt
             = DateTime.Now.AddDays(-199)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 37,
                Name = "Tấm tường bê tông đúc sẵn",
                Description = "Ưu điểm dễ dàng thi công lắp đặt với 6m2 tường chỉ cần 3 công nhân làm việc trong 1 giờ đồng hồ nên giúp tiết kiệm nhân lực lao động. So với các loại truyền thống như tường gạch, block bê tông thì tấm tường bê tông đúc sẵn này có tuổi thọ cao hơn, giảm chi phí sử dụng vật liệu hơn do có chiều dày nhỏ hơn chỉ khoảng 68 – 140 mm nên còn giúp tiết kiệm không gian lắp đặt tăng diện tích sử dụng cho nhà ở hoặc công trình.",
                ClientId = 37,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-198),
                UpdatedAt
             = DateTime.Now.AddDays(-198)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 38,
                Name = "Gạch men và sứ vệ sinh kháng khuẩn",
                Description = "Đây là dòng sản phẩm với khả năng tự tiêu diệt vi khuẩn khi bám trên bề mặt sản phẩm. Ở nước ngoài đây là loại vật liệu chủ yếu dùng trong các cơ sở y tế và bệnh viện. Với lớp men Nano phun trực tiếp lên sản phẩm và nung ở nhiệt độ 1200 – 1250 độ C, giúp cho lớp men này trở nên siêu bền trên bề mặt, chống bám dính, ổ bẩn cũng như góp phần tăng độ nhẵn mịn bóng loáng cho sản phẩm.",
                ClientId = 38,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-197),
                UpdatedAt
             = DateTime.Now.AddDays(-197)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 39,
                Name = "METRO STAR",
                Description = "Metro Star có vị trí đắc địa ở địa chỉ 360 Xa Lộ Hà Nội, nằm trong khu dân cư đông đúc, sôi động của cửa ngõ phía Đông Sài Gòn - nơi có hai mặt tiền đường là Xa lộ Hà Nội và Nam Hòa cùng với công viên cỏ xanh  rộng rãi, thoáng đãng, đặc biệt là dự án hiếm hoi có cầu bộ hành kết nối trực tiếp từ ga Metro số 10 đi vào tầng 2 khu dân cư.Metro Star được đầu tư phát triển bởi Công ty Metro Star, trực thuộc Tổng Công ty C.T Land (thành viên Tập đoàn C.T Group - Tập đoàn đa ngành hàng đầu Việt Nam), mang đến một “siêu phẩm” độc đáo về kiến trúc, chất lượng xây dựng tiêu chuẩn Singapore và 100+ tiện ích đậm chất quốc đảo sư tử.",
                ClientId = 39,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-196),
                UpdatedAt
             = DateTime.Now.AddDays(-196)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 40,
                Name = "C.T PLAZA",
                Description = "C.T Plaza là một thương hiệu nhà ở và thương mại văn phòng rất đặc biệt, là sự kết hợp hài hòa giữa 3 đỉnh cao: Nghệ thuật của Tạo hóa là Thiên nhiên tươi đẹp, Nghệ thuật của Nhân loại là Kiến trúc, Hội họa, Âm nhạc, Phim ảnh…và đẹp hơn hết là Con người với cái đẹp của thân thể và tâm hồn…nơi con người có thể nâng cuộc sống hằng ngày lên thành Nghệ thuật sống cuộc đời (Living Art) để mỗi người hạnh phúc tuyệt vời theo cách riêng trong ngôi nhà của mình (A Life Style Home Brand).",
                ClientId = 40,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-195),
                UpdatedAt
             = DateTime.Now.AddDays(-195)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 41,
                Name = "I-HOME",
                Description = "Thương hiệu I-Home cực kỳ mới lạ và đặc biệt yêu thích bởi giới trẻ với concept rất thú vị và giá rất nice. Là sự kết hợp giữa Home và Internet trong 1 thế giới phẳng. Khu I-Home tại 359 Phạm Văn Chiêu, Q.Gò Vấp với vị trí thuận lợi, tiện ích nội khu vượt trội, thiết kế thông minh, nội thất cao cấp nhưng giá chỉ bằng giá nhà ở xã hội, Khai trương và vận hành chính thức tòa nhà vào đầu tháng 04/2017.",
                ClientId = 41,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-194),
                UpdatedAt
             = DateTime.Now.AddDays(-194)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 42,
                Name = "The Zen Park",
                Description = "Tổng diện tích đất: 28.834 m2 Tổng số tòa: 4 (R1.01, R1.02, R1.03, R1.05) Số tầng mỗi tòa: 31 tầng nổi Diện tích tầng hầm: ~ 24.000 m2 Diện tích cây xanh: 6.208 m2 Diện tích mặt nước Hồ cá Koi: 692 m2 Toà mở bán: 2 toà (R1.02 & R1.05) Số lượng mở bán - 7 loại căn hộ: Studio (52 căn) : 1PN: 271 căn, 1PN+1: 263 căn, 2PN: 224 căn, 2PN+1: 85 căn, 3PN: 31 căn, 3PN+1: 35 cănCác loại căn hộ diện tích linh hoạt (từ 28m2 đến 95 m2)",
                ClientId = 42,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-193),
                UpdatedAt
             = DateTime.Now.AddDays(-193)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 43,
                Name = "Vinhome Ocean Park",
                Description = "Được quy hoạch bởi đơn vị tư vấn thiết kế hàng đầu thế giới EDSA, với mật độ xây dựng thấp chỉ gần 19% Vinhomes Ocean Park mang tầm vóc một đại đô thị đồng bộ tiện ích như Đảo quốc Singapore. Và hơn thế nữa, dự án sở hữu những đại tiện ích và cảnh quan quy mô tầm cỡ, mới mẻ như Công viên Gym ngoài trời, Công viên BBQ rộng lớn trên nền tảng không gian cây xanh, mặt nước đa dạng.",
                ClientId = 43,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-192),
                UpdatedAt
             = DateTime.Now.AddDays(-192)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 44,
                Name = "VegaCity",
                Description = "Với muôn vàn cung bậc của trái tim, từ êm đềm thảnh thơi đến cháy bừng hứng khởi, Vega Continental Shopping Plaza mang đậm cảm hứng cuộc đại hải trình vĩ đại, nơi nhịp sống rộn ràng không ngừng nghỉ, thắp sáng lên một khung trời lễ hội.",
                ClientId = 44,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-191),
                UpdatedAt
             = DateTime.Now.AddDays(-191)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 45,
                Name = "Shophouse Bình Minh Garden",
                Description = "Vị trí: Số 93 phố Đức Giang, phường Đức Giang, quận Long Biên, Hà Nội Chủ đầu tư: Công ty cổ phần đầu tư và phát triển BĐS Thế Kỷ - Cen Invest Diện tích khu thấp tầng: 9.511m2 Mật độ xây dựng thấp tầng: 70% Nhà thầu thiết kế: Công ty CP tư vấn AA (AA – Corp)",
                ClientId = 45,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-190),
                UpdatedAt
             = DateTime.Now.AddDays(-190)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 46,
                Name = "Chung cư Bình Minh Garden",
                Description = "Được định hướng phát triển cuộc sống năng động, đầy đủ, mọi tiện ích phục vụ nhu cầu hàng ngày của cư dân được bố trí ngay trong nội khu dự án từ ăn uống, mua sắm, dịch vụ làm đẹp, ngân hàng,…",
                ClientId = 46,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-189),
                UpdatedAt
             = DateTime.Now.AddDays(-189)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 47,
                Name = "Chung Cư Cao Cấp I Tower Quy Nhơn",
                Description = "I–Tower Quy Nhơn là dự án chung cư căn hộ thương mại cao cấp được UBND tỉnh chấp thuận chủ trương đầu tư từ đầu năm 2015 do Công ty CP Đầu tư Phát triển bất động sản Đô Thành làm chủ đầu tư. Đây là dự án sở hữu vị trí “Vàng” ngay trung tâm Tp biển Quy Nhơn.",
                ClientId = 47,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-188),
                UpdatedAt
             = DateTime.Now.AddDays(-188)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 48,
                Name = "La Queenara Hội An",
                Description = "Lấy cảm hứng thiết kế từ câu chuyện di sản và con người Hội An, La Queenara gây ấn tượng  với hệ sinh thái 200 tiện ích phức hợp, tạo nên tổng thể hài hòa kiến tạo cộng đồng tinh hoa ngay trong lòng thành phố di sản: ",
                ClientId = 48,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-187),
                UpdatedAt
             = DateTime.Now.AddDays(-187)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 49,
                Name = "Samsora Premier 106",
                Description = "Samsora Premier là dự án chung cư nằm ngay trên mặt đường Chu Văn An huyết mạch kết nối giao thông phía Đông Bắc và Tây Nam thành phố. Dự án được nhiều khách hàng biết tới với quy hoạch hiện đại và hạ tầng tiện ích đầu tư chất lượng.",
                ClientId = 49,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-186),
                UpdatedAt
             = DateTime.Now.AddDays(-186)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 50,
                Name = "Vườn Vua Resort & Villas",
                Description = "Từ thủ đô Hà Nội đi theo đường Đại Lộ Thăng Long, qua Làng Văn hóa các Dân tộc Việt Nam, lên thẳng Đá Chông (khu di tích K9), qua Cầu Đồng Quang - Phà Đá Chông vượt Sông Đà 2km là đến Vườn Vua, với khoảng 65km từ Hà Nội. Nếu đi theo đường quốc lộ 32 qua cầu Trung Hà, qua huyện lỵ Thanh Thuỷ đến Vườn Vua khoảng 85km.",
                ClientId = 50,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-185),
                UpdatedAt
             = DateTime.Now.AddDays(-185)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 51,
                Name = "Khai Sơn Town",
                Description = "Nằm cách phố cổ chỉ 10 phút di chuyển, dự án Khai Sơn Town thuộc quần thể đô thị Khai Sơn City Long Biên được thừa hưởng nhiều ưu thế để phát triển mạnh mẽ trong tương lai. Dự án không chỉ có ưu thế về liên kết hạ tầng giao thông, tiện ích, mà còn có nhiều tiềm năng tăng giá, xứng đáng là khoản đầu tư không thể bỏ qua của các nhà đầu tư.",
                ClientId = 51,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-184),
                UpdatedAt
             = DateTime.Now.AddDays(-184)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 52,
                Name = "Mercedes-Benz GLS 600 Maybach",
                Description = "Tình trạng Mới Năm sản xuất 2021 Kiểu dáng SUV Xuất xứ Nhập khẩu Hộp số Số tự động",
                ClientId = 52,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-183),
                UpdatedAt
             = DateTime.Now.AddDays(-183)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 53,
                Name = "Toyota Crown Royal Saloon 3.0 MT bản full",
                Description = "Tình trạng Đã qua sử dụng Số km đã đi 32.000 km Năm sản xuất 1998 Kiểu dáng Sedan Xuất xứ Nhập khẩu Hộp số Số tay",
                ClientId = 53,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-182),
                UpdatedAt
             = DateTime.Now.AddDays(-182)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 54,
                Name = "Xe tải Hino FG tải 8 tấn thùng dài",
                Description = "Tình trạng Mới Năm sản xuất 2020 Kiểu dáng Truck Xuất xứ Lắp ráp Hộp số Số tay Địa chỉ rao bán Tp.HCM",
                ClientId = 54,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-181),
                UpdatedAt
             = DateTime.Now.AddDays(-181)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 55,
                Name = "Kia Cerato 2.0AT",
                Description = "Tình trạng Đã qua sử dụng Số km đã đi 12.000 km Năm sản xuất 2019 Kiểu dáng Sedan Hộp số Số tự động Địa chỉ rao bán Tp.HCM",
                ClientId = 55,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-180),
                UpdatedAt
             = DateTime.Now.AddDays(-180)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 56,
                Name = "Toyota Land Cruiser 1999",
                Description = "Tình trạng Đã qua sử dụng Số km đã đi 18.000 km Năm sản xuất 1998 Kiểu dáng SUV Xuất xứ Nhập khẩu Hộp số Số tay Địa chỉ rao bán Hà Nội",
                ClientId = 56,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-179),
                UpdatedAt
             = DateTime.Now.AddDays(-179)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 57,
                Name = "Lexus RX 350 F-Sport 2017",
                Description = "Tình trạng Đã qua sử dụngSố km đã đi22.000 kmNăm sản xuất2016Kiểu dángSUVXuất xứNhập khẩuHộp sốSố tự động",
                ClientId = 57,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-178),
                UpdatedAt
             = DateTime.Now.AddDays(-178)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 58,
                Name = "Mercedes G63 Edition 2",
                Description = "Tình trạng Mới Năm sản xuất 2021 Kiểu dáng SUV Xuất xứ Nhập khẩu Hộp số Số tự động Địa chỉ rao bán Hà Nội",
                ClientId = 58,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-177),
                UpdatedAt
             = DateTime.Now.AddDays(-177)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 59,
                Name = "Mazda CX 5 2020",
                Description = "Tình trạng Đã qua sử dụng Số km đã đi 27.000 km Năm sản xuất 2019 Kiểu dáng SUV Hộp số Số tự động Địa chỉ rao bán Tp.HCM",
                ClientId = 59,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-176),
                UpdatedAt
             = DateTime.Now.AddDays(-176)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 60,
                Name = "Volkswagen T-Cross",
                Description = "Cùng với Teramont, Volkswagen T-Cross 2021 được đồn đoán là mẫu xe hoàn toàn mới sẽ gia nhập đội hình sản phẩm xe hơi của Volkswagen (VW) tại Việt Nam trong năm 2021. Hiện tại, VW Việt Nam vẫn chưa tiết lộ bất cứ thông tin nào về kế hoạch ra mắt T-Cross 2021 tại Việt Nam.",
                ClientId = 60,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-175),
                UpdatedAt
             = DateTime.Now.AddDays(-175)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 61,
                Name = "Dự án The Filmore Đà Nẵng",
                Description = "Diện tích khu đất 1.504,2 m2 với quy mô 25 tầng nổi, 3 tầng hầm và 206 căn hộ cao cấp (gồm các căn hộ 1 phòng ngủ, 2 phòng ngủ, 3 phòng ngủ - Duplex, Dual Key). Tổng diện tích sàn xây dựng hơn 22.600 m2, diện tích sàn nhà ở khoảng 12.876 m2, diện tích sàn sử dụng thương mại dịch vụ gần 300 m2. Mật độ xây dựng khối đế 55,6%, khối tháp 47,8%. Dự án dự kiến hoàn thành và bàn giao vào quý IV/2022.",
                ClientId = 61,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-204),
                UpdatedAt
             = DateTime.Now.AddDays(-204)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 62,
                Name = "Ô tô điện thông minh vf-e36",
                Description = "Thuộc phân khúc C, từng được công bố vào tháng 1/2021 với tên mã VF31. Xe có chiều dài cơ sở 2.611mm, kích thước các chiều dài x rộng x cao là 4.300 x 1.793 x 1.613 (mm), khoảng sáng gầm xe 180mm, trọng lượng không tải 1.490kg. VinFast VF e34 được trang bị một động cơ điện có công suất tối đa 110 kW ( 147 HP), mô-men xoắn cực đại 242 Nm cùng hệ dẫn động cầu trước, hệ thống treo trước MacPherson, hệ thống treo sau dạng thanh xoắn. Xe sử dụng một bộ pin dung lượng 42kWh, có thể đi được quãng đường 300km sau mỗi lần sạc đầy. Để minh chứng cho đẳng cấp, chất lượng và tạo sự an tâm cho khách hàng, VinFast tiên phong áp dụng chính sách bảo hành lên tới 10 năm cho xe VF e36",
                ClientId = 62,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-203),
                UpdatedAt
             = DateTime.Now.AddDays(-203)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 63,
                Name = "Xi măng Nghi Sơn đa dụng",
                Description = "chất lượng PCB40, được sản xuất từ công nghệ Nhật tiên tiến, chất lượng được kiểm soát bởi các chuyên gia Nhật Bản",
                ClientId = 63,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-202),
                UpdatedAt
             = DateTime.Now.AddDays(-202)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 64,
                Name = "Gạch bê tông AAC",
                Description = "Gạch bê tông AAC (viết tắt của ba từ tiếng Anh là “Aerated Autoclaved Concrete”) hay còn có tên là “gạch bê tông khí chưng áp” đây là loại vật liệu mới trong xây dựng với kết cấu bê tông gồm các bọt khí nhỏ. Mặc dù đã xuất hiện và bắt đầu sử dụng trên Thế Giới gần 1 thế kỷ trước. Tuy nhiên đến năm 2008 Việt Nam mới bắt đầu nhập khẩu và sử dụng loại vật liệu này.Đây được xem là vật liệu xanh vì có thể tái sử dụng. Được sản xuất bằng công nghệ khí chưng áp từ các nguyên liệu như cát, vôi, thạch cao, xi măng, bột nhôm và không gây ô nhiễm nên thân thiện môi trường.",
                ClientId = 64,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-201),
                UpdatedAt
             = DateTime.Now.AddDays(-201)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 65,
                Name = "Tấm panel ALC",
                Description = "ALC (Autoclaced Lightweight Aerated Concrete) hay được gọi là “Bê tông gia khí chưng áp. Tấm tường Panel được sản xuất bằng các nguyên liệu giống với nguyên liệu tạo ra sản phẩm gạch nhẹ AAC. Với khả năng chịu lực cao, tấm ALC được chế tạo bằng 2 lớp thép (thép nguội), cấu trúc không gian 3 chiều nên tạo ra một bộ khung cứng và vững chắc. Ứng dụng để làm tường, sàn, cầu thang, mái,… Có thể gia công cưa, cắt, khoan hay đóng đinh một cách đơn giản, tốn ít thời gian, quá trình lắp đặt nhanh chóng thuận tiện.",
                ClientId = 65,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-200),
                UpdatedAt
             = DateTime.Now.AddDays(-200)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 66,
                Name = "Xi măng công nghệ nano",
                Description = "Đây là sản phẩm vật liệu mới trong xây dựng nhà ở và công trình. Sản phẩm có độ cứng và độ bền vượt trội. Với công thức độc đáo đây là công nghệ vật liệu mới trong xây dựng – công nghệ độc quyền của SCG giúp cải tiến chất lượng xi măng, các phân tử xi măng tạo ra ở kích thước nano nên tạo ra liên kết vô cùng chặt chẽ nên giảm thiểu khả năng nứt, rò rỉ của công trình một trong những nguyên nhân gây ra chính là do các lỗ rỗng trong quá trình trộn bê tông tạo ra khi sử dụng xi măng cũ tiếp xúc với các tác nhân môi trường như nắng, gió, mưa,..",
                ClientId = 66,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-199),
                UpdatedAt
             = DateTime.Now.AddDays(-199)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 67,
                Name = "Tấm tường bê tông đúc sẵn",
                Description = "Ưu điểm dễ dàng thi công lắp đặt với 6m2 tường chỉ cần 3 công nhân làm việc trong 1 giờ đồng hồ nên giúp tiết kiệm nhân lực lao động. So với các loại truyền thống như tường gạch, block bê tông thì tấm tường bê tông đúc sẵn này có tuổi thọ cao hơn, giảm chi phí sử dụng vật liệu hơn do có chiều dày nhỏ hơn chỉ khoảng 68 – 140 mm nên còn giúp tiết kiệm không gian lắp đặt tăng diện tích sử dụng cho nhà ở hoặc công trình.",
                ClientId = 67,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-198),
                UpdatedAt
             = DateTime.Now.AddDays(-198)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 68,
                Name = "Gạch men và sứ vệ sinh kháng khuẩn",
                Description = "Đây là dòng sản phẩm với khả năng tự tiêu diệt vi khuẩn khi bám trên bề mặt sản phẩm. Ở nước ngoài đây là loại vật liệu chủ yếu dùng trong các cơ sở y tế và bệnh viện. Với lớp men Nano phun trực tiếp lên sản phẩm và nung ở nhiệt độ 1200 – 1250 độ C, giúp cho lớp men này trở nên siêu bền trên bề mặt, chống bám dính, ổ bẩn cũng như góp phần tăng độ nhẵn mịn bóng loáng cho sản phẩm.",
                ClientId = 68,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-197),
                UpdatedAt
             = DateTime.Now.AddDays(-197)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 69,
                Name = "METRO STAR",
                Description = "Metro Star có vị trí đắc địa ở địa chỉ 360 Xa Lộ Hà Nội, nằm trong khu dân cư đông đúc, sôi động của cửa ngõ phía Đông Sài Gòn - nơi có hai mặt tiền đường là Xa lộ Hà Nội và Nam Hòa cùng với công viên cỏ xanh  rộng rãi, thoáng đãng, đặc biệt là dự án hiếm hoi có cầu bộ hành kết nối trực tiếp từ ga Metro số 10 đi vào tầng 2 khu dân cư.Metro Star được đầu tư phát triển bởi Công ty Metro Star, trực thuộc Tổng Công ty C.T Land (thành viên Tập đoàn C.T Group - Tập đoàn đa ngành hàng đầu Việt Nam), mang đến một “siêu phẩm” độc đáo về kiến trúc, chất lượng xây dựng tiêu chuẩn Singapore và 100+ tiện ích đậm chất quốc đảo sư tử.",
                ClientId = 69,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-196),
                UpdatedAt
             = DateTime.Now.AddDays(-196)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 70,
                Name = "C.T PLAZA",
                Description = "C.T Plaza là một thương hiệu nhà ở và thương mại văn phòng rất đặc biệt, là sự kết hợp hài hòa giữa 3 đỉnh cao: Nghệ thuật của Tạo hóa là Thiên nhiên tươi đẹp, Nghệ thuật của Nhân loại là Kiến trúc, Hội họa, Âm nhạc, Phim ảnh…và đẹp hơn hết là Con người với cái đẹp của thân thể và tâm hồn…nơi con người có thể nâng cuộc sống hằng ngày lên thành Nghệ thuật sống cuộc đời (Living Art) để mỗi người hạnh phúc tuyệt vời theo cách riêng trong ngôi nhà của mình (A Life Style Home Brand).",
                ClientId = 70,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-195),
                UpdatedAt
             = DateTime.Now.AddDays(-195)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 71,
                Name = "I-HOME",
                Description = "Thương hiệu I-Home cực kỳ mới lạ và đặc biệt yêu thích bởi giới trẻ với concept rất thú vị và giá rất nice. Là sự kết hợp giữa Home và Internet trong 1 thế giới phẳng. Khu I-Home tại 359 Phạm Văn Chiêu, Q.Gò Vấp với vị trí thuận lợi, tiện ích nội khu vượt trội, thiết kế thông minh, nội thất cao cấp nhưng giá chỉ bằng giá nhà ở xã hội, Khai trương và vận hành chính thức tòa nhà vào đầu tháng 04/2017.",
                ClientId = 71,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-194),
                UpdatedAt
             = DateTime.Now.AddDays(-194)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 72,
                Name = "The Zen Park",
                Description = "Tổng diện tích đất: 28.834 m2 Tổng số tòa: 4 (R1.01, R1.02, R1.03, R1.05) Số tầng mỗi tòa: 31 tầng nổi Diện tích tầng hầm: ~ 24.000 m2 Diện tích cây xanh: 6.208 m2 Diện tích mặt nước Hồ cá Koi: 692 m2 Toà mở bán: 2 toà (R1.02 & R1.05) Số lượng mở bán - 7 loại căn hộ: Studio (52 căn) : 1PN: 271 căn, 1PN+1: 263 căn, 2PN: 224 căn, 2PN+1: 85 căn, 3PN: 31 căn, 3PN+1: 35 cănCác loại căn hộ diện tích linh hoạt (từ 28m2 đến 95 m2)",
                ClientId = 72,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-193),
                UpdatedAt
             = DateTime.Now.AddDays(-193)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 73,
                Name = "Vinhome Ocean Park",
                Description = "Được quy hoạch bởi đơn vị tư vấn thiết kế hàng đầu thế giới EDSA, với mật độ xây dựng thấp chỉ gần 19% Vinhomes Ocean Park mang tầm vóc một đại đô thị đồng bộ tiện ích như Đảo quốc Singapore. Và hơn thế nữa, dự án sở hữu những đại tiện ích và cảnh quan quy mô tầm cỡ, mới mẻ như Công viên Gym ngoài trời, Công viên BBQ rộng lớn trên nền tảng không gian cây xanh, mặt nước đa dạng.",
                ClientId = 73,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-192),
                UpdatedAt
             = DateTime.Now.AddDays(-192)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 74,
                Name = "VegaCity",
                Description = "Với muôn vàn cung bậc của trái tim, từ êm đềm thảnh thơi đến cháy bừng hứng khởi, Vega Continental Shopping Plaza mang đậm cảm hứng cuộc đại hải trình vĩ đại, nơi nhịp sống rộn ràng không ngừng nghỉ, thắp sáng lên một khung trời lễ hội.",
                ClientId = 74,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-191),
                UpdatedAt
             = DateTime.Now.AddDays(-191)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 75,
                Name = "Shophouse Bình Minh Garden",
                Description = "Vị trí: Số 93 phố Đức Giang, phường Đức Giang, quận Long Biên, Hà Nội Chủ đầu tư: Công ty cổ phần đầu tư và phát triển BĐS Thế Kỷ - Cen Invest Diện tích khu thấp tầng: 9.511m2 Mật độ xây dựng thấp tầng: 70% Nhà thầu thiết kế: Công ty CP tư vấn AA (AA – Corp)",
                ClientId = 75,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-190),
                UpdatedAt
             = DateTime.Now.AddDays(-190)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 76,
                Name = "Chung cư Bình Minh Garden",
                Description = "Được định hướng phát triển cuộc sống năng động, đầy đủ, mọi tiện ích phục vụ nhu cầu hàng ngày của cư dân được bố trí ngay trong nội khu dự án từ ăn uống, mua sắm, dịch vụ làm đẹp, ngân hàng,…",
                ClientId = 76,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-189),
                UpdatedAt
             = DateTime.Now.AddDays(-189)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 77,
                Name = "Chung Cư Cao Cấp I Tower Quy Nhơn",
                Description = "I–Tower Quy Nhơn là dự án chung cư căn hộ thương mại cao cấp được UBND tỉnh chấp thuận chủ trương đầu tư từ đầu năm 2015 do Công ty CP Đầu tư Phát triển bất động sản Đô Thành làm chủ đầu tư. Đây là dự án sở hữu vị trí “Vàng” ngay trung tâm Tp biển Quy Nhơn.",
                ClientId = 77,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-188),
                UpdatedAt
             = DateTime.Now.AddDays(-188)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 78,
                Name = "La Queenara Hội An",
                Description = "Lấy cảm hứng thiết kế từ câu chuyện di sản và con người Hội An, La Queenara gây ấn tượng  với hệ sinh thái 200 tiện ích phức hợp, tạo nên tổng thể hài hòa kiến tạo cộng đồng tinh hoa ngay trong lòng thành phố di sản: ",
                ClientId = 78,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-187),
                UpdatedAt
             = DateTime.Now.AddDays(-187)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 79,
                Name = "Samsora Premier 107",
                Description = "Samsora Premier là dự án chung cư nằm ngay trên mặt đường Chu Văn An huyết mạch kết nối giao thông phía Đông Bắc và Tây Nam thành phố. Dự án được nhiều khách hàng biết tới với quy hoạch hiện đại và hạ tầng tiện ích đầu tư chất lượng.",
                ClientId = 79,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-186),
                UpdatedAt
             = DateTime.Now.AddDays(-186)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 80,
                Name = "Vườn Vua Resort & Villas",
                Description = "Từ thủ đô Hà Nội đi theo đường Đại Lộ Thăng Long, qua Làng Văn hóa các Dân tộc Việt Nam, lên thẳng Đá Chông (khu di tích K9), qua Cầu Đồng Quang - Phà Đá Chông vượt Sông Đà 2km là đến Vườn Vua, với khoảng 65km từ Hà Nội. Nếu đi theo đường quốc lộ 32 qua cầu Trung Hà, qua huyện lỵ Thanh Thuỷ đến Vườn Vua khoảng 85km.",
                ClientId = 80,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-185),
                UpdatedAt
             = DateTime.Now.AddDays(-185)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 81,
                Name = "Khai Sơn Town",
                Description = "Nằm cách phố cổ chỉ 10 phút di chuyển, dự án Khai Sơn Town thuộc quần thể đô thị Khai Sơn City Long Biên được thừa hưởng nhiều ưu thế để phát triển mạnh mẽ trong tương lai. Dự án không chỉ có ưu thế về liên kết hạ tầng giao thông, tiện ích, mà còn có nhiều tiềm năng tăng giá, xứng đáng là khoản đầu tư không thể bỏ qua của các nhà đầu tư.",
                ClientId = 81,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-184),
                UpdatedAt
             = DateTime.Now.AddDays(-184)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 82,
                Name = "Mercedes-Benz GLS 600 Maybach",
                Description = "Tình trạng Mới Năm sản xuất 2021 Kiểu dáng SUV Xuất xứ Nhập khẩu Hộp số Số tự động",
                ClientId = 82,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-183),
                UpdatedAt
             = DateTime.Now.AddDays(-183)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 83,
                Name = "Toyota Crown Royal Saloon 3.0 MT bản full",
                Description = "Tình trạng Đã qua sử dụng Số km đã đi 32.000 km Năm sản xuất 1998 Kiểu dáng Sedan Xuất xứ Nhập khẩu Hộp số Số tay",
                ClientId = 83,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-182),
                UpdatedAt
             = DateTime.Now.AddDays(-182)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 84,
                Name = "Xe tải Hino FG tải 8 tấn thùng dài",
                Description = "Tình trạng Mới Năm sản xuất 2020 Kiểu dáng Truck Xuất xứ Lắp ráp Hộp số Số tay Địa chỉ rao bán Tp.HCM",
                ClientId = 84,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-181),
                UpdatedAt
             = DateTime.Now.AddDays(-181)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 85,
                Name = "Kia Cerato 2.0AT",
                Description = "Tình trạng Đã qua sử dụng Số km đã đi 12.000 km Năm sản xuất 2019 Kiểu dáng Sedan Hộp số Số tự động Địa chỉ rao bán Tp.HCM",
                ClientId = 85,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-180),
                UpdatedAt
             = DateTime.Now.AddDays(-180)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 86,
                Name = "Toyota Land Cruiser 2000",
                Description = "Tình trạng Đã qua sử dụng Số km đã đi 18.000 km Năm sản xuất 1998 Kiểu dáng SUV Xuất xứ Nhập khẩu Hộp số Số tay Địa chỉ rao bán Hà Nội",
                ClientId = 86,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-179),
                UpdatedAt
             = DateTime.Now.AddDays(-179)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 87,
                Name = "Lexus RX 350 F-Sport 2018",
                Description = "Tình trạng Đã qua sử dụngSố km đã đi22.000 kmNăm sản xuất2016Kiểu dángSUVXuất xứNhập khẩuHộp sốSố tự động",
                ClientId = 87,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-178),
                UpdatedAt
             = DateTime.Now.AddDays(-178)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 88,
                Name = "Mercedes G63 Edition 3",
                Description = "Tình trạng Mới Năm sản xuất 2021 Kiểu dáng SUV Xuất xứ Nhập khẩu Hộp số Số tự động Địa chỉ rao bán Hà Nội",
                ClientId = 88,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-177),
                UpdatedAt
             = DateTime.Now.AddDays(-177)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 89,
                Name = "Mazda CX 5 2021",
                Description = "Tình trạng Đã qua sử dụng Số km đã đi 27.000 km Năm sản xuất 2019 Kiểu dáng SUV Hộp số Số tự động Địa chỉ rao bán Tp.HCM",
                ClientId = 89,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-176),
                UpdatedAt
             = DateTime.Now.AddDays(-176)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 90,
                Name = "Volkswagen T-Cross",
                Description = "Cùng với Teramont, Volkswagen T-Cross 2021 được đồn đoán là mẫu xe hoàn toàn mới sẽ gia nhập đội hình sản phẩm xe hơi của Volkswagen (VW) tại Việt Nam trong năm 2021. Hiện tại, VW Việt Nam vẫn chưa tiết lộ bất cứ thông tin nào về kế hoạch ra mắt T-Cross 2021 tại Việt Nam.",
                ClientId = 90,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-175),
                UpdatedAt
             = DateTime.Now.AddDays(-175)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 91,
                Name = "Dự án The Filmore Đà Nẵng",
                Description = "Diện tích khu đất 1.504,2 m2 với quy mô 25 tầng nổi, 3 tầng hầm và 206 căn hộ cao cấp (gồm các căn hộ 1 phòng ngủ, 2 phòng ngủ, 3 phòng ngủ - Duplex, Dual Key). Tổng diện tích sàn xây dựng hơn 22.600 m2, diện tích sàn nhà ở khoảng 12.876 m2, diện tích sàn sử dụng thương mại dịch vụ gần 300 m2. Mật độ xây dựng khối đế 55,6%, khối tháp 47,8%. Dự án dự kiến hoàn thành và bàn giao vào quý IV/2022.",
                ClientId = 91,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-204),
                UpdatedAt
             = DateTime.Now.AddDays(-204)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 92,
                Name = "Ô tô điện thông minh vf-e37",
                Description = "Thuộc phân khúc C, từng được công bố vào tháng 1/2021 với tên mã VF31. Xe có chiều dài cơ sở 2.611mm, kích thước các chiều dài x rộng x cao là 4.300 x 1.793 x 1.613 (mm), khoảng sáng gầm xe 180mm, trọng lượng không tải 1.490kg. VinFast VF e34 được trang bị một động cơ điện có công suất tối đa 110 kW ( 147 HP), mô-men xoắn cực đại 242 Nm cùng hệ dẫn động cầu trước, hệ thống treo trước MacPherson, hệ thống treo sau dạng thanh xoắn. Xe sử dụng một bộ pin dung lượng 42kWh, có thể đi được quãng đường 300km sau mỗi lần sạc đầy. Để minh chứng cho đẳng cấp, chất lượng và tạo sự an tâm cho khách hàng, VinFast tiên phong áp dụng chính sách bảo hành lên tới 10 năm cho xe VF e37",
                ClientId = 92,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-203),
                UpdatedAt
             = DateTime.Now.AddDays(-203)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 93,
                Name = "Xi măng Nghi Sơn đa dụng",
                Description = "chất lượng PCB40, được sản xuất từ công nghệ Nhật tiên tiến, chất lượng được kiểm soát bởi các chuyên gia Nhật Bản",
                ClientId = 93,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-202),
                UpdatedAt
             = DateTime.Now.AddDays(-202)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 94,
                Name = "Gạch bê tông AAC",
                Description = "Gạch bê tông AAC (viết tắt của ba từ tiếng Anh là “Aerated Autoclaved Concrete”) hay còn có tên là “gạch bê tông khí chưng áp” đây là loại vật liệu mới trong xây dựng với kết cấu bê tông gồm các bọt khí nhỏ. Mặc dù đã xuất hiện và bắt đầu sử dụng trên Thế Giới gần 1 thế kỷ trước. Tuy nhiên đến năm 2008 Việt Nam mới bắt đầu nhập khẩu và sử dụng loại vật liệu này.Đây được xem là vật liệu xanh vì có thể tái sử dụng. Được sản xuất bằng công nghệ khí chưng áp từ các nguyên liệu như cát, vôi, thạch cao, xi măng, bột nhôm và không gây ô nhiễm nên thân thiện môi trường.",
                ClientId = 94,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-201),
                UpdatedAt
             = DateTime.Now.AddDays(-201)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 95,
                Name = "Tấm panel ALC",
                Description = "ALC (Autoclaced Lightweight Aerated Concrete) hay được gọi là “Bê tông gia khí chưng áp. Tấm tường Panel được sản xuất bằng các nguyên liệu giống với nguyên liệu tạo ra sản phẩm gạch nhẹ AAC. Với khả năng chịu lực cao, tấm ALC được chế tạo bằng 2 lớp thép (thép nguội), cấu trúc không gian 3 chiều nên tạo ra một bộ khung cứng và vững chắc. Ứng dụng để làm tường, sàn, cầu thang, mái,… Có thể gia công cưa, cắt, khoan hay đóng đinh một cách đơn giản, tốn ít thời gian, quá trình lắp đặt nhanh chóng thuận tiện.",
                ClientId = 95,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-200),
                UpdatedAt
             = DateTime.Now.AddDays(-200)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 96,
                Name = "Xi măng công nghệ nano",
                Description = "Đây là sản phẩm vật liệu mới trong xây dựng nhà ở và công trình. Sản phẩm có độ cứng và độ bền vượt trội. Với công thức độc đáo đây là công nghệ vật liệu mới trong xây dựng – công nghệ độc quyền của SCG giúp cải tiến chất lượng xi măng, các phân tử xi măng tạo ra ở kích thước nano nên tạo ra liên kết vô cùng chặt chẽ nên giảm thiểu khả năng nứt, rò rỉ của công trình một trong những nguyên nhân gây ra chính là do các lỗ rỗng trong quá trình trộn bê tông tạo ra khi sử dụng xi măng cũ tiếp xúc với các tác nhân môi trường như nắng, gió, mưa,..",
                ClientId = 96,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-199),
                UpdatedAt
             = DateTime.Now.AddDays(-199)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 97,
                Name = "Tấm tường bê tông đúc sẵn",
                Description = "Ưu điểm dễ dàng thi công lắp đặt với 6m2 tường chỉ cần 3 công nhân làm việc trong 1 giờ đồng hồ nên giúp tiết kiệm nhân lực lao động. So với các loại truyền thống như tường gạch, block bê tông thì tấm tường bê tông đúc sẵn này có tuổi thọ cao hơn, giảm chi phí sử dụng vật liệu hơn do có chiều dày nhỏ hơn chỉ khoảng 68 – 140 mm nên còn giúp tiết kiệm không gian lắp đặt tăng diện tích sử dụng cho nhà ở hoặc công trình.",
                ClientId = 97,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-198),
                UpdatedAt
             = DateTime.Now.AddDays(-198)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 98,
                Name = "Gạch men và sứ vệ sinh kháng khuẩn",
                Description = "Đây là dòng sản phẩm với khả năng tự tiêu diệt vi khuẩn khi bám trên bề mặt sản phẩm. Ở nước ngoài đây là loại vật liệu chủ yếu dùng trong các cơ sở y tế và bệnh viện. Với lớp men Nano phun trực tiếp lên sản phẩm và nung ở nhiệt độ 1200 – 1250 độ C, giúp cho lớp men này trở nên siêu bền trên bề mặt, chống bám dính, ổ bẩn cũng như góp phần tăng độ nhẵn mịn bóng loáng cho sản phẩm.",
                ClientId = 98,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-197),
                UpdatedAt
             = DateTime.Now.AddDays(-197)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 99,
                Name = "METRO STAR",
                Description = "Metro Star có vị trí đắc địa ở địa chỉ 360 Xa Lộ Hà Nội, nằm trong khu dân cư đông đúc, sôi động của cửa ngõ phía Đông Sài Gòn - nơi có hai mặt tiền đường là Xa lộ Hà Nội và Nam Hòa cùng với công viên cỏ xanh  rộng rãi, thoáng đãng, đặc biệt là dự án hiếm hoi có cầu bộ hành kết nối trực tiếp từ ga Metro số 10 đi vào tầng 2 khu dân cư.Metro Star được đầu tư phát triển bởi Công ty Metro Star, trực thuộc Tổng Công ty C.T Land (thành viên Tập đoàn C.T Group - Tập đoàn đa ngành hàng đầu Việt Nam), mang đến một “siêu phẩm” độc đáo về kiến trúc, chất lượng xây dựng tiêu chuẩn Singapore và 100+ tiện ích đậm chất quốc đảo sư tử.",
                ClientId = 99,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-196),
                UpdatedAt
             = DateTime.Now.AddDays(-196)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 100,
                Name = "C.T PLAZA",
                Description = "C.T Plaza là một thương hiệu nhà ở và thương mại văn phòng rất đặc biệt, là sự kết hợp hài hòa giữa 3 đỉnh cao: Nghệ thuật của Tạo hóa là Thiên nhiên tươi đẹp, Nghệ thuật của Nhân loại là Kiến trúc, Hội họa, Âm nhạc, Phim ảnh…và đẹp hơn hết là Con người với cái đẹp của thân thể và tâm hồn…nơi con người có thể nâng cuộc sống hằng ngày lên thành Nghệ thuật sống cuộc đời (Living Art) để mỗi người hạnh phúc tuyệt vời theo cách riêng trong ngôi nhà của mình (A Life Style Home Brand).",
                ClientId = 100,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-195),
                UpdatedAt
             = DateTime.Now.AddDays(-195)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 101,
                Name = "I-HOME",
                Description = "Thương hiệu I-Home cực kỳ mới lạ và đặc biệt yêu thích bởi giới trẻ với concept rất thú vị và giá rất nice. Là sự kết hợp giữa Home và Internet trong 1 thế giới phẳng. Khu I-Home tại 359 Phạm Văn Chiêu, Q.Gò Vấp với vị trí thuận lợi, tiện ích nội khu vượt trội, thiết kế thông minh, nội thất cao cấp nhưng giá chỉ bằng giá nhà ở xã hội, Khai trương và vận hành chính thức tòa nhà vào đầu tháng 04/2017.",
                ClientId = 101,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-194),
                UpdatedAt
             = DateTime.Now.AddDays(-194)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 102,
                Name = "The Zen Park",
                Description = "Tổng diện tích đất: 28.834 m2 Tổng số tòa: 4 (R1.01, R1.02, R1.03, R1.05) Số tầng mỗi tòa: 31 tầng nổi Diện tích tầng hầm: ~ 24.000 m2 Diện tích cây xanh: 6.208 m2 Diện tích mặt nước Hồ cá Koi: 692 m2 Toà mở bán: 2 toà (R1.02 & R1.05) Số lượng mở bán - 7 loại căn hộ: Studio (52 căn) : 1PN: 271 căn, 1PN+1: 263 căn, 2PN: 224 căn, 2PN+1: 85 căn, 3PN: 31 căn, 3PN+1: 35 cănCác loại căn hộ diện tích linh hoạt (từ 28m2 đến 95 m2)",
                ClientId = 102,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-193),
                UpdatedAt
             = DateTime.Now.AddDays(-193)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 103,
                Name = "Vinhome Ocean Park",
                Description = "Được quy hoạch bởi đơn vị tư vấn thiết kế hàng đầu thế giới EDSA, với mật độ xây dựng thấp chỉ gần 19% Vinhomes Ocean Park mang tầm vóc một đại đô thị đồng bộ tiện ích như Đảo quốc Singapore. Và hơn thế nữa, dự án sở hữu những đại tiện ích và cảnh quan quy mô tầm cỡ, mới mẻ như Công viên Gym ngoài trời, Công viên BBQ rộng lớn trên nền tảng không gian cây xanh, mặt nước đa dạng.",
                ClientId = 103,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-192),
                UpdatedAt
             = DateTime.Now.AddDays(-192)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 104,
                Name = "VegaCity",
                Description = "Với muôn vàn cung bậc của trái tim, từ êm đềm thảnh thơi đến cháy bừng hứng khởi, Vega Continental Shopping Plaza mang đậm cảm hứng cuộc đại hải trình vĩ đại, nơi nhịp sống rộn ràng không ngừng nghỉ, thắp sáng lên một khung trời lễ hội.",
                ClientId = 104,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-191),
                UpdatedAt
             = DateTime.Now.AddDays(-191)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 105,
                Name = "Shophouse Bình Minh Garden",
                Description = "Vị trí: Số 93 phố Đức Giang, phường Đức Giang, quận Long Biên, Hà Nội Chủ đầu tư: Công ty cổ phần đầu tư và phát triển BĐS Thế Kỷ - Cen Invest Diện tích khu thấp tầng: 9.511m2 Mật độ xây dựng thấp tầng: 70% Nhà thầu thiết kế: Công ty CP tư vấn AA (AA – Corp)",
                ClientId = 105,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-190),
                UpdatedAt
             = DateTime.Now.AddDays(-190)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 106,
                Name = "Chung cư Bình Minh Garden",
                Description = "Được định hướng phát triển cuộc sống năng động, đầy đủ, mọi tiện ích phục vụ nhu cầu hàng ngày của cư dân được bố trí ngay trong nội khu dự án từ ăn uống, mua sắm, dịch vụ làm đẹp, ngân hàng,…",
                ClientId = 106,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-189),
                UpdatedAt
             = DateTime.Now.AddDays(-189)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 107,
                Name = "Chung Cư Cao Cấp I Tower Quy Nhơn",
                Description = "I–Tower Quy Nhơn là dự án chung cư căn hộ thương mại cao cấp được UBND tỉnh chấp thuận chủ trương đầu tư từ đầu năm 2015 do Công ty CP Đầu tư Phát triển bất động sản Đô Thành làm chủ đầu tư. Đây là dự án sở hữu vị trí “Vàng” ngay trung tâm Tp biển Quy Nhơn.",
                ClientId = 107,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-188),
                UpdatedAt
             = DateTime.Now.AddDays(-188)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 108,
                Name = "La Queenara Hội An",
                Description = "Lấy cảm hứng thiết kế từ câu chuyện di sản và con người Hội An, La Queenara gây ấn tượng  với hệ sinh thái 200 tiện ích phức hợp, tạo nên tổng thể hài hòa kiến tạo cộng đồng tinh hoa ngay trong lòng thành phố di sản: ",
                ClientId = 108,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-187),
                UpdatedAt
             = DateTime.Now.AddDays(-187)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 109,
                Name = "Samsora Premier 108",
                Description = "Samsora Premier là dự án chung cư nằm ngay trên mặt đường Chu Văn An huyết mạch kết nối giao thông phía Đông Bắc và Tây Nam thành phố. Dự án được nhiều khách hàng biết tới với quy hoạch hiện đại và hạ tầng tiện ích đầu tư chất lượng.",
                ClientId = 109,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-186),
                UpdatedAt
             = DateTime.Now.AddDays(-186)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 110,
                Name = "Vườn Vua Resort & Villas",
                Description = "Từ thủ đô Hà Nội đi theo đường Đại Lộ Thăng Long, qua Làng Văn hóa các Dân tộc Việt Nam, lên thẳng Đá Chông (khu di tích K9), qua Cầu Đồng Quang - Phà Đá Chông vượt Sông Đà 2km là đến Vườn Vua, với khoảng 65km từ Hà Nội. Nếu đi theo đường quốc lộ 32 qua cầu Trung Hà, qua huyện lỵ Thanh Thuỷ đến Vườn Vua khoảng 85km.",
                ClientId = 110,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-185),
                UpdatedAt
             = DateTime.Now.AddDays(-185)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 111,
                Name = "Khai Sơn Town",
                Description = "Nằm cách phố cổ chỉ 10 phút di chuyển, dự án Khai Sơn Town thuộc quần thể đô thị Khai Sơn City Long Biên được thừa hưởng nhiều ưu thế để phát triển mạnh mẽ trong tương lai. Dự án không chỉ có ưu thế về liên kết hạ tầng giao thông, tiện ích, mà còn có nhiều tiềm năng tăng giá, xứng đáng là khoản đầu tư không thể bỏ qua của các nhà đầu tư.",
                ClientId = 111,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-184),
                UpdatedAt
             = DateTime.Now.AddDays(-184)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 112,
                Name = "Mercedes-Benz GLS 600 Maybach",
                Description = "Tình trạng Mới Năm sản xuất 2021 Kiểu dáng SUV Xuất xứ Nhập khẩu Hộp số Số tự động",
                ClientId = 112,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-183),
                UpdatedAt
             = DateTime.Now.AddDays(-183)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 113,
                Name = "Toyota Crown Royal Saloon 3.0 MT bản full",
                Description = "Tình trạng Đã qua sử dụng Số km đã đi 32.000 km Năm sản xuất 1998 Kiểu dáng Sedan Xuất xứ Nhập khẩu Hộp số Số tay",
                ClientId = 113,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-182),
                UpdatedAt
             = DateTime.Now.AddDays(-182)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 114,
                Name = "Xe tải Hino FG tải 8 tấn thùng dài",
                Description = "Tình trạng Mới Năm sản xuất 2020 Kiểu dáng Truck Xuất xứ Lắp ráp Hộp số Số tay Địa chỉ rao bán Tp.HCM",
                ClientId = 114,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-181),
                UpdatedAt
             = DateTime.Now.AddDays(-181)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 115,
                Name = "Kia Cerato 2.0AT",
                Description = "Tình trạng Đã qua sử dụng Số km đã đi 12.000 km Năm sản xuất 2019 Kiểu dáng Sedan Hộp số Số tự động Địa chỉ rao bán Tp.HCM",
                ClientId = 115,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-180),
                UpdatedAt
             = DateTime.Now.AddDays(-180)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 116,
                Name = "Toyota Land Cruiser 2001",
                Description = "Tình trạng Đã qua sử dụng Số km đã đi 18.000 km Năm sản xuất 1998 Kiểu dáng SUV Xuất xứ Nhập khẩu Hộp số Số tay Địa chỉ rao bán Hà Nội",
                ClientId = 116,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-179),
                UpdatedAt
             = DateTime.Now.AddDays(-179)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 117,
                Name = "Lexus RX 350 F-Sport 2019",
                Description = "Tình trạng Đã qua sử dụngSố km đã đi22.000 kmNăm sản xuất2016Kiểu dángSUVXuất xứNhập khẩuHộp sốSố tự động",
                ClientId = 117,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-178),
                UpdatedAt
             = DateTime.Now.AddDays(-178)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 118,
                Name = "Mercedes G63 Edition 4",
                Description = "Tình trạng Mới Năm sản xuất 2021 Kiểu dáng SUV Xuất xứ Nhập khẩu Hộp số Số tự động Địa chỉ rao bán Hà Nội",
                ClientId = 118,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-177),
                UpdatedAt
             = DateTime.Now.AddDays(-177)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 119,
                Name = "Mazda CX 5 2022",
                Description = "Tình trạng Đã qua sử dụng Số km đã đi 27.000 km Năm sản xuất 2019 Kiểu dáng SUV Hộp số Số tự động Địa chỉ rao bán Tp.HCM",
                ClientId = 119,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-176),
                UpdatedAt
             = DateTime.Now.AddDays(-176)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 120,
                Name = "Volkswagen T-Cross",
                Description = "Cùng với Teramont, Volkswagen T-Cross 2021 được đồn đoán là mẫu xe hoàn toàn mới sẽ gia nhập đội hình sản phẩm xe hơi của Volkswagen (VW) tại Việt Nam trong năm 2021. Hiện tại, VW Việt Nam vẫn chưa tiết lộ bất cứ thông tin nào về kế hoạch ra mắt T-Cross 2021 tại Việt Nam.",
                ClientId = 120,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-175),
                UpdatedAt
             = DateTime.Now.AddDays(-175)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 121,
                Name = "Dự án The Filmore Đà Nẵng",
                Description = "Diện tích khu đất 1.504,2 m2 với quy mô 25 tầng nổi, 3 tầng hầm và 206 căn hộ cao cấp (gồm các căn hộ 1 phòng ngủ, 2 phòng ngủ, 3 phòng ngủ - Duplex, Dual Key). Tổng diện tích sàn xây dựng hơn 22.600 m2, diện tích sàn nhà ở khoảng 12.876 m2, diện tích sàn sử dụng thương mại dịch vụ gần 300 m2. Mật độ xây dựng khối đế 55,6%, khối tháp 47,8%. Dự án dự kiến hoàn thành và bàn giao vào quý IV/2022.",
                ClientId = 121,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-204),
                UpdatedAt
             = DateTime.Now.AddDays(-204)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 122,
                Name = "Ô tô điện thông minh vf-e38",
                Description = "Thuộc phân khúc C, từng được công bố vào tháng 1/2021 với tên mã VF31. Xe có chiều dài cơ sở 2.611mm, kích thước các chiều dài x rộng x cao là 4.300 x 1.793 x 1.613 (mm), khoảng sáng gầm xe 180mm, trọng lượng không tải 1.490kg. VinFast VF e34 được trang bị một động cơ điện có công suất tối đa 110 kW ( 147 HP), mô-men xoắn cực đại 242 Nm cùng hệ dẫn động cầu trước, hệ thống treo trước MacPherson, hệ thống treo sau dạng thanh xoắn. Xe sử dụng một bộ pin dung lượng 42kWh, có thể đi được quãng đường 300km sau mỗi lần sạc đầy. Để minh chứng cho đẳng cấp, chất lượng và tạo sự an tâm cho khách hàng, VinFast tiên phong áp dụng chính sách bảo hành lên tới 10 năm cho xe VF e38",
                ClientId = 122,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-203),
                UpdatedAt
             = DateTime.Now.AddDays(-203)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 123,
                Name = "Xi măng Nghi Sơn đa dụng",
                Description = "chất lượng PCB40, được sản xuất từ công nghệ Nhật tiên tiến, chất lượng được kiểm soát bởi các chuyên gia Nhật Bản",
                ClientId = 123,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-202),
                UpdatedAt
             = DateTime.Now.AddDays(-202)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 124,
                Name = "Gạch bê tông AAC",
                Description = "Gạch bê tông AAC (viết tắt của ba từ tiếng Anh là “Aerated Autoclaved Concrete”) hay còn có tên là “gạch bê tông khí chưng áp” đây là loại vật liệu mới trong xây dựng với kết cấu bê tông gồm các bọt khí nhỏ. Mặc dù đã xuất hiện và bắt đầu sử dụng trên Thế Giới gần 1 thế kỷ trước. Tuy nhiên đến năm 2008 Việt Nam mới bắt đầu nhập khẩu và sử dụng loại vật liệu này.Đây được xem là vật liệu xanh vì có thể tái sử dụng. Được sản xuất bằng công nghệ khí chưng áp từ các nguyên liệu như cát, vôi, thạch cao, xi măng, bột nhôm và không gây ô nhiễm nên thân thiện môi trường.",
                ClientId = 124,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-201),
                UpdatedAt
             = DateTime.Now.AddDays(-201)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 125,
                Name = "Tấm panel ALC",
                Description = "ALC (Autoclaced Lightweight Aerated Concrete) hay được gọi là “Bê tông gia khí chưng áp. Tấm tường Panel được sản xuất bằng các nguyên liệu giống với nguyên liệu tạo ra sản phẩm gạch nhẹ AAC. Với khả năng chịu lực cao, tấm ALC được chế tạo bằng 2 lớp thép (thép nguội), cấu trúc không gian 3 chiều nên tạo ra một bộ khung cứng và vững chắc. Ứng dụng để làm tường, sàn, cầu thang, mái,… Có thể gia công cưa, cắt, khoan hay đóng đinh một cách đơn giản, tốn ít thời gian, quá trình lắp đặt nhanh chóng thuận tiện.",
                ClientId = 125,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-200),
                UpdatedAt
             = DateTime.Now.AddDays(-200)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 126,
                Name = "Xi măng công nghệ nano",
                Description = "Đây là sản phẩm vật liệu mới trong xây dựng nhà ở và công trình. Sản phẩm có độ cứng và độ bền vượt trội. Với công thức độc đáo đây là công nghệ vật liệu mới trong xây dựng – công nghệ độc quyền của SCG giúp cải tiến chất lượng xi măng, các phân tử xi măng tạo ra ở kích thước nano nên tạo ra liên kết vô cùng chặt chẽ nên giảm thiểu khả năng nứt, rò rỉ của công trình một trong những nguyên nhân gây ra chính là do các lỗ rỗng trong quá trình trộn bê tông tạo ra khi sử dụng xi măng cũ tiếp xúc với các tác nhân môi trường như nắng, gió, mưa,..",
                ClientId = 126,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-199),
                UpdatedAt
             = DateTime.Now.AddDays(-199)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 127,
                Name = "Tấm tường bê tông đúc sẵn",
                Description = "Ưu điểm dễ dàng thi công lắp đặt với 6m2 tường chỉ cần 3 công nhân làm việc trong 1 giờ đồng hồ nên giúp tiết kiệm nhân lực lao động. So với các loại truyền thống như tường gạch, block bê tông thì tấm tường bê tông đúc sẵn này có tuổi thọ cao hơn, giảm chi phí sử dụng vật liệu hơn do có chiều dày nhỏ hơn chỉ khoảng 68 – 140 mm nên còn giúp tiết kiệm không gian lắp đặt tăng diện tích sử dụng cho nhà ở hoặc công trình.",
                ClientId = 127,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-198),
                UpdatedAt
             = DateTime.Now.AddDays(-198)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 128,
                Name = "Gạch men và sứ vệ sinh kháng khuẩn",
                Description = "Đây là dòng sản phẩm với khả năng tự tiêu diệt vi khuẩn khi bám trên bề mặt sản phẩm. Ở nước ngoài đây là loại vật liệu chủ yếu dùng trong các cơ sở y tế và bệnh viện. Với lớp men Nano phun trực tiếp lên sản phẩm và nung ở nhiệt độ 1200 – 1250 độ C, giúp cho lớp men này trở nên siêu bền trên bề mặt, chống bám dính, ổ bẩn cũng như góp phần tăng độ nhẵn mịn bóng loáng cho sản phẩm.",
                ClientId = 128,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-197),
                UpdatedAt
             = DateTime.Now.AddDays(-197)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 129,
                Name = "METRO STAR",
                Description = "Metro Star có vị trí đắc địa ở địa chỉ 360 Xa Lộ Hà Nội, nằm trong khu dân cư đông đúc, sôi động của cửa ngõ phía Đông Sài Gòn - nơi có hai mặt tiền đường là Xa lộ Hà Nội và Nam Hòa cùng với công viên cỏ xanh  rộng rãi, thoáng đãng, đặc biệt là dự án hiếm hoi có cầu bộ hành kết nối trực tiếp từ ga Metro số 10 đi vào tầng 2 khu dân cư.Metro Star được đầu tư phát triển bởi Công ty Metro Star, trực thuộc Tổng Công ty C.T Land (thành viên Tập đoàn C.T Group - Tập đoàn đa ngành hàng đầu Việt Nam), mang đến một “siêu phẩm” độc đáo về kiến trúc, chất lượng xây dựng tiêu chuẩn Singapore và 100+ tiện ích đậm chất quốc đảo sư tử.",
                ClientId = 129,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-196),
                UpdatedAt
             = DateTime.Now.AddDays(-196)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 130,
                Name = "C.T PLAZA",
                Description = "C.T Plaza là một thương hiệu nhà ở và thương mại văn phòng rất đặc biệt, là sự kết hợp hài hòa giữa 3 đỉnh cao: Nghệ thuật của Tạo hóa là Thiên nhiên tươi đẹp, Nghệ thuật của Nhân loại là Kiến trúc, Hội họa, Âm nhạc, Phim ảnh…và đẹp hơn hết là Con người với cái đẹp của thân thể và tâm hồn…nơi con người có thể nâng cuộc sống hằng ngày lên thành Nghệ thuật sống cuộc đời (Living Art) để mỗi người hạnh phúc tuyệt vời theo cách riêng trong ngôi nhà của mình (A Life Style Home Brand).",
                ClientId = 130,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-195),
                UpdatedAt
             = DateTime.Now.AddDays(-195)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 131,
                Name = "I-HOME",
                Description = "Thương hiệu I-Home cực kỳ mới lạ và đặc biệt yêu thích bởi giới trẻ với concept rất thú vị và giá rất nice. Là sự kết hợp giữa Home và Internet trong 1 thế giới phẳng. Khu I-Home tại 359 Phạm Văn Chiêu, Q.Gò Vấp với vị trí thuận lợi, tiện ích nội khu vượt trội, thiết kế thông minh, nội thất cao cấp nhưng giá chỉ bằng giá nhà ở xã hội, Khai trương và vận hành chính thức tòa nhà vào đầu tháng 04/2017.",
                ClientId = 131,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-194),
                UpdatedAt
             = DateTime.Now.AddDays(-194)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 132,
                Name = "The Zen Park",
                Description = "Tổng diện tích đất: 28.834 m2 Tổng số tòa: 4 (R1.01, R1.02, R1.03, R1.05) Số tầng mỗi tòa: 31 tầng nổi Diện tích tầng hầm: ~ 24.000 m2 Diện tích cây xanh: 6.208 m2 Diện tích mặt nước Hồ cá Koi: 692 m2 Toà mở bán: 2 toà (R1.02 & R1.05) Số lượng mở bán - 7 loại căn hộ: Studio (52 căn) : 1PN: 271 căn, 1PN+1: 263 căn, 2PN: 224 căn, 2PN+1: 85 căn, 3PN: 31 căn, 3PN+1: 35 cănCác loại căn hộ diện tích linh hoạt (từ 28m2 đến 95 m2)",
                ClientId = 132,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-193),
                UpdatedAt
             = DateTime.Now.AddDays(-193)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 133,
                Name = "Vinhome Ocean Park",
                Description = "Được quy hoạch bởi đơn vị tư vấn thiết kế hàng đầu thế giới EDSA, với mật độ xây dựng thấp chỉ gần 19% Vinhomes Ocean Park mang tầm vóc một đại đô thị đồng bộ tiện ích như Đảo quốc Singapore. Và hơn thế nữa, dự án sở hữu những đại tiện ích và cảnh quan quy mô tầm cỡ, mới mẻ như Công viên Gym ngoài trời, Công viên BBQ rộng lớn trên nền tảng không gian cây xanh, mặt nước đa dạng.",
                ClientId = 133,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-192),
                UpdatedAt
             = DateTime.Now.AddDays(-192)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 134,
                Name = "VegaCity",
                Description = "Với muôn vàn cung bậc của trái tim, từ êm đềm thảnh thơi đến cháy bừng hứng khởi, Vega Continental Shopping Plaza mang đậm cảm hứng cuộc đại hải trình vĩ đại, nơi nhịp sống rộn ràng không ngừng nghỉ, thắp sáng lên một khung trời lễ hội.",
                ClientId = 134,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-191),
                UpdatedAt
             = DateTime.Now.AddDays(-191)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 135,
                Name = "Shophouse Bình Minh Garden",
                Description = "Vị trí: Số 93 phố Đức Giang, phường Đức Giang, quận Long Biên, Hà Nội Chủ đầu tư: Công ty cổ phần đầu tư và phát triển BĐS Thế Kỷ - Cen Invest Diện tích khu thấp tầng: 9.511m2 Mật độ xây dựng thấp tầng: 70% Nhà thầu thiết kế: Công ty CP tư vấn AA (AA – Corp)",
                ClientId = 135,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-190),
                UpdatedAt
             = DateTime.Now.AddDays(-190)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 136,
                Name = "Chung cư Bình Minh Garden",
                Description = "Được định hướng phát triển cuộc sống năng động, đầy đủ, mọi tiện ích phục vụ nhu cầu hàng ngày của cư dân được bố trí ngay trong nội khu dự án từ ăn uống, mua sắm, dịch vụ làm đẹp, ngân hàng,…",
                ClientId = 136,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-189),
                UpdatedAt
             = DateTime.Now.AddDays(-189)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 137,
                Name = "Chung Cư Cao Cấp I Tower Quy Nhơn",
                Description = "I–Tower Quy Nhơn là dự án chung cư căn hộ thương mại cao cấp được UBND tỉnh chấp thuận chủ trương đầu tư từ đầu năm 2015 do Công ty CP Đầu tư Phát triển bất động sản Đô Thành làm chủ đầu tư. Đây là dự án sở hữu vị trí “Vàng” ngay trung tâm Tp biển Quy Nhơn.",
                ClientId = 137,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-188),
                UpdatedAt
             = DateTime.Now.AddDays(-188)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 138,
                Name = "La Queenara Hội An",
                Description = "Lấy cảm hứng thiết kế từ câu chuyện di sản và con người Hội An, La Queenara gây ấn tượng  với hệ sinh thái 200 tiện ích phức hợp, tạo nên tổng thể hài hòa kiến tạo cộng đồng tinh hoa ngay trong lòng thành phố di sản: ",
                ClientId = 138,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-187),
                UpdatedAt
             = DateTime.Now.AddDays(-187)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 139,
                Name = "Samsora Premier 109",
                Description = "Samsora Premier là dự án chung cư nằm ngay trên mặt đường Chu Văn An huyết mạch kết nối giao thông phía Đông Bắc và Tây Nam thành phố. Dự án được nhiều khách hàng biết tới với quy hoạch hiện đại và hạ tầng tiện ích đầu tư chất lượng.",
                ClientId = 139,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-186),
                UpdatedAt
             = DateTime.Now.AddDays(-186)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 140,
                Name = "Vườn Vua Resort & Villas",
                Description = "Từ thủ đô Hà Nội đi theo đường Đại Lộ Thăng Long, qua Làng Văn hóa các Dân tộc Việt Nam, lên thẳng Đá Chông (khu di tích K9), qua Cầu Đồng Quang - Phà Đá Chông vượt Sông Đà 2km là đến Vườn Vua, với khoảng 65km từ Hà Nội. Nếu đi theo đường quốc lộ 32 qua cầu Trung Hà, qua huyện lỵ Thanh Thuỷ đến Vườn Vua khoảng 85km.",
                ClientId = 140,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-185),
                UpdatedAt
             = DateTime.Now.AddDays(-185)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 141,
                Name = "Khai Sơn Town",
                Description = "Nằm cách phố cổ chỉ 10 phút di chuyển, dự án Khai Sơn Town thuộc quần thể đô thị Khai Sơn City Long Biên được thừa hưởng nhiều ưu thế để phát triển mạnh mẽ trong tương lai. Dự án không chỉ có ưu thế về liên kết hạ tầng giao thông, tiện ích, mà còn có nhiều tiềm năng tăng giá, xứng đáng là khoản đầu tư không thể bỏ qua của các nhà đầu tư.",
                ClientId = 141,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-184),
                UpdatedAt
             = DateTime.Now.AddDays(-184)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 142,
                Name = "Mercedes-Benz GLS 600 Maybach",
                Description = "Tình trạng Mới Năm sản xuất 2021 Kiểu dáng SUV Xuất xứ Nhập khẩu Hộp số Số tự động",
                ClientId = 142,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-183),
                UpdatedAt
             = DateTime.Now.AddDays(-183)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 143,
                Name = "Toyota Crown Royal Saloon 3.0 MT bản full",
                Description = "Tình trạng Đã qua sử dụng Số km đã đi 32.000 km Năm sản xuất 1998 Kiểu dáng Sedan Xuất xứ Nhập khẩu Hộp số Số tay",
                ClientId = 143,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-182),
                UpdatedAt
             = DateTime.Now.AddDays(-182)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 144,
                Name = "Xe tải Hino FG tải 8 tấn thùng dài",
                Description = "Tình trạng Mới Năm sản xuất 2020 Kiểu dáng Truck Xuất xứ Lắp ráp Hộp số Số tay Địa chỉ rao bán Tp.HCM",
                ClientId = 144,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-181),
                UpdatedAt
             = DateTime.Now.AddDays(-181)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 145,
                Name = "Kia Cerato 2.0AT",
                Description = "Tình trạng Đã qua sử dụng Số km đã đi 12.000 km Năm sản xuất 2019 Kiểu dáng Sedan Hộp số Số tự động Địa chỉ rao bán Tp.HCM",
                ClientId = 145,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-180),
                UpdatedAt
             = DateTime.Now.AddDays(-180)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 146,
                Name = "Toyota Land Cruiser 2002",
                Description = "Tình trạng Đã qua sử dụng Số km đã đi 18.000 km Năm sản xuất 1998 Kiểu dáng SUV Xuất xứ Nhập khẩu Hộp số Số tay Địa chỉ rao bán Hà Nội",
                ClientId = 146,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-179),
                UpdatedAt
             = DateTime.Now.AddDays(-179)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 147,
                Name = "Lexus RX 350 F-Sport 2020",
                Description = "Tình trạng Đã qua sử dụngSố km đã đi22.000 kmNăm sản xuất2016Kiểu dángSUVXuất xứNhập khẩuHộp sốSố tự động",
                ClientId = 147,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-178),
                UpdatedAt
             = DateTime.Now.AddDays(-178)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 148,
                Name = "Mercedes G63 Edition 5",
                Description = "Tình trạng Mới Năm sản xuất 2021 Kiểu dáng SUV Xuất xứ Nhập khẩu Hộp số Số tự động Địa chỉ rao bán Hà Nội",
                ClientId = 148,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-177),
                UpdatedAt
             = DateTime.Now.AddDays(-177)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 149,
                Name = "Mazda CX 5 2023",
                Description = "Tình trạng Đã qua sử dụng Số km đã đi 27.000 km Năm sản xuất 2019 Kiểu dáng SUV Hộp số Số tự động Địa chỉ rao bán Tp.HCM",
                ClientId = 149,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-176),
                UpdatedAt
             = DateTime.Now.AddDays(-176)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 150,
                Name = "Volkswagen T-Cross",
                Description = "Cùng với Teramont, Volkswagen T-Cross 2021 được đồn đoán là mẫu xe hoàn toàn mới sẽ gia nhập đội hình sản phẩm xe hơi của Volkswagen (VW) tại Việt Nam trong năm 2021. Hiện tại, VW Việt Nam vẫn chưa tiết lộ bất cứ thông tin nào về kế hoạch ra mắt T-Cross 2021 tại Việt Nam.",
                ClientId = 150,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-175),
                UpdatedAt
             = DateTime.Now.AddDays(-175)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 151,
                Name = "Dự án The Filmore Đà Nẵng",
                Description = "Diện tích khu đất 1.504,2 m2 với quy mô 25 tầng nổi, 3 tầng hầm và 206 căn hộ cao cấp (gồm các căn hộ 1 phòng ngủ, 2 phòng ngủ, 3 phòng ngủ - Duplex, Dual Key). Tổng diện tích sàn xây dựng hơn 22.600 m2, diện tích sàn nhà ở khoảng 12.876 m2, diện tích sàn sử dụng thương mại dịch vụ gần 300 m2. Mật độ xây dựng khối đế 55,6%, khối tháp 47,8%. Dự án dự kiến hoàn thành và bàn giao vào quý IV/2022.",
                ClientId = 151,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-204),
                UpdatedAt
             = DateTime.Now.AddDays(-204)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 152,
                Name = "Ô tô điện thông minh vf-e39",
                Description = "Thuộc phân khúc C, từng được công bố vào tháng 1/2021 với tên mã VF31. Xe có chiều dài cơ sở 2.611mm, kích thước các chiều dài x rộng x cao là 4.300 x 1.793 x 1.613 (mm), khoảng sáng gầm xe 180mm, trọng lượng không tải 1.490kg. VinFast VF e34 được trang bị một động cơ điện có công suất tối đa 110 kW ( 147 HP), mô-men xoắn cực đại 242 Nm cùng hệ dẫn động cầu trước, hệ thống treo trước MacPherson, hệ thống treo sau dạng thanh xoắn. Xe sử dụng một bộ pin dung lượng 42kWh, có thể đi được quãng đường 300km sau mỗi lần sạc đầy. Để minh chứng cho đẳng cấp, chất lượng và tạo sự an tâm cho khách hàng, VinFast tiên phong áp dụng chính sách bảo hành lên tới 10 năm cho xe VF e39",
                ClientId = 152,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-203),
                UpdatedAt
             = DateTime.Now.AddDays(-203)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 153,
                Name = "Xi măng Nghi Sơn đa dụng",
                Description = "chất lượng PCB40, được sản xuất từ công nghệ Nhật tiên tiến, chất lượng được kiểm soát bởi các chuyên gia Nhật Bản",
                ClientId = 153,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-202),
                UpdatedAt
             = DateTime.Now.AddDays(-202)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 154,
                Name = "Gạch bê tông AAC",
                Description = "Gạch bê tông AAC (viết tắt của ba từ tiếng Anh là “Aerated Autoclaved Concrete”) hay còn có tên là “gạch bê tông khí chưng áp” đây là loại vật liệu mới trong xây dựng với kết cấu bê tông gồm các bọt khí nhỏ. Mặc dù đã xuất hiện và bắt đầu sử dụng trên Thế Giới gần 1 thế kỷ trước. Tuy nhiên đến năm 2008 Việt Nam mới bắt đầu nhập khẩu và sử dụng loại vật liệu này.Đây được xem là vật liệu xanh vì có thể tái sử dụng. Được sản xuất bằng công nghệ khí chưng áp từ các nguyên liệu như cát, vôi, thạch cao, xi măng, bột nhôm và không gây ô nhiễm nên thân thiện môi trường.",
                ClientId = 154,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-201),
                UpdatedAt
             = DateTime.Now.AddDays(-201)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 155,
                Name = "Tấm panel ALC",
                Description = "ALC (Autoclaced Lightweight Aerated Concrete) hay được gọi là “Bê tông gia khí chưng áp. Tấm tường Panel được sản xuất bằng các nguyên liệu giống với nguyên liệu tạo ra sản phẩm gạch nhẹ AAC. Với khả năng chịu lực cao, tấm ALC được chế tạo bằng 2 lớp thép (thép nguội), cấu trúc không gian 3 chiều nên tạo ra một bộ khung cứng và vững chắc. Ứng dụng để làm tường, sàn, cầu thang, mái,… Có thể gia công cưa, cắt, khoan hay đóng đinh một cách đơn giản, tốn ít thời gian, quá trình lắp đặt nhanh chóng thuận tiện.",
                ClientId = 155,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-200),
                UpdatedAt
             = DateTime.Now.AddDays(-200)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 156,
                Name = "Xi măng công nghệ nano",
                Description = "Đây là sản phẩm vật liệu mới trong xây dựng nhà ở và công trình. Sản phẩm có độ cứng và độ bền vượt trội. Với công thức độc đáo đây là công nghệ vật liệu mới trong xây dựng – công nghệ độc quyền của SCG giúp cải tiến chất lượng xi măng, các phân tử xi măng tạo ra ở kích thước nano nên tạo ra liên kết vô cùng chặt chẽ nên giảm thiểu khả năng nứt, rò rỉ của công trình một trong những nguyên nhân gây ra chính là do các lỗ rỗng trong quá trình trộn bê tông tạo ra khi sử dụng xi măng cũ tiếp xúc với các tác nhân môi trường như nắng, gió, mưa,..",
                ClientId = 156,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-199),
                UpdatedAt
             = DateTime.Now.AddDays(-199)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 157,
                Name = "Tấm tường bê tông đúc sẵn",
                Description = "Ưu điểm dễ dàng thi công lắp đặt với 6m2 tường chỉ cần 3 công nhân làm việc trong 1 giờ đồng hồ nên giúp tiết kiệm nhân lực lao động. So với các loại truyền thống như tường gạch, block bê tông thì tấm tường bê tông đúc sẵn này có tuổi thọ cao hơn, giảm chi phí sử dụng vật liệu hơn do có chiều dày nhỏ hơn chỉ khoảng 68 – 140 mm nên còn giúp tiết kiệm không gian lắp đặt tăng diện tích sử dụng cho nhà ở hoặc công trình.",
                ClientId = 157,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-198),
                UpdatedAt
             = DateTime.Now.AddDays(-198)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 158,
                Name = "Gạch men và sứ vệ sinh kháng khuẩn",
                Description = "Đây là dòng sản phẩm với khả năng tự tiêu diệt vi khuẩn khi bám trên bề mặt sản phẩm. Ở nước ngoài đây là loại vật liệu chủ yếu dùng trong các cơ sở y tế và bệnh viện. Với lớp men Nano phun trực tiếp lên sản phẩm và nung ở nhiệt độ 1200 – 1250 độ C, giúp cho lớp men này trở nên siêu bền trên bề mặt, chống bám dính, ổ bẩn cũng như góp phần tăng độ nhẵn mịn bóng loáng cho sản phẩm.",
                ClientId = 158,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-197),
                UpdatedAt
             = DateTime.Now.AddDays(-197)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 159,
                Name = "METRO STAR",
                Description = "Metro Star có vị trí đắc địa ở địa chỉ 360 Xa Lộ Hà Nội, nằm trong khu dân cư đông đúc, sôi động của cửa ngõ phía Đông Sài Gòn - nơi có hai mặt tiền đường là Xa lộ Hà Nội và Nam Hòa cùng với công viên cỏ xanh  rộng rãi, thoáng đãng, đặc biệt là dự án hiếm hoi có cầu bộ hành kết nối trực tiếp từ ga Metro số 10 đi vào tầng 2 khu dân cư.Metro Star được đầu tư phát triển bởi Công ty Metro Star, trực thuộc Tổng Công ty C.T Land (thành viên Tập đoàn C.T Group - Tập đoàn đa ngành hàng đầu Việt Nam), mang đến một “siêu phẩm” độc đáo về kiến trúc, chất lượng xây dựng tiêu chuẩn Singapore và 100+ tiện ích đậm chất quốc đảo sư tử.",
                ClientId = 159,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-196),
                UpdatedAt
             = DateTime.Now.AddDays(-196)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 160,
                Name = "C.T PLAZA",
                Description = "C.T Plaza là một thương hiệu nhà ở và thương mại văn phòng rất đặc biệt, là sự kết hợp hài hòa giữa 3 đỉnh cao: Nghệ thuật của Tạo hóa là Thiên nhiên tươi đẹp, Nghệ thuật của Nhân loại là Kiến trúc, Hội họa, Âm nhạc, Phim ảnh…và đẹp hơn hết là Con người với cái đẹp của thân thể và tâm hồn…nơi con người có thể nâng cuộc sống hằng ngày lên thành Nghệ thuật sống cuộc đời (Living Art) để mỗi người hạnh phúc tuyệt vời theo cách riêng trong ngôi nhà của mình (A Life Style Home Brand).",
                ClientId = 160,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-195),
                UpdatedAt
             = DateTime.Now.AddDays(-195)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 161,
                Name = "I-HOME",
                Description = "Thương hiệu I-Home cực kỳ mới lạ và đặc biệt yêu thích bởi giới trẻ với concept rất thú vị và giá rất nice. Là sự kết hợp giữa Home và Internet trong 1 thế giới phẳng. Khu I-Home tại 359 Phạm Văn Chiêu, Q.Gò Vấp với vị trí thuận lợi, tiện ích nội khu vượt trội, thiết kế thông minh, nội thất cao cấp nhưng giá chỉ bằng giá nhà ở xã hội, Khai trương và vận hành chính thức tòa nhà vào đầu tháng 04/2017.",
                ClientId = 161,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-194),
                UpdatedAt
             = DateTime.Now.AddDays(-194)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 162,
                Name = "The Zen Park",
                Description = "Tổng diện tích đất: 28.834 m2 Tổng số tòa: 4 (R1.01, R1.02, R1.03, R1.05) Số tầng mỗi tòa: 31 tầng nổi Diện tích tầng hầm: ~ 24.000 m2 Diện tích cây xanh: 6.208 m2 Diện tích mặt nước Hồ cá Koi: 692 m2 Toà mở bán: 2 toà (R1.02 & R1.05) Số lượng mở bán - 7 loại căn hộ: Studio (52 căn) : 1PN: 271 căn, 1PN+1: 263 căn, 2PN: 224 căn, 2PN+1: 85 căn, 3PN: 31 căn, 3PN+1: 35 cănCác loại căn hộ diện tích linh hoạt (từ 28m2 đến 95 m2)",
                ClientId = 162,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-193),
                UpdatedAt
             = DateTime.Now.AddDays(-193)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 163,
                Name = "Vinhome Ocean Park",
                Description = "Được quy hoạch bởi đơn vị tư vấn thiết kế hàng đầu thế giới EDSA, với mật độ xây dựng thấp chỉ gần 19% Vinhomes Ocean Park mang tầm vóc một đại đô thị đồng bộ tiện ích như Đảo quốc Singapore. Và hơn thế nữa, dự án sở hữu những đại tiện ích và cảnh quan quy mô tầm cỡ, mới mẻ như Công viên Gym ngoài trời, Công viên BBQ rộng lớn trên nền tảng không gian cây xanh, mặt nước đa dạng.",
                ClientId = 163,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-192),
                UpdatedAt
             = DateTime.Now.AddDays(-192)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 164,
                Name = "VegaCity",
                Description = "Với muôn vàn cung bậc của trái tim, từ êm đềm thảnh thơi đến cháy bừng hứng khởi, Vega Continental Shopping Plaza mang đậm cảm hứng cuộc đại hải trình vĩ đại, nơi nhịp sống rộn ràng không ngừng nghỉ, thắp sáng lên một khung trời lễ hội.",
                ClientId = 164,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-191),
                UpdatedAt
             = DateTime.Now.AddDays(-191)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 165,
                Name = "Shophouse Bình Minh Garden",
                Description = "Vị trí: Số 93 phố Đức Giang, phường Đức Giang, quận Long Biên, Hà Nội Chủ đầu tư: Công ty cổ phần đầu tư và phát triển BĐS Thế Kỷ - Cen Invest Diện tích khu thấp tầng: 9.511m2 Mật độ xây dựng thấp tầng: 70% Nhà thầu thiết kế: Công ty CP tư vấn AA (AA – Corp)",
                ClientId = 165,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-190),
                UpdatedAt
             = DateTime.Now.AddDays(-190)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 166,
                Name = "Chung cư Bình Minh Garden",
                Description = "Được định hướng phát triển cuộc sống năng động, đầy đủ, mọi tiện ích phục vụ nhu cầu hàng ngày của cư dân được bố trí ngay trong nội khu dự án từ ăn uống, mua sắm, dịch vụ làm đẹp, ngân hàng,…",
                ClientId = 166,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-189),
                UpdatedAt
             = DateTime.Now.AddDays(-189)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 167,
                Name = "Chung Cư Cao Cấp I Tower Quy Nhơn",
                Description = "I–Tower Quy Nhơn là dự án chung cư căn hộ thương mại cao cấp được UBND tỉnh chấp thuận chủ trương đầu tư từ đầu năm 2015 do Công ty CP Đầu tư Phát triển bất động sản Đô Thành làm chủ đầu tư. Đây là dự án sở hữu vị trí “Vàng” ngay trung tâm Tp biển Quy Nhơn.",
                ClientId = 167,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-188),
                UpdatedAt
             = DateTime.Now.AddDays(-188)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 168,
                Name = "La Queenara Hội An",
                Description = "Lấy cảm hứng thiết kế từ câu chuyện di sản và con người Hội An, La Queenara gây ấn tượng  với hệ sinh thái 200 tiện ích phức hợp, tạo nên tổng thể hài hòa kiến tạo cộng đồng tinh hoa ngay trong lòng thành phố di sản: ",
                ClientId = 168,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-187),
                UpdatedAt
             = DateTime.Now.AddDays(-187)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 169,
                Name = "Samsora Premier 110",
                Description = "Samsora Premier là dự án chung cư nằm ngay trên mặt đường Chu Văn An huyết mạch kết nối giao thông phía Đông Bắc và Tây Nam thành phố. Dự án được nhiều khách hàng biết tới với quy hoạch hiện đại và hạ tầng tiện ích đầu tư chất lượng.",
                ClientId = 169,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-186),
                UpdatedAt
             = DateTime.Now.AddDays(-186)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 170,
                Name = "Vườn Vua Resort & Villas",
                Description = "Từ thủ đô Hà Nội đi theo đường Đại Lộ Thăng Long, qua Làng Văn hóa các Dân tộc Việt Nam, lên thẳng Đá Chông (khu di tích K9), qua Cầu Đồng Quang - Phà Đá Chông vượt Sông Đà 2km là đến Vườn Vua, với khoảng 65km từ Hà Nội. Nếu đi theo đường quốc lộ 32 qua cầu Trung Hà, qua huyện lỵ Thanh Thuỷ đến Vườn Vua khoảng 85km.",
                ClientId = 170,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-185),
                UpdatedAt
             = DateTime.Now.AddDays(-185)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 171,
                Name = "Khai Sơn Town",
                Description = "Nằm cách phố cổ chỉ 10 phút di chuyển, dự án Khai Sơn Town thuộc quần thể đô thị Khai Sơn City Long Biên được thừa hưởng nhiều ưu thế để phát triển mạnh mẽ trong tương lai. Dự án không chỉ có ưu thế về liên kết hạ tầng giao thông, tiện ích, mà còn có nhiều tiềm năng tăng giá, xứng đáng là khoản đầu tư không thể bỏ qua của các nhà đầu tư.",
                ClientId = 171,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-184),
                UpdatedAt
             = DateTime.Now.AddDays(-184)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 172,
                Name = "Mercedes-Benz GLS 600 Maybach",
                Description = "Tình trạng Mới Năm sản xuất 2021 Kiểu dáng SUV Xuất xứ Nhập khẩu Hộp số Số tự động",
                ClientId = 172,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-183),
                UpdatedAt
             = DateTime.Now.AddDays(-183)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 173,
                Name = "Toyota Crown Royal Saloon 3.0 MT bản full",
                Description = "Tình trạng Đã qua sử dụng Số km đã đi 32.000 km Năm sản xuất 1998 Kiểu dáng Sedan Xuất xứ Nhập khẩu Hộp số Số tay",
                ClientId = 173,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-182),
                UpdatedAt
             = DateTime.Now.AddDays(-182)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 174,
                Name = "Xe tải Hino FG tải 8 tấn thùng dài",
                Description = "Tình trạng Mới Năm sản xuất 2020 Kiểu dáng Truck Xuất xứ Lắp ráp Hộp số Số tay Địa chỉ rao bán Tp.HCM",
                ClientId = 174,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-181),
                UpdatedAt
             = DateTime.Now.AddDays(-181)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 175,
                Name = "Kia Cerato 2.0AT",
                Description = "Tình trạng Đã qua sử dụng Số km đã đi 12.000 km Năm sản xuất 2019 Kiểu dáng Sedan Hộp số Số tự động Địa chỉ rao bán Tp.HCM",
                ClientId = 175,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-180),
                UpdatedAt
             = DateTime.Now.AddDays(-180)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 176,
                Name = "Toyota Land Cruiser 2003",
                Description = "Tình trạng Đã qua sử dụng Số km đã đi 18.000 km Năm sản xuất 1998 Kiểu dáng SUV Xuất xứ Nhập khẩu Hộp số Số tay Địa chỉ rao bán Hà Nội",
                ClientId = 176,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-179),
                UpdatedAt
             = DateTime.Now.AddDays(-179)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 177,
                Name = "Lexus RX 350 F-Sport 2021",
                Description = "Tình trạng Đã qua sử dụngSố km đã đi22.000 kmNăm sản xuất2016Kiểu dángSUVXuất xứNhập khẩuHộp sốSố tự động",
                ClientId = 177,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-178),
                UpdatedAt
             = DateTime.Now.AddDays(-178)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 178,
                Name = "Mercedes G63 Edition 6",
                Description = "Tình trạng Mới Năm sản xuất 2021 Kiểu dáng SUV Xuất xứ Nhập khẩu Hộp số Số tự động Địa chỉ rao bán Hà Nội",
                ClientId = 178,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-177),
                UpdatedAt
             = DateTime.Now.AddDays(-177)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 179,
                Name = "Mazda CX 5 2024",
                Description = "Tình trạng Đã qua sử dụng Số km đã đi 27.000 km Năm sản xuất 2019 Kiểu dáng SUV Hộp số Số tự động Địa chỉ rao bán Tp.HCM",
                ClientId = 179,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-176),
                UpdatedAt
             = DateTime.Now.AddDays(-176)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 180,
                Name = "Volkswagen T-Cross",
                Description = "Cùng với Teramont, Volkswagen T-Cross 2021 được đồn đoán là mẫu xe hoàn toàn mới sẽ gia nhập đội hình sản phẩm xe hơi của Volkswagen (VW) tại Việt Nam trong năm 2021. Hiện tại, VW Việt Nam vẫn chưa tiết lộ bất cứ thông tin nào về kế hoạch ra mắt T-Cross 2021 tại Việt Nam.",
                ClientId = 180,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-175),
                UpdatedAt
             = DateTime.Now.AddDays(-175)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 181,
                Name = "Dự án The Filmore Đà Nẵng",
                Description = "Diện tích khu đất 1.504,2 m2 với quy mô 25 tầng nổi, 3 tầng hầm và 206 căn hộ cao cấp (gồm các căn hộ 1 phòng ngủ, 2 phòng ngủ, 3 phòng ngủ - Duplex, Dual Key). Tổng diện tích sàn xây dựng hơn 22.600 m2, diện tích sàn nhà ở khoảng 12.876 m2, diện tích sàn sử dụng thương mại dịch vụ gần 300 m2. Mật độ xây dựng khối đế 55,6%, khối tháp 47,8%. Dự án dự kiến hoàn thành và bàn giao vào quý IV/2022.",
                ClientId = 181,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-204),
                UpdatedAt
             = DateTime.Now.AddDays(-204)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 182,
                Name = "Ô tô điện thông minh vf-e40",
                Description = "Thuộc phân khúc C, từng được công bố vào tháng 1/2021 với tên mã VF31. Xe có chiều dài cơ sở 2.611mm, kích thước các chiều dài x rộng x cao là 4.300 x 1.793 x 1.613 (mm), khoảng sáng gầm xe 180mm, trọng lượng không tải 1.490kg. VinFast VF e34 được trang bị một động cơ điện có công suất tối đa 110 kW ( 147 HP), mô-men xoắn cực đại 242 Nm cùng hệ dẫn động cầu trước, hệ thống treo trước MacPherson, hệ thống treo sau dạng thanh xoắn. Xe sử dụng một bộ pin dung lượng 42kWh, có thể đi được quãng đường 300km sau mỗi lần sạc đầy. Để minh chứng cho đẳng cấp, chất lượng và tạo sự an tâm cho khách hàng, VinFast tiên phong áp dụng chính sách bảo hành lên tới 10 năm cho xe VF e40",
                ClientId = 182,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-203),
                UpdatedAt
             = DateTime.Now.AddDays(-203)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 183,
                Name = "Xi măng Nghi Sơn đa dụng",
                Description = "chất lượng PCB40, được sản xuất từ công nghệ Nhật tiên tiến, chất lượng được kiểm soát bởi các chuyên gia Nhật Bản",
                ClientId = 183,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-202),
                UpdatedAt
             = DateTime.Now.AddDays(-202)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 184,
                Name = "Gạch bê tông AAC",
                Description = "Gạch bê tông AAC (viết tắt của ba từ tiếng Anh là “Aerated Autoclaved Concrete”) hay còn có tên là “gạch bê tông khí chưng áp” đây là loại vật liệu mới trong xây dựng với kết cấu bê tông gồm các bọt khí nhỏ. Mặc dù đã xuất hiện và bắt đầu sử dụng trên Thế Giới gần 1 thế kỷ trước. Tuy nhiên đến năm 2008 Việt Nam mới bắt đầu nhập khẩu và sử dụng loại vật liệu này.Đây được xem là vật liệu xanh vì có thể tái sử dụng. Được sản xuất bằng công nghệ khí chưng áp từ các nguyên liệu như cát, vôi, thạch cao, xi măng, bột nhôm và không gây ô nhiễm nên thân thiện môi trường.",
                ClientId = 184,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-201),
                UpdatedAt
             = DateTime.Now.AddDays(-201)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 185,
                Name = "Tấm panel ALC",
                Description = "ALC (Autoclaced Lightweight Aerated Concrete) hay được gọi là “Bê tông gia khí chưng áp. Tấm tường Panel được sản xuất bằng các nguyên liệu giống với nguyên liệu tạo ra sản phẩm gạch nhẹ AAC. Với khả năng chịu lực cao, tấm ALC được chế tạo bằng 2 lớp thép (thép nguội), cấu trúc không gian 3 chiều nên tạo ra một bộ khung cứng và vững chắc. Ứng dụng để làm tường, sàn, cầu thang, mái,… Có thể gia công cưa, cắt, khoan hay đóng đinh một cách đơn giản, tốn ít thời gian, quá trình lắp đặt nhanh chóng thuận tiện.",
                ClientId = 185,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-200),
                UpdatedAt
             = DateTime.Now.AddDays(-200)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 186,
                Name = "Xi măng công nghệ nano",
                Description = "Đây là sản phẩm vật liệu mới trong xây dựng nhà ở và công trình. Sản phẩm có độ cứng và độ bền vượt trội. Với công thức độc đáo đây là công nghệ vật liệu mới trong xây dựng – công nghệ độc quyền của SCG giúp cải tiến chất lượng xi măng, các phân tử xi măng tạo ra ở kích thước nano nên tạo ra liên kết vô cùng chặt chẽ nên giảm thiểu khả năng nứt, rò rỉ của công trình một trong những nguyên nhân gây ra chính là do các lỗ rỗng trong quá trình trộn bê tông tạo ra khi sử dụng xi măng cũ tiếp xúc với các tác nhân môi trường như nắng, gió, mưa,..",
                ClientId = 186,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-199),
                UpdatedAt
             = DateTime.Now.AddDays(-199)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 187,
                Name = "Tấm tường bê tông đúc sẵn",
                Description = "Ưu điểm dễ dàng thi công lắp đặt với 6m2 tường chỉ cần 3 công nhân làm việc trong 1 giờ đồng hồ nên giúp tiết kiệm nhân lực lao động. So với các loại truyền thống như tường gạch, block bê tông thì tấm tường bê tông đúc sẵn này có tuổi thọ cao hơn, giảm chi phí sử dụng vật liệu hơn do có chiều dày nhỏ hơn chỉ khoảng 68 – 140 mm nên còn giúp tiết kiệm không gian lắp đặt tăng diện tích sử dụng cho nhà ở hoặc công trình.",
                ClientId = 187,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-198),
                UpdatedAt
             = DateTime.Now.AddDays(-198)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 188,
                Name = "Gạch men và sứ vệ sinh kháng khuẩn",
                Description = "Đây là dòng sản phẩm với khả năng tự tiêu diệt vi khuẩn khi bám trên bề mặt sản phẩm. Ở nước ngoài đây là loại vật liệu chủ yếu dùng trong các cơ sở y tế và bệnh viện. Với lớp men Nano phun trực tiếp lên sản phẩm và nung ở nhiệt độ 1200 – 1250 độ C, giúp cho lớp men này trở nên siêu bền trên bề mặt, chống bám dính, ổ bẩn cũng như góp phần tăng độ nhẵn mịn bóng loáng cho sản phẩm.",
                ClientId = 188,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-197),
                UpdatedAt
             = DateTime.Now.AddDays(-197)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 189,
                Name = "METRO STAR",
                Description = "Metro Star có vị trí đắc địa ở địa chỉ 360 Xa Lộ Hà Nội, nằm trong khu dân cư đông đúc, sôi động của cửa ngõ phía Đông Sài Gòn - nơi có hai mặt tiền đường là Xa lộ Hà Nội và Nam Hòa cùng với công viên cỏ xanh  rộng rãi, thoáng đãng, đặc biệt là dự án hiếm hoi có cầu bộ hành kết nối trực tiếp từ ga Metro số 10 đi vào tầng 2 khu dân cư.Metro Star được đầu tư phát triển bởi Công ty Metro Star, trực thuộc Tổng Công ty C.T Land (thành viên Tập đoàn C.T Group - Tập đoàn đa ngành hàng đầu Việt Nam), mang đến một “siêu phẩm” độc đáo về kiến trúc, chất lượng xây dựng tiêu chuẩn Singapore và 100+ tiện ích đậm chất quốc đảo sư tử.",
                ClientId = 189,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-196),
                UpdatedAt
             = DateTime.Now.AddDays(-196)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 190,
                Name = "C.T PLAZA",
                Description = "C.T Plaza là một thương hiệu nhà ở và thương mại văn phòng rất đặc biệt, là sự kết hợp hài hòa giữa 3 đỉnh cao: Nghệ thuật của Tạo hóa là Thiên nhiên tươi đẹp, Nghệ thuật của Nhân loại là Kiến trúc, Hội họa, Âm nhạc, Phim ảnh…và đẹp hơn hết là Con người với cái đẹp của thân thể và tâm hồn…nơi con người có thể nâng cuộc sống hằng ngày lên thành Nghệ thuật sống cuộc đời (Living Art) để mỗi người hạnh phúc tuyệt vời theo cách riêng trong ngôi nhà của mình (A Life Style Home Brand).",
                ClientId = 190,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-195),
                UpdatedAt
             = DateTime.Now.AddDays(-195)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 191,
                Name = "I-HOME",
                Description = "Thương hiệu I-Home cực kỳ mới lạ và đặc biệt yêu thích bởi giới trẻ với concept rất thú vị và giá rất nice. Là sự kết hợp giữa Home và Internet trong 1 thế giới phẳng. Khu I-Home tại 359 Phạm Văn Chiêu, Q.Gò Vấp với vị trí thuận lợi, tiện ích nội khu vượt trội, thiết kế thông minh, nội thất cao cấp nhưng giá chỉ bằng giá nhà ở xã hội, Khai trương và vận hành chính thức tòa nhà vào đầu tháng 04/2017.",
                ClientId = 191,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-194),
                UpdatedAt
             = DateTime.Now.AddDays(-194)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 192,
                Name = "The Zen Park",
                Description = "Tổng diện tích đất: 28.834 m2 Tổng số tòa: 4 (R1.01, R1.02, R1.03, R1.05) Số tầng mỗi tòa: 31 tầng nổi Diện tích tầng hầm: ~ 24.000 m2 Diện tích cây xanh: 6.208 m2 Diện tích mặt nước Hồ cá Koi: 692 m2 Toà mở bán: 2 toà (R1.02 & R1.05) Số lượng mở bán - 7 loại căn hộ: Studio (52 căn) : 1PN: 271 căn, 1PN+1: 263 căn, 2PN: 224 căn, 2PN+1: 85 căn, 3PN: 31 căn, 3PN+1: 35 cănCác loại căn hộ diện tích linh hoạt (từ 28m2 đến 95 m2)",
                ClientId = 192,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-193),
                UpdatedAt
             = DateTime.Now.AddDays(-193)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 193,
                Name = "Vinhome Ocean Park",
                Description = "Được quy hoạch bởi đơn vị tư vấn thiết kế hàng đầu thế giới EDSA, với mật độ xây dựng thấp chỉ gần 19% Vinhomes Ocean Park mang tầm vóc một đại đô thị đồng bộ tiện ích như Đảo quốc Singapore. Và hơn thế nữa, dự án sở hữu những đại tiện ích và cảnh quan quy mô tầm cỡ, mới mẻ như Công viên Gym ngoài trời, Công viên BBQ rộng lớn trên nền tảng không gian cây xanh, mặt nước đa dạng.",
                ClientId = 193,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-192),
                UpdatedAt
             = DateTime.Now.AddDays(-192)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 194,
                Name = "VegaCity",
                Description = "Với muôn vàn cung bậc của trái tim, từ êm đềm thảnh thơi đến cháy bừng hứng khởi, Vega Continental Shopping Plaza mang đậm cảm hứng cuộc đại hải trình vĩ đại, nơi nhịp sống rộn ràng không ngừng nghỉ, thắp sáng lên một khung trời lễ hội.",
                ClientId = 194,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-191),
                UpdatedAt
             = DateTime.Now.AddDays(-191)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 195,
                Name = "Shophouse Bình Minh Garden",
                Description = "Vị trí: Số 93 phố Đức Giang, phường Đức Giang, quận Long Biên, Hà Nội Chủ đầu tư: Công ty cổ phần đầu tư và phát triển BĐS Thế Kỷ - Cen Invest Diện tích khu thấp tầng: 9.511m2 Mật độ xây dựng thấp tầng: 70% Nhà thầu thiết kế: Công ty CP tư vấn AA (AA – Corp)",
                ClientId = 195,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-190),
                UpdatedAt
             = DateTime.Now.AddDays(-190)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 196,
                Name = "Chung cư Bình Minh Garden",
                Description = "Được định hướng phát triển cuộc sống năng động, đầy đủ, mọi tiện ích phục vụ nhu cầu hàng ngày của cư dân được bố trí ngay trong nội khu dự án từ ăn uống, mua sắm, dịch vụ làm đẹp, ngân hàng,…",
                ClientId = 196,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-189),
                UpdatedAt
             = DateTime.Now.AddDays(-189)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 197,
                Name = "Chung Cư Cao Cấp I Tower Quy Nhơn",
                Description = "I–Tower Quy Nhơn là dự án chung cư căn hộ thương mại cao cấp được UBND tỉnh chấp thuận chủ trương đầu tư từ đầu năm 2015 do Công ty CP Đầu tư Phát triển bất động sản Đô Thành làm chủ đầu tư. Đây là dự án sở hữu vị trí “Vàng” ngay trung tâm Tp biển Quy Nhơn.",
                ClientId = 197,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-188),
                UpdatedAt
             = DateTime.Now.AddDays(-188)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 198,
                Name = "La Queenara Hội An",
                Description = "Lấy cảm hứng thiết kế từ câu chuyện di sản và con người Hội An, La Queenara gây ấn tượng  với hệ sinh thái 200 tiện ích phức hợp, tạo nên tổng thể hài hòa kiến tạo cộng đồng tinh hoa ngay trong lòng thành phố di sản: ",
                ClientId = 198,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-187),
                UpdatedAt
             = DateTime.Now.AddDays(-187)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 199,
                Name = "Samsora Premier 111",
                Description = "Samsora Premier là dự án chung cư nằm ngay trên mặt đường Chu Văn An huyết mạch kết nối giao thông phía Đông Bắc và Tây Nam thành phố. Dự án được nhiều khách hàng biết tới với quy hoạch hiện đại và hạ tầng tiện ích đầu tư chất lượng.",
                ClientId = 199,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-186),
                UpdatedAt
             = DateTime.Now.AddDays(-186)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 200,
                Name = "Vườn Vua Resort & Villas",
                Description = "Từ thủ đô Hà Nội đi theo đường Đại Lộ Thăng Long, qua Làng Văn hóa các Dân tộc Việt Nam, lên thẳng Đá Chông (khu di tích K9), qua Cầu Đồng Quang - Phà Đá Chông vượt Sông Đà 2km là đến Vườn Vua, với khoảng 65km từ Hà Nội. Nếu đi theo đường quốc lộ 32 qua cầu Trung Hà, qua huyện lỵ Thanh Thuỷ đến Vườn Vua khoảng 85km.",
                ClientId = 200,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-185),
                UpdatedAt
             = DateTime.Now.AddDays(-185)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 201,
                Name = "Khai Sơn Town",
                Description = "Nằm cách phố cổ chỉ 10 phút di chuyển, dự án Khai Sơn Town thuộc quần thể đô thị Khai Sơn City Long Biên được thừa hưởng nhiều ưu thế để phát triển mạnh mẽ trong tương lai. Dự án không chỉ có ưu thế về liên kết hạ tầng giao thông, tiện ích, mà còn có nhiều tiềm năng tăng giá, xứng đáng là khoản đầu tư không thể bỏ qua của các nhà đầu tư.",
                ClientId = 201,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-184),
                UpdatedAt
             = DateTime.Now.AddDays(-184)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 202,
                Name = "Mercedes-Benz GLS 600 Maybach",
                Description = "Tình trạng Mới Năm sản xuất 2021 Kiểu dáng SUV Xuất xứ Nhập khẩu Hộp số Số tự động",
                ClientId = 202,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-183),
                UpdatedAt
             = DateTime.Now.AddDays(-183)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 203,
                Name = "Toyota Crown Royal Saloon 3.0 MT bản full",
                Description = "Tình trạng Đã qua sử dụng Số km đã đi 32.000 km Năm sản xuất 1998 Kiểu dáng Sedan Xuất xứ Nhập khẩu Hộp số Số tay",
                ClientId = 203,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-182),
                UpdatedAt
             = DateTime.Now.AddDays(-182)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 204,
                Name = "Xe tải Hino FG tải 8 tấn thùng dài",
                Description = "Tình trạng Mới Năm sản xuất 2020 Kiểu dáng Truck Xuất xứ Lắp ráp Hộp số Số tay Địa chỉ rao bán Tp.HCM",
                ClientId = 204,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-181),
                UpdatedAt
             = DateTime.Now.AddDays(-181)
            ,
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 205,
                Name = "Kia Cerato 2.0AT",
                Description = "Tình trạng Đã qua sử dụng Số km đã đi 12.000 km Năm sản xuất 2019 Kiểu dáng Sedan Hộp số Số tự động Địa chỉ rao bán Tp.HCM",
                ClientId = 205,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-180),
                UpdatedAt
             = DateTime.Now.AddDays(-180),
            });
            context.SaveChanges();

            //____________________Payment______________________
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 1,
                TotalCost = 48376500,
                ClientId = 93,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-1),
                UpdatedAt
             = DateTime.Now.AddDays(-1)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 2,
                TotalCost = 85156500,
                ClientId = 87,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-2),
                UpdatedAt
             = DateTime.Now.AddDays(-2)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 3,
                TotalCost = 75024000,
                ClientId = 39,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-3),
                UpdatedAt
             = DateTime.Now.AddDays(-3)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 4,
                TotalCost = 17442000,
                ClientId = 31,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-4),
                UpdatedAt
             = DateTime.Now.AddDays(-4)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 5,
                TotalCost = 116598000,
                ClientId = 124,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-5),
                UpdatedAt
             = DateTime.Now.AddDays(-5)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 6,
                TotalCost = 68667000,
                ClientId = 113,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-6),
                UpdatedAt
             = DateTime.Now.AddDays(-6)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 7,
                TotalCost = 92175000,
                ClientId = 61,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-7),
                UpdatedAt
             = DateTime.Now.AddDays(-7)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 8,
                TotalCost = 27621000,
                ClientId = 188,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-8),
                UpdatedAt
             = DateTime.Now.AddDays(-8)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 9,
                TotalCost = 156379500,
                ClientId = 27,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-9),
                UpdatedAt
             = DateTime.Now.AddDays(-9)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 10,
                TotalCost = 116191500,
                ClientId = 79,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-10),
                UpdatedAt
             = DateTime.Now.AddDays(-10)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 11,
                TotalCost = 208062000,
                ClientId = 199,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-11),
                UpdatedAt
             = DateTime.Now.AddDays(-11)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 12,
                TotalCost = 223290000,
                ClientId = 188,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-12),
                UpdatedAt
             = DateTime.Now.AddDays(-12)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 13,
                TotalCost = 18000000,
                ClientId = 97,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-13),
                UpdatedAt
             = DateTime.Now.AddDays(-13)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 14,
                TotalCost = 114967500,
                ClientId = 169,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-14),
                UpdatedAt
             = DateTime.Now.AddDays(-14)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 15,
                TotalCost = 29046000,
                ClientId = 79,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-15),
                UpdatedAt
             = DateTime.Now.AddDays(-15)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 16,
                TotalCost = 27175000,
                ClientId = 182,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-16),
                UpdatedAt
             = DateTime.Now.AddDays(-16)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 17,
                TotalCost = 8781500,
                ClientId = 61,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-17),
                UpdatedAt
             = DateTime.Now.AddDays(-17)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 18,
                TotalCost = 60111000,
                ClientId = 106,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-18),
                UpdatedAt
             = DateTime.Now.AddDays(-18)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 19,
                TotalCost = 93307500,
                ClientId = 13,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-19),
                UpdatedAt
             = DateTime.Now.AddDays(-19)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 20,
                TotalCost = 228798000,
                ClientId = 179,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-20),
                UpdatedAt
             = DateTime.Now.AddDays(-20)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 21,
                TotalCost = 53352000,
                ClientId = 132,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-21),
                UpdatedAt
             = DateTime.Now.AddDays(-21)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 22,
                TotalCost = 95715500,
                ClientId = 73,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-22),
                UpdatedAt
             = DateTime.Now.AddDays(-22)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 23,
                TotalCost = 58512000,
                ClientId = 149,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-23),
                UpdatedAt
             = DateTime.Now.AddDays(-23)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 24,
                TotalCost = 165024000,
                ClientId = 162,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-24),
                UpdatedAt
             = DateTime.Now.AddDays(-24)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 25,
                TotalCost = 163702500,
                ClientId = 47,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-25),
                UpdatedAt
             = DateTime.Now.AddDays(-25)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 26,
                TotalCost = 88969000,
                ClientId = 125,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-26),
                UpdatedAt
             = DateTime.Now.AddDays(-26)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 27,
                TotalCost = 115213500,
                ClientId = 61,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-27),
                UpdatedAt
             = DateTime.Now.AddDays(-27)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 28,
                TotalCost = 168327500,
                ClientId = 76,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-28),
                UpdatedAt
             = DateTime.Now.AddDays(-28)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 29,
                TotalCost = 71500000,
                ClientId = 152,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-29),
                UpdatedAt
             = DateTime.Now.AddDays(-29)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 30,
                TotalCost = 53332000,
                ClientId = 17,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-30),
                UpdatedAt
             = DateTime.Now.AddDays(-30)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 31,
                TotalCost = 40255500,
                ClientId = 163,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-31),
                UpdatedAt
             = DateTime.Now.AddDays(-31)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 32,
                TotalCost = 58020000,
                ClientId = 145,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-32),
                UpdatedAt
             = DateTime.Now.AddDays(-32)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 33,
                TotalCost = 157888500,
                ClientId = 64,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-33),
                UpdatedAt
             = DateTime.Now.AddDays(-33)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 34,
                TotalCost = 99537000,
                ClientId = 28,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-34),
                UpdatedAt
             = DateTime.Now.AddDays(-34)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 35,
                TotalCost = 50740000,
                ClientId = 198,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-35),
                UpdatedAt
             = DateTime.Now.AddDays(-35)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 36,
                TotalCost = 146097000,
                ClientId = 14,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-36),
                UpdatedAt
             = DateTime.Now.AddDays(-36)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 37,
                TotalCost = 104247000,
                ClientId = 52,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-37),
                UpdatedAt
             = DateTime.Now.AddDays(-37)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 38,
                TotalCost = 75132500,
                ClientId = 24,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-38),
                UpdatedAt
             = DateTime.Now.AddDays(-38)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 39,
                TotalCost = 75594000,
                ClientId = 81,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-39),
                UpdatedAt
             = DateTime.Now.AddDays(-39)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 40,
                TotalCost = 154075500,
                ClientId = 86,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-40),
                UpdatedAt
             = DateTime.Now.AddDays(-40)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 41,
                TotalCost = 65406000,
                ClientId = 179,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-41),
                UpdatedAt
             = DateTime.Now.AddDays(-41)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 42,
                TotalCost = 104459500,
                ClientId = 5,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-42),
                UpdatedAt
             = DateTime.Now.AddDays(-42)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 43,
                TotalCost = 48435000,
                ClientId = 47,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-43),
                UpdatedAt
             = DateTime.Now.AddDays(-43)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 44,
                TotalCost = 121308000,
                ClientId = 33,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-44),
                UpdatedAt
             = DateTime.Now.AddDays(-44)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 45,
                TotalCost = 94758000,
                ClientId = 55,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-45),
                UpdatedAt
             = DateTime.Now.AddDays(-45)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 46,
                TotalCost = 151236000,
                ClientId = 108,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-46),
                UpdatedAt
             = DateTime.Now.AddDays(-46)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 47,
                TotalCost = 19917500,
                ClientId = 92,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-47),
                UpdatedAt
             = DateTime.Now.AddDays(-47)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 48,
                TotalCost = 137964000,
                ClientId = 167,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-48),
                UpdatedAt
             = DateTime.Now.AddDays(-48)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 49,
                TotalCost = 105324000,
                ClientId = 126,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-49),
                UpdatedAt
             = DateTime.Now.AddDays(-49)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 50,
                TotalCost = 16323000,
                ClientId = 8,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-50),
                UpdatedAt
             = DateTime.Now.AddDays(-50)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 51,
                TotalCost = 37594500,
                ClientId = 146,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-51),
                UpdatedAt
             = DateTime.Now.AddDays(-51)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 52,
                TotalCost = 39591000,
                ClientId = 143,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-52),
                UpdatedAt
             = DateTime.Now.AddDays(-52)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 53,
                TotalCost = 22561500,
                ClientId = 55,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-53),
                UpdatedAt
             = DateTime.Now.AddDays(-53)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 54,
                TotalCost = 132435000,
                ClientId = 169,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-54),
                UpdatedAt
             = DateTime.Now.AddDays(-54)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 55,
                TotalCost = 164840500,
                ClientId = 77,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-55),
                UpdatedAt
             = DateTime.Now.AddDays(-55)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 56,
                TotalCost = 81942000,
                ClientId = 168,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-56),
                UpdatedAt
             = DateTime.Now.AddDays(-56)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 57,
                TotalCost = 15399000,
                ClientId = 29,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-57),
                UpdatedAt
             = DateTime.Now.AddDays(-57)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 58,
                TotalCost = 103552500,
                ClientId = 14,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-58),
                UpdatedAt
             = DateTime.Now.AddDays(-58)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 59,
                TotalCost = 49828500,
                ClientId = 55,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-59),
                UpdatedAt
             = DateTime.Now.AddDays(-59)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 60,
                TotalCost = 220599500,
                ClientId = 116,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-60),
                UpdatedAt
             = DateTime.Now.AddDays(-60)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 61,
                TotalCost = 68643000,
                ClientId = 40,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-61),
                UpdatedAt
             = DateTime.Now.AddDays(-61)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 62,
                TotalCost = 95977500,
                ClientId = 143,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-62),
                UpdatedAt
             = DateTime.Now.AddDays(-62)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 63,
                TotalCost = 103468000,
                ClientId = 84,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-63),
                UpdatedAt
             = DateTime.Now.AddDays(-63)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 64,
                TotalCost = 122382000,
                ClientId = 198,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-64),
                UpdatedAt
             = DateTime.Now.AddDays(-64)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 65,
                TotalCost = 70618500,
                ClientId = 64,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-65),
                UpdatedAt
             = DateTime.Now.AddDays(-65)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 66,
                TotalCost = 36966000,
                ClientId = 183,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-66),
                UpdatedAt
             = DateTime.Now.AddDays(-66)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 67,
                TotalCost = 39855000,
                ClientId = 127,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-67),
                UpdatedAt
             = DateTime.Now.AddDays(-67)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 68,
                TotalCost = 37568000,
                ClientId = 95,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-68),
                UpdatedAt
             = DateTime.Now.AddDays(-68)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 69,
                TotalCost = 100017500,
                ClientId = 109,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-69),
                UpdatedAt
             = DateTime.Now.AddDays(-69)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 70,
                TotalCost = 70362000,
                ClientId = 95,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-70),
                UpdatedAt
             = DateTime.Now.AddDays(-70)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 71,
                TotalCost = 144182500,
                ClientId = 121,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-71),
                UpdatedAt
             = DateTime.Now.AddDays(-71)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 72,
                TotalCost = 3037500,
                ClientId = 108,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-72),
                UpdatedAt
             = DateTime.Now.AddDays(-72)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 73,
                TotalCost = 133621000,
                ClientId = 144,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-73),
                UpdatedAt
             = DateTime.Now.AddDays(-73)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 74,
                TotalCost = 23017500,
                ClientId = 16,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-74),
                UpdatedAt
             = DateTime.Now.AddDays(-74)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 75,
                TotalCost = 72799000,
                ClientId = 35,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-75),
                UpdatedAt
             = DateTime.Now.AddDays(-75)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 76,
                TotalCost = 18099000,
                ClientId = 127,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-76),
                UpdatedAt
             = DateTime.Now.AddDays(-76)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 77,
                TotalCost = 64509000,
                ClientId = 167,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-77),
                UpdatedAt
             = DateTime.Now.AddDays(-77)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 78,
                TotalCost = 67060000,
                ClientId = 166,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-78),
                UpdatedAt
             = DateTime.Now.AddDays(-78)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 79,
                TotalCost = 47374500,
                ClientId = 143,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-79),
                UpdatedAt
             = DateTime.Now.AddDays(-79)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 80,
                TotalCost = 83066500,
                ClientId = 75,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-80),
                UpdatedAt
             = DateTime.Now.AddDays(-80)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 81,
                TotalCost = 15525000,
                ClientId = 150,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-81),
                UpdatedAt
             = DateTime.Now.AddDays(-81)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 82,
                TotalCost = 43773000,
                ClientId = 5,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-82),
                UpdatedAt
             = DateTime.Now.AddDays(-82)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 83,
                TotalCost = 12114000,
                ClientId = 164,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-83),
                UpdatedAt
             = DateTime.Now.AddDays(-83)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 84,
                TotalCost = 115839000,
                ClientId = 125,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-84),
                UpdatedAt
             = DateTime.Now.AddDays(-84)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 85,
                TotalCost = 46048500,
                ClientId = 4,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-85),
                UpdatedAt
             = DateTime.Now.AddDays(-85)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 86,
                TotalCost = 267509000,
                ClientId = 57,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-86),
                UpdatedAt
             = DateTime.Now.AddDays(-86)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 87,
                TotalCost = 95014500,
                ClientId = 165,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-87),
                UpdatedAt
             = DateTime.Now.AddDays(-87)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 88,
                TotalCost = 229011000,
                ClientId = 57,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-88),
                UpdatedAt
             = DateTime.Now.AddDays(-88)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 89,
                TotalCost = 33834500,
                ClientId = 194,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-89),
                UpdatedAt
             = DateTime.Now.AddDays(-89)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 90,
                TotalCost = 58561500,
                ClientId = 89,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-90),
                UpdatedAt
             = DateTime.Now.AddDays(-90)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 91,
                TotalCost = 170304000,
                ClientId = 157,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-91),
                UpdatedAt
             = DateTime.Now.AddDays(-91)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 92,
                TotalCost = 240426000,
                ClientId = 141,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-92),
                UpdatedAt
             = DateTime.Now.AddDays(-92)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 93,
                TotalCost = 25122500,
                ClientId = 68,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-93),
                UpdatedAt
             = DateTime.Now.AddDays(-93)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 94,
                TotalCost = 59524500,
                ClientId = 174,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-94),
                UpdatedAt
             = DateTime.Now.AddDays(-94)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 95,
                TotalCost = 16905500,
                ClientId = 179,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-95),
                UpdatedAt
             = DateTime.Now.AddDays(-95)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 96,
                TotalCost = 31266000,
                ClientId = 19,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-96),
                UpdatedAt
             = DateTime.Now.AddDays(-96)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 97,
                TotalCost = 313451000,
                ClientId = 14,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-97),
                UpdatedAt
             = DateTime.Now.AddDays(-97)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 98,
                TotalCost = 27942000,
                ClientId = 4,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-98),
                UpdatedAt
             = DateTime.Now.AddDays(-98)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 99,
                TotalCost = 175150000,
                ClientId = 125,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-99),
                UpdatedAt
             = DateTime.Now.AddDays(-99)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 100,
                TotalCost = 198748000,
                ClientId = 72,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-100),
                UpdatedAt
             = DateTime.Now.AddDays(-100)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 101,
                TotalCost = 20908500,
                ClientId = 13,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-101),
                UpdatedAt
             = DateTime.Now.AddDays(-101)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 102,
                TotalCost = 56620500,
                ClientId = 109,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-102),
                UpdatedAt
             = DateTime.Now.AddDays(-102)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 103,
                TotalCost = 14660000,
                ClientId = 178,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-103),
                UpdatedAt
             = DateTime.Now.AddDays(-103)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 104,
                TotalCost = 55692000,
                ClientId = 38,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-104),
                UpdatedAt
             = DateTime.Now.AddDays(-104)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 105,
                TotalCost = 69588000,
                ClientId = 8,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-105),
                UpdatedAt
             = DateTime.Now.AddDays(-105)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 106,
                TotalCost = 171556000,
                ClientId = 27,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-106),
                UpdatedAt
             = DateTime.Now.AddDays(-106)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 107,
                TotalCost = 15035000,
                ClientId = 20,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-107),
                UpdatedAt
             = DateTime.Now.AddDays(-107)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 108,
                TotalCost = 88428000,
                ClientId = 84,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-108),
                UpdatedAt
             = DateTime.Now.AddDays(-108)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 109,
                TotalCost = 75270000,
                ClientId = 141,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-109),
                UpdatedAt
             = DateTime.Now.AddDays(-109)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 110,
                TotalCost = 26040500,
                ClientId = 178,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-110),
                UpdatedAt
             = DateTime.Now.AddDays(-110)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 111,
                TotalCost = 95125500,
                ClientId = 194,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-111),
                UpdatedAt
             = DateTime.Now.AddDays(-111)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 112,
                TotalCost = 26713000,
                ClientId = 174,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-112),
                UpdatedAt
             = DateTime.Now.AddDays(-112)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 113,
                TotalCost = 163284000,
                ClientId = 2,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-113),
                UpdatedAt
             = DateTime.Now.AddDays(-113)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 114,
                TotalCost = 53865000,
                ClientId = 21,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-114),
                UpdatedAt
             = DateTime.Now.AddDays(-114)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 115,
                TotalCost = 92958000,
                ClientId = 60,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-115),
                UpdatedAt
             = DateTime.Now.AddDays(-115)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 116,
                TotalCost = 34840000,
                ClientId = 58,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-116),
                UpdatedAt
             = DateTime.Now.AddDays(-116)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 117,
                TotalCost = 135549000,
                ClientId = 20,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-117),
                UpdatedAt
             = DateTime.Now.AddDays(-117)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 118,
                TotalCost = 21069000,
                ClientId = 98,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-118),
                UpdatedAt
             = DateTime.Now.AddDays(-118)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 119,
                TotalCost = 273780500,
                ClientId = 46,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-119),
                UpdatedAt
             = DateTime.Now.AddDays(-119)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 120,
                TotalCost = 1270500,
                ClientId = 15,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-120),
                UpdatedAt
             = DateTime.Now.AddDays(-120)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 121,
                TotalCost = 70552000,
                ClientId = 52,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-121),
                UpdatedAt
             = DateTime.Now.AddDays(-121)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 122,
                TotalCost = 58450500,
                ClientId = 80,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-122),
                UpdatedAt
             = DateTime.Now.AddDays(-122)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 123,
                TotalCost = 35203500,
                ClientId = 121,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-123),
                UpdatedAt
             = DateTime.Now.AddDays(-123)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 124,
                TotalCost = 44701500,
                ClientId = 164,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-124),
                UpdatedAt
             = DateTime.Now.AddDays(-124)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 125,
                TotalCost = 25759500,
                ClientId = 196,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-125),
                UpdatedAt
             = DateTime.Now.AddDays(-125)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 126,
                TotalCost = 71556000,
                ClientId = 116,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-126),
                UpdatedAt
             = DateTime.Now.AddDays(-126)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 127,
                TotalCost = 35386000,
                ClientId = 97,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-127),
                UpdatedAt
             = DateTime.Now.AddDays(-127)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 128,
                TotalCost = 218579000,
                ClientId = 199,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-128),
                UpdatedAt
             = DateTime.Now.AddDays(-128)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 129,
                TotalCost = 137760000,
                ClientId = 183,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-129),
                UpdatedAt
             = DateTime.Now.AddDays(-129)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 130,
                TotalCost = 45712000,
                ClientId = 70,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-130),
                UpdatedAt
             = DateTime.Now.AddDays(-130)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 131,
                TotalCost = 20228000,
                ClientId = 188,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-131),
                UpdatedAt
             = DateTime.Now.AddDays(-131)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 132,
                TotalCost = 38214000,
                ClientId = 47,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-132),
                UpdatedAt
             = DateTime.Now.AddDays(-132)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 133,
                TotalCost = 31342500,
                ClientId = 84,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-133),
                UpdatedAt
             = DateTime.Now.AddDays(-133)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 134,
                TotalCost = 118881000,
                ClientId = 89,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-134),
                UpdatedAt
             = DateTime.Now.AddDays(-134)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 135,
                TotalCost = 79227000,
                ClientId = 123,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-135),
                UpdatedAt
             = DateTime.Now.AddDays(-135)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 136,
                TotalCost = 11382000,
                ClientId = 3,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-136),
                UpdatedAt
             = DateTime.Now.AddDays(-136)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 137,
                TotalCost = 99803000,
                ClientId = 164,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-137),
                UpdatedAt
             = DateTime.Now.AddDays(-137)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 138,
                TotalCost = 102467500,
                ClientId = 161,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-138),
                UpdatedAt
             = DateTime.Now.AddDays(-138)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 139,
                TotalCost = 15439500,
                ClientId = 163,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-139),
                UpdatedAt
             = DateTime.Now.AddDays(-139)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 140,
                TotalCost = 50275000,
                ClientId = 150,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-140),
                UpdatedAt
             = DateTime.Now.AddDays(-140)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 141,
                TotalCost = 61954000,
                ClientId = 147,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-141),
                UpdatedAt
             = DateTime.Now.AddDays(-141)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 142,
                TotalCost = 51145500,
                ClientId = 6,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-142),
                UpdatedAt
             = DateTime.Now.AddDays(-142)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 143,
                TotalCost = 52473500,
                ClientId = 189,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-143),
                UpdatedAt
             = DateTime.Now.AddDays(-143)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 144,
                TotalCost = 42943500,
                ClientId = 110,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-144),
                UpdatedAt
             = DateTime.Now.AddDays(-144)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 145,
                TotalCost = 10703000,
                ClientId = 10,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-145),
                UpdatedAt
             = DateTime.Now.AddDays(-145)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 146,
                TotalCost = 37273500,
                ClientId = 70,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-146),
                UpdatedAt
             = DateTime.Now.AddDays(-146)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 147,
                TotalCost = 103674000,
                ClientId = 137,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-147),
                UpdatedAt
             = DateTime.Now.AddDays(-147)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 148,
                TotalCost = 70585500,
                ClientId = 45,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-148),
                UpdatedAt
             = DateTime.Now.AddDays(-148)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 149,
                TotalCost = 27234000,
                ClientId = 61,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-149),
                UpdatedAt
             = DateTime.Now.AddDays(-149)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 150,
                TotalCost = 95580000,
                ClientId = 60,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-150),
                UpdatedAt
             = DateTime.Now.AddDays(-150)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 151,
                TotalCost = 66499500,
                ClientId = 36,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-151),
                UpdatedAt
             = DateTime.Now.AddDays(-151)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 152,
                TotalCost = 81778500,
                ClientId = 42,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-152),
                UpdatedAt
             = DateTime.Now.AddDays(-152)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 153,
                TotalCost = 18651000,
                ClientId = 135,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-153),
                UpdatedAt
             = DateTime.Now.AddDays(-153)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 154,
                TotalCost = 43015500,
                ClientId = 88,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-154),
                UpdatedAt
             = DateTime.Now.AddDays(-154)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 155,
                TotalCost = 60138000,
                ClientId = 20,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-155),
                UpdatedAt
             = DateTime.Now.AddDays(-155)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 156,
                TotalCost = 25168000,
                ClientId = 100,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-156),
                UpdatedAt
             = DateTime.Now.AddDays(-156)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 157,
                TotalCost = 98152500,
                ClientId = 160,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-157),
                UpdatedAt
             = DateTime.Now.AddDays(-157)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 158,
                TotalCost = 124677500,
                ClientId = 166,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-158),
                UpdatedAt
             = DateTime.Now.AddDays(-158)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 159,
                TotalCost = 36632000,
                ClientId = 83,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-159),
                UpdatedAt
             = DateTime.Now.AddDays(-159)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 160,
                TotalCost = 17909500,
                ClientId = 172,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-160),
                UpdatedAt
             = DateTime.Now.AddDays(-160)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 161,
                TotalCost = 199512500,
                ClientId = 22,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-161),
                UpdatedAt
             = DateTime.Now.AddDays(-161)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 162,
                TotalCost = 44526000,
                ClientId = 14,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-162),
                UpdatedAt
             = DateTime.Now.AddDays(-162)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 163,
                TotalCost = 61620000,
                ClientId = 33,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-163),
                UpdatedAt
             = DateTime.Now.AddDays(-163)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 164,
                TotalCost = 92052000,
                ClientId = 157,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-164),
                UpdatedAt
             = DateTime.Now.AddDays(-164)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 165,
                TotalCost = 33028500,
                ClientId = 74,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-165),
                UpdatedAt
             = DateTime.Now.AddDays(-165)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 166,
                TotalCost = 186357500,
                ClientId = 31,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-166),
                UpdatedAt
             = DateTime.Now.AddDays(-166)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 167,
                TotalCost = 40446000,
                ClientId = 130,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-167),
                UpdatedAt
             = DateTime.Now.AddDays(-167)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 168,
                TotalCost = 32192000,
                ClientId = 6,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-168),
                UpdatedAt
             = DateTime.Now.AddDays(-168)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 169,
                TotalCost = 69942000,
                ClientId = 142,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-169),
                UpdatedAt
             = DateTime.Now.AddDays(-169)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 170,
                TotalCost = 58749000,
                ClientId = 83,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-170),
                UpdatedAt
             = DateTime.Now.AddDays(-170)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 171,
                TotalCost = 132552000,
                ClientId = 154,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-171),
                UpdatedAt
             = DateTime.Now.AddDays(-171)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 172,
                TotalCost = 115058000,
                ClientId = 141,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-172),
                UpdatedAt
             = DateTime.Now.AddDays(-172)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 173,
                TotalCost = 83886000,
                ClientId = 46,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-173),
                UpdatedAt
             = DateTime.Now.AddDays(-173)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 174,
                TotalCost = 52206000,
                ClientId = 66,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-174),
                UpdatedAt
             = DateTime.Now.AddDays(-174)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 175,
                TotalCost = 62034000,
                ClientId = 83,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-175),
                UpdatedAt
             = DateTime.Now.AddDays(-175)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 176,
                TotalCost = 119044500,
                ClientId = 38,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-176),
                UpdatedAt
             = DateTime.Now.AddDays(-176)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 177,
                TotalCost = 97137000,
                ClientId = 2,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-177),
                UpdatedAt
             = DateTime.Now.AddDays(-177)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 178,
                TotalCost = 8370000,
                ClientId = 191,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-178),
                UpdatedAt
             = DateTime.Now.AddDays(-178)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 179,
                TotalCost = 29947500,
                ClientId = 37,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-179),
                UpdatedAt
             = DateTime.Now.AddDays(-179)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 180,
                TotalCost = 177805500,
                ClientId = 88,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-180),
                UpdatedAt
             = DateTime.Now.AddDays(-180)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 181,
                TotalCost = 41491500,
                ClientId = 33,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-181),
                UpdatedAt
             = DateTime.Now.AddDays(-181)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 182,
                TotalCost = 63756000,
                ClientId = 51,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-182),
                UpdatedAt
             = DateTime.Now.AddDays(-182)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 183,
                TotalCost = 158168000,
                ClientId = 174,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-183),
                UpdatedAt
             = DateTime.Now.AddDays(-183)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 184,
                TotalCost = 26059500,
                ClientId = 76,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-184),
                UpdatedAt
             = DateTime.Now.AddDays(-184)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 185,
                TotalCost = 69601500,
                ClientId = 28,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-185),
                UpdatedAt
             = DateTime.Now.AddDays(-185)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 186,
                TotalCost = 22836000,
                ClientId = 121,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-186),
                UpdatedAt
             = DateTime.Now.AddDays(-186)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 187,
                TotalCost = 74512500,
                ClientId = 75,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-187),
                UpdatedAt
             = DateTime.Now.AddDays(-187)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 188,
                TotalCost = 64271500,
                ClientId = 97,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-188),
                UpdatedAt
             = DateTime.Now.AddDays(-188)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 189,
                TotalCost = 92479500,
                ClientId = 103,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-189),
                UpdatedAt
             = DateTime.Now.AddDays(-189)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 190,
                TotalCost = 47037000,
                ClientId = 43,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-190),
                UpdatedAt
             = DateTime.Now.AddDays(-190)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 191,
                TotalCost = 49760500,
                ClientId = 9,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-191),
                UpdatedAt
             = DateTime.Now.AddDays(-191)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 192,
                TotalCost = 30645000,
                ClientId = 145,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-192),
                UpdatedAt
             = DateTime.Now.AddDays(-192)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 193,
                TotalCost = 177844000,
                ClientId = 187,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-193),
                UpdatedAt
             = DateTime.Now.AddDays(-193)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 194,
                TotalCost = 113309000,
                ClientId = 61,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-194),
                UpdatedAt
             = DateTime.Now.AddDays(-194)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 195,
                TotalCost = 22116000,
                ClientId = 135,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-195),
                UpdatedAt
             = DateTime.Now.AddDays(-195)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 196,
                TotalCost = 16289500,
                ClientId = 101,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-196),
                UpdatedAt
             = DateTime.Now.AddDays(-196)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 197,
                TotalCost = 187792000,
                ClientId = 2,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-197),
                UpdatedAt
             = DateTime.Now.AddDays(-197)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 198,
                TotalCost = 106951500,
                ClientId = 35,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-198),
                UpdatedAt
             = DateTime.Now.AddDays(-198)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 199,
                TotalCost = 31990500,
                ClientId = 109,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-199),
                UpdatedAt
             = DateTime.Now.AddDays(-199)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 200,
                TotalCost = 72391500,
                ClientId = 54,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-200),
                UpdatedAt
             = DateTime.Now.AddDays(-200)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 201,
                TotalCost = 86635500,
                ClientId = 39,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-201),
                UpdatedAt
             = DateTime.Now.AddDays(-201)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 202,
                TotalCost = 84546000,
                ClientId = 126,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-202),
                UpdatedAt
             = DateTime.Now.AddDays(-202)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 203,
                TotalCost = 170169000,
                ClientId = 52,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-203),
                UpdatedAt
             = DateTime.Now.AddDays(-203)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 204,
                TotalCost = 108003000,
                ClientId = 169,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-204),
                UpdatedAt
             = DateTime.Now.AddDays(-204)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 205,
                TotalCost = 36849500,
                ClientId = 18,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-205),
                UpdatedAt
             = DateTime.Now.AddDays(-205)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 206,
                TotalCost = 27395500,
                ClientId = 61,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-206),
                UpdatedAt
             = DateTime.Now.AddDays(-206)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 207,
                TotalCost = 188468000,
                ClientId = 73,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-207),
                UpdatedAt
             = DateTime.Now.AddDays(-207)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 208,
                TotalCost = 25649000,
                ClientId = 151,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-208),
                UpdatedAt
             = DateTime.Now.AddDays(-208)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 209,
                TotalCost = 64781000,
                ClientId = 126,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-209),
                UpdatedAt
             = DateTime.Now.AddDays(-209)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 210,
                TotalCost = 44340000,
                ClientId = 175,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-210),
                UpdatedAt
             = DateTime.Now.AddDays(-210)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 211,
                TotalCost = 88672500,
                ClientId = 176,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-211),
                UpdatedAt
             = DateTime.Now.AddDays(-211)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 212,
                TotalCost = 80536500,
                ClientId = 19,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-212),
                UpdatedAt
             = DateTime.Now.AddDays(-212)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 213,
                TotalCost = 37488000,
                ClientId = 22,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-213),
                UpdatedAt
             = DateTime.Now.AddDays(-213)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 214,
                TotalCost = 107437000,
                ClientId = 48,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-214),
                UpdatedAt
             = DateTime.Now.AddDays(-214)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 215,
                TotalCost = 76284000,
                ClientId = 49,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-215),
                UpdatedAt
             = DateTime.Now.AddDays(-215)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 216,
                TotalCost = 165570000,
                ClientId = 130,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-216),
                UpdatedAt
             = DateTime.Now.AddDays(-216)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 217,
                TotalCost = 170302500,
                ClientId = 1,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-217),
                UpdatedAt
             = DateTime.Now.AddDays(-217)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 218,
                TotalCost = 47232500,
                ClientId = 22,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-218),
                UpdatedAt
             = DateTime.Now.AddDays(-218)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 219,
                TotalCost = 6582000,
                ClientId = 84,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-219),
                UpdatedAt
             = DateTime.Now.AddDays(-219)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 220,
                TotalCost = 47582000,
                ClientId = 64,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-220),
                UpdatedAt
             = DateTime.Now.AddDays(-220)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 221,
                TotalCost = 242744500,
                ClientId = 4,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-221),
                UpdatedAt
             = DateTime.Now.AddDays(-221)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 222,
                TotalCost = 100250500,
                ClientId = 119,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-222),
                UpdatedAt
             = DateTime.Now.AddDays(-222)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 223,
                TotalCost = 104269000,
                ClientId = 7,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-223),
                UpdatedAt
             = DateTime.Now.AddDays(-223)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 224,
                TotalCost = 13512000,
                ClientId = 30,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-224),
                UpdatedAt
             = DateTime.Now.AddDays(-224)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 225,
                TotalCost = 158142000,
                ClientId = 182,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-225),
                UpdatedAt
             = DateTime.Now.AddDays(-225)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 226,
                TotalCost = 75318000,
                ClientId = 152,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-226),
                UpdatedAt
             = DateTime.Now.AddDays(-226)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 227,
                TotalCost = 191680500,
                ClientId = 158,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-227),
                UpdatedAt
             = DateTime.Now.AddDays(-227)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 228,
                TotalCost = 112830000,
                ClientId = 77,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-228),
                UpdatedAt
             = DateTime.Now.AddDays(-228)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 229,
                TotalCost = 49476000,
                ClientId = 180,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-229),
                UpdatedAt
             = DateTime.Now.AddDays(-229)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 230,
                TotalCost = 33399000,
                ClientId = 40,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-230),
                UpdatedAt
             = DateTime.Now.AddDays(-230)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 231,
                TotalCost = 48097000,
                ClientId = 134,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-231),
                UpdatedAt
             = DateTime.Now.AddDays(-231)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 232,
                TotalCost = 132206000,
                ClientId = 95,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-232),
                UpdatedAt
             = DateTime.Now.AddDays(-232)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 233,
                TotalCost = 44560000,
                ClientId = 154,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-233),
                UpdatedAt
             = DateTime.Now.AddDays(-233)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 234,
                TotalCost = 138663000,
                ClientId = 27,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-234),
                UpdatedAt
             = DateTime.Now.AddDays(-234)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 235,
                TotalCost = 61245000,
                ClientId = 108,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-235),
                UpdatedAt
             = DateTime.Now.AddDays(-235)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 236,
                TotalCost = 13957500,
                ClientId = 175,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-236),
                UpdatedAt
             = DateTime.Now.AddDays(-236)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 237,
                TotalCost = 19872000,
                ClientId = 200,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-237),
                UpdatedAt
             = DateTime.Now.AddDays(-237)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 238,
                TotalCost = 115404000,
                ClientId = 114,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-238),
                UpdatedAt
             = DateTime.Now.AddDays(-238)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 239,
                TotalCost = 42936000,
                ClientId = 33,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-239),
                UpdatedAt
             = DateTime.Now.AddDays(-239)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 240,
                TotalCost = 26685000,
                ClientId = 12,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-240),
                UpdatedAt
             = DateTime.Now.AddDays(-240)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 241,
                TotalCost = 97856000,
                ClientId = 94,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-241),
                UpdatedAt
             = DateTime.Now.AddDays(-241)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 242,
                TotalCost = 203164500,
                ClientId = 97,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-242),
                UpdatedAt
             = DateTime.Now.AddDays(-242)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 243,
                TotalCost = 74761000,
                ClientId = 171,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-243),
                UpdatedAt
             = DateTime.Now.AddDays(-243)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 244,
                TotalCost = 31970000,
                ClientId = 32,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-244),
                UpdatedAt
             = DateTime.Now.AddDays(-244)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 245,
                TotalCost = 33900000,
                ClientId = 127,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-245),
                UpdatedAt
             = DateTime.Now.AddDays(-245)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 246,
                TotalCost = 73318500,
                ClientId = 30,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-246),
                UpdatedAt
             = DateTime.Now.AddDays(-246)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 247,
                TotalCost = 175557000,
                ClientId = 30,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-247),
                UpdatedAt
             = DateTime.Now.AddDays(-247)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 248,
                TotalCost = 101274000,
                ClientId = 16,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-248),
                UpdatedAt
             = DateTime.Now.AddDays(-248)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 249,
                TotalCost = 130124000,
                ClientId = 37,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-249),
                UpdatedAt
             = DateTime.Now.AddDays(-249)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 250,
                TotalCost = 77994000,
                ClientId = 3,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-250),
                UpdatedAt
             = DateTime.Now.AddDays(-250)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 251,
                TotalCost = 11126000,
                ClientId = 61,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-251),
                UpdatedAt
             = DateTime.Now.AddDays(-251)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 252,
                TotalCost = 133125000,
                ClientId = 8,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-252),
                UpdatedAt
             = DateTime.Now.AddDays(-252)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 253,
                TotalCost = 62700000,
                ClientId = 112,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-253),
                UpdatedAt
             = DateTime.Now.AddDays(-253)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 254,
                TotalCost = 100930500,
                ClientId = 150,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-254),
                UpdatedAt
             = DateTime.Now.AddDays(-254)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 255,
                TotalCost = 112517500,
                ClientId = 97,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-255),
                UpdatedAt
             = DateTime.Now.AddDays(-255)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 256,
                TotalCost = 16966500,
                ClientId = 175,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-256),
                UpdatedAt
             = DateTime.Now.AddDays(-256)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 257,
                TotalCost = 106353000,
                ClientId = 180,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-257),
                UpdatedAt
             = DateTime.Now.AddDays(-257)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 258,
                TotalCost = 144864000,
                ClientId = 79,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-258),
                UpdatedAt
             = DateTime.Now.AddDays(-258)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 259,
                TotalCost = 37026000,
                ClientId = 182,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-259),
                UpdatedAt
             = DateTime.Now.AddDays(-259)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 260,
                TotalCost = 49234000,
                ClientId = 110,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-260),
                UpdatedAt
             = DateTime.Now.AddDays(-260)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 261,
                TotalCost = 164257500,
                ClientId = 48,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-261),
                UpdatedAt
             = DateTime.Now.AddDays(-261)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 262,
                TotalCost = 99270000,
                ClientId = 147,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-262),
                UpdatedAt
             = DateTime.Now.AddDays(-262)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 263,
                TotalCost = 90454000,
                ClientId = 79,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-263),
                UpdatedAt
             = DateTime.Now.AddDays(-263)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 264,
                TotalCost = 33078000,
                ClientId = 144,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-264),
                UpdatedAt
             = DateTime.Now.AddDays(-264)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 265,
                TotalCost = 148349500,
                ClientId = 15,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-265),
                UpdatedAt
             = DateTime.Now.AddDays(-265)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 266,
                TotalCost = 193914000,
                ClientId = 54,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-266),
                UpdatedAt
             = DateTime.Now.AddDays(-266)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 267,
                TotalCost = 48424500,
                ClientId = 200,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-267),
                UpdatedAt
             = DateTime.Now.AddDays(-267)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 268,
                TotalCost = 121860000,
                ClientId = 63,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-268),
                UpdatedAt
             = DateTime.Now.AddDays(-268)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 269,
                TotalCost = 109311000,
                ClientId = 112,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-269),
                UpdatedAt
             = DateTime.Now.AddDays(-269)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 270,
                TotalCost = 68781000,
                ClientId = 97,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-270),
                UpdatedAt
             = DateTime.Now.AddDays(-270)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 271,
                TotalCost = 32621500,
                ClientId = 139,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-271),
                UpdatedAt
             = DateTime.Now.AddDays(-271)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 272,
                TotalCost = 37296000,
                ClientId = 87,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-272),
                UpdatedAt
             = DateTime.Now.AddDays(-272)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 273,
                TotalCost = 47829000,
                ClientId = 200,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-273),
                UpdatedAt
             = DateTime.Now.AddDays(-273)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 274,
                TotalCost = 13446000,
                ClientId = 50,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-274),
                UpdatedAt
             = DateTime.Now.AddDays(-274)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 275,
                TotalCost = 81974000,
                ClientId = 75,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-275),
                UpdatedAt
             = DateTime.Now.AddDays(-275)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 276,
                TotalCost = 69510000,
                ClientId = 15,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-276),
                UpdatedAt
             = DateTime.Now.AddDays(-276)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 277,
                TotalCost = 34830000,
                ClientId = 86,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-277),
                UpdatedAt
             = DateTime.Now.AddDays(-277)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 278,
                TotalCost = 22287000,
                ClientId = 109,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-278),
                UpdatedAt
             = DateTime.Now.AddDays(-278)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 279,
                TotalCost = 175323000,
                ClientId = 102,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-279),
                UpdatedAt
             = DateTime.Now.AddDays(-279)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 280,
                TotalCost = 145320000,
                ClientId = 84,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-280),
                UpdatedAt
             = DateTime.Now.AddDays(-280)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 281,
                TotalCost = 104686500,
                ClientId = 67,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-281),
                UpdatedAt
             = DateTime.Now.AddDays(-281)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 282,
                TotalCost = 147304500,
                ClientId = 174,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-282),
                UpdatedAt
             = DateTime.Now.AddDays(-282)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 283,
                TotalCost = 99693000,
                ClientId = 58,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-283),
                UpdatedAt
             = DateTime.Now.AddDays(-283)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 284,
                TotalCost = 136312500,
                ClientId = 160,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-284),
                UpdatedAt
             = DateTime.Now.AddDays(-284)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 285,
                TotalCost = 49432500,
                ClientId = 177,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-285),
                UpdatedAt
             = DateTime.Now.AddDays(-285)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 286,
                TotalCost = 119078000,
                ClientId = 6,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-286),
                UpdatedAt
             = DateTime.Now.AddDays(-286)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 287,
                TotalCost = 52884000,
                ClientId = 22,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-287),
                UpdatedAt
             = DateTime.Now.AddDays(-287)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 288,
                TotalCost = 35946000,
                ClientId = 97,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-288),
                UpdatedAt
             = DateTime.Now.AddDays(-288)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 289,
                TotalCost = 62353500,
                ClientId = 59,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-289),
                UpdatedAt
             = DateTime.Now.AddDays(-289)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 290,
                TotalCost = 38637500,
                ClientId = 18,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-290),
                UpdatedAt
             = DateTime.Now.AddDays(-290)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 291,
                TotalCost = 73853500,
                ClientId = 139,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-291),
                UpdatedAt
             = DateTime.Now.AddDays(-291)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 292,
                TotalCost = 14341500,
                ClientId = 182,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-292),
                UpdatedAt
             = DateTime.Now.AddDays(-292)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 293,
                TotalCost = 163114000,
                ClientId = 6,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-293),
                UpdatedAt
             = DateTime.Now.AddDays(-293)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 294,
                TotalCost = 20560500,
                ClientId = 160,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-294),
                UpdatedAt
             = DateTime.Now.AddDays(-294)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 295,
                TotalCost = 147643500,
                ClientId = 47,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-295),
                UpdatedAt
             = DateTime.Now.AddDays(-295)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 296,
                TotalCost = 162225000,
                ClientId = 15,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-296),
                UpdatedAt
             = DateTime.Now.AddDays(-296)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 297,
                TotalCost = 18415500,
                ClientId = 12,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-297),
                UpdatedAt
             = DateTime.Now.AddDays(-297)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 298,
                TotalCost = 95458000,
                ClientId = 143,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-298),
                UpdatedAt
             = DateTime.Now.AddDays(-298)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 299,
                TotalCost = 42462000,
                ClientId = 63,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-299),
                UpdatedAt
             = DateTime.Now.AddDays(-299)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 300,
                TotalCost = 226990500,
                ClientId = 24,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-300),
                UpdatedAt
             = DateTime.Now.AddDays(-300)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 301,
                TotalCost = 43887500,
                ClientId = 90,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-301),
                UpdatedAt
             = DateTime.Now.AddDays(-301)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 302,
                TotalCost = 55272000,
                ClientId = 163,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-302),
                UpdatedAt
             = DateTime.Now.AddDays(-302)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 303,
                TotalCost = 87716000,
                ClientId = 106,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-303),
                UpdatedAt
             = DateTime.Now.AddDays(-303)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 304,
                TotalCost = 70907000,
                ClientId = 75,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-304),
                UpdatedAt
             = DateTime.Now.AddDays(-304)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 305,
                TotalCost = 70830000,
                ClientId = 164,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-305),
                UpdatedAt
             = DateTime.Now.AddDays(-305)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 306,
                TotalCost = 68827000,
                ClientId = 73,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-306),
                UpdatedAt
             = DateTime.Now.AddDays(-306)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 307,
                TotalCost = 55416000,
                ClientId = 6,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-307),
                UpdatedAt
             = DateTime.Now.AddDays(-307)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 308,
                TotalCost = 133735000,
                ClientId = 80,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-308),
                UpdatedAt
             = DateTime.Now.AddDays(-308)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 309,
                TotalCost = 70064500,
                ClientId = 115,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-309),
                UpdatedAt
             = DateTime.Now.AddDays(-309)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 310,
                TotalCost = 17046000,
                ClientId = 58,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-310),
                UpdatedAt
             = DateTime.Now.AddDays(-310)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 311,
                TotalCost = 186597000,
                ClientId = 93,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-311),
                UpdatedAt
             = DateTime.Now.AddDays(-311)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 312,
                TotalCost = 4467000,
                ClientId = 149,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-312),
                UpdatedAt
             = DateTime.Now.AddDays(-312)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 313,
                TotalCost = 34432500,
                ClientId = 199,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-313),
                UpdatedAt
             = DateTime.Now.AddDays(-313)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 314,
                TotalCost = 185958000,
                ClientId = 77,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-314),
                UpdatedAt
             = DateTime.Now.AddDays(-314)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 315,
                TotalCost = 85889000,
                ClientId = 1,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-315),
                UpdatedAt
             = DateTime.Now.AddDays(-315)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 316,
                TotalCost = 86417500,
                ClientId = 107,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-316),
                UpdatedAt
             = DateTime.Now.AddDays(-316)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 317,
                TotalCost = 28080000,
                ClientId = 81,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-317),
                UpdatedAt
             = DateTime.Now.AddDays(-317)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 318,
                TotalCost = 35832000,
                ClientId = 5,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-318),
                UpdatedAt
             = DateTime.Now.AddDays(-318)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 319,
                TotalCost = 66915000,
                ClientId = 75,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-319),
                UpdatedAt
             = DateTime.Now.AddDays(-319)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 320,
                TotalCost = 19440000,
                ClientId = 8,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-320),
                UpdatedAt
             = DateTime.Now.AddDays(-320)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 321,
                TotalCost = 64512000,
                ClientId = 33,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-321),
                UpdatedAt
             = DateTime.Now.AddDays(-321)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 322,
                TotalCost = 53543000,
                ClientId = 56,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-322),
                UpdatedAt
             = DateTime.Now.AddDays(-322)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 323,
                TotalCost = 64176000,
                ClientId = 40,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-323),
                UpdatedAt
             = DateTime.Now.AddDays(-323)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 324,
                TotalCost = 50145000,
                ClientId = 166,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-324),
                UpdatedAt
             = DateTime.Now.AddDays(-324)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 325,
                TotalCost = 17118000,
                ClientId = 39,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-325),
                UpdatedAt
             = DateTime.Now.AddDays(-325)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 326,
                TotalCost = 43902500,
                ClientId = 108,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-326),
                UpdatedAt
             = DateTime.Now.AddDays(-326)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 327,
                TotalCost = 165300000,
                ClientId = 199,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-327),
                UpdatedAt
             = DateTime.Now.AddDays(-327)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 328,
                TotalCost = 135924000,
                ClientId = 56,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-328),
                UpdatedAt
             = DateTime.Now.AddDays(-328)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 329,
                TotalCost = 10296500,
                ClientId = 30,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-329),
                UpdatedAt
             = DateTime.Now.AddDays(-329)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 330,
                TotalCost = 77148000,
                ClientId = 24,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-330),
                UpdatedAt
             = DateTime.Now.AddDays(-330)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 331,
                TotalCost = 42443500,
                ClientId = 124,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-331),
                UpdatedAt
             = DateTime.Now.AddDays(-331)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 332,
                TotalCost = 156465000,
                ClientId = 75,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-332),
                UpdatedAt
             = DateTime.Now.AddDays(-332)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 333,
                TotalCost = 10805000,
                ClientId = 119,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-333),
                UpdatedAt
             = DateTime.Now.AddDays(-333)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 334,
                TotalCost = 38333000,
                ClientId = 78,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-334),
                UpdatedAt
             = DateTime.Now.AddDays(-334)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 335,
                TotalCost = 67260000,
                ClientId = 15,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-335),
                UpdatedAt
             = DateTime.Now.AddDays(-335)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 336,
                TotalCost = 141141000,
                ClientId = 38,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-336),
                UpdatedAt
             = DateTime.Now.AddDays(-336)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 337,
                TotalCost = 84679000,
                ClientId = 152,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-337),
                UpdatedAt
             = DateTime.Now.AddDays(-337)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 338,
                TotalCost = 36502500,
                ClientId = 85,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-338),
                UpdatedAt
             = DateTime.Now.AddDays(-338)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 339,
                TotalCost = 77421000,
                ClientId = 178,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-339),
                UpdatedAt
             = DateTime.Now.AddDays(-339)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 340,
                TotalCost = 47627000,
                ClientId = 93,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-340),
                UpdatedAt
             = DateTime.Now.AddDays(-340)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 341,
                TotalCost = 85944000,
                ClientId = 133,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-341),
                UpdatedAt
             = DateTime.Now.AddDays(-341)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 342,
                TotalCost = 102196000,
                ClientId = 49,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-342),
                UpdatedAt
             = DateTime.Now.AddDays(-342)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 343,
                TotalCost = 85032000,
                ClientId = 107,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-343),
                UpdatedAt
             = DateTime.Now.AddDays(-343)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 344,
                TotalCost = 35055000,
                ClientId = 23,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-344),
                UpdatedAt
             = DateTime.Now.AddDays(-344)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 345,
                TotalCost = 67386000,
                ClientId = 150,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-345),
                UpdatedAt
             = DateTime.Now.AddDays(-345)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 346,
                TotalCost = 76692500,
                ClientId = 13,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-346),
                UpdatedAt
             = DateTime.Now.AddDays(-346)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 347,
                TotalCost = 244320000,
                ClientId = 122,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-347),
                UpdatedAt
             = DateTime.Now.AddDays(-347)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 348,
                TotalCost = 73934000,
                ClientId = 128,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-348),
                UpdatedAt
             = DateTime.Now.AddDays(-348)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 349,
                TotalCost = 143847500,
                ClientId = 66,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-349),
                UpdatedAt
             = DateTime.Now.AddDays(-349)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 350,
                TotalCost = 119517000,
                ClientId = 44,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-350),
                UpdatedAt
             = DateTime.Now.AddDays(-350)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 351,
                TotalCost = 144804000,
                ClientId = 136,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-351),
                UpdatedAt
             = DateTime.Now.AddDays(-351)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 352,
                TotalCost = 79687500,
                ClientId = 154,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-352),
                UpdatedAt
             = DateTime.Now.AddDays(-352)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 353,
                TotalCost = 91477500,
                ClientId = 83,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-353),
                UpdatedAt
             = DateTime.Now.AddDays(-353)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 354,
                TotalCost = 9946500,
                ClientId = 125,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-354),
                UpdatedAt
             = DateTime.Now.AddDays(-354)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 355,
                TotalCost = 134937000,
                ClientId = 12,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-355),
                UpdatedAt
             = DateTime.Now.AddDays(-355)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 356,
                TotalCost = 60552000,
                ClientId = 158,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-356),
                UpdatedAt
             = DateTime.Now.AddDays(-356)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 357,
                TotalCost = 72468000,
                ClientId = 157,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-357),
                UpdatedAt
             = DateTime.Now.AddDays(-357)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 358,
                TotalCost = 67513500,
                ClientId = 185,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-358),
                UpdatedAt
             = DateTime.Now.AddDays(-358)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 359,
                TotalCost = 63904500,
                ClientId = 190,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-359),
                UpdatedAt
             = DateTime.Now.AddDays(-359)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 360,
                TotalCost = 145612500,
                ClientId = 76,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-360),
                UpdatedAt
             = DateTime.Now.AddDays(-360)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 361,
                TotalCost = 106849000,
                ClientId = 76,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-361),
                UpdatedAt
             = DateTime.Now.AddDays(-361)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 362,
                TotalCost = 101142000,
                ClientId = 153,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-362),
                UpdatedAt
             = DateTime.Now.AddDays(-362)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 363,
                TotalCost = 83191500,
                ClientId = 128,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-363),
                UpdatedAt
             = DateTime.Now.AddDays(-363)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 364,
                TotalCost = 29112000,
                ClientId = 186,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-364),
                UpdatedAt
             = DateTime.Now.AddDays(-364)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 365,
                TotalCost = 63365000,
                ClientId = 61,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-365),
                UpdatedAt
             = DateTime.Now.AddDays(-365)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 366,
                TotalCost = 140300000,
                ClientId = 149,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-366),
                UpdatedAt
             = DateTime.Now.AddDays(-366)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 367,
                TotalCost = 26618000,
                ClientId = 149,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-367),
                UpdatedAt
             = DateTime.Now.AddDays(-367)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 368,
                TotalCost = 149310000,
                ClientId = 134,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-368),
                UpdatedAt
             = DateTime.Now.AddDays(-368)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 369,
                TotalCost = 63496000,
                ClientId = 17,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-369),
                UpdatedAt
             = DateTime.Now.AddDays(-369)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 370,
                TotalCost = 146658000,
                ClientId = 13,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-370),
                UpdatedAt
             = DateTime.Now.AddDays(-370)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 371,
                TotalCost = 106840500,
                ClientId = 134,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-371),
                UpdatedAt
             = DateTime.Now.AddDays(-371)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 372,
                TotalCost = 58356000,
                ClientId = 10,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-372),
                UpdatedAt
             = DateTime.Now.AddDays(-372)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 373,
                TotalCost = 75804000,
                ClientId = 194,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-373),
                UpdatedAt
             = DateTime.Now.AddDays(-373)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 374,
                TotalCost = 38194000,
                ClientId = 177,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-374),
                UpdatedAt
             = DateTime.Now.AddDays(-374)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 375,
                TotalCost = 147171000,
                ClientId = 155,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-375),
                UpdatedAt
             = DateTime.Now.AddDays(-375)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 376,
                TotalCost = 185724000,
                ClientId = 45,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-376),
                UpdatedAt
             = DateTime.Now.AddDays(-376)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 377,
                TotalCost = 103598000,
                ClientId = 79,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-377),
                UpdatedAt
             = DateTime.Now.AddDays(-377)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 378,
                TotalCost = 18198000,
                ClientId = 177,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-378),
                UpdatedAt
             = DateTime.Now.AddDays(-378)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 379,
                TotalCost = 17121000,
                ClientId = 188,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-379),
                UpdatedAt
             = DateTime.Now.AddDays(-379)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 380,
                TotalCost = 137484000,
                ClientId = 117,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-380),
                UpdatedAt
             = DateTime.Now.AddDays(-380)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 381,
                TotalCost = 55941000,
                ClientId = 171,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-381),
                UpdatedAt
             = DateTime.Now.AddDays(-381)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 382,
                TotalCost = 64336500,
                ClientId = 127,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-382),
                UpdatedAt
             = DateTime.Now.AddDays(-382)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 383,
                TotalCost = 112647000,
                ClientId = 95,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-383),
                UpdatedAt
             = DateTime.Now.AddDays(-383)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 384,
                TotalCost = 184470000,
                ClientId = 138,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-384),
                UpdatedAt
             = DateTime.Now.AddDays(-384)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 385,
                TotalCost = 97240000,
                ClientId = 187,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-385),
                UpdatedAt
             = DateTime.Now.AddDays(-385)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 386,
                TotalCost = 127198500,
                ClientId = 132,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-386),
                UpdatedAt
             = DateTime.Now.AddDays(-386)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 387,
                TotalCost = 65202500,
                ClientId = 122,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-387),
                UpdatedAt
             = DateTime.Now.AddDays(-387)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 388,
                TotalCost = 36324000,
                ClientId = 4,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-388),
                UpdatedAt
             = DateTime.Now.AddDays(-388)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 389,
                TotalCost = 15988500,
                ClientId = 20,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-389),
                UpdatedAt
             = DateTime.Now.AddDays(-389)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 390,
                TotalCost = 77091000,
                ClientId = 74,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-390),
                UpdatedAt
             = DateTime.Now.AddDays(-390)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 391,
                TotalCost = 42573000,
                ClientId = 195,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-391),
                UpdatedAt
             = DateTime.Now.AddDays(-391)
            ,
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 392,
                TotalCost = 214689000,
                ClientId = 79,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-392),
                UpdatedAt
             = DateTime.Now.AddDays(-392),
            });
            context.SaveChanges();

           //____________________PaymentDetail______________________
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 1,
PaymentId = 1,
ProductId = 29,
ServiceId = 1,
AmoutEmployee = 160,
StartDate = DateTime.Now.AddDays(-19),
EndDate = DateTime.Now.AddDays(-18),
Cost = 4320000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-1),
UpdatedAt
 = DateTime.Now.AddDays(-1)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 2,
PaymentId = 1,
ProductId = 27,
ServiceId = 2,
AmoutEmployee = 118,
StartDate = DateTime.Now.AddDays(-100),
EndDate = DateTime.Now.AddDays(-94),
Cost = 30444000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-1),
UpdatedAt
 = DateTime.Now.AddDays(-1)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 3,
PaymentId = 1,
ProductId = 20,
ServiceId = 3,
AmoutEmployee = 33,
StartDate = DateTime.Now.AddDays(-109),
EndDate = DateTime.Now.AddDays(-94),
Cost = 13612500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-1),
UpdatedAt
 = DateTime.Now.AddDays(-1)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 4,
PaymentId = 2,
ProductId = 19,
ServiceId = 3,
AmoutEmployee = 87,
StartDate = DateTime.Now.AddDays(-130),
EndDate = DateTime.Now.AddDays(-120),
Cost = 3349500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-2),
UpdatedAt
 = DateTime.Now.AddDays(-2)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 5,
PaymentId = 2,
ProductId = 15,
ServiceId = 3,
AmoutEmployee = 152,
StartDate = DateTime.Now.AddDays(-74),
EndDate = DateTime.Now.AddDays(-73),
Cost = 56012000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-2),
UpdatedAt
 = DateTime.Now.AddDays(-2)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 6,
PaymentId = 2,
ProductId = 7,
ServiceId = 3,
AmoutEmployee = 70,
StartDate = DateTime.Now.AddDays(-117),
EndDate = DateTime.Now.AddDays(-111),
Cost = 25795000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-2),
UpdatedAt
 = DateTime.Now.AddDays(-2)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 7,
PaymentId = 3,
ProductId = 24,
ServiceId = 2,
AmoutEmployee = 26,
StartDate = DateTime.Now.AddDays(-8),
EndDate = DateTime.Now.AddDays(-4),
Cost = 312000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-3),
UpdatedAt
 = DateTime.Now.AddDays(-3)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 8,
PaymentId = 3,
ProductId = 5,
ServiceId = 3,
AmoutEmployee = 167,
StartDate = DateTime.Now.AddDays(-200),
EndDate = DateTime.Now.AddDays(-196),
Cost = 66132000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-3),
UpdatedAt
 = DateTime.Now.AddDays(-3)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 9,
PaymentId = 3,
ProductId = 18,
ServiceId = 3,
AmoutEmployee = 195,
StartDate = DateTime.Now.AddDays(-193),
EndDate = DateTime.Now.AddDays(-180),
Cost = 8580000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-3),
UpdatedAt
 = DateTime.Now.AddDays(-3)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 10,
PaymentId = 4,
ProductId = 1,
ServiceId = 3,
AmoutEmployee = 54,
StartDate = DateTime.Now.AddDays(-55),
EndDate = DateTime.Now.AddDays(-51),
Cost = 5643000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-4),
UpdatedAt
 = DateTime.Now.AddDays(-4)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 11,
PaymentId = 4,
ProductId = 30,
ServiceId = 1,
AmoutEmployee = 46,
StartDate = DateTime.Now.AddDays(-90),
EndDate = DateTime.Now.AddDays(-87),
Cost = 11799000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-4),
UpdatedAt
 = DateTime.Now.AddDays(-4)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 12,
PaymentId = 5,
ProductId = 2,
ServiceId = 3,
AmoutEmployee = 99,
StartDate = DateTime.Now.AddDays(-162),
EndDate = DateTime.Now.AddDays(-149),
Cost = 81675000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-5),
UpdatedAt
 = DateTime.Now.AddDays(-5)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 13,
PaymentId = 5,
ProductId = 16,
ServiceId = 1,
AmoutEmployee = 145,
StartDate = DateTime.Now.AddDays(-159),
EndDate = DateTime.Now.AddDays(-151),
Cost = 15007500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-5),
UpdatedAt
 = DateTime.Now.AddDays(-5)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 14,
PaymentId = 5,
ProductId = 9,
ServiceId = 3,
AmoutEmployee = 71,
StartDate = DateTime.Now.AddDays(-103),
EndDate = DateTime.Now.AddDays(-97),
Cost = 19915500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-5),
UpdatedAt
 = DateTime.Now.AddDays(-5)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 15,
PaymentId = 6,
ProductId = 3,
ServiceId = 1,
AmoutEmployee = 129,
StartDate = DateTime.Now.AddDays(-163),
EndDate = DateTime.Now.AddDays(-148),
Cost = 49923000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-6),
UpdatedAt
 = DateTime.Now.AddDays(-6)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 16,
PaymentId = 6,
ProductId = 10,
ServiceId = 3,
AmoutEmployee = 48,
StartDate = DateTime.Now.AddDays(-170),
EndDate = DateTime.Now.AddDays(-165),
Cost = 18744000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-6),
UpdatedAt
 = DateTime.Now.AddDays(-6)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 17,
PaymentId = 7,
ProductId = 20,
ServiceId = 1,
AmoutEmployee = 26,
StartDate = DateTime.Now.AddDays(-170),
EndDate = DateTime.Now.AddDays(-158),
Cost = 10179000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-7),
UpdatedAt
 = DateTime.Now.AddDays(-7)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 18,
PaymentId = 7,
ProductId = 21,
ServiceId = 2,
AmoutEmployee = 71,
StartDate = DateTime.Now.AddDays(-40),
EndDate = DateTime.Now.AddDays(-33),
Cost = 5964000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-7),
UpdatedAt
 = DateTime.Now.AddDays(-7)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 19,
PaymentId = 7,
ProductId = 29,
ServiceId = 3,
AmoutEmployee = 144,
StartDate = DateTime.Now.AddDays(-102),
EndDate = DateTime.Now.AddDays(-93),
Cost = 76032000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-7),
UpdatedAt
 = DateTime.Now.AddDays(-7)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 20,
PaymentId = 8,
ProductId = 1,
ServiceId = 2,
AmoutEmployee = 77,
StartDate = DateTime.Now.AddDays(-200),
EndDate = DateTime.Now.AddDays(-193),
Cost = 24948000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-8),
UpdatedAt
 = DateTime.Now.AddDays(-8)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 21,
PaymentId = 8,
ProductId = 29,
ServiceId = 1,
AmoutEmployee = 27,
StartDate = DateTime.Now.AddDays(-193),
EndDate = DateTime.Now.AddDays(-179),
Cost = 2673000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-8),
UpdatedAt
 = DateTime.Now.AddDays(-8)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 22,
PaymentId = 9,
ProductId = 5,
ServiceId = 1,
AmoutEmployee = 151,
StartDate = DateTime.Now.AddDays(-34),
EndDate = DateTime.Now.AddDays(-20),
Cost = 6115500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-9),
UpdatedAt
 = DateTime.Now.AddDays(-9)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 23,
PaymentId = 9,
ProductId = 5,
ServiceId = 3,
AmoutEmployee = 198,
StartDate = DateTime.Now.AddDays(-157),
EndDate = DateTime.Now.AddDays(-151),
Cost = 144837000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-9),
UpdatedAt
 = DateTime.Now.AddDays(-9)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 24,
PaymentId = 9,
ProductId = 9,
ServiceId = 1,
AmoutEmployee = 67,
StartDate = DateTime.Now.AddDays(-129),
EndDate = DateTime.Now.AddDays(-122),
Cost = 5427000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-9),
UpdatedAt
 = DateTime.Now.AddDays(-9)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 25,
PaymentId = 10,
ProductId = 1,
ServiceId = 2,
AmoutEmployee = 182,
StartDate = DateTime.Now.AddDays(-126),
EndDate = DateTime.Now.AddDays(-118),
Cost = 113568000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-10),
UpdatedAt
 = DateTime.Now.AddDays(-10)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 26,
PaymentId = 10,
ProductId = 17,
ServiceId = 1,
AmoutEmployee = 53,
StartDate = DateTime.Now.AddDays(-57),
EndDate = DateTime.Now.AddDays(-47),
Cost = 2623500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-10),
UpdatedAt
 = DateTime.Now.AddDays(-10)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 27,
PaymentId = 11,
ProductId = 15,
ServiceId = 1,
AmoutEmployee = 107,
StartDate = DateTime.Now.AddDays(-112),
EndDate = DateTime.Now.AddDays(-97),
Cost = 51039000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-11),
UpdatedAt
 = DateTime.Now.AddDays(-11)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 28,
PaymentId = 11,
ProductId = 6,
ServiceId = 1,
AmoutEmployee = 157,
StartDate = DateTime.Now.AddDays(-30),
EndDate = DateTime.Now.AddDays(-24),
Cost = 1413000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-11),
UpdatedAt
 = DateTime.Now.AddDays(-11)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 29,
PaymentId = 11,
ProductId = 9,
ServiceId = 1,
AmoutEmployee = 190,
StartDate = DateTime.Now.AddDays(-194),
EndDate = DateTime.Now.AddDays(-180),
Cost = 155610000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-11),
UpdatedAt
 = DateTime.Now.AddDays(-11)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 30,
PaymentId = 12,
ProductId = 26,
ServiceId = 2,
AmoutEmployee = 165,
StartDate = DateTime.Now.AddDays(-198),
EndDate = DateTime.Now.AddDays(-196),
Cost = 141570000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-12),
UpdatedAt
 = DateTime.Now.AddDays(-12)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 31,
PaymentId = 12,
ProductId = 22,
ServiceId = 1,
AmoutEmployee = 151,
StartDate = DateTime.Now.AddDays(-106),
EndDate = DateTime.Now.AddDays(-98),
Cost = 47565000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-12),
UpdatedAt
 = DateTime.Now.AddDays(-12)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 32,
PaymentId = 12,
ProductId = 25,
ServiceId = 3,
AmoutEmployee = 54,
StartDate = DateTime.Now.AddDays(-159),
EndDate = DateTime.Now.AddDays(-157),
Cost = 34155000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-12),
UpdatedAt
 = DateTime.Now.AddDays(-12)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 33,
PaymentId = 13,
ProductId = 8,
ServiceId = 3,
AmoutEmployee = 53,
StartDate = DateTime.Now.AddDays(-72),
EndDate = DateTime.Now.AddDays(-70),
Cost = 5247000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-13),
UpdatedAt
 = DateTime.Now.AddDays(-13)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 34,
PaymentId = 13,
ProductId = 29,
ServiceId = 1,
AmoutEmployee = 26,
StartDate = DateTime.Now.AddDays(-120),
EndDate = DateTime.Now.AddDays(-105),
Cost = 12753000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-13),
UpdatedAt
 = DateTime.Now.AddDays(-13)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 35,
PaymentId = 14,
ProductId = 5,
ServiceId = 1,
AmoutEmployee = 183,
StartDate = DateTime.Now.AddDays(-184),
EndDate = DateTime.Now.AddDays(-170),
Cost = 88114500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-14),
UpdatedAt
 = DateTime.Now.AddDays(-14)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 36,
PaymentId = 14,
ProductId = 29,
ServiceId = 1,
AmoutEmployee = 45,
StartDate = DateTime.Now.AddDays(-186),
EndDate = DateTime.Now.AddDays(-179),
Cost = 14985000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-14),
UpdatedAt
 = DateTime.Now.AddDays(-14)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 37,
PaymentId = 14,
ProductId = 10,
ServiceId = 2,
AmoutEmployee = 46,
StartDate = DateTime.Now.AddDays(-74),
EndDate = DateTime.Now.AddDays(-62),
Cost = 11868000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-14),
UpdatedAt
 = DateTime.Now.AddDays(-14)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 38,
PaymentId = 15,
ProductId = 15,
ServiceId = 1,
AmoutEmployee = 39,
StartDate = DateTime.Now.AddDays(-40),
EndDate = DateTime.Now.AddDays(-38),
Cost = 3510000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-15),
UpdatedAt
 = DateTime.Now.AddDays(-15)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 39,
PaymentId = 15,
ProductId = 11,
ServiceId = 2,
AmoutEmployee = 76,
StartDate = DateTime.Now.AddDays(-139),
EndDate = DateTime.Now.AddDays(-129),
Cost = 25536000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-15),
UpdatedAt
 = DateTime.Now.AddDays(-15)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 40,
PaymentId = 16,
ProductId = 18,
ServiceId = 3,
AmoutEmployee = 184,
StartDate = DateTime.Now.AddDays(-154),
EndDate = DateTime.Now.AddDays(-147),
Cost = 19228000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-16),
UpdatedAt
 = DateTime.Now.AddDays(-16)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 41,
PaymentId = 16,
ProductId = 21,
ServiceId = 1,
AmoutEmployee = 49,
StartDate = DateTime.Now.AddDays(-133),
EndDate = DateTime.Now.AddDays(-120),
Cost = 3087000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-16),
UpdatedAt
 = DateTime.Now.AddDays(-16)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 42,
PaymentId = 16,
ProductId = 18,
ServiceId = 1,
AmoutEmployee = 180,
StartDate = DateTime.Now.AddDays(-23),
EndDate = DateTime.Now.AddDays(-11),
Cost = 4860000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-16),
UpdatedAt
 = DateTime.Now.AddDays(-16)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 43,
PaymentId = 17,
ProductId = 8,
ServiceId = 3,
AmoutEmployee = 47,
StartDate = DateTime.Now.AddDays(-71),
EndDate = DateTime.Now.AddDays(-57),
Cost = 8013500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-17),
UpdatedAt
 = DateTime.Now.AddDays(-17)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 44,
PaymentId = 17,
ProductId = 24,
ServiceId = 2,
AmoutEmployee = 128,
StartDate = DateTime.Now.AddDays(-90),
EndDate = DateTime.Now.AddDays(-82),
Cost = 768000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-17),
UpdatedAt
 = DateTime.Now.AddDays(-17)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 45,
PaymentId = 18,
ProductId = 5,
ServiceId = 1,
AmoutEmployee = 69,
StartDate = DateTime.Now.AddDays(-192),
EndDate = DateTime.Now.AddDays(-190),
Cost = 22045500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-18),
UpdatedAt
 = DateTime.Now.AddDays(-18)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 46,
PaymentId = 18,
ProductId = 17,
ServiceId = 1,
AmoutEmployee = 146,
StartDate = DateTime.Now.AddDays(-77),
EndDate = DateTime.Now.AddDays(-62),
Cost = 27594000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-18),
UpdatedAt
 = DateTime.Now.AddDays(-18)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 47,
PaymentId = 18,
ProductId = 8,
ServiceId = 1,
AmoutEmployee = 179,
StartDate = DateTime.Now.AddDays(-52),
EndDate = DateTime.Now.AddDays(-47),
Cost = 10471500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-18),
UpdatedAt
 = DateTime.Now.AddDays(-18)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 48,
PaymentId = 19,
ProductId = 23,
ServiceId = 3,
AmoutEmployee = 180,
StartDate = DateTime.Now.AddDays(-79),
EndDate = DateTime.Now.AddDays(-71),
Cost = 63360000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-19),
UpdatedAt
 = DateTime.Now.AddDays(-19)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 49,
PaymentId = 19,
ProductId = 17,
ServiceId = 1,
AmoutEmployee = 55,
StartDate = DateTime.Now.AddDays(-142),
EndDate = DateTime.Now.AddDays(-132),
Cost = 29947500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-19),
UpdatedAt
 = DateTime.Now.AddDays(-19)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 50,
PaymentId = 20,
ProductId = 1,
ServiceId = 1,
AmoutEmployee = 54,
StartDate = DateTime.Now.AddDays(-46),
EndDate = DateTime.Now.AddDays(-37),
Cost = 3888000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-20),
UpdatedAt
 = DateTime.Now.AddDays(-20)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 51,
PaymentId = 20,
ProductId = 28,
ServiceId = 1,
AmoutEmployee = 192,
StartDate = DateTime.Now.AddDays(-198),
EndDate = DateTime.Now.AddDays(-193),
Cost = 120960000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-20),
UpdatedAt
 = DateTime.Now.AddDays(-20)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 52,
PaymentId = 20,
ProductId = 28,
ServiceId = 1,
AmoutEmployee = 165,
StartDate = DateTime.Now.AddDays(-154),
EndDate = DateTime.Now.AddDays(-140),
Cost = 103950000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-20),
UpdatedAt
 = DateTime.Now.AddDays(-20)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 53,
PaymentId = 21,
ProductId = 18,
ServiceId = 1,
AmoutEmployee = 123,
StartDate = DateTime.Now.AddDays(-126),
EndDate = DateTime.Now.AddDays(-111),
Cost = 13284000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-21),
UpdatedAt
 = DateTime.Now.AddDays(-21)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 54,
PaymentId = 21,
ProductId = 23,
ServiceId = 1,
AmoutEmployee = 84,
StartDate = DateTime.Now.AddDays(-160),
EndDate = DateTime.Now.AddDays(-152),
Cost = 40068000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-21),
UpdatedAt
 = DateTime.Now.AddDays(-21)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 55,
PaymentId = 22,
ProductId = 24,
ServiceId = 3,
AmoutEmployee = 191,
StartDate = DateTime.Now.AddDays(-193),
EndDate = DateTime.Now.AddDays(-183),
Cost = 48323000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-22),
UpdatedAt
 = DateTime.Now.AddDays(-22)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 56,
PaymentId = 22,
ProductId = 29,
ServiceId = 2,
AmoutEmployee = 65,
StartDate = DateTime.Now.AddDays(-163),
EndDate = DateTime.Now.AddDays(-159),
Cost = 44850000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-22),
UpdatedAt
 = DateTime.Now.AddDays(-22)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 57,
PaymentId = 22,
ProductId = 4,
ServiceId = 1,
AmoutEmployee = 113,
StartDate = DateTime.Now.AddDays(-22),
EndDate = DateTime.Now.AddDays(-17),
Cost = 2542500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-22),
UpdatedAt
 = DateTime.Now.AddDays(-22)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 58,
PaymentId = 23,
ProductId = 9,
ServiceId = 3,
AmoutEmployee = 159,
StartDate = DateTime.Now.AddDays(-176),
EndDate = DateTime.Now.AddDays(-162),
Cost = 25360500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-23),
UpdatedAt
 = DateTime.Now.AddDays(-23)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 59,
PaymentId = 23,
ProductId = 17,
ServiceId = 3,
AmoutEmployee = 126,
StartDate = DateTime.Now.AddDays(-68),
EndDate = DateTime.Now.AddDays(-57),
Cost = 30492000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-23),
UpdatedAt
 = DateTime.Now.AddDays(-23)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 60,
PaymentId = 23,
ProductId = 28,
ServiceId = 1,
AmoutEmployee = 197,
StartDate = DateTime.Now.AddDays(-10),
EndDate = DateTime.Now.AddDays(0),
Cost = 2659500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-23),
UpdatedAt
 = DateTime.Now.AddDays(-23)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 61,
PaymentId = 24,
ProductId = 21,
ServiceId = 2,
AmoutEmployee = 116,
StartDate = DateTime.Now.AddDays(-193),
EndDate = DateTime.Now.AddDays(-186),
Cost = 128064000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-24),
UpdatedAt
 = DateTime.Now.AddDays(-24)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 62,
PaymentId = 24,
ProductId = 30,
ServiceId = 2,
AmoutEmployee = 80,
StartDate = DateTime.Now.AddDays(-167),
EndDate = DateTime.Now.AddDays(-165),
Cost = 36960000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-24),
UpdatedAt
 = DateTime.Now.AddDays(-24)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 63,
PaymentId = 25,
ProductId = 27,
ServiceId = 2,
AmoutEmployee = 94,
StartDate = DateTime.Now.AddDays(-13),
EndDate = DateTime.Now.AddDays(2),
Cost = 1692000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-25),
UpdatedAt
 = DateTime.Now.AddDays(-25)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 64,
PaymentId = 25,
ProductId = 18,
ServiceId = 2,
AmoutEmployee = 142,
StartDate = DateTime.Now.AddDays(-179),
EndDate = DateTime.Now.AddDays(-176),
Cost = 145692000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-25),
UpdatedAt
 = DateTime.Now.AddDays(-25)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 65,
PaymentId = 25,
ProductId = 10,
ServiceId = 3,
AmoutEmployee = 129,
StartDate = DateTime.Now.AddDays(-68),
EndDate = DateTime.Now.AddDays(-62),
Cost = 16318500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-25),
UpdatedAt
 = DateTime.Now.AddDays(-25)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 66,
PaymentId = 26,
ProductId = 19,
ServiceId = 3,
AmoutEmployee = 149,
StartDate = DateTime.Now.AddDays(-69),
EndDate = DateTime.Now.AddDays(-62),
Cost = 31141000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-26),
UpdatedAt
 = DateTime.Now.AddDays(-26)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 67,
PaymentId = 26,
ProductId = 27,
ServiceId = 2,
AmoutEmployee = 79,
StartDate = DateTime.Now.AddDays(-164),
EndDate = DateTime.Now.AddDays(-157),
Cost = 57828000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-26),
UpdatedAt
 = DateTime.Now.AddDays(-26)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 68,
PaymentId = 27,
ProductId = 6,
ServiceId = 3,
AmoutEmployee = 55,
StartDate = DateTime.Now.AddDays(-105),
EndDate = DateTime.Now.AddDays(-91),
Cost = 20872500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-27),
UpdatedAt
 = DateTime.Now.AddDays(-27)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 69,
PaymentId = 27,
ProductId = 4,
ServiceId = 2,
AmoutEmployee = 54,
StartDate = DateTime.Now.AddDays(-43),
EndDate = DateTime.Now.AddDays(-36),
Cost = 324000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-27),
UpdatedAt
 = DateTime.Now.AddDays(-27)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 70,
PaymentId = 27,
ProductId = 13,
ServiceId = 3,
AmoutEmployee = 154,
StartDate = DateTime.Now.AddDays(-126),
EndDate = DateTime.Now.AddDays(-121),
Cost = 94017000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-27),
UpdatedAt
 = DateTime.Now.AddDays(-27)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 71,
PaymentId = 28,
ProductId = 5,
ServiceId = 3,
AmoutEmployee = 197,
StartDate = DateTime.Now.AddDays(-163),
EndDate = DateTime.Now.AddDays(-159),
Cost = 167942500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-28),
UpdatedAt
 = DateTime.Now.AddDays(-28)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 72,
PaymentId = 28,
ProductId = 15,
ServiceId = 3,
AmoutEmployee = 70,
StartDate = DateTime.Now.AddDays(-10),
EndDate = DateTime.Now.AddDays(-9),
Cost = 385000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-28),
UpdatedAt
 = DateTime.Now.AddDays(-28)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 73,
PaymentId = 29,
ProductId = 17,
ServiceId = 1,
AmoutEmployee = 66,
StartDate = DateTime.Now.AddDays(-77),
EndDate = DateTime.Now.AddDays(-71),
Cost = 7128000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-29),
UpdatedAt
 = DateTime.Now.AddDays(-29)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 74,
PaymentId = 29,
ProductId = 5,
ServiceId = 2,
AmoutEmployee = 54,
StartDate = DateTime.Now.AddDays(-46),
EndDate = DateTime.Now.AddDays(-31),
Cost = 10692000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-29),
UpdatedAt
 = DateTime.Now.AddDays(-29)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 75,
PaymentId = 29,
ProductId = 25,
ServiceId = 3,
AmoutEmployee = 160,
StartDate = DateTime.Now.AddDays(-116),
EndDate = DateTime.Now.AddDays(-102),
Cost = 53680000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-29),
UpdatedAt
 = DateTime.Now.AddDays(-29)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 76,
PaymentId = 30,
ProductId = 21,
ServiceId = 2,
AmoutEmployee = 68,
StartDate = DateTime.Now.AddDays(-10),
EndDate = DateTime.Now.AddDays(-1),
Cost = 1632000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-30),
UpdatedAt
 = DateTime.Now.AddDays(-30)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 77,
PaymentId = 30,
ProductId = 7,
ServiceId = 3,
AmoutEmployee = 200,
StartDate = DateTime.Now.AddDays(-181),
EndDate = DateTime.Now.AddDays(-179),
Cost = 51700000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-30),
UpdatedAt
 = DateTime.Now.AddDays(-30)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 78,
PaymentId = 31,
ProductId = 25,
ServiceId = 3,
AmoutEmployee = 129,
StartDate = DateTime.Now.AddDays(-71),
EndDate = DateTime.Now.AddDays(-59),
Cost = 34765500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-31),
UpdatedAt
 = DateTime.Now.AddDays(-31)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 79,
PaymentId = 31,
ProductId = 17,
ServiceId = 1,
AmoutEmployee = 61,
StartDate = DateTime.Now.AddDays(-135),
EndDate = DateTime.Now.AddDays(-133),
Cost = 2470500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-31),
UpdatedAt
 = DateTime.Now.AddDays(-31)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 80,
PaymentId = 31,
ProductId = 19,
ServiceId = 3,
AmoutEmployee = 61,
StartDate = DateTime.Now.AddDays(-66),
EndDate = DateTime.Now.AddDays(-65),
Cost = 3019500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-31),
UpdatedAt
 = DateTime.Now.AddDays(-31)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 81,
PaymentId = 32,
ProductId = 30,
ServiceId = 2,
AmoutEmployee = 140,
StartDate = DateTime.Now.AddDays(-124),
EndDate = DateTime.Now.AddDays(-116),
Cost = 52920000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-32),
UpdatedAt
 = DateTime.Now.AddDays(-32)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 82,
PaymentId = 32,
ProductId = 20,
ServiceId = 2,
AmoutEmployee = 25,
StartDate = DateTime.Now.AddDays(-117),
EndDate = DateTime.Now.AddDays(-107),
Cost = 5100000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-32),
UpdatedAt
 = DateTime.Now.AddDays(-32)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 83,
PaymentId = 33,
ProductId = 13,
ServiceId = 2,
AmoutEmployee = 71,
StartDate = DateTime.Now.AddDays(-183),
EndDate = DateTime.Now.AddDays(-176),
Cost = 57936000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-33),
UpdatedAt
 = DateTime.Now.AddDays(-33)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 84,
PaymentId = 33,
ProductId = 23,
ServiceId = 3,
AmoutEmployee = 155,
StartDate = DateTime.Now.AddDays(-102),
EndDate = DateTime.Now.AddDays(-98),
Cost = 28132500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-33),
UpdatedAt
 = DateTime.Now.AddDays(-33)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 85,
PaymentId = 33,
ProductId = 11,
ServiceId = 2,
AmoutEmployee = 70,
StartDate = DateTime.Now.AddDays(-183),
EndDate = DateTime.Now.AddDays(-173),
Cost = 71820000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-33),
UpdatedAt
 = DateTime.Now.AddDays(-33)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 86,
PaymentId = 34,
ProductId = 8,
ServiceId = 3,
AmoutEmployee = 105,
StartDate = DateTime.Now.AddDays(-106),
EndDate = DateTime.Now.AddDays(-99),
Cost = 58327500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-34),
UpdatedAt
 = DateTime.Now.AddDays(-34)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 87,
PaymentId = 34,
ProductId = 16,
ServiceId = 1,
AmoutEmployee = 197,
StartDate = DateTime.Now.AddDays(-31),
EndDate = DateTime.Now.AddDays(-19),
Cost = 7978500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-34),
UpdatedAt
 = DateTime.Now.AddDays(-34)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 88,
PaymentId = 34,
ProductId = 11,
ServiceId = 3,
AmoutEmployee = 114,
StartDate = DateTime.Now.AddDays(-96),
EndDate = DateTime.Now.AddDays(-91),
Cost = 33231000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-34),
UpdatedAt
 = DateTime.Now.AddDays(-34)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 89,
PaymentId = 35,
ProductId = 22,
ServiceId = 1,
AmoutEmployee = 96,
StartDate = DateTime.Now.AddDays(-178),
EndDate = DateTime.Now.AddDays(-175),
Cost = 32832000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-35),
UpdatedAt
 = DateTime.Now.AddDays(-35)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 90,
PaymentId = 35,
ProductId = 5,
ServiceId = 3,
AmoutEmployee = 88,
StartDate = DateTime.Now.AddDays(-45),
EndDate = DateTime.Now.AddDays(-30),
Cost = 17908000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-35),
UpdatedAt
 = DateTime.Now.AddDays(-35)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 91,
PaymentId = 36,
ProductId = 13,
ServiceId = 2,
AmoutEmployee = 88,
StartDate = DateTime.Now.AddDays(-151),
EndDate = DateTime.Now.AddDays(-149),
Cost = 43824000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-36),
UpdatedAt
 = DateTime.Now.AddDays(-36)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 92,
PaymentId = 36,
ProductId = 12,
ServiceId = 2,
AmoutEmployee = 152,
StartDate = DateTime.Now.AddDays(-140),
EndDate = DateTime.Now.AddDays(-128),
Cost = 94848000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-36),
UpdatedAt
 = DateTime.Now.AddDays(-36)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 93,
PaymentId = 36,
ProductId = 17,
ServiceId = 3,
AmoutEmployee = 45,
StartDate = DateTime.Now.AddDays(-37),
EndDate = DateTime.Now.AddDays(-23),
Cost = 7425000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-36),
UpdatedAt
 = DateTime.Now.AddDays(-36)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 94,
PaymentId = 37,
ProductId = 8,
ServiceId = 1,
AmoutEmployee = 166,
StartDate = DateTime.Now.AddDays(-193),
EndDate = DateTime.Now.AddDays(-180),
Cost = 53784000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-37),
UpdatedAt
 = DateTime.Now.AddDays(-37)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 95,
PaymentId = 37,
ProductId = 21,
ServiceId = 1,
AmoutEmployee = 126,
StartDate = DateTime.Now.AddDays(-190),
EndDate = DateTime.Now.AddDays(-179),
Cost = 50463000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-37),
UpdatedAt
 = DateTime.Now.AddDays(-37)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 96,
PaymentId = 38,
ProductId = 8,
ServiceId = 3,
AmoutEmployee = 58,
StartDate = DateTime.Now.AddDays(-171),
EndDate = DateTime.Now.AddDays(-163),
Cost = 11165000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-38),
UpdatedAt
 = DateTime.Now.AddDays(-38)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 97,
PaymentId = 38,
ProductId = 16,
ServiceId = 2,
AmoutEmployee = 174,
StartDate = DateTime.Now.AddDays(-21),
EndDate = DateTime.Now.AddDays(-19),
Cost = 1044000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-38),
UpdatedAt
 = DateTime.Now.AddDays(-38)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 98,
PaymentId = 38,
ProductId = 2,
ServiceId = 1,
AmoutEmployee = 177,
StartDate = DateTime.Now.AddDays(-140),
EndDate = DateTime.Now.AddDays(-130),
Cost = 62923500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-38),
UpdatedAt
 = DateTime.Now.AddDays(-38)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 99,
PaymentId = 39,
ProductId = 6,
ServiceId = 3,
AmoutEmployee = 159,
StartDate = DateTime.Now.AddDays(-188),
EndDate = DateTime.Now.AddDays(-180),
Cost = 59466000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-39),
UpdatedAt
 = DateTime.Now.AddDays(-39)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 100,
PaymentId = 39,
ProductId = 11,
ServiceId = 2,
AmoutEmployee = 64,
StartDate = DateTime.Now.AddDays(-64),
EndDate = DateTime.Now.AddDays(-59),
Cost = 16128000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-39),
UpdatedAt
 = DateTime.Now.AddDays(-39)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 101,
PaymentId = 40,
ProductId = 21,
ServiceId = 3,
AmoutEmployee = 33,
StartDate = DateTime.Now.AddDays(-95),
EndDate = DateTime.Now.AddDays(-85),
Cost = 6715500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-40),
UpdatedAt
 = DateTime.Now.AddDays(-40)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 102,
PaymentId = 40,
ProductId = 24,
ServiceId = 2,
AmoutEmployee = 94,
StartDate = DateTime.Now.AddDays(-148),
EndDate = DateTime.Now.AddDays(-134),
Cost = 77268000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-40),
UpdatedAt
 = DateTime.Now.AddDays(-40)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 103,
PaymentId = 40,
ProductId = 14,
ServiceId = 1,
AmoutEmployee = 177,
StartDate = DateTime.Now.AddDays(-116),
EndDate = DateTime.Now.AddDays(-108),
Cost = 70092000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-40),
UpdatedAt
 = DateTime.Now.AddDays(-40)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 104,
PaymentId = 41,
ProductId = 21,
ServiceId = 2,
AmoutEmployee = 84,
StartDate = DateTime.Now.AddDays(-58),
EndDate = DateTime.Now.AddDays(-44),
Cost = 14112000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-41),
UpdatedAt
 = DateTime.Now.AddDays(-41)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 105,
PaymentId = 41,
ProductId = 15,
ServiceId = 2,
AmoutEmployee = 103,
StartDate = DateTime.Now.AddDays(-126),
EndDate = DateTime.Now.AddDays(-114),
Cost = 51294000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-41),
UpdatedAt
 = DateTime.Now.AddDays(-41)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 106,
PaymentId = 42,
ProductId = 18,
ServiceId = 1,
AmoutEmployee = 115,
StartDate = DateTime.Now.AddDays(-191),
EndDate = DateTime.Now.AddDays(-188),
Cost = 49162500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-42),
UpdatedAt
 = DateTime.Now.AddDays(-42)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 107,
PaymentId = 42,
ProductId = 3,
ServiceId = 3,
AmoutEmployee = 42,
StartDate = DateTime.Now.AddDays(-97),
EndDate = DateTime.Now.AddDays(-93),
Cost = 2772000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-42),
UpdatedAt
 = DateTime.Now.AddDays(-42)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 108,
PaymentId = 42,
ProductId = 3,
ServiceId = 3,
AmoutEmployee = 191,
StartDate = DateTime.Now.AddDays(-196),
EndDate = DateTime.Now.AddDays(-193),
Cost = 52525000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-42),
UpdatedAt
 = DateTime.Now.AddDays(-42)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 109,
PaymentId = 43,
ProductId = 29,
ServiceId = 3,
AmoutEmployee = 89,
StartDate = DateTime.Now.AddDays(-115),
EndDate = DateTime.Now.AddDays(-108),
Cost = 32307000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-43),
UpdatedAt
 = DateTime.Now.AddDays(-43)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 110,
PaymentId = 43,
ProductId = 17,
ServiceId = 1,
AmoutEmployee = 56,
StartDate = DateTime.Now.AddDays(-140),
EndDate = DateTime.Now.AddDays(-126),
Cost = 16128000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-43),
UpdatedAt
 = DateTime.Now.AddDays(-43)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 111,
PaymentId = 44,
ProductId = 12,
ServiceId = 3,
AmoutEmployee = 159,
StartDate = DateTime.Now.AddDays(-91),
EndDate = DateTime.Now.AddDays(-77),
Cost = 59466000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-44),
UpdatedAt
 = DateTime.Now.AddDays(-44)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 112,
PaymentId = 44,
ProductId = 8,
ServiceId = 3,
AmoutEmployee = 69,
StartDate = DateTime.Now.AddDays(-182),
EndDate = DateTime.Now.AddDays(-168),
Cost = 41365500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-44),
UpdatedAt
 = DateTime.Now.AddDays(-44)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 113,
PaymentId = 44,
ProductId = 25,
ServiceId = 3,
AmoutEmployee = 73,
StartDate = DateTime.Now.AddDays(-129),
EndDate = DateTime.Now.AddDays(-127),
Cost = 20476500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-44),
UpdatedAt
 = DateTime.Now.AddDays(-44)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 114,
PaymentId = 45,
ProductId = 30,
ServiceId = 2,
AmoutEmployee = 79,
StartDate = DateTime.Now.AddDays(-107),
EndDate = DateTime.Now.AddDays(-103),
Cost = 26070000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-45),
UpdatedAt
 = DateTime.Now.AddDays(-45)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 115,
PaymentId = 45,
ProductId = 14,
ServiceId = 2,
AmoutEmployee = 52,
StartDate = DateTime.Now.AddDays(-128),
EndDate = DateTime.Now.AddDays(-115),
Cost = 33696000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-45),
UpdatedAt
 = DateTime.Now.AddDays(-45)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 116,
PaymentId = 45,
ProductId = 19,
ServiceId = 2,
AmoutEmployee = 72,
StartDate = DateTime.Now.AddDays(-184),
EndDate = DateTime.Now.AddDays(-179),
Cost = 34992000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-45),
UpdatedAt
 = DateTime.Now.AddDays(-45)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 117,
PaymentId = 46,
ProductId = 29,
ServiceId = 2,
AmoutEmployee = 170,
StartDate = DateTime.Now.AddDays(-180),
EndDate = DateTime.Now.AddDays(-177),
Cost = 135660000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-46),
UpdatedAt
 = DateTime.Now.AddDays(-46)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 118,
PaymentId = 46,
ProductId = 24,
ServiceId = 2,
AmoutEmployee = 118,
StartDate = DateTime.Now.AddDays(-44),
EndDate = DateTime.Now.AddDays(-38),
Cost = 15576000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-46),
UpdatedAt
 = DateTime.Now.AddDays(-46)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 119,
PaymentId = 47,
ProductId = 4,
ServiceId = 3,
AmoutEmployee = 85,
StartDate = DateTime.Now.AddDays(-163),
EndDate = DateTime.Now.AddDays(-152),
Cost = 13557500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-47),
UpdatedAt
 = DateTime.Now.AddDays(-47)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 120,
PaymentId = 47,
ProductId = 18,
ServiceId = 2,
AmoutEmployee = 88,
StartDate = DateTime.Now.AddDays(-22),
EndDate = DateTime.Now.AddDays(-14),
Cost = 5280000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-47),
UpdatedAt
 = DateTime.Now.AddDays(-47)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 121,
PaymentId = 47,
ProductId = 27,
ServiceId = 1,
AmoutEmployee = 80,
StartDate = DateTime.Now.AddDays(-14),
EndDate = DateTime.Now.AddDays(-8),
Cost = 1080000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-47),
UpdatedAt
 = DateTime.Now.AddDays(-47)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 122,
PaymentId = 48,
ProductId = 30,
ServiceId = 2,
AmoutEmployee = 50,
StartDate = DateTime.Now.AddDays(-33),
EndDate = DateTime.Now.AddDays(-32),
Cost = 2400000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-48),
UpdatedAt
 = DateTime.Now.AddDays(-48)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 123,
PaymentId = 48,
ProductId = 26,
ServiceId = 3,
AmoutEmployee = 156,
StartDate = DateTime.Now.AddDays(-181),
EndDate = DateTime.Now.AddDays(-170),
Cost = 135564000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-48),
UpdatedAt
 = DateTime.Now.AddDays(-48)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 124,
PaymentId = 49,
ProductId = 14,
ServiceId = 1,
AmoutEmployee = 164,
StartDate = DateTime.Now.AddDays(-63),
EndDate = DateTime.Now.AddDays(-58),
Cost = 17712000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-49),
UpdatedAt
 = DateTime.Now.AddDays(-49)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 125,
PaymentId = 49,
ProductId = 18,
ServiceId = 1,
AmoutEmployee = 139,
StartDate = DateTime.Now.AddDays(-134),
EndDate = DateTime.Now.AddDays(-124),
Cost = 72558000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-49),
UpdatedAt
 = DateTime.Now.AddDays(-49)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 126,
PaymentId = 49,
ProductId = 7,
ServiceId = 2,
AmoutEmployee = 193,
StartDate = DateTime.Now.AddDays(-63),
EndDate = DateTime.Now.AddDays(-57),
Cost = 15054000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-49),
UpdatedAt
 = DateTime.Now.AddDays(-49)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 127,
PaymentId = 50,
ProductId = 25,
ServiceId = 2,
AmoutEmployee = 53,
StartDate = DateTime.Now.AddDays(-70),
EndDate = DateTime.Now.AddDays(-67),
Cost = 12084000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-50),
UpdatedAt
 = DateTime.Now.AddDays(-50)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 128,
PaymentId = 50,
ProductId = 14,
ServiceId = 1,
AmoutEmployee = 157,
StartDate = DateTime.Now.AddDays(-23),
EndDate = DateTime.Now.AddDays(-22),
Cost = 4239000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-50),
UpdatedAt
 = DateTime.Now.AddDays(-50)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 129,
PaymentId = 51,
ProductId = 1,
ServiceId = 3,
AmoutEmployee = 116,
StartDate = DateTime.Now.AddDays(-36),
EndDate = DateTime.Now.AddDays(-23),
Cost = 18502000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-51),
UpdatedAt
 = DateTime.Now.AddDays(-51)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 130,
PaymentId = 51,
ProductId = 4,
ServiceId = 3,
AmoutEmployee = 131,
StartDate = DateTime.Now.AddDays(-59),
EndDate = DateTime.Now.AddDays(-50),
Cost = 18012500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-51),
UpdatedAt
 = DateTime.Now.AddDays(-51)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 131,
PaymentId = 51,
ProductId = 8,
ServiceId = 1,
AmoutEmployee = 60,
StartDate = DateTime.Now.AddDays(-10),
EndDate = DateTime.Now.AddDays(-5),
Cost = 1080000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-51),
UpdatedAt
 = DateTime.Now.AddDays(-51)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 132,
PaymentId = 52,
ProductId = 8,
ServiceId = 1,
AmoutEmployee = 178,
StartDate = DateTime.Now.AddDays(-45),
EndDate = DateTime.Now.AddDays(-36),
Cost = 18423000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-52),
UpdatedAt
 = DateTime.Now.AddDays(-52)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 133,
PaymentId = 52,
ProductId = 15,
ServiceId = 1,
AmoutEmployee = 98,
StartDate = DateTime.Now.AddDays(-124),
EndDate = DateTime.Now.AddDays(-111),
Cost = 21168000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-52),
UpdatedAt
 = DateTime.Now.AddDays(-52)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 134,
PaymentId = 53,
ProductId = 30,
ServiceId = 2,
AmoutEmployee = 104,
StartDate = DateTime.Now.AddDays(-21),
EndDate = DateTime.Now.AddDays(-6),
Cost = 8112000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-53),
UpdatedAt
 = DateTime.Now.AddDays(-53)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 135,
PaymentId = 53,
ProductId = 25,
ServiceId = 2,
AmoutEmployee = 129,
StartDate = DateTime.Now.AddDays(-25),
EndDate = DateTime.Now.AddDays(-12),
Cost = 2322000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-53),
UpdatedAt
 = DateTime.Now.AddDays(-53)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 136,
PaymentId = 53,
ProductId = 30,
ServiceId = 3,
AmoutEmployee = 105,
StartDate = DateTime.Now.AddDays(-165),
EndDate = DateTime.Now.AddDays(-164),
Cost = 12127500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-53),
UpdatedAt
 = DateTime.Now.AddDays(-53)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 137,
PaymentId = 54,
ProductId = 25,
ServiceId = 2,
AmoutEmployee = 168,
StartDate = DateTime.Now.AddDays(-76),
EndDate = DateTime.Now.AddDays(-75),
Cost = 35280000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-54),
UpdatedAt
 = DateTime.Now.AddDays(-54)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 138,
PaymentId = 54,
ProductId = 2,
ServiceId = 1,
AmoutEmployee = 127,
StartDate = DateTime.Now.AddDays(-176),
EndDate = DateTime.Now.AddDays(-164),
Cost = 97155000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-54),
UpdatedAt
 = DateTime.Now.AddDays(-54)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 139,
PaymentId = 55,
ProductId = 13,
ServiceId = 1,
AmoutEmployee = 44,
StartDate = DateTime.Now.AddDays(-119),
EndDate = DateTime.Now.AddDays(-107),
Cost = 4158000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-55),
UpdatedAt
 = DateTime.Now.AddDays(-55)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 140,
PaymentId = 55,
ProductId = 30,
ServiceId = 2,
AmoutEmployee = 200,
StartDate = DateTime.Now.AddDays(-115),
EndDate = DateTime.Now.AddDays(-113),
Cost = 132000000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-55),
UpdatedAt
 = DateTime.Now.AddDays(-55)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 141,
PaymentId = 55,
ProductId = 17,
ServiceId = 3,
AmoutEmployee = 149,
StartDate = DateTime.Now.AddDays(-43),
EndDate = DateTime.Now.AddDays(-38),
Cost = 28682500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-55),
UpdatedAt
 = DateTime.Now.AddDays(-55)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 142,
PaymentId = 56,
ProductId = 2,
ServiceId = 3,
AmoutEmployee = 65,
StartDate = DateTime.Now.AddDays(-115),
EndDate = DateTime.Now.AddDays(-109),
Cost = 24310000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-56),
UpdatedAt
 = DateTime.Now.AddDays(-56)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 143,
PaymentId = 56,
ProductId = 6,
ServiceId = 3,
AmoutEmployee = 92,
StartDate = DateTime.Now.AddDays(-121),
EndDate = DateTime.Now.AddDays(-110),
Cost = 26312000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-56),
UpdatedAt
 = DateTime.Now.AddDays(-56)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 144,
PaymentId = 56,
ProductId = 10,
ServiceId = 2,
AmoutEmployee = 174,
StartDate = DateTime.Now.AddDays(-121),
EndDate = DateTime.Now.AddDays(-119),
Cost = 31320000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-56),
UpdatedAt
 = DateTime.Now.AddDays(-56)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 145,
PaymentId = 57,
ProductId = 23,
ServiceId = 1,
AmoutEmployee = 79,
StartDate = DateTime.Now.AddDays(-59),
EndDate = DateTime.Now.AddDays(-57),
Cost = 15286500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-57),
UpdatedAt
 = DateTime.Now.AddDays(-57)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 146,
PaymentId = 57,
ProductId = 3,
ServiceId = 1,
AmoutEmployee = 25,
StartDate = DateTime.Now.AddDays(-16),
EndDate = DateTime.Now.AddDays(-7),
Cost = 112500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-57),
UpdatedAt
 = DateTime.Now.AddDays(-57)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 147,
PaymentId = 58,
ProductId = 6,
ServiceId = 1,
AmoutEmployee = 195,
StartDate = DateTime.Now.AddDays(-185),
EndDate = DateTime.Now.AddDays(-183),
Cost = 58792500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-58),
UpdatedAt
 = DateTime.Now.AddDays(-58)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 148,
PaymentId = 58,
ProductId = 18,
ServiceId = 2,
AmoutEmployee = 181,
StartDate = DateTime.Now.AddDays(-99),
EndDate = DateTime.Now.AddDays(-86),
Cost = 21720000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-58),
UpdatedAt
 = DateTime.Now.AddDays(-58)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 149,
PaymentId = 58,
ProductId = 2,
ServiceId = 2,
AmoutEmployee = 96,
StartDate = DateTime.Now.AddDays(-80),
EndDate = DateTime.Now.AddDays(-74),
Cost = 23040000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-58),
UpdatedAt
 = DateTime.Now.AddDays(-58)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 150,
PaymentId = 59,
ProductId = 18,
ServiceId = 1,
AmoutEmployee = 104,
StartDate = DateTime.Now.AddDays(-133),
EndDate = DateTime.Now.AddDays(-127),
Cost = 3744000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-59),
UpdatedAt
 = DateTime.Now.AddDays(-59)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 151,
PaymentId = 59,
ProductId = 16,
ServiceId = 1,
AmoutEmployee = 133,
StartDate = DateTime.Now.AddDays(-199),
EndDate = DateTime.Now.AddDays(-196),
Cost = 46084500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-59),
UpdatedAt
 = DateTime.Now.AddDays(-59)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 152,
PaymentId = 60,
ProductId = 13,
ServiceId = 3,
AmoutEmployee = 162,
StartDate = DateTime.Now.AddDays(-130),
EndDate = DateTime.Now.AddDays(-126),
Cost = 67716000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-60),
UpdatedAt
 = DateTime.Now.AddDays(-60)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 153,
PaymentId = 60,
ProductId = 13,
ServiceId = 3,
AmoutEmployee = 124,
StartDate = DateTime.Now.AddDays(-185),
EndDate = DateTime.Now.AddDays(-183),
Cost = 97526000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-60),
UpdatedAt
 = DateTime.Now.AddDays(-60)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 154,
PaymentId = 60,
ProductId = 10,
ServiceId = 3,
AmoutEmployee = 183,
StartDate = DateTime.Now.AddDays(-188),
EndDate = DateTime.Now.AddDays(-176),
Cost = 55357500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-60),
UpdatedAt
 = DateTime.Now.AddDays(-60)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 155,
PaymentId = 61,
ProductId = 2,
ServiceId = 1,
AmoutEmployee = 138,
StartDate = DateTime.Now.AddDays(-109),
EndDate = DateTime.Now.AddDays(-101),
Cost = 29187000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-61),
UpdatedAt
 = DateTime.Now.AddDays(-61)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 156,
PaymentId = 61,
ProductId = 22,
ServiceId = 2,
AmoutEmployee = 137,
StartDate = DateTime.Now.AddDays(-108),
EndDate = DateTime.Now.AddDays(-100),
Cost = 39456000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-61),
UpdatedAt
 = DateTime.Now.AddDays(-61)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 157,
PaymentId = 62,
ProductId = 7,
ServiceId = 1,
AmoutEmployee = 31,
StartDate = DateTime.Now.AddDays(-168),
EndDate = DateTime.Now.AddDays(-158),
Cost = 21343500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-62),
UpdatedAt
 = DateTime.Now.AddDays(-62)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 158,
PaymentId = 62,
ProductId = 1,
ServiceId = 1,
AmoutEmployee = 57,
StartDate = DateTime.Now.AddDays(-153),
EndDate = DateTime.Now.AddDays(-144),
Cost = 31806000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-62),
UpdatedAt
 = DateTime.Now.AddDays(-62)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 159,
PaymentId = 62,
ProductId = 3,
ServiceId = 2,
AmoutEmployee = 166,
StartDate = DateTime.Now.AddDays(-85),
EndDate = DateTime.Now.AddDays(-70),
Cost = 42828000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-62),
UpdatedAt
 = DateTime.Now.AddDays(-62)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 160,
PaymentId = 63,
ProductId = 14,
ServiceId = 2,
AmoutEmployee = 86,
StartDate = DateTime.Now.AddDays(-170),
EndDate = DateTime.Now.AddDays(-162),
Cost = 44376000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-63),
UpdatedAt
 = DateTime.Now.AddDays(-63)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 161,
PaymentId = 63,
ProductId = 4,
ServiceId = 3,
AmoutEmployee = 136,
StartDate = DateTime.Now.AddDays(-96),
EndDate = DateTime.Now.AddDays(-91),
Cost = 59092000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-63),
UpdatedAt
 = DateTime.Now.AddDays(-63)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 162,
PaymentId = 64,
ProductId = 8,
ServiceId = 2,
AmoutEmployee = 159,
StartDate = DateTime.Now.AddDays(-122),
EndDate = DateTime.Now.AddDays(-118),
Cost = 105894000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-64),
UpdatedAt
 = DateTime.Now.AddDays(-64)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 163,
PaymentId = 64,
ProductId = 1,
ServiceId = 2,
AmoutEmployee = 30,
StartDate = DateTime.Now.AddDays(-133),
EndDate = DateTime.Now.AddDays(-132),
Cost = 360000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-64),
UpdatedAt
 = DateTime.Now.AddDays(-64)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 164,
PaymentId = 64,
ProductId = 24,
ServiceId = 2,
AmoutEmployee = 84,
StartDate = DateTime.Now.AddDays(-108),
EndDate = DateTime.Now.AddDays(-93),
Cost = 16128000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-64),
UpdatedAt
 = DateTime.Now.AddDays(-64)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 165,
PaymentId = 65,
ProductId = 12,
ServiceId = 3,
AmoutEmployee = 135,
StartDate = DateTime.Now.AddDays(-161),
EndDate = DateTime.Now.AddDays(-148),
Cost = 33412500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-65),
UpdatedAt
 = DateTime.Now.AddDays(-65)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 166,
PaymentId = 65,
ProductId = 27,
ServiceId = 1,
AmoutEmployee = 159,
StartDate = DateTime.Now.AddDays(-76),
EndDate = DateTime.Now.AddDays(-67),
Cost = 37206000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-65),
UpdatedAt
 = DateTime.Now.AddDays(-65)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 167,
PaymentId = 66,
ProductId = 15,
ServiceId = 1,
AmoutEmployee = 176,
StartDate = DateTime.Now.AddDays(-93),
EndDate = DateTime.Now.AddDays(-92),
Cost = 22968000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-66),
UpdatedAt
 = DateTime.Now.AddDays(-66)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 168,
PaymentId = 66,
ProductId = 1,
ServiceId = 2,
AmoutEmployee = 87,
StartDate = DateTime.Now.AddDays(-41),
EndDate = DateTime.Now.AddDays(-26),
Cost = 10962000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-66),
UpdatedAt
 = DateTime.Now.AddDays(-66)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 169,
PaymentId = 66,
ProductId = 27,
ServiceId = 3,
AmoutEmployee = 46,
StartDate = DateTime.Now.AddDays(-180),
EndDate = DateTime.Now.AddDays(-169),
Cost = 3036000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-66),
UpdatedAt
 = DateTime.Now.AddDays(-66)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 170,
PaymentId = 67,
ProductId = 25,
ServiceId = 1,
AmoutEmployee = 174,
StartDate = DateTime.Now.AddDays(-19),
EndDate = DateTime.Now.AddDays(-6),
Cost = 10179000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-67),
UpdatedAt
 = DateTime.Now.AddDays(-67)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 171,
PaymentId = 67,
ProductId = 7,
ServiceId = 3,
AmoutEmployee = 48,
StartDate = DateTime.Now.AddDays(-117),
EndDate = DateTime.Now.AddDays(-111),
Cost = 22968000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-67),
UpdatedAt
 = DateTime.Now.AddDays(-67)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 172,
PaymentId = 67,
ProductId = 4,
ServiceId = 2,
AmoutEmployee = 26,
StartDate = DateTime.Now.AddDays(-59),
EndDate = DateTime.Now.AddDays(-56),
Cost = 6708000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-67),
UpdatedAt
 = DateTime.Now.AddDays(-67)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 173,
PaymentId = 68,
ProductId = 3,
ServiceId = 2,
AmoutEmployee = 171,
StartDate = DateTime.Now.AddDays(-54),
EndDate = DateTime.Now.AddDays(-49),
Cost = 34884000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-68),
UpdatedAt
 = DateTime.Now.AddDays(-68)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 174,
PaymentId = 68,
ProductId = 27,
ServiceId = 3,
AmoutEmployee = 61,
StartDate = DateTime.Now.AddDays(-66),
EndDate = DateTime.Now.AddDays(-57),
Cost = 2684000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-68),
UpdatedAt
 = DateTime.Now.AddDays(-68)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 175,
PaymentId = 69,
ProductId = 3,
ServiceId = 3,
AmoutEmployee = 38,
StartDate = DateTime.Now.AddDays(-158),
EndDate = DateTime.Now.AddDays(-143),
Cost = 16093000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-69),
UpdatedAt
 = DateTime.Now.AddDays(-69)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 176,
PaymentId = 69,
ProductId = 12,
ServiceId = 3,
AmoutEmployee = 183,
StartDate = DateTime.Now.AddDays(-68),
EndDate = DateTime.Now.AddDays(-53),
Cost = 38247000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-69),
UpdatedAt
 = DateTime.Now.AddDays(-69)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 177,
PaymentId = 69,
ProductId = 16,
ServiceId = 3,
AmoutEmployee = 151,
StartDate = DateTime.Now.AddDays(-71),
EndDate = DateTime.Now.AddDays(-65),
Cost = 45677500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-69),
UpdatedAt
 = DateTime.Now.AddDays(-69)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 178,
PaymentId = 70,
ProductId = 8,
ServiceId = 1,
AmoutEmployee = 178,
StartDate = DateTime.Now.AddDays(-72),
EndDate = DateTime.Now.AddDays(-70),
Cost = 41652000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-70),
UpdatedAt
 = DateTime.Now.AddDays(-70)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 179,
PaymentId = 70,
ProductId = 8,
ServiceId = 3,
AmoutEmployee = 116,
StartDate = DateTime.Now.AddDays(-191),
EndDate = DateTime.Now.AddDays(-180),
Cost = 28710000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-70),
UpdatedAt
 = DateTime.Now.AddDays(-70)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 180,
PaymentId = 71,
ProductId = 22,
ServiceId = 1,
AmoutEmployee = 159,
StartDate = DateTime.Now.AddDays(-142),
EndDate = DateTime.Now.AddDays(-136),
Cost = 62248500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-71),
UpdatedAt
 = DateTime.Now.AddDays(-71)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 181,
PaymentId = 71,
ProductId = 15,
ServiceId = 3,
AmoutEmployee = 101,
StartDate = DateTime.Now.AddDays(-172),
EndDate = DateTime.Now.AddDays(-165),
Cost = 74437000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-71),
UpdatedAt
 = DateTime.Now.AddDays(-71)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 182,
PaymentId = 71,
ProductId = 7,
ServiceId = 1,
AmoutEmployee = 98,
StartDate = DateTime.Now.AddDays(-25),
EndDate = DateTime.Now.AddDays(-21),
Cost = 7497000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-71),
UpdatedAt
 = DateTime.Now.AddDays(-71)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 183,
PaymentId = 72,
ProductId = 6,
ServiceId = 3,
AmoutEmployee = 108,
StartDate = DateTime.Now.AddDays(-9),
EndDate = DateTime.Now.AddDays(-3),
Cost = 2376000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-72),
UpdatedAt
 = DateTime.Now.AddDays(-72)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 184,
PaymentId = 72,
ProductId = 12,
ServiceId = 1,
AmoutEmployee = 147,
StartDate = DateTime.Now.AddDays(-11),
EndDate = DateTime.Now.AddDays(-3),
Cost = 661500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-72),
UpdatedAt
 = DateTime.Now.AddDays(-72)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 185,
PaymentId = 73,
ProductId = 22,
ServiceId = 1,
AmoutEmployee = 148,
StartDate = DateTime.Now.AddDays(-50),
EndDate = DateTime.Now.AddDays(-47),
Cost = 27972000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-73),
UpdatedAt
 = DateTime.Now.AddDays(-73)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 186,
PaymentId = 73,
ProductId = 22,
ServiceId = 1,
AmoutEmployee = 73,
StartDate = DateTime.Now.AddDays(-132),
EndDate = DateTime.Now.AddDays(-121),
Cost = 12154500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-73),
UpdatedAt
 = DateTime.Now.AddDays(-73)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 187,
PaymentId = 73,
ProductId = 10,
ServiceId = 3,
AmoutEmployee = 191,
StartDate = DateTime.Now.AddDays(-188),
EndDate = DateTime.Now.AddDays(-181),
Cost = 93494500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-73),
UpdatedAt
 = DateTime.Now.AddDays(-73)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 188,
PaymentId = 74,
ProductId = 14,
ServiceId = 1,
AmoutEmployee = 105,
StartDate = DateTime.Now.AddDays(-15),
EndDate = DateTime.Now.AddDays(-1),
Cost = 1417500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-74),
UpdatedAt
 = DateTime.Now.AddDays(-74)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 189,
PaymentId = 74,
ProductId = 7,
ServiceId = 2,
AmoutEmployee = 100,
StartDate = DateTime.Now.AddDays(-51),
EndDate = DateTime.Now.AddDays(-45),
Cost = 21600000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-74),
UpdatedAt
 = DateTime.Now.AddDays(-74)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 190,
PaymentId = 75,
ProductId = 17,
ServiceId = 3,
AmoutEmployee = 82,
StartDate = DateTime.Now.AddDays(-152),
EndDate = DateTime.Now.AddDays(-139),
Cost = 35629000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-75),
UpdatedAt
 = DateTime.Now.AddDays(-75)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 191,
PaymentId = 75,
ProductId = 29,
ServiceId = 1,
AmoutEmployee = 35,
StartDate = DateTime.Now.AddDays(-99),
EndDate = DateTime.Now.AddDays(-91),
Cost = 6930000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-75),
UpdatedAt
 = DateTime.Now.AddDays(-75)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 192,
PaymentId = 75,
ProductId = 15,
ServiceId = 1,
AmoutEmployee = 192,
StartDate = DateTime.Now.AddDays(-132),
EndDate = DateTime.Now.AddDays(-130),
Cost = 30240000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-75),
UpdatedAt
 = DateTime.Now.AddDays(-75)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 193,
PaymentId = 76,
ProductId = 11,
ServiceId = 1,
AmoutEmployee = 103,
StartDate = DateTime.Now.AddDays(-43),
EndDate = DateTime.Now.AddDays(-35),
Cost = 17613000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-76),
UpdatedAt
 = DateTime.Now.AddDays(-76)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 194,
PaymentId = 76,
ProductId = 12,
ServiceId = 1,
AmoutEmployee = 27,
StartDate = DateTime.Now.AddDays(-122),
EndDate = DateTime.Now.AddDays(-119),
Cost = 486000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-76),
UpdatedAt
 = DateTime.Now.AddDays(-76)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 195,
PaymentId = 77,
ProductId = 4,
ServiceId = 3,
AmoutEmployee = 106,
StartDate = DateTime.Now.AddDays(-58),
EndDate = DateTime.Now.AddDays(-54),
Cost = 19239000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-77),
UpdatedAt
 = DateTime.Now.AddDays(-77)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 196,
PaymentId = 77,
ProductId = 13,
ServiceId = 1,
AmoutEmployee = 90,
StartDate = DateTime.Now.AddDays(-81),
EndDate = DateTime.Now.AddDays(-78),
Cost = 16605000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-77),
UpdatedAt
 = DateTime.Now.AddDays(-77)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 197,
PaymentId = 77,
ProductId = 20,
ServiceId = 1,
AmoutEmployee = 65,
StartDate = DateTime.Now.AddDays(-169),
EndDate = DateTime.Now.AddDays(-158),
Cost = 28665000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-77),
UpdatedAt
 = DateTime.Now.AddDays(-77)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 198,
PaymentId = 78,
ProductId = 16,
ServiceId = 2,
AmoutEmployee = 54,
StartDate = DateTime.Now.AddDays(-168),
EndDate = DateTime.Now.AddDays(-155),
Cost = 14904000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-78),
UpdatedAt
 = DateTime.Now.AddDays(-78)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 199,
PaymentId = 78,
ProductId = 4,
ServiceId = 2,
AmoutEmployee = 174,
StartDate = DateTime.Now.AddDays(-92),
EndDate = DateTime.Now.AddDays(-86),
Cost = 40716000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-78),
UpdatedAt
 = DateTime.Now.AddDays(-78)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 200,
PaymentId = 78,
ProductId = 8,
ServiceId = 3,
AmoutEmployee = 26,
StartDate = DateTime.Now.AddDays(-94),
EndDate = DateTime.Now.AddDays(-82),
Cost = 11440000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-78),
UpdatedAt
 = DateTime.Now.AddDays(-78)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 201,
PaymentId = 79,
ProductId = 5,
ServiceId = 2,
AmoutEmployee = 40,
StartDate = DateTime.Now.AddDays(-158),
EndDate = DateTime.Now.AddDays(-155),
Cost = 30000000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-79),
UpdatedAt
 = DateTime.Now.AddDays(-79)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 202,
PaymentId = 79,
ProductId = 27,
ServiceId = 1,
AmoutEmployee = 117,
StartDate = DateTime.Now.AddDays(-121),
EndDate = DateTime.Now.AddDays(-117),
Cost = 17374500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-79),
UpdatedAt
 = DateTime.Now.AddDays(-79)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 203,
PaymentId = 80,
ProductId = 12,
ServiceId = 3,
AmoutEmployee = 96,
StartDate = DateTime.Now.AddDays(-31),
EndDate = DateTime.Now.AddDays(-23),
Cost = 8976000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-80),
UpdatedAt
 = DateTime.Now.AddDays(-80)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 204,
PaymentId = 80,
ProductId = 12,
ServiceId = 2,
AmoutEmployee = 132,
StartDate = DateTime.Now.AddDays(-58),
EndDate = DateTime.Now.AddDays(-44),
Cost = 36432000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-80),
UpdatedAt
 = DateTime.Now.AddDays(-80)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 205,
PaymentId = 80,
ProductId = 27,
ServiceId = 3,
AmoutEmployee = 167,
StartDate = DateTime.Now.AddDays(-67),
EndDate = DateTime.Now.AddDays(-61),
Cost = 37658500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-80),
UpdatedAt
 = DateTime.Now.AddDays(-80)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 206,
PaymentId = 81,
ProductId = 17,
ServiceId = 1,
AmoutEmployee = 122,
StartDate = DateTime.Now.AddDays(-191),
EndDate = DateTime.Now.AddDays(-181),
Cost = 8235000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-81),
UpdatedAt
 = DateTime.Now.AddDays(-81)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 207,
PaymentId = 81,
ProductId = 2,
ServiceId = 1,
AmoutEmployee = 162,
StartDate = DateTime.Now.AddDays(-39),
EndDate = DateTime.Now.AddDays(-31),
Cost = 7290000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-81),
UpdatedAt
 = DateTime.Now.AddDays(-81)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 208,
PaymentId = 82,
ProductId = 17,
ServiceId = 2,
AmoutEmployee = 30,
StartDate = DateTime.Now.AddDays(-8),
EndDate = DateTime.Now.AddDays(2),
Cost = 180000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-82),
UpdatedAt
 = DateTime.Now.AddDays(-82)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 209,
PaymentId = 82,
ProductId = 14,
ServiceId = 3,
AmoutEmployee = 132,
StartDate = DateTime.Now.AddDays(-171),
EndDate = DateTime.Now.AddDays(-166),
Cost = 36300000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-82),
UpdatedAt
 = DateTime.Now.AddDays(-82)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 210,
PaymentId = 82,
ProductId = 13,
ServiceId = 3,
AmoutEmployee = 78,
StartDate = DateTime.Now.AddDays(-35),
EndDate = DateTime.Now.AddDays(-24),
Cost = 7293000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-82),
UpdatedAt
 = DateTime.Now.AddDays(-82)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 211,
PaymentId = 83,
ProductId = 19,
ServiceId = 2,
AmoutEmployee = 29,
StartDate = DateTime.Now.AddDays(-32),
EndDate = DateTime.Now.AddDays(-31),
Cost = 2610000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-83),
UpdatedAt
 = DateTime.Now.AddDays(-83)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 212,
PaymentId = 83,
ProductId = 5,
ServiceId = 3,
AmoutEmployee = 72,
StartDate = DateTime.Now.AddDays(-130),
EndDate = DateTime.Now.AddDays(-118),
Cost = 9504000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-83),
UpdatedAt
 = DateTime.Now.AddDays(-83)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 213,
PaymentId = 84,
ProductId = 2,
ServiceId = 1,
AmoutEmployee = 159,
StartDate = DateTime.Now.AddDays(-90),
EndDate = DateTime.Now.AddDays(-75),
Cost = 52231500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-84),
UpdatedAt
 = DateTime.Now.AddDays(-84)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 214,
PaymentId = 84,
ProductId = 8,
ServiceId = 3,
AmoutEmployee = 39,
StartDate = DateTime.Now.AddDays(-92),
EndDate = DateTime.Now.AddDays(-77),
Cost = 16087500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-84),
UpdatedAt
 = DateTime.Now.AddDays(-84)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 215,
PaymentId = 84,
ProductId = 6,
ServiceId = 1,
AmoutEmployee = 165,
StartDate = DateTime.Now.AddDays(-88),
EndDate = DateTime.Now.AddDays(-73),
Cost = 47520000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-84),
UpdatedAt
 = DateTime.Now.AddDays(-84)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 216,
PaymentId = 85,
ProductId = 17,
ServiceId = 1,
AmoutEmployee = 98,
StartDate = DateTime.Now.AddDays(-87),
EndDate = DateTime.Now.AddDays(-81),
Cost = 17640000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-85),
UpdatedAt
 = DateTime.Now.AddDays(-85)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 217,
PaymentId = 85,
ProductId = 10,
ServiceId = 1,
AmoutEmployee = 59,
StartDate = DateTime.Now.AddDays(-169),
EndDate = DateTime.Now.AddDays(-161),
Cost = 28408500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-85),
UpdatedAt
 = DateTime.Now.AddDays(-85)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 218,
PaymentId = 86,
ProductId = 6,
ServiceId = 2,
AmoutEmployee = 84,
StartDate = DateTime.Now.AddDays(-98),
EndDate = DateTime.Now.AddDays(-97),
Cost = 27720000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-86),
UpdatedAt
 = DateTime.Now.AddDays(-86)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 219,
PaymentId = 86,
ProductId = 1,
ServiceId = 3,
AmoutEmployee = 150,
StartDate = DateTime.Now.AddDays(-188),
EndDate = DateTime.Now.AddDays(-176),
Cost = 136125000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-86),
UpdatedAt
 = DateTime.Now.AddDays(-86)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 220,
PaymentId = 86,
ProductId = 11,
ServiceId = 3,
AmoutEmployee = 124,
StartDate = DateTime.Now.AddDays(-174),
EndDate = DateTime.Now.AddDays(-171),
Cost = 103664000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-86),
UpdatedAt
 = DateTime.Now.AddDays(-86)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 221,
PaymentId = 87,
ProductId = 26,
ServiceId = 3,
AmoutEmployee = 129,
StartDate = DateTime.Now.AddDays(-91),
EndDate = DateTime.Now.AddDays(-89),
Cost = 50374500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-87),
UpdatedAt
 = DateTime.Now.AddDays(-87)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 222,
PaymentId = 87,
ProductId = 24,
ServiceId = 1,
AmoutEmployee = 124,
StartDate = DateTime.Now.AddDays(-110),
EndDate = DateTime.Now.AddDays(-103),
Cost = 44640000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-87),
UpdatedAt
 = DateTime.Now.AddDays(-87)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 223,
PaymentId = 88,
ProductId = 6,
ServiceId = 3,
AmoutEmployee = 159,
StartDate = DateTime.Now.AddDays(-164),
EndDate = DateTime.Now.AddDays(-154),
Cost = 121555500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-88),
UpdatedAt
 = DateTime.Now.AddDays(-88)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 224,
PaymentId = 88,
ProductId = 29,
ServiceId = 1,
AmoutEmployee = 167,
StartDate = DateTime.Now.AddDays(-138),
EndDate = DateTime.Now.AddDays(-136),
Cost = 81913500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-88),
UpdatedAt
 = DateTime.Now.AddDays(-88)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 225,
PaymentId = 88,
ProductId = 15,
ServiceId = 2,
AmoutEmployee = 129,
StartDate = DateTime.Now.AddDays(-142),
EndDate = DateTime.Now.AddDays(-134),
Cost = 25542000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-88),
UpdatedAt
 = DateTime.Now.AddDays(-88)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 226,
PaymentId = 89,
ProductId = 8,
ServiceId = 3,
AmoutEmployee = 61,
StartDate = DateTime.Now.AddDays(-191),
EndDate = DateTime.Now.AddDays(-178),
Cost = 13755500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-89),
UpdatedAt
 = DateTime.Now.AddDays(-89)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 227,
PaymentId = 89,
ProductId = 7,
ServiceId = 1,
AmoutEmployee = 28,
StartDate = DateTime.Now.AddDays(-195),
EndDate = DateTime.Now.AddDays(-192),
Cost = 14112000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-89),
UpdatedAt
 = DateTime.Now.AddDays(-89)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 228,
PaymentId = 89,
ProductId = 4,
ServiceId = 1,
AmoutEmployee = 102,
StartDate = DateTime.Now.AddDays(-30),
EndDate = DateTime.Now.AddDays(-27),
Cost = 5967000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-89),
UpdatedAt
 = DateTime.Now.AddDays(-89)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 229,
PaymentId = 90,
ProductId = 9,
ServiceId = 2,
AmoutEmployee = 152,
StartDate = DateTime.Now.AddDays(-24),
EndDate = DateTime.Now.AddDays(-13),
Cost = 17328000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-90),
UpdatedAt
 = DateTime.Now.AddDays(-90)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 230,
PaymentId = 90,
ProductId = 11,
ServiceId = 3,
AmoutEmployee = 63,
StartDate = DateTime.Now.AddDays(-147),
EndDate = DateTime.Now.AddDays(-134),
Cost = 41233500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-90),
UpdatedAt
 = DateTime.Now.AddDays(-90)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 231,
PaymentId = 91,
ProductId = 22,
ServiceId = 2,
AmoutEmployee = 195,
StartDate = DateTime.Now.AddDays(-124),
EndDate = DateTime.Now.AddDays(-116),
Cost = 23400000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-91),
UpdatedAt
 = DateTime.Now.AddDays(-91)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 232,
PaymentId = 91,
ProductId = 2,
ServiceId = 1,
AmoutEmployee = 157,
StartDate = DateTime.Now.AddDays(-155),
EndDate = DateTime.Now.AddDays(-141),
Cost = 96084000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-91),
UpdatedAt
 = DateTime.Now.AddDays(-91)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 233,
PaymentId = 91,
ProductId = 24,
ServiceId = 2,
AmoutEmployee = 154,
StartDate = DateTime.Now.AddDays(-148),
EndDate = DateTime.Now.AddDays(-138),
Cost = 50820000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-91),
UpdatedAt
 = DateTime.Now.AddDays(-91)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 234,
PaymentId = 92,
ProductId = 2,
ServiceId = 1,
AmoutEmployee = 152,
StartDate = DateTime.Now.AddDays(-183),
EndDate = DateTime.Now.AddDays(-179),
Cost = 42408000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-92),
UpdatedAt
 = DateTime.Now.AddDays(-92)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 235,
PaymentId = 92,
ProductId = 28,
ServiceId = 2,
AmoutEmployee = 193,
StartDate = DateTime.Now.AddDays(-176),
EndDate = DateTime.Now.AddDays(-163),
Cost = 198018000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-92),
UpdatedAt
 = DateTime.Now.AddDays(-92)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 236,
PaymentId = 93,
ProductId = 16,
ServiceId = 1,
AmoutEmployee = 104,
StartDate = DateTime.Now.AddDays(-157),
EndDate = DateTime.Now.AddDays(-147),
Cost = 5148000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-93),
UpdatedAt
 = DateTime.Now.AddDays(-93)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 237,
PaymentId = 93,
ProductId = 4,
ServiceId = 2,
AmoutEmployee = 34,
StartDate = DateTime.Now.AddDays(-198),
EndDate = DateTime.Now.AddDays(-187),
Cost = 19584000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-93),
UpdatedAt
 = DateTime.Now.AddDays(-93)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 238,
PaymentId = 93,
ProductId = 19,
ServiceId = 3,
AmoutEmployee = 71,
StartDate = DateTime.Now.AddDays(-120),
EndDate = DateTime.Now.AddDays(-118),
Cost = 390500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-93),
UpdatedAt
 = DateTime.Now.AddDays(-93)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 239,
PaymentId = 94,
ProductId = 2,
ServiceId = 3,
AmoutEmployee = 93,
StartDate = DateTime.Now.AddDays(-74),
EndDate = DateTime.Now.AddDays(-59),
Cost = 28132500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-94),
UpdatedAt
 = DateTime.Now.AddDays(-94)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 240,
PaymentId = 94,
ProductId = 22,
ServiceId = 2,
AmoutEmployee = 109,
StartDate = DateTime.Now.AddDays(-189),
EndDate = DateTime.Now.AddDays(-174),
Cost = 31392000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-94),
UpdatedAt
 = DateTime.Now.AddDays(-94)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 241,
PaymentId = 95,
ProductId = 3,
ServiceId = 3,
AmoutEmployee = 193,
StartDate = DateTime.Now.AddDays(-8),
EndDate = DateTime.Now.AddDays(-4),
Cost = 3184500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-95),
UpdatedAt
 = DateTime.Now.AddDays(-95)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 242,
PaymentId = 95,
ProductId = 6,
ServiceId = 3,
AmoutEmployee = 71,
StartDate = DateTime.Now.AddDays(-48),
EndDate = DateTime.Now.AddDays(-38),
Cost = 13277000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-95),
UpdatedAt
 = DateTime.Now.AddDays(-95)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 243,
PaymentId = 95,
ProductId = 12,
ServiceId = 2,
AmoutEmployee = 74,
StartDate = DateTime.Now.AddDays(-10),
EndDate = DateTime.Now.AddDays(-4),
Cost = 444000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-95),
UpdatedAt
 = DateTime.Now.AddDays(-95)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 244,
PaymentId = 96,
ProductId = 20,
ServiceId = 2,
AmoutEmployee = 169,
StartDate = DateTime.Now.AddDays(-56),
EndDate = DateTime.Now.AddDays(-52),
Cost = 25350000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-96),
UpdatedAt
 = DateTime.Now.AddDays(-96)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 245,
PaymentId = 96,
ProductId = 10,
ServiceId = 2,
AmoutEmployee = 34,
StartDate = DateTime.Now.AddDays(-139),
EndDate = DateTime.Now.AddDays(-133),
Cost = 5916000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-96),
UpdatedAt
 = DateTime.Now.AddDays(-96)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 246,
PaymentId = 97,
ProductId = 29,
ServiceId = 1,
AmoutEmployee = 186,
StartDate = DateTime.Now.AddDays(-159),
EndDate = DateTime.Now.AddDays(-144),
Cost = 97092000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-97),
UpdatedAt
 = DateTime.Now.AddDays(-97)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 247,
PaymentId = 97,
ProductId = 2,
ServiceId = 3,
AmoutEmployee = 197,
StartDate = DateTime.Now.AddDays(-186),
EndDate = DateTime.Now.AddDays(-178),
Cost = 166859000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-97),
UpdatedAt
 = DateTime.Now.AddDays(-97)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 248,
PaymentId = 97,
ProductId = 10,
ServiceId = 3,
AmoutEmployee = 90,
StartDate = DateTime.Now.AddDays(-150),
EndDate = DateTime.Now.AddDays(-141),
Cost = 49500000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-97),
UpdatedAt
 = DateTime.Now.AddDays(-97)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 249,
PaymentId = 98,
ProductId = 2,
ServiceId = 3,
AmoutEmployee = 120,
StartDate = DateTime.Now.AddDays(-158),
EndDate = DateTime.Now.AddDays(-157),
Cost = 13200000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-98),
UpdatedAt
 = DateTime.Now.AddDays(-98)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 250,
PaymentId = 98,
ProductId = 21,
ServiceId = 1,
AmoutEmployee = 84,
StartDate = DateTime.Now.AddDays(-49),
EndDate = DateTime.Now.AddDays(-39),
Cost = 14742000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-98),
UpdatedAt
 = DateTime.Now.AddDays(-98)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 251,
PaymentId = 99,
ProductId = 29,
ServiceId = 3,
AmoutEmployee = 150,
StartDate = DateTime.Now.AddDays(-143),
EndDate = DateTime.Now.AddDays(-136),
Cost = 82500000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-99),
UpdatedAt
 = DateTime.Now.AddDays(-99)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 252,
PaymentId = 99,
ProductId = 1,
ServiceId = 2,
AmoutEmployee = 200,
StartDate = DateTime.Now.AddDays(-158),
EndDate = DateTime.Now.AddDays(-143),
Cost = 88800000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-99),
UpdatedAt
 = DateTime.Now.AddDays(-99)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 253,
PaymentId = 99,
ProductId = 28,
ServiceId = 3,
AmoutEmployee = 140,
StartDate = DateTime.Now.AddDays(-14),
EndDate = DateTime.Now.AddDays(-5),
Cost = 3850000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-99),
UpdatedAt
 = DateTime.Now.AddDays(-99)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 254,
PaymentId = 100,
ProductId = 10,
ServiceId = 2,
AmoutEmployee = 141,
StartDate = DateTime.Now.AddDays(-126),
EndDate = DateTime.Now.AddDays(-115),
Cost = 102366000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-100),
UpdatedAt
 = DateTime.Now.AddDays(-100)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 255,
PaymentId = 100,
ProductId = 22,
ServiceId = 3,
AmoutEmployee = 142,
StartDate = DateTime.Now.AddDays(-113),
EndDate = DateTime.Now.AddDays(-99),
Cost = 79662000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-100),
UpdatedAt
 = DateTime.Now.AddDays(-100)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 256,
PaymentId = 100,
ProductId = 7,
ServiceId = 3,
AmoutEmployee = 190,
StartDate = DateTime.Now.AddDays(-41),
EndDate = DateTime.Now.AddDays(-39),
Cost = 16720000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-100),
UpdatedAt
 = DateTime.Now.AddDays(-100)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 257,
PaymentId = 101,
ProductId = 27,
ServiceId = 1,
AmoutEmployee = 93,
StartDate = DateTime.Now.AddDays(-96),
EndDate = DateTime.Now.AddDays(-83),
Cost = 2092500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-101),
UpdatedAt
 = DateTime.Now.AddDays(-101)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 258,
PaymentId = 101,
ProductId = 26,
ServiceId = 2,
AmoutEmployee = 196,
StartDate = DateTime.Now.AddDays(-117),
EndDate = DateTime.Now.AddDays(-110),
Cost = 18816000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-101),
UpdatedAt
 = DateTime.Now.AddDays(-101)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 259,
PaymentId = 102,
ProductId = 22,
ServiceId = 2,
AmoutEmployee = 88,
StartDate = DateTime.Now.AddDays(-107),
EndDate = DateTime.Now.AddDays(-101),
Cost = 33792000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-102),
UpdatedAt
 = DateTime.Now.AddDays(-102)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 260,
PaymentId = 102,
ProductId = 10,
ServiceId = 1,
AmoutEmployee = 51,
StartDate = DateTime.Now.AddDays(-136),
EndDate = DateTime.Now.AddDays(-124),
Cost = 11016000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-102),
UpdatedAt
 = DateTime.Now.AddDays(-102)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 261,
PaymentId = 102,
ProductId = 15,
ServiceId = 1,
AmoutEmployee = 125,
StartDate = DateTime.Now.AddDays(-75),
EndDate = DateTime.Now.AddDays(-74),
Cost = 11812500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-102),
UpdatedAt
 = DateTime.Now.AddDays(-102)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 262,
PaymentId = 103,
ProductId = 19,
ServiceId = 2,
AmoutEmployee = 63,
StartDate = DateTime.Now.AddDays(-123),
EndDate = DateTime.Now.AddDays(-112),
Cost = 756000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-103),
UpdatedAt
 = DateTime.Now.AddDays(-103)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 263,
PaymentId = 103,
ProductId = 28,
ServiceId = 3,
AmoutEmployee = 158,
StartDate = DateTime.Now.AddDays(-21),
EndDate = DateTime.Now.AddDays(-10),
Cost = 13904000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-103),
UpdatedAt
 = DateTime.Now.AddDays(-103)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 264,
PaymentId = 104,
ProductId = 10,
ServiceId = 3,
AmoutEmployee = 126,
StartDate = DateTime.Now.AddDays(-138),
EndDate = DateTime.Now.AddDays(-129),
Cost = 43659000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-104),
UpdatedAt
 = DateTime.Now.AddDays(-104)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 265,
PaymentId = 104,
ProductId = 4,
ServiceId = 3,
AmoutEmployee = 36,
StartDate = DateTime.Now.AddDays(-107),
EndDate = DateTime.Now.AddDays(-93),
Cost = 4158000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-104),
UpdatedAt
 = DateTime.Now.AddDays(-104)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 266,
PaymentId = 104,
ProductId = 10,
ServiceId = 1,
AmoutEmployee = 175,
StartDate = DateTime.Now.AddDays(-60),
EndDate = DateTime.Now.AddDays(-47),
Cost = 7875000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-104),
UpdatedAt
 = DateTime.Now.AddDays(-104)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 267,
PaymentId = 105,
ProductId = 24,
ServiceId = 2,
AmoutEmployee = 151,
StartDate = DateTime.Now.AddDays(-64),
EndDate = DateTime.Now.AddDays(-58),
Cost = 30804000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-105),
UpdatedAt
 = DateTime.Now.AddDays(-105)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 268,
PaymentId = 105,
ProductId = 25,
ServiceId = 2,
AmoutEmployee = 101,
StartDate = DateTime.Now.AddDays(-104),
EndDate = DateTime.Now.AddDays(-95),
Cost = 38784000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-105),
UpdatedAt
 = DateTime.Now.AddDays(-105)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 269,
PaymentId = 106,
ProductId = 17,
ServiceId = 2,
AmoutEmployee = 134,
StartDate = DateTime.Now.AddDays(-164),
EndDate = DateTime.Now.AddDays(-149),
Cost = 93264000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-106),
UpdatedAt
 = DateTime.Now.AddDays(-106)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 270,
PaymentId = 106,
ProductId = 22,
ServiceId = 3,
AmoutEmployee = 149,
StartDate = DateTime.Now.AddDays(-151),
EndDate = DateTime.Now.AddDays(-146),
Cost = 45892000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-106),
UpdatedAt
 = DateTime.Now.AddDays(-106)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 271,
PaymentId = 106,
ProductId = 23,
ServiceId = 2,
AmoutEmployee = 200,
StartDate = DateTime.Now.AddDays(-52),
EndDate = DateTime.Now.AddDays(-40),
Cost = 32400000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-106),
UpdatedAt
 = DateTime.Now.AddDays(-106)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 272,
PaymentId = 107,
ProductId = 21,
ServiceId = 1,
AmoutEmployee = 70,
StartDate = DateTime.Now.AddDays(-45),
EndDate = DateTime.Now.AddDays(-34),
Cost = 12285000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-107),
UpdatedAt
 = DateTime.Now.AddDays(-107)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 273,
PaymentId = 107,
ProductId = 8,
ServiceId = 3,
AmoutEmployee = 125,
StartDate = DateTime.Now.AddDays(-10),
EndDate = DateTime.Now.AddDays(0),
Cost = 2750000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-107),
UpdatedAt
 = DateTime.Now.AddDays(-107)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 274,
PaymentId = 108,
ProductId = 27,
ServiceId = 3,
AmoutEmployee = 113,
StartDate = DateTime.Now.AddDays(-137),
EndDate = DateTime.Now.AddDays(-136),
Cost = 60907000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-108),
UpdatedAt
 = DateTime.Now.AddDays(-108)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 275,
PaymentId = 108,
ProductId = 2,
ServiceId = 3,
AmoutEmployee = 35,
StartDate = DateTime.Now.AddDays(-54),
EndDate = DateTime.Now.AddDays(-51),
Cost = 8855000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-108),
UpdatedAt
 = DateTime.Now.AddDays(-108)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 276,
PaymentId = 108,
ProductId = 7,
ServiceId = 2,
AmoutEmployee = 183,
StartDate = DateTime.Now.AddDays(-168),
EndDate = DateTime.Now.AddDays(-165),
Cost = 18666000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-108),
UpdatedAt
 = DateTime.Now.AddDays(-108)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 277,
PaymentId = 109,
ProductId = 25,
ServiceId = 2,
AmoutEmployee = 88,
StartDate = DateTime.Now.AddDays(-127),
EndDate = DateTime.Now.AddDays(-114),
Cost = 23232000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-109),
UpdatedAt
 = DateTime.Now.AddDays(-109)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 278,
PaymentId = 109,
ProductId = 7,
ServiceId = 2,
AmoutEmployee = 177,
StartDate = DateTime.Now.AddDays(-162),
EndDate = DateTime.Now.AddDays(-158),
Cost = 52038000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-109),
UpdatedAt
 = DateTime.Now.AddDays(-109)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 279,
PaymentId = 110,
ProductId = 11,
ServiceId = 3,
AmoutEmployee = 118,
StartDate = DateTime.Now.AddDays(-66),
EndDate = DateTime.Now.AddDays(-60),
Cost = 17523000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-110),
UpdatedAt
 = DateTime.Now.AddDays(-110)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 280,
PaymentId = 110,
ProductId = 14,
ServiceId = 1,
AmoutEmployee = 29,
StartDate = DateTime.Now.AddDays(-12),
EndDate = DateTime.Now.AddDays(-4),
Cost = 652500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-110),
UpdatedAt
 = DateTime.Now.AddDays(-110)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 281,
PaymentId = 110,
ProductId = 9,
ServiceId = 3,
AmoutEmployee = 110,
StartDate = DateTime.Now.AddDays(-22),
EndDate = DateTime.Now.AddDays(-7),
Cost = 7865000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-110),
UpdatedAt
 = DateTime.Now.AddDays(-110)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 282,
PaymentId = 111,
ProductId = 10,
ServiceId = 1,
AmoutEmployee = 162,
StartDate = DateTime.Now.AddDays(-138),
EndDate = DateTime.Now.AddDays(-135),
Cost = 69984000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-111),
UpdatedAt
 = DateTime.Now.AddDays(-111)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 283,
PaymentId = 111,
ProductId = 24,
ServiceId = 1,
AmoutEmployee = 46,
StartDate = DateTime.Now.AddDays(-146),
EndDate = DateTime.Now.AddDays(-139),
Cost = 22149000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-111),
UpdatedAt
 = DateTime.Now.AddDays(-111)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 284,
PaymentId = 111,
ProductId = 12,
ServiceId = 1,
AmoutEmployee = 95,
StartDate = DateTime.Now.AddDays(-152),
EndDate = DateTime.Now.AddDays(-143),
Cost = 2992500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-111),
UpdatedAt
 = DateTime.Now.AddDays(-111)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 285,
PaymentId = 112,
ProductId = 8,
ServiceId = 3,
AmoutEmployee = 25,
StartDate = DateTime.Now.AddDays(-101),
EndDate = DateTime.Now.AddDays(-89),
Cost = 9625000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-112),
UpdatedAt
 = DateTime.Now.AddDays(-112)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 286,
PaymentId = 112,
ProductId = 7,
ServiceId = 2,
AmoutEmployee = 89,
StartDate = DateTime.Now.AddDays(-40),
EndDate = DateTime.Now.AddDays(-28),
Cost = 17088000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-112),
UpdatedAt
 = DateTime.Now.AddDays(-112)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 287,
PaymentId = 113,
ProductId = 22,
ServiceId = 3,
AmoutEmployee = 86,
StartDate = DateTime.Now.AddDays(-126),
EndDate = DateTime.Now.AddDays(-118),
Cost = 9460000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-113),
UpdatedAt
 = DateTime.Now.AddDays(-113)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 288,
PaymentId = 113,
ProductId = 15,
ServiceId = 3,
AmoutEmployee = 190,
StartDate = DateTime.Now.AddDays(-175),
EndDate = DateTime.Now.AddDays(-162),
Cost = 132715000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-113),
UpdatedAt
 = DateTime.Now.AddDays(-113)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 289,
PaymentId = 113,
ProductId = 4,
ServiceId = 3,
AmoutEmployee = 101,
StartDate = DateTime.Now.AddDays(-185),
EndDate = DateTime.Now.AddDays(-175),
Cost = 21109000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-113),
UpdatedAt
 = DateTime.Now.AddDays(-113)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 290,
PaymentId = 114,
ProductId = 6,
ServiceId = 2,
AmoutEmployee = 123,
StartDate = DateTime.Now.AddDays(-183),
EndDate = DateTime.Now.AddDays(-168),
Cost = 46494000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-114),
UpdatedAt
 = DateTime.Now.AddDays(-114)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 291,
PaymentId = 114,
ProductId = 11,
ServiceId = 1,
AmoutEmployee = 78,
StartDate = DateTime.Now.AddDays(-37),
EndDate = DateTime.Now.AddDays(-23),
Cost = 7371000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-114),
UpdatedAt
 = DateTime.Now.AddDays(-114)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 292,
PaymentId = 115,
ProductId = 10,
ServiceId = 2,
AmoutEmployee = 189,
StartDate = DateTime.Now.AddDays(-8),
EndDate = DateTime.Now.AddDays(-4),
Cost = 3402000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-115),
UpdatedAt
 = DateTime.Now.AddDays(-115)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 293,
PaymentId = 115,
ProductId = 13,
ServiceId = 2,
AmoutEmployee = 98,
StartDate = DateTime.Now.AddDays(-161),
EndDate = DateTime.Now.AddDays(-157),
Cost = 79380000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-115),
UpdatedAt
 = DateTime.Now.AddDays(-115)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 294,
PaymentId = 115,
ProductId = 2,
ServiceId = 2,
AmoutEmployee = 106,
StartDate = DateTime.Now.AddDays(-164),
EndDate = DateTime.Now.AddDays(-159),
Cost = 10176000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-115),
UpdatedAt
 = DateTime.Now.AddDays(-115)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 295,
PaymentId = 116,
ProductId = 12,
ServiceId = 3,
AmoutEmployee = 46,
StartDate = DateTime.Now.AddDays(-98),
EndDate = DateTime.Now.AddDays(-86),
Cost = 13915000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-116),
UpdatedAt
 = DateTime.Now.AddDays(-116)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 296,
PaymentId = 116,
ProductId = 4,
ServiceId = 1,
AmoutEmployee = 155,
StartDate = DateTime.Now.AddDays(-114),
EndDate = DateTime.Now.AddDays(-108),
Cost = 20925000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-116),
UpdatedAt
 = DateTime.Now.AddDays(-116)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 297,
PaymentId = 117,
ProductId = 23,
ServiceId = 3,
AmoutEmployee = 195,
StartDate = DateTime.Now.AddDays(-181),
EndDate = DateTime.Now.AddDays(-168),
Cost = 35392500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-117),
UpdatedAt
 = DateTime.Now.AddDays(-117)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 298,
PaymentId = 117,
ProductId = 11,
ServiceId = 1,
AmoutEmployee = 82,
StartDate = DateTime.Now.AddDays(-31),
EndDate = DateTime.Now.AddDays(-18),
Cost = 9594000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-117),
UpdatedAt
 = DateTime.Now.AddDays(-117)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 299,
PaymentId = 117,
ProductId = 29,
ServiceId = 1,
AmoutEmployee = 175,
StartDate = DateTime.Now.AddDays(-122),
EndDate = DateTime.Now.AddDays(-114),
Cost = 90562500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-117),
UpdatedAt
 = DateTime.Now.AddDays(-117)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 300,
PaymentId = 118,
ProductId = 14,
ServiceId = 2,
AmoutEmployee = 62,
StartDate = DateTime.Now.AddDays(-11),
EndDate = DateTime.Now.AddDays(-10),
Cost = 2232000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-118),
UpdatedAt
 = DateTime.Now.AddDays(-118)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 301,
PaymentId = 118,
ProductId = 25,
ServiceId = 1,
AmoutEmployee = 161,
StartDate = DateTime.Now.AddDays(-35),
EndDate = DateTime.Now.AddDays(-26),
Cost = 18837000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-118),
UpdatedAt
 = DateTime.Now.AddDays(-118)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 302,
PaymentId = 119,
ProductId = 4,
ServiceId = 1,
AmoutEmployee = 145,
StartDate = DateTime.Now.AddDays(-171),
EndDate = DateTime.Now.AddDays(-167),
Cost = 44370000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-119),
UpdatedAt
 = DateTime.Now.AddDays(-119)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 303,
PaymentId = 119,
ProductId = 3,
ServiceId = 3,
AmoutEmployee = 103,
StartDate = DateTime.Now.AddDays(-198),
EndDate = DateTime.Now.AddDays(-189),
Cost = 104802500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-119),
UpdatedAt
 = DateTime.Now.AddDays(-119)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 304,
PaymentId = 119,
ProductId = 26,
ServiceId = 2,
AmoutEmployee = 118,
StartDate = DateTime.Now.AddDays(-198),
EndDate = DateTime.Now.AddDays(-187),
Cost = 124608000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-119),
UpdatedAt
 = DateTime.Now.AddDays(-119)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 305,
PaymentId = 120,
ProductId = 8,
ServiceId = 1,
AmoutEmployee = 79,
StartDate = DateTime.Now.AddDays(-17),
EndDate = DateTime.Now.AddDays(-5),
Cost = 1066500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-120),
UpdatedAt
 = DateTime.Now.AddDays(-120)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 306,
PaymentId = 120,
ProductId = 28,
ServiceId = 2,
AmoutEmployee = 34,
StartDate = DateTime.Now.AddDays(-95),
EndDate = DateTime.Now.AddDays(-85),
Cost = 204000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-120),
UpdatedAt
 = DateTime.Now.AddDays(-120)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 307,
PaymentId = 121,
ProductId = 29,
ServiceId = 3,
AmoutEmployee = 166,
StartDate = DateTime.Now.AddDays(-88),
EndDate = DateTime.Now.AddDays(-76),
Cost = 26477000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-121),
UpdatedAt
 = DateTime.Now.AddDays(-121)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 308,
PaymentId = 121,
ProductId = 2,
ServiceId = 2,
AmoutEmployee = 87,
StartDate = DateTime.Now.AddDays(-82),
EndDate = DateTime.Now.AddDays(-76),
Cost = 30798000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-121),
UpdatedAt
 = DateTime.Now.AddDays(-121)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 309,
PaymentId = 121,
ProductId = 11,
ServiceId = 3,
AmoutEmployee = 34,
StartDate = DateTime.Now.AddDays(-115),
EndDate = DateTime.Now.AddDays(-101),
Cost = 13277000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-121),
UpdatedAt
 = DateTime.Now.AddDays(-121)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 310,
PaymentId = 122,
ProductId = 1,
ServiceId = 1,
AmoutEmployee = 61,
StartDate = DateTime.Now.AddDays(-31),
EndDate = DateTime.Now.AddDays(-26),
Cost = 5215500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-122),
UpdatedAt
 = DateTime.Now.AddDays(-122)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 311,
PaymentId = 122,
ProductId = 2,
ServiceId = 1,
AmoutEmployee = 178,
StartDate = DateTime.Now.AddDays(-63),
EndDate = DateTime.Now.AddDays(-62),
Cost = 40851000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-122),
UpdatedAt
 = DateTime.Now.AddDays(-122)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 312,
PaymentId = 122,
ProductId = 19,
ServiceId = 2,
AmoutEmployee = 48,
StartDate = DateTime.Now.AddDays(-169),
EndDate = DateTime.Now.AddDays(-166),
Cost = 12384000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-122),
UpdatedAt
 = DateTime.Now.AddDays(-122)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 313,
PaymentId = 123,
ProductId = 18,
ServiceId = 1,
AmoutEmployee = 127,
StartDate = DateTime.Now.AddDays(-138),
EndDate = DateTime.Now.AddDays(-135),
Cost = 32575500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-123),
UpdatedAt
 = DateTime.Now.AddDays(-123)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 314,
PaymentId = 123,
ProductId = 10,
ServiceId = 2,
AmoutEmployee = 146,
StartDate = DateTime.Now.AddDays(-16),
EndDate = DateTime.Now.AddDays(-5),
Cost = 2628000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-123),
UpdatedAt
 = DateTime.Now.AddDays(-123)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 315,
PaymentId = 124,
ProductId = 22,
ServiceId = 1,
AmoutEmployee = 115,
StartDate = DateTime.Now.AddDays(-136),
EndDate = DateTime.Now.AddDays(-134),
Cost = 37777500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-124),
UpdatedAt
 = DateTime.Now.AddDays(-124)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 316,
PaymentId = 124,
ProductId = 13,
ServiceId = 2,
AmoutEmployee = 45,
StartDate = DateTime.Now.AddDays(-68),
EndDate = DateTime.Now.AddDays(-67),
Cost = 2430000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-124),
UpdatedAt
 = DateTime.Now.AddDays(-124)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 317,
PaymentId = 124,
ProductId = 15,
ServiceId = 2,
AmoutEmployee = 107,
StartDate = DateTime.Now.AddDays(-15),
EndDate = DateTime.Now.AddDays(-1),
Cost = 4494000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-124),
UpdatedAt
 = DateTime.Now.AddDays(-124)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 318,
PaymentId = 125,
ProductId = 5,
ServiceId = 2,
AmoutEmployee = 46,
StartDate = DateTime.Now.AddDays(-95),
EndDate = DateTime.Now.AddDays(-87),
Cost = 18492000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-125),
UpdatedAt
 = DateTime.Now.AddDays(-125)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 319,
PaymentId = 125,
ProductId = 7,
ServiceId = 1,
AmoutEmployee = 85,
StartDate = DateTime.Now.AddDays(-127),
EndDate = DateTime.Now.AddDays(-123),
Cost = 7267500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-125),
UpdatedAt
 = DateTime.Now.AddDays(-125)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 320,
PaymentId = 126,
ProductId = 27,
ServiceId = 1,
AmoutEmployee = 196,
StartDate = DateTime.Now.AddDays(-76),
EndDate = DateTime.Now.AddDays(-62),
Cost = 26460000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-126),
UpdatedAt
 = DateTime.Now.AddDays(-126)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 321,
PaymentId = 126,
ProductId = 25,
ServiceId = 2,
AmoutEmployee = 106,
StartDate = DateTime.Now.AddDays(-93),
EndDate = DateTime.Now.AddDays(-78),
Cost = 5724000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-126),
UpdatedAt
 = DateTime.Now.AddDays(-126)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 322,
PaymentId = 126,
ProductId = 7,
ServiceId = 2,
AmoutEmployee = 193,
StartDate = DateTime.Now.AddDays(-98),
EndDate = DateTime.Now.AddDays(-88),
Cost = 39372000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-126),
UpdatedAt
 = DateTime.Now.AddDays(-126)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 323,
PaymentId = 127,
ProductId = 11,
ServiceId = 1,
AmoutEmployee = 48,
StartDate = DateTime.Now.AddDays(-118),
EndDate = DateTime.Now.AddDays(-114),
Cost = 14904000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-127),
UpdatedAt
 = DateTime.Now.AddDays(-127)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 324,
PaymentId = 127,
ProductId = 25,
ServiceId = 3,
AmoutEmployee = 196,
StartDate = DateTime.Now.AddDays(-111),
EndDate = DateTime.Now.AddDays(-110),
Cost = 20482000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-127),
UpdatedAt
 = DateTime.Now.AddDays(-127)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 325,
PaymentId = 128,
ProductId = 8,
ServiceId = 3,
AmoutEmployee = 131,
StartDate = DateTime.Now.AddDays(-172),
EndDate = DateTime.Now.AddDays(-169),
Cost = 15851000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-128),
UpdatedAt
 = DateTime.Now.AddDays(-128)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 326,
PaymentId = 128,
ProductId = 23,
ServiceId = 3,
AmoutEmployee = 158,
StartDate = DateTime.Now.AddDays(-179),
EndDate = DateTime.Now.AddDays(-171),
Cost = 114708000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-128),
UpdatedAt
 = DateTime.Now.AddDays(-128)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 327,
PaymentId = 128,
ProductId = 18,
ServiceId = 2,
AmoutEmployee = 163,
StartDate = DateTime.Now.AddDays(-173),
EndDate = DateTime.Now.AddDays(-162),
Cost = 88020000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-128),
UpdatedAt
 = DateTime.Now.AddDays(-128)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 328,
PaymentId = 129,
ProductId = 23,
ServiceId = 2,
AmoutEmployee = 131,
StartDate = DateTime.Now.AddDays(-200),
EndDate = DateTime.Now.AddDays(-188),
Cost = 101394000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-129),
UpdatedAt
 = DateTime.Now.AddDays(-129)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 329,
PaymentId = 129,
ProductId = 17,
ServiceId = 3,
AmoutEmployee = 87,
StartDate = DateTime.Now.AddDays(-105),
EndDate = DateTime.Now.AddDays(-90),
Cost = 36366000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-129),
UpdatedAt
 = DateTime.Now.AddDays(-129)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 330,
PaymentId = 130,
ProductId = 11,
ServiceId = 2,
AmoutEmployee = 96,
StartDate = DateTime.Now.AddDays(-104),
EndDate = DateTime.Now.AddDays(-91),
Cost = 17856000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-130),
UpdatedAt
 = DateTime.Now.AddDays(-130)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 331,
PaymentId = 130,
ProductId = 28,
ServiceId = 2,
AmoutEmployee = 96,
StartDate = DateTime.Now.AddDays(-134),
EndDate = DateTime.Now.AddDays(-122),
Cost = 19584000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-130),
UpdatedAt
 = DateTime.Now.AddDays(-130)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 332,
PaymentId = 130,
ProductId = 23,
ServiceId = 3,
AmoutEmployee = 188,
StartDate = DateTime.Now.AddDays(-42),
EndDate = DateTime.Now.AddDays(-31),
Cost = 8272000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-130),
UpdatedAt
 = DateTime.Now.AddDays(-130)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 333,
PaymentId = 131,
ProductId = 15,
ServiceId = 3,
AmoutEmployee = 164,
StartDate = DateTime.Now.AddDays(-25),
EndDate = DateTime.Now.AddDays(-15),
Cost = 14432000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-131),
UpdatedAt
 = DateTime.Now.AddDays(-131)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 334,
PaymentId = 131,
ProductId = 13,
ServiceId = 2,
AmoutEmployee = 161,
StartDate = DateTime.Now.AddDays(-121),
EndDate = DateTime.Now.AddDays(-117),
Cost = 5796000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-131),
UpdatedAt
 = DateTime.Now.AddDays(-131)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 335,
PaymentId = 132,
ProductId = 13,
ServiceId = 2,
AmoutEmployee = 33,
StartDate = DateTime.Now.AddDays(-182),
EndDate = DateTime.Now.AddDays(-172),
Cost = 23364000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-132),
UpdatedAt
 = DateTime.Now.AddDays(-132)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 336,
PaymentId = 132,
ProductId = 24,
ServiceId = 2,
AmoutEmployee = 75,
StartDate = DateTime.Now.AddDays(-37),
EndDate = DateTime.Now.AddDays(-27),
Cost = 1350000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-132),
UpdatedAt
 = DateTime.Now.AddDays(-132)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 337,
PaymentId = 132,
ProductId = 10,
ServiceId = 1,
AmoutEmployee = 120,
StartDate = DateTime.Now.AddDays(-33),
EndDate = DateTime.Now.AddDays(-24),
Cost = 13500000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-132),
UpdatedAt
 = DateTime.Now.AddDays(-132)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 338,
PaymentId = 133,
ProductId = 13,
ServiceId = 1,
AmoutEmployee = 190,
StartDate = DateTime.Now.AddDays(-140),
EndDate = DateTime.Now.AddDays(-129),
Cost = 16245000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-133),
UpdatedAt
 = DateTime.Now.AddDays(-133)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 339,
PaymentId = 133,
ProductId = 27,
ServiceId = 3,
AmoutEmployee = 119,
StartDate = DateTime.Now.AddDays(-13),
EndDate = DateTime.Now.AddDays(1),
Cost = 1963500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-133),
UpdatedAt
 = DateTime.Now.AddDays(-133)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 340,
PaymentId = 133,
ProductId = 25,
ServiceId = 2,
AmoutEmployee = 199,
StartDate = DateTime.Now.AddDays(-20),
EndDate = DateTime.Now.AddDays(-12),
Cost = 13134000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-133),
UpdatedAt
 = DateTime.Now.AddDays(-133)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 341,
PaymentId = 134,
ProductId = 22,
ServiceId = 1,
AmoutEmployee = 182,
StartDate = DateTime.Now.AddDays(-10),
EndDate = DateTime.Now.AddDays(3),
Cost = 2457000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-134),
UpdatedAt
 = DateTime.Now.AddDays(-134)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 342,
PaymentId = 134,
ProductId = 25,
ServiceId = 2,
AmoutEmployee = 147,
StartDate = DateTime.Now.AddDays(-154),
EndDate = DateTime.Now.AddDays(-147),
Cost = 116424000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-134),
UpdatedAt
 = DateTime.Now.AddDays(-134)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 343,
PaymentId = 135,
ProductId = 19,
ServiceId = 1,
AmoutEmployee = 101,
StartDate = DateTime.Now.AddDays(-98),
EndDate = DateTime.Now.AddDays(-88),
Cost = 39087000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-135),
UpdatedAt
 = DateTime.Now.AddDays(-135)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 344,
PaymentId = 135,
ProductId = 22,
ServiceId = 2,
AmoutEmployee = 56,
StartDate = DateTime.Now.AddDays(-137),
EndDate = DateTime.Now.AddDays(-122),
Cost = 6384000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-135),
UpdatedAt
 = DateTime.Now.AddDays(-135)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 345,
PaymentId = 135,
ProductId = 10,
ServiceId = 2,
AmoutEmployee = 194,
StartDate = DateTime.Now.AddDays(-77),
EndDate = DateTime.Now.AddDays(-66),
Cost = 33756000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-135),
UpdatedAt
 = DateTime.Now.AddDays(-135)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 346,
PaymentId = 136,
ProductId = 17,
ServiceId = 2,
AmoutEmployee = 49,
StartDate = DateTime.Now.AddDays(-68),
EndDate = DateTime.Now.AddDays(-61),
Cost = 3822000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-136),
UpdatedAt
 = DateTime.Now.AddDays(-136)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 347,
PaymentId = 136,
ProductId = 21,
ServiceId = 1,
AmoutEmployee = 42,
StartDate = DateTime.Now.AddDays(-72),
EndDate = DateTime.Now.AddDays(-59),
Cost = 7560000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-136),
UpdatedAt
 = DateTime.Now.AddDays(-136)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 348,
PaymentId = 137,
ProductId = 6,
ServiceId = 2,
AmoutEmployee = 128,
StartDate = DateTime.Now.AddDays(-8),
EndDate = DateTime.Now.AddDays(1),
Cost = 1536000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-137),
UpdatedAt
 = DateTime.Now.AddDays(-137)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 349,
PaymentId = 137,
ProductId = 26,
ServiceId = 3,
AmoutEmployee = 163,
StartDate = DateTime.Now.AddDays(-130),
EndDate = DateTime.Now.AddDays(-128),
Cost = 93236000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-137),
UpdatedAt
 = DateTime.Now.AddDays(-137)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 350,
PaymentId = 137,
ProductId = 19,
ServiceId = 1,
AmoutEmployee = 26,
StartDate = DateTime.Now.AddDays(-48),
EndDate = DateTime.Now.AddDays(-41),
Cost = 5031000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-137),
UpdatedAt
 = DateTime.Now.AddDays(-137)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 351,
PaymentId = 138,
ProductId = 18,
ServiceId = 2,
AmoutEmployee = 115,
StartDate = DateTime.Now.AddDays(-156),
EndDate = DateTime.Now.AddDays(-142),
Cost = 84180000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-138),
UpdatedAt
 = DateTime.Now.AddDays(-138)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 352,
PaymentId = 138,
ProductId = 3,
ServiceId = 3,
AmoutEmployee = 35,
StartDate = DateTime.Now.AddDays(-111),
EndDate = DateTime.Now.AddDays(-104),
Cost = 18287500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-138),
UpdatedAt
 = DateTime.Now.AddDays(-138)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 353,
PaymentId = 139,
ProductId = 25,
ServiceId = 2,
AmoutEmployee = 99,
StartDate = DateTime.Now.AddDays(-44),
EndDate = DateTime.Now.AddDays(-41),
Cost = 1782000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-139),
UpdatedAt
 = DateTime.Now.AddDays(-139)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 354,
PaymentId = 139,
ProductId = 5,
ServiceId = 3,
AmoutEmployee = 63,
StartDate = DateTime.Now.AddDays(-32),
EndDate = DateTime.Now.AddDays(-28),
Cost = 346500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-139),
UpdatedAt
 = DateTime.Now.AddDays(-139)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 355,
PaymentId = 139,
ProductId = 26,
ServiceId = 1,
AmoutEmployee = 51,
StartDate = DateTime.Now.AddDays(-159),
EndDate = DateTime.Now.AddDays(-146),
Cost = 13311000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-139),
UpdatedAt
 = DateTime.Now.AddDays(-139)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 356,
PaymentId = 140,
ProductId = 23,
ServiceId = 3,
AmoutEmployee = 89,
StartDate = DateTime.Now.AddDays(-107),
EndDate = DateTime.Now.AddDays(-105),
Cost = 39160000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-140),
UpdatedAt
 = DateTime.Now.AddDays(-140)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 357,
PaymentId = 140,
ProductId = 12,
ServiceId = 1,
AmoutEmployee = 190,
StartDate = DateTime.Now.AddDays(-31),
EndDate = DateTime.Now.AddDays(-30),
Cost = 11115000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-140),
UpdatedAt
 = DateTime.Now.AddDays(-140)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 358,
PaymentId = 141,
ProductId = 6,
ServiceId = 1,
AmoutEmployee = 50,
StartDate = DateTime.Now.AddDays(-188),
EndDate = DateTime.Now.AddDays(-176),
Cost = 900000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-141),
UpdatedAt
 = DateTime.Now.AddDays(-141)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 359,
PaymentId = 141,
ProductId = 21,
ServiceId = 3,
AmoutEmployee = 196,
StartDate = DateTime.Now.AddDays(-125),
EndDate = DateTime.Now.AddDays(-115),
Cost = 20482000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-141),
UpdatedAt
 = DateTime.Now.AddDays(-141)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 360,
PaymentId = 141,
ProductId = 24,
ServiceId = 2,
AmoutEmployee = 147,
StartDate = DateTime.Now.AddDays(-57),
EndDate = DateTime.Now.AddDays(-49),
Cost = 40572000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-141),
UpdatedAt
 = DateTime.Now.AddDays(-141)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 361,
PaymentId = 142,
ProductId = 9,
ServiceId = 1,
AmoutEmployee = 127,
StartDate = DateTime.Now.AddDays(-152),
EndDate = DateTime.Now.AddDays(-150),
Cost = 5143500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-142),
UpdatedAt
 = DateTime.Now.AddDays(-142)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 362,
PaymentId = 142,
ProductId = 30,
ServiceId = 3,
AmoutEmployee = 102,
StartDate = DateTime.Now.AddDays(-96),
EndDate = DateTime.Now.AddDays(-88),
Cost = 46002000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-142),
UpdatedAt
 = DateTime.Now.AddDays(-142)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 363,
PaymentId = 143,
ProductId = 9,
ServiceId = 1,
AmoutEmployee = 45,
StartDate = DateTime.Now.AddDays(-181),
EndDate = DateTime.Now.AddDays(-174),
Cost = 24907500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-143),
UpdatedAt
 = DateTime.Now.AddDays(-143)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 364,
PaymentId = 143,
ProductId = 26,
ServiceId = 3,
AmoutEmployee = 60,
StartDate = DateTime.Now.AddDays(-112),
EndDate = DateTime.Now.AddDays(-97),
Cost = 23100000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-143),
UpdatedAt
 = DateTime.Now.AddDays(-143)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 365,
PaymentId = 143,
ProductId = 25,
ServiceId = 3,
AmoutEmployee = 29,
StartDate = DateTime.Now.AddDays(-88),
EndDate = DateTime.Now.AddDays(-78),
Cost = 4466000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-143),
UpdatedAt
 = DateTime.Now.AddDays(-143)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 366,
PaymentId = 144,
ProductId = 16,
ServiceId = 3,
AmoutEmployee = 179,
StartDate = DateTime.Now.AddDays(-74),
EndDate = DateTime.Now.AddDays(-60),
Cost = 20674500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-144),
UpdatedAt
 = DateTime.Now.AddDays(-144)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 367,
PaymentId = 144,
ProductId = 26,
ServiceId = 3,
AmoutEmployee = 137,
StartDate = DateTime.Now.AddDays(-71),
EndDate = DateTime.Now.AddDays(-65),
Cost = 18084000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-144),
UpdatedAt
 = DateTime.Now.AddDays(-144)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 368,
PaymentId = 144,
ProductId = 16,
ServiceId = 1,
AmoutEmployee = 62,
StartDate = DateTime.Now.AddDays(-103),
EndDate = DateTime.Now.AddDays(-90),
Cost = 4185000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-144),
UpdatedAt
 = DateTime.Now.AddDays(-144)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 369,
PaymentId = 145,
ProductId = 16,
ServiceId = 3,
AmoutEmployee = 183,
StartDate = DateTime.Now.AddDays(-15),
EndDate = DateTime.Now.AddDays(-1),
Cost = 6039000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-145),
UpdatedAt
 = DateTime.Now.AddDays(-145)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 370,
PaymentId = 145,
ProductId = 1,
ServiceId = 3,
AmoutEmployee = 53,
StartDate = DateTime.Now.AddDays(-31),
EndDate = DateTime.Now.AddDays(-29),
Cost = 4664000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-145),
UpdatedAt
 = DateTime.Now.AddDays(-145)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 371,
PaymentId = 146,
ProductId = 3,
ServiceId = 3,
AmoutEmployee = 29,
StartDate = DateTime.Now.AddDays(-77),
EndDate = DateTime.Now.AddDays(-76),
Cost = 7177500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-146),
UpdatedAt
 = DateTime.Now.AddDays(-146)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 372,
PaymentId = 146,
ProductId = 29,
ServiceId = 2,
AmoutEmployee = 83,
StartDate = DateTime.Now.AddDays(-116),
EndDate = DateTime.Now.AddDays(-113),
Cost = 19920000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-146),
UpdatedAt
 = DateTime.Now.AddDays(-146)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 373,
PaymentId = 146,
ProductId = 18,
ServiceId = 2,
AmoutEmployee = 106,
StartDate = DateTime.Now.AddDays(-132),
EndDate = DateTime.Now.AddDays(-128),
Cost = 10176000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-146),
UpdatedAt
 = DateTime.Now.AddDays(-146)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 374,
PaymentId = 147,
ProductId = 11,
ServiceId = 1,
AmoutEmployee = 190,
StartDate = DateTime.Now.AddDays(-107),
EndDate = DateTime.Now.AddDays(-99),
Cost = 87210000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-147),
UpdatedAt
 = DateTime.Now.AddDays(-147)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 375,
PaymentId = 147,
ProductId = 24,
ServiceId = 2,
AmoutEmployee = 196,
StartDate = DateTime.Now.AddDays(-52),
EndDate = DateTime.Now.AddDays(-42),
Cost = 16464000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-147),
UpdatedAt
 = DateTime.Now.AddDays(-147)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 376,
PaymentId = 148,
ProductId = 1,
ServiceId = 3,
AmoutEmployee = 37,
StartDate = DateTime.Now.AddDays(-80),
EndDate = DateTime.Now.AddDays(-65),
Cost = 4273500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-148),
UpdatedAt
 = DateTime.Now.AddDays(-148)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 377,
PaymentId = 148,
ProductId = 28,
ServiceId = 2,
AmoutEmployee = 90,
StartDate = DateTime.Now.AddDays(-134),
EndDate = DateTime.Now.AddDays(-132),
Cost = 61560000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-148),
UpdatedAt
 = DateTime.Now.AddDays(-148)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 378,
PaymentId = 148,
ProductId = 6,
ServiceId = 3,
AmoutEmployee = 36,
StartDate = DateTime.Now.AddDays(-141),
EndDate = DateTime.Now.AddDays(-130),
Cost = 4752000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-148),
UpdatedAt
 = DateTime.Now.AddDays(-148)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 379,
PaymentId = 149,
ProductId = 11,
ServiceId = 2,
AmoutEmployee = 58,
StartDate = DateTime.Now.AddDays(-108),
EndDate = DateTime.Now.AddDays(-98),
Cost = 26100000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-149),
UpdatedAt
 = DateTime.Now.AddDays(-149)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 380,
PaymentId = 149,
ProductId = 5,
ServiceId = 2,
AmoutEmployee = 189,
StartDate = DateTime.Now.AddDays(-149),
EndDate = DateTime.Now.AddDays(-148),
Cost = 1134000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-149),
UpdatedAt
 = DateTime.Now.AddDays(-149)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 381,
PaymentId = 150,
ProductId = 17,
ServiceId = 3,
AmoutEmployee = 72,
StartDate = DateTime.Now.AddDays(-167),
EndDate = DateTime.Now.AddDays(-162),
Cost = 15048000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-150),
UpdatedAt
 = DateTime.Now.AddDays(-150)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 382,
PaymentId = 150,
ProductId = 21,
ServiceId = 2,
AmoutEmployee = 193,
StartDate = DateTime.Now.AddDays(-18),
EndDate = DateTime.Now.AddDays(-8),
Cost = 4632000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-150),
UpdatedAt
 = DateTime.Now.AddDays(-150)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 383,
PaymentId = 150,
ProductId = 13,
ServiceId = 3,
AmoutEmployee = 150,
StartDate = DateTime.Now.AddDays(-159),
EndDate = DateTime.Now.AddDays(-152),
Cost = 75900000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-150),
UpdatedAt
 = DateTime.Now.AddDays(-150)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 384,
PaymentId = 151,
ProductId = 23,
ServiceId = 1,
AmoutEmployee = 129,
StartDate = DateTime.Now.AddDays(-197),
EndDate = DateTime.Now.AddDays(-192),
Cost = 64435500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-151),
UpdatedAt
 = DateTime.Now.AddDays(-151)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 385,
PaymentId = 151,
ProductId = 17,
ServiceId = 2,
AmoutEmployee = 172,
StartDate = DateTime.Now.AddDays(-14),
EndDate = DateTime.Now.AddDays(-6),
Cost = 2064000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-151),
UpdatedAt
 = DateTime.Now.AddDays(-151)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 386,
PaymentId = 152,
ProductId = 28,
ServiceId = 3,
AmoutEmployee = 43,
StartDate = DateTime.Now.AddDays(-120),
EndDate = DateTime.Now.AddDays(-119),
Cost = 25305500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-152),
UpdatedAt
 = DateTime.Now.AddDays(-152)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 387,
PaymentId = 152,
ProductId = 9,
ServiceId = 3,
AmoutEmployee = 107,
StartDate = DateTime.Now.AddDays(-18),
EndDate = DateTime.Now.AddDays(-7),
Cost = 1177000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-152),
UpdatedAt
 = DateTime.Now.AddDays(-152)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 388,
PaymentId = 152,
ProductId = 10,
ServiceId = 2,
AmoutEmployee = 128,
StartDate = DateTime.Now.AddDays(-89),
EndDate = DateTime.Now.AddDays(-86),
Cost = 55296000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-152),
UpdatedAt
 = DateTime.Now.AddDays(-152)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 389,
PaymentId = 153,
ProductId = 30,
ServiceId = 2,
AmoutEmployee = 140,
StartDate = DateTime.Now.AddDays(-64),
EndDate = DateTime.Now.AddDays(-49),
Cost = 13440000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-153),
UpdatedAt
 = DateTime.Now.AddDays(-153)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 390,
PaymentId = 153,
ProductId = 26,
ServiceId = 1,
AmoutEmployee = 193,
StartDate = DateTime.Now.AddDays(-17),
EndDate = DateTime.Now.AddDays(-4),
Cost = 5211000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-153),
UpdatedAt
 = DateTime.Now.AddDays(-153)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 391,
PaymentId = 154,
ProductId = 28,
ServiceId = 1,
AmoutEmployee = 90,
StartDate = DateTime.Now.AddDays(-69),
EndDate = DateTime.Now.AddDays(-61),
Cost = 19035000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-154),
UpdatedAt
 = DateTime.Now.AddDays(-154)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 392,
PaymentId = 154,
ProductId = 25,
ServiceId = 2,
AmoutEmployee = 36,
StartDate = DateTime.Now.AddDays(-127),
EndDate = DateTime.Now.AddDays(-117),
Cost = 11016000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-154),
UpdatedAt
 = DateTime.Now.AddDays(-154)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 393,
PaymentId = 154,
ProductId = 2,
ServiceId = 1,
AmoutEmployee = 43,
StartDate = DateTime.Now.AddDays(-149),
EndDate = DateTime.Now.AddDays(-142),
Cost = 12964500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-154),
UpdatedAt
 = DateTime.Now.AddDays(-154)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 394,
PaymentId = 155,
ProductId = 27,
ServiceId = 2,
AmoutEmployee = 63,
StartDate = DateTime.Now.AddDays(-97),
EndDate = DateTime.Now.AddDays(-89),
Cost = 11340000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-155),
UpdatedAt
 = DateTime.Now.AddDays(-155)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 395,
PaymentId = 155,
ProductId = 17,
ServiceId = 2,
AmoutEmployee = 126,
StartDate = DateTime.Now.AddDays(-51),
EndDate = DateTime.Now.AddDays(-43),
Cost = 30996000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-155),
UpdatedAt
 = DateTime.Now.AddDays(-155)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 396,
PaymentId = 155,
ProductId = 19,
ServiceId = 1,
AmoutEmployee = 92,
StartDate = DateTime.Now.AddDays(-150),
EndDate = DateTime.Now.AddDays(-143),
Cost = 17802000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-155),
UpdatedAt
 = DateTime.Now.AddDays(-155)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 397,
PaymentId = 156,
ProductId = 17,
ServiceId = 1,
AmoutEmployee = 64,
StartDate = DateTime.Now.AddDays(-89),
EndDate = DateTime.Now.AddDays(-88),
Cost = 9504000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-156),
UpdatedAt
 = DateTime.Now.AddDays(-156)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 398,
PaymentId = 156,
ProductId = 24,
ServiceId = 3,
AmoutEmployee = 32,
StartDate = DateTime.Now.AddDays(-122),
EndDate = DateTime.Now.AddDays(-108),
Cost = 15664000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-156),
UpdatedAt
 = DateTime.Now.AddDays(-156)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 399,
PaymentId = 157,
ProductId = 20,
ServiceId = 3,
AmoutEmployee = 169,
StartDate = DateTime.Now.AddDays(-117),
EndDate = DateTime.Now.AddDays(-105),
Cost = 73430500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-157),
UpdatedAt
 = DateTime.Now.AddDays(-157)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 400,
PaymentId = 157,
ProductId = 20,
ServiceId = 1,
AmoutEmployee = 175,
StartDate = DateTime.Now.AddDays(-52),
EndDate = DateTime.Now.AddDays(-47),
Cost = 12600000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-157),
UpdatedAt
 = DateTime.Now.AddDays(-157)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 401,
PaymentId = 157,
ProductId = 14,
ServiceId = 3,
AmoutEmployee = 58,
StartDate = DateTime.Now.AddDays(-52),
EndDate = DateTime.Now.AddDays(-46),
Cost = 12122000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-157),
UpdatedAt
 = DateTime.Now.AddDays(-157)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 402,
PaymentId = 158,
ProductId = 5,
ServiceId = 2,
AmoutEmployee = 188,
StartDate = DateTime.Now.AddDays(-106),
EndDate = DateTime.Now.AddDays(-94),
Cost = 107160000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-158),
UpdatedAt
 = DateTime.Now.AddDays(-158)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 403,
PaymentId = 158,
ProductId = 11,
ServiceId = 3,
AmoutEmployee = 65,
StartDate = DateTime.Now.AddDays(-79),
EndDate = DateTime.Now.AddDays(-67),
Cost = 17517500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-158),
UpdatedAt
 = DateTime.Now.AddDays(-158)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 404,
PaymentId = 159,
ProductId = 16,
ServiceId = 3,
AmoutEmployee = 147,
StartDate = DateTime.Now.AddDays(-107),
EndDate = DateTime.Now.AddDays(-100),
Cost = 12936000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-159),
UpdatedAt
 = DateTime.Now.AddDays(-159)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 405,
PaymentId = 159,
ProductId = 18,
ServiceId = 2,
AmoutEmployee = 152,
StartDate = DateTime.Now.AddDays(-34),
EndDate = DateTime.Now.AddDays(-30),
Cost = 18240000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-159),
UpdatedAt
 = DateTime.Now.AddDays(-159)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 406,
PaymentId = 159,
ProductId = 20,
ServiceId = 3,
AmoutEmployee = 31,
StartDate = DateTime.Now.AddDays(-81),
EndDate = DateTime.Now.AddDays(-72),
Cost = 5456000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-159),
UpdatedAt
 = DateTime.Now.AddDays(-159)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 407,
PaymentId = 160,
ProductId = 8,
ServiceId = 3,
AmoutEmployee = 55,
StartDate = DateTime.Now.AddDays(-128),
EndDate = DateTime.Now.AddDays(-116),
Cost = 14822500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-160),
UpdatedAt
 = DateTime.Now.AddDays(-160)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 408,
PaymentId = 160,
ProductId = 30,
ServiceId = 1,
AmoutEmployee = 49,
StartDate = DateTime.Now.AddDays(-110),
EndDate = DateTime.Now.AddDays(-107),
Cost = 3087000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-160),
UpdatedAt
 = DateTime.Now.AddDays(-160)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 409,
PaymentId = 161,
ProductId = 2,
ServiceId = 3,
AmoutEmployee = 103,
StartDate = DateTime.Now.AddDays(-147),
EndDate = DateTime.Now.AddDays(-145),
Cost = 25492500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-161),
UpdatedAt
 = DateTime.Now.AddDays(-161)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 410,
PaymentId = 161,
ProductId = 17,
ServiceId = 2,
AmoutEmployee = 77,
StartDate = DateTime.Now.AddDays(-10),
EndDate = DateTime.Now.AddDays(5),
Cost = 462000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-161),
UpdatedAt
 = DateTime.Now.AddDays(-161)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 411,
PaymentId = 161,
ProductId = 26,
ServiceId = 3,
AmoutEmployee = 196,
StartDate = DateTime.Now.AddDays(-191),
EndDate = DateTime.Now.AddDays(-178),
Cost = 173558000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-161),
UpdatedAt
 = DateTime.Now.AddDays(-161)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 412,
PaymentId = 162,
ProductId = 18,
ServiceId = 2,
AmoutEmployee = 173,
StartDate = DateTime.Now.AddDays(-52),
EndDate = DateTime.Now.AddDays(-41),
Cost = 43596000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-162),
UpdatedAt
 = DateTime.Now.AddDays(-162)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 413,
PaymentId = 162,
ProductId = 5,
ServiceId = 2,
AmoutEmployee = 155,
StartDate = DateTime.Now.AddDays(-134),
EndDate = DateTime.Now.AddDays(-119),
Cost = 930000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-162),
UpdatedAt
 = DateTime.Now.AddDays(-162)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 414,
PaymentId = 163,
ProductId = 22,
ServiceId = 2,
AmoutEmployee = 54,
StartDate = DateTime.Now.AddDays(-182),
EndDate = DateTime.Now.AddDays(-171),
Cost = 36288000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-163),
UpdatedAt
 = DateTime.Now.AddDays(-163)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 415,
PaymentId = 163,
ProductId = 26,
ServiceId = 3,
AmoutEmployee = 144,
StartDate = DateTime.Now.AddDays(-156),
EndDate = DateTime.Now.AddDays(-150),
Cost = 21384000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-163),
UpdatedAt
 = DateTime.Now.AddDays(-163)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 416,
PaymentId = 163,
ProductId = 17,
ServiceId = 2,
AmoutEmployee = 47,
StartDate = DateTime.Now.AddDays(-82),
EndDate = DateTime.Now.AddDays(-71),
Cost = 3948000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-163),
UpdatedAt
 = DateTime.Now.AddDays(-163)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 417,
PaymentId = 164,
ProductId = 15,
ServiceId = 1,
AmoutEmployee = 93,
StartDate = DateTime.Now.AddDays(-100),
EndDate = DateTime.Now.AddDays(-94),
Cost = 38083500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-164),
UpdatedAt
 = DateTime.Now.AddDays(-164)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 418,
PaymentId = 164,
ProductId = 29,
ServiceId = 1,
AmoutEmployee = 179,
StartDate = DateTime.Now.AddDays(-154),
EndDate = DateTime.Now.AddDays(-139),
Cost = 53968500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-164),
UpdatedAt
 = DateTime.Now.AddDays(-164)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 419,
PaymentId = 165,
ProductId = 8,
ServiceId = 1,
AmoutEmployee = 31,
StartDate = DateTime.Now.AddDays(-158),
EndDate = DateTime.Now.AddDays(-148),
Cost = 15484500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-165),
UpdatedAt
 = DateTime.Now.AddDays(-165)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 420,
PaymentId = 165,
ProductId = 11,
ServiceId = 2,
AmoutEmployee = 47,
StartDate = DateTime.Now.AddDays(-84),
EndDate = DateTime.Now.AddDays(-77),
Cost = 15792000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-165),
UpdatedAt
 = DateTime.Now.AddDays(-165)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 421,
PaymentId = 165,
ProductId = 24,
ServiceId = 2,
AmoutEmployee = 146,
StartDate = DateTime.Now.AddDays(-10),
EndDate = DateTime.Now.AddDays(-3),
Cost = 1752000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-165),
UpdatedAt
 = DateTime.Now.AddDays(-165)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 422,
PaymentId = 166,
ProductId = 22,
ServiceId = 1,
AmoutEmployee = 30,
StartDate = DateTime.Now.AddDays(-146),
EndDate = DateTime.Now.AddDays(-141),
Cost = 14580000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-166),
UpdatedAt
 = DateTime.Now.AddDays(-166)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 423,
PaymentId = 166,
ProductId = 26,
ServiceId = 1,
AmoutEmployee = 85,
StartDate = DateTime.Now.AddDays(-148),
EndDate = DateTime.Now.AddDays(-143),
Cost = 48577500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-166),
UpdatedAt
 = DateTime.Now.AddDays(-166)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 424,
PaymentId = 166,
ProductId = 29,
ServiceId = 3,
AmoutEmployee = 175,
StartDate = DateTime.Now.AddDays(-168),
EndDate = DateTime.Now.AddDays(-164),
Cost = 123200000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-166),
UpdatedAt
 = DateTime.Now.AddDays(-166)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 425,
PaymentId = 167,
ProductId = 11,
ServiceId = 2,
AmoutEmployee = 91,
StartDate = DateTime.Now.AddDays(-38),
EndDate = DateTime.Now.AddDays(-36),
Cost = 6006000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-167),
UpdatedAt
 = DateTime.Now.AddDays(-167)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 426,
PaymentId = 167,
ProductId = 30,
ServiceId = 2,
AmoutEmployee = 140,
StartDate = DateTime.Now.AddDays(-162),
EndDate = DateTime.Now.AddDays(-161),
Cost = 34440000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-167),
UpdatedAt
 = DateTime.Now.AddDays(-167)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 427,
PaymentId = 168,
ProductId = 10,
ServiceId = 3,
AmoutEmployee = 120,
StartDate = DateTime.Now.AddDays(-182),
EndDate = DateTime.Now.AddDays(-168),
Cost = 4620000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-168),
UpdatedAt
 = DateTime.Now.AddDays(-168)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 428,
PaymentId = 168,
ProductId = 21,
ServiceId = 3,
AmoutEmployee = 29,
StartDate = DateTime.Now.AddDays(-186),
EndDate = DateTime.Now.AddDays(-179),
Cost = 2552000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-168),
UpdatedAt
 = DateTime.Now.AddDays(-168)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 429,
PaymentId = 168,
ProductId = 28,
ServiceId = 1,
AmoutEmployee = 40,
StartDate = DateTime.Now.AddDays(-178),
EndDate = DateTime.Now.AddDays(-175),
Cost = 25020000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-168),
UpdatedAt
 = DateTime.Now.AddDays(-168)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 430,
PaymentId = 169,
ProductId = 17,
ServiceId = 2,
AmoutEmployee = 119,
StartDate = DateTime.Now.AddDays(-64),
EndDate = DateTime.Now.AddDays(-59),
Cost = 13566000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-169),
UpdatedAt
 = DateTime.Now.AddDays(-169)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 431,
PaymentId = 169,
ProductId = 4,
ServiceId = 2,
AmoutEmployee = 108,
StartDate = DateTime.Now.AddDays(-157),
EndDate = DateTime.Now.AddDays(-151),
Cost = 56376000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-169),
UpdatedAt
 = DateTime.Now.AddDays(-169)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 432,
PaymentId = 170,
ProductId = 29,
ServiceId = 3,
AmoutEmployee = 27,
StartDate = DateTime.Now.AddDays(-77),
EndDate = DateTime.Now.AddDays(-75),
Cost = 2821500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-170),
UpdatedAt
 = DateTime.Now.AddDays(-170)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 433,
PaymentId = 170,
ProductId = 22,
ServiceId = 1,
AmoutEmployee = 141,
StartDate = DateTime.Now.AddDays(-146),
EndDate = DateTime.Now.AddDays(-133),
Cost = 55201500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-170),
UpdatedAt
 = DateTime.Now.AddDays(-170)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 434,
PaymentId = 170,
ProductId = 7,
ServiceId = 3,
AmoutEmployee = 44,
StartDate = DateTime.Now.AddDays(-15),
EndDate = DateTime.Now.AddDays(-7),
Cost = 726000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-170),
UpdatedAt
 = DateTime.Now.AddDays(-170)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 435,
PaymentId = 171,
ProductId = 21,
ServiceId = 3,
AmoutEmployee = 189,
StartDate = DateTime.Now.AddDays(-129),
EndDate = DateTime.Now.AddDays(-116),
Cost = 66528000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-171),
UpdatedAt
 = DateTime.Now.AddDays(-171)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 436,
PaymentId = 171,
ProductId = 2,
ServiceId = 1,
AmoutEmployee = 112,
StartDate = DateTime.Now.AddDays(-184),
EndDate = DateTime.Now.AddDays(-177),
Cost = 66024000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-171),
UpdatedAt
 = DateTime.Now.AddDays(-171)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 437,
PaymentId = 172,
ProductId = 23,
ServiceId = 2,
AmoutEmployee = 192,
StartDate = DateTime.Now.AddDays(-29),
EndDate = DateTime.Now.AddDays(-18),
Cost = 21888000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-172),
UpdatedAt
 = DateTime.Now.AddDays(-172)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 438,
PaymentId = 172,
ProductId = 12,
ServiceId = 3,
AmoutEmployee = 104,
StartDate = DateTime.Now.AddDays(-191),
EndDate = DateTime.Now.AddDays(-190),
Cost = 77220000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-172),
UpdatedAt
 = DateTime.Now.AddDays(-172)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 439,
PaymentId = 172,
ProductId = 30,
ServiceId = 3,
AmoutEmployee = 100,
StartDate = DateTime.Now.AddDays(-64),
EndDate = DateTime.Now.AddDays(-63),
Cost = 15950000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-172),
UpdatedAt
 = DateTime.Now.AddDays(-172)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 440,
PaymentId = 173,
ProductId = 26,
ServiceId = 3,
AmoutEmployee = 79,
StartDate = DateTime.Now.AddDays(-180),
EndDate = DateTime.Now.AddDays(-175),
Cost = 69085500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-173),
UpdatedAt
 = DateTime.Now.AddDays(-173)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 441,
PaymentId = 173,
ProductId = 3,
ServiceId = 3,
AmoutEmployee = 69,
StartDate = DateTime.Now.AddDays(-62),
EndDate = DateTime.Now.AddDays(-56),
Cost = 14800500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-173),
UpdatedAt
 = DateTime.Now.AddDays(-173)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 442,
PaymentId = 174,
ProductId = 16,
ServiceId = 2,
AmoutEmployee = 171,
StartDate = DateTime.Now.AddDays(-31),
EndDate = DateTime.Now.AddDays(-19),
Cost = 23598000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-174),
UpdatedAt
 = DateTime.Now.AddDays(-174)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 443,
PaymentId = 174,
ProductId = 11,
ServiceId = 2,
AmoutEmployee = 104,
StartDate = DateTime.Now.AddDays(-39),
EndDate = DateTime.Now.AddDays(-27),
Cost = 19968000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-174),
UpdatedAt
 = DateTime.Now.AddDays(-174)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 444,
PaymentId = 174,
ProductId = 11,
ServiceId = 2,
AmoutEmployee = 144,
StartDate = DateTime.Now.AddDays(-87),
EndDate = DateTime.Now.AddDays(-81),
Cost = 8640000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-174),
UpdatedAt
 = DateTime.Now.AddDays(-174)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 445,
PaymentId = 175,
ProductId = 5,
ServiceId = 2,
AmoutEmployee = 152,
StartDate = DateTime.Now.AddDays(-122),
EndDate = DateTime.Now.AddDays(-119),
Cost = 15504000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-175),
UpdatedAt
 = DateTime.Now.AddDays(-175)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 446,
PaymentId = 175,
ProductId = 14,
ServiceId = 2,
AmoutEmployee = 165,
StartDate = DateTime.Now.AddDays(-80),
EndDate = DateTime.Now.AddDays(-76),
Cost = 46530000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-175),
UpdatedAt
 = DateTime.Now.AddDays(-175)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 447,
PaymentId = 176,
ProductId = 26,
ServiceId = 2,
AmoutEmployee = 49,
StartDate = DateTime.Now.AddDays(-40),
EndDate = DateTime.Now.AddDays(-38),
Cost = 2940000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-176),
UpdatedAt
 = DateTime.Now.AddDays(-176)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 448,
PaymentId = 176,
ProductId = 9,
ServiceId = 3,
AmoutEmployee = 89,
StartDate = DateTime.Now.AddDays(-188),
EndDate = DateTime.Now.AddDays(-180),
Cost = 24964500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-176),
UpdatedAt
 = DateTime.Now.AddDays(-176)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 449,
PaymentId = 176,
ProductId = 5,
ServiceId = 2,
AmoutEmployee = 155,
StartDate = DateTime.Now.AddDays(-113),
EndDate = DateTime.Now.AddDays(-106),
Cost = 91140000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-176),
UpdatedAt
 = DateTime.Now.AddDays(-176)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 450,
PaymentId = 177,
ProductId = 4,
ServiceId = 1,
AmoutEmployee = 105,
StartDate = DateTime.Now.AddDays(-45),
EndDate = DateTime.Now.AddDays(-36),
Cost = 11812500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-177),
UpdatedAt
 = DateTime.Now.AddDays(-177)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 451,
PaymentId = 177,
ProductId = 20,
ServiceId = 2,
AmoutEmployee = 194,
StartDate = DateTime.Now.AddDays(-88),
EndDate = DateTime.Now.AddDays(-87),
Cost = 55872000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-177),
UpdatedAt
 = DateTime.Now.AddDays(-177)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 452,
PaymentId = 177,
ProductId = 26,
ServiceId = 3,
AmoutEmployee = 105,
StartDate = DateTime.Now.AddDays(-131),
EndDate = DateTime.Now.AddDays(-125),
Cost = 29452500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-177),
UpdatedAt
 = DateTime.Now.AddDays(-177)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 453,
PaymentId = 178,
ProductId = 1,
ServiceId = 3,
AmoutEmployee = 54,
StartDate = DateTime.Now.AddDays(-172),
EndDate = DateTime.Now.AddDays(-168),
Cost = 4752000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-178),
UpdatedAt
 = DateTime.Now.AddDays(-178)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 454,
PaymentId = 178,
ProductId = 5,
ServiceId = 1,
AmoutEmployee = 67,
StartDate = DateTime.Now.AddDays(-52),
EndDate = DateTime.Now.AddDays(-43),
Cost = 3618000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-178),
UpdatedAt
 = DateTime.Now.AddDays(-178)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 455,
PaymentId = 179,
ProductId = 8,
ServiceId = 3,
AmoutEmployee = 87,
StartDate = DateTime.Now.AddDays(-126),
EndDate = DateTime.Now.AddDays(-123),
Cost = 15312000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-179),
UpdatedAt
 = DateTime.Now.AddDays(-179)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 456,
PaymentId = 179,
ProductId = 27,
ServiceId = 3,
AmoutEmployee = 50,
StartDate = DateTime.Now.AddDays(-102),
EndDate = DateTime.Now.AddDays(-87),
Cost = 8250000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-179),
UpdatedAt
 = DateTime.Now.AddDays(-179)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 457,
PaymentId = 179,
ProductId = 10,
ServiceId = 3,
AmoutEmployee = 27,
StartDate = DateTime.Now.AddDays(-53),
EndDate = DateTime.Now.AddDays(-51),
Cost = 6385500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-179),
UpdatedAt
 = DateTime.Now.AddDays(-179)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 458,
PaymentId = 180,
ProductId = 16,
ServiceId = 2,
AmoutEmployee = 153,
StartDate = DateTime.Now.AddDays(-198),
EndDate = DateTime.Now.AddDays(-194),
Cost = 138618000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-180),
UpdatedAt
 = DateTime.Now.AddDays(-180)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 459,
PaymentId = 180,
ProductId = 19,
ServiceId = 3,
AmoutEmployee = 125,
StartDate = DateTime.Now.AddDays(-101),
EndDate = DateTime.Now.AddDays(-97),
Cost = 39187500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-180),
UpdatedAt
 = DateTime.Now.AddDays(-180)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 460,
PaymentId = 181,
ProductId = 28,
ServiceId = 1,
AmoutEmployee = 138,
StartDate = DateTime.Now.AddDays(-38),
EndDate = DateTime.Now.AddDays(-31),
Cost = 621000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-181),
UpdatedAt
 = DateTime.Now.AddDays(-181)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 461,
PaymentId = 181,
ProductId = 2,
ServiceId = 3,
AmoutEmployee = 39,
StartDate = DateTime.Now.AddDays(-187),
EndDate = DateTime.Now.AddDays(-177),
Cost = 35821500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-181),
UpdatedAt
 = DateTime.Now.AddDays(-181)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 462,
PaymentId = 181,
ProductId = 27,
ServiceId = 3,
AmoutEmployee = 54,
StartDate = DateTime.Now.AddDays(-67),
EndDate = DateTime.Now.AddDays(-65),
Cost = 5049000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-181),
UpdatedAt
 = DateTime.Now.AddDays(-181)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 463,
PaymentId = 182,
ProductId = 16,
ServiceId = 3,
AmoutEmployee = 121,
StartDate = DateTime.Now.AddDays(-178),
EndDate = DateTime.Now.AddDays(-172),
Cost = 61226000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-182),
UpdatedAt
 = DateTime.Now.AddDays(-182)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 464,
PaymentId = 182,
ProductId = 4,
ServiceId = 3,
AmoutEmployee = 92,
StartDate = DateTime.Now.AddDays(-30),
EndDate = DateTime.Now.AddDays(-29),
Cost = 2530000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-182),
UpdatedAt
 = DateTime.Now.AddDays(-182)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 465,
PaymentId = 183,
ProductId = 11,
ServiceId = 2,
AmoutEmployee = 102,
StartDate = DateTime.Now.AddDays(-11),
EndDate = DateTime.Now.AddDays(-8),
Cost = 3672000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-183),
UpdatedAt
 = DateTime.Now.AddDays(-183)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 466,
PaymentId = 183,
ProductId = 10,
ServiceId = 2,
AmoutEmployee = 197,
StartDate = DateTime.Now.AddDays(-145),
EndDate = DateTime.Now.AddDays(-133),
Cost = 140658000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-183),
UpdatedAt
 = DateTime.Now.AddDays(-183)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 467,
PaymentId = 183,
ProductId = 20,
ServiceId = 3,
AmoutEmployee = 148,
StartDate = DateTime.Now.AddDays(-48),
EndDate = DateTime.Now.AddDays(-37),
Cost = 13838000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-183),
UpdatedAt
 = DateTime.Now.AddDays(-183)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 468,
PaymentId = 184,
ProductId = 21,
ServiceId = 1,
AmoutEmployee = 165,
StartDate = DateTime.Now.AddDays(-107),
EndDate = DateTime.Now.AddDays(-93),
Cost = 23017500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-184),
UpdatedAt
 = DateTime.Now.AddDays(-184)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 469,
PaymentId = 184,
ProductId = 5,
ServiceId = 2,
AmoutEmployee = 169,
StartDate = DateTime.Now.AddDays(-13),
EndDate = DateTime.Now.AddDays(-1),
Cost = 3042000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-184),
UpdatedAt
 = DateTime.Now.AddDays(-184)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 470,
PaymentId = 185,
ProductId = 7,
ServiceId = 3,
AmoutEmployee = 51,
StartDate = DateTime.Now.AddDays(-164),
EndDate = DateTime.Now.AddDays(-162),
Cost = 3366000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-185),
UpdatedAt
 = DateTime.Now.AddDays(-185)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 471,
PaymentId = 185,
ProductId = 9,
ServiceId = 1,
AmoutEmployee = 193,
StartDate = DateTime.Now.AddDays(-79),
EndDate = DateTime.Now.AddDays(-69),
Cost = 54715500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-185),
UpdatedAt
 = DateTime.Now.AddDays(-185)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 472,
PaymentId = 185,
ProductId = 4,
ServiceId = 1,
AmoutEmployee = 128,
StartDate = DateTime.Now.AddDays(-154),
EndDate = DateTime.Now.AddDays(-145),
Cost = 11520000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-185),
UpdatedAt
 = DateTime.Now.AddDays(-185)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 473,
PaymentId = 186,
ProductId = 3,
ServiceId = 3,
AmoutEmployee = 33,
StartDate = DateTime.Now.AddDays(-104),
EndDate = DateTime.Now.AddDays(-103),
Cost = 1815000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-186),
UpdatedAt
 = DateTime.Now.AddDays(-186)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 474,
PaymentId = 186,
ProductId = 20,
ServiceId = 3,
AmoutEmployee = 91,
StartDate = DateTime.Now.AddDays(-64),
EndDate = DateTime.Now.AddDays(-62),
Cost = 21021000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-186),
UpdatedAt
 = DateTime.Now.AddDays(-186)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 475,
PaymentId = 187,
ProductId = 6,
ServiceId = 3,
AmoutEmployee = 147,
StartDate = DateTime.Now.AddDays(-92),
EndDate = DateTime.Now.AddDays(-90),
Cost = 6468000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-187),
UpdatedAt
 = DateTime.Now.AddDays(-187)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 476,
PaymentId = 187,
ProductId = 29,
ServiceId = 3,
AmoutEmployee = 175,
StartDate = DateTime.Now.AddDays(-166),
EndDate = DateTime.Now.AddDays(-154),
Cost = 34650000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-187),
UpdatedAt
 = DateTime.Now.AddDays(-187)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 477,
PaymentId = 187,
ProductId = 6,
ServiceId = 1,
AmoutEmployee = 181,
StartDate = DateTime.Now.AddDays(-89),
EndDate = DateTime.Now.AddDays(-75),
Cost = 33394500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-187),
UpdatedAt
 = DateTime.Now.AddDays(-187)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 478,
PaymentId = 188,
ProductId = 12,
ServiceId = 1,
AmoutEmployee = 190,
StartDate = DateTime.Now.AddDays(-45),
EndDate = DateTime.Now.AddDays(-34),
Cost = 9405000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-188),
UpdatedAt
 = DateTime.Now.AddDays(-188)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 479,
PaymentId = 188,
ProductId = 26,
ServiceId = 3,
AmoutEmployee = 67,
StartDate = DateTime.Now.AddDays(-127),
EndDate = DateTime.Now.AddDays(-114),
Cost = 31322500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-188),
UpdatedAt
 = DateTime.Now.AddDays(-188)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 480,
PaymentId = 188,
ProductId = 10,
ServiceId = 2,
AmoutEmployee = 109,
StartDate = DateTime.Now.AddDays(-150),
EndDate = DateTime.Now.AddDays(-149),
Cost = 23544000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-188),
UpdatedAt
 = DateTime.Now.AddDays(-188)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 481,
PaymentId = 189,
ProductId = 7,
ServiceId = 3,
AmoutEmployee = 142,
StartDate = DateTime.Now.AddDays(-143),
EndDate = DateTime.Now.AddDays(-129),
Cost = 63261000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-189),
UpdatedAt
 = DateTime.Now.AddDays(-189)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 482,
PaymentId = 189,
ProductId = 29,
ServiceId = 1,
AmoutEmployee = 151,
StartDate = DateTime.Now.AddDays(-98),
EndDate = DateTime.Now.AddDays(-83),
Cost = 29218500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-189),
UpdatedAt
 = DateTime.Now.AddDays(-189)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 483,
PaymentId = 190,
ProductId = 26,
ServiceId = 2,
AmoutEmployee = 35,
StartDate = DateTime.Now.AddDays(-82),
EndDate = DateTime.Now.AddDays(-75),
Cost = 9660000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-190),
UpdatedAt
 = DateTime.Now.AddDays(-190)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 484,
PaymentId = 190,
ProductId = 26,
ServiceId = 3,
AmoutEmployee = 57,
StartDate = DateTime.Now.AddDays(-163),
EndDate = DateTime.Now.AddDays(-148),
Cost = 35739000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-190),
UpdatedAt
 = DateTime.Now.AddDays(-190)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 485,
PaymentId = 190,
ProductId = 23,
ServiceId = 1,
AmoutEmployee = 52,
StartDate = DateTime.Now.AddDays(-37),
EndDate = DateTime.Now.AddDays(-24),
Cost = 1638000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-190),
UpdatedAt
 = DateTime.Now.AddDays(-190)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 486,
PaymentId = 191,
ProductId = 7,
ServiceId = 3,
AmoutEmployee = 67,
StartDate = DateTime.Now.AddDays(-25),
EndDate = DateTime.Now.AddDays(-18),
Cost = 368500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-191),
UpdatedAt
 = DateTime.Now.AddDays(-191)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 487,
PaymentId = 191,
ProductId = 1,
ServiceId = 2,
AmoutEmployee = 147,
StartDate = DateTime.Now.AddDays(-141),
EndDate = DateTime.Now.AddDays(-134),
Cost = 49392000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-191),
UpdatedAt
 = DateTime.Now.AddDays(-191)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 488,
PaymentId = 192,
ProductId = 4,
ServiceId = 2,
AmoutEmployee = 32,
StartDate = DateTime.Now.AddDays(-95),
EndDate = DateTime.Now.AddDays(-89),
Cost = 6912000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-192),
UpdatedAt
 = DateTime.Now.AddDays(-192)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 489,
PaymentId = 192,
ProductId = 28,
ServiceId = 3,
AmoutEmployee = 57,
StartDate = DateTime.Now.AddDays(-118),
EndDate = DateTime.Now.AddDays(-103),
Cost = 22572000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-192),
UpdatedAt
 = DateTime.Now.AddDays(-192)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 490,
PaymentId = 192,
ProductId = 29,
ServiceId = 1,
AmoutEmployee = 129,
StartDate = DateTime.Now.AddDays(-41),
EndDate = DateTime.Now.AddDays(-37),
Cost = 1161000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-192),
UpdatedAt
 = DateTime.Now.AddDays(-192)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 491,
PaymentId = 193,
ProductId = 19,
ServiceId = 3,
AmoutEmployee = 178,
StartDate = DateTime.Now.AddDays(-143),
EndDate = DateTime.Now.AddDays(-139),
Cost = 133144000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-193),
UpdatedAt
 = DateTime.Now.AddDays(-193)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 492,
PaymentId = 193,
ProductId = 2,
ServiceId = 2,
AmoutEmployee = 149,
StartDate = DateTime.Now.AddDays(-162),
EndDate = DateTime.Now.AddDays(-159),
Cost = 44700000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-193),
UpdatedAt
 = DateTime.Now.AddDays(-193)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 493,
PaymentId = 194,
ProductId = 18,
ServiceId = 1,
AmoutEmployee = 111,
StartDate = DateTime.Now.AddDays(-196),
EndDate = DateTime.Now.AddDays(-189),
Cost = 16983000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-194),
UpdatedAt
 = DateTime.Now.AddDays(-194)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 494,
PaymentId = 194,
ProductId = 12,
ServiceId = 3,
AmoutEmployee = 175,
StartDate = DateTime.Now.AddDays(-166),
EndDate = DateTime.Now.AddDays(-165),
Cost = 88550000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-194),
UpdatedAt
 = DateTime.Now.AddDays(-194)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 495,
PaymentId = 194,
ProductId = 15,
ServiceId = 1,
AmoutEmployee = 32,
StartDate = DateTime.Now.AddDays(-102),
EndDate = DateTime.Now.AddDays(-98),
Cost = 7776000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-194),
UpdatedAt
 = DateTime.Now.AddDays(-194)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 496,
PaymentId = 195,
ProductId = 26,
ServiceId = 1,
AmoutEmployee = 108,
StartDate = DateTime.Now.AddDays(-71),
EndDate = DateTime.Now.AddDays(-66),
Cost = 19926000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-195),
UpdatedAt
 = DateTime.Now.AddDays(-195)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 497,
PaymentId = 195,
ProductId = 13,
ServiceId = 2,
AmoutEmployee = 73,
StartDate = DateTime.Now.AddDays(-10),
EndDate = DateTime.Now.AddDays(-3),
Cost = 2190000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-195),
UpdatedAt
 = DateTime.Now.AddDays(-195)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 498,
PaymentId = 196,
ProductId = 3,
ServiceId = 2,
AmoutEmployee = 59,
StartDate = DateTime.Now.AddDays(-157),
EndDate = DateTime.Now.AddDays(-144),
Cost = 9912000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-196),
UpdatedAt
 = DateTime.Now.AddDays(-196)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 499,
PaymentId = 196,
ProductId = 20,
ServiceId = 3,
AmoutEmployee = 29,
StartDate = DateTime.Now.AddDays(-122),
EndDate = DateTime.Now.AddDays(-108),
Cost = 3668500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-196),
UpdatedAt
 = DateTime.Now.AddDays(-196)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 500,
PaymentId = 196,
ProductId = 26,
ServiceId = 1,
AmoutEmployee = 43,
StartDate = DateTime.Now.AddDays(-53),
EndDate = DateTime.Now.AddDays(-44),
Cost = 2709000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-196),
UpdatedAt
 = DateTime.Now.AddDays(-196)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 501,
PaymentId = 197,
ProductId = 21,
ServiceId = 3,
AmoutEmployee = 164,
StartDate = DateTime.Now.AddDays(-26),
EndDate = DateTime.Now.AddDays(-17),
Cost = 7216000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-197),
UpdatedAt
 = DateTime.Now.AddDays(-197)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 502,
PaymentId = 197,
ProductId = 25,
ServiceId = 2,
AmoutEmployee = 198,
StartDate = DateTime.Now.AddDays(-195),
EndDate = DateTime.Now.AddDays(-191),
Cost = 180576000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-197),
UpdatedAt
 = DateTime.Now.AddDays(-197)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 503,
PaymentId = 198,
ProductId = 19,
ServiceId = 1,
AmoutEmployee = 45,
StartDate = DateTime.Now.AddDays(-84),
EndDate = DateTime.Now.AddDays(-77),
Cost = 5467500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-198),
UpdatedAt
 = DateTime.Now.AddDays(-198)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 504,
PaymentId = 198,
ProductId = 14,
ServiceId = 2,
AmoutEmployee = 156,
StartDate = DateTime.Now.AddDays(-86),
EndDate = DateTime.Now.AddDays(-85),
Cost = 32760000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-198),
UpdatedAt
 = DateTime.Now.AddDays(-198)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 505,
PaymentId = 198,
ProductId = 24,
ServiceId = 2,
AmoutEmployee = 83,
StartDate = DateTime.Now.AddDays(-184),
EndDate = DateTime.Now.AddDays(-174),
Cost = 68724000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-198),
UpdatedAt
 = DateTime.Now.AddDays(-198)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 506,
PaymentId = 199,
ProductId = 3,
ServiceId = 1,
AmoutEmployee = 53,
StartDate = DateTime.Now.AddDays(-133),
EndDate = DateTime.Now.AddDays(-125),
Cost = 28620000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-199),
UpdatedAt
 = DateTime.Now.AddDays(-199)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 507,
PaymentId = 199,
ProductId = 2,
ServiceId = 1,
AmoutEmployee = 81,
StartDate = DateTime.Now.AddDays(-140),
EndDate = DateTime.Now.AddDays(-126),
Cost = 2916000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-199),
UpdatedAt
 = DateTime.Now.AddDays(-199)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 508,
PaymentId = 199,
ProductId = 25,
ServiceId = 1,
AmoutEmployee = 101,
StartDate = DateTime.Now.AddDays(-10),
EndDate = DateTime.Now.AddDays(5),
Cost = 454500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-199),
UpdatedAt
 = DateTime.Now.AddDays(-199)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 509,
PaymentId = 200,
ProductId = 2,
ServiceId = 1,
AmoutEmployee = 151,
StartDate = DateTime.Now.AddDays(-36),
EndDate = DateTime.Now.AddDays(-24),
Cost = 679500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-200),
UpdatedAt
 = DateTime.Now.AddDays(-200)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 510,
PaymentId = 200,
ProductId = 12,
ServiceId = 1,
AmoutEmployee = 166,
StartDate = DateTime.Now.AddDays(-121),
EndDate = DateTime.Now.AddDays(-108),
Cost = 71712000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-200),
UpdatedAt
 = DateTime.Now.AddDays(-200)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 511,
PaymentId = 201,
ProductId = 24,
ServiceId = 2,
AmoutEmployee = 54,
StartDate = DateTime.Now.AddDays(-183),
EndDate = DateTime.Now.AddDays(-174),
Cost = 47628000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-201),
UpdatedAt
 = DateTime.Now.AddDays(-201)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 512,
PaymentId = 201,
ProductId = 10,
ServiceId = 2,
AmoutEmployee = 128,
StartDate = DateTime.Now.AddDays(-48),
EndDate = DateTime.Now.AddDays(-47),
Cost = 10752000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-201),
UpdatedAt
 = DateTime.Now.AddDays(-201)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 513,
PaymentId = 201,
ProductId = 24,
ServiceId = 1,
AmoutEmployee = 91,
StartDate = DateTime.Now.AddDays(-150),
EndDate = DateTime.Now.AddDays(-137),
Cost = 28255500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-201),
UpdatedAt
 = DateTime.Now.AddDays(-201)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 514,
PaymentId = 202,
ProductId = 7,
ServiceId = 2,
AmoutEmployee = 50,
StartDate = DateTime.Now.AddDays(-123),
EndDate = DateTime.Now.AddDays(-117),
Cost = 23100000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-202),
UpdatedAt
 = DateTime.Now.AddDays(-202)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 515,
PaymentId = 202,
ProductId = 14,
ServiceId = 2,
AmoutEmployee = 133,
StartDate = DateTime.Now.AddDays(-193),
EndDate = DateTime.Now.AddDays(-187),
Cost = 61446000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-202),
UpdatedAt
 = DateTime.Now.AddDays(-202)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 516,
PaymentId = 203,
ProductId = 13,
ServiceId = 1,
AmoutEmployee = 110,
StartDate = DateTime.Now.AddDays(-90),
EndDate = DateTime.Now.AddDays(-76),
Cost = 18315000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-203),
UpdatedAt
 = DateTime.Now.AddDays(-203)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 517,
PaymentId = 203,
ProductId = 12,
ServiceId = 2,
AmoutEmployee = 143,
StartDate = DateTime.Now.AddDays(-193),
EndDate = DateTime.Now.AddDays(-189),
Cost = 145860000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-203),
UpdatedAt
 = DateTime.Now.AddDays(-203)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 518,
PaymentId = 203,
ProductId = 25,
ServiceId = 2,
AmoutEmployee = 111,
StartDate = DateTime.Now.AddDays(-87),
EndDate = DateTime.Now.AddDays(-77),
Cost = 5994000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-203),
UpdatedAt
 = DateTime.Now.AddDays(-203)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 519,
PaymentId = 204,
ProductId = 10,
ServiceId = 2,
AmoutEmployee = 103,
StartDate = DateTime.Now.AddDays(-113),
EndDate = DateTime.Now.AddDays(-101),
Cost = 66126000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-204),
UpdatedAt
 = DateTime.Now.AddDays(-204)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 520,
PaymentId = 204,
ProductId = 13,
ServiceId = 1,
AmoutEmployee = 198,
StartDate = DateTime.Now.AddDays(-58),
EndDate = DateTime.Now.AddDays(-44),
Cost = 41877000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-204),
UpdatedAt
 = DateTime.Now.AddDays(-204)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 521,
PaymentId = 205,
ProductId = 26,
ServiceId = 1,
AmoutEmployee = 73,
StartDate = DateTime.Now.AddDays(-28),
EndDate = DateTime.Now.AddDays(-16),
Cost = 5584500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-205),
UpdatedAt
 = DateTime.Now.AddDays(-205)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 522,
PaymentId = 205,
ProductId = 10,
ServiceId = 2,
AmoutEmployee = 30,
StartDate = DateTime.Now.AddDays(-111),
EndDate = DateTime.Now.AddDays(-96),
Cost = 1620000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-205),
UpdatedAt
 = DateTime.Now.AddDays(-205)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 523,
PaymentId = 205,
ProductId = 12,
ServiceId = 3,
AmoutEmployee = 98,
StartDate = DateTime.Now.AddDays(-79),
EndDate = DateTime.Now.AddDays(-65),
Cost = 29645000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-205),
UpdatedAt
 = DateTime.Now.AddDays(-205)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 524,
PaymentId = 206,
ProductId = 15,
ServiceId = 1,
AmoutEmployee = 173,
StartDate = DateTime.Now.AddDays(-191),
EndDate = DateTime.Now.AddDays(-178),
Cost = 25690500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-206),
UpdatedAt
 = DateTime.Now.AddDays(-206)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 525,
PaymentId = 206,
ProductId = 9,
ServiceId = 3,
AmoutEmployee = 155,
StartDate = DateTime.Now.AddDays(-125),
EndDate = DateTime.Now.AddDays(-111),
Cost = 1705000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-206),
UpdatedAt
 = DateTime.Now.AddDays(-206)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 526,
PaymentId = 207,
ProductId = 16,
ServiceId = 1,
AmoutEmployee = 102,
StartDate = DateTime.Now.AddDays(-147),
EndDate = DateTime.Now.AddDays(-139),
Cost = 21573000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-207),
UpdatedAt
 = DateTime.Now.AddDays(-207)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 527,
PaymentId = 207,
ProductId = 14,
ServiceId = 1,
AmoutEmployee = 75,
StartDate = DateTime.Now.AddDays(-156),
EndDate = DateTime.Now.AddDays(-154),
Cost = 50625000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-207),
UpdatedAt
 = DateTime.Now.AddDays(-207)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 528,
PaymentId = 207,
ProductId = 7,
ServiceId = 3,
AmoutEmployee = 151,
StartDate = DateTime.Now.AddDays(-172),
EndDate = DateTime.Now.AddDays(-160),
Cost = 116270000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-207),
UpdatedAt
 = DateTime.Now.AddDays(-207)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 529,
PaymentId = 208,
ProductId = 9,
ServiceId = 2,
AmoutEmployee = 109,
StartDate = DateTime.Now.AddDays(-178),
EndDate = DateTime.Now.AddDays(-172),
Cost = 25506000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-208),
UpdatedAt
 = DateTime.Now.AddDays(-208)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 530,
PaymentId = 208,
ProductId = 26,
ServiceId = 3,
AmoutEmployee = 26,
StartDate = DateTime.Now.AddDays(-29),
EndDate = DateTime.Now.AddDays(-23),
Cost = 143000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-208),
UpdatedAt
 = DateTime.Now.AddDays(-208)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 531,
PaymentId = 209,
ProductId = 26,
ServiceId = 3,
AmoutEmployee = 159,
StartDate = DateTime.Now.AddDays(-119),
EndDate = DateTime.Now.AddDays(-107),
Cost = 45474000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-209),
UpdatedAt
 = DateTime.Now.AddDays(-209)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 532,
PaymentId = 209,
ProductId = 19,
ServiceId = 3,
AmoutEmployee = 103,
StartDate = DateTime.Now.AddDays(-116),
EndDate = DateTime.Now.AddDays(-107),
Cost = 13029500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-209),
UpdatedAt
 = DateTime.Now.AddDays(-209)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 533,
PaymentId = 209,
ProductId = 13,
ServiceId = 1,
AmoutEmployee = 155,
StartDate = DateTime.Now.AddDays(-45),
EndDate = DateTime.Now.AddDays(-41),
Cost = 6277500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-209),
UpdatedAt
 = DateTime.Now.AddDays(-209)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 534,
PaymentId = 210,
ProductId = 21,
ServiceId = 2,
AmoutEmployee = 81,
StartDate = DateTime.Now.AddDays(-57),
EndDate = DateTime.Now.AddDays(-42),
Cost = 5832000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-210),
UpdatedAt
 = DateTime.Now.AddDays(-210)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 535,
PaymentId = 210,
ProductId = 11,
ServiceId = 2,
AmoutEmployee = 198,
StartDate = DateTime.Now.AddDays(-49),
EndDate = DateTime.Now.AddDays(-38),
Cost = 13068000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-210),
UpdatedAt
 = DateTime.Now.AddDays(-210)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 536,
PaymentId = 210,
ProductId = 20,
ServiceId = 2,
AmoutEmployee = 80,
StartDate = DateTime.Now.AddDays(-99),
EndDate = DateTime.Now.AddDays(-86),
Cost = 25440000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-210),
UpdatedAt
 = DateTime.Now.AddDays(-210)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 537,
PaymentId = 211,
ProductId = 22,
ServiceId = 1,
AmoutEmployee = 43,
StartDate = DateTime.Now.AddDays(-70),
EndDate = DateTime.Now.AddDays(-65),
Cost = 12577500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-211),
UpdatedAt
 = DateTime.Now.AddDays(-211)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 538,
PaymentId = 211,
ProductId = 14,
ServiceId = 1,
AmoutEmployee = 190,
StartDate = DateTime.Now.AddDays(-114),
EndDate = DateTime.Now.AddDays(-110),
Cost = 76095000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-211),
UpdatedAt
 = DateTime.Now.AddDays(-211)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 539,
PaymentId = 212,
ProductId = 13,
ServiceId = 1,
AmoutEmployee = 68,
StartDate = DateTime.Now.AddDays(-80),
EndDate = DateTime.Now.AddDays(-69),
Cost = 22338000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-212),
UpdatedAt
 = DateTime.Now.AddDays(-212)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 540,
PaymentId = 212,
ProductId = 20,
ServiceId = 1,
AmoutEmployee = 27,
StartDate = DateTime.Now.AddDays(-194),
EndDate = DateTime.Now.AddDays(-187),
Cost = 10084500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-212),
UpdatedAt
 = DateTime.Now.AddDays(-212)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 541,
PaymentId = 212,
ProductId = 5,
ServiceId = 3,
AmoutEmployee = 108,
StartDate = DateTime.Now.AddDays(-185),
EndDate = DateTime.Now.AddDays(-175),
Cost = 48114000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-212),
UpdatedAt
 = DateTime.Now.AddDays(-212)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 542,
PaymentId = 213,
ProductId = 12,
ServiceId = 3,
AmoutEmployee = 47,
StartDate = DateTime.Now.AddDays(-145),
EndDate = DateTime.Now.AddDays(-139),
Cost = 35673000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-213),
UpdatedAt
 = DateTime.Now.AddDays(-213)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 543,
PaymentId = 213,
ProductId = 2,
ServiceId = 3,
AmoutEmployee = 30,
StartDate = DateTime.Now.AddDays(-170),
EndDate = DateTime.Now.AddDays(-165),
Cost = 1815000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-213),
UpdatedAt
 = DateTime.Now.AddDays(-213)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 544,
PaymentId = 214,
ProductId = 1,
ServiceId = 2,
AmoutEmployee = 121,
StartDate = DateTime.Now.AddDays(-103),
EndDate = DateTime.Now.AddDays(-89),
Cost = 65340000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-214),
UpdatedAt
 = DateTime.Now.AddDays(-214)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 545,
PaymentId = 214,
ProductId = 3,
ServiceId = 3,
AmoutEmployee = 42,
StartDate = DateTime.Now.AddDays(-143),
EndDate = DateTime.Now.AddDays(-140),
Cost = 27027000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-214),
UpdatedAt
 = DateTime.Now.AddDays(-214)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 546,
PaymentId = 214,
ProductId = 18,
ServiceId = 3,
AmoutEmployee = 137,
StartDate = DateTime.Now.AddDays(-91),
EndDate = DateTime.Now.AddDays(-87),
Cost = 15070000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-214),
UpdatedAt
 = DateTime.Now.AddDays(-214)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 547,
PaymentId = 215,
ProductId = 27,
ServiceId = 2,
AmoutEmployee = 106,
StartDate = DateTime.Now.AddDays(-45),
EndDate = DateTime.Now.AddDays(-41),
Cost = 24804000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-215),
UpdatedAt
 = DateTime.Now.AddDays(-215)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 548,
PaymentId = 215,
ProductId = 1,
ServiceId = 2,
AmoutEmployee = 165,
StartDate = DateTime.Now.AddDays(-66),
EndDate = DateTime.Now.AddDays(-59),
Cost = 51480000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-215),
UpdatedAt
 = DateTime.Now.AddDays(-215)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 549,
PaymentId = 216,
ProductId = 12,
ServiceId = 2,
AmoutEmployee = 186,
StartDate = DateTime.Now.AddDays(-191),
EndDate = DateTime.Now.AddDays(-186),
Cost = 121644000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-216),
UpdatedAt
 = DateTime.Now.AddDays(-216)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 550,
PaymentId = 216,
ProductId = 19,
ServiceId = 3,
AmoutEmployee = 109,
StartDate = DateTime.Now.AddDays(-70),
EndDate = DateTime.Now.AddDays(-68),
Cost = 35970000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-216),
UpdatedAt
 = DateTime.Now.AddDays(-216)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 551,
PaymentId = 216,
ProductId = 6,
ServiceId = 1,
AmoutEmployee = 136,
StartDate = DateTime.Now.AddDays(-106),
EndDate = DateTime.Now.AddDays(-104),
Cost = 7956000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-216),
UpdatedAt
 = DateTime.Now.AddDays(-216)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 552,
PaymentId = 217,
ProductId = 18,
ServiceId = 2,
AmoutEmployee = 92,
StartDate = DateTime.Now.AddDays(-108),
EndDate = DateTime.Now.AddDays(-97),
Cost = 44160000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-217),
UpdatedAt
 = DateTime.Now.AddDays(-217)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 553,
PaymentId = 217,
ProductId = 10,
ServiceId = 3,
AmoutEmployee = 165,
StartDate = DateTime.Now.AddDays(-198),
EndDate = DateTime.Now.AddDays(-190),
Cost = 126142500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-217),
UpdatedAt
 = DateTime.Now.AddDays(-217)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 554,
PaymentId = 218,
ProductId = 24,
ServiceId = 3,
AmoutEmployee = 41,
StartDate = DateTime.Now.AddDays(-146),
EndDate = DateTime.Now.AddDays(-145),
Cost = 225500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-218),
UpdatedAt
 = DateTime.Now.AddDays(-218)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 555,
PaymentId = 218,
ProductId = 2,
ServiceId = 1,
AmoutEmployee = 75,
StartDate = DateTime.Now.AddDays(-69),
EndDate = DateTime.Now.AddDays(-58),
Cost = 16875000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-218),
UpdatedAt
 = DateTime.Now.AddDays(-218)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 556,
PaymentId = 218,
ProductId = 17,
ServiceId = 1,
AmoutEmployee = 93,
StartDate = DateTime.Now.AddDays(-166),
EndDate = DateTime.Now.AddDays(-157),
Cost = 30132000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-218),
UpdatedAt
 = DateTime.Now.AddDays(-218)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 557,
PaymentId = 219,
ProductId = 13,
ServiceId = 2,
AmoutEmployee = 193,
StartDate = DateTime.Now.AddDays(-105),
EndDate = DateTime.Now.AddDays(-95),
Cost = 2316000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-219),
UpdatedAt
 = DateTime.Now.AddDays(-219)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 558,
PaymentId = 219,
ProductId = 2,
ServiceId = 1,
AmoutEmployee = 158,
StartDate = DateTime.Now.AddDays(-13),
EndDate = DateTime.Now.AddDays(2),
Cost = 4266000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-219),
UpdatedAt
 = DateTime.Now.AddDays(-219)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 559,
PaymentId = 220,
ProductId = 15,
ServiceId = 1,
AmoutEmployee = 107,
StartDate = DateTime.Now.AddDays(-85),
EndDate = DateTime.Now.AddDays(-73),
Cost = 30816000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-220),
UpdatedAt
 = DateTime.Now.AddDays(-220)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 560,
PaymentId = 220,
ProductId = 29,
ServiceId = 3,
AmoutEmployee = 185,
StartDate = DateTime.Now.AddDays(-197),
EndDate = DateTime.Now.AddDays(-190),
Cost = 16280000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-220),
UpdatedAt
 = DateTime.Now.AddDays(-220)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 561,
PaymentId = 220,
ProductId = 14,
ServiceId = 1,
AmoutEmployee = 54,
StartDate = DateTime.Now.AddDays(-11),
EndDate = DateTime.Now.AddDays(0),
Cost = 486000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-220),
UpdatedAt
 = DateTime.Now.AddDays(-220)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 562,
PaymentId = 221,
ProductId = 28,
ServiceId = 3,
AmoutEmployee = 157,
StartDate = DateTime.Now.AddDays(-134),
EndDate = DateTime.Now.AddDays(-119),
Cost = 109664500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-221),
UpdatedAt
 = DateTime.Now.AddDays(-221)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 563,
PaymentId = 221,
ProductId = 23,
ServiceId = 2,
AmoutEmployee = 164,
StartDate = DateTime.Now.AddDays(-45),
EndDate = DateTime.Now.AddDays(-31),
Cost = 17712000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-221),
UpdatedAt
 = DateTime.Now.AddDays(-221)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 564,
PaymentId = 221,
ProductId = 29,
ServiceId = 3,
AmoutEmployee = 138,
StartDate = DateTime.Now.AddDays(-194),
EndDate = DateTime.Now.AddDays(-187),
Cost = 115368000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-221),
UpdatedAt
 = DateTime.Now.AddDays(-221)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 565,
PaymentId = 222,
ProductId = 24,
ServiceId = 3,
AmoutEmployee = 169,
StartDate = DateTime.Now.AddDays(-151),
EndDate = DateTime.Now.AddDays(-148),
Cost = 6506500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-222),
UpdatedAt
 = DateTime.Now.AddDays(-222)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 566,
PaymentId = 222,
ProductId = 14,
ServiceId = 1,
AmoutEmployee = 186,
StartDate = DateTime.Now.AddDays(-145),
EndDate = DateTime.Now.AddDays(-130),
Cost = 93744000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-222),
UpdatedAt
 = DateTime.Now.AddDays(-222)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 567,
PaymentId = 223,
ProductId = 25,
ServiceId = 3,
AmoutEmployee = 55,
StartDate = DateTime.Now.AddDays(-175),
EndDate = DateTime.Now.AddDays(-164),
Cost = 11192500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-223),
UpdatedAt
 = DateTime.Now.AddDays(-223)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 568,
PaymentId = 223,
ProductId = 6,
ServiceId = 3,
AmoutEmployee = 159,
StartDate = DateTime.Now.AddDays(-84),
EndDate = DateTime.Now.AddDays(-83),
Cost = 48972000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-223),
UpdatedAt
 = DateTime.Now.AddDays(-223)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 569,
PaymentId = 223,
ProductId = 3,
ServiceId = 3,
AmoutEmployee = 99,
StartDate = DateTime.Now.AddDays(-145),
EndDate = DateTime.Now.AddDays(-143),
Cost = 44104500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-223),
UpdatedAt
 = DateTime.Now.AddDays(-223)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 570,
PaymentId = 224,
ProductId = 27,
ServiceId = 2,
AmoutEmployee = 76,
StartDate = DateTime.Now.AddDays(-8),
EndDate = DateTime.Now.AddDays(-7),
Cost = 456000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-224),
UpdatedAt
 = DateTime.Now.AddDays(-224)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 571,
PaymentId = 224,
ProductId = 15,
ServiceId = 2,
AmoutEmployee = 136,
StartDate = DateTime.Now.AddDays(-86),
EndDate = DateTime.Now.AddDays(-73),
Cost = 13056000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-224),
UpdatedAt
 = DateTime.Now.AddDays(-224)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 572,
PaymentId = 225,
ProductId = 13,
ServiceId = 2,
AmoutEmployee = 172,
StartDate = DateTime.Now.AddDays(-101),
EndDate = DateTime.Now.AddDays(-89),
Cost = 78432000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-225),
UpdatedAt
 = DateTime.Now.AddDays(-225)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 573,
PaymentId = 225,
ProductId = 9,
ServiceId = 2,
AmoutEmployee = 84,
StartDate = DateTime.Now.AddDays(-184),
EndDate = DateTime.Now.AddDays(-171),
Cost = 76608000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-225),
UpdatedAt
 = DateTime.Now.AddDays(-225)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 574,
PaymentId = 225,
ProductId = 19,
ServiceId = 3,
AmoutEmployee = 188,
StartDate = DateTime.Now.AddDays(-16),
EndDate = DateTime.Now.AddDays(-4),
Cost = 3102000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-225),
UpdatedAt
 = DateTime.Now.AddDays(-225)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 575,
PaymentId = 226,
ProductId = 5,
ServiceId = 2,
AmoutEmployee = 29,
StartDate = DateTime.Now.AddDays(-40),
EndDate = DateTime.Now.AddDays(-29),
Cost = 4872000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-226),
UpdatedAt
 = DateTime.Now.AddDays(-226)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 576,
PaymentId = 226,
ProductId = 14,
ServiceId = 2,
AmoutEmployee = 199,
StartDate = DateTime.Now.AddDays(-177),
EndDate = DateTime.Now.AddDays(-175),
Cost = 70446000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-226),
UpdatedAt
 = DateTime.Now.AddDays(-226)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 577,
PaymentId = 227,
ProductId = 8,
ServiceId = 2,
AmoutEmployee = 189,
StartDate = DateTime.Now.AddDays(-159),
EndDate = DateTime.Now.AddDays(-156),
Cost = 168966000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-227),
UpdatedAt
 = DateTime.Now.AddDays(-227)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 578,
PaymentId = 227,
ProductId = 21,
ServiceId = 1,
AmoutEmployee = 137,
StartDate = DateTime.Now.AddDays(-24),
EndDate = DateTime.Now.AddDays(-17),
Cost = 8014500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-227),
UpdatedAt
 = DateTime.Now.AddDays(-227)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 579,
PaymentId = 227,
ProductId = 19,
ServiceId = 2,
AmoutEmployee = 70,
StartDate = DateTime.Now.AddDays(-164),
EndDate = DateTime.Now.AddDays(-159),
Cost = 14700000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-227),
UpdatedAt
 = DateTime.Now.AddDays(-227)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 580,
PaymentId = 228,
ProductId = 3,
ServiceId = 2,
AmoutEmployee = 152,
StartDate = DateTime.Now.AddDays(-187),
EndDate = DateTime.Now.AddDays(-186),
Cost = 84816000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-228),
UpdatedAt
 = DateTime.Now.AddDays(-228)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 581,
PaymentId = 228,
ProductId = 11,
ServiceId = 2,
AmoutEmployee = 161,
StartDate = DateTime.Now.AddDays(-63),
EndDate = DateTime.Now.AddDays(-48),
Cost = 28014000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-228),
UpdatedAt
 = DateTime.Now.AddDays(-228)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 582,
PaymentId = 229,
ProductId = 22,
ServiceId = 2,
AmoutEmployee = 71,
StartDate = DateTime.Now.AddDays(-82),
EndDate = DateTime.Now.AddDays(-71),
Cost = 32802000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-229),
UpdatedAt
 = DateTime.Now.AddDays(-229)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 583,
PaymentId = 229,
ProductId = 6,
ServiceId = 2,
AmoutEmployee = 152,
StartDate = DateTime.Now.AddDays(-119),
EndDate = DateTime.Now.AddDays(-116),
Cost = 12768000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-229),
UpdatedAt
 = DateTime.Now.AddDays(-229)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 584,
PaymentId = 229,
ProductId = 12,
ServiceId = 2,
AmoutEmployee = 93,
StartDate = DateTime.Now.AddDays(-71),
EndDate = DateTime.Now.AddDays(-68),
Cost = 3906000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-229),
UpdatedAt
 = DateTime.Now.AddDays(-229)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 585,
PaymentId = 230,
ProductId = 7,
ServiceId = 1,
AmoutEmployee = 120,
StartDate = DateTime.Now.AddDays(-102),
EndDate = DateTime.Now.AddDays(-91),
Cost = 31320000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-230),
UpdatedAt
 = DateTime.Now.AddDays(-230)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 586,
PaymentId = 230,
ProductId = 13,
ServiceId = 1,
AmoutEmployee = 33,
StartDate = DateTime.Now.AddDays(-45),
EndDate = DateTime.Now.AddDays(-32),
Cost = 2079000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-230),
UpdatedAt
 = DateTime.Now.AddDays(-230)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 587,
PaymentId = 231,
ProductId = 9,
ServiceId = 3,
AmoutEmployee = 78,
StartDate = DateTime.Now.AddDays(-59),
EndDate = DateTime.Now.AddDays(-56),
Cost = 22737000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-231),
UpdatedAt
 = DateTime.Now.AddDays(-231)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 588,
PaymentId = 231,
ProductId = 21,
ServiceId = 3,
AmoutEmployee = 40,
StartDate = DateTime.Now.AddDays(-40),
EndDate = DateTime.Now.AddDays(-27),
Cost = 6160000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-231),
UpdatedAt
 = DateTime.Now.AddDays(-231)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 589,
PaymentId = 231,
ProductId = 27,
ServiceId = 2,
AmoutEmployee = 160,
StartDate = DateTime.Now.AddDays(-70),
EndDate = DateTime.Now.AddDays(-59),
Cost = 19200000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-231),
UpdatedAt
 = DateTime.Now.AddDays(-231)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 590,
PaymentId = 232,
ProductId = 24,
ServiceId = 3,
AmoutEmployee = 196,
StartDate = DateTime.Now.AddDays(-60),
EndDate = DateTime.Now.AddDays(-52),
Cost = 32340000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-232),
UpdatedAt
 = DateTime.Now.AddDays(-232)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 591,
PaymentId = 232,
ProductId = 9,
ServiceId = 1,
AmoutEmployee = 91,
StartDate = DateTime.Now.AddDays(-91),
EndDate = DateTime.Now.AddDays(-77),
Cost = 409500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-232),
UpdatedAt
 = DateTime.Now.AddDays(-232)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 592,
PaymentId = 232,
ProductId = 15,
ServiceId = 3,
AmoutEmployee = 169,
StartDate = DateTime.Now.AddDays(-168),
EndDate = DateTime.Now.AddDays(-159),
Cost = 99456500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-232),
UpdatedAt
 = DateTime.Now.AddDays(-232)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 593,
PaymentId = 233,
ProductId = 14,
ServiceId = 3,
AmoutEmployee = 148,
StartDate = DateTime.Now.AddDays(-180),
EndDate = DateTime.Now.AddDays(-175),
Cost = 42328000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-233),
UpdatedAt
 = DateTime.Now.AddDays(-233)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 594,
PaymentId = 233,
ProductId = 8,
ServiceId = 1,
AmoutEmployee = 124,
StartDate = DateTime.Now.AddDays(-160),
EndDate = DateTime.Now.AddDays(-158),
Cost = 2232000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-233),
UpdatedAt
 = DateTime.Now.AddDays(-233)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 595,
PaymentId = 234,
ProductId = 26,
ServiceId = 3,
AmoutEmployee = 191,
StartDate = DateTime.Now.AddDays(-121),
EndDate = DateTime.Now.AddDays(-120),
Cost = 66181500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-234),
UpdatedAt
 = DateTime.Now.AddDays(-234)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 596,
PaymentId = 234,
ProductId = 23,
ServiceId = 1,
AmoutEmployee = 180,
StartDate = DateTime.Now.AddDays(-67),
EndDate = DateTime.Now.AddDays(-55),
Cost = 24300000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-234),
UpdatedAt
 = DateTime.Now.AddDays(-234)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 597,
PaymentId = 234,
ProductId = 10,
ServiceId = 1,
AmoutEmployee = 129,
StartDate = DateTime.Now.AddDays(-132),
EndDate = DateTime.Now.AddDays(-121),
Cost = 48181500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-234),
UpdatedAt
 = DateTime.Now.AddDays(-234)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 598,
PaymentId = 235,
ProductId = 16,
ServiceId = 1,
AmoutEmployee = 37,
StartDate = DateTime.Now.AddDays(-8),
EndDate = DateTime.Now.AddDays(1),
Cost = 333000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-235),
UpdatedAt
 = DateTime.Now.AddDays(-235)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 599,
PaymentId = 235,
ProductId = 23,
ServiceId = 1,
AmoutEmployee = 188,
StartDate = DateTime.Now.AddDays(-112),
EndDate = DateTime.Now.AddDays(-111),
Cost = 60912000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-235),
UpdatedAt
 = DateTime.Now.AddDays(-235)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 600,
PaymentId = 236,
ProductId = 22,
ServiceId = 2,
AmoutEmployee = 196,
StartDate = DateTime.Now.AddDays(-158),
EndDate = DateTime.Now.AddDays(-156),
Cost = 8232000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-236),
UpdatedAt
 = DateTime.Now.AddDays(-236)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 601,
PaymentId = 236,
ProductId = 6,
ServiceId = 3,
AmoutEmployee = 54,
StartDate = DateTime.Now.AddDays(-33),
EndDate = DateTime.Now.AddDays(-19),
Cost = 4158000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-236),
UpdatedAt
 = DateTime.Now.AddDays(-236)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 602,
PaymentId = 236,
ProductId = 21,
ServiceId = 3,
AmoutEmployee = 57,
StartDate = DateTime.Now.AddDays(-20),
EndDate = DateTime.Now.AddDays(-13),
Cost = 1567500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-236),
UpdatedAt
 = DateTime.Now.AddDays(-236)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 603,
PaymentId = 237,
ProductId = 28,
ServiceId = 1,
AmoutEmployee = 52,
StartDate = DateTime.Now.AddDays(-18),
EndDate = DateTime.Now.AddDays(-17),
Cost = 1872000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-237),
UpdatedAt
 = DateTime.Now.AddDays(-237)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 604,
PaymentId = 237,
ProductId = 3,
ServiceId = 1,
AmoutEmployee = 50,
StartDate = DateTime.Now.AddDays(-127),
EndDate = DateTime.Now.AddDays(-122),
Cost = 18000000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-237),
UpdatedAt
 = DateTime.Now.AddDays(-237)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 605,
PaymentId = 238,
ProductId = 18,
ServiceId = 1,
AmoutEmployee = 184,
StartDate = DateTime.Now.AddDays(-58),
EndDate = DateTime.Now.AddDays(-51),
Cost = 34776000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-238),
UpdatedAt
 = DateTime.Now.AddDays(-238)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 606,
PaymentId = 238,
ProductId = 29,
ServiceId = 2,
AmoutEmployee = 94,
StartDate = DateTime.Now.AddDays(-159),
EndDate = DateTime.Now.AddDays(-148),
Cost = 47376000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-238),
UpdatedAt
 = DateTime.Now.AddDays(-238)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 607,
PaymentId = 238,
ProductId = 2,
ServiceId = 2,
AmoutEmployee = 163,
StartDate = DateTime.Now.AddDays(-100),
EndDate = DateTime.Now.AddDays(-88),
Cost = 33252000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-238),
UpdatedAt
 = DateTime.Now.AddDays(-238)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 608,
PaymentId = 239,
ProductId = 14,
ServiceId = 2,
AmoutEmployee = 125,
StartDate = DateTime.Now.AddDays(-41),
EndDate = DateTime.Now.AddDays(-26),
Cost = 15000000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-239),
UpdatedAt
 = DateTime.Now.AddDays(-239)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 609,
PaymentId = 239,
ProductId = 14,
ServiceId = 2,
AmoutEmployee = 194,
StartDate = DateTime.Now.AddDays(-53),
EndDate = DateTime.Now.AddDays(-43),
Cost = 27936000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-239),
UpdatedAt
 = DateTime.Now.AddDays(-239)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 610,
PaymentId = 240,
ProductId = 9,
ServiceId = 1,
AmoutEmployee = 107,
StartDate = DateTime.Now.AddDays(-70),
EndDate = DateTime.Now.AddDays(-67),
Cost = 8667000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-240),
UpdatedAt
 = DateTime.Now.AddDays(-240)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 611,
PaymentId = 240,
ProductId = 12,
ServiceId = 1,
AmoutEmployee = 33,
StartDate = DateTime.Now.AddDays(-30),
EndDate = DateTime.Now.AddDays(-26),
Cost = 594000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-240),
UpdatedAt
 = DateTime.Now.AddDays(-240)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 612,
PaymentId = 240,
ProductId = 25,
ServiceId = 3,
AmoutEmployee = 66,
StartDate = DateTime.Now.AddDays(-177),
EndDate = DateTime.Now.AddDays(-164),
Cost = 17424000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-240),
UpdatedAt
 = DateTime.Now.AddDays(-240)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 613,
PaymentId = 241,
ProductId = 7,
ServiceId = 3,
AmoutEmployee = 128,
StartDate = DateTime.Now.AddDays(-119),
EndDate = DateTime.Now.AddDays(-104),
Cost = 33792000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-241),
UpdatedAt
 = DateTime.Now.AddDays(-241)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 614,
PaymentId = 241,
ProductId = 27,
ServiceId = 3,
AmoutEmployee = 64,
StartDate = DateTime.Now.AddDays(-198),
EndDate = DateTime.Now.AddDays(-193),
Cost = 64064000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-241),
UpdatedAt
 = DateTime.Now.AddDays(-241)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 615,
PaymentId = 242,
ProductId = 9,
ServiceId = 3,
AmoutEmployee = 81,
StartDate = DateTime.Now.AddDays(-70),
EndDate = DateTime.Now.AddDays(-57),
Cost = 9801000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-242),
UpdatedAt
 = DateTime.Now.AddDays(-242)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 616,
PaymentId = 242,
ProductId = 24,
ServiceId = 3,
AmoutEmployee = 31,
StartDate = DateTime.Now.AddDays(-135),
EndDate = DateTime.Now.AddDays(-132),
Cost = 2557500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-242),
UpdatedAt
 = DateTime.Now.AddDays(-242)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 617,
PaymentId = 242,
ProductId = 22,
ServiceId = 3,
AmoutEmployee = 196,
StartDate = DateTime.Now.AddDays(-189),
EndDate = DateTime.Now.AddDays(-176),
Cost = 190806000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-242),
UpdatedAt
 = DateTime.Now.AddDays(-242)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 618,
PaymentId = 243,
ProductId = 10,
ServiceId = 1,
AmoutEmployee = 110,
StartDate = DateTime.Now.AddDays(-145),
EndDate = DateTime.Now.AddDays(-134),
Cost = 43065000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-243),
UpdatedAt
 = DateTime.Now.AddDays(-243)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 619,
PaymentId = 243,
ProductId = 23,
ServiceId = 3,
AmoutEmployee = 176,
StartDate = DateTime.Now.AddDays(-154),
EndDate = DateTime.Now.AddDays(-145),
Cost = 1936000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-243),
UpdatedAt
 = DateTime.Now.AddDays(-243)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 620,
PaymentId = 243,
ProductId = 10,
ServiceId = 2,
AmoutEmployee = 40,
StartDate = DateTime.Now.AddDays(-139),
EndDate = DateTime.Now.AddDays(-126),
Cost = 29760000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-243),
UpdatedAt
 = DateTime.Now.AddDays(-243)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 621,
PaymentId = 244,
ProductId = 24,
ServiceId = 2,
AmoutEmployee = 92,
StartDate = DateTime.Now.AddDays(-130),
EndDate = DateTime.Now.AddDays(-129),
Cost = 13248000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-244),
UpdatedAt
 = DateTime.Now.AddDays(-244)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 622,
PaymentId = 244,
ProductId = 14,
ServiceId = 3,
AmoutEmployee = 46,
StartDate = DateTime.Now.AddDays(-188),
EndDate = DateTime.Now.AddDays(-184),
Cost = 18722000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-244),
UpdatedAt
 = DateTime.Now.AddDays(-244)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 623,
PaymentId = 245,
ProductId = 15,
ServiceId = 2,
AmoutEmployee = 98,
StartDate = DateTime.Now.AddDays(-51),
EndDate = DateTime.Now.AddDays(-44),
Cost = 12936000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-245),
UpdatedAt
 = DateTime.Now.AddDays(-245)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 624,
PaymentId = 245,
ProductId = 27,
ServiceId = 2,
AmoutEmployee = 46,
StartDate = DateTime.Now.AddDays(-156),
EndDate = DateTime.Now.AddDays(-154),
Cost = 18492000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-245),
UpdatedAt
 = DateTime.Now.AddDays(-245)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 625,
PaymentId = 245,
ProductId = 8,
ServiceId = 2,
AmoutEmployee = 103,
StartDate = DateTime.Now.AddDays(-10),
EndDate = DateTime.Now.AddDays(-9),
Cost = 2472000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-245),
UpdatedAt
 = DateTime.Now.AddDays(-245)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 626,
PaymentId = 246,
ProductId = 9,
ServiceId = 1,
AmoutEmployee = 87,
StartDate = DateTime.Now.AddDays(-155),
EndDate = DateTime.Now.AddDays(-148),
Cost = 32494500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-246),
UpdatedAt
 = DateTime.Now.AddDays(-246)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 627,
PaymentId = 246,
ProductId = 17,
ServiceId = 1,
AmoutEmployee = 56,
StartDate = DateTime.Now.AddDays(-193),
EndDate = DateTime.Now.AddDays(-180),
Cost = 40824000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-246),
UpdatedAt
 = DateTime.Now.AddDays(-246)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 628,
PaymentId = 247,
ProductId = 10,
ServiceId = 1,
AmoutEmployee = 116,
StartDate = DateTime.Now.AddDays(-52),
EndDate = DateTime.Now.AddDays(-39),
Cost = 20880000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-247),
UpdatedAt
 = DateTime.Now.AddDays(-247)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 629,
PaymentId = 247,
ProductId = 16,
ServiceId = 1,
AmoutEmployee = 97,
StartDate = DateTime.Now.AddDays(-41),
EndDate = DateTime.Now.AddDays(-32),
Cost = 1309500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-247),
UpdatedAt
 = DateTime.Now.AddDays(-247)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 630,
PaymentId = 247,
ProductId = 21,
ServiceId = 3,
AmoutEmployee = 195,
StartDate = DateTime.Now.AddDays(-170),
EndDate = DateTime.Now.AddDays(-168),
Cost = 153367500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-247),
UpdatedAt
 = DateTime.Now.AddDays(-247)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 631,
PaymentId = 248,
ProductId = 23,
ServiceId = 2,
AmoutEmployee = 101,
StartDate = DateTime.Now.AddDays(-89),
EndDate = DateTime.Now.AddDays(-83),
Cost = 11514000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-248),
UpdatedAt
 = DateTime.Now.AddDays(-248)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 632,
PaymentId = 248,
ProductId = 26,
ServiceId = 3,
AmoutEmployee = 192,
StartDate = DateTime.Now.AddDays(-167),
EndDate = DateTime.Now.AddDays(-154),
Cost = 89760000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-248),
UpdatedAt
 = DateTime.Now.AddDays(-248)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 633,
PaymentId = 249,
ProductId = 23,
ServiceId = 3,
AmoutEmployee = 35,
StartDate = DateTime.Now.AddDays(-131),
EndDate = DateTime.Now.AddDays(-129),
Cost = 14630000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-249),
UpdatedAt
 = DateTime.Now.AddDays(-249)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 634,
PaymentId = 249,
ProductId = 24,
ServiceId = 1,
AmoutEmployee = 152,
StartDate = DateTime.Now.AddDays(-57),
EndDate = DateTime.Now.AddDays(-55),
Cost = 19836000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-249),
UpdatedAt
 = DateTime.Now.AddDays(-249)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 635,
PaymentId = 249,
ProductId = 12,
ServiceId = 2,
AmoutEmployee = 107,
StartDate = DateTime.Now.AddDays(-170),
EndDate = DateTime.Now.AddDays(-160),
Cost = 95658000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-249),
UpdatedAt
 = DateTime.Now.AddDays(-249)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 636,
PaymentId = 250,
ProductId = 4,
ServiceId = 1,
AmoutEmployee = 168,
StartDate = DateTime.Now.AddDays(-19),
EndDate = DateTime.Now.AddDays(-12),
Cost = 3024000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-250),
UpdatedAt
 = DateTime.Now.AddDays(-250)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 637,
PaymentId = 250,
ProductId = 22,
ServiceId = 1,
AmoutEmployee = 170,
StartDate = DateTime.Now.AddDays(-188),
EndDate = DateTime.Now.AddDays(-174),
Cost = 74970000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-250),
UpdatedAt
 = DateTime.Now.AddDays(-250)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 638,
PaymentId = 251,
ProductId = 10,
ServiceId = 3,
AmoutEmployee = 46,
StartDate = DateTime.Now.AddDays(-62),
EndDate = DateTime.Now.AddDays(-61),
Cost = 3542000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-251),
UpdatedAt
 = DateTime.Now.AddDays(-251)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 639,
PaymentId = 251,
ProductId = 13,
ServiceId = 2,
AmoutEmployee = 37,
StartDate = DateTime.Now.AddDays(-32),
EndDate = DateTime.Now.AddDays(-18),
Cost = 3552000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-251),
UpdatedAt
 = DateTime.Now.AddDays(-251)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 640,
PaymentId = 251,
ProductId = 3,
ServiceId = 1,
AmoutEmployee = 112,
StartDate = DateTime.Now.AddDays(-34),
EndDate = DateTime.Now.AddDays(-26),
Cost = 4032000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-251),
UpdatedAt
 = DateTime.Now.AddDays(-251)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 641,
PaymentId = 252,
ProductId = 10,
ServiceId = 1,
AmoutEmployee = 121,
StartDate = DateTime.Now.AddDays(-62),
EndDate = DateTime.Now.AddDays(-50),
Cost = 5445000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-252),
UpdatedAt
 = DateTime.Now.AddDays(-252)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 642,
PaymentId = 252,
ProductId = 23,
ServiceId = 2,
AmoutEmployee = 190,
StartDate = DateTime.Now.AddDays(-194),
EndDate = DateTime.Now.AddDays(-188),
Cost = 127680000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-252),
UpdatedAt
 = DateTime.Now.AddDays(-252)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 643,
PaymentId = 253,
ProductId = 26,
ServiceId = 1,
AmoutEmployee = 34,
StartDate = DateTime.Now.AddDays(-184),
EndDate = DateTime.Now.AddDays(-169),
Cost = 26010000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-253),
UpdatedAt
 = DateTime.Now.AddDays(-253)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 644,
PaymentId = 253,
ProductId = 10,
ServiceId = 2,
AmoutEmployee = 40,
StartDate = DateTime.Now.AddDays(-49),
EndDate = DateTime.Now.AddDays(-39),
Cost = 6000000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-253),
UpdatedAt
 = DateTime.Now.AddDays(-253)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 645,
PaymentId = 253,
ProductId = 25,
ServiceId = 3,
AmoutEmployee = 45,
StartDate = DateTime.Now.AddDays(-149),
EndDate = DateTime.Now.AddDays(-139),
Cost = 30690000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-253),
UpdatedAt
 = DateTime.Now.AddDays(-253)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 646,
PaymentId = 254,
ProductId = 1,
ServiceId = 1,
AmoutEmployee = 31,
StartDate = DateTime.Now.AddDays(-153),
EndDate = DateTime.Now.AddDays(-142),
Cost = 13810500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-254),
UpdatedAt
 = DateTime.Now.AddDays(-254)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 647,
PaymentId = 254,
ProductId = 9,
ServiceId = 2,
AmoutEmployee = 40,
StartDate = DateTime.Now.AddDays(-161),
EndDate = DateTime.Now.AddDays(-159),
Cost = 13200000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-254),
UpdatedAt
 = DateTime.Now.AddDays(-254)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 648,
PaymentId = 254,
ProductId = 12,
ServiceId = 3,
AmoutEmployee = 120,
StartDate = DateTime.Now.AddDays(-161),
EndDate = DateTime.Now.AddDays(-156),
Cost = 73920000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-254),
UpdatedAt
 = DateTime.Now.AddDays(-254)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 649,
PaymentId = 255,
ProductId = 20,
ServiceId = 2,
AmoutEmployee = 184,
StartDate = DateTime.Now.AddDays(-120),
EndDate = DateTime.Now.AddDays(-105),
Cost = 73968000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-255),
UpdatedAt
 = DateTime.Now.AddDays(-255)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 650,
PaymentId = 255,
ProductId = 26,
ServiceId = 3,
AmoutEmployee = 163,
StartDate = DateTime.Now.AddDays(-139),
EndDate = DateTime.Now.AddDays(-126),
Cost = 38549500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-255),
UpdatedAt
 = DateTime.Now.AddDays(-255)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 651,
PaymentId = 256,
ProductId = 1,
ServiceId = 2,
AmoutEmployee = 34,
StartDate = DateTime.Now.AddDays(-14),
EndDate = DateTime.Now.AddDays(-2),
Cost = 816000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-256),
UpdatedAt
 = DateTime.Now.AddDays(-256)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 652,
PaymentId = 256,
ProductId = 18,
ServiceId = 1,
AmoutEmployee = 60,
StartDate = DateTime.Now.AddDays(-84),
EndDate = DateTime.Now.AddDays(-77),
Cost = 7290000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-256),
UpdatedAt
 = DateTime.Now.AddDays(-256)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 653,
PaymentId = 256,
ProductId = 10,
ServiceId = 1,
AmoutEmployee = 179,
StartDate = DateTime.Now.AddDays(-161),
EndDate = DateTime.Now.AddDays(-146),
Cost = 8860500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-256),
UpdatedAt
 = DateTime.Now.AddDays(-256)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 654,
PaymentId = 257,
ProductId = 30,
ServiceId = 2,
AmoutEmployee = 191,
StartDate = DateTime.Now.AddDays(-167),
EndDate = DateTime.Now.AddDays(-156),
Cost = 61884000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-257),
UpdatedAt
 = DateTime.Now.AddDays(-257)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 655,
PaymentId = 257,
ProductId = 6,
ServiceId = 1,
AmoutEmployee = 183,
StartDate = DateTime.Now.AddDays(-72),
EndDate = DateTime.Now.AddDays(-71),
Cost = 44469000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-257),
UpdatedAt
 = DateTime.Now.AddDays(-257)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 656,
PaymentId = 258,
ProductId = 4,
ServiceId = 2,
AmoutEmployee = 115,
StartDate = DateTime.Now.AddDays(-161),
EndDate = DateTime.Now.AddDays(-156),
Cost = 71070000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-258),
UpdatedAt
 = DateTime.Now.AddDays(-258)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 657,
PaymentId = 258,
ProductId = 14,
ServiceId = 2,
AmoutEmployee = 145,
StartDate = DateTime.Now.AddDays(-159),
EndDate = DateTime.Now.AddDays(-153),
Cost = 72210000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-258),
UpdatedAt
 = DateTime.Now.AddDays(-258)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 658,
PaymentId = 258,
ProductId = 3,
ServiceId = 1,
AmoutEmployee = 32,
StartDate = DateTime.Now.AddDays(-24),
EndDate = DateTime.Now.AddDays(-23),
Cost = 1584000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-258),
UpdatedAt
 = DateTime.Now.AddDays(-258)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 659,
PaymentId = 259,
ProductId = 12,
ServiceId = 1,
AmoutEmployee = 197,
StartDate = DateTime.Now.AddDays(-93),
EndDate = DateTime.Now.AddDays(-85),
Cost = 14184000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-259),
UpdatedAt
 = DateTime.Now.AddDays(-259)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 660,
PaymentId = 259,
ProductId = 1,
ServiceId = 2,
AmoutEmployee = 47,
StartDate = DateTime.Now.AddDays(-119),
EndDate = DateTime.Now.AddDays(-108),
Cost = 22842000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-259),
UpdatedAt
 = DateTime.Now.AddDays(-259)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 661,
PaymentId = 260,
ProductId = 1,
ServiceId = 3,
AmoutEmployee = 28,
StartDate = DateTime.Now.AddDays(-177),
EndDate = DateTime.Now.AddDays(-174),
Cost = 9086000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-260),
UpdatedAt
 = DateTime.Now.AddDays(-260)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 662,
PaymentId = 260,
ProductId = 9,
ServiceId = 3,
AmoutEmployee = 89,
StartDate = DateTime.Now.AddDays(-82),
EndDate = DateTime.Now.AddDays(-67),
Cost = 1958000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-260),
UpdatedAt
 = DateTime.Now.AddDays(-260)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 663,
PaymentId = 260,
ProductId = 10,
ServiceId = 2,
AmoutEmployee = 95,
StartDate = DateTime.Now.AddDays(-132),
EndDate = DateTime.Now.AddDays(-130),
Cost = 38190000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-260),
UpdatedAt
 = DateTime.Now.AddDays(-260)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 664,
PaymentId = 261,
ProductId = 13,
ServiceId = 2,
AmoutEmployee = 160,
StartDate = DateTime.Now.AddDays(-151),
EndDate = DateTime.Now.AddDays(-136),
Cost = 126720000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-261),
UpdatedAt
 = DateTime.Now.AddDays(-261)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 665,
PaymentId = 261,
ProductId = 4,
ServiceId = 3,
AmoutEmployee = 195,
StartDate = DateTime.Now.AddDays(-40),
EndDate = DateTime.Now.AddDays(-27),
Cost = 37537500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-261),
UpdatedAt
 = DateTime.Now.AddDays(-261)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 666,
PaymentId = 262,
ProductId = 26,
ServiceId = 2,
AmoutEmployee = 62,
StartDate = DateTime.Now.AddDays(-197),
EndDate = DateTime.Now.AddDays(-182),
Cost = 20832000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-262),
UpdatedAt
 = DateTime.Now.AddDays(-262)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 667,
PaymentId = 262,
ProductId = 24,
ServiceId = 2,
AmoutEmployee = 191,
StartDate = DateTime.Now.AddDays(-98),
EndDate = DateTime.Now.AddDays(-83),
Cost = 55008000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-262),
UpdatedAt
 = DateTime.Now.AddDays(-262)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 668,
PaymentId = 262,
ProductId = 27,
ServiceId = 3,
AmoutEmployee = 60,
StartDate = DateTime.Now.AddDays(-112),
EndDate = DateTime.Now.AddDays(-99),
Cost = 23430000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-262),
UpdatedAt
 = DateTime.Now.AddDays(-262)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 669,
PaymentId = 263,
ProductId = 6,
ServiceId = 2,
AmoutEmployee = 157,
StartDate = DateTime.Now.AddDays(-137),
EndDate = DateTime.Now.AddDays(-127),
Cost = 80070000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-263),
UpdatedAt
 = DateTime.Now.AddDays(-263)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 670,
PaymentId = 263,
ProductId = 21,
ServiceId = 3,
AmoutEmployee = 118,
StartDate = DateTime.Now.AddDays(-90),
EndDate = DateTime.Now.AddDays(-77),
Cost = 10384000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-263),
UpdatedAt
 = DateTime.Now.AddDays(-263)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 671,
PaymentId = 264,
ProductId = 16,
ServiceId = 1,
AmoutEmployee = 131,
StartDate = DateTime.Now.AddDays(-28),
EndDate = DateTime.Now.AddDays(-24),
Cost = 3537000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-264),
UpdatedAt
 = DateTime.Now.AddDays(-264)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 672,
PaymentId = 264,
ProductId = 27,
ServiceId = 1,
AmoutEmployee = 79,
StartDate = DateTime.Now.AddDays(-176),
EndDate = DateTime.Now.AddDays(-174),
Cost = 26307000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-264),
UpdatedAt
 = DateTime.Now.AddDays(-264)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 673,
PaymentId = 264,
ProductId = 13,
ServiceId = 3,
AmoutEmployee = 196,
StartDate = DateTime.Now.AddDays(-8),
EndDate = DateTime.Now.AddDays(-3),
Cost = 3234000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-264),
UpdatedAt
 = DateTime.Now.AddDays(-264)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 674,
PaymentId = 265,
ProductId = 30,
ServiceId = 3,
AmoutEmployee = 59,
StartDate = DateTime.Now.AddDays(-69),
EndDate = DateTime.Now.AddDays(-54),
Cost = 7463500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-265),
UpdatedAt
 = DateTime.Now.AddDays(-265)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 675,
PaymentId = 265,
ProductId = 8,
ServiceId = 2,
AmoutEmployee = 149,
StartDate = DateTime.Now.AddDays(-85),
EndDate = DateTime.Now.AddDays(-77),
Cost = 51852000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-265),
UpdatedAt
 = DateTime.Now.AddDays(-265)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 676,
PaymentId = 265,
ProductId = 23,
ServiceId = 3,
AmoutEmployee = 114,
StartDate = DateTime.Now.AddDays(-183),
EndDate = DateTime.Now.AddDays(-171),
Cost = 89034000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-265),
UpdatedAt
 = DateTime.Now.AddDays(-265)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 677,
PaymentId = 266,
ProductId = 21,
ServiceId = 2,
AmoutEmployee = 168,
StartDate = DateTime.Now.AddDays(-186),
EndDate = DateTime.Now.AddDays(-183),
Cost = 55440000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-266),
UpdatedAt
 = DateTime.Now.AddDays(-266)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 678,
PaymentId = 266,
ProductId = 21,
ServiceId = 1,
AmoutEmployee = 196,
StartDate = DateTime.Now.AddDays(-194),
EndDate = DateTime.Now.AddDays(-186),
Cost = 138474000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-266),
UpdatedAt
 = DateTime.Now.AddDays(-266)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 679,
PaymentId = 267,
ProductId = 2,
ServiceId = 1,
AmoutEmployee = 199,
StartDate = DateTime.Now.AddDays(-91),
EndDate = DateTime.Now.AddDays(-89),
Cost = 32238000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-267),
UpdatedAt
 = DateTime.Now.AddDays(-267)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 680,
PaymentId = 267,
ProductId = 8,
ServiceId = 1,
AmoutEmployee = 184,
StartDate = DateTime.Now.AddDays(-146),
EndDate = DateTime.Now.AddDays(-143),
Cost = 12420000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-267),
UpdatedAt
 = DateTime.Now.AddDays(-267)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 681,
PaymentId = 267,
ProductId = 21,
ServiceId = 1,
AmoutEmployee = 93,
StartDate = DateTime.Now.AddDays(-109),
EndDate = DateTime.Now.AddDays(-101),
Cost = 3766500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-267),
UpdatedAt
 = DateTime.Now.AddDays(-267)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 682,
PaymentId = 268,
ProductId = 6,
ServiceId = 2,
AmoutEmployee = 157,
StartDate = DateTime.Now.AddDays(-117),
EndDate = DateTime.Now.AddDays(-116),
Cost = 98910000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-268),
UpdatedAt
 = DateTime.Now.AddDays(-268)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 683,
PaymentId = 268,
ProductId = 27,
ServiceId = 1,
AmoutEmployee = 30,
StartDate = DateTime.Now.AddDays(-196),
EndDate = DateTime.Now.AddDays(-184),
Cost = 22950000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-268),
UpdatedAt
 = DateTime.Now.AddDays(-268)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 684,
PaymentId = 269,
ProductId = 15,
ServiceId = 1,
AmoutEmployee = 89,
StartDate = DateTime.Now.AddDays(-28),
EndDate = DateTime.Now.AddDays(-20),
Cost = 8811000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-269),
UpdatedAt
 = DateTime.Now.AddDays(-269)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 685,
PaymentId = 269,
ProductId = 29,
ServiceId = 2,
AmoutEmployee = 163,
StartDate = DateTime.Now.AddDays(-179),
EndDate = DateTime.Now.AddDays(-169),
Cost = 95844000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-269),
UpdatedAt
 = DateTime.Now.AddDays(-269)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 686,
PaymentId = 269,
ProductId = 28,
ServiceId = 2,
AmoutEmployee = 194,
StartDate = DateTime.Now.AddDays(-107),
EndDate = DateTime.Now.AddDays(-104),
Cost = 4656000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-269),
UpdatedAt
 = DateTime.Now.AddDays(-269)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 687,
PaymentId = 270,
ProductId = 23,
ServiceId = 2,
AmoutEmployee = 118,
StartDate = DateTime.Now.AddDays(-92),
EndDate = DateTime.Now.AddDays(-87),
Cost = 37524000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-270),
UpdatedAt
 = DateTime.Now.AddDays(-270)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 688,
PaymentId = 270,
ProductId = 20,
ServiceId = 1,
AmoutEmployee = 46,
StartDate = DateTime.Now.AddDays(-195),
EndDate = DateTime.Now.AddDays(-189),
Cost = 31257000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-270),
UpdatedAt
 = DateTime.Now.AddDays(-270)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 689,
PaymentId = 271,
ProductId = 13,
ServiceId = 3,
AmoutEmployee = 181,
StartDate = DateTime.Now.AddDays(-95),
EndDate = DateTime.Now.AddDays(-84),
Cost = 995500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-271),
UpdatedAt
 = DateTime.Now.AddDays(-271)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 690,
PaymentId = 271,
ProductId = 23,
ServiceId = 2,
AmoutEmployee = 28,
StartDate = DateTime.Now.AddDays(-188),
EndDate = DateTime.Now.AddDays(-185),
Cost = 30576000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-271),
UpdatedAt
 = DateTime.Now.AddDays(-271)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 691,
PaymentId = 271,
ProductId = 14,
ServiceId = 2,
AmoutEmployee = 35,
StartDate = DateTime.Now.AddDays(-10),
EndDate = DateTime.Now.AddDays(-6),
Cost = 1050000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-271),
UpdatedAt
 = DateTime.Now.AddDays(-271)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 692,
PaymentId = 272,
ProductId = 10,
ServiceId = 2,
AmoutEmployee = 168,
StartDate = DateTime.Now.AddDays(-161),
EndDate = DateTime.Now.AddDays(-154),
Cost = 22176000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-272),
UpdatedAt
 = DateTime.Now.AddDays(-272)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 693,
PaymentId = 272,
ProductId = 27,
ServiceId = 1,
AmoutEmployee = 105,
StartDate = DateTime.Now.AddDays(-105),
EndDate = DateTime.Now.AddDays(-94),
Cost = 15120000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-272),
UpdatedAt
 = DateTime.Now.AddDays(-272)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 694,
PaymentId = 273,
ProductId = 13,
ServiceId = 1,
AmoutEmployee = 99,
StartDate = DateTime.Now.AddDays(-128),
EndDate = DateTime.Now.AddDays(-120),
Cost = 35194500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-273),
UpdatedAt
 = DateTime.Now.AddDays(-273)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 695,
PaymentId = 273,
ProductId = 23,
ServiceId = 2,
AmoutEmployee = 182,
StartDate = DateTime.Now.AddDays(-41),
EndDate = DateTime.Now.AddDays(-38),
Cost = 4368000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-273),
UpdatedAt
 = DateTime.Now.AddDays(-273)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 696,
PaymentId = 273,
ProductId = 22,
ServiceId = 3,
AmoutEmployee = 167,
StartDate = DateTime.Now.AddDays(-33),
EndDate = DateTime.Now.AddDays(-26),
Cost = 8266500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-273),
UpdatedAt
 = DateTime.Now.AddDays(-273)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 697,
PaymentId = 274,
ProductId = 24,
ServiceId = 1,
AmoutEmployee = 98,
StartDate = DateTime.Now.AddDays(-97),
EndDate = DateTime.Now.AddDays(-91),
Cost = 2646000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-274),
UpdatedAt
 = DateTime.Now.AddDays(-274)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 698,
PaymentId = 274,
ProductId = 10,
ServiceId = 2,
AmoutEmployee = 100,
StartDate = DateTime.Now.AddDays(-180),
EndDate = DateTime.Now.AddDays(-169),
Cost = 10800000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-274),
UpdatedAt
 = DateTime.Now.AddDays(-274)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 699,
PaymentId = 275,
ProductId = 6,
ServiceId = 3,
AmoutEmployee = 140,
StartDate = DateTime.Now.AddDays(-145),
EndDate = DateTime.Now.AddDays(-134),
Cost = 16940000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-275),
UpdatedAt
 = DateTime.Now.AddDays(-275)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 700,
PaymentId = 275,
ProductId = 13,
ServiceId = 1,
AmoutEmployee = 74,
StartDate = DateTime.Now.AddDays(-57),
EndDate = DateTime.Now.AddDays(-43),
Cost = 5994000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-275),
UpdatedAt
 = DateTime.Now.AddDays(-275)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 701,
PaymentId = 275,
ProductId = 10,
ServiceId = 2,
AmoutEmployee = 120,
StartDate = DateTime.Now.AddDays(-174),
EndDate = DateTime.Now.AddDays(-165),
Cost = 59040000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-275),
UpdatedAt
 = DateTime.Now.AddDays(-275)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 702,
PaymentId = 276,
ProductId = 6,
ServiceId = 3,
AmoutEmployee = 123,
StartDate = DateTime.Now.AddDays(-17),
EndDate = DateTime.Now.AddDays(-2),
Cost = 5412000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-276),
UpdatedAt
 = DateTime.Now.AddDays(-276)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 703,
PaymentId = 276,
ProductId = 22,
ServiceId = 2,
AmoutEmployee = 72,
StartDate = DateTime.Now.AddDays(-198),
EndDate = DateTime.Now.AddDays(-196),
Cost = 14688000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-276),
UpdatedAt
 = DateTime.Now.AddDays(-276)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 704,
PaymentId = 276,
ProductId = 21,
ServiceId = 2,
AmoutEmployee = 183,
StartDate = DateTime.Now.AddDays(-57),
EndDate = DateTime.Now.AddDays(-54),
Cost = 49410000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-276),
UpdatedAt
 = DateTime.Now.AddDays(-276)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 705,
PaymentId = 277,
ProductId = 10,
ServiceId = 3,
AmoutEmployee = 69,
StartDate = DateTime.Now.AddDays(-58),
EndDate = DateTime.Now.AddDays(-54),
Cost = 13662000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-277),
UpdatedAt
 = DateTime.Now.AddDays(-277)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 706,
PaymentId = 277,
ProductId = 4,
ServiceId = 2,
AmoutEmployee = 168,
StartDate = DateTime.Now.AddDays(-113),
EndDate = DateTime.Now.AddDays(-112),
Cost = 21168000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-277),
UpdatedAt
 = DateTime.Now.AddDays(-277)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 707,
PaymentId = 278,
ProductId = 21,
ServiceId = 2,
AmoutEmployee = 193,
StartDate = DateTime.Now.AddDays(-22),
EndDate = DateTime.Now.AddDays(-9),
Cost = 9264000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-278),
UpdatedAt
 = DateTime.Now.AddDays(-278)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 708,
PaymentId = 278,
ProductId = 5,
ServiceId = 3,
AmoutEmployee = 42,
StartDate = DateTime.Now.AddDays(-54),
EndDate = DateTime.Now.AddDays(-41),
Cost = 231000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-278),
UpdatedAt
 = DateTime.Now.AddDays(-278)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 709,
PaymentId = 278,
ProductId = 28,
ServiceId = 2,
AmoutEmployee = 82,
StartDate = DateTime.Now.AddDays(-93),
EndDate = DateTime.Now.AddDays(-92),
Cost = 12792000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-278),
UpdatedAt
 = DateTime.Now.AddDays(-278)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 710,
PaymentId = 279,
ProductId = 4,
ServiceId = 2,
AmoutEmployee = 93,
StartDate = DateTime.Now.AddDays(-191),
EndDate = DateTime.Now.AddDays(-184),
Cost = 87048000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-279),
UpdatedAt
 = DateTime.Now.AddDays(-279)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 711,
PaymentId = 279,
ProductId = 13,
ServiceId = 3,
AmoutEmployee = 150,
StartDate = DateTime.Now.AddDays(-191),
EndDate = DateTime.Now.AddDays(-180),
Cost = 88275000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-279),
UpdatedAt
 = DateTime.Now.AddDays(-279)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 712,
PaymentId = 280,
ProductId = 25,
ServiceId = 3,
AmoutEmployee = 154,
StartDate = DateTime.Now.AddDays(-104),
EndDate = DateTime.Now.AddDays(-94),
Cost = 5082000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-280),
UpdatedAt
 = DateTime.Now.AddDays(-280)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 713,
PaymentId = 280,
ProductId = 12,
ServiceId = 2,
AmoutEmployee = 179,
StartDate = DateTime.Now.AddDays(-129),
EndDate = DateTime.Now.AddDays(-127),
Cost = 93438000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-280),
UpdatedAt
 = DateTime.Now.AddDays(-280)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 714,
PaymentId = 280,
ProductId = 5,
ServiceId = 2,
AmoutEmployee = 120,
StartDate = DateTime.Now.AddDays(-72),
EndDate = DateTime.Now.AddDays(-62),
Cost = 46800000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-280),
UpdatedAt
 = DateTime.Now.AddDays(-280)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 715,
PaymentId = 281,
ProductId = 13,
ServiceId = 3,
AmoutEmployee = 129,
StartDate = DateTime.Now.AddDays(-197),
EndDate = DateTime.Now.AddDays(-183),
Cost = 47536500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-281),
UpdatedAt
 = DateTime.Now.AddDays(-281)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 716,
PaymentId = 281,
ProductId = 9,
ServiceId = 1,
AmoutEmployee = 100,
StartDate = DateTime.Now.AddDays(-154),
EndDate = DateTime.Now.AddDays(-140),
Cost = 57150000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-281),
UpdatedAt
 = DateTime.Now.AddDays(-281)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 717,
PaymentId = 282,
ProductId = 15,
ServiceId = 3,
AmoutEmployee = 183,
StartDate = DateTime.Now.AddDays(-125),
EndDate = DateTime.Now.AddDays(-114),
Cost = 41266500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-282),
UpdatedAt
 = DateTime.Now.AddDays(-282)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 718,
PaymentId = 282,
ProductId = 6,
ServiceId = 1,
AmoutEmployee = 164,
StartDate = DateTime.Now.AddDays(-145),
EndDate = DateTime.Now.AddDays(-134),
Cost = 93726000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-282),
UpdatedAt
 = DateTime.Now.AddDays(-282)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 719,
PaymentId = 282,
ProductId = 22,
ServiceId = 2,
AmoutEmployee = 57,
StartDate = DateTime.Now.AddDays(-49),
EndDate = DateTime.Now.AddDays(-38),
Cost = 12312000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-282),
UpdatedAt
 = DateTime.Now.AddDays(-282)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 720,
PaymentId = 283,
ProductId = 6,
ServiceId = 2,
AmoutEmployee = 55,
StartDate = DateTime.Now.AddDays(-167),
EndDate = DateTime.Now.AddDays(-165),
Cost = 53130000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-283),
UpdatedAt
 = DateTime.Now.AddDays(-283)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 721,
PaymentId = 283,
ProductId = 24,
ServiceId = 3,
AmoutEmployee = 51,
StartDate = DateTime.Now.AddDays(-196),
EndDate = DateTime.Now.AddDays(-187),
Cost = 46563000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-283),
UpdatedAt
 = DateTime.Now.AddDays(-283)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 722,
PaymentId = 284,
ProductId = 27,
ServiceId = 3,
AmoutEmployee = 183,
StartDate = DateTime.Now.AddDays(-120),
EndDate = DateTime.Now.AddDays(-117),
Cost = 61396500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-284),
UpdatedAt
 = DateTime.Now.AddDays(-284)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 723,
PaymentId = 284,
ProductId = 30,
ServiceId = 1,
AmoutEmployee = 68,
StartDate = DateTime.Now.AddDays(-88),
EndDate = DateTime.Now.AddDays(-87),
Cost = 14076000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-284),
UpdatedAt
 = DateTime.Now.AddDays(-284)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 724,
PaymentId = 284,
ProductId = 28,
ServiceId = 2,
AmoutEmployee = 156,
StartDate = DateTime.Now.AddDays(-73),
EndDate = DateTime.Now.AddDays(-63),
Cost = 60840000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-284),
UpdatedAt
 = DateTime.Now.AddDays(-284)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 725,
PaymentId = 285,
ProductId = 13,
ServiceId = 2,
AmoutEmployee = 51,
StartDate = DateTime.Now.AddDays(-177),
EndDate = DateTime.Now.AddDays(-165),
Cost = 46512000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-285),
UpdatedAt
 = DateTime.Now.AddDays(-285)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 726,
PaymentId = 285,
ProductId = 12,
ServiceId = 3,
AmoutEmployee = 177,
StartDate = DateTime.Now.AddDays(-166),
EndDate = DateTime.Now.AddDays(-160),
Cost = 2920500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-285),
UpdatedAt
 = DateTime.Now.AddDays(-285)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 727,
PaymentId = 286,
ProductId = 17,
ServiceId = 3,
AmoutEmployee = 98,
StartDate = DateTime.Now.AddDays(-145),
EndDate = DateTime.Now.AddDays(-130),
Cost = 52283000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-286),
UpdatedAt
 = DateTime.Now.AddDays(-286)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 728,
PaymentId = 286,
ProductId = 4,
ServiceId = 1,
AmoutEmployee = 58,
StartDate = DateTime.Now.AddDays(-87),
EndDate = DateTime.Now.AddDays(-75),
Cost = 13833000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-286),
UpdatedAt
 = DateTime.Now.AddDays(-286)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 729,
PaymentId = 286,
ProductId = 7,
ServiceId = 2,
AmoutEmployee = 91,
StartDate = DateTime.Now.AddDays(-194),
EndDate = DateTime.Now.AddDays(-179),
Cost = 52962000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-286),
UpdatedAt
 = DateTime.Now.AddDays(-286)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 730,
PaymentId = 287,
ProductId = 27,
ServiceId = 3,
AmoutEmployee = 58,
StartDate = DateTime.Now.AddDays(-73),
EndDate = DateTime.Now.AddDays(-69),
Cost = 11484000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-287),
UpdatedAt
 = DateTime.Now.AddDays(-287)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 731,
PaymentId = 287,
ProductId = 22,
ServiceId = 2,
AmoutEmployee = 130,
StartDate = DateTime.Now.AddDays(-71),
EndDate = DateTime.Now.AddDays(-63),
Cost = 39000000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-287),
UpdatedAt
 = DateTime.Now.AddDays(-287)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 732,
PaymentId = 287,
ProductId = 11,
ServiceId = 2,
AmoutEmployee = 200,
StartDate = DateTime.Now.AddDays(-58),
EndDate = DateTime.Now.AddDays(-47),
Cost = 2400000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-287),
UpdatedAt
 = DateTime.Now.AddDays(-287)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 733,
PaymentId = 288,
ProductId = 29,
ServiceId = 2,
AmoutEmployee = 145,
StartDate = DateTime.Now.AddDays(-100),
EndDate = DateTime.Now.AddDays(-86),
Cost = 26970000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-288),
UpdatedAt
 = DateTime.Now.AddDays(-288)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 734,
PaymentId = 288,
ProductId = 7,
ServiceId = 3,
AmoutEmployee = 136,
StartDate = DateTime.Now.AddDays(-75),
EndDate = DateTime.Now.AddDays(-69),
Cost = 8976000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-288),
UpdatedAt
 = DateTime.Now.AddDays(-288)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 735,
PaymentId = 289,
ProductId = 5,
ServiceId = 3,
AmoutEmployee = 101,
StartDate = DateTime.Now.AddDays(-163),
EndDate = DateTime.Now.AddDays(-152),
Cost = 51661500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-289),
UpdatedAt
 = DateTime.Now.AddDays(-289)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 736,
PaymentId = 289,
ProductId = 10,
ServiceId = 3,
AmoutEmployee = 162,
StartDate = DateTime.Now.AddDays(-67),
EndDate = DateTime.Now.AddDays(-56),
Cost = 891000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-289),
UpdatedAt
 = DateTime.Now.AddDays(-289)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 737,
PaymentId = 289,
ProductId = 13,
ServiceId = 1,
AmoutEmployee = 66,
StartDate = DateTime.Now.AddDays(-125),
EndDate = DateTime.Now.AddDays(-123),
Cost = 9801000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-289),
UpdatedAt
 = DateTime.Now.AddDays(-289)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 738,
PaymentId = 290,
ProductId = 2,
ServiceId = 3,
AmoutEmployee = 55,
StartDate = DateTime.Now.AddDays(-27),
EndDate = DateTime.Now.AddDays(-18),
Cost = 302500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-290),
UpdatedAt
 = DateTime.Now.AddDays(-290)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 739,
PaymentId = 290,
ProductId = 5,
ServiceId = 3,
AmoutEmployee = 170,
StartDate = DateTime.Now.AddDays(-130),
EndDate = DateTime.Now.AddDays(-117),
Cost = 38335000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-290),
UpdatedAt
 = DateTime.Now.AddDays(-290)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 740,
PaymentId = 291,
ProductId = 30,
ServiceId = 3,
AmoutEmployee = 34,
StartDate = DateTime.Now.AddDays(-46),
EndDate = DateTime.Now.AddDays(-44),
Cost = 7480000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-291),
UpdatedAt
 = DateTime.Now.AddDays(-291)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 741,
PaymentId = 291,
ProductId = 19,
ServiceId = 1,
AmoutEmployee = 63,
StartDate = DateTime.Now.AddDays(-130),
EndDate = DateTime.Now.AddDays(-126),
Cost = 5953500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-291),
UpdatedAt
 = DateTime.Now.AddDays(-291)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 742,
PaymentId = 291,
ProductId = 8,
ServiceId = 2,
AmoutEmployee = 106,
StartDate = DateTime.Now.AddDays(-101),
EndDate = DateTime.Now.AddDays(-91),
Cost = 60420000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-291),
UpdatedAt
 = DateTime.Now.AddDays(-291)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 743,
PaymentId = 292,
ProductId = 1,
ServiceId = 3,
AmoutEmployee = 94,
StartDate = DateTime.Now.AddDays(-61),
EndDate = DateTime.Now.AddDays(-51),
Cost = 13959000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-292),
UpdatedAt
 = DateTime.Now.AddDays(-292)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 744,
PaymentId = 292,
ProductId = 4,
ServiceId = 1,
AmoutEmployee = 85,
StartDate = DateTime.Now.AddDays(-153),
EndDate = DateTime.Now.AddDays(-145),
Cost = 382500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-292),
UpdatedAt
 = DateTime.Now.AddDays(-292)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 745,
PaymentId = 293,
ProductId = 19,
ServiceId = 3,
AmoutEmployee = 133,
StartDate = DateTime.Now.AddDays(-85),
EndDate = DateTime.Now.AddDays(-83),
Cost = 20482000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-293),
UpdatedAt
 = DateTime.Now.AddDays(-293)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 746,
PaymentId = 293,
ProductId = 9,
ServiceId = 2,
AmoutEmployee = 165,
StartDate = DateTime.Now.AddDays(-165),
EndDate = DateTime.Now.AddDays(-160),
Cost = 128700000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-293),
UpdatedAt
 = DateTime.Now.AddDays(-293)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 747,
PaymentId = 293,
ProductId = 27,
ServiceId = 1,
AmoutEmployee = 36,
StartDate = DateTime.Now.AddDays(-178),
EndDate = DateTime.Now.AddDays(-164),
Cost = 13932000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-293),
UpdatedAt
 = DateTime.Now.AddDays(-293)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 748,
PaymentId = 294,
ProductId = 5,
ServiceId = 1,
AmoutEmployee = 41,
StartDate = DateTime.Now.AddDays(-174),
EndDate = DateTime.Now.AddDays(-171),
Cost = 9040500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-294),
UpdatedAt
 = DateTime.Now.AddDays(-294)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 749,
PaymentId = 294,
ProductId = 27,
ServiceId = 1,
AmoutEmployee = 80,
StartDate = DateTime.Now.AddDays(-40),
EndDate = DateTime.Now.AddDays(-38),
Cost = 11520000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-294),
UpdatedAt
 = DateTime.Now.AddDays(-294)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 750,
PaymentId = 295,
ProductId = 29,
ServiceId = 2,
AmoutEmployee = 148,
StartDate = DateTime.Now.AddDays(-140),
EndDate = DateTime.Now.AddDays(-131),
Cost = 72816000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-295),
UpdatedAt
 = DateTime.Now.AddDays(-295)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 751,
PaymentId = 295,
ProductId = 9,
ServiceId = 1,
AmoutEmployee = 185,
StartDate = DateTime.Now.AddDays(-63),
EndDate = DateTime.Now.AddDays(-60),
Cost = 39127500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-295),
UpdatedAt
 = DateTime.Now.AddDays(-295)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 752,
PaymentId = 295,
ProductId = 23,
ServiceId = 2,
AmoutEmployee = 175,
StartDate = DateTime.Now.AddDays(-149),
EndDate = DateTime.Now.AddDays(-144),
Cost = 35700000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-295),
UpdatedAt
 = DateTime.Now.AddDays(-295)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 753,
PaymentId = 296,
ProductId = 8,
ServiceId = 1,
AmoutEmployee = 186,
StartDate = DateTime.Now.AddDays(-194),
EndDate = DateTime.Now.AddDays(-189),
Cost = 146475000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-296),
UpdatedAt
 = DateTime.Now.AddDays(-296)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 754,
PaymentId = 296,
ProductId = 21,
ServiceId = 2,
AmoutEmployee = 105,
StartDate = DateTime.Now.AddDays(-156),
EndDate = DateTime.Now.AddDays(-142),
Cost = 15750000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-296),
UpdatedAt
 = DateTime.Now.AddDays(-296)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 755,
PaymentId = 297,
ProductId = 17,
ServiceId = 2,
AmoutEmployee = 145,
StartDate = DateTime.Now.AddDays(-17),
EndDate = DateTime.Now.AddDays(-5),
Cost = 6090000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-297),
UpdatedAt
 = DateTime.Now.AddDays(-297)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 756,
PaymentId = 297,
ProductId = 5,
ServiceId = 2,
AmoutEmployee = 198,
StartDate = DateTime.Now.AddDays(-26),
EndDate = DateTime.Now.AddDays(-24),
Cost = 11880000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-297),
UpdatedAt
 = DateTime.Now.AddDays(-297)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 757,
PaymentId = 297,
ProductId = 27,
ServiceId = 3,
AmoutEmployee = 81,
StartDate = DateTime.Now.AddDays(-169),
EndDate = DateTime.Now.AddDays(-154),
Cost = 445500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-297),
UpdatedAt
 = DateTime.Now.AddDays(-297)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 758,
PaymentId = 298,
ProductId = 20,
ServiceId = 3,
AmoutEmployee = 86,
StartDate = DateTime.Now.AddDays(-178),
EndDate = DateTime.Now.AddDays(-173),
Cost = 80410000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-298),
UpdatedAt
 = DateTime.Now.AddDays(-298)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 759,
PaymentId = 298,
ProductId = 4,
ServiceId = 1,
AmoutEmployee = 62,
StartDate = DateTime.Now.AddDays(-129),
EndDate = DateTime.Now.AddDays(-123),
Cost = 4464000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-298),
UpdatedAt
 = DateTime.Now.AddDays(-298)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 760,
PaymentId = 298,
ProductId = 27,
ServiceId = 1,
AmoutEmployee = 112,
StartDate = DateTime.Now.AddDays(-49),
EndDate = DateTime.Now.AddDays(-36),
Cost = 10584000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-298),
UpdatedAt
 = DateTime.Now.AddDays(-298)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 761,
PaymentId = 299,
ProductId = 27,
ServiceId = 2,
AmoutEmployee = 79,
StartDate = DateTime.Now.AddDays(-152),
EndDate = DateTime.Now.AddDays(-144),
Cost = 16590000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-299),
UpdatedAt
 = DateTime.Now.AddDays(-299)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 762,
PaymentId = 299,
ProductId = 9,
ServiceId = 3,
AmoutEmployee = 42,
StartDate = DateTime.Now.AddDays(-154),
EndDate = DateTime.Now.AddDays(-149),
Cost = 25872000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-299),
UpdatedAt
 = DateTime.Now.AddDays(-299)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 763,
PaymentId = 300,
ProductId = 28,
ServiceId = 1,
AmoutEmployee = 61,
StartDate = DateTime.Now.AddDays(-192),
EndDate = DateTime.Now.AddDays(-181),
Cost = 1098000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-300),
UpdatedAt
 = DateTime.Now.AddDays(-300)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 764,
PaymentId = 300,
ProductId = 11,
ServiceId = 1,
AmoutEmployee = 180,
StartDate = DateTime.Now.AddDays(-178),
EndDate = DateTime.Now.AddDays(-175),
Cost = 57510000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-300),
UpdatedAt
 = DateTime.Now.AddDays(-300)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 765,
PaymentId = 300,
ProductId = 25,
ServiceId = 3,
AmoutEmployee = 195,
StartDate = DateTime.Now.AddDays(-193),
EndDate = DateTime.Now.AddDays(-191),
Cost = 168382500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-300),
UpdatedAt
 = DateTime.Now.AddDays(-300)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 766,
PaymentId = 301,
ProductId = 11,
ServiceId = 1,
AmoutEmployee = 171,
StartDate = DateTime.Now.AddDays(-60),
EndDate = DateTime.Now.AddDays(-50),
Cost = 3847500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-301),
UpdatedAt
 = DateTime.Now.AddDays(-301)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 767,
PaymentId = 301,
ProductId = 19,
ServiceId = 3,
AmoutEmployee = 140,
StartDate = DateTime.Now.AddDays(-195),
EndDate = DateTime.Now.AddDays(-189),
Cost = 40040000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-301),
UpdatedAt
 = DateTime.Now.AddDays(-301)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 768,
PaymentId = 302,
ProductId = 3,
ServiceId = 2,
AmoutEmployee = 132,
StartDate = DateTime.Now.AddDays(-128),
EndDate = DateTime.Now.AddDays(-116),
Cost = 47520000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-302),
UpdatedAt
 = DateTime.Now.AddDays(-302)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 769,
PaymentId = 302,
ProductId = 18,
ServiceId = 1,
AmoutEmployee = 192,
StartDate = DateTime.Now.AddDays(-43),
EndDate = DateTime.Now.AddDays(-31),
Cost = 6912000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-302),
UpdatedAt
 = DateTime.Now.AddDays(-302)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 770,
PaymentId = 302,
ProductId = 21,
ServiceId = 2,
AmoutEmployee = 28,
StartDate = DateTime.Now.AddDays(-33),
EndDate = DateTime.Now.AddDays(-32),
Cost = 840000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-302),
UpdatedAt
 = DateTime.Now.AddDays(-302)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 771,
PaymentId = 303,
ProductId = 11,
ServiceId = 2,
AmoutEmployee = 57,
StartDate = DateTime.Now.AddDays(-183),
EndDate = DateTime.Now.AddDays(-172),
Cost = 27018000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-303),
UpdatedAt
 = DateTime.Now.AddDays(-303)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 772,
PaymentId = 303,
ProductId = 12,
ServiceId = 3,
AmoutEmployee = 124,
StartDate = DateTime.Now.AddDays(-180),
EndDate = DateTime.Now.AddDays(-171),
Cost = 60698000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-303),
UpdatedAt
 = DateTime.Now.AddDays(-303)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 773,
PaymentId = 304,
ProductId = 10,
ServiceId = 1,
AmoutEmployee = 26,
StartDate = DateTime.Now.AddDays(-161),
EndDate = DateTime.Now.AddDays(-147),
Cost = 11583000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-304),
UpdatedAt
 = DateTime.Now.AddDays(-304)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 774,
PaymentId = 304,
ProductId = 6,
ServiceId = 2,
AmoutEmployee = 67,
StartDate = DateTime.Now.AddDays(-49),
EndDate = DateTime.Now.AddDays(-40),
Cost = 14070000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-304),
UpdatedAt
 = DateTime.Now.AddDays(-304)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 775,
PaymentId = 304,
ProductId = 20,
ServiceId = 3,
AmoutEmployee = 121,
StartDate = DateTime.Now.AddDays(-91),
EndDate = DateTime.Now.AddDays(-77),
Cost = 45254000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-304),
UpdatedAt
 = DateTime.Now.AddDays(-304)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 776,
PaymentId = 305,
ProductId = 8,
ServiceId = 1,
AmoutEmployee = 38,
StartDate = DateTime.Now.AddDays(-200),
EndDate = DateTime.Now.AddDays(-188),
Cost = 12996000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-305),
UpdatedAt
 = DateTime.Now.AddDays(-305)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 777,
PaymentId = 305,
ProductId = 9,
ServiceId = 2,
AmoutEmployee = 81,
StartDate = DateTime.Now.AddDays(-186),
EndDate = DateTime.Now.AddDays(-184),
Cost = 57834000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-305),
UpdatedAt
 = DateTime.Now.AddDays(-305)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 778,
PaymentId = 306,
ProductId = 5,
ServiceId = 2,
AmoutEmployee = 44,
StartDate = DateTime.Now.AddDays(-34),
EndDate = DateTime.Now.AddDays(-33),
Cost = 6336000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-306),
UpdatedAt
 = DateTime.Now.AddDays(-306)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 779,
PaymentId = 306,
ProductId = 13,
ServiceId = 3,
AmoutEmployee = 95,
StartDate = DateTime.Now.AddDays(-175),
EndDate = DateTime.Now.AddDays(-165),
Cost = 16720000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-306),
UpdatedAt
 = DateTime.Now.AddDays(-306)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 780,
PaymentId = 306,
ProductId = 2,
ServiceId = 3,
AmoutEmployee = 57,
StartDate = DateTime.Now.AddDays(-184),
EndDate = DateTime.Now.AddDays(-173),
Cost = 45771000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-306),
UpdatedAt
 = DateTime.Now.AddDays(-306)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 781,
PaymentId = 307,
ProductId = 29,
ServiceId = 2,
AmoutEmployee = 159,
StartDate = DateTime.Now.AddDays(-49),
EndDate = DateTime.Now.AddDays(-39),
Cost = 26712000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-307),
UpdatedAt
 = DateTime.Now.AddDays(-307)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 782,
PaymentId = 307,
ProductId = 1,
ServiceId = 2,
AmoutEmployee = 104,
StartDate = DateTime.Now.AddDays(-139),
EndDate = DateTime.Now.AddDays(-128),
Cost = 28704000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-307),
UpdatedAt
 = DateTime.Now.AddDays(-307)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 783,
PaymentId = 308,
ProductId = 20,
ServiceId = 2,
AmoutEmployee = 64,
StartDate = DateTime.Now.AddDays(-24),
EndDate = DateTime.Now.AddDays(-17),
Cost = 4992000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-308),
UpdatedAt
 = DateTime.Now.AddDays(-308)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 784,
PaymentId = 308,
ProductId = 28,
ServiceId = 3,
AmoutEmployee = 109,
StartDate = DateTime.Now.AddDays(-77),
EndDate = DateTime.Now.AddDays(-71),
Cost = 34771000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-308),
UpdatedAt
 = DateTime.Now.AddDays(-308)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 785,
PaymentId = 308,
ProductId = 11,
ServiceId = 2,
AmoutEmployee = 191,
StartDate = DateTime.Now.AddDays(-116),
EndDate = DateTime.Now.AddDays(-102),
Cost = 93972000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-308),
UpdatedAt
 = DateTime.Now.AddDays(-308)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 786,
PaymentId = 309,
ProductId = 25,
ServiceId = 2,
AmoutEmployee = 180,
StartDate = DateTime.Now.AddDays(-33),
EndDate = DateTime.Now.AddDays(-24),
Cost = 23760000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-309),
UpdatedAt
 = DateTime.Now.AddDays(-309)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 787,
PaymentId = 309,
ProductId = 29,
ServiceId = 3,
AmoutEmployee = 67,
StartDate = DateTime.Now.AddDays(-177),
EndDate = DateTime.Now.AddDays(-172),
Cost = 368500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-309),
UpdatedAt
 = DateTime.Now.AddDays(-309)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 788,
PaymentId = 309,
ProductId = 24,
ServiceId = 1,
AmoutEmployee = 116,
StartDate = DateTime.Now.AddDays(-151),
EndDate = DateTime.Now.AddDays(-136),
Cost = 45936000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-309),
UpdatedAt
 = DateTime.Now.AddDays(-309)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 789,
PaymentId = 310,
ProductId = 22,
ServiceId = 2,
AmoutEmployee = 127,
StartDate = DateTime.Now.AddDays(-31),
EndDate = DateTime.Now.AddDays(-28),
Cost = 15240000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-310),
UpdatedAt
 = DateTime.Now.AddDays(-310)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 790,
PaymentId = 310,
ProductId = 21,
ServiceId = 2,
AmoutEmployee = 43,
StartDate = DateTime.Now.AddDays(-160),
EndDate = DateTime.Now.AddDays(-148),
Cost = 1806000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-310),
UpdatedAt
 = DateTime.Now.AddDays(-310)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 791,
PaymentId = 311,
ProductId = 13,
ServiceId = 3,
AmoutEmployee = 177,
StartDate = DateTime.Now.AddDays(-168),
EndDate = DateTime.Now.AddDays(-159),
Cost = 98323500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-311),
UpdatedAt
 = DateTime.Now.AddDays(-311)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 792,
PaymentId = 311,
ProductId = 13,
ServiceId = 3,
AmoutEmployee = 153,
StartDate = DateTime.Now.AddDays(-163),
EndDate = DateTime.Now.AddDays(-153),
Cost = 58063500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-311),
UpdatedAt
 = DateTime.Now.AddDays(-311)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 793,
PaymentId = 311,
ProductId = 17,
ServiceId = 2,
AmoutEmployee = 95,
StartDate = DateTime.Now.AddDays(-80),
EndDate = DateTime.Now.AddDays(-67),
Cost = 30210000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-311),
UpdatedAt
 = DateTime.Now.AddDays(-311)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 794,
PaymentId = 312,
ProductId = 1,
ServiceId = 1,
AmoutEmployee = 134,
StartDate = DateTime.Now.AddDays(-19),
EndDate = DateTime.Now.AddDays(-17),
Cost = 3015000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-312),
UpdatedAt
 = DateTime.Now.AddDays(-312)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 795,
PaymentId = 312,
ProductId = 4,
ServiceId = 3,
AmoutEmployee = 33,
StartDate = DateTime.Now.AddDays(-16),
EndDate = DateTime.Now.AddDays(-4),
Cost = 1452000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-312),
UpdatedAt
 = DateTime.Now.AddDays(-312)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 796,
PaymentId = 313,
ProductId = 14,
ServiceId = 2,
AmoutEmployee = 188,
StartDate = DateTime.Now.AddDays(-29),
EndDate = DateTime.Now.AddDays(-28),
Cost = 5640000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-313),
UpdatedAt
 = DateTime.Now.AddDays(-313)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 797,
PaymentId = 313,
ProductId = 26,
ServiceId = 3,
AmoutEmployee = 105,
StartDate = DateTime.Now.AddDays(-33),
EndDate = DateTime.Now.AddDays(-24),
Cost = 15592500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-313),
UpdatedAt
 = DateTime.Now.AddDays(-313)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 798,
PaymentId = 313,
ProductId = 26,
ServiceId = 2,
AmoutEmployee = 88,
StartDate = DateTime.Now.AddDays(-191),
EndDate = DateTime.Now.AddDays(-186),
Cost = 13200000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-313),
UpdatedAt
 = DateTime.Now.AddDays(-313)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 799,
PaymentId = 314,
ProductId = 23,
ServiceId = 1,
AmoutEmployee = 116,
StartDate = DateTime.Now.AddDays(-43),
EndDate = DateTime.Now.AddDays(-31),
Cost = 15138000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-314),
UpdatedAt
 = DateTime.Now.AddDays(-314)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 800,
PaymentId = 314,
ProductId = 22,
ServiceId = 2,
AmoutEmployee = 195,
StartDate = DateTime.Now.AddDays(-158),
EndDate = DateTime.Now.AddDays(-144),
Cost = 170820000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-314),
UpdatedAt
 = DateTime.Now.AddDays(-314)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 801,
PaymentId = 315,
ProductId = 17,
ServiceId = 3,
AmoutEmployee = 62,
StartDate = DateTime.Now.AddDays(-125),
EndDate = DateTime.Now.AddDays(-120),
Cost = 21483000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-315),
UpdatedAt
 = DateTime.Now.AddDays(-315)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 802,
PaymentId = 315,
ProductId = 26,
ServiceId = 3,
AmoutEmployee = 86,
StartDate = DateTime.Now.AddDays(-174),
EndDate = DateTime.Now.AddDays(-163),
Cost = 48719000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-315),
UpdatedAt
 = DateTime.Now.AddDays(-315)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 803,
PaymentId = 315,
ProductId = 13,
ServiceId = 1,
AmoutEmployee = 166,
StartDate = DateTime.Now.AddDays(-149),
EndDate = DateTime.Now.AddDays(-135),
Cost = 15687000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-315),
UpdatedAt
 = DateTime.Now.AddDays(-315)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 804,
PaymentId = 316,
ProductId = 14,
ServiceId = 1,
AmoutEmployee = 113,
StartDate = DateTime.Now.AddDays(-194),
EndDate = DateTime.Now.AddDays(-183),
Cost = 80851500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-316),
UpdatedAt
 = DateTime.Now.AddDays(-316)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 805,
PaymentId = 316,
ProductId = 22,
ServiceId = 3,
AmoutEmployee = 92,
StartDate = DateTime.Now.AddDays(-24),
EndDate = DateTime.Now.AddDays(-14),
Cost = 5566000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-316),
UpdatedAt
 = DateTime.Now.AddDays(-316)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 806,
PaymentId = 317,
ProductId = 27,
ServiceId = 1,
AmoutEmployee = 176,
StartDate = DateTime.Now.AddDays(-19),
EndDate = DateTime.Now.AddDays(-10),
Cost = 792000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-317),
UpdatedAt
 = DateTime.Now.AddDays(-317)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 807,
PaymentId = 317,
ProductId = 17,
ServiceId = 1,
AmoutEmployee = 74,
StartDate = DateTime.Now.AddDays(-94),
EndDate = DateTime.Now.AddDays(-91),
Cost = 25641000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-317),
UpdatedAt
 = DateTime.Now.AddDays(-317)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 808,
PaymentId = 317,
ProductId = 5,
ServiceId = 1,
AmoutEmployee = 183,
StartDate = DateTime.Now.AddDays(-22),
EndDate = DateTime.Now.AddDays(-14),
Cost = 1647000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-317),
UpdatedAt
 = DateTime.Now.AddDays(-317)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 809,
PaymentId = 318,
ProductId = 6,
ServiceId = 2,
AmoutEmployee = 36,
StartDate = DateTime.Now.AddDays(-153),
EndDate = DateTime.Now.AddDays(-142),
Cost = 24408000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-318),
UpdatedAt
 = DateTime.Now.AddDays(-318)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 810,
PaymentId = 318,
ProductId = 25,
ServiceId = 2,
AmoutEmployee = 136,
StartDate = DateTime.Now.AddDays(-32),
EndDate = DateTime.Now.AddDays(-20),
Cost = 11424000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-318),
UpdatedAt
 = DateTime.Now.AddDays(-318)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 811,
PaymentId = 319,
ProductId = 8,
ServiceId = 1,
AmoutEmployee = 120,
StartDate = DateTime.Now.AddDays(-76),
EndDate = DateTime.Now.AddDays(-70),
Cost = 10260000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-319),
UpdatedAt
 = DateTime.Now.AddDays(-319)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 812,
PaymentId = 319,
ProductId = 25,
ServiceId = 1,
AmoutEmployee = 47,
StartDate = DateTime.Now.AddDays(-154),
EndDate = DateTime.Now.AddDays(-144),
Cost = 30667500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-319),
UpdatedAt
 = DateTime.Now.AddDays(-319)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 813,
PaymentId = 319,
ProductId = 16,
ServiceId = 1,
AmoutEmployee = 55,
StartDate = DateTime.Now.AddDays(-149),
EndDate = DateTime.Now.AddDays(-135),
Cost = 25987500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-319),
UpdatedAt
 = DateTime.Now.AddDays(-319)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 814,
PaymentId = 320,
ProductId = 1,
ServiceId = 2,
AmoutEmployee = 86,
StartDate = DateTime.Now.AddDays(-65),
EndDate = DateTime.Now.AddDays(-61),
Cost = 3096000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-320),
UpdatedAt
 = DateTime.Now.AddDays(-320)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 815,
PaymentId = 320,
ProductId = 28,
ServiceId = 2,
AmoutEmployee = 127,
StartDate = DateTime.Now.AddDays(-160),
EndDate = DateTime.Now.AddDays(-156),
Cost = 11430000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-320),
UpdatedAt
 = DateTime.Now.AddDays(-320)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 816,
PaymentId = 320,
ProductId = 12,
ServiceId = 1,
AmoutEmployee = 182,
StartDate = DateTime.Now.AddDays(-15),
EndDate = DateTime.Now.AddDays(-7),
Cost = 4914000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-320),
UpdatedAt
 = DateTime.Now.AddDays(-320)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 817,
PaymentId = 321,
ProductId = 2,
ServiceId = 1,
AmoutEmployee = 121,
StartDate = DateTime.Now.AddDays(-77),
EndDate = DateTime.Now.AddDays(-74),
Cost = 30492000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-321),
UpdatedAt
 = DateTime.Now.AddDays(-321)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 818,
PaymentId = 321,
ProductId = 30,
ServiceId = 2,
AmoutEmployee = 70,
StartDate = DateTime.Now.AddDays(-124),
EndDate = DateTime.Now.AddDays(-123),
Cost = 34020000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-321),
UpdatedAt
 = DateTime.Now.AddDays(-321)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 819,
PaymentId = 322,
ProductId = 24,
ServiceId = 3,
AmoutEmployee = 56,
StartDate = DateTime.Now.AddDays(-73),
EndDate = DateTime.Now.AddDays(-65),
Cost = 7700000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-322),
UpdatedAt
 = DateTime.Now.AddDays(-322)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 820,
PaymentId = 322,
ProductId = 27,
ServiceId = 2,
AmoutEmployee = 126,
StartDate = DateTime.Now.AddDays(-51),
EndDate = DateTime.Now.AddDays(-37),
Cost = 6804000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-322),
UpdatedAt
 = DateTime.Now.AddDays(-322)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 821,
PaymentId = 322,
ProductId = 29,
ServiceId = 3,
AmoutEmployee = 169,
StartDate = DateTime.Now.AddDays(-60),
EndDate = DateTime.Now.AddDays(-50),
Cost = 39039000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-322),
UpdatedAt
 = DateTime.Now.AddDays(-322)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 822,
PaymentId = 323,
ProductId = 10,
ServiceId = 1,
AmoutEmployee = 167,
StartDate = DateTime.Now.AddDays(-199),
EndDate = DateTime.Now.AddDays(-198),
Cost = 39078000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-323),
UpdatedAt
 = DateTime.Now.AddDays(-323)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 823,
PaymentId = 323,
ProductId = 7,
ServiceId = 2,
AmoutEmployee = 47,
StartDate = DateTime.Now.AddDays(-142),
EndDate = DateTime.Now.AddDays(-136),
Cost = 25098000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-323),
UpdatedAt
 = DateTime.Now.AddDays(-323)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 824,
PaymentId = 324,
ProductId = 13,
ServiceId = 1,
AmoutEmployee = 116,
StartDate = DateTime.Now.AddDays(-97),
EndDate = DateTime.Now.AddDays(-88),
Cost = 41760000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-324),
UpdatedAt
 = DateTime.Now.AddDays(-324)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 825,
PaymentId = 324,
ProductId = 27,
ServiceId = 1,
AmoutEmployee = 50,
StartDate = DateTime.Now.AddDays(-174),
EndDate = DateTime.Now.AddDays(-170),
Cost = 6075000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-324),
UpdatedAt
 = DateTime.Now.AddDays(-324)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 826,
PaymentId = 324,
ProductId = 22,
ServiceId = 3,
AmoutEmployee = 84,
StartDate = DateTime.Now.AddDays(-23),
EndDate = DateTime.Now.AddDays(-21),
Cost = 2310000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-324),
UpdatedAt
 = DateTime.Now.AddDays(-324)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 827,
PaymentId = 325,
ProductId = 8,
ServiceId = 2,
AmoutEmployee = 170,
StartDate = DateTime.Now.AddDays(-147),
EndDate = DateTime.Now.AddDays(-143),
Cost = 9180000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-325),
UpdatedAt
 = DateTime.Now.AddDays(-325)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 828,
PaymentId = 325,
ProductId = 26,
ServiceId = 2,
AmoutEmployee = 147,
StartDate = DateTime.Now.AddDays(-14),
EndDate = DateTime.Now.AddDays(0),
Cost = 7938000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-325),
UpdatedAt
 = DateTime.Now.AddDays(-325)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 829,
PaymentId = 326,
ProductId = 1,
ServiceId = 2,
AmoutEmployee = 137,
StartDate = DateTime.Now.AddDays(-29),
EndDate = DateTime.Now.AddDays(-17),
Cost = 4932000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-326),
UpdatedAt
 = DateTime.Now.AddDays(-326)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 830,
PaymentId = 326,
ProductId = 1,
ServiceId = 3,
AmoutEmployee = 61,
StartDate = DateTime.Now.AddDays(-22),
EndDate = DateTime.Now.AddDays(-7),
Cost = 3690500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-326),
UpdatedAt
 = DateTime.Now.AddDays(-326)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 831,
PaymentId = 326,
ProductId = 11,
ServiceId = 2,
AmoutEmployee = 168,
StartDate = DateTime.Now.AddDays(-70),
EndDate = DateTime.Now.AddDays(-66),
Cost = 35280000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-326),
UpdatedAt
 = DateTime.Now.AddDays(-326)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 832,
PaymentId = 327,
ProductId = 18,
ServiceId = 2,
AmoutEmployee = 89,
StartDate = DateTime.Now.AddDays(-147),
EndDate = DateTime.Now.AddDays(-140),
Cost = 61944000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-327),
UpdatedAt
 = DateTime.Now.AddDays(-327)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 833,
PaymentId = 327,
ProductId = 27,
ServiceId = 2,
AmoutEmployee = 99,
StartDate = DateTime.Now.AddDays(-186),
EndDate = DateTime.Now.AddDays(-178),
Cost = 103356000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-327),
UpdatedAt
 = DateTime.Now.AddDays(-327)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 834,
PaymentId = 328,
ProductId = 7,
ServiceId = 1,
AmoutEmployee = 112,
StartDate = DateTime.Now.AddDays(-16),
EndDate = DateTime.Now.AddDays(-6),
Cost = 5040000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-328),
UpdatedAt
 = DateTime.Now.AddDays(-328)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 835,
PaymentId = 328,
ProductId = 28,
ServiceId = 2,
AmoutEmployee = 143,
StartDate = DateTime.Now.AddDays(-176),
EndDate = DateTime.Now.AddDays(-169),
Cost = 104676000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-328),
UpdatedAt
 = DateTime.Now.AddDays(-328)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 836,
PaymentId = 328,
ProductId = 25,
ServiceId = 2,
AmoutEmployee = 84,
StartDate = DateTime.Now.AddDays(-195),
EndDate = DateTime.Now.AddDays(-188),
Cost = 26208000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-328),
UpdatedAt
 = DateTime.Now.AddDays(-328)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 837,
PaymentId = 329,
ProductId = 24,
ServiceId = 3,
AmoutEmployee = 149,
StartDate = DateTime.Now.AddDays(-89),
EndDate = DateTime.Now.AddDays(-80),
Cost = 5736500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-329),
UpdatedAt
 = DateTime.Now.AddDays(-329)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 838,
PaymentId = 329,
ProductId = 30,
ServiceId = 2,
AmoutEmployee = 38,
StartDate = DateTime.Now.AddDays(-126),
EndDate = DateTime.Now.AddDays(-114),
Cost = 4560000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-329),
UpdatedAt
 = DateTime.Now.AddDays(-329)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 839,
PaymentId = 330,
ProductId = 9,
ServiceId = 2,
AmoutEmployee = 156,
StartDate = DateTime.Now.AddDays(-60),
EndDate = DateTime.Now.AddDays(-45),
Cost = 46800000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-330),
UpdatedAt
 = DateTime.Now.AddDays(-330)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 840,
PaymentId = 330,
ProductId = 16,
ServiceId = 1,
AmoutEmployee = 64,
StartDate = DateTime.Now.AddDays(-117),
EndDate = DateTime.Now.AddDays(-112),
Cost = 15840000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-330),
UpdatedAt
 = DateTime.Now.AddDays(-330)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 841,
PaymentId = 330,
ProductId = 6,
ServiceId = 1,
AmoutEmployee = 104,
StartDate = DateTime.Now.AddDays(-166),
EndDate = DateTime.Now.AddDays(-160),
Cost = 14508000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-330),
UpdatedAt
 = DateTime.Now.AddDays(-330)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 842,
PaymentId = 331,
ProductId = 23,
ServiceId = 3,
AmoutEmployee = 29,
StartDate = DateTime.Now.AddDays(-142),
EndDate = DateTime.Now.AddDays(-131),
Cost = 16109500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-331),
UpdatedAt
 = DateTime.Now.AddDays(-331)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 843,
PaymentId = 331,
ProductId = 3,
ServiceId = 1,
AmoutEmployee = 27,
StartDate = DateTime.Now.AddDays(-186),
EndDate = DateTime.Now.AddDays(-178),
Cost = 20898000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-331),
UpdatedAt
 = DateTime.Now.AddDays(-331)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 844,
PaymentId = 331,
ProductId = 17,
ServiceId = 1,
AmoutEmployee = 151,
StartDate = DateTime.Now.AddDays(-18),
EndDate = DateTime.Now.AddDays(-4),
Cost = 5436000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-331),
UpdatedAt
 = DateTime.Now.AddDays(-331)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 845,
PaymentId = 332,
ProductId = 20,
ServiceId = 1,
AmoutEmployee = 105,
StartDate = DateTime.Now.AddDays(-189),
EndDate = DateTime.Now.AddDays(-179),
Cost = 70402500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-332),
UpdatedAt
 = DateTime.Now.AddDays(-332)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 846,
PaymentId = 332,
ProductId = 12,
ServiceId = 1,
AmoutEmployee = 125,
StartDate = DateTime.Now.AddDays(-188),
EndDate = DateTime.Now.AddDays(-187),
Cost = 86062500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-332),
UpdatedAt
 = DateTime.Now.AddDays(-332)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 847,
PaymentId = 333,
ProductId = 1,
ServiceId = 3,
AmoutEmployee = 58,
StartDate = DateTime.Now.AddDays(-50),
EndDate = DateTime.Now.AddDays(-42),
Cost = 7975000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-333),
UpdatedAt
 = DateTime.Now.AddDays(-333)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 848,
PaymentId = 333,
ProductId = 24,
ServiceId = 2,
AmoutEmployee = 43,
StartDate = DateTime.Now.AddDays(-44),
EndDate = DateTime.Now.AddDays(-41),
Cost = 1290000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-333),
UpdatedAt
 = DateTime.Now.AddDays(-333)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 849,
PaymentId = 333,
ProductId = 25,
ServiceId = 3,
AmoutEmployee = 28,
StartDate = DateTime.Now.AddDays(-68),
EndDate = DateTime.Now.AddDays(-55),
Cost = 1540000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-333),
UpdatedAt
 = DateTime.Now.AddDays(-333)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 850,
PaymentId = 334,
ProductId = 12,
ServiceId = 2,
AmoutEmployee = 69,
StartDate = DateTime.Now.AddDays(-167),
EndDate = DateTime.Now.AddDays(-160),
Cost = 34362000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-334),
UpdatedAt
 = DateTime.Now.AddDays(-334)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 851,
PaymentId = 334,
ProductId = 7,
ServiceId = 3,
AmoutEmployee = 38,
StartDate = DateTime.Now.AddDays(-59),
EndDate = DateTime.Now.AddDays(-49),
Cost = 3971000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-334),
UpdatedAt
 = DateTime.Now.AddDays(-334)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 852,
PaymentId = 335,
ProductId = 2,
ServiceId = 2,
AmoutEmployee = 58,
StartDate = DateTime.Now.AddDays(-25),
EndDate = DateTime.Now.AddDays(-17),
Cost = 6264000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-335),
UpdatedAt
 = DateTime.Now.AddDays(-335)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 853,
PaymentId = 335,
ProductId = 24,
ServiceId = 2,
AmoutEmployee = 83,
StartDate = DateTime.Now.AddDays(-116),
EndDate = DateTime.Now.AddDays(-111),
Cost = 12948000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-335),
UpdatedAt
 = DateTime.Now.AddDays(-335)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 854,
PaymentId = 335,
ProductId = 9,
ServiceId = 2,
AmoutEmployee = 154,
StartDate = DateTime.Now.AddDays(-168),
EndDate = DateTime.Now.AddDays(-158),
Cost = 48048000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-335),
UpdatedAt
 = DateTime.Now.AddDays(-335)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 855,
PaymentId = 336,
ProductId = 11,
ServiceId = 3,
AmoutEmployee = 197,
StartDate = DateTime.Now.AddDays(-194),
EndDate = DateTime.Now.AddDays(-186),
Cost = 28171000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-336),
UpdatedAt
 = DateTime.Now.AddDays(-336)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 856,
PaymentId = 336,
ProductId = 19,
ServiceId = 3,
AmoutEmployee = 130,
StartDate = DateTime.Now.AddDays(-184),
EndDate = DateTime.Now.AddDays(-172),
Cost = 112970000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-336),
UpdatedAt
 = DateTime.Now.AddDays(-336)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 857,
PaymentId = 337,
ProductId = 3,
ServiceId = 3,
AmoutEmployee = 43,
StartDate = DateTime.Now.AddDays(-111),
EndDate = DateTime.Now.AddDays(-97),
Cost = 2365000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-337),
UpdatedAt
 = DateTime.Now.AddDays(-337)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 858,
PaymentId = 337,
ProductId = 12,
ServiceId = 1,
AmoutEmployee = 117,
StartDate = DateTime.Now.AddDays(-188),
EndDate = DateTime.Now.AddDays(-176),
Cost = 18954000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-337),
UpdatedAt
 = DateTime.Now.AddDays(-337)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 859,
PaymentId = 337,
ProductId = 28,
ServiceId = 2,
AmoutEmployee = 132,
StartDate = DateTime.Now.AddDays(-150),
EndDate = DateTime.Now.AddDays(-136),
Cost = 63360000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-337),
UpdatedAt
 = DateTime.Now.AddDays(-337)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 860,
PaymentId = 338,
ProductId = 2,
ServiceId = 3,
AmoutEmployee = 145,
StartDate = DateTime.Now.AddDays(-46),
EndDate = DateTime.Now.AddDays(-40),
Cost = 31102500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-338),
UpdatedAt
 = DateTime.Now.AddDays(-338)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 861,
PaymentId = 338,
ProductId = 7,
ServiceId = 2,
AmoutEmployee = 180,
StartDate = DateTime.Now.AddDays(-46),
EndDate = DateTime.Now.AddDays(-40),
Cost = 5400000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-338),
UpdatedAt
 = DateTime.Now.AddDays(-338)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 862,
PaymentId = 339,
ProductId = 11,
ServiceId = 2,
AmoutEmployee = 47,
StartDate = DateTime.Now.AddDays(-71),
EndDate = DateTime.Now.AddDays(-65),
Cost = 12972000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-339),
UpdatedAt
 = DateTime.Now.AddDays(-339)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 863,
PaymentId = 339,
ProductId = 4,
ServiceId = 2,
AmoutEmployee = 182,
StartDate = DateTime.Now.AddDays(-79),
EndDate = DateTime.Now.AddDays(-67),
Cost = 45864000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-339),
UpdatedAt
 = DateTime.Now.AddDays(-339)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 864,
PaymentId = 339,
ProductId = 2,
ServiceId = 1,
AmoutEmployee = 118,
StartDate = DateTime.Now.AddDays(-44),
EndDate = DateTime.Now.AddDays(-36),
Cost = 18585000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-339),
UpdatedAt
 = DateTime.Now.AddDays(-339)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 865,
PaymentId = 340,
ProductId = 3,
ServiceId = 1,
AmoutEmployee = 148,
StartDate = DateTime.Now.AddDays(-98),
EndDate = DateTime.Now.AddDays(-83),
Cost = 17982000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-340),
UpdatedAt
 = DateTime.Now.AddDays(-340)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 866,
PaymentId = 340,
ProductId = 18,
ServiceId = 3,
AmoutEmployee = 110,
StartDate = DateTime.Now.AddDays(-66),
EndDate = DateTime.Now.AddDays(-58),
Cost = 29645000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-340),
UpdatedAt
 = DateTime.Now.AddDays(-340)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 867,
PaymentId = 341,
ProductId = 7,
ServiceId = 2,
AmoutEmployee = 113,
StartDate = DateTime.Now.AddDays(-189),
EndDate = DateTime.Now.AddDays(-188),
Cost = 18984000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-341),
UpdatedAt
 = DateTime.Now.AddDays(-341)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 868,
PaymentId = 341,
ProductId = 13,
ServiceId = 2,
AmoutEmployee = 85,
StartDate = DateTime.Now.AddDays(-166),
EndDate = DateTime.Now.AddDays(-163),
Cost = 55080000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-341),
UpdatedAt
 = DateTime.Now.AddDays(-341)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 869,
PaymentId = 341,
ProductId = 28,
ServiceId = 2,
AmoutEmployee = 165,
StartDate = DateTime.Now.AddDays(-83),
EndDate = DateTime.Now.AddDays(-75),
Cost = 11880000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-341),
UpdatedAt
 = DateTime.Now.AddDays(-341)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 870,
PaymentId = 342,
ProductId = 29,
ServiceId = 3,
AmoutEmployee = 26,
StartDate = DateTime.Now.AddDays(-112),
EndDate = DateTime.Now.AddDays(-100),
Cost = 13013000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-342),
UpdatedAt
 = DateTime.Now.AddDays(-342)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 871,
PaymentId = 342,
ProductId = 20,
ServiceId = 2,
AmoutEmployee = 174,
StartDate = DateTime.Now.AddDays(-138),
EndDate = DateTime.Now.AddDays(-132),
Cost = 85608000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-342),
UpdatedAt
 = DateTime.Now.AddDays(-342)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 872,
PaymentId = 342,
ProductId = 2,
ServiceId = 3,
AmoutEmployee = 26,
StartDate = DateTime.Now.AddDays(-45),
EndDate = DateTime.Now.AddDays(-37),
Cost = 3575000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-342),
UpdatedAt
 = DateTime.Now.AddDays(-342)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 873,
PaymentId = 343,
ProductId = 22,
ServiceId = 2,
AmoutEmployee = 200,
StartDate = DateTime.Now.AddDays(-74),
EndDate = DateTime.Now.AddDays(-73),
Cost = 75600000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-343),
UpdatedAt
 = DateTime.Now.AddDays(-343)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 874,
PaymentId = 343,
ProductId = 24,
ServiceId = 1,
AmoutEmployee = 131,
StartDate = DateTime.Now.AddDays(-64),
EndDate = DateTime.Now.AddDays(-58),
Cost = 9432000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-343),
UpdatedAt
 = DateTime.Now.AddDays(-343)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 875,
PaymentId = 344,
ProductId = 19,
ServiceId = 1,
AmoutEmployee = 166,
StartDate = DateTime.Now.AddDays(-50),
EndDate = DateTime.Now.AddDays(-36),
Cost = 1494000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-344),
UpdatedAt
 = DateTime.Now.AddDays(-344)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 876,
PaymentId = 344,
ProductId = 11,
ServiceId = 1,
AmoutEmployee = 37,
StartDate = DateTime.Now.AddDays(-129),
EndDate = DateTime.Now.AddDays(-120),
Cost = 18315000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-344),
UpdatedAt
 = DateTime.Now.AddDays(-344)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 877,
PaymentId = 344,
ProductId = 10,
ServiceId = 3,
AmoutEmployee = 132,
StartDate = DateTime.Now.AddDays(-47),
EndDate = DateTime.Now.AddDays(-33),
Cost = 15246000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-344),
UpdatedAt
 = DateTime.Now.AddDays(-344)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 878,
PaymentId = 345,
ProductId = 4,
ServiceId = 3,
AmoutEmployee = 153,
StartDate = DateTime.Now.AddDays(-38),
EndDate = DateTime.Now.AddDays(-31),
Cost = 20196000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-345),
UpdatedAt
 = DateTime.Now.AddDays(-345)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 879,
PaymentId = 345,
ProductId = 5,
ServiceId = 3,
AmoutEmployee = 195,
StartDate = DateTime.Now.AddDays(-151),
EndDate = DateTime.Now.AddDays(-146),
Cost = 47190000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-345),
UpdatedAt
 = DateTime.Now.AddDays(-345)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 880,
PaymentId = 346,
ProductId = 20,
ServiceId = 2,
AmoutEmployee = 58,
StartDate = DateTime.Now.AddDays(-146),
EndDate = DateTime.Now.AddDays(-145),
Cost = 35844000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-346),
UpdatedAt
 = DateTime.Now.AddDays(-346)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 881,
PaymentId = 346,
ProductId = 22,
ServiceId = 3,
AmoutEmployee = 91,
StartDate = DateTime.Now.AddDays(-128),
EndDate = DateTime.Now.AddDays(-118),
Cost = 12012000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-346),
UpdatedAt
 = DateTime.Now.AddDays(-346)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 882,
PaymentId = 346,
ProductId = 21,
ServiceId = 3,
AmoutEmployee = 49,
StartDate = DateTime.Now.AddDays(-112),
EndDate = DateTime.Now.AddDays(-106),
Cost = 28836500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-346),
UpdatedAt
 = DateTime.Now.AddDays(-346)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 883,
PaymentId = 347,
ProductId = 23,
ServiceId = 3,
AmoutEmployee = 200,
StartDate = DateTime.Now.AddDays(-154),
EndDate = DateTime.Now.AddDays(-147),
Cost = 132000000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-347),
UpdatedAt
 = DateTime.Now.AddDays(-347)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 884,
PaymentId = 347,
ProductId = 24,
ServiceId = 2,
AmoutEmployee = 195,
StartDate = DateTime.Now.AddDays(-189),
EndDate = DateTime.Now.AddDays(-184),
Cost = 112320000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-347),
UpdatedAt
 = DateTime.Now.AddDays(-347)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 885,
PaymentId = 348,
ProductId = 16,
ServiceId = 3,
AmoutEmployee = 56,
StartDate = DateTime.Now.AddDays(-178),
EndDate = DateTime.Now.AddDays(-177),
Cost = 36344000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-348),
UpdatedAt
 = DateTime.Now.AddDays(-348)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 886,
PaymentId = 348,
ProductId = 28,
ServiceId = 2,
AmoutEmployee = 43,
StartDate = DateTime.Now.AddDays(-186),
EndDate = DateTime.Now.AddDays(-173),
Cost = 23478000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-348),
UpdatedAt
 = DateTime.Now.AddDays(-348)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 887,
PaymentId = 348,
ProductId = 12,
ServiceId = 1,
AmoutEmployee = 196,
StartDate = DateTime.Now.AddDays(-137),
EndDate = DateTime.Now.AddDays(-126),
Cost = 14112000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-348),
UpdatedAt
 = DateTime.Now.AddDays(-348)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 888,
PaymentId = 349,
ProductId = 19,
ServiceId = 1,
AmoutEmployee = 109,
StartDate = DateTime.Now.AddDays(-148),
EndDate = DateTime.Now.AddDays(-136),
Cost = 2943000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-349),
UpdatedAt
 = DateTime.Now.AddDays(-349)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 889,
PaymentId = 349,
ProductId = 6,
ServiceId = 3,
AmoutEmployee = 187,
StartDate = DateTime.Now.AddDays(-196),
EndDate = DateTime.Now.AddDays(-195),
Cost = 140904500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-349),
UpdatedAt
 = DateTime.Now.AddDays(-349)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 890,
PaymentId = 350,
ProductId = 9,
ServiceId = 2,
AmoutEmployee = 182,
StartDate = DateTime.Now.AddDays(-98),
EndDate = DateTime.Now.AddDays(-92),
Cost = 99372000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-350),
UpdatedAt
 = DateTime.Now.AddDays(-350)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 891,
PaymentId = 350,
ProductId = 14,
ServiceId = 2,
AmoutEmployee = 83,
StartDate = DateTime.Now.AddDays(-75),
EndDate = DateTime.Now.AddDays(-60),
Cost = 18426000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-350),
UpdatedAt
 = DateTime.Now.AddDays(-350)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 892,
PaymentId = 350,
ProductId = 29,
ServiceId = 1,
AmoutEmployee = 191,
StartDate = DateTime.Now.AddDays(-23),
EndDate = DateTime.Now.AddDays(-22),
Cost = 1719000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-350),
UpdatedAt
 = DateTime.Now.AddDays(-350)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 893,
PaymentId = 351,
ProductId = 14,
ServiceId = 3,
AmoutEmployee = 46,
StartDate = DateTime.Now.AddDays(-164),
EndDate = DateTime.Now.AddDays(-161),
Cost = 39468000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-351),
UpdatedAt
 = DateTime.Now.AddDays(-351)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 894,
PaymentId = 351,
ProductId = 7,
ServiceId = 3,
AmoutEmployee = 168,
StartDate = DateTime.Now.AddDays(-156),
EndDate = DateTime.Now.AddDays(-142),
Cost = 105336000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-351),
UpdatedAt
 = DateTime.Now.AddDays(-351)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 895,
PaymentId = 352,
ProductId = 15,
ServiceId = 1,
AmoutEmployee = 85,
StartDate = DateTime.Now.AddDays(-67),
EndDate = DateTime.Now.AddDays(-65),
Cost = 16447500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-352),
UpdatedAt
 = DateTime.Now.AddDays(-352)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 896,
PaymentId = 352,
ProductId = 8,
ServiceId = 2,
AmoutEmployee = 189,
StartDate = DateTime.Now.AddDays(-31),
EndDate = DateTime.Now.AddDays(-22),
Cost = 22680000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-352),
UpdatedAt
 = DateTime.Now.AddDays(-352)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 897,
PaymentId = 352,
ProductId = 28,
ServiceId = 2,
AmoutEmployee = 65,
StartDate = DateTime.Now.AddDays(-162),
EndDate = DateTime.Now.AddDays(-158),
Cost = 40560000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-352),
UpdatedAt
 = DateTime.Now.AddDays(-352)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 898,
PaymentId = 353,
ProductId = 7,
ServiceId = 1,
AmoutEmployee = 133,
StartDate = DateTime.Now.AddDays(-123),
EndDate = DateTime.Now.AddDays(-119),
Cost = 55062000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-353),
UpdatedAt
 = DateTime.Now.AddDays(-353)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 899,
PaymentId = 353,
ProductId = 2,
ServiceId = 3,
AmoutEmployee = 123,
StartDate = DateTime.Now.AddDays(-59),
EndDate = DateTime.Now.AddDays(-55),
Cost = 35178000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-353),
UpdatedAt
 = DateTime.Now.AddDays(-353)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 900,
PaymentId = 353,
ProductId = 17,
ServiceId = 1,
AmoutEmployee = 25,
StartDate = DateTime.Now.AddDays(-40),
EndDate = DateTime.Now.AddDays(-37),
Cost = 1237500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-353),
UpdatedAt
 = DateTime.Now.AddDays(-353)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 901,
PaymentId = 354,
ProductId = 19,
ServiceId = 1,
AmoutEmployee = 179,
StartDate = DateTime.Now.AddDays(-41),
EndDate = DateTime.Now.AddDays(-39),
Cost = 9666000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-354),
UpdatedAt
 = DateTime.Now.AddDays(-354)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 902,
PaymentId = 354,
ProductId = 15,
ServiceId = 3,
AmoutEmployee = 51,
StartDate = DateTime.Now.AddDays(-11),
EndDate = DateTime.Now.AddDays(4),
Cost = 280500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-354),
UpdatedAt
 = DateTime.Now.AddDays(-354)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 903,
PaymentId = 355,
ProductId = 28,
ServiceId = 1,
AmoutEmployee = 56,
StartDate = DateTime.Now.AddDays(-37),
EndDate = DateTime.Now.AddDays(-27),
Cost = 1008000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-355),
UpdatedAt
 = DateTime.Now.AddDays(-355)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 904,
PaymentId = 355,
ProductId = 29,
ServiceId = 1,
AmoutEmployee = 39,
StartDate = DateTime.Now.AddDays(-49),
EndDate = DateTime.Now.AddDays(-43),
Cost = 2457000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-355),
UpdatedAt
 = DateTime.Now.AddDays(-355)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 905,
PaymentId = 355,
ProductId = 13,
ServiceId = 2,
AmoutEmployee = 166,
StartDate = DateTime.Now.AddDays(-148),
EndDate = DateTime.Now.AddDays(-141),
Cost = 131472000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-355),
UpdatedAt
 = DateTime.Now.AddDays(-355)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 906,
PaymentId = 356,
ProductId = 16,
ServiceId = 1,
AmoutEmployee = 158,
StartDate = DateTime.Now.AddDays(-56),
EndDate = DateTime.Now.AddDays(-44),
Cost = 22752000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-356),
UpdatedAt
 = DateTime.Now.AddDays(-356)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 907,
PaymentId = 356,
ProductId = 17,
ServiceId = 2,
AmoutEmployee = 105,
StartDate = DateTime.Now.AddDays(-169),
EndDate = DateTime.Now.AddDays(-162),
Cost = 37800000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-356),
UpdatedAt
 = DateTime.Now.AddDays(-356)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 908,
PaymentId = 357,
ProductId = 3,
ServiceId = 1,
AmoutEmployee = 182,
StartDate = DateTime.Now.AddDays(-184),
EndDate = DateTime.Now.AddDays(-169),
Cost = 58968000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-357),
UpdatedAt
 = DateTime.Now.AddDays(-357)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 909,
PaymentId = 357,
ProductId = 6,
ServiceId = 1,
AmoutEmployee = 200,
StartDate = DateTime.Now.AddDays(-191),
EndDate = DateTime.Now.AddDays(-189),
Cost = 5400000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-357),
UpdatedAt
 = DateTime.Now.AddDays(-357)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 910,
PaymentId = 357,
ProductId = 6,
ServiceId = 1,
AmoutEmployee = 150,
StartDate = DateTime.Now.AddDays(-32),
EndDate = DateTime.Now.AddDays(-30),
Cost = 8100000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-357),
UpdatedAt
 = DateTime.Now.AddDays(-357)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 911,
PaymentId = 358,
ProductId = 5,
ServiceId = 1,
AmoutEmployee = 178,
StartDate = DateTime.Now.AddDays(-41),
EndDate = DateTime.Now.AddDays(-40),
Cost = 21627000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-358),
UpdatedAt
 = DateTime.Now.AddDays(-358)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 912,
PaymentId = 358,
ProductId = 26,
ServiceId = 3,
AmoutEmployee = 103,
StartDate = DateTime.Now.AddDays(-92),
EndDate = DateTime.Now.AddDays(-91),
Cost = 45886500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-358),
UpdatedAt
 = DateTime.Now.AddDays(-358)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 913,
PaymentId = 359,
ProductId = 5,
ServiceId = 1,
AmoutEmployee = 86,
StartDate = DateTime.Now.AddDays(-137),
EndDate = DateTime.Now.AddDays(-128),
Cost = 41796000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-359),
UpdatedAt
 = DateTime.Now.AddDays(-359)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 914,
PaymentId = 359,
ProductId = 4,
ServiceId = 1,
AmoutEmployee = 197,
StartDate = DateTime.Now.AddDays(-12),
EndDate = DateTime.Now.AddDays(-7),
Cost = 6205500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-359),
UpdatedAt
 = DateTime.Now.AddDays(-359)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 915,
PaymentId = 359,
ProductId = 16,
ServiceId = 1,
AmoutEmployee = 186,
StartDate = DateTime.Now.AddDays(-31),
EndDate = DateTime.Now.AddDays(-18),
Cost = 15903000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-359),
UpdatedAt
 = DateTime.Now.AddDays(-359)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 916,
PaymentId = 360,
ProductId = 12,
ServiceId = 3,
AmoutEmployee = 57,
StartDate = DateTime.Now.AddDays(-168),
EndDate = DateTime.Now.AddDays(-159),
Cost = 25707000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-360),
UpdatedAt
 = DateTime.Now.AddDays(-360)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 917,
PaymentId = 360,
ProductId = 20,
ServiceId = 3,
AmoutEmployee = 169,
StartDate = DateTime.Now.AddDays(-135),
EndDate = DateTime.Now.AddDays(-131),
Cost = 119905500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-360),
UpdatedAt
 = DateTime.Now.AddDays(-360)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 918,
PaymentId = 361,
ProductId = 8,
ServiceId = 3,
AmoutEmployee = 156,
StartDate = DateTime.Now.AddDays(-118),
EndDate = DateTime.Now.AddDays(-110),
Cost = 42900000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-361),
UpdatedAt
 = DateTime.Now.AddDays(-361)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 919,
PaymentId = 361,
ProductId = 11,
ServiceId = 3,
AmoutEmployee = 166,
StartDate = DateTime.Now.AddDays(-8),
EndDate = DateTime.Now.AddDays(-6),
Cost = 913000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-361),
UpdatedAt
 = DateTime.Now.AddDays(-361)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 920,
PaymentId = 361,
ProductId = 27,
ServiceId = 1,
AmoutEmployee = 103,
StartDate = DateTime.Now.AddDays(-145),
EndDate = DateTime.Now.AddDays(-137),
Cost = 63036000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-361),
UpdatedAt
 = DateTime.Now.AddDays(-361)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 921,
PaymentId = 362,
ProductId = 4,
ServiceId = 2,
AmoutEmployee = 135,
StartDate = DateTime.Now.AddDays(-181),
EndDate = DateTime.Now.AddDays(-166),
Cost = 25110000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-362),
UpdatedAt
 = DateTime.Now.AddDays(-362)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 922,
PaymentId = 362,
ProductId = 22,
ServiceId = 2,
AmoutEmployee = 144,
StartDate = DateTime.Now.AddDays(-131),
EndDate = DateTime.Now.AddDays(-125),
Cost = 76032000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-362),
UpdatedAt
 = DateTime.Now.AddDays(-362)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 923,
PaymentId = 363,
ProductId = 20,
ServiceId = 1,
AmoutEmployee = 111,
StartDate = DateTime.Now.AddDays(-53),
EndDate = DateTime.Now.AddDays(-38),
Cost = 499500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-363),
UpdatedAt
 = DateTime.Now.AddDays(-363)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 924,
PaymentId = 363,
ProductId = 11,
ServiceId = 3,
AmoutEmployee = 194,
StartDate = DateTime.Now.AddDays(-89),
EndDate = DateTime.Now.AddDays(-76),
Cost = 76824000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-363),
UpdatedAt
 = DateTime.Now.AddDays(-363)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 925,
PaymentId = 363,
ProductId = 9,
ServiceId = 2,
AmoutEmployee = 163,
StartDate = DateTime.Now.AddDays(-77),
EndDate = DateTime.Now.AddDays(-70),
Cost = 5868000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-363),
UpdatedAt
 = DateTime.Now.AddDays(-363)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 926,
PaymentId = 364,
ProductId = 20,
ServiceId = 3,
AmoutEmployee = 84,
StartDate = DateTime.Now.AddDays(-59),
EndDate = DateTime.Now.AddDays(-58),
Cost = 24486000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-364),
UpdatedAt
 = DateTime.Now.AddDays(-364)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 927,
PaymentId = 364,
ProductId = 28,
ServiceId = 2,
AmoutEmployee = 171,
StartDate = DateTime.Now.AddDays(-11),
EndDate = DateTime.Now.AddDays(0),
Cost = 1026000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-364),
UpdatedAt
 = DateTime.Now.AddDays(-364)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 928,
PaymentId = 364,
ProductId = 24,
ServiceId = 2,
AmoutEmployee = 120,
StartDate = DateTime.Now.AddDays(-16),
EndDate = DateTime.Now.AddDays(-12),
Cost = 3600000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-364),
UpdatedAt
 = DateTime.Now.AddDays(-364)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 929,
PaymentId = 365,
ProductId = 2,
ServiceId = 1,
AmoutEmployee = 166,
StartDate = DateTime.Now.AddDays(-122),
EndDate = DateTime.Now.AddDays(-117),
Cost = 37350000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-365),
UpdatedAt
 = DateTime.Now.AddDays(-365)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 930,
PaymentId = 365,
ProductId = 26,
ServiceId = 3,
AmoutEmployee = 86,
StartDate = DateTime.Now.AddDays(-126),
EndDate = DateTime.Now.AddDays(-124),
Cost = 26015000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-365),
UpdatedAt
 = DateTime.Now.AddDays(-365)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 931,
PaymentId = 366,
ProductId = 10,
ServiceId = 1,
AmoutEmployee = 147,
StartDate = DateTime.Now.AddDays(-170),
EndDate = DateTime.Now.AddDays(-169),
Cost = 36382500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-366),
UpdatedAt
 = DateTime.Now.AddDays(-366)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 932,
PaymentId = 366,
ProductId = 9,
ServiceId = 1,
AmoutEmployee = 147,
StartDate = DateTime.Now.AddDays(-164),
EndDate = DateTime.Now.AddDays(-161),
Cost = 53581500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-366),
UpdatedAt
 = DateTime.Now.AddDays(-366)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 933,
PaymentId = 366,
ProductId = 2,
ServiceId = 3,
AmoutEmployee = 176,
StartDate = DateTime.Now.AddDays(-87),
EndDate = DateTime.Now.AddDays(-74),
Cost = 50336000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-366),
UpdatedAt
 = DateTime.Now.AddDays(-366)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 934,
PaymentId = 367,
ProductId = 9,
ServiceId = 1,
AmoutEmployee = 136,
StartDate = DateTime.Now.AddDays(-26),
EndDate = DateTime.Now.AddDays(-25),
Cost = 10404000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-367),
UpdatedAt
 = DateTime.Now.AddDays(-367)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 935,
PaymentId = 367,
ProductId = 6,
ServiceId = 3,
AmoutEmployee = 67,
StartDate = DateTime.Now.AddDays(-169),
EndDate = DateTime.Now.AddDays(-158),
Cost = 16214000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-367),
UpdatedAt
 = DateTime.Now.AddDays(-367)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 936,
PaymentId = 368,
ProductId = 19,
ServiceId = 1,
AmoutEmployee = 154,
StartDate = DateTime.Now.AddDays(-172),
EndDate = DateTime.Now.AddDays(-161),
Cost = 96327000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-368),
UpdatedAt
 = DateTime.Now.AddDays(-368)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 937,
PaymentId = 368,
ProductId = 28,
ServiceId = 3,
AmoutEmployee = 105,
StartDate = DateTime.Now.AddDays(-99),
EndDate = DateTime.Now.AddDays(-97),
Cost = 24255000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-368),
UpdatedAt
 = DateTime.Now.AddDays(-368)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 938,
PaymentId = 368,
ProductId = 24,
ServiceId = 2,
AmoutEmployee = 133,
StartDate = DateTime.Now.AddDays(-54),
EndDate = DateTime.Now.AddDays(-46),
Cost = 28728000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-368),
UpdatedAt
 = DateTime.Now.AddDays(-368)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 939,
PaymentId = 369,
ProductId = 19,
ServiceId = 1,
AmoutEmployee = 102,
StartDate = DateTime.Now.AddDays(-58),
EndDate = DateTime.Now.AddDays(-47),
Cost = 22950000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-369),
UpdatedAt
 = DateTime.Now.AddDays(-369)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 940,
PaymentId = 369,
ProductId = 17,
ServiceId = 3,
AmoutEmployee = 194,
StartDate = DateTime.Now.AddDays(-74),
EndDate = DateTime.Now.AddDays(-73),
Cost = 40546000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-369),
UpdatedAt
 = DateTime.Now.AddDays(-369)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 941,
PaymentId = 370,
ProductId = 21,
ServiceId = 2,
AmoutEmployee = 184,
StartDate = DateTime.Now.AddDays(-117),
EndDate = DateTime.Now.AddDays(-107),
Cost = 85008000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-370),
UpdatedAt
 = DateTime.Now.AddDays(-370)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 942,
PaymentId = 370,
ProductId = 22,
ServiceId = 1,
AmoutEmployee = 151,
StartDate = DateTime.Now.AddDays(-8),
EndDate = DateTime.Now.AddDays(1),
Cost = 1359000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-370),
UpdatedAt
 = DateTime.Now.AddDays(-370)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 943,
PaymentId = 370,
ProductId = 9,
ServiceId = 3,
AmoutEmployee = 87,
StartDate = DateTime.Now.AddDays(-143),
EndDate = DateTime.Now.AddDays(-140),
Cost = 60291000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-370),
UpdatedAt
 = DateTime.Now.AddDays(-370)
,
});
            //change
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 944,
PaymentId = 371,
ProductId = 28,
ServiceId = 2,
AmoutEmployee = 162,
StartDate = DateTime.Now.AddDays(-96),
EndDate = DateTime.Now.AddDays(-82),
Cost = 72900000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-371),
UpdatedAt
 = DateTime.Now.AddDays(-371)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 945,
PaymentId = 371,
ProductId = 6,
ServiceId = 3,
AmoutEmployee = 121,
StartDate = DateTime.Now.AddDays(-183),
EndDate = DateTime.Now.AddDays(-174),
Cost = 33940500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-371),
UpdatedAt
 = DateTime.Now.AddDays(-371)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 946,
PaymentId = 372,
ProductId = 23,
ServiceId = 1,
AmoutEmployee = 48,
StartDate = DateTime.Now.AddDays(-94),
EndDate = DateTime.Now.AddDays(-87),
Cost = 11664000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-372),
UpdatedAt
 = DateTime.Now.AddDays(-372)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 947,
PaymentId = 372,
ProductId = 21,
ServiceId = 2,
AmoutEmployee = 93,
StartDate = DateTime.Now.AddDays(-152),
EndDate = DateTime.Now.AddDays(-138),
Cost = 32922000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-372),
UpdatedAt
 = DateTime.Now.AddDays(-372)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 948,
PaymentId = 372,
ProductId = 18,
ServiceId = 1,
AmoutEmployee = 34,
StartDate = DateTime.Now.AddDays(-136),
EndDate = DateTime.Now.AddDays(-128),
Cost = 13770000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-372),
UpdatedAt
 = DateTime.Now.AddDays(-372)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 949,
PaymentId = 373,
ProductId = 11,
ServiceId = 1,
AmoutEmployee = 200,
StartDate = DateTime.Now.AddDays(-153),
EndDate = DateTime.Now.AddDays(-148),
Cost = 63000000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-373),
UpdatedAt
 = DateTime.Now.AddDays(-373)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 950,
PaymentId = 373,
ProductId = 8,
ServiceId = 3,
AmoutEmployee = 194,
StartDate = DateTime.Now.AddDays(-44),
EndDate = DateTime.Now.AddDays(-40),
Cost = 12804000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-373),
UpdatedAt
 = DateTime.Now.AddDays(-373)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 951,
PaymentId = 374,
ProductId = 29,
ServiceId = 1,
AmoutEmployee = 49,
StartDate = DateTime.Now.AddDays(-56),
EndDate = DateTime.Now.AddDays(-55),
Cost = 6835500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-374),
UpdatedAt
 = DateTime.Now.AddDays(-374)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 952,
PaymentId = 374,
ProductId = 7,
ServiceId = 3,
AmoutEmployee = 157,
StartDate = DateTime.Now.AddDays(-72),
EndDate = DateTime.Now.AddDays(-66),
Cost = 26768500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-374),
UpdatedAt
 = DateTime.Now.AddDays(-374)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 953,
PaymentId = 374,
ProductId = 12,
ServiceId = 2,
AmoutEmployee = 51,
StartDate = DateTime.Now.AddDays(-20),
EndDate = DateTime.Now.AddDays(-12),
Cost = 4590000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-374),
UpdatedAt
 = DateTime.Now.AddDays(-374)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 954,
PaymentId = 375,
ProductId = 8,
ServiceId = 1,
AmoutEmployee = 179,
StartDate = DateTime.Now.AddDays(-185),
EndDate = DateTime.Now.AddDays(-170),
Cost = 115186500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-375),
UpdatedAt
 = DateTime.Now.AddDays(-375)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 955,
PaymentId = 375,
ProductId = 10,
ServiceId = 1,
AmoutEmployee = 54,
StartDate = DateTime.Now.AddDays(-85),
EndDate = DateTime.Now.AddDays(-78),
Cost = 19197000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-375),
UpdatedAt
 = DateTime.Now.AddDays(-375)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 956,
PaymentId = 375,
ProductId = 27,
ServiceId = 3,
AmoutEmployee = 155,
StartDate = DateTime.Now.AddDays(-141),
EndDate = DateTime.Now.AddDays(-133),
Cost = 12787500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-375),
UpdatedAt
 = DateTime.Now.AddDays(-375)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 957,
PaymentId = 376,
ProductId = 19,
ServiceId = 1,
AmoutEmployee = 200,
StartDate = DateTime.Now.AddDays(-41),
EndDate = DateTime.Now.AddDays(-30),
Cost = 6300000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-376),
UpdatedAt
 = DateTime.Now.AddDays(-376)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 958,
PaymentId = 376,
ProductId = 15,
ServiceId = 2,
AmoutEmployee = 178,
StartDate = DateTime.Now.AddDays(-175),
EndDate = DateTime.Now.AddDays(-168),
Cost = 179424000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-376),
UpdatedAt
 = DateTime.Now.AddDays(-376)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 959,
PaymentId = 377,
ProductId = 5,
ServiceId = 3,
AmoutEmployee = 78,
StartDate = DateTime.Now.AddDays(-47),
EndDate = DateTime.Now.AddDays(-38),
Cost = 13299000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-377),
UpdatedAt
 = DateTime.Now.AddDays(-377)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 960,
PaymentId = 377,
ProductId = 3,
ServiceId = 1,
AmoutEmployee = 176,
StartDate = DateTime.Now.AddDays(-104),
EndDate = DateTime.Now.AddDays(-103),
Cost = 4752000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-377),
UpdatedAt
 = DateTime.Now.AddDays(-377)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 961,
PaymentId = 377,
ProductId = 25,
ServiceId = 3,
AmoutEmployee = 154,
StartDate = DateTime.Now.AddDays(-113),
EndDate = DateTime.Now.AddDays(-106),
Cost = 85547000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-377),
UpdatedAt
 = DateTime.Now.AddDays(-377)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 962,
PaymentId = 378,
ProductId = 14,
ServiceId = 3,
AmoutEmployee = 92,
StartDate = DateTime.Now.AddDays(-33),
EndDate = DateTime.Now.AddDays(-32),
Cost = 1518000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-378),
UpdatedAt
 = DateTime.Now.AddDays(-378)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 963,
PaymentId = 378,
ProductId = 4,
ServiceId = 2,
AmoutEmployee = 139,
StartDate = DateTime.Now.AddDays(-47),
EndDate = DateTime.Now.AddDays(-32),
Cost = 16680000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-378),
UpdatedAt
 = DateTime.Now.AddDays(-378)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 964,
PaymentId = 379,
ProductId = 30,
ServiceId = 2,
AmoutEmployee = 134,
StartDate = DateTime.Now.AddDays(-27),
EndDate = DateTime.Now.AddDays(-20),
Cost = 10452000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-379),
UpdatedAt
 = DateTime.Now.AddDays(-379)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 965,
PaymentId = 379,
ProductId = 7,
ServiceId = 1,
AmoutEmployee = 172,
StartDate = DateTime.Now.AddDays(-38),
EndDate = DateTime.Now.AddDays(-28),
Cost = 4644000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-379),
UpdatedAt
 = DateTime.Now.AddDays(-379)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 966,
PaymentId = 379,
ProductId = 22,
ServiceId = 1,
AmoutEmployee = 150,
StartDate = DateTime.Now.AddDays(-32),
EndDate = DateTime.Now.AddDays(-24),
Cost = 2025000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-379),
UpdatedAt
 = DateTime.Now.AddDays(-379)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 967,
PaymentId = 380,
ProductId = 8,
ServiceId = 1,
AmoutEmployee = 178,
StartDate = DateTime.Now.AddDays(-84),
EndDate = DateTime.Now.AddDays(-70),
Cost = 41652000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-380),
UpdatedAt
 = DateTime.Now.AddDays(-380)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 968,
PaymentId = 380,
ProductId = 21,
ServiceId = 2,
AmoutEmployee = 121,
StartDate = DateTime.Now.AddDays(-137),
EndDate = DateTime.Now.AddDays(-127),
Cost = 95832000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-380),
UpdatedAt
 = DateTime.Now.AddDays(-380)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 969,
PaymentId = 381,
ProductId = 8,
ServiceId = 1,
AmoutEmployee = 57,
StartDate = DateTime.Now.AddDays(-25),
EndDate = DateTime.Now.AddDays(-24),
Cost = 1282500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-381),
UpdatedAt
 = DateTime.Now.AddDays(-381)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 970,
PaymentId = 381,
ProductId = 14,
ServiceId = 2,
AmoutEmployee = 191,
StartDate = DateTime.Now.AddDays(-135),
EndDate = DateTime.Now.AddDays(-124),
Cost = 46986000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-381),
UpdatedAt
 = DateTime.Now.AddDays(-381)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 971,
PaymentId = 381,
ProductId = 1,
ServiceId = 3,
AmoutEmployee = 155,
StartDate = DateTime.Now.AddDays(-151),
EndDate = DateTime.Now.AddDays(-138),
Cost = 7672500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-381),
UpdatedAt
 = DateTime.Now.AddDays(-381)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 972,
PaymentId = 382,
ProductId = 25,
ServiceId = 1,
AmoutEmployee = 176,
StartDate = DateTime.Now.AddDays(-155),
EndDate = DateTime.Now.AddDays(-151),
Cost = 38808000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-382),
UpdatedAt
 = DateTime.Now.AddDays(-382)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 973,
PaymentId = 382,
ProductId = 12,
ServiceId = 1,
AmoutEmployee = 93,
StartDate = DateTime.Now.AddDays(-66),
EndDate = DateTime.Now.AddDays(-62),
Cost = 25528500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-382),
UpdatedAt
 = DateTime.Now.AddDays(-382)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 974,
PaymentId = 383,
ProductId = 1,
ServiceId = 2,
AmoutEmployee = 130,
StartDate = DateTime.Now.AddDays(-73),
EndDate = DateTime.Now.AddDays(-62),
Cost = 28860000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-383),
UpdatedAt
 = DateTime.Now.AddDays(-383)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 975,
PaymentId = 383,
ProductId = 14,
ServiceId = 2,
AmoutEmployee = 53,
StartDate = DateTime.Now.AddDays(-155),
EndDate = DateTime.Now.AddDays(-152),
Cost = 34980000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-383),
UpdatedAt
 = DateTime.Now.AddDays(-383)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 976,
PaymentId = 383,
ProductId = 30,
ServiceId = 3,
AmoutEmployee = 87,
StartDate = DateTime.Now.AddDays(-123),
EndDate = DateTime.Now.AddDays(-116),
Cost = 48807000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-383),
UpdatedAt
 = DateTime.Now.AddDays(-383)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 977,
PaymentId = 384,
ProductId = 3,
ServiceId = 3,
AmoutEmployee = 195,
StartDate = DateTime.Now.AddDays(-156),
EndDate = DateTime.Now.AddDays(-148),
Cost = 115830000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-384),
UpdatedAt
 = DateTime.Now.AddDays(-384)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 978,
PaymentId = 384,
ProductId = 10,
ServiceId = 3,
AmoutEmployee = 195,
StartDate = DateTime.Now.AddDays(-71),
EndDate = DateTime.Now.AddDays(-64),
Cost = 68640000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-384),
UpdatedAt
 = DateTime.Now.AddDays(-384)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 979,
PaymentId = 385,
ProductId = 6,
ServiceId = 1,
AmoutEmployee = 106,
StartDate = DateTime.Now.AddDays(-17),
EndDate = DateTime.Now.AddDays(-12),
Cost = 2862000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-385),
UpdatedAt
 = DateTime.Now.AddDays(-385)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 980,
PaymentId = 385,
ProductId = 1,
ServiceId = 3,
AmoutEmployee = 80,
StartDate = DateTime.Now.AddDays(-124),
EndDate = DateTime.Now.AddDays(-123),
Cost = 20680000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-385),
UpdatedAt
 = DateTime.Now.AddDays(-385)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 981,
PaymentId = 385,
ProductId = 30,
ServiceId = 2,
AmoutEmployee = 173,
StartDate = DateTime.Now.AddDays(-77),
EndDate = DateTime.Now.AddDays(-62),
Cost = 73698000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-385),
UpdatedAt
 = DateTime.Now.AddDays(-385)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 982,
PaymentId = 386,
ProductId = 10,
ServiceId = 1,
AmoutEmployee = 143,
StartDate = DateTime.Now.AddDays(-140),
EndDate = DateTime.Now.AddDays(-130),
Cost = 40540500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-386),
UpdatedAt
 = DateTime.Now.AddDays(-386)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 983,
PaymentId = 386,
ProductId = 25,
ServiceId = 2,
AmoutEmployee = 143,
StartDate = DateTime.Now.AddDays(-143),
EndDate = DateTime.Now.AddDays(-141),
Cost = 81510000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-386),
UpdatedAt
 = DateTime.Now.AddDays(-386)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 984,
PaymentId = 386,
ProductId = 10,
ServiceId = 3,
AmoutEmployee = 39,
StartDate = DateTime.Now.AddDays(-33),
EndDate = DateTime.Now.AddDays(-23),
Cost = 5148000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-386),
UpdatedAt
 = DateTime.Now.AddDays(-386)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 985,
PaymentId = 387,
ProductId = 24,
ServiceId = 3,
AmoutEmployee = 45,
StartDate = DateTime.Now.AddDays(-47),
EndDate = DateTime.Now.AddDays(-37),
Cost = 8167500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-387),
UpdatedAt
 = DateTime.Now.AddDays(-387)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 986,
PaymentId = 387,
ProductId = 6,
ServiceId = 3,
AmoutEmployee = 170,
StartDate = DateTime.Now.AddDays(-147),
EndDate = DateTime.Now.AddDays(-136),
Cost = 57035000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-387),
UpdatedAt
 = DateTime.Now.AddDays(-387)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 987,
PaymentId = 388,
ProductId = 12,
ServiceId = 3,
AmoutEmployee = 66,
StartDate = DateTime.Now.AddDays(-22),
EndDate = DateTime.Now.AddDays(-7),
Cost = 5082000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-388),
UpdatedAt
 = DateTime.Now.AddDays(-388)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 988,
PaymentId = 388,
ProductId = 26,
ServiceId = 1,
AmoutEmployee = 60,
StartDate = DateTime.Now.AddDays(-96),
EndDate = DateTime.Now.AddDays(-88),
Cost = 3780000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-388),
UpdatedAt
 = DateTime.Now.AddDays(-388)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 989,
PaymentId = 388,
ProductId = 17,
ServiceId = 2,
AmoutEmployee = 199,
StartDate = DateTime.Now.AddDays(-84),
EndDate = DateTime.Now.AddDays(-82),
Cost = 27462000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-388),
UpdatedAt
 = DateTime.Now.AddDays(-388)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 990,
PaymentId = 389,
ProductId = 18,
ServiceId = 3,
AmoutEmployee = 129,
StartDate = DateTime.Now.AddDays(-55),
EndDate = DateTime.Now.AddDays(-41),
Cost = 10642500,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-389),
UpdatedAt
 = DateTime.Now.AddDays(-389)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 991,
PaymentId = 389,
ProductId = 27,
ServiceId = 3,
AmoutEmployee = 81,
StartDate = DateTime.Now.AddDays(-63),
EndDate = DateTime.Now.AddDays(-49),
Cost = 5346000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-389),
UpdatedAt
 = DateTime.Now.AddDays(-389)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 992,
PaymentId = 390,
ProductId = 25,
ServiceId = 2,
AmoutEmployee = 58,
StartDate = DateTime.Now.AddDays(-92),
EndDate = DateTime.Now.AddDays(-77),
Cost = 8700000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-390),
UpdatedAt
 = DateTime.Now.AddDays(-390)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 993,
PaymentId = 390,
ProductId = 16,
ServiceId = 2,
AmoutEmployee = 180,
StartDate = DateTime.Now.AddDays(-65),
EndDate = DateTime.Now.AddDays(-64),
Cost = 49680000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-390),
UpdatedAt
 = DateTime.Now.AddDays(-390)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 994,
PaymentId = 390,
ProductId = 17,
ServiceId = 1,
AmoutEmployee = 198,
StartDate = DateTime.Now.AddDays(-104),
EndDate = DateTime.Now.AddDays(-100),
Cost = 18711000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-390),
UpdatedAt
 = DateTime.Now.AddDays(-390)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 995,
PaymentId = 391,
ProductId = 5,
ServiceId = 2,
AmoutEmployee = 127,
StartDate = DateTime.Now.AddDays(-75),
EndDate = DateTime.Now.AddDays(-73),
Cost = 17526000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-391),
UpdatedAt
 = DateTime.Now.AddDays(-391)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 996,
PaymentId = 391,
ProductId = 4,
ServiceId = 3,
AmoutEmployee = 198,
StartDate = DateTime.Now.AddDays(-79),
EndDate = DateTime.Now.AddDays(-69),
Cost = 25047000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-391),
UpdatedAt
 = DateTime.Now.AddDays(-391)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 997,
PaymentId = 392,
ProductId = 4,
ServiceId = 2,
AmoutEmployee = 170,
StartDate = DateTime.Now.AddDays(-151),
EndDate = DateTime.Now.AddDays(-147),
Cost = 77520000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-392),
UpdatedAt
 = DateTime.Now.AddDays(-392)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 998,
PaymentId = 392,
ProductId = 6,
ServiceId = 1,
AmoutEmployee = 123,
StartDate = DateTime.Now.AddDays(-44),
EndDate = DateTime.Now.AddDays(-30),
Cost = 16605000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-392),
UpdatedAt
 = DateTime.Now.AddDays(-392)
,
});
context.PaymentDetails.AddOrUpdate(new PaymentDetail()
{
Id = 999,
PaymentId = 392,
ProductId = 17,
ServiceId = 2,
AmoutEmployee = 197,
StartDate = DateTime.Now.AddDays(-191),
EndDate = DateTime.Now.AddDays(-186),
Cost = 120564000,
Status = PaymentDetailStatus.Active,
CreatedAt = DateTime.Now.AddDays(-392),
UpdatedAt
 = DateTime.Now.AddDays(-392),
});
context.SaveChanges();
        }
    }
}
