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

                ClientSource = "",

                PhoneNumber = "0989850321",

                Address = "Số 19, Tòa nhà Masteri An Phú, 179 Xa lộ Hà Nội, Tp.HCM",

                Career = "VLXD",

                Email = "AnhA@gmail.com",

                PointOfContact = "Anh A",

                Position = "GĐ",

                Description = "Công ty Cổ phần Tập đoàn Masterise có mã số thuế 304840018. Địa chỉ tại: Số 19, Tòa nhà Masteri An Phú, 179 Xa lộ Hà Nội, Tp.HCM Chuyên cung cấp sản phẩm dịch vụ liên quan đến ngành nghề: VLXD",

                Status = ClientStatus.Active,

                CreatedAt = DateTime.Now.AddDays(-204),

                UpdatedAt = DateTime.Now.AddDays(-204),

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

                UpdatedAt = DateTime.Now.AddDays(-203),

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

                UpdatedAt = DateTime.Now.AddDays(-202),

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

                UpdatedAt = DateTime.Now.AddDays(-201),

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

                UpdatedAt = DateTime.Now.AddDays(-200),

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

                UpdatedAt = DateTime.Now.AddDays(-199),

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

                UpdatedAt = DateTime.Now.AddDays(-198),

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

                UpdatedAt = DateTime.Now.AddDays(-197),

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

                UpdatedAt = DateTime.Now.AddDays(-196),

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

                UpdatedAt = DateTime.Now.AddDays(-195),

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

                UpdatedAt = DateTime.Now.AddDays(-194),

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

                UpdatedAt = DateTime.Now.AddDays(-193),

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

                UpdatedAt = DateTime.Now.AddDays(-192),

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

                UpdatedAt = DateTime.Now.AddDays(-191),

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

                UpdatedAt = DateTime.Now.AddDays(-190),

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

                UpdatedAt = DateTime.Now.AddDays(-189),

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

                UpdatedAt = DateTime.Now.AddDays(-188),

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

                UpdatedAt = DateTime.Now.AddDays(-187),

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

                UpdatedAt = DateTime.Now.AddDays(-186),

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

                UpdatedAt = DateTime.Now.AddDays(-185),

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

                UpdatedAt = DateTime.Now.AddDays(-184),

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

                UpdatedAt = DateTime.Now.AddDays(-183),

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

                UpdatedAt = DateTime.Now.AddDays(-182),

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

                UpdatedAt = DateTime.Now.AddDays(-181),

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

                UpdatedAt = DateTime.Now.AddDays(-180),

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

                UpdatedAt = DateTime.Now.AddDays(-179),

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

                UpdatedAt = DateTime.Now.AddDays(-178),

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

                UpdatedAt = DateTime.Now.AddDays(-177),

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

                UpdatedAt = DateTime.Now.AddDays(-176),

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

                UpdatedAt = DateTime.Now.AddDays(-175),

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

                UpdatedAt = DateTime.Now.AddDays(-174),

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

                UpdatedAt = DateTime.Now.AddDays(-173),

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

                UpdatedAt = DateTime.Now.AddDays(-172),

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

                UpdatedAt = DateTime.Now.AddDays(-171),

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

                UpdatedAt = DateTime.Now.AddDays(-170),

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

                UpdatedAt = DateTime.Now.AddDays(-169),

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

                UpdatedAt = DateTime.Now.AddDays(-168),

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

                UpdatedAt = DateTime.Now.AddDays(-167),

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

                UpdatedAt = DateTime.Now.AddDays(-166),

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

                UpdatedAt = DateTime.Now.AddDays(-165),

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

                UpdatedAt = DateTime.Now.AddDays(-164),

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

                UpdatedAt = DateTime.Now.AddDays(-163),

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

                UpdatedAt = DateTime.Now.AddDays(-162),

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

                UpdatedAt = DateTime.Now.AddDays(-161),

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

                UpdatedAt = DateTime.Now.AddDays(-160),

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

                UpdatedAt = DateTime.Now.AddDays(-159),

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

                UpdatedAt = DateTime.Now.AddDays(-158),

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

                UpdatedAt = DateTime.Now.AddDays(-157),

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

                UpdatedAt = DateTime.Now.AddDays(-156),

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

                UpdatedAt = DateTime.Now.AddDays(-155),

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

                UpdatedAt = DateTime.Now.AddDays(-154),

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

                UpdatedAt = DateTime.Now.AddDays(-153),

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

                UpdatedAt = DateTime.Now.AddDays(-152),

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

                UpdatedAt = DateTime.Now.AddDays(-151),

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

                UpdatedAt = DateTime.Now.AddDays(-150),

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

                UpdatedAt = DateTime.Now.AddDays(-149),

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

                UpdatedAt = DateTime.Now.AddDays(-148),

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

                UpdatedAt = DateTime.Now.AddDays(-147),

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

                UpdatedAt = DateTime.Now.AddDays(-146),

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

                UpdatedAt = DateTime.Now.AddDays(-145),

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

                UpdatedAt = DateTime.Now.AddDays(-144),

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

                UpdatedAt = DateTime.Now.AddDays(-143),

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

                UpdatedAt = DateTime.Now.AddDays(-142),

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

                UpdatedAt = DateTime.Now.AddDays(-141),

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

                UpdatedAt = DateTime.Now.AddDays(-140),

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

                UpdatedAt = DateTime.Now.AddDays(-139),

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

                UpdatedAt = DateTime.Now.AddDays(-138),

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

                UpdatedAt = DateTime.Now.AddDays(-137),

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

                UpdatedAt = DateTime.Now.AddDays(-136),

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

                UpdatedAt = DateTime.Now.AddDays(-135),

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

                UpdatedAt = DateTime.Now.AddDays(-134),

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

                UpdatedAt = DateTime.Now.AddDays(-133),

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

                UpdatedAt = DateTime.Now.AddDays(-132),

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

                UpdatedAt = DateTime.Now.AddDays(-131),

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

                UpdatedAt = DateTime.Now.AddDays(-130),

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

                UpdatedAt = DateTime.Now.AddDays(-129),

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

                UpdatedAt = DateTime.Now.AddDays(-128),

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

                UpdatedAt = DateTime.Now.AddDays(-127),

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

                UpdatedAt = DateTime.Now.AddDays(-126),

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

                UpdatedAt = DateTime.Now.AddDays(-125),

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

                UpdatedAt = DateTime.Now.AddDays(-124),

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

                UpdatedAt = DateTime.Now.AddDays(-123),

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

                UpdatedAt = DateTime.Now.AddDays(-122),

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

                UpdatedAt = DateTime.Now.AddDays(-121),

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

                UpdatedAt = DateTime.Now.AddDays(-120),

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

                UpdatedAt = DateTime.Now.AddDays(-119),

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

                UpdatedAt = DateTime.Now.AddDays(-118),

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

                UpdatedAt = DateTime.Now.AddDays(-117),

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

                UpdatedAt = DateTime.Now.AddDays(-116),

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

                UpdatedAt = DateTime.Now.AddDays(-115),

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

                UpdatedAt = DateTime.Now.AddDays(-114),

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

                UpdatedAt = DateTime.Now.AddDays(-113),

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

                UpdatedAt = DateTime.Now.AddDays(-112),

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

                UpdatedAt = DateTime.Now.AddDays(-111),

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

                UpdatedAt = DateTime.Now.AddDays(-110),

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

                UpdatedAt = DateTime.Now.AddDays(-109),

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

                UpdatedAt = DateTime.Now.AddDays(-108),

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

                UpdatedAt = DateTime.Now.AddDays(-107),

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

                UpdatedAt = DateTime.Now.AddDays(-106),

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

                UpdatedAt = DateTime.Now.AddDays(-105),

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

                UpdatedAt = DateTime.Now.AddDays(-104),

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

                UpdatedAt = DateTime.Now.AddDays(-103),

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

                UpdatedAt = DateTime.Now.AddDays(-102),

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

                UpdatedAt = DateTime.Now.AddDays(-101),

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

                UpdatedAt = DateTime.Now.AddDays(-100),

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

                UpdatedAt = DateTime.Now.AddDays(-99),

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

                UpdatedAt = DateTime.Now.AddDays(-98),

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

                UpdatedAt = DateTime.Now.AddDays(-97),

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

                UpdatedAt = DateTime.Now.AddDays(-96),

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

                UpdatedAt = DateTime.Now.AddDays(-95),

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

                UpdatedAt = DateTime.Now.AddDays(-94),

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

                UpdatedAt = DateTime.Now.AddDays(-93),

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

                UpdatedAt = DateTime.Now.AddDays(-92),

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

                UpdatedAt = DateTime.Now.AddDays(-91),

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

                UpdatedAt = DateTime.Now.AddDays(-90),

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

                UpdatedAt = DateTime.Now.AddDays(-89),

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

                UpdatedAt = DateTime.Now.AddDays(-88),

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

                UpdatedAt = DateTime.Now.AddDays(-87),

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

                UpdatedAt = DateTime.Now.AddDays(-86),

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

                UpdatedAt = DateTime.Now.AddDays(-85),

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

                UpdatedAt = DateTime.Now.AddDays(-84),

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

                UpdatedAt = DateTime.Now.AddDays(-83),

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

                UpdatedAt = DateTime.Now.AddDays(-82),

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

                UpdatedAt = DateTime.Now.AddDays(-81),

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

                UpdatedAt = DateTime.Now.AddDays(-80),

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

                UpdatedAt = DateTime.Now.AddDays(-79),

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

                UpdatedAt = DateTime.Now.AddDays(-78),

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

                UpdatedAt = DateTime.Now.AddDays(-77),

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

                UpdatedAt = DateTime.Now.AddDays(-76),

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

                UpdatedAt = DateTime.Now.AddDays(-75),

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

                UpdatedAt = DateTime.Now.AddDays(-74),

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

                UpdatedAt = DateTime.Now.AddDays(-73),

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

                UpdatedAt = DateTime.Now.AddDays(-72),

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

                UpdatedAt = DateTime.Now.AddDays(-71),

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

                UpdatedAt = DateTime.Now.AddDays(-70),

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

                UpdatedAt = DateTime.Now.AddDays(-69),

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

                UpdatedAt = DateTime.Now.AddDays(-68),

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

                UpdatedAt = DateTime.Now.AddDays(-67),

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

                UpdatedAt = DateTime.Now.AddDays(-66),

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

                UpdatedAt = DateTime.Now.AddDays(-65),

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

                UpdatedAt = DateTime.Now.AddDays(-64),

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

                UpdatedAt = DateTime.Now.AddDays(-63),

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

                UpdatedAt = DateTime.Now.AddDays(-62),

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

                UpdatedAt = DateTime.Now.AddDays(-61),

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

                UpdatedAt = DateTime.Now.AddDays(-60),

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

                UpdatedAt = DateTime.Now.AddDays(-59),

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

                UpdatedAt = DateTime.Now.AddDays(-58),

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

                UpdatedAt = DateTime.Now.AddDays(-57),

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

                UpdatedAt = DateTime.Now.AddDays(-56),

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

                UpdatedAt = DateTime.Now.AddDays(-55),

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

                UpdatedAt = DateTime.Now.AddDays(-54),

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

                UpdatedAt = DateTime.Now.AddDays(-53),

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

                UpdatedAt = DateTime.Now.AddDays(-52),

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

                UpdatedAt = DateTime.Now.AddDays(-51),

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

                UpdatedAt = DateTime.Now.AddDays(-50),

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

                UpdatedAt = DateTime.Now.AddDays(-49),

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

                UpdatedAt = DateTime.Now.AddDays(-48),

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

                UpdatedAt = DateTime.Now.AddDays(-47),

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

                UpdatedAt = DateTime.Now.AddDays(-46),

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

                UpdatedAt = DateTime.Now.AddDays(-45),

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

                UpdatedAt = DateTime.Now.AddDays(-44),

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

                UpdatedAt = DateTime.Now.AddDays(-43),

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

                UpdatedAt = DateTime.Now.AddDays(-42),

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

                UpdatedAt = DateTime.Now.AddDays(-41),

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

                UpdatedAt = DateTime.Now.AddDays(-40),

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

                UpdatedAt = DateTime.Now.AddDays(-39),

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

                UpdatedAt = DateTime.Now.AddDays(-38),

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

                UpdatedAt = DateTime.Now.AddDays(-37),

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

                UpdatedAt = DateTime.Now.AddDays(-36),

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

                UpdatedAt = DateTime.Now.AddDays(-35),

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

                UpdatedAt = DateTime.Now.AddDays(-34),

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

                UpdatedAt = DateTime.Now.AddDays(-33),

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

                UpdatedAt = DateTime.Now.AddDays(-32),

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

                UpdatedAt = DateTime.Now.AddDays(-31),

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

                UpdatedAt = DateTime.Now.AddDays(-30),

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

                UpdatedAt = DateTime.Now.AddDays(-29),

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

                UpdatedAt = DateTime.Now.AddDays(-28),

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

                UpdatedAt = DateTime.Now.AddDays(-27),

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

                UpdatedAt = DateTime.Now.AddDays(-26),

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

                UpdatedAt = DateTime.Now.AddDays(-25),

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

                UpdatedAt = DateTime.Now.AddDays(-24),

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

                UpdatedAt = DateTime.Now.AddDays(-23),

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

                UpdatedAt = DateTime.Now.AddDays(-22),

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

                UpdatedAt = DateTime.Now.AddDays(-21),

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

                UpdatedAt = DateTime.Now.AddDays(-20),

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

                UpdatedAt = DateTime.Now.AddDays(-19),

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

                UpdatedAt = DateTime.Now.AddDays(-18),

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

                UpdatedAt = DateTime.Now.AddDays(-17),

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

                UpdatedAt = DateTime.Now.AddDays(-16),

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

                UpdatedAt = DateTime.Now.AddDays(-15),

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

                UpdatedAt = DateTime.Now.AddDays(-14),

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

                UpdatedAt = DateTime.Now.AddDays(-13),

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

                UpdatedAt = DateTime.Now.AddDays(-12),

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

                UpdatedAt = DateTime.Now.AddDays(-11),

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

                UpdatedAt = DateTime.Now.AddDays(-10),

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

                UpdatedAt = DateTime.Now.AddDays(-9),

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

                UpdatedAt = DateTime.Now.AddDays(-8),

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

                UpdatedAt = DateTime.Now.AddDays(-7),

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

                UpdatedAt = DateTime.Now.AddDays(-6),

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

                UpdatedAt = DateTime.Now.AddDays(-5),

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

                UpdatedAt = DateTime.Now.AddDays(-4),

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

                UpdatedAt = DateTime.Now.AddDays(-3),

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

                UpdatedAt = DateTime.Now.AddDays(-2),

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

                UpdatedAt = DateTime.Now.AddDays(-1),

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

                UpdatedAt = DateTime.Now.AddDays(0),

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

                UpdatedAt = DateTime.Now.AddDays(-204),

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

                UpdatedAt = DateTime.Now.AddDays(-203),

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

                UpdatedAt = DateTime.Now.AddDays(-202),

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

                UpdatedAt = DateTime.Now.AddDays(-201),

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

                UpdatedAt = DateTime.Now.AddDays(-200),

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

                UpdatedAt = DateTime.Now.AddDays(-199),

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

                UpdatedAt = DateTime.Now.AddDays(-198),

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

                UpdatedAt = DateTime.Now.AddDays(-197),

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

                UpdatedAt = DateTime.Now.AddDays(-196),

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

                UpdatedAt = DateTime.Now.AddDays(-195),

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

                UpdatedAt = DateTime.Now.AddDays(-194),

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

                UpdatedAt = DateTime.Now.AddDays(-193),

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

                UpdatedAt = DateTime.Now.AddDays(-192),

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

                UpdatedAt = DateTime.Now.AddDays(-191),

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

                UpdatedAt = DateTime.Now.AddDays(-190),

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

                UpdatedAt = DateTime.Now.AddDays(-189),

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

                UpdatedAt = DateTime.Now.AddDays(-188),

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

                UpdatedAt = DateTime.Now.AddDays(-187),

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

                UpdatedAt = DateTime.Now.AddDays(-186),

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

                UpdatedAt = DateTime.Now.AddDays(-185),

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

                UpdatedAt = DateTime.Now.AddDays(-184),

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

                UpdatedAt = DateTime.Now.AddDays(-183),

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

                UpdatedAt = DateTime.Now.AddDays(-182),

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

                UpdatedAt = DateTime.Now.AddDays(-181),

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

                UpdatedAt = DateTime.Now.AddDays(-180),

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

                UpdatedAt = DateTime.Now.AddDays(-179),

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

                UpdatedAt = DateTime.Now.AddDays(-178),

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

                UpdatedAt = DateTime.Now.AddDays(-177),

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

                UpdatedAt = DateTime.Now.AddDays(-176),

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

                UpdatedAt = DateTime.Now.AddDays(-175),

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

                UpdatedAt = DateTime.Now.AddDays(-174),

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

                UpdatedAt = DateTime.Now.AddDays(-173),

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

                UpdatedAt = DateTime.Now.AddDays(-172),

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

                UpdatedAt = DateTime.Now.AddDays(-171),

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

                UpdatedAt = DateTime.Now.AddDays(-170),

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

                UpdatedAt = DateTime.Now.AddDays(-169),

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

                UpdatedAt = DateTime.Now.AddDays(-168),

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

                UpdatedAt = DateTime.Now.AddDays(-167),

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

                UpdatedAt = DateTime.Now.AddDays(-166),

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

                UpdatedAt = DateTime.Now.AddDays(-165),

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

                UpdatedAt = DateTime.Now.AddDays(-164),

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

                UpdatedAt = DateTime.Now.AddDays(-163),

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

                UpdatedAt = DateTime.Now.AddDays(-162),

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

                UpdatedAt = DateTime.Now.AddDays(-161),

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

                UpdatedAt = DateTime.Now.AddDays(-160),

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

                UpdatedAt = DateTime.Now.AddDays(-159),

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

                UpdatedAt = DateTime.Now.AddDays(-158),

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

                UpdatedAt = DateTime.Now.AddDays(-157),

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

                UpdatedAt = DateTime.Now.AddDays(-156),

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

                UpdatedAt = DateTime.Now.AddDays(-155),

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

                UpdatedAt = DateTime.Now.AddDays(-154),

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

                UpdatedAt = DateTime.Now.AddDays(-153),

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

                UpdatedAt = DateTime.Now.AddDays(-152),

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

                UpdatedAt = DateTime.Now.AddDays(-151),

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

                UpdatedAt = DateTime.Now.AddDays(-150),

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

                UpdatedAt = DateTime.Now.AddDays(-149),

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

                UpdatedAt = DateTime.Now.AddDays(-148),

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

                UpdatedAt = DateTime.Now.AddDays(-147),

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

                UpdatedAt = DateTime.Now.AddDays(-146),

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

                UpdatedAt = DateTime.Now.AddDays(-145),

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

                UpdatedAt = DateTime.Now.AddDays(-144),

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

                UpdatedAt = DateTime.Now.AddDays(-143),

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

                UpdatedAt = DateTime.Now.AddDays(-142),

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

                UpdatedAt = DateTime.Now.AddDays(-141),

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

                UpdatedAt = DateTime.Now.AddDays(-140),

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

                UpdatedAt = DateTime.Now.AddDays(-139),

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

                UpdatedAt = DateTime.Now.AddDays(-138),

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

                UpdatedAt = DateTime.Now.AddDays(-137),

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

                UpdatedAt = DateTime.Now.AddDays(-136),

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

                UpdatedAt = DateTime.Now.AddDays(-135),

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

                UpdatedAt = DateTime.Now.AddDays(-134),

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

                UpdatedAt = DateTime.Now.AddDays(-133),

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

                UpdatedAt = DateTime.Now.AddDays(-132),

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

                UpdatedAt = DateTime.Now.AddDays(-131),

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

                UpdatedAt = DateTime.Now.AddDays(-130),

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

                UpdatedAt = DateTime.Now.AddDays(-129),

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

                UpdatedAt = DateTime.Now.AddDays(-128),

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

                UpdatedAt = DateTime.Now.AddDays(-127),

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

                UpdatedAt = DateTime.Now.AddDays(-126),

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

                UpdatedAt = DateTime.Now.AddDays(-125),

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

                UpdatedAt = DateTime.Now.AddDays(-124),

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

                UpdatedAt = DateTime.Now.AddDays(-123),

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

                UpdatedAt = DateTime.Now.AddDays(-122),

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

                UpdatedAt = DateTime.Now.AddDays(-121),

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

                UpdatedAt = DateTime.Now.AddDays(-120),

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

                UpdatedAt = DateTime.Now.AddDays(-119),

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

                UpdatedAt = DateTime.Now.AddDays(-118),

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

                UpdatedAt = DateTime.Now.AddDays(-117),

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

                UpdatedAt = DateTime.Now.AddDays(-116),

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

                UpdatedAt = DateTime.Now.AddDays(-115),

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

                UpdatedAt = DateTime.Now.AddDays(-114),

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

                UpdatedAt = DateTime.Now.AddDays(-113),

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

                UpdatedAt = DateTime.Now.AddDays(-112),

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

                UpdatedAt = DateTime.Now.AddDays(-111),

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

                UpdatedAt = DateTime.Now.AddDays(-110),

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

                UpdatedAt = DateTime.Now.AddDays(-109),

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

                UpdatedAt = DateTime.Now.AddDays(-108),

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

                UpdatedAt = DateTime.Now.AddDays(-107),

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

                UpdatedAt = DateTime.Now.AddDays(-106),

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

                UpdatedAt = DateTime.Now.AddDays(-105),

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

                UpdatedAt = DateTime.Now.AddDays(-104),

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

                UpdatedAt = DateTime.Now.AddDays(-103),

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

                UpdatedAt = DateTime.Now.AddDays(-102),

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

                UpdatedAt = DateTime.Now.AddDays(-101),

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

                UpdatedAt = DateTime.Now.AddDays(-100),

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

                UpdatedAt = DateTime.Now.AddDays(-99),

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

                UpdatedAt = DateTime.Now.AddDays(-98),

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

                UpdatedAt = DateTime.Now.AddDays(-97),

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

                UpdatedAt = DateTime.Now.AddDays(-96),

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

                UpdatedAt = DateTime.Now.AddDays(-95),

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

                UpdatedAt = DateTime.Now.AddDays(-94),

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

                UpdatedAt = DateTime.Now.AddDays(-93),

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

                UpdatedAt = DateTime.Now.AddDays(-92),

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

                UpdatedAt = DateTime.Now.AddDays(-91),

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

                UpdatedAt = DateTime.Now.AddDays(-90),

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

                UpdatedAt = DateTime.Now.AddDays(-89),

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

                UpdatedAt = DateTime.Now.AddDays(-88),

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

                UpdatedAt = DateTime.Now.AddDays(-87),

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

                UpdatedAt = DateTime.Now.AddDays(-86),

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

                UpdatedAt = DateTime.Now.AddDays(-85),

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

                UpdatedAt = DateTime.Now.AddDays(-84),

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

                UpdatedAt = DateTime.Now.AddDays(-83),

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

                UpdatedAt = DateTime.Now.AddDays(-82),

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

                UpdatedAt = DateTime.Now.AddDays(-81),

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

                UpdatedAt = DateTime.Now.AddDays(-80),

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

                UpdatedAt = DateTime.Now.AddDays(-79),

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

                UpdatedAt = DateTime.Now.AddDays(-78),

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

                UpdatedAt = DateTime.Now.AddDays(-77),

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

                UpdatedAt = DateTime.Now.AddDays(-76),

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

                UpdatedAt = DateTime.Now.AddDays(-75),

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

                UpdatedAt = DateTime.Now.AddDays(-74),

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

                UpdatedAt = DateTime.Now.AddDays(-73),

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

                UpdatedAt = DateTime.Now.AddDays(-72),

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

                UpdatedAt = DateTime.Now.AddDays(-71),

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

                UpdatedAt = DateTime.Now.AddDays(-70),

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

                UpdatedAt = DateTime.Now.AddDays(-69),

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

                UpdatedAt = DateTime.Now.AddDays(-68),

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

                UpdatedAt = DateTime.Now.AddDays(-67),

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

                UpdatedAt = DateTime.Now.AddDays(-66),

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

                UpdatedAt = DateTime.Now.AddDays(-65),

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

                UpdatedAt = DateTime.Now.AddDays(-64),

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

                UpdatedAt = DateTime.Now.AddDays(-63),

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

                UpdatedAt = DateTime.Now.AddDays(-62),

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

                UpdatedAt = DateTime.Now.AddDays(-61),

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

                UpdatedAt = DateTime.Now.AddDays(-60),

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

                UpdatedAt = DateTime.Now.AddDays(-59),

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

                UpdatedAt = DateTime.Now.AddDays(-58),

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

                UpdatedAt = DateTime.Now.AddDays(-57),

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

                UpdatedAt = DateTime.Now.AddDays(-56),

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

                UpdatedAt = DateTime.Now.AddDays(-55),

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

                UpdatedAt = DateTime.Now.AddDays(-54),

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

                UpdatedAt = DateTime.Now.AddDays(-53),

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

                UpdatedAt = DateTime.Now.AddDays(-52),

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

                UpdatedAt = DateTime.Now.AddDays(-51),

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

                UpdatedAt = DateTime.Now.AddDays(-50),

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

                UpdatedAt = DateTime.Now.AddDays(-49),

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

                UpdatedAt = DateTime.Now.AddDays(-48),

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

                UpdatedAt = DateTime.Now.AddDays(-47),

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

                UpdatedAt = DateTime.Now.AddDays(-46),

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

                UpdatedAt = DateTime.Now.AddDays(-45),

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

                UpdatedAt = DateTime.Now.AddDays(-44),

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

                UpdatedAt = DateTime.Now.AddDays(-43),

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

                UpdatedAt = DateTime.Now.AddDays(-42),

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

                UpdatedAt = DateTime.Now.AddDays(-41),

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

                UpdatedAt = DateTime.Now.AddDays(-40),

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

                UpdatedAt = DateTime.Now.AddDays(-39),

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
                UpdatedAt = DateTime.Now.AddDays(-204),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 2,
                Name = "Ô tô điện thông minh vf-e34",
                Description = "Thuộc phân khúc C, từng được công bố vào tháng 1/2021 với tên mã VF31. Xe có chiều dài cơ sở 2.611mm, kích thước các chiều dài x rộng x cao là 4.300 x 1.793 x 1.613 (mm), khoảng sáng gầm xe 180mm, trọng lượng không tải 1.490kg. VinFast VF e34 được trang bị một động cơ điện có công suất tối đa 110 kW ( 147 HP), mô-men xoắn cực đại 242 Nm cùng hệ dẫn động cầu trước, hệ thống treo trước MacPherson, hệ thống treo sau dạng thanh xoắn. Xe sử dụng một bộ pin dung lượng 42kWh, có thể đi được quãng đường 300km sau mỗi lần sạc đầy. Để minh chứng cho đẳng cấp, chất lượng và tạo sự an tâm cho khách hàng, VinFast tiên phong áp dụng chính sách bảo hành lên tới 10 năm cho xe VF e34",
                ClientId = 2,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-203),
                UpdatedAt = DateTime.Now.AddDays(-203),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 3,
                Name = "Xi măng Nghi Sơn đa dụng",
                Description = "chất lượng PCB40, được sản xuất từ công nghệ Nhật tiên tiến, chất lượng được kiểm soát bởi các chuyên gia Nhật Bản",
                ClientId = 3,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-202),
                UpdatedAt = DateTime.Now.AddDays(-202),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 4,
                Name = "Gạch bê tông AAC",
                Description = "Gạch bê tông AAC (viết tắt của ba từ tiếng Anh là “Aerated Autoclaved Concrete”) hay còn có tên là “gạch bê tông khí chưng áp” đây là loại vật liệu mới trong xây dựng với kết cấu bê tông gồm các bọt khí nhỏ. Mặc dù đã xuất hiện và bắt đầu sử dụng trên Thế Giới gần 1 thế kỷ trước. Tuy nhiên đến năm 2008 Việt Nam mới bắt đầu nhập khẩu và sử dụng loại vật liệu này.Đây được xem là vật liệu xanh vì có thể tái sử dụng. Được sản xuất bằng công nghệ khí chưng áp từ các nguyên liệu như cát, vôi, thạch cao, xi măng, bột nhôm và không gây ô nhiễm nên thân thiện môi trường.",
                ClientId = 4,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-201),
                UpdatedAt = DateTime.Now.AddDays(-201),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 5,
                Name = "Tấm panel ALC",
                Description = "ALC (Autoclaced Lightweight Aerated Concrete) hay được gọi là “Bê tông gia khí chưng áp. Tấm tường Panel được sản xuất bằng các nguyên liệu giống với nguyên liệu tạo ra sản phẩm gạch nhẹ AAC. Với khả năng chịu lực cao, tấm ALC được chế tạo bằng 2 lớp thép (thép nguội), cấu trúc không gian 3 chiều nên tạo ra một bộ khung cứng và vững chắc. Ứng dụng để làm tường, sàn, cầu thang, mái,… Có thể gia công cưa, cắt, khoan hay đóng đinh một cách đơn giản, tốn ít thời gian, quá trình lắp đặt nhanh chóng thuận tiện.",
                ClientId = 5,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-200),
                UpdatedAt = DateTime.Now.AddDays(-200),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 6,
                Name = "Xi măng công nghệ nano",
                Description = "Đây là sản phẩm vật liệu mới trong xây dựng nhà ở và công trình. Sản phẩm có độ cứng và độ bền vượt trội. Với công thức độc đáo đây là công nghệ vật liệu mới trong xây dựng – công nghệ độc quyền của SCG giúp cải tiến chất lượng xi măng, các phân tử xi măng tạo ra ở kích thước nano nên tạo ra liên kết vô cùng chặt chẽ nên giảm thiểu khả năng nứt, rò rỉ của công trình một trong những nguyên nhân gây ra chính là do các lỗ rỗng trong quá trình trộn bê tông tạo ra khi sử dụng xi măng cũ tiếp xúc với các tác nhân môi trường như nắng, gió, mưa,..",
                ClientId = 6,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-199),
                UpdatedAt = DateTime.Now.AddDays(-199),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 7,
                Name = "Tấm tường bê tông đúc sẵn",
                Description = "Ưu điểm dễ dàng thi công lắp đặt với 6m2 tường chỉ cần 3 công nhân làm việc trong 1 giờ đồng hồ nên giúp tiết kiệm nhân lực lao động. So với các loại truyền thống như tường gạch, block bê tông thì tấm tường bê tông đúc sẵn này có tuổi thọ cao hơn, giảm chi phí sử dụng vật liệu hơn do có chiều dày nhỏ hơn chỉ khoảng 68 – 140 mm nên còn giúp tiết kiệm không gian lắp đặt tăng diện tích sử dụng cho nhà ở hoặc công trình.",
                ClientId = 7,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-198),
                UpdatedAt = DateTime.Now.AddDays(-198),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 8,
                Name = "Gạch men và sứ vệ sinh kháng khuẩn",
                Description = "Đây là dòng sản phẩm với khả năng tự tiêu diệt vi khuẩn khi bám trên bề mặt sản phẩm. Ở nước ngoài đây là loại vật liệu chủ yếu dùng trong các cơ sở y tế và bệnh viện. Với lớp men Nano phun trực tiếp lên sản phẩm và nung ở nhiệt độ 1200 – 1250 độ C, giúp cho lớp men này trở nên siêu bền trên bề mặt, chống bám dính, ổ bẩn cũng như góp phần tăng độ nhẵn mịn bóng loáng cho sản phẩm.",
                ClientId = 8,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-197),
                UpdatedAt = DateTime.Now.AddDays(-197),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 9,
                Name = "METRO STAR",
                Description = "Metro Star có vị trí đắc địa ở địa chỉ 360 Xa Lộ Hà Nội, nằm trong khu dân cư đông đúc, sôi động của cửa ngõ phía Đông Sài Gòn - nơi có hai mặt tiền đường là Xa lộ Hà Nội và Nam Hòa cùng với công viên cỏ xanh  rộng rãi, thoáng đãng, đặc biệt là dự án hiếm hoi có cầu bộ hành kết nối trực tiếp từ ga Metro số 10 đi vào tầng 2 khu dân cư.Metro Star được đầu tư phát triển bởi Công ty Metro Star, trực thuộc Tổng Công ty C.T Land (thành viên Tập đoàn C.T Group - Tập đoàn đa ngành hàng đầu Việt Nam), mang đến một “siêu phẩm” độc đáo về kiến trúc, chất lượng xây dựng tiêu chuẩn Singapore và 100+ tiện ích đậm chất quốc đảo sư tử.",
                ClientId = 9,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-196),
                UpdatedAt = DateTime.Now.AddDays(-196),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 10,
                Name = "C.T PLAZA",
                Description = "C.T Plaza là một thương hiệu nhà ở và thương mại văn phòng rất đặc biệt, là sự kết hợp hài hòa giữa 3 đỉnh cao: Nghệ thuật của Tạo hóa là Thiên nhiên tươi đẹp, Nghệ thuật của Nhân loại là Kiến trúc, Hội họa, Âm nhạc, Phim ảnh…và đẹp hơn hết là Con người với cái đẹp của thân thể và tâm hồn…nơi con người có thể nâng cuộc sống hằng ngày lên thành Nghệ thuật sống cuộc đời (Living Art) để mỗi người hạnh phúc tuyệt vời theo cách riêng trong ngôi nhà của mình (A Life Style Home Brand).",
                ClientId = 10,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-195),
                UpdatedAt = DateTime.Now.AddDays(-195),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 11,
                Name = "I-HOME",
                Description = "Thương hiệu I-Home cực kỳ mới lạ và đặc biệt yêu thích bởi giới trẻ với concept rất thú vị và giá rất nice. Là sự kết hợp giữa Home và Internet trong 1 thế giới phẳng. Khu I-Home tại 359 Phạm Văn Chiêu, Q.Gò Vấp với vị trí thuận lợi, tiện ích nội khu vượt trội, thiết kế thông minh, nội thất cao cấp nhưng giá chỉ bằng giá nhà ở xã hội, Khai trương và vận hành chính thức tòa nhà vào đầu tháng 04/2017.",
                ClientId = 11,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-194),
                UpdatedAt = DateTime.Now.AddDays(-194),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 12,
                Name = "The Zen Park",
                Description = "Tổng diện tích đất: 28.834 m2 Tổng số tòa: 4 (R1.01, R1.02, R1.03, R1.05) Số tầng mỗi tòa: 31 tầng nổi Diện tích tầng hầm: ~ 24.000 m2 Diện tích cây xanh: 6.208 m2 Diện tích mặt nước Hồ cá Koi: 692 m2 Toà mở bán: 2 toà (R1.02 & R1.05) Số lượng mở bán - 7 loại căn hộ: Studio (52 căn) : 1PN: 271 căn, 1PN+1: 263 căn, 2PN: 224 căn, 2PN+1: 85 căn, 3PN: 31 căn, 3PN+1: 35 cănCác loại căn hộ diện tích linh hoạt (từ 28m2 đến 95 m2)",
                ClientId = 12,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-193),
                UpdatedAt = DateTime.Now.AddDays(-193),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 13,
                Name = "Vinhome Ocean Park",
                Description = "Được quy hoạch bởi đơn vị tư vấn thiết kế hàng đầu thế giới EDSA, với mật độ xây dựng thấp chỉ gần 19% Vinhomes Ocean Park mang tầm vóc một đại đô thị đồng bộ tiện ích như Đảo quốc Singapore. Và hơn thế nữa, dự án sở hữu những đại tiện ích và cảnh quan quy mô tầm cỡ, mới mẻ như Công viên Gym ngoài trời, Công viên BBQ rộng lớn trên nền tảng không gian cây xanh, mặt nước đa dạng.",
                ClientId = 13,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-192),
                UpdatedAt = DateTime.Now.AddDays(-192),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 14,
                Name = "VegaCity",
                Description = "Với muôn vàn cung bậc của trái tim, từ êm đềm thảnh thơi đến cháy bừng hứng khởi, Vega Continental Shopping Plaza mang đậm cảm hứng cuộc đại hải trình vĩ đại, nơi nhịp sống rộn ràng không ngừng nghỉ, thắp sáng lên một khung trời lễ hội.",
                ClientId = 14,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-191),
                UpdatedAt = DateTime.Now.AddDays(-191),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 15,
                Name = "Shophouse Bình Minh Garden",
                Description = "Vị trí: Số 93 phố Đức Giang, phường Đức Giang, quận Long Biên, Hà Nội Chủ đầu tư: Công ty cổ phần đầu tư và phát triển BĐS Thế Kỷ - Cen Invest Diện tích khu thấp tầng: 9.511m2 Mật độ xây dựng thấp tầng: 70% Nhà thầu thiết kế: Công ty CP tư vấn AA (AA – Corp)",
                ClientId = 15,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-190),
                UpdatedAt = DateTime.Now.AddDays(-190),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 16,
                Name = "Chung cư Bình Minh Garden",
                Description = "Được định hướng phát triển cuộc sống năng động, đầy đủ, mọi tiện ích phục vụ nhu cầu hàng ngày của cư dân được bố trí ngay trong nội khu dự án từ ăn uống, mua sắm, dịch vụ làm đẹp, ngân hàng,…",
                ClientId = 16,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-189),
                UpdatedAt = DateTime.Now.AddDays(-189),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 17,
                Name = "Chung Cư Cao Cấp I Tower Quy Nhơn",
                Description = "I–Tower Quy Nhơn là dự án chung cư căn hộ thương mại cao cấp được UBND tỉnh chấp thuận chủ trương đầu tư từ đầu năm 2015 do Công ty CP Đầu tư Phát triển bất động sản Đô Thành làm chủ đầu tư. Đây là dự án sở hữu vị trí “Vàng” ngay trung tâm Tp biển Quy Nhơn.",
                ClientId = 17,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-188),
                UpdatedAt = DateTime.Now.AddDays(-188),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 18,
                Name = "La Queenara Hội An",
                Description = "Lấy cảm hứng thiết kế từ câu chuyện di sản và con người Hội An, La Queenara gây ấn tượng  với hệ sinh thái 200 tiện ích phức hợp, tạo nên tổng thể hài hòa kiến tạo cộng đồng tinh hoa ngay trong lòng thành phố di sản: ",
                ClientId = 18,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-187),
                UpdatedAt = DateTime.Now.AddDays(-187),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 19,
                Name = "Samsora Premier 105",
                Description = "Samsora Premier là dự án chung cư nằm ngay trên mặt đường Chu Văn An huyết mạch kết nối giao thông phía Đông Bắc và Tây Nam thành phố. Dự án được nhiều khách hàng biết tới với quy hoạch hiện đại và hạ tầng tiện ích đầu tư chất lượng.",
                ClientId = 19,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-186),
                UpdatedAt = DateTime.Now.AddDays(-186),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 20,
                Name = "Vườn Vua Resort & Villas",
                Description = "Từ thủ đô Hà Nội đi theo đường Đại Lộ Thăng Long, qua Làng Văn hóa các Dân tộc Việt Nam, lên thẳng Đá Chông (khu di tích K9), qua Cầu Đồng Quang - Phà Đá Chông vượt Sông Đà 2km là đến Vườn Vua, với khoảng 65km từ Hà Nội. Nếu đi theo đường quốc lộ 32 qua cầu Trung Hà, qua huyện lỵ Thanh Thuỷ đến Vườn Vua khoảng 85km.",
                ClientId = 20,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-185),
                UpdatedAt = DateTime.Now.AddDays(-185),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 21,
                Name = "Khai Sơn Town",
                Description = "Nằm cách phố cổ chỉ 10 phút di chuyển, dự án Khai Sơn Town thuộc quần thể đô thị Khai Sơn City Long Biên được thừa hưởng nhiều ưu thế để phát triển mạnh mẽ trong tương lai. Dự án không chỉ có ưu thế về liên kết hạ tầng giao thông, tiện ích, mà còn có nhiều tiềm năng tăng giá, xứng đáng là khoản đầu tư không thể bỏ qua của các nhà đầu tư.",
                ClientId = 21,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-184),
                UpdatedAt = DateTime.Now.AddDays(-184),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 22,
                Name = "Mercedes-Benz GLS 600 Maybach",
                Description = "Tình trạng Mới Năm sản xuất 2021 Kiểu dáng SUV Xuất xứ Nhập khẩu Hộp số Số tự động",
                ClientId = 22,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-183),
                UpdatedAt = DateTime.Now.AddDays(-183),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 23,
                Name = "Toyota Crown Royal Saloon 3.0 MT bản full",
                Description = "Tình trạng Đã qua sử dụng Số km đã đi 32.000 km Năm sản xuất 1998 Kiểu dáng Sedan Xuất xứ Nhập khẩu Hộp số Số tay",
                ClientId = 23,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-182),
                UpdatedAt = DateTime.Now.AddDays(-182),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 24,
                Name = "Xe tải Hino FG tải 8 tấn thùng dài",
                Description = "Tình trạng Mới Năm sản xuất 2020 Kiểu dáng Truck Xuất xứ Lắp ráp Hộp số Số tay Địa chỉ rao bán Tp.HCM",
                ClientId = 24,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-181),
                UpdatedAt = DateTime.Now.AddDays(-181),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 25,
                Name = "Kia Cerato 2.0AT",
                Description = "Tình trạng Đã qua sử dụng Số km đã đi 12.000 km Năm sản xuất 2019 Kiểu dáng Sedan Hộp số Số tự động Địa chỉ rao bán Tp.HCM",
                ClientId = 25,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-180),
                UpdatedAt = DateTime.Now.AddDays(-180),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 26,
                Name = "Toyota Land Cruiser 1998",
                Description = "Tình trạng Đã qua sử dụng Số km đã đi 18.000 km Năm sản xuất 1998 Kiểu dáng SUV Xuất xứ Nhập khẩu Hộp số Số tay Địa chỉ rao bán Hà Nội",
                ClientId = 26,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-179),
                UpdatedAt = DateTime.Now.AddDays(-179),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 27,
                Name = "Lexus RX 350 F-Sport 2016",
                Description = "Tình trạng Đã qua sử dụngSố km đã đi22.000 kmNăm sản xuất2016Kiểu dángSUVXuất xứNhập khẩuHộp sốSố tự động",
                ClientId = 27,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-178),
                UpdatedAt = DateTime.Now.AddDays(-178),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 28,
                Name = "Mercedes G63 Edition 1",
                Description = "Tình trạng Mới Năm sản xuất 2021 Kiểu dáng SUV Xuất xứ Nhập khẩu Hộp số Số tự động Địa chỉ rao bán Hà Nội",
                ClientId = 28,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-177),
                UpdatedAt = DateTime.Now.AddDays(-177),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 29,
                Name = "Mazda CX 5 2019",
                Description = "Tình trạng Đã qua sử dụng Số km đã đi 27.000 km Năm sản xuất 2019 Kiểu dáng SUV Hộp số Số tự động Địa chỉ rao bán Tp.HCM",
                ClientId = 29,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-176),
                UpdatedAt = DateTime.Now.AddDays(-176),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 30,
                Name = "Volkswagen T-Cross",
                Description = "Cùng với Teramont, Volkswagen T-Cross 2021 được đồn đoán là mẫu xe hoàn toàn mới sẽ gia nhập đội hình sản phẩm xe hơi của Volkswagen (VW) tại Việt Nam trong năm 2021. Hiện tại, VW Việt Nam vẫn chưa tiết lộ bất cứ thông tin nào về kế hoạch ra mắt T-Cross 2021 tại Việt Nam.",
                ClientId = 30,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-175),
                UpdatedAt = DateTime.Now.AddDays(-175),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 31,
                Name = "Dự án The Filmore Đà Nẵng",
                Description = "Diện tích khu đất 1.504,2 m2 với quy mô 25 tầng nổi, 3 tầng hầm và 206 căn hộ cao cấp (gồm các căn hộ 1 phòng ngủ, 2 phòng ngủ, 3 phòng ngủ - Duplex, Dual Key). Tổng diện tích sàn xây dựng hơn 22.600 m2, diện tích sàn nhà ở khoảng 12.876 m2, diện tích sàn sử dụng thương mại dịch vụ gần 300 m2. Mật độ xây dựng khối đế 55,6%, khối tháp 47,8%. Dự án dự kiến hoàn thành và bàn giao vào quý IV/2022.",
                ClientId = 31,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-204),
                UpdatedAt = DateTime.Now.AddDays(-204),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 32,
                Name = "Ô tô điện thông minh vf-e35",
                Description = "Thuộc phân khúc C, từng được công bố vào tháng 1/2021 với tên mã VF31. Xe có chiều dài cơ sở 2.611mm, kích thước các chiều dài x rộng x cao là 4.300 x 1.793 x 1.613 (mm), khoảng sáng gầm xe 180mm, trọng lượng không tải 1.490kg. VinFast VF e34 được trang bị một động cơ điện có công suất tối đa 110 kW ( 147 HP), mô-men xoắn cực đại 242 Nm cùng hệ dẫn động cầu trước, hệ thống treo trước MacPherson, hệ thống treo sau dạng thanh xoắn. Xe sử dụng một bộ pin dung lượng 42kWh, có thể đi được quãng đường 300km sau mỗi lần sạc đầy. Để minh chứng cho đẳng cấp, chất lượng và tạo sự an tâm cho khách hàng, VinFast tiên phong áp dụng chính sách bảo hành lên tới 10 năm cho xe VF e35",
                ClientId = 32,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-203),
                UpdatedAt = DateTime.Now.AddDays(-203),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 33,
                Name = "Xi măng Nghi Sơn đa dụng",
                Description = "chất lượng PCB40, được sản xuất từ công nghệ Nhật tiên tiến, chất lượng được kiểm soát bởi các chuyên gia Nhật Bản",
                ClientId = 33,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-202),
                UpdatedAt = DateTime.Now.AddDays(-202),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 34,
                Name = "Gạch bê tông AAC",
                Description = "Gạch bê tông AAC (viết tắt của ba từ tiếng Anh là “Aerated Autoclaved Concrete”) hay còn có tên là “gạch bê tông khí chưng áp” đây là loại vật liệu mới trong xây dựng với kết cấu bê tông gồm các bọt khí nhỏ. Mặc dù đã xuất hiện và bắt đầu sử dụng trên Thế Giới gần 1 thế kỷ trước. Tuy nhiên đến năm 2008 Việt Nam mới bắt đầu nhập khẩu và sử dụng loại vật liệu này.Đây được xem là vật liệu xanh vì có thể tái sử dụng. Được sản xuất bằng công nghệ khí chưng áp từ các nguyên liệu như cát, vôi, thạch cao, xi măng, bột nhôm và không gây ô nhiễm nên thân thiện môi trường.",
                ClientId = 34,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-201),
                UpdatedAt = DateTime.Now.AddDays(-201),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 35,
                Name = "Tấm panel ALC",
                Description = "ALC (Autoclaced Lightweight Aerated Concrete) hay được gọi là “Bê tông gia khí chưng áp. Tấm tường Panel được sản xuất bằng các nguyên liệu giống với nguyên liệu tạo ra sản phẩm gạch nhẹ AAC. Với khả năng chịu lực cao, tấm ALC được chế tạo bằng 2 lớp thép (thép nguội), cấu trúc không gian 3 chiều nên tạo ra một bộ khung cứng và vững chắc. Ứng dụng để làm tường, sàn, cầu thang, mái,… Có thể gia công cưa, cắt, khoan hay đóng đinh một cách đơn giản, tốn ít thời gian, quá trình lắp đặt nhanh chóng thuận tiện.",
                ClientId = 35,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-200),
                UpdatedAt = DateTime.Now.AddDays(-200),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 36,
                Name = "Xi măng công nghệ nano",
                Description = "Đây là sản phẩm vật liệu mới trong xây dựng nhà ở và công trình. Sản phẩm có độ cứng và độ bền vượt trội. Với công thức độc đáo đây là công nghệ vật liệu mới trong xây dựng – công nghệ độc quyền của SCG giúp cải tiến chất lượng xi măng, các phân tử xi măng tạo ra ở kích thước nano nên tạo ra liên kết vô cùng chặt chẽ nên giảm thiểu khả năng nứt, rò rỉ của công trình một trong những nguyên nhân gây ra chính là do các lỗ rỗng trong quá trình trộn bê tông tạo ra khi sử dụng xi măng cũ tiếp xúc với các tác nhân môi trường như nắng, gió, mưa,..",
                ClientId = 36,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-199),
                UpdatedAt = DateTime.Now.AddDays(-199),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 37,
                Name = "Tấm tường bê tông đúc sẵn",
                Description = "Ưu điểm dễ dàng thi công lắp đặt với 6m2 tường chỉ cần 3 công nhân làm việc trong 1 giờ đồng hồ nên giúp tiết kiệm nhân lực lao động. So với các loại truyền thống như tường gạch, block bê tông thì tấm tường bê tông đúc sẵn này có tuổi thọ cao hơn, giảm chi phí sử dụng vật liệu hơn do có chiều dày nhỏ hơn chỉ khoảng 68 – 140 mm nên còn giúp tiết kiệm không gian lắp đặt tăng diện tích sử dụng cho nhà ở hoặc công trình.",
                ClientId = 37,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-198),
                UpdatedAt = DateTime.Now.AddDays(-198),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 38,
                Name = "Gạch men và sứ vệ sinh kháng khuẩn",
                Description = "Đây là dòng sản phẩm với khả năng tự tiêu diệt vi khuẩn khi bám trên bề mặt sản phẩm. Ở nước ngoài đây là loại vật liệu chủ yếu dùng trong các cơ sở y tế và bệnh viện. Với lớp men Nano phun trực tiếp lên sản phẩm và nung ở nhiệt độ 1200 – 1250 độ C, giúp cho lớp men này trở nên siêu bền trên bề mặt, chống bám dính, ổ bẩn cũng như góp phần tăng độ nhẵn mịn bóng loáng cho sản phẩm.",
                ClientId = 38,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-197),
                UpdatedAt = DateTime.Now.AddDays(-197),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 39,
                Name = "METRO STAR",
                Description = "Metro Star có vị trí đắc địa ở địa chỉ 360 Xa Lộ Hà Nội, nằm trong khu dân cư đông đúc, sôi động của cửa ngõ phía Đông Sài Gòn - nơi có hai mặt tiền đường là Xa lộ Hà Nội và Nam Hòa cùng với công viên cỏ xanh  rộng rãi, thoáng đãng, đặc biệt là dự án hiếm hoi có cầu bộ hành kết nối trực tiếp từ ga Metro số 10 đi vào tầng 2 khu dân cư.Metro Star được đầu tư phát triển bởi Công ty Metro Star, trực thuộc Tổng Công ty C.T Land (thành viên Tập đoàn C.T Group - Tập đoàn đa ngành hàng đầu Việt Nam), mang đến một “siêu phẩm” độc đáo về kiến trúc, chất lượng xây dựng tiêu chuẩn Singapore và 100+ tiện ích đậm chất quốc đảo sư tử.",
                ClientId = 39,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-196),
                UpdatedAt = DateTime.Now.AddDays(-196),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 40,
                Name = "C.T PLAZA",
                Description = "C.T Plaza là một thương hiệu nhà ở và thương mại văn phòng rất đặc biệt, là sự kết hợp hài hòa giữa 3 đỉnh cao: Nghệ thuật của Tạo hóa là Thiên nhiên tươi đẹp, Nghệ thuật của Nhân loại là Kiến trúc, Hội họa, Âm nhạc, Phim ảnh…và đẹp hơn hết là Con người với cái đẹp của thân thể và tâm hồn…nơi con người có thể nâng cuộc sống hằng ngày lên thành Nghệ thuật sống cuộc đời (Living Art) để mỗi người hạnh phúc tuyệt vời theo cách riêng trong ngôi nhà của mình (A Life Style Home Brand).",
                ClientId = 40,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-195),
                UpdatedAt = DateTime.Now.AddDays(-195),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 41,
                Name = "I-HOME",
                Description = "Thương hiệu I-Home cực kỳ mới lạ và đặc biệt yêu thích bởi giới trẻ với concept rất thú vị và giá rất nice. Là sự kết hợp giữa Home và Internet trong 1 thế giới phẳng. Khu I-Home tại 359 Phạm Văn Chiêu, Q.Gò Vấp với vị trí thuận lợi, tiện ích nội khu vượt trội, thiết kế thông minh, nội thất cao cấp nhưng giá chỉ bằng giá nhà ở xã hội, Khai trương và vận hành chính thức tòa nhà vào đầu tháng 04/2017.",
                ClientId = 41,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-194),
                UpdatedAt = DateTime.Now.AddDays(-194),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 42,
                Name = "The Zen Park",
                Description = "Tổng diện tích đất: 28.834 m2 Tổng số tòa: 4 (R1.01, R1.02, R1.03, R1.05) Số tầng mỗi tòa: 31 tầng nổi Diện tích tầng hầm: ~ 24.000 m2 Diện tích cây xanh: 6.208 m2 Diện tích mặt nước Hồ cá Koi: 692 m2 Toà mở bán: 2 toà (R1.02 & R1.05) Số lượng mở bán - 7 loại căn hộ: Studio (52 căn) : 1PN: 271 căn, 1PN+1: 263 căn, 2PN: 224 căn, 2PN+1: 85 căn, 3PN: 31 căn, 3PN+1: 35 cănCác loại căn hộ diện tích linh hoạt (từ 28m2 đến 95 m2)",
                ClientId = 42,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-193),
                UpdatedAt = DateTime.Now.AddDays(-193),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 43,
                Name = "Vinhome Ocean Park",
                Description = "Được quy hoạch bởi đơn vị tư vấn thiết kế hàng đầu thế giới EDSA, với mật độ xây dựng thấp chỉ gần 19% Vinhomes Ocean Park mang tầm vóc một đại đô thị đồng bộ tiện ích như Đảo quốc Singapore. Và hơn thế nữa, dự án sở hữu những đại tiện ích và cảnh quan quy mô tầm cỡ, mới mẻ như Công viên Gym ngoài trời, Công viên BBQ rộng lớn trên nền tảng không gian cây xanh, mặt nước đa dạng.",
                ClientId = 43,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-192),
                UpdatedAt = DateTime.Now.AddDays(-192),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 44,
                Name = "VegaCity",
                Description = "Với muôn vàn cung bậc của trái tim, từ êm đềm thảnh thơi đến cháy bừng hứng khởi, Vega Continental Shopping Plaza mang đậm cảm hứng cuộc đại hải trình vĩ đại, nơi nhịp sống rộn ràng không ngừng nghỉ, thắp sáng lên một khung trời lễ hội.",
                ClientId = 44,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-191),
                UpdatedAt = DateTime.Now.AddDays(-191),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 45,
                Name = "Shophouse Bình Minh Garden",
                Description = "Vị trí: Số 93 phố Đức Giang, phường Đức Giang, quận Long Biên, Hà Nội Chủ đầu tư: Công ty cổ phần đầu tư và phát triển BĐS Thế Kỷ - Cen Invest Diện tích khu thấp tầng: 9.511m2 Mật độ xây dựng thấp tầng: 70% Nhà thầu thiết kế: Công ty CP tư vấn AA (AA – Corp)",
                ClientId = 45,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-190),
                UpdatedAt = DateTime.Now.AddDays(-190),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 46,
                Name = "Chung cư Bình Minh Garden",
                Description = "Được định hướng phát triển cuộc sống năng động, đầy đủ, mọi tiện ích phục vụ nhu cầu hàng ngày của cư dân được bố trí ngay trong nội khu dự án từ ăn uống, mua sắm, dịch vụ làm đẹp, ngân hàng,…",
                ClientId = 46,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-189),
                UpdatedAt = DateTime.Now.AddDays(-189),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 47,
                Name = "Chung Cư Cao Cấp I Tower Quy Nhơn",
                Description = "I–Tower Quy Nhơn là dự án chung cư căn hộ thương mại cao cấp được UBND tỉnh chấp thuận chủ trương đầu tư từ đầu năm 2015 do Công ty CP Đầu tư Phát triển bất động sản Đô Thành làm chủ đầu tư. Đây là dự án sở hữu vị trí “Vàng” ngay trung tâm Tp biển Quy Nhơn.",
                ClientId = 47,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-188),
                UpdatedAt = DateTime.Now.AddDays(-188),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 48,
                Name = "La Queenara Hội An",
                Description = "Lấy cảm hứng thiết kế từ câu chuyện di sản và con người Hội An, La Queenara gây ấn tượng  với hệ sinh thái 200 tiện ích phức hợp, tạo nên tổng thể hài hòa kiến tạo cộng đồng tinh hoa ngay trong lòng thành phố di sản: ",
                ClientId = 48,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-187),
                UpdatedAt = DateTime.Now.AddDays(-187),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 49,
                Name = "Samsora Premier 106",
                Description = "Samsora Premier là dự án chung cư nằm ngay trên mặt đường Chu Văn An huyết mạch kết nối giao thông phía Đông Bắc và Tây Nam thành phố. Dự án được nhiều khách hàng biết tới với quy hoạch hiện đại và hạ tầng tiện ích đầu tư chất lượng.",
                ClientId = 49,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-186),
                UpdatedAt = DateTime.Now.AddDays(-186),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 50,
                Name = "Vườn Vua Resort & Villas",
                Description = "Từ thủ đô Hà Nội đi theo đường Đại Lộ Thăng Long, qua Làng Văn hóa các Dân tộc Việt Nam, lên thẳng Đá Chông (khu di tích K9), qua Cầu Đồng Quang - Phà Đá Chông vượt Sông Đà 2km là đến Vườn Vua, với khoảng 65km từ Hà Nội. Nếu đi theo đường quốc lộ 32 qua cầu Trung Hà, qua huyện lỵ Thanh Thuỷ đến Vườn Vua khoảng 85km.",
                ClientId = 50,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-185),
                UpdatedAt = DateTime.Now.AddDays(-185),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 51,
                Name = "Khai Sơn Town",
                Description = "Nằm cách phố cổ chỉ 10 phút di chuyển, dự án Khai Sơn Town thuộc quần thể đô thị Khai Sơn City Long Biên được thừa hưởng nhiều ưu thế để phát triển mạnh mẽ trong tương lai. Dự án không chỉ có ưu thế về liên kết hạ tầng giao thông, tiện ích, mà còn có nhiều tiềm năng tăng giá, xứng đáng là khoản đầu tư không thể bỏ qua của các nhà đầu tư.",
                ClientId = 51,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-184),
                UpdatedAt = DateTime.Now.AddDays(-184),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 52,
                Name = "Mercedes-Benz GLS 600 Maybach",
                Description = "Tình trạng Mới Năm sản xuất 2021 Kiểu dáng SUV Xuất xứ Nhập khẩu Hộp số Số tự động",
                ClientId = 52,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-183),
                UpdatedAt = DateTime.Now.AddDays(-183),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 53,
                Name = "Toyota Crown Royal Saloon 3.0 MT bản full",
                Description = "Tình trạng Đã qua sử dụng Số km đã đi 32.000 km Năm sản xuất 1998 Kiểu dáng Sedan Xuất xứ Nhập khẩu Hộp số Số tay",
                ClientId = 53,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-182),
                UpdatedAt = DateTime.Now.AddDays(-182),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 54,
                Name = "Xe tải Hino FG tải 8 tấn thùng dài",
                Description = "Tình trạng Mới Năm sản xuất 2020 Kiểu dáng Truck Xuất xứ Lắp ráp Hộp số Số tay Địa chỉ rao bán Tp.HCM",
                ClientId = 54,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-181),
                UpdatedAt = DateTime.Now.AddDays(-181),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 55,
                Name = "Kia Cerato 2.0AT",
                Description = "Tình trạng Đã qua sử dụng Số km đã đi 12.000 km Năm sản xuất 2019 Kiểu dáng Sedan Hộp số Số tự động Địa chỉ rao bán Tp.HCM",
                ClientId = 55,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-180),
                UpdatedAt = DateTime.Now.AddDays(-180),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 56,
                Name = "Toyota Land Cruiser 1999",
                Description = "Tình trạng Đã qua sử dụng Số km đã đi 18.000 km Năm sản xuất 1998 Kiểu dáng SUV Xuất xứ Nhập khẩu Hộp số Số tay Địa chỉ rao bán Hà Nội",
                ClientId = 56,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-179),
                UpdatedAt = DateTime.Now.AddDays(-179),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 57,
                Name = "Lexus RX 350 F-Sport 2017",
                Description = "Tình trạng Đã qua sử dụngSố km đã đi22.000 kmNăm sản xuất2016Kiểu dángSUVXuất xứNhập khẩuHộp sốSố tự động",
                ClientId = 57,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-178),
                UpdatedAt = DateTime.Now.AddDays(-178),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 58,
                Name = "Mercedes G63 Edition 2",
                Description = "Tình trạng Mới Năm sản xuất 2021 Kiểu dáng SUV Xuất xứ Nhập khẩu Hộp số Số tự động Địa chỉ rao bán Hà Nội",
                ClientId = 58,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-177),
                UpdatedAt = DateTime.Now.AddDays(-177),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 59,
                Name = "Mazda CX 5 2020",
                Description = "Tình trạng Đã qua sử dụng Số km đã đi 27.000 km Năm sản xuất 2019 Kiểu dáng SUV Hộp số Số tự động Địa chỉ rao bán Tp.HCM",
                ClientId = 59,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-176),
                UpdatedAt = DateTime.Now.AddDays(-176),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 60,
                Name = "Volkswagen T-Cross",
                Description = "Cùng với Teramont, Volkswagen T-Cross 2021 được đồn đoán là mẫu xe hoàn toàn mới sẽ gia nhập đội hình sản phẩm xe hơi của Volkswagen (VW) tại Việt Nam trong năm 2021. Hiện tại, VW Việt Nam vẫn chưa tiết lộ bất cứ thông tin nào về kế hoạch ra mắt T-Cross 2021 tại Việt Nam.",
                ClientId = 60,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-175),
                UpdatedAt = DateTime.Now.AddDays(-175),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 61,
                Name = "Dự án The Filmore Đà Nẵng",
                Description = "Diện tích khu đất 1.504,2 m2 với quy mô 25 tầng nổi, 3 tầng hầm và 206 căn hộ cao cấp (gồm các căn hộ 1 phòng ngủ, 2 phòng ngủ, 3 phòng ngủ - Duplex, Dual Key). Tổng diện tích sàn xây dựng hơn 22.600 m2, diện tích sàn nhà ở khoảng 12.876 m2, diện tích sàn sử dụng thương mại dịch vụ gần 300 m2. Mật độ xây dựng khối đế 55,6%, khối tháp 47,8%. Dự án dự kiến hoàn thành và bàn giao vào quý IV/2022.",
                ClientId = 61,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-204),
                UpdatedAt = DateTime.Now.AddDays(-204),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 62,
                Name = "Ô tô điện thông minh vf-e36",
                Description = "Thuộc phân khúc C, từng được công bố vào tháng 1/2021 với tên mã VF31. Xe có chiều dài cơ sở 2.611mm, kích thước các chiều dài x rộng x cao là 4.300 x 1.793 x 1.613 (mm), khoảng sáng gầm xe 180mm, trọng lượng không tải 1.490kg. VinFast VF e34 được trang bị một động cơ điện có công suất tối đa 110 kW ( 147 HP), mô-men xoắn cực đại 242 Nm cùng hệ dẫn động cầu trước, hệ thống treo trước MacPherson, hệ thống treo sau dạng thanh xoắn. Xe sử dụng một bộ pin dung lượng 42kWh, có thể đi được quãng đường 300km sau mỗi lần sạc đầy. Để minh chứng cho đẳng cấp, chất lượng và tạo sự an tâm cho khách hàng, VinFast tiên phong áp dụng chính sách bảo hành lên tới 10 năm cho xe VF e36",
                ClientId = 62,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-203),
                UpdatedAt = DateTime.Now.AddDays(-203),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 63,
                Name = "Xi măng Nghi Sơn đa dụng",
                Description = "chất lượng PCB40, được sản xuất từ công nghệ Nhật tiên tiến, chất lượng được kiểm soát bởi các chuyên gia Nhật Bản",
                ClientId = 63,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-202),
                UpdatedAt = DateTime.Now.AddDays(-202),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 64,
                Name = "Gạch bê tông AAC",
                Description = "Gạch bê tông AAC (viết tắt của ba từ tiếng Anh là “Aerated Autoclaved Concrete”) hay còn có tên là “gạch bê tông khí chưng áp” đây là loại vật liệu mới trong xây dựng với kết cấu bê tông gồm các bọt khí nhỏ. Mặc dù đã xuất hiện và bắt đầu sử dụng trên Thế Giới gần 1 thế kỷ trước. Tuy nhiên đến năm 2008 Việt Nam mới bắt đầu nhập khẩu và sử dụng loại vật liệu này.Đây được xem là vật liệu xanh vì có thể tái sử dụng. Được sản xuất bằng công nghệ khí chưng áp từ các nguyên liệu như cát, vôi, thạch cao, xi măng, bột nhôm và không gây ô nhiễm nên thân thiện môi trường.",
                ClientId = 64,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-201),
                UpdatedAt = DateTime.Now.AddDays(-201),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 65,
                Name = "Tấm panel ALC",
                Description = "ALC (Autoclaced Lightweight Aerated Concrete) hay được gọi là “Bê tông gia khí chưng áp. Tấm tường Panel được sản xuất bằng các nguyên liệu giống với nguyên liệu tạo ra sản phẩm gạch nhẹ AAC. Với khả năng chịu lực cao, tấm ALC được chế tạo bằng 2 lớp thép (thép nguội), cấu trúc không gian 3 chiều nên tạo ra một bộ khung cứng và vững chắc. Ứng dụng để làm tường, sàn, cầu thang, mái,… Có thể gia công cưa, cắt, khoan hay đóng đinh một cách đơn giản, tốn ít thời gian, quá trình lắp đặt nhanh chóng thuận tiện.",
                ClientId = 65,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-200),
                UpdatedAt = DateTime.Now.AddDays(-200),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 66,
                Name = "Xi măng công nghệ nano",
                Description = "Đây là sản phẩm vật liệu mới trong xây dựng nhà ở và công trình. Sản phẩm có độ cứng và độ bền vượt trội. Với công thức độc đáo đây là công nghệ vật liệu mới trong xây dựng – công nghệ độc quyền của SCG giúp cải tiến chất lượng xi măng, các phân tử xi măng tạo ra ở kích thước nano nên tạo ra liên kết vô cùng chặt chẽ nên giảm thiểu khả năng nứt, rò rỉ của công trình một trong những nguyên nhân gây ra chính là do các lỗ rỗng trong quá trình trộn bê tông tạo ra khi sử dụng xi măng cũ tiếp xúc với các tác nhân môi trường như nắng, gió, mưa,..",
                ClientId = 66,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-199),
                UpdatedAt = DateTime.Now.AddDays(-199),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 67,
                Name = "Tấm tường bê tông đúc sẵn",
                Description = "Ưu điểm dễ dàng thi công lắp đặt với 6m2 tường chỉ cần 3 công nhân làm việc trong 1 giờ đồng hồ nên giúp tiết kiệm nhân lực lao động. So với các loại truyền thống như tường gạch, block bê tông thì tấm tường bê tông đúc sẵn này có tuổi thọ cao hơn, giảm chi phí sử dụng vật liệu hơn do có chiều dày nhỏ hơn chỉ khoảng 68 – 140 mm nên còn giúp tiết kiệm không gian lắp đặt tăng diện tích sử dụng cho nhà ở hoặc công trình.",
                ClientId = 67,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-198),
                UpdatedAt = DateTime.Now.AddDays(-198),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 68,
                Name = "Gạch men và sứ vệ sinh kháng khuẩn",
                Description = "Đây là dòng sản phẩm với khả năng tự tiêu diệt vi khuẩn khi bám trên bề mặt sản phẩm. Ở nước ngoài đây là loại vật liệu chủ yếu dùng trong các cơ sở y tế và bệnh viện. Với lớp men Nano phun trực tiếp lên sản phẩm và nung ở nhiệt độ 1200 – 1250 độ C, giúp cho lớp men này trở nên siêu bền trên bề mặt, chống bám dính, ổ bẩn cũng như góp phần tăng độ nhẵn mịn bóng loáng cho sản phẩm.",
                ClientId = 68,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-197),
                UpdatedAt = DateTime.Now.AddDays(-197),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 69,
                Name = "METRO STAR",
                Description = "Metro Star có vị trí đắc địa ở địa chỉ 360 Xa Lộ Hà Nội, nằm trong khu dân cư đông đúc, sôi động của cửa ngõ phía Đông Sài Gòn - nơi có hai mặt tiền đường là Xa lộ Hà Nội và Nam Hòa cùng với công viên cỏ xanh  rộng rãi, thoáng đãng, đặc biệt là dự án hiếm hoi có cầu bộ hành kết nối trực tiếp từ ga Metro số 10 đi vào tầng 2 khu dân cư.Metro Star được đầu tư phát triển bởi Công ty Metro Star, trực thuộc Tổng Công ty C.T Land (thành viên Tập đoàn C.T Group - Tập đoàn đa ngành hàng đầu Việt Nam), mang đến một “siêu phẩm” độc đáo về kiến trúc, chất lượng xây dựng tiêu chuẩn Singapore và 100+ tiện ích đậm chất quốc đảo sư tử.",
                ClientId = 69,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-196),
                UpdatedAt = DateTime.Now.AddDays(-196),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 70,
                Name = "C.T PLAZA",
                Description = "C.T Plaza là một thương hiệu nhà ở và thương mại văn phòng rất đặc biệt, là sự kết hợp hài hòa giữa 3 đỉnh cao: Nghệ thuật của Tạo hóa là Thiên nhiên tươi đẹp, Nghệ thuật của Nhân loại là Kiến trúc, Hội họa, Âm nhạc, Phim ảnh…và đẹp hơn hết là Con người với cái đẹp của thân thể và tâm hồn…nơi con người có thể nâng cuộc sống hằng ngày lên thành Nghệ thuật sống cuộc đời (Living Art) để mỗi người hạnh phúc tuyệt vời theo cách riêng trong ngôi nhà của mình (A Life Style Home Brand).",
                ClientId = 70,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-195),
                UpdatedAt = DateTime.Now.AddDays(-195),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 71,
                Name = "I-HOME",
                Description = "Thương hiệu I-Home cực kỳ mới lạ và đặc biệt yêu thích bởi giới trẻ với concept rất thú vị và giá rất nice. Là sự kết hợp giữa Home và Internet trong 1 thế giới phẳng. Khu I-Home tại 359 Phạm Văn Chiêu, Q.Gò Vấp với vị trí thuận lợi, tiện ích nội khu vượt trội, thiết kế thông minh, nội thất cao cấp nhưng giá chỉ bằng giá nhà ở xã hội, Khai trương và vận hành chính thức tòa nhà vào đầu tháng 04/2017.",
                ClientId = 71,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-194),
                UpdatedAt = DateTime.Now.AddDays(-194),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 72,
                Name = "The Zen Park",
                Description = "Tổng diện tích đất: 28.834 m2 Tổng số tòa: 4 (R1.01, R1.02, R1.03, R1.05) Số tầng mỗi tòa: 31 tầng nổi Diện tích tầng hầm: ~ 24.000 m2 Diện tích cây xanh: 6.208 m2 Diện tích mặt nước Hồ cá Koi: 692 m2 Toà mở bán: 2 toà (R1.02 & R1.05) Số lượng mở bán - 7 loại căn hộ: Studio (52 căn) : 1PN: 271 căn, 1PN+1: 263 căn, 2PN: 224 căn, 2PN+1: 85 căn, 3PN: 31 căn, 3PN+1: 35 cănCác loại căn hộ diện tích linh hoạt (từ 28m2 đến 95 m2)",
                ClientId = 72,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-193),
                UpdatedAt = DateTime.Now.AddDays(-193),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 73,
                Name = "Vinhome Ocean Park",
                Description = "Được quy hoạch bởi đơn vị tư vấn thiết kế hàng đầu thế giới EDSA, với mật độ xây dựng thấp chỉ gần 19% Vinhomes Ocean Park mang tầm vóc một đại đô thị đồng bộ tiện ích như Đảo quốc Singapore. Và hơn thế nữa, dự án sở hữu những đại tiện ích và cảnh quan quy mô tầm cỡ, mới mẻ như Công viên Gym ngoài trời, Công viên BBQ rộng lớn trên nền tảng không gian cây xanh, mặt nước đa dạng.",
                ClientId = 73,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-192),
                UpdatedAt = DateTime.Now.AddDays(-192),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 74,
                Name = "VegaCity",
                Description = "Với muôn vàn cung bậc của trái tim, từ êm đềm thảnh thơi đến cháy bừng hứng khởi, Vega Continental Shopping Plaza mang đậm cảm hứng cuộc đại hải trình vĩ đại, nơi nhịp sống rộn ràng không ngừng nghỉ, thắp sáng lên một khung trời lễ hội.",
                ClientId = 74,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-191),
                UpdatedAt = DateTime.Now.AddDays(-191),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 75,
                Name = "Shophouse Bình Minh Garden",
                Description = "Vị trí: Số 93 phố Đức Giang, phường Đức Giang, quận Long Biên, Hà Nội Chủ đầu tư: Công ty cổ phần đầu tư và phát triển BĐS Thế Kỷ - Cen Invest Diện tích khu thấp tầng: 9.511m2 Mật độ xây dựng thấp tầng: 70% Nhà thầu thiết kế: Công ty CP tư vấn AA (AA – Corp)",
                ClientId = 75,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-190),
                UpdatedAt = DateTime.Now.AddDays(-190),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 76,
                Name = "Chung cư Bình Minh Garden",
                Description = "Được định hướng phát triển cuộc sống năng động, đầy đủ, mọi tiện ích phục vụ nhu cầu hàng ngày của cư dân được bố trí ngay trong nội khu dự án từ ăn uống, mua sắm, dịch vụ làm đẹp, ngân hàng,…",
                ClientId = 76,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-189),
                UpdatedAt = DateTime.Now.AddDays(-189),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 77,
                Name = "Chung Cư Cao Cấp I Tower Quy Nhơn",
                Description = "I–Tower Quy Nhơn là dự án chung cư căn hộ thương mại cao cấp được UBND tỉnh chấp thuận chủ trương đầu tư từ đầu năm 2015 do Công ty CP Đầu tư Phát triển bất động sản Đô Thành làm chủ đầu tư. Đây là dự án sở hữu vị trí “Vàng” ngay trung tâm Tp biển Quy Nhơn.",
                ClientId = 77,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-188),
                UpdatedAt = DateTime.Now.AddDays(-188),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 78,
                Name = "La Queenara Hội An",
                Description = "Lấy cảm hứng thiết kế từ câu chuyện di sản và con người Hội An, La Queenara gây ấn tượng  với hệ sinh thái 200 tiện ích phức hợp, tạo nên tổng thể hài hòa kiến tạo cộng đồng tinh hoa ngay trong lòng thành phố di sản: ",
                ClientId = 78,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-187),
                UpdatedAt = DateTime.Now.AddDays(-187),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 79,
                Name = "Samsora Premier 107",
                Description = "Samsora Premier là dự án chung cư nằm ngay trên mặt đường Chu Văn An huyết mạch kết nối giao thông phía Đông Bắc và Tây Nam thành phố. Dự án được nhiều khách hàng biết tới với quy hoạch hiện đại và hạ tầng tiện ích đầu tư chất lượng.",
                ClientId = 79,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-186),
                UpdatedAt = DateTime.Now.AddDays(-186),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 80,
                Name = "Vườn Vua Resort & Villas",
                Description = "Từ thủ đô Hà Nội đi theo đường Đại Lộ Thăng Long, qua Làng Văn hóa các Dân tộc Việt Nam, lên thẳng Đá Chông (khu di tích K9), qua Cầu Đồng Quang - Phà Đá Chông vượt Sông Đà 2km là đến Vườn Vua, với khoảng 65km từ Hà Nội. Nếu đi theo đường quốc lộ 32 qua cầu Trung Hà, qua huyện lỵ Thanh Thuỷ đến Vườn Vua khoảng 85km.",
                ClientId = 80,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-185),
                UpdatedAt = DateTime.Now.AddDays(-185),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 81,
                Name = "Khai Sơn Town",
                Description = "Nằm cách phố cổ chỉ 10 phút di chuyển, dự án Khai Sơn Town thuộc quần thể đô thị Khai Sơn City Long Biên được thừa hưởng nhiều ưu thế để phát triển mạnh mẽ trong tương lai. Dự án không chỉ có ưu thế về liên kết hạ tầng giao thông, tiện ích, mà còn có nhiều tiềm năng tăng giá, xứng đáng là khoản đầu tư không thể bỏ qua của các nhà đầu tư.",
                ClientId = 81,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-184),
                UpdatedAt = DateTime.Now.AddDays(-184),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 82,
                Name = "Mercedes-Benz GLS 600 Maybach",
                Description = "Tình trạng Mới Năm sản xuất 2021 Kiểu dáng SUV Xuất xứ Nhập khẩu Hộp số Số tự động",
                ClientId = 82,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-183),
                UpdatedAt = DateTime.Now.AddDays(-183),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 83,
                Name = "Toyota Crown Royal Saloon 3.0 MT bản full",
                Description = "Tình trạng Đã qua sử dụng Số km đã đi 32.000 km Năm sản xuất 1998 Kiểu dáng Sedan Xuất xứ Nhập khẩu Hộp số Số tay",
                ClientId = 83,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-182),
                UpdatedAt = DateTime.Now.AddDays(-182),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 84,
                Name = "Xe tải Hino FG tải 8 tấn thùng dài",
                Description = "Tình trạng Mới Năm sản xuất 2020 Kiểu dáng Truck Xuất xứ Lắp ráp Hộp số Số tay Địa chỉ rao bán Tp.HCM",
                ClientId = 84,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-181),
                UpdatedAt = DateTime.Now.AddDays(-181),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 85,
                Name = "Kia Cerato 2.0AT",
                Description = "Tình trạng Đã qua sử dụng Số km đã đi 12.000 km Năm sản xuất 2019 Kiểu dáng Sedan Hộp số Số tự động Địa chỉ rao bán Tp.HCM",
                ClientId = 85,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-180),
                UpdatedAt = DateTime.Now.AddDays(-180),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 86,
                Name = "Toyota Land Cruiser 2000",
                Description = "Tình trạng Đã qua sử dụng Số km đã đi 18.000 km Năm sản xuất 1998 Kiểu dáng SUV Xuất xứ Nhập khẩu Hộp số Số tay Địa chỉ rao bán Hà Nội",
                ClientId = 86,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-179),
                UpdatedAt = DateTime.Now.AddDays(-179),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 87,
                Name = "Lexus RX 350 F-Sport 2018",
                Description = "Tình trạng Đã qua sử dụngSố km đã đi22.000 kmNăm sản xuất2016Kiểu dángSUVXuất xứNhập khẩuHộp sốSố tự động",
                ClientId = 87,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-178),
                UpdatedAt = DateTime.Now.AddDays(-178),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 88,
                Name = "Mercedes G63 Edition 3",
                Description = "Tình trạng Mới Năm sản xuất 2021 Kiểu dáng SUV Xuất xứ Nhập khẩu Hộp số Số tự động Địa chỉ rao bán Hà Nội",
                ClientId = 88,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-177),
                UpdatedAt = DateTime.Now.AddDays(-177),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 89,
                Name = "Mazda CX 5 2021",
                Description = "Tình trạng Đã qua sử dụng Số km đã đi 27.000 km Năm sản xuất 2019 Kiểu dáng SUV Hộp số Số tự động Địa chỉ rao bán Tp.HCM",
                ClientId = 89,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-176),
                UpdatedAt = DateTime.Now.AddDays(-176),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 90,
                Name = "Volkswagen T-Cross",
                Description = "Cùng với Teramont, Volkswagen T-Cross 2021 được đồn đoán là mẫu xe hoàn toàn mới sẽ gia nhập đội hình sản phẩm xe hơi của Volkswagen (VW) tại Việt Nam trong năm 2021. Hiện tại, VW Việt Nam vẫn chưa tiết lộ bất cứ thông tin nào về kế hoạch ra mắt T-Cross 2021 tại Việt Nam.",
                ClientId = 90,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-175),
                UpdatedAt = DateTime.Now.AddDays(-175),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 91,
                Name = "Dự án The Filmore Đà Nẵng",
                Description = "Diện tích khu đất 1.504,2 m2 với quy mô 25 tầng nổi, 3 tầng hầm và 206 căn hộ cao cấp (gồm các căn hộ 1 phòng ngủ, 2 phòng ngủ, 3 phòng ngủ - Duplex, Dual Key). Tổng diện tích sàn xây dựng hơn 22.600 m2, diện tích sàn nhà ở khoảng 12.876 m2, diện tích sàn sử dụng thương mại dịch vụ gần 300 m2. Mật độ xây dựng khối đế 55,6%, khối tháp 47,8%. Dự án dự kiến hoàn thành và bàn giao vào quý IV/2022.",
                ClientId = 91,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-204),
                UpdatedAt = DateTime.Now.AddDays(-204),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 92,
                Name = "Ô tô điện thông minh vf-e37",
                Description = "Thuộc phân khúc C, từng được công bố vào tháng 1/2021 với tên mã VF31. Xe có chiều dài cơ sở 2.611mm, kích thước các chiều dài x rộng x cao là 4.300 x 1.793 x 1.613 (mm), khoảng sáng gầm xe 180mm, trọng lượng không tải 1.490kg. VinFast VF e34 được trang bị một động cơ điện có công suất tối đa 110 kW ( 147 HP), mô-men xoắn cực đại 242 Nm cùng hệ dẫn động cầu trước, hệ thống treo trước MacPherson, hệ thống treo sau dạng thanh xoắn. Xe sử dụng một bộ pin dung lượng 42kWh, có thể đi được quãng đường 300km sau mỗi lần sạc đầy. Để minh chứng cho đẳng cấp, chất lượng và tạo sự an tâm cho khách hàng, VinFast tiên phong áp dụng chính sách bảo hành lên tới 10 năm cho xe VF e37",
                ClientId = 92,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-203),
                UpdatedAt = DateTime.Now.AddDays(-203),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 93,
                Name = "Xi măng Nghi Sơn đa dụng",
                Description = "chất lượng PCB40, được sản xuất từ công nghệ Nhật tiên tiến, chất lượng được kiểm soát bởi các chuyên gia Nhật Bản",
                ClientId = 93,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-202),
                UpdatedAt = DateTime.Now.AddDays(-202),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 94,
                Name = "Gạch bê tông AAC",
                Description = "Gạch bê tông AAC (viết tắt của ba từ tiếng Anh là “Aerated Autoclaved Concrete”) hay còn có tên là “gạch bê tông khí chưng áp” đây là loại vật liệu mới trong xây dựng với kết cấu bê tông gồm các bọt khí nhỏ. Mặc dù đã xuất hiện và bắt đầu sử dụng trên Thế Giới gần 1 thế kỷ trước. Tuy nhiên đến năm 2008 Việt Nam mới bắt đầu nhập khẩu và sử dụng loại vật liệu này.Đây được xem là vật liệu xanh vì có thể tái sử dụng. Được sản xuất bằng công nghệ khí chưng áp từ các nguyên liệu như cát, vôi, thạch cao, xi măng, bột nhôm và không gây ô nhiễm nên thân thiện môi trường.",
                ClientId = 94,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-201),
                UpdatedAt = DateTime.Now.AddDays(-201),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 95,
                Name = "Tấm panel ALC",
                Description = "ALC (Autoclaced Lightweight Aerated Concrete) hay được gọi là “Bê tông gia khí chưng áp. Tấm tường Panel được sản xuất bằng các nguyên liệu giống với nguyên liệu tạo ra sản phẩm gạch nhẹ AAC. Với khả năng chịu lực cao, tấm ALC được chế tạo bằng 2 lớp thép (thép nguội), cấu trúc không gian 3 chiều nên tạo ra một bộ khung cứng và vững chắc. Ứng dụng để làm tường, sàn, cầu thang, mái,… Có thể gia công cưa, cắt, khoan hay đóng đinh một cách đơn giản, tốn ít thời gian, quá trình lắp đặt nhanh chóng thuận tiện.",
                ClientId = 95,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-200),
                UpdatedAt = DateTime.Now.AddDays(-200),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 96,
                Name = "Xi măng công nghệ nano",
                Description = "Đây là sản phẩm vật liệu mới trong xây dựng nhà ở và công trình. Sản phẩm có độ cứng và độ bền vượt trội. Với công thức độc đáo đây là công nghệ vật liệu mới trong xây dựng – công nghệ độc quyền của SCG giúp cải tiến chất lượng xi măng, các phân tử xi măng tạo ra ở kích thước nano nên tạo ra liên kết vô cùng chặt chẽ nên giảm thiểu khả năng nứt, rò rỉ của công trình một trong những nguyên nhân gây ra chính là do các lỗ rỗng trong quá trình trộn bê tông tạo ra khi sử dụng xi măng cũ tiếp xúc với các tác nhân môi trường như nắng, gió, mưa,..",
                ClientId = 96,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-199),
                UpdatedAt = DateTime.Now.AddDays(-199),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 97,
                Name = "Tấm tường bê tông đúc sẵn",
                Description = "Ưu điểm dễ dàng thi công lắp đặt với 6m2 tường chỉ cần 3 công nhân làm việc trong 1 giờ đồng hồ nên giúp tiết kiệm nhân lực lao động. So với các loại truyền thống như tường gạch, block bê tông thì tấm tường bê tông đúc sẵn này có tuổi thọ cao hơn, giảm chi phí sử dụng vật liệu hơn do có chiều dày nhỏ hơn chỉ khoảng 68 – 140 mm nên còn giúp tiết kiệm không gian lắp đặt tăng diện tích sử dụng cho nhà ở hoặc công trình.",
                ClientId = 97,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-198),
                UpdatedAt = DateTime.Now.AddDays(-198),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 98,
                Name = "Gạch men và sứ vệ sinh kháng khuẩn",
                Description = "Đây là dòng sản phẩm với khả năng tự tiêu diệt vi khuẩn khi bám trên bề mặt sản phẩm. Ở nước ngoài đây là loại vật liệu chủ yếu dùng trong các cơ sở y tế và bệnh viện. Với lớp men Nano phun trực tiếp lên sản phẩm và nung ở nhiệt độ 1200 – 1250 độ C, giúp cho lớp men này trở nên siêu bền trên bề mặt, chống bám dính, ổ bẩn cũng như góp phần tăng độ nhẵn mịn bóng loáng cho sản phẩm.",
                ClientId = 98,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-197),
                UpdatedAt = DateTime.Now.AddDays(-197),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 99,
                Name = "METRO STAR",
                Description = "Metro Star có vị trí đắc địa ở địa chỉ 360 Xa Lộ Hà Nội, nằm trong khu dân cư đông đúc, sôi động của cửa ngõ phía Đông Sài Gòn - nơi có hai mặt tiền đường là Xa lộ Hà Nội và Nam Hòa cùng với công viên cỏ xanh  rộng rãi, thoáng đãng, đặc biệt là dự án hiếm hoi có cầu bộ hành kết nối trực tiếp từ ga Metro số 10 đi vào tầng 2 khu dân cư.Metro Star được đầu tư phát triển bởi Công ty Metro Star, trực thuộc Tổng Công ty C.T Land (thành viên Tập đoàn C.T Group - Tập đoàn đa ngành hàng đầu Việt Nam), mang đến một “siêu phẩm” độc đáo về kiến trúc, chất lượng xây dựng tiêu chuẩn Singapore và 100+ tiện ích đậm chất quốc đảo sư tử.",
                ClientId = 99,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-196),
                UpdatedAt = DateTime.Now.AddDays(-196),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 100,
                Name = "C.T PLAZA",
                Description = "C.T Plaza là một thương hiệu nhà ở và thương mại văn phòng rất đặc biệt, là sự kết hợp hài hòa giữa 3 đỉnh cao: Nghệ thuật của Tạo hóa là Thiên nhiên tươi đẹp, Nghệ thuật của Nhân loại là Kiến trúc, Hội họa, Âm nhạc, Phim ảnh…và đẹp hơn hết là Con người với cái đẹp của thân thể và tâm hồn…nơi con người có thể nâng cuộc sống hằng ngày lên thành Nghệ thuật sống cuộc đời (Living Art) để mỗi người hạnh phúc tuyệt vời theo cách riêng trong ngôi nhà của mình (A Life Style Home Brand).",
                ClientId = 100,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-195),
                UpdatedAt = DateTime.Now.AddDays(-195),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 101,
                Name = "I-HOME",
                Description = "Thương hiệu I-Home cực kỳ mới lạ và đặc biệt yêu thích bởi giới trẻ với concept rất thú vị và giá rất nice. Là sự kết hợp giữa Home và Internet trong 1 thế giới phẳng. Khu I-Home tại 359 Phạm Văn Chiêu, Q.Gò Vấp với vị trí thuận lợi, tiện ích nội khu vượt trội, thiết kế thông minh, nội thất cao cấp nhưng giá chỉ bằng giá nhà ở xã hội, Khai trương và vận hành chính thức tòa nhà vào đầu tháng 04/2017.",
                ClientId = 101,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-194),
                UpdatedAt = DateTime.Now.AddDays(-194),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 102,
                Name = "The Zen Park",
                Description = "Tổng diện tích đất: 28.834 m2 Tổng số tòa: 4 (R1.01, R1.02, R1.03, R1.05) Số tầng mỗi tòa: 31 tầng nổi Diện tích tầng hầm: ~ 24.000 m2 Diện tích cây xanh: 6.208 m2 Diện tích mặt nước Hồ cá Koi: 692 m2 Toà mở bán: 2 toà (R1.02 & R1.05) Số lượng mở bán - 7 loại căn hộ: Studio (52 căn) : 1PN: 271 căn, 1PN+1: 263 căn, 2PN: 224 căn, 2PN+1: 85 căn, 3PN: 31 căn, 3PN+1: 35 cănCác loại căn hộ diện tích linh hoạt (từ 28m2 đến 95 m2)",
                ClientId = 102,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-193),
                UpdatedAt = DateTime.Now.AddDays(-193),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 103,
                Name = "Vinhome Ocean Park",
                Description = "Được quy hoạch bởi đơn vị tư vấn thiết kế hàng đầu thế giới EDSA, với mật độ xây dựng thấp chỉ gần 19% Vinhomes Ocean Park mang tầm vóc một đại đô thị đồng bộ tiện ích như Đảo quốc Singapore. Và hơn thế nữa, dự án sở hữu những đại tiện ích và cảnh quan quy mô tầm cỡ, mới mẻ như Công viên Gym ngoài trời, Công viên BBQ rộng lớn trên nền tảng không gian cây xanh, mặt nước đa dạng.",
                ClientId = 103,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-192),
                UpdatedAt = DateTime.Now.AddDays(-192),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 104,
                Name = "VegaCity",
                Description = "Với muôn vàn cung bậc của trái tim, từ êm đềm thảnh thơi đến cháy bừng hứng khởi, Vega Continental Shopping Plaza mang đậm cảm hứng cuộc đại hải trình vĩ đại, nơi nhịp sống rộn ràng không ngừng nghỉ, thắp sáng lên một khung trời lễ hội.",
                ClientId = 104,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-191),
                UpdatedAt = DateTime.Now.AddDays(-191),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 105,
                Name = "Shophouse Bình Minh Garden",
                Description = "Vị trí: Số 93 phố Đức Giang, phường Đức Giang, quận Long Biên, Hà Nội Chủ đầu tư: Công ty cổ phần đầu tư và phát triển BĐS Thế Kỷ - Cen Invest Diện tích khu thấp tầng: 9.511m2 Mật độ xây dựng thấp tầng: 70% Nhà thầu thiết kế: Công ty CP tư vấn AA (AA – Corp)",
                ClientId = 105,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-190),
                UpdatedAt = DateTime.Now.AddDays(-190),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 106,
                Name = "Chung cư Bình Minh Garden",
                Description = "Được định hướng phát triển cuộc sống năng động, đầy đủ, mọi tiện ích phục vụ nhu cầu hàng ngày của cư dân được bố trí ngay trong nội khu dự án từ ăn uống, mua sắm, dịch vụ làm đẹp, ngân hàng,…",
                ClientId = 106,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-189),
                UpdatedAt = DateTime.Now.AddDays(-189),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 107,
                Name = "Chung Cư Cao Cấp I Tower Quy Nhơn",
                Description = "I–Tower Quy Nhơn là dự án chung cư căn hộ thương mại cao cấp được UBND tỉnh chấp thuận chủ trương đầu tư từ đầu năm 2015 do Công ty CP Đầu tư Phát triển bất động sản Đô Thành làm chủ đầu tư. Đây là dự án sở hữu vị trí “Vàng” ngay trung tâm Tp biển Quy Nhơn.",
                ClientId = 107,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-188),
                UpdatedAt = DateTime.Now.AddDays(-188),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 108,
                Name = "La Queenara Hội An",
                Description = "Lấy cảm hứng thiết kế từ câu chuyện di sản và con người Hội An, La Queenara gây ấn tượng  với hệ sinh thái 200 tiện ích phức hợp, tạo nên tổng thể hài hòa kiến tạo cộng đồng tinh hoa ngay trong lòng thành phố di sản: ",
                ClientId = 108,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-187),
                UpdatedAt = DateTime.Now.AddDays(-187),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 109,
                Name = "Samsora Premier 108",
                Description = "Samsora Premier là dự án chung cư nằm ngay trên mặt đường Chu Văn An huyết mạch kết nối giao thông phía Đông Bắc và Tây Nam thành phố. Dự án được nhiều khách hàng biết tới với quy hoạch hiện đại và hạ tầng tiện ích đầu tư chất lượng.",
                ClientId = 109,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-186),
                UpdatedAt = DateTime.Now.AddDays(-186),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 110,
                Name = "Vườn Vua Resort & Villas",
                Description = "Từ thủ đô Hà Nội đi theo đường Đại Lộ Thăng Long, qua Làng Văn hóa các Dân tộc Việt Nam, lên thẳng Đá Chông (khu di tích K9), qua Cầu Đồng Quang - Phà Đá Chông vượt Sông Đà 2km là đến Vườn Vua, với khoảng 65km từ Hà Nội. Nếu đi theo đường quốc lộ 32 qua cầu Trung Hà, qua huyện lỵ Thanh Thuỷ đến Vườn Vua khoảng 85km.",
                ClientId = 110,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-185),
                UpdatedAt = DateTime.Now.AddDays(-185),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 111,
                Name = "Khai Sơn Town",
                Description = "Nằm cách phố cổ chỉ 10 phút di chuyển, dự án Khai Sơn Town thuộc quần thể đô thị Khai Sơn City Long Biên được thừa hưởng nhiều ưu thế để phát triển mạnh mẽ trong tương lai. Dự án không chỉ có ưu thế về liên kết hạ tầng giao thông, tiện ích, mà còn có nhiều tiềm năng tăng giá, xứng đáng là khoản đầu tư không thể bỏ qua của các nhà đầu tư.",
                ClientId = 111,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-184),
                UpdatedAt = DateTime.Now.AddDays(-184),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 112,
                Name = "Mercedes-Benz GLS 600 Maybach",
                Description = "Tình trạng Mới Năm sản xuất 2021 Kiểu dáng SUV Xuất xứ Nhập khẩu Hộp số Số tự động",
                ClientId = 112,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-183),
                UpdatedAt = DateTime.Now.AddDays(-183),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 113,
                Name = "Toyota Crown Royal Saloon 3.0 MT bản full",
                Description = "Tình trạng Đã qua sử dụng Số km đã đi 32.000 km Năm sản xuất 1998 Kiểu dáng Sedan Xuất xứ Nhập khẩu Hộp số Số tay",
                ClientId = 113,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-182),
                UpdatedAt = DateTime.Now.AddDays(-182),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 114,
                Name = "Xe tải Hino FG tải 8 tấn thùng dài",
                Description = "Tình trạng Mới Năm sản xuất 2020 Kiểu dáng Truck Xuất xứ Lắp ráp Hộp số Số tay Địa chỉ rao bán Tp.HCM",
                ClientId = 114,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-181),
                UpdatedAt = DateTime.Now.AddDays(-181),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 115,
                Name = "Kia Cerato 2.0AT",
                Description = "Tình trạng Đã qua sử dụng Số km đã đi 12.000 km Năm sản xuất 2019 Kiểu dáng Sedan Hộp số Số tự động Địa chỉ rao bán Tp.HCM",
                ClientId = 115,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-180),
                UpdatedAt = DateTime.Now.AddDays(-180),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 116,
                Name = "Toyota Land Cruiser 2001",
                Description = "Tình trạng Đã qua sử dụng Số km đã đi 18.000 km Năm sản xuất 1998 Kiểu dáng SUV Xuất xứ Nhập khẩu Hộp số Số tay Địa chỉ rao bán Hà Nội",
                ClientId = 116,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-179),
                UpdatedAt = DateTime.Now.AddDays(-179),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 117,
                Name = "Lexus RX 350 F-Sport 2019",
                Description = "Tình trạng Đã qua sử dụngSố km đã đi22.000 kmNăm sản xuất2016Kiểu dángSUVXuất xứNhập khẩuHộp sốSố tự động",
                ClientId = 117,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-178),
                UpdatedAt = DateTime.Now.AddDays(-178),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 118,
                Name = "Mercedes G63 Edition 4",
                Description = "Tình trạng Mới Năm sản xuất 2021 Kiểu dáng SUV Xuất xứ Nhập khẩu Hộp số Số tự động Địa chỉ rao bán Hà Nội",
                ClientId = 118,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-177),
                UpdatedAt = DateTime.Now.AddDays(-177),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 119,
                Name = "Mazda CX 5 2022",
                Description = "Tình trạng Đã qua sử dụng Số km đã đi 27.000 km Năm sản xuất 2019 Kiểu dáng SUV Hộp số Số tự động Địa chỉ rao bán Tp.HCM",
                ClientId = 119,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-176),
                UpdatedAt = DateTime.Now.AddDays(-176),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 120,
                Name = "Volkswagen T-Cross",
                Description = "Cùng với Teramont, Volkswagen T-Cross 2021 được đồn đoán là mẫu xe hoàn toàn mới sẽ gia nhập đội hình sản phẩm xe hơi của Volkswagen (VW) tại Việt Nam trong năm 2021. Hiện tại, VW Việt Nam vẫn chưa tiết lộ bất cứ thông tin nào về kế hoạch ra mắt T-Cross 2021 tại Việt Nam.",
                ClientId = 120,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-175),
                UpdatedAt = DateTime.Now.AddDays(-175),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 121,
                Name = "Dự án The Filmore Đà Nẵng",
                Description = "Diện tích khu đất 1.504,2 m2 với quy mô 25 tầng nổi, 3 tầng hầm và 206 căn hộ cao cấp (gồm các căn hộ 1 phòng ngủ, 2 phòng ngủ, 3 phòng ngủ - Duplex, Dual Key). Tổng diện tích sàn xây dựng hơn 22.600 m2, diện tích sàn nhà ở khoảng 12.876 m2, diện tích sàn sử dụng thương mại dịch vụ gần 300 m2. Mật độ xây dựng khối đế 55,6%, khối tháp 47,8%. Dự án dự kiến hoàn thành và bàn giao vào quý IV/2022.",
                ClientId = 121,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-204),
                UpdatedAt = DateTime.Now.AddDays(-204),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 122,
                Name = "Ô tô điện thông minh vf-e38",
                Description = "Thuộc phân khúc C, từng được công bố vào tháng 1/2021 với tên mã VF31. Xe có chiều dài cơ sở 2.611mm, kích thước các chiều dài x rộng x cao là 4.300 x 1.793 x 1.613 (mm), khoảng sáng gầm xe 180mm, trọng lượng không tải 1.490kg. VinFast VF e34 được trang bị một động cơ điện có công suất tối đa 110 kW ( 147 HP), mô-men xoắn cực đại 242 Nm cùng hệ dẫn động cầu trước, hệ thống treo trước MacPherson, hệ thống treo sau dạng thanh xoắn. Xe sử dụng một bộ pin dung lượng 42kWh, có thể đi được quãng đường 300km sau mỗi lần sạc đầy. Để minh chứng cho đẳng cấp, chất lượng và tạo sự an tâm cho khách hàng, VinFast tiên phong áp dụng chính sách bảo hành lên tới 10 năm cho xe VF e38",
                ClientId = 122,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-203),
                UpdatedAt = DateTime.Now.AddDays(-203),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 123,
                Name = "Xi măng Nghi Sơn đa dụng",
                Description = "chất lượng PCB40, được sản xuất từ công nghệ Nhật tiên tiến, chất lượng được kiểm soát bởi các chuyên gia Nhật Bản",
                ClientId = 123,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-202),
                UpdatedAt = DateTime.Now.AddDays(-202),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 124,
                Name = "Gạch bê tông AAC",
                Description = "Gạch bê tông AAC (viết tắt của ba từ tiếng Anh là “Aerated Autoclaved Concrete”) hay còn có tên là “gạch bê tông khí chưng áp” đây là loại vật liệu mới trong xây dựng với kết cấu bê tông gồm các bọt khí nhỏ. Mặc dù đã xuất hiện và bắt đầu sử dụng trên Thế Giới gần 1 thế kỷ trước. Tuy nhiên đến năm 2008 Việt Nam mới bắt đầu nhập khẩu và sử dụng loại vật liệu này.Đây được xem là vật liệu xanh vì có thể tái sử dụng. Được sản xuất bằng công nghệ khí chưng áp từ các nguyên liệu như cát, vôi, thạch cao, xi măng, bột nhôm và không gây ô nhiễm nên thân thiện môi trường.",
                ClientId = 124,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-201),
                UpdatedAt = DateTime.Now.AddDays(-201),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 125,
                Name = "Tấm panel ALC",
                Description = "ALC (Autoclaced Lightweight Aerated Concrete) hay được gọi là “Bê tông gia khí chưng áp. Tấm tường Panel được sản xuất bằng các nguyên liệu giống với nguyên liệu tạo ra sản phẩm gạch nhẹ AAC. Với khả năng chịu lực cao, tấm ALC được chế tạo bằng 2 lớp thép (thép nguội), cấu trúc không gian 3 chiều nên tạo ra một bộ khung cứng và vững chắc. Ứng dụng để làm tường, sàn, cầu thang, mái,… Có thể gia công cưa, cắt, khoan hay đóng đinh một cách đơn giản, tốn ít thời gian, quá trình lắp đặt nhanh chóng thuận tiện.",
                ClientId = 125,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-200),
                UpdatedAt = DateTime.Now.AddDays(-200),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 126,
                Name = "Xi măng công nghệ nano",
                Description = "Đây là sản phẩm vật liệu mới trong xây dựng nhà ở và công trình. Sản phẩm có độ cứng và độ bền vượt trội. Với công thức độc đáo đây là công nghệ vật liệu mới trong xây dựng – công nghệ độc quyền của SCG giúp cải tiến chất lượng xi măng, các phân tử xi măng tạo ra ở kích thước nano nên tạo ra liên kết vô cùng chặt chẽ nên giảm thiểu khả năng nứt, rò rỉ của công trình một trong những nguyên nhân gây ra chính là do các lỗ rỗng trong quá trình trộn bê tông tạo ra khi sử dụng xi măng cũ tiếp xúc với các tác nhân môi trường như nắng, gió, mưa,..",
                ClientId = 126,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-199),
                UpdatedAt = DateTime.Now.AddDays(-199),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 127,
                Name = "Tấm tường bê tông đúc sẵn",
                Description = "Ưu điểm dễ dàng thi công lắp đặt với 6m2 tường chỉ cần 3 công nhân làm việc trong 1 giờ đồng hồ nên giúp tiết kiệm nhân lực lao động. So với các loại truyền thống như tường gạch, block bê tông thì tấm tường bê tông đúc sẵn này có tuổi thọ cao hơn, giảm chi phí sử dụng vật liệu hơn do có chiều dày nhỏ hơn chỉ khoảng 68 – 140 mm nên còn giúp tiết kiệm không gian lắp đặt tăng diện tích sử dụng cho nhà ở hoặc công trình.",
                ClientId = 127,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-198),
                UpdatedAt = DateTime.Now.AddDays(-198),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 128,
                Name = "Gạch men và sứ vệ sinh kháng khuẩn",
                Description = "Đây là dòng sản phẩm với khả năng tự tiêu diệt vi khuẩn khi bám trên bề mặt sản phẩm. Ở nước ngoài đây là loại vật liệu chủ yếu dùng trong các cơ sở y tế và bệnh viện. Với lớp men Nano phun trực tiếp lên sản phẩm và nung ở nhiệt độ 1200 – 1250 độ C, giúp cho lớp men này trở nên siêu bền trên bề mặt, chống bám dính, ổ bẩn cũng như góp phần tăng độ nhẵn mịn bóng loáng cho sản phẩm.",
                ClientId = 128,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-197),
                UpdatedAt = DateTime.Now.AddDays(-197),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 129,
                Name = "METRO STAR",
                Description = "Metro Star có vị trí đắc địa ở địa chỉ 360 Xa Lộ Hà Nội, nằm trong khu dân cư đông đúc, sôi động của cửa ngõ phía Đông Sài Gòn - nơi có hai mặt tiền đường là Xa lộ Hà Nội và Nam Hòa cùng với công viên cỏ xanh  rộng rãi, thoáng đãng, đặc biệt là dự án hiếm hoi có cầu bộ hành kết nối trực tiếp từ ga Metro số 10 đi vào tầng 2 khu dân cư.Metro Star được đầu tư phát triển bởi Công ty Metro Star, trực thuộc Tổng Công ty C.T Land (thành viên Tập đoàn C.T Group - Tập đoàn đa ngành hàng đầu Việt Nam), mang đến một “siêu phẩm” độc đáo về kiến trúc, chất lượng xây dựng tiêu chuẩn Singapore và 100+ tiện ích đậm chất quốc đảo sư tử.",
                ClientId = 129,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-196),
                UpdatedAt = DateTime.Now.AddDays(-196),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 130,
                Name = "C.T PLAZA",
                Description = "C.T Plaza là một thương hiệu nhà ở và thương mại văn phòng rất đặc biệt, là sự kết hợp hài hòa giữa 3 đỉnh cao: Nghệ thuật của Tạo hóa là Thiên nhiên tươi đẹp, Nghệ thuật của Nhân loại là Kiến trúc, Hội họa, Âm nhạc, Phim ảnh…và đẹp hơn hết là Con người với cái đẹp của thân thể và tâm hồn…nơi con người có thể nâng cuộc sống hằng ngày lên thành Nghệ thuật sống cuộc đời (Living Art) để mỗi người hạnh phúc tuyệt vời theo cách riêng trong ngôi nhà của mình (A Life Style Home Brand).",
                ClientId = 130,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-195),
                UpdatedAt = DateTime.Now.AddDays(-195),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 131,
                Name = "I-HOME",
                Description = "Thương hiệu I-Home cực kỳ mới lạ và đặc biệt yêu thích bởi giới trẻ với concept rất thú vị và giá rất nice. Là sự kết hợp giữa Home và Internet trong 1 thế giới phẳng. Khu I-Home tại 359 Phạm Văn Chiêu, Q.Gò Vấp với vị trí thuận lợi, tiện ích nội khu vượt trội, thiết kế thông minh, nội thất cao cấp nhưng giá chỉ bằng giá nhà ở xã hội, Khai trương và vận hành chính thức tòa nhà vào đầu tháng 04/2017.",
                ClientId = 131,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-194),
                UpdatedAt = DateTime.Now.AddDays(-194),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 132,
                Name = "The Zen Park",
                Description = "Tổng diện tích đất: 28.834 m2 Tổng số tòa: 4 (R1.01, R1.02, R1.03, R1.05) Số tầng mỗi tòa: 31 tầng nổi Diện tích tầng hầm: ~ 24.000 m2 Diện tích cây xanh: 6.208 m2 Diện tích mặt nước Hồ cá Koi: 692 m2 Toà mở bán: 2 toà (R1.02 & R1.05) Số lượng mở bán - 7 loại căn hộ: Studio (52 căn) : 1PN: 271 căn, 1PN+1: 263 căn, 2PN: 224 căn, 2PN+1: 85 căn, 3PN: 31 căn, 3PN+1: 35 cănCác loại căn hộ diện tích linh hoạt (từ 28m2 đến 95 m2)",
                ClientId = 132,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-193),
                UpdatedAt = DateTime.Now.AddDays(-193),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 133,
                Name = "Vinhome Ocean Park",
                Description = "Được quy hoạch bởi đơn vị tư vấn thiết kế hàng đầu thế giới EDSA, với mật độ xây dựng thấp chỉ gần 19% Vinhomes Ocean Park mang tầm vóc một đại đô thị đồng bộ tiện ích như Đảo quốc Singapore. Và hơn thế nữa, dự án sở hữu những đại tiện ích và cảnh quan quy mô tầm cỡ, mới mẻ như Công viên Gym ngoài trời, Công viên BBQ rộng lớn trên nền tảng không gian cây xanh, mặt nước đa dạng.",
                ClientId = 133,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-192),
                UpdatedAt = DateTime.Now.AddDays(-192),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 134,
                Name = "VegaCity",
                Description = "Với muôn vàn cung bậc của trái tim, từ êm đềm thảnh thơi đến cháy bừng hứng khởi, Vega Continental Shopping Plaza mang đậm cảm hứng cuộc đại hải trình vĩ đại, nơi nhịp sống rộn ràng không ngừng nghỉ, thắp sáng lên một khung trời lễ hội.",
                ClientId = 134,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-191),
                UpdatedAt = DateTime.Now.AddDays(-191),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 135,
                Name = "Shophouse Bình Minh Garden",
                Description = "Vị trí: Số 93 phố Đức Giang, phường Đức Giang, quận Long Biên, Hà Nội Chủ đầu tư: Công ty cổ phần đầu tư và phát triển BĐS Thế Kỷ - Cen Invest Diện tích khu thấp tầng: 9.511m2 Mật độ xây dựng thấp tầng: 70% Nhà thầu thiết kế: Công ty CP tư vấn AA (AA – Corp)",
                ClientId = 135,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-190),
                UpdatedAt = DateTime.Now.AddDays(-190),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 136,
                Name = "Chung cư Bình Minh Garden",
                Description = "Được định hướng phát triển cuộc sống năng động, đầy đủ, mọi tiện ích phục vụ nhu cầu hàng ngày của cư dân được bố trí ngay trong nội khu dự án từ ăn uống, mua sắm, dịch vụ làm đẹp, ngân hàng,…",
                ClientId = 136,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-189),
                UpdatedAt = DateTime.Now.AddDays(-189),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 137,
                Name = "Chung Cư Cao Cấp I Tower Quy Nhơn",
                Description = "I–Tower Quy Nhơn là dự án chung cư căn hộ thương mại cao cấp được UBND tỉnh chấp thuận chủ trương đầu tư từ đầu năm 2015 do Công ty CP Đầu tư Phát triển bất động sản Đô Thành làm chủ đầu tư. Đây là dự án sở hữu vị trí “Vàng” ngay trung tâm Tp biển Quy Nhơn.",
                ClientId = 137,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-188),
                UpdatedAt = DateTime.Now.AddDays(-188),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 138,
                Name = "La Queenara Hội An",
                Description = "Lấy cảm hứng thiết kế từ câu chuyện di sản và con người Hội An, La Queenara gây ấn tượng  với hệ sinh thái 200 tiện ích phức hợp, tạo nên tổng thể hài hòa kiến tạo cộng đồng tinh hoa ngay trong lòng thành phố di sản: ",
                ClientId = 138,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-187),
                UpdatedAt = DateTime.Now.AddDays(-187),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 139,
                Name = "Samsora Premier 109",
                Description = "Samsora Premier là dự án chung cư nằm ngay trên mặt đường Chu Văn An huyết mạch kết nối giao thông phía Đông Bắc và Tây Nam thành phố. Dự án được nhiều khách hàng biết tới với quy hoạch hiện đại và hạ tầng tiện ích đầu tư chất lượng.",
                ClientId = 139,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-186),
                UpdatedAt = DateTime.Now.AddDays(-186),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 140,
                Name = "Vườn Vua Resort & Villas",
                Description = "Từ thủ đô Hà Nội đi theo đường Đại Lộ Thăng Long, qua Làng Văn hóa các Dân tộc Việt Nam, lên thẳng Đá Chông (khu di tích K9), qua Cầu Đồng Quang - Phà Đá Chông vượt Sông Đà 2km là đến Vườn Vua, với khoảng 65km từ Hà Nội. Nếu đi theo đường quốc lộ 32 qua cầu Trung Hà, qua huyện lỵ Thanh Thuỷ đến Vườn Vua khoảng 85km.",
                ClientId = 140,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-185),
                UpdatedAt = DateTime.Now.AddDays(-185),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 141,
                Name = "Khai Sơn Town",
                Description = "Nằm cách phố cổ chỉ 10 phút di chuyển, dự án Khai Sơn Town thuộc quần thể đô thị Khai Sơn City Long Biên được thừa hưởng nhiều ưu thế để phát triển mạnh mẽ trong tương lai. Dự án không chỉ có ưu thế về liên kết hạ tầng giao thông, tiện ích, mà còn có nhiều tiềm năng tăng giá, xứng đáng là khoản đầu tư không thể bỏ qua của các nhà đầu tư.",
                ClientId = 141,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-184),
                UpdatedAt = DateTime.Now.AddDays(-184),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 142,
                Name = "Mercedes-Benz GLS 600 Maybach",
                Description = "Tình trạng Mới Năm sản xuất 2021 Kiểu dáng SUV Xuất xứ Nhập khẩu Hộp số Số tự động",
                ClientId = 142,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-183),
                UpdatedAt = DateTime.Now.AddDays(-183),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 143,
                Name = "Toyota Crown Royal Saloon 3.0 MT bản full",
                Description = "Tình trạng Đã qua sử dụng Số km đã đi 32.000 km Năm sản xuất 1998 Kiểu dáng Sedan Xuất xứ Nhập khẩu Hộp số Số tay",
                ClientId = 143,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-182),
                UpdatedAt = DateTime.Now.AddDays(-182),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 144,
                Name = "Xe tải Hino FG tải 8 tấn thùng dài",
                Description = "Tình trạng Mới Năm sản xuất 2020 Kiểu dáng Truck Xuất xứ Lắp ráp Hộp số Số tay Địa chỉ rao bán Tp.HCM",
                ClientId = 144,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-181),
                UpdatedAt = DateTime.Now.AddDays(-181),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 145,
                Name = "Kia Cerato 2.0AT",
                Description = "Tình trạng Đã qua sử dụng Số km đã đi 12.000 km Năm sản xuất 2019 Kiểu dáng Sedan Hộp số Số tự động Địa chỉ rao bán Tp.HCM",
                ClientId = 145,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-180),
                UpdatedAt = DateTime.Now.AddDays(-180),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 146,
                Name = "Toyota Land Cruiser 2002",
                Description = "Tình trạng Đã qua sử dụng Số km đã đi 18.000 km Năm sản xuất 1998 Kiểu dáng SUV Xuất xứ Nhập khẩu Hộp số Số tay Địa chỉ rao bán Hà Nội",
                ClientId = 146,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-179),
                UpdatedAt = DateTime.Now.AddDays(-179),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 147,
                Name = "Lexus RX 350 F-Sport 2020",
                Description = "Tình trạng Đã qua sử dụngSố km đã đi22.000 kmNăm sản xuất2016Kiểu dángSUVXuất xứNhập khẩuHộp sốSố tự động",
                ClientId = 147,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-178),
                UpdatedAt = DateTime.Now.AddDays(-178),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 148,
                Name = "Mercedes G63 Edition 5",
                Description = "Tình trạng Mới Năm sản xuất 2021 Kiểu dáng SUV Xuất xứ Nhập khẩu Hộp số Số tự động Địa chỉ rao bán Hà Nội",
                ClientId = 148,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-177),
                UpdatedAt = DateTime.Now.AddDays(-177),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 149,
                Name = "Mazda CX 5 2023",
                Description = "Tình trạng Đã qua sử dụng Số km đã đi 27.000 km Năm sản xuất 2019 Kiểu dáng SUV Hộp số Số tự động Địa chỉ rao bán Tp.HCM",
                ClientId = 149,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-176),
                UpdatedAt = DateTime.Now.AddDays(-176),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 150,
                Name = "Volkswagen T-Cross",
                Description = "Cùng với Teramont, Volkswagen T-Cross 2021 được đồn đoán là mẫu xe hoàn toàn mới sẽ gia nhập đội hình sản phẩm xe hơi của Volkswagen (VW) tại Việt Nam trong năm 2021. Hiện tại, VW Việt Nam vẫn chưa tiết lộ bất cứ thông tin nào về kế hoạch ra mắt T-Cross 2021 tại Việt Nam.",
                ClientId = 150,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-175),
                UpdatedAt = DateTime.Now.AddDays(-175),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 151,
                Name = "Dự án The Filmore Đà Nẵng",
                Description = "Diện tích khu đất 1.504,2 m2 với quy mô 25 tầng nổi, 3 tầng hầm và 206 căn hộ cao cấp (gồm các căn hộ 1 phòng ngủ, 2 phòng ngủ, 3 phòng ngủ - Duplex, Dual Key). Tổng diện tích sàn xây dựng hơn 22.600 m2, diện tích sàn nhà ở khoảng 12.876 m2, diện tích sàn sử dụng thương mại dịch vụ gần 300 m2. Mật độ xây dựng khối đế 55,6%, khối tháp 47,8%. Dự án dự kiến hoàn thành và bàn giao vào quý IV/2022.",
                ClientId = 151,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-204),
                UpdatedAt = DateTime.Now.AddDays(-204),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 152,
                Name = "Ô tô điện thông minh vf-e39",
                Description = "Thuộc phân khúc C, từng được công bố vào tháng 1/2021 với tên mã VF31. Xe có chiều dài cơ sở 2.611mm, kích thước các chiều dài x rộng x cao là 4.300 x 1.793 x 1.613 (mm), khoảng sáng gầm xe 180mm, trọng lượng không tải 1.490kg. VinFast VF e34 được trang bị một động cơ điện có công suất tối đa 110 kW ( 147 HP), mô-men xoắn cực đại 242 Nm cùng hệ dẫn động cầu trước, hệ thống treo trước MacPherson, hệ thống treo sau dạng thanh xoắn. Xe sử dụng một bộ pin dung lượng 42kWh, có thể đi được quãng đường 300km sau mỗi lần sạc đầy. Để minh chứng cho đẳng cấp, chất lượng và tạo sự an tâm cho khách hàng, VinFast tiên phong áp dụng chính sách bảo hành lên tới 10 năm cho xe VF e39",
                ClientId = 152,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-203),
                UpdatedAt = DateTime.Now.AddDays(-203),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 153,
                Name = "Xi măng Nghi Sơn đa dụng",
                Description = "chất lượng PCB40, được sản xuất từ công nghệ Nhật tiên tiến, chất lượng được kiểm soát bởi các chuyên gia Nhật Bản",
                ClientId = 153,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-202),
                UpdatedAt = DateTime.Now.AddDays(-202),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 154,
                Name = "Gạch bê tông AAC",
                Description = "Gạch bê tông AAC (viết tắt của ba từ tiếng Anh là “Aerated Autoclaved Concrete”) hay còn có tên là “gạch bê tông khí chưng áp” đây là loại vật liệu mới trong xây dựng với kết cấu bê tông gồm các bọt khí nhỏ. Mặc dù đã xuất hiện và bắt đầu sử dụng trên Thế Giới gần 1 thế kỷ trước. Tuy nhiên đến năm 2008 Việt Nam mới bắt đầu nhập khẩu và sử dụng loại vật liệu này.Đây được xem là vật liệu xanh vì có thể tái sử dụng. Được sản xuất bằng công nghệ khí chưng áp từ các nguyên liệu như cát, vôi, thạch cao, xi măng, bột nhôm và không gây ô nhiễm nên thân thiện môi trường.",
                ClientId = 154,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-201),
                UpdatedAt = DateTime.Now.AddDays(-201),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 155,
                Name = "Tấm panel ALC",
                Description = "ALC (Autoclaced Lightweight Aerated Concrete) hay được gọi là “Bê tông gia khí chưng áp. Tấm tường Panel được sản xuất bằng các nguyên liệu giống với nguyên liệu tạo ra sản phẩm gạch nhẹ AAC. Với khả năng chịu lực cao, tấm ALC được chế tạo bằng 2 lớp thép (thép nguội), cấu trúc không gian 3 chiều nên tạo ra một bộ khung cứng và vững chắc. Ứng dụng để làm tường, sàn, cầu thang, mái,… Có thể gia công cưa, cắt, khoan hay đóng đinh một cách đơn giản, tốn ít thời gian, quá trình lắp đặt nhanh chóng thuận tiện.",
                ClientId = 155,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-200),
                UpdatedAt = DateTime.Now.AddDays(-200),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 156,
                Name = "Xi măng công nghệ nano",
                Description = "Đây là sản phẩm vật liệu mới trong xây dựng nhà ở và công trình. Sản phẩm có độ cứng và độ bền vượt trội. Với công thức độc đáo đây là công nghệ vật liệu mới trong xây dựng – công nghệ độc quyền của SCG giúp cải tiến chất lượng xi măng, các phân tử xi măng tạo ra ở kích thước nano nên tạo ra liên kết vô cùng chặt chẽ nên giảm thiểu khả năng nứt, rò rỉ của công trình một trong những nguyên nhân gây ra chính là do các lỗ rỗng trong quá trình trộn bê tông tạo ra khi sử dụng xi măng cũ tiếp xúc với các tác nhân môi trường như nắng, gió, mưa,..",
                ClientId = 156,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-199),
                UpdatedAt = DateTime.Now.AddDays(-199),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 157,
                Name = "Tấm tường bê tông đúc sẵn",
                Description = "Ưu điểm dễ dàng thi công lắp đặt với 6m2 tường chỉ cần 3 công nhân làm việc trong 1 giờ đồng hồ nên giúp tiết kiệm nhân lực lao động. So với các loại truyền thống như tường gạch, block bê tông thì tấm tường bê tông đúc sẵn này có tuổi thọ cao hơn, giảm chi phí sử dụng vật liệu hơn do có chiều dày nhỏ hơn chỉ khoảng 68 – 140 mm nên còn giúp tiết kiệm không gian lắp đặt tăng diện tích sử dụng cho nhà ở hoặc công trình.",
                ClientId = 157,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-198),
                UpdatedAt = DateTime.Now.AddDays(-198),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 158,
                Name = "Gạch men và sứ vệ sinh kháng khuẩn",
                Description = "Đây là dòng sản phẩm với khả năng tự tiêu diệt vi khuẩn khi bám trên bề mặt sản phẩm. Ở nước ngoài đây là loại vật liệu chủ yếu dùng trong các cơ sở y tế và bệnh viện. Với lớp men Nano phun trực tiếp lên sản phẩm và nung ở nhiệt độ 1200 – 1250 độ C, giúp cho lớp men này trở nên siêu bền trên bề mặt, chống bám dính, ổ bẩn cũng như góp phần tăng độ nhẵn mịn bóng loáng cho sản phẩm.",
                ClientId = 158,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-197),
                UpdatedAt = DateTime.Now.AddDays(-197),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 159,
                Name = "METRO STAR",
                Description = "Metro Star có vị trí đắc địa ở địa chỉ 360 Xa Lộ Hà Nội, nằm trong khu dân cư đông đúc, sôi động của cửa ngõ phía Đông Sài Gòn - nơi có hai mặt tiền đường là Xa lộ Hà Nội và Nam Hòa cùng với công viên cỏ xanh  rộng rãi, thoáng đãng, đặc biệt là dự án hiếm hoi có cầu bộ hành kết nối trực tiếp từ ga Metro số 10 đi vào tầng 2 khu dân cư.Metro Star được đầu tư phát triển bởi Công ty Metro Star, trực thuộc Tổng Công ty C.T Land (thành viên Tập đoàn C.T Group - Tập đoàn đa ngành hàng đầu Việt Nam), mang đến một “siêu phẩm” độc đáo về kiến trúc, chất lượng xây dựng tiêu chuẩn Singapore và 100+ tiện ích đậm chất quốc đảo sư tử.",
                ClientId = 159,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-196),
                UpdatedAt = DateTime.Now.AddDays(-196),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 160,
                Name = "C.T PLAZA",
                Description = "C.T Plaza là một thương hiệu nhà ở và thương mại văn phòng rất đặc biệt, là sự kết hợp hài hòa giữa 3 đỉnh cao: Nghệ thuật của Tạo hóa là Thiên nhiên tươi đẹp, Nghệ thuật của Nhân loại là Kiến trúc, Hội họa, Âm nhạc, Phim ảnh…và đẹp hơn hết là Con người với cái đẹp của thân thể và tâm hồn…nơi con người có thể nâng cuộc sống hằng ngày lên thành Nghệ thuật sống cuộc đời (Living Art) để mỗi người hạnh phúc tuyệt vời theo cách riêng trong ngôi nhà của mình (A Life Style Home Brand).",
                ClientId = 160,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-195),
                UpdatedAt = DateTime.Now.AddDays(-195),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 161,
                Name = "I-HOME",
                Description = "Thương hiệu I-Home cực kỳ mới lạ và đặc biệt yêu thích bởi giới trẻ với concept rất thú vị và giá rất nice. Là sự kết hợp giữa Home và Internet trong 1 thế giới phẳng. Khu I-Home tại 359 Phạm Văn Chiêu, Q.Gò Vấp với vị trí thuận lợi, tiện ích nội khu vượt trội, thiết kế thông minh, nội thất cao cấp nhưng giá chỉ bằng giá nhà ở xã hội, Khai trương và vận hành chính thức tòa nhà vào đầu tháng 04/2017.",
                ClientId = 161,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-194),
                UpdatedAt = DateTime.Now.AddDays(-194),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 162,
                Name = "The Zen Park",
                Description = "Tổng diện tích đất: 28.834 m2 Tổng số tòa: 4 (R1.01, R1.02, R1.03, R1.05) Số tầng mỗi tòa: 31 tầng nổi Diện tích tầng hầm: ~ 24.000 m2 Diện tích cây xanh: 6.208 m2 Diện tích mặt nước Hồ cá Koi: 692 m2 Toà mở bán: 2 toà (R1.02 & R1.05) Số lượng mở bán - 7 loại căn hộ: Studio (52 căn) : 1PN: 271 căn, 1PN+1: 263 căn, 2PN: 224 căn, 2PN+1: 85 căn, 3PN: 31 căn, 3PN+1: 35 cănCác loại căn hộ diện tích linh hoạt (từ 28m2 đến 95 m2)",
                ClientId = 162,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-193),
                UpdatedAt = DateTime.Now.AddDays(-193),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 163,
                Name = "Vinhome Ocean Park",
                Description = "Được quy hoạch bởi đơn vị tư vấn thiết kế hàng đầu thế giới EDSA, với mật độ xây dựng thấp chỉ gần 19% Vinhomes Ocean Park mang tầm vóc một đại đô thị đồng bộ tiện ích như Đảo quốc Singapore. Và hơn thế nữa, dự án sở hữu những đại tiện ích và cảnh quan quy mô tầm cỡ, mới mẻ như Công viên Gym ngoài trời, Công viên BBQ rộng lớn trên nền tảng không gian cây xanh, mặt nước đa dạng.",
                ClientId = 163,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-192),
                UpdatedAt = DateTime.Now.AddDays(-192),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 164,
                Name = "VegaCity",
                Description = "Với muôn vàn cung bậc của trái tim, từ êm đềm thảnh thơi đến cháy bừng hứng khởi, Vega Continental Shopping Plaza mang đậm cảm hứng cuộc đại hải trình vĩ đại, nơi nhịp sống rộn ràng không ngừng nghỉ, thắp sáng lên một khung trời lễ hội.",
                ClientId = 164,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-191),
                UpdatedAt = DateTime.Now.AddDays(-191),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 165,
                Name = "Shophouse Bình Minh Garden",
                Description = "Vị trí: Số 93 phố Đức Giang, phường Đức Giang, quận Long Biên, Hà Nội Chủ đầu tư: Công ty cổ phần đầu tư và phát triển BĐS Thế Kỷ - Cen Invest Diện tích khu thấp tầng: 9.511m2 Mật độ xây dựng thấp tầng: 70% Nhà thầu thiết kế: Công ty CP tư vấn AA (AA – Corp)",
                ClientId = 165,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-190),
                UpdatedAt = DateTime.Now.AddDays(-190),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 166,
                Name = "Chung cư Bình Minh Garden",
                Description = "Được định hướng phát triển cuộc sống năng động, đầy đủ, mọi tiện ích phục vụ nhu cầu hàng ngày của cư dân được bố trí ngay trong nội khu dự án từ ăn uống, mua sắm, dịch vụ làm đẹp, ngân hàng,…",
                ClientId = 166,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-189),
                UpdatedAt = DateTime.Now.AddDays(-189),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 167,
                Name = "Chung Cư Cao Cấp I Tower Quy Nhơn",
                Description = "I–Tower Quy Nhơn là dự án chung cư căn hộ thương mại cao cấp được UBND tỉnh chấp thuận chủ trương đầu tư từ đầu năm 2015 do Công ty CP Đầu tư Phát triển bất động sản Đô Thành làm chủ đầu tư. Đây là dự án sở hữu vị trí “Vàng” ngay trung tâm Tp biển Quy Nhơn.",
                ClientId = 167,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-188),
                UpdatedAt = DateTime.Now.AddDays(-188),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 168,
                Name = "La Queenara Hội An",
                Description = "Lấy cảm hứng thiết kế từ câu chuyện di sản và con người Hội An, La Queenara gây ấn tượng  với hệ sinh thái 200 tiện ích phức hợp, tạo nên tổng thể hài hòa kiến tạo cộng đồng tinh hoa ngay trong lòng thành phố di sản: ",
                ClientId = 168,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-187),
                UpdatedAt = DateTime.Now.AddDays(-187),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 169,
                Name = "Samsora Premier 110",
                Description = "Samsora Premier là dự án chung cư nằm ngay trên mặt đường Chu Văn An huyết mạch kết nối giao thông phía Đông Bắc và Tây Nam thành phố. Dự án được nhiều khách hàng biết tới với quy hoạch hiện đại và hạ tầng tiện ích đầu tư chất lượng.",
                ClientId = 169,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-186),
                UpdatedAt = DateTime.Now.AddDays(-186),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 170,
                Name = "Vườn Vua Resort & Villas",
                Description = "Từ thủ đô Hà Nội đi theo đường Đại Lộ Thăng Long, qua Làng Văn hóa các Dân tộc Việt Nam, lên thẳng Đá Chông (khu di tích K9), qua Cầu Đồng Quang - Phà Đá Chông vượt Sông Đà 2km là đến Vườn Vua, với khoảng 65km từ Hà Nội. Nếu đi theo đường quốc lộ 32 qua cầu Trung Hà, qua huyện lỵ Thanh Thuỷ đến Vườn Vua khoảng 85km.",
                ClientId = 170,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-185),
                UpdatedAt = DateTime.Now.AddDays(-185),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 171,
                Name = "Khai Sơn Town",
                Description = "Nằm cách phố cổ chỉ 10 phút di chuyển, dự án Khai Sơn Town thuộc quần thể đô thị Khai Sơn City Long Biên được thừa hưởng nhiều ưu thế để phát triển mạnh mẽ trong tương lai. Dự án không chỉ có ưu thế về liên kết hạ tầng giao thông, tiện ích, mà còn có nhiều tiềm năng tăng giá, xứng đáng là khoản đầu tư không thể bỏ qua của các nhà đầu tư.",
                ClientId = 171,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-184),
                UpdatedAt = DateTime.Now.AddDays(-184),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 172,
                Name = "Mercedes-Benz GLS 600 Maybach",
                Description = "Tình trạng Mới Năm sản xuất 2021 Kiểu dáng SUV Xuất xứ Nhập khẩu Hộp số Số tự động",
                ClientId = 172,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-183),
                UpdatedAt = DateTime.Now.AddDays(-183),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 173,
                Name = "Toyota Crown Royal Saloon 3.0 MT bản full",
                Description = "Tình trạng Đã qua sử dụng Số km đã đi 32.000 km Năm sản xuất 1998 Kiểu dáng Sedan Xuất xứ Nhập khẩu Hộp số Số tay",
                ClientId = 173,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-182),
                UpdatedAt = DateTime.Now.AddDays(-182),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 174,
                Name = "Xe tải Hino FG tải 8 tấn thùng dài",
                Description = "Tình trạng Mới Năm sản xuất 2020 Kiểu dáng Truck Xuất xứ Lắp ráp Hộp số Số tay Địa chỉ rao bán Tp.HCM",
                ClientId = 174,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-181),
                UpdatedAt = DateTime.Now.AddDays(-181),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 175,
                Name = "Kia Cerato 2.0AT",
                Description = "Tình trạng Đã qua sử dụng Số km đã đi 12.000 km Năm sản xuất 2019 Kiểu dáng Sedan Hộp số Số tự động Địa chỉ rao bán Tp.HCM",
                ClientId = 175,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-180),
                UpdatedAt = DateTime.Now.AddDays(-180),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 176,
                Name = "Toyota Land Cruiser 2003",
                Description = "Tình trạng Đã qua sử dụng Số km đã đi 18.000 km Năm sản xuất 1998 Kiểu dáng SUV Xuất xứ Nhập khẩu Hộp số Số tay Địa chỉ rao bán Hà Nội",
                ClientId = 176,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-179),
                UpdatedAt = DateTime.Now.AddDays(-179),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 177,
                Name = "Lexus RX 350 F-Sport 2021",
                Description = "Tình trạng Đã qua sử dụngSố km đã đi22.000 kmNăm sản xuất2016Kiểu dángSUVXuất xứNhập khẩuHộp sốSố tự động",
                ClientId = 177,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-178),
                UpdatedAt = DateTime.Now.AddDays(-178),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 178,
                Name = "Mercedes G63 Edition 6",
                Description = "Tình trạng Mới Năm sản xuất 2021 Kiểu dáng SUV Xuất xứ Nhập khẩu Hộp số Số tự động Địa chỉ rao bán Hà Nội",
                ClientId = 178,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-177),
                UpdatedAt = DateTime.Now.AddDays(-177),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 179,
                Name = "Mazda CX 5 2024",
                Description = "Tình trạng Đã qua sử dụng Số km đã đi 27.000 km Năm sản xuất 2019 Kiểu dáng SUV Hộp số Số tự động Địa chỉ rao bán Tp.HCM",
                ClientId = 179,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-176),
                UpdatedAt = DateTime.Now.AddDays(-176),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 180,
                Name = "Volkswagen T-Cross",
                Description = "Cùng với Teramont, Volkswagen T-Cross 2021 được đồn đoán là mẫu xe hoàn toàn mới sẽ gia nhập đội hình sản phẩm xe hơi của Volkswagen (VW) tại Việt Nam trong năm 2021. Hiện tại, VW Việt Nam vẫn chưa tiết lộ bất cứ thông tin nào về kế hoạch ra mắt T-Cross 2021 tại Việt Nam.",
                ClientId = 180,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-175),
                UpdatedAt = DateTime.Now.AddDays(-175),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 181,
                Name = "Dự án The Filmore Đà Nẵng",
                Description = "Diện tích khu đất 1.504,2 m2 với quy mô 25 tầng nổi, 3 tầng hầm và 206 căn hộ cao cấp (gồm các căn hộ 1 phòng ngủ, 2 phòng ngủ, 3 phòng ngủ - Duplex, Dual Key). Tổng diện tích sàn xây dựng hơn 22.600 m2, diện tích sàn nhà ở khoảng 12.876 m2, diện tích sàn sử dụng thương mại dịch vụ gần 300 m2. Mật độ xây dựng khối đế 55,6%, khối tháp 47,8%. Dự án dự kiến hoàn thành và bàn giao vào quý IV/2022.",
                ClientId = 181,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-204),
                UpdatedAt = DateTime.Now.AddDays(-204),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 182,
                Name = "Ô tô điện thông minh vf-e40",
                Description = "Thuộc phân khúc C, từng được công bố vào tháng 1/2021 với tên mã VF31. Xe có chiều dài cơ sở 2.611mm, kích thước các chiều dài x rộng x cao là 4.300 x 1.793 x 1.613 (mm), khoảng sáng gầm xe 180mm, trọng lượng không tải 1.490kg. VinFast VF e34 được trang bị một động cơ điện có công suất tối đa 110 kW ( 147 HP), mô-men xoắn cực đại 242 Nm cùng hệ dẫn động cầu trước, hệ thống treo trước MacPherson, hệ thống treo sau dạng thanh xoắn. Xe sử dụng một bộ pin dung lượng 42kWh, có thể đi được quãng đường 300km sau mỗi lần sạc đầy. Để minh chứng cho đẳng cấp, chất lượng và tạo sự an tâm cho khách hàng, VinFast tiên phong áp dụng chính sách bảo hành lên tới 10 năm cho xe VF e40",
                ClientId = 182,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-203),
                UpdatedAt = DateTime.Now.AddDays(-203),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 183,
                Name = "Xi măng Nghi Sơn đa dụng",
                Description = "chất lượng PCB40, được sản xuất từ công nghệ Nhật tiên tiến, chất lượng được kiểm soát bởi các chuyên gia Nhật Bản",
                ClientId = 183,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-202),
                UpdatedAt = DateTime.Now.AddDays(-202),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 184,
                Name = "Gạch bê tông AAC",
                Description = "Gạch bê tông AAC (viết tắt của ba từ tiếng Anh là “Aerated Autoclaved Concrete”) hay còn có tên là “gạch bê tông khí chưng áp” đây là loại vật liệu mới trong xây dựng với kết cấu bê tông gồm các bọt khí nhỏ. Mặc dù đã xuất hiện và bắt đầu sử dụng trên Thế Giới gần 1 thế kỷ trước. Tuy nhiên đến năm 2008 Việt Nam mới bắt đầu nhập khẩu và sử dụng loại vật liệu này.Đây được xem là vật liệu xanh vì có thể tái sử dụng. Được sản xuất bằng công nghệ khí chưng áp từ các nguyên liệu như cát, vôi, thạch cao, xi măng, bột nhôm và không gây ô nhiễm nên thân thiện môi trường.",
                ClientId = 184,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-201),
                UpdatedAt = DateTime.Now.AddDays(-201),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 185,
                Name = "Tấm panel ALC",
                Description = "ALC (Autoclaced Lightweight Aerated Concrete) hay được gọi là “Bê tông gia khí chưng áp. Tấm tường Panel được sản xuất bằng các nguyên liệu giống với nguyên liệu tạo ra sản phẩm gạch nhẹ AAC. Với khả năng chịu lực cao, tấm ALC được chế tạo bằng 2 lớp thép (thép nguội), cấu trúc không gian 3 chiều nên tạo ra một bộ khung cứng và vững chắc. Ứng dụng để làm tường, sàn, cầu thang, mái,… Có thể gia công cưa, cắt, khoan hay đóng đinh một cách đơn giản, tốn ít thời gian, quá trình lắp đặt nhanh chóng thuận tiện.",
                ClientId = 185,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-200),
                UpdatedAt = DateTime.Now.AddDays(-200),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 186,
                Name = "Xi măng công nghệ nano",
                Description = "Đây là sản phẩm vật liệu mới trong xây dựng nhà ở và công trình. Sản phẩm có độ cứng và độ bền vượt trội. Với công thức độc đáo đây là công nghệ vật liệu mới trong xây dựng – công nghệ độc quyền của SCG giúp cải tiến chất lượng xi măng, các phân tử xi măng tạo ra ở kích thước nano nên tạo ra liên kết vô cùng chặt chẽ nên giảm thiểu khả năng nứt, rò rỉ của công trình một trong những nguyên nhân gây ra chính là do các lỗ rỗng trong quá trình trộn bê tông tạo ra khi sử dụng xi măng cũ tiếp xúc với các tác nhân môi trường như nắng, gió, mưa,..",
                ClientId = 186,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-199),
                UpdatedAt = DateTime.Now.AddDays(-199),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 187,
                Name = "Tấm tường bê tông đúc sẵn",
                Description = "Ưu điểm dễ dàng thi công lắp đặt với 6m2 tường chỉ cần 3 công nhân làm việc trong 1 giờ đồng hồ nên giúp tiết kiệm nhân lực lao động. So với các loại truyền thống như tường gạch, block bê tông thì tấm tường bê tông đúc sẵn này có tuổi thọ cao hơn, giảm chi phí sử dụng vật liệu hơn do có chiều dày nhỏ hơn chỉ khoảng 68 – 140 mm nên còn giúp tiết kiệm không gian lắp đặt tăng diện tích sử dụng cho nhà ở hoặc công trình.",
                ClientId = 187,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-198),
                UpdatedAt = DateTime.Now.AddDays(-198),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 188,
                Name = "Gạch men và sứ vệ sinh kháng khuẩn",
                Description = "Đây là dòng sản phẩm với khả năng tự tiêu diệt vi khuẩn khi bám trên bề mặt sản phẩm. Ở nước ngoài đây là loại vật liệu chủ yếu dùng trong các cơ sở y tế và bệnh viện. Với lớp men Nano phun trực tiếp lên sản phẩm và nung ở nhiệt độ 1200 – 1250 độ C, giúp cho lớp men này trở nên siêu bền trên bề mặt, chống bám dính, ổ bẩn cũng như góp phần tăng độ nhẵn mịn bóng loáng cho sản phẩm.",
                ClientId = 188,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-197),
                UpdatedAt = DateTime.Now.AddDays(-197),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 189,
                Name = "METRO STAR",
                Description = "Metro Star có vị trí đắc địa ở địa chỉ 360 Xa Lộ Hà Nội, nằm trong khu dân cư đông đúc, sôi động của cửa ngõ phía Đông Sài Gòn - nơi có hai mặt tiền đường là Xa lộ Hà Nội và Nam Hòa cùng với công viên cỏ xanh  rộng rãi, thoáng đãng, đặc biệt là dự án hiếm hoi có cầu bộ hành kết nối trực tiếp từ ga Metro số 10 đi vào tầng 2 khu dân cư.Metro Star được đầu tư phát triển bởi Công ty Metro Star, trực thuộc Tổng Công ty C.T Land (thành viên Tập đoàn C.T Group - Tập đoàn đa ngành hàng đầu Việt Nam), mang đến một “siêu phẩm” độc đáo về kiến trúc, chất lượng xây dựng tiêu chuẩn Singapore và 100+ tiện ích đậm chất quốc đảo sư tử.",
                ClientId = 189,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-196),
                UpdatedAt = DateTime.Now.AddDays(-196),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 190,
                Name = "C.T PLAZA",
                Description = "C.T Plaza là một thương hiệu nhà ở và thương mại văn phòng rất đặc biệt, là sự kết hợp hài hòa giữa 3 đỉnh cao: Nghệ thuật của Tạo hóa là Thiên nhiên tươi đẹp, Nghệ thuật của Nhân loại là Kiến trúc, Hội họa, Âm nhạc, Phim ảnh…và đẹp hơn hết là Con người với cái đẹp của thân thể và tâm hồn…nơi con người có thể nâng cuộc sống hằng ngày lên thành Nghệ thuật sống cuộc đời (Living Art) để mỗi người hạnh phúc tuyệt vời theo cách riêng trong ngôi nhà của mình (A Life Style Home Brand).",
                ClientId = 190,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-195),
                UpdatedAt = DateTime.Now.AddDays(-195),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 191,
                Name = "I-HOME",
                Description = "Thương hiệu I-Home cực kỳ mới lạ và đặc biệt yêu thích bởi giới trẻ với concept rất thú vị và giá rất nice. Là sự kết hợp giữa Home và Internet trong 1 thế giới phẳng. Khu I-Home tại 359 Phạm Văn Chiêu, Q.Gò Vấp với vị trí thuận lợi, tiện ích nội khu vượt trội, thiết kế thông minh, nội thất cao cấp nhưng giá chỉ bằng giá nhà ở xã hội, Khai trương và vận hành chính thức tòa nhà vào đầu tháng 04/2017.",
                ClientId = 191,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-194),
                UpdatedAt = DateTime.Now.AddDays(-194),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 192,
                Name = "The Zen Park",
                Description = "Tổng diện tích đất: 28.834 m2 Tổng số tòa: 4 (R1.01, R1.02, R1.03, R1.05) Số tầng mỗi tòa: 31 tầng nổi Diện tích tầng hầm: ~ 24.000 m2 Diện tích cây xanh: 6.208 m2 Diện tích mặt nước Hồ cá Koi: 692 m2 Toà mở bán: 2 toà (R1.02 & R1.05) Số lượng mở bán - 7 loại căn hộ: Studio (52 căn) : 1PN: 271 căn, 1PN+1: 263 căn, 2PN: 224 căn, 2PN+1: 85 căn, 3PN: 31 căn, 3PN+1: 35 cănCác loại căn hộ diện tích linh hoạt (từ 28m2 đến 95 m2)",
                ClientId = 192,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-193),
                UpdatedAt = DateTime.Now.AddDays(-193),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 193,
                Name = "Vinhome Ocean Park",
                Description = "Được quy hoạch bởi đơn vị tư vấn thiết kế hàng đầu thế giới EDSA, với mật độ xây dựng thấp chỉ gần 19% Vinhomes Ocean Park mang tầm vóc một đại đô thị đồng bộ tiện ích như Đảo quốc Singapore. Và hơn thế nữa, dự án sở hữu những đại tiện ích và cảnh quan quy mô tầm cỡ, mới mẻ như Công viên Gym ngoài trời, Công viên BBQ rộng lớn trên nền tảng không gian cây xanh, mặt nước đa dạng.",
                ClientId = 193,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-192),
                UpdatedAt = DateTime.Now.AddDays(-192),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 194,
                Name = "VegaCity",
                Description = "Với muôn vàn cung bậc của trái tim, từ êm đềm thảnh thơi đến cháy bừng hứng khởi, Vega Continental Shopping Plaza mang đậm cảm hứng cuộc đại hải trình vĩ đại, nơi nhịp sống rộn ràng không ngừng nghỉ, thắp sáng lên một khung trời lễ hội.",
                ClientId = 194,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-191),
                UpdatedAt = DateTime.Now.AddDays(-191),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 195,
                Name = "Shophouse Bình Minh Garden",
                Description = "Vị trí: Số 93 phố Đức Giang, phường Đức Giang, quận Long Biên, Hà Nội Chủ đầu tư: Công ty cổ phần đầu tư và phát triển BĐS Thế Kỷ - Cen Invest Diện tích khu thấp tầng: 9.511m2 Mật độ xây dựng thấp tầng: 70% Nhà thầu thiết kế: Công ty CP tư vấn AA (AA – Corp)",
                ClientId = 195,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-190),
                UpdatedAt = DateTime.Now.AddDays(-190),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 196,
                Name = "Chung cư Bình Minh Garden",
                Description = "Được định hướng phát triển cuộc sống năng động, đầy đủ, mọi tiện ích phục vụ nhu cầu hàng ngày của cư dân được bố trí ngay trong nội khu dự án từ ăn uống, mua sắm, dịch vụ làm đẹp, ngân hàng,…",
                ClientId = 196,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-189),
                UpdatedAt = DateTime.Now.AddDays(-189),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 197,
                Name = "Chung Cư Cao Cấp I Tower Quy Nhơn",
                Description = "I–Tower Quy Nhơn là dự án chung cư căn hộ thương mại cao cấp được UBND tỉnh chấp thuận chủ trương đầu tư từ đầu năm 2015 do Công ty CP Đầu tư Phát triển bất động sản Đô Thành làm chủ đầu tư. Đây là dự án sở hữu vị trí “Vàng” ngay trung tâm Tp biển Quy Nhơn.",
                ClientId = 197,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-188),
                UpdatedAt = DateTime.Now.AddDays(-188),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 198,
                Name = "La Queenara Hội An",
                Description = "Lấy cảm hứng thiết kế từ câu chuyện di sản và con người Hội An, La Queenara gây ấn tượng  với hệ sinh thái 200 tiện ích phức hợp, tạo nên tổng thể hài hòa kiến tạo cộng đồng tinh hoa ngay trong lòng thành phố di sản: ",
                ClientId = 198,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-187),
                UpdatedAt = DateTime.Now.AddDays(-187),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 199,
                Name = "Samsora Premier 111",
                Description = "Samsora Premier là dự án chung cư nằm ngay trên mặt đường Chu Văn An huyết mạch kết nối giao thông phía Đông Bắc và Tây Nam thành phố. Dự án được nhiều khách hàng biết tới với quy hoạch hiện đại và hạ tầng tiện ích đầu tư chất lượng.",
                ClientId = 199,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-186),
                UpdatedAt = DateTime.Now.AddDays(-186),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 200,
                Name = "Vườn Vua Resort & Villas",
                Description = "Từ thủ đô Hà Nội đi theo đường Đại Lộ Thăng Long, qua Làng Văn hóa các Dân tộc Việt Nam, lên thẳng Đá Chông (khu di tích K9), qua Cầu Đồng Quang - Phà Đá Chông vượt Sông Đà 2km là đến Vườn Vua, với khoảng 65km từ Hà Nội. Nếu đi theo đường quốc lộ 32 qua cầu Trung Hà, qua huyện lỵ Thanh Thuỷ đến Vườn Vua khoảng 85km.",
                ClientId = 200,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-185),
                UpdatedAt = DateTime.Now.AddDays(-185),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 201,
                Name = "Khai Sơn Town",
                Description = "Nằm cách phố cổ chỉ 10 phút di chuyển, dự án Khai Sơn Town thuộc quần thể đô thị Khai Sơn City Long Biên được thừa hưởng nhiều ưu thế để phát triển mạnh mẽ trong tương lai. Dự án không chỉ có ưu thế về liên kết hạ tầng giao thông, tiện ích, mà còn có nhiều tiềm năng tăng giá, xứng đáng là khoản đầu tư không thể bỏ qua của các nhà đầu tư.",
                ClientId = 201,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-184),
                UpdatedAt = DateTime.Now.AddDays(-184),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 202,
                Name = "Mercedes-Benz GLS 600 Maybach",
                Description = "Tình trạng Mới Năm sản xuất 2021 Kiểu dáng SUV Xuất xứ Nhập khẩu Hộp số Số tự động",
                ClientId = 202,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-183),
                UpdatedAt = DateTime.Now.AddDays(-183),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 203,
                Name = "Toyota Crown Royal Saloon 3.0 MT bản full",
                Description = "Tình trạng Đã qua sử dụng Số km đã đi 32.000 km Năm sản xuất 1998 Kiểu dáng Sedan Xuất xứ Nhập khẩu Hộp số Số tay",
                ClientId = 203,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-182),
                UpdatedAt = DateTime.Now.AddDays(-182),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 204,
                Name = "Xe tải Hino FG tải 8 tấn thùng dài",
                Description = "Tình trạng Mới Năm sản xuất 2020 Kiểu dáng Truck Xuất xứ Lắp ráp Hộp số Số tay Địa chỉ rao bán Tp.HCM",
                ClientId = 204,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-181),
                UpdatedAt = DateTime.Now.AddDays(-181),
            });
            context.Products.AddOrUpdate(new Product()
            {
                Id = 205,
                Name = "Kia Cerato 2.0AT",
                Description = "Tình trạng Đã qua sử dụng Số km đã đi 12.000 km Năm sản xuất 2019 Kiểu dáng Sedan Hộp số Số tự động Địa chỉ rao bán Tp.HCM",
                ClientId = 205,
                Status = ProductService.Active,
                CreatedAt = DateTime.Now.AddDays(-180),
                UpdatedAt = DateTime.Now.AddDays(-180),
            });
            context.SaveChanges();
            //____________________Payment______________________
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 1,
                TotalCost = 21276000,
                ClientId = 82,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-20),
                UpdatedAt = DateTime.Now.AddDays(-20),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 2,
                TotalCost = 15262500,
                ClientId = 44,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-37),
                UpdatedAt = DateTime.Now.AddDays(-37),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 3,
                TotalCost = 67863500,
                ClientId = 66,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-36),
                UpdatedAt = DateTime.Now.AddDays(-36),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 4,
                TotalCost = 66291500,
                ClientId = 198,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-100),
                UpdatedAt = DateTime.Now.AddDays(-100),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 5,
                TotalCost = 34116000,
                ClientId = 166,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-88),
                UpdatedAt = DateTime.Now.AddDays(-88),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 6,
                TotalCost = 40866000,
                ClientId = 172,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-85),
                UpdatedAt = DateTime.Now.AddDays(-85),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 7,
                TotalCost = 46926000,
                ClientId = 87,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-184),
                UpdatedAt = DateTime.Now.AddDays(-184),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 8,
                TotalCost = 25416000,
                ClientId = 46,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-97),
                UpdatedAt = DateTime.Now.AddDays(-97),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 9,
                TotalCost = 34450500,
                ClientId = 198,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-28),
                UpdatedAt = DateTime.Now.AddDays(-28),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 10,
                TotalCost = 48915000,
                ClientId = 99,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-191),
                UpdatedAt = DateTime.Now.AddDays(-191),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 11,
                TotalCost = 89595500,
                ClientId = 23,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-117),
                UpdatedAt = DateTime.Now.AddDays(-117),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 12,
                TotalCost = 58905000,
                ClientId = 78,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-8),
                UpdatedAt = DateTime.Now.AddDays(-8),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 13,
                TotalCost = 45018000,
                ClientId = 82,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-184),
                UpdatedAt = DateTime.Now.AddDays(-184),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 14,
                TotalCost = 64838000,
                ClientId = 102,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-50),
                UpdatedAt = DateTime.Now.AddDays(-50),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 15,
                TotalCost = 118349000,
                ClientId = 9,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-13),
                UpdatedAt = DateTime.Now.AddDays(-13),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 16,
                TotalCost = 50176500,
                ClientId = 46,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-172),
                UpdatedAt = DateTime.Now.AddDays(-172),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 17,
                TotalCost = 79682000,
                ClientId = 59,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-69),
                UpdatedAt = DateTime.Now.AddDays(-69),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 18,
                TotalCost = 48609000,
                ClientId = 40,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-169),
                UpdatedAt = DateTime.Now.AddDays(-169),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 19,
                TotalCost = 3300000,
                ClientId = 92,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-151),
                UpdatedAt = DateTime.Now.AddDays(-151),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 20,
                TotalCost = 35994000,
                ClientId = 141,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-166),
                UpdatedAt = DateTime.Now.AddDays(-166),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 21,
                TotalCost = 58248000,
                ClientId = 135,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-36),
                UpdatedAt = DateTime.Now.AddDays(-36),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 22,
                TotalCost = 40382000,
                ClientId = 54,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-109),
                UpdatedAt = DateTime.Now.AddDays(-109),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 23,
                TotalCost = 35748000,
                ClientId = 19,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-116),
                UpdatedAt = DateTime.Now.AddDays(-116),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 24,
                TotalCost = 119418000,
                ClientId = 15,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-129),
                UpdatedAt = DateTime.Now.AddDays(-129),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 25,
                TotalCost = 124421000,
                ClientId = 183,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-176),
                UpdatedAt = DateTime.Now.AddDays(-176),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 26,
                TotalCost = 12426000,
                ClientId = 194,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-178),
                UpdatedAt = DateTime.Now.AddDays(-178),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 27,
                TotalCost = 123065500,
                ClientId = 173,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-100),
                UpdatedAt = DateTime.Now.AddDays(-100),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 28,
                TotalCost = 105742000,
                ClientId = 179,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-160),
                UpdatedAt = DateTime.Now.AddDays(-160),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 29,
                TotalCost = 211167000,
                ClientId = 168,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-107),
                UpdatedAt = DateTime.Now.AddDays(-107),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 30,
                TotalCost = 129858000,
                ClientId = 17,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-182),
                UpdatedAt = DateTime.Now.AddDays(-182),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 31,
                TotalCost = 47107500,
                ClientId = 101,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-48),
                UpdatedAt = DateTime.Now.AddDays(-48),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 32,
                TotalCost = 73980000,
                ClientId = 63,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-116),
                UpdatedAt = DateTime.Now.AddDays(-116),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 33,
                TotalCost = 115286000,
                ClientId = 163,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-54),
                UpdatedAt = DateTime.Now.AddDays(-54),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 34,
                TotalCost = 18675000,
                ClientId = 33,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-92),
                UpdatedAt = DateTime.Now.AddDays(-92),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 35,
                TotalCost = 5940000,
                ClientId = 145,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-176),
                UpdatedAt = DateTime.Now.AddDays(-176),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 36,
                TotalCost = 33600000,
                ClientId = 39,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-70),
                UpdatedAt = DateTime.Now.AddDays(-70),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 37,
                TotalCost = 48324000,
                ClientId = 75,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-8),
                UpdatedAt = DateTime.Now.AddDays(-8),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 38,
                TotalCost = 61347000,
                ClientId = 145,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-23),
                UpdatedAt = DateTime.Now.AddDays(-23),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 39,
                TotalCost = 65101500,
                ClientId = 113,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-64),
                UpdatedAt = DateTime.Now.AddDays(-64),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 40,
                TotalCost = 19409500,
                ClientId = 177,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-171),
                UpdatedAt = DateTime.Now.AddDays(-171),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 41,
                TotalCost = 5294000,
                ClientId = 67,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-185),
                UpdatedAt = DateTime.Now.AddDays(-185),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 42,
                TotalCost = 61402000,
                ClientId = 77,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-27),
                UpdatedAt = DateTime.Now.AddDays(-27),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 43,
                TotalCost = 81202500,
                ClientId = 7,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-132),
                UpdatedAt = DateTime.Now.AddDays(-132),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 44,
                TotalCost = 40639500,
                ClientId = 144,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-91),
                UpdatedAt = DateTime.Now.AddDays(-91),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 45,
                TotalCost = 34984500,
                ClientId = 96,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-51),
                UpdatedAt = DateTime.Now.AddDays(-51),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 46,
                TotalCost = 7767000,
                ClientId = 11,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-100),
                UpdatedAt = DateTime.Now.AddDays(-100),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 47,
                TotalCost = 53208000,
                ClientId = 41,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-106),
                UpdatedAt = DateTime.Now.AddDays(-106),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 48,
                TotalCost = 6538500,
                ClientId = 113,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-163),
                UpdatedAt = DateTime.Now.AddDays(-163),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 49,
                TotalCost = 95244000,
                ClientId = 48,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-187),
                UpdatedAt = DateTime.Now.AddDays(-187),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 50,
                TotalCost = 18193500,
                ClientId = 136,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-20),
                UpdatedAt = DateTime.Now.AddDays(-20),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 51,
                TotalCost = 32532000,
                ClientId = 66,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-99),
                UpdatedAt = DateTime.Now.AddDays(-99),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 52,
                TotalCost = 51199500,
                ClientId = 186,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-55),
                UpdatedAt = DateTime.Now.AddDays(-55),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 53,
                TotalCost = 69828000,
                ClientId = 182,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-119),
                UpdatedAt = DateTime.Now.AddDays(-119),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 54,
                TotalCost = 86476500,
                ClientId = 47,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-103),
                UpdatedAt = DateTime.Now.AddDays(-103),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 55,
                TotalCost = 83655000,
                ClientId = 143,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-191),
                UpdatedAt = DateTime.Now.AddDays(-191),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 56,
                TotalCost = 30630000,
                ClientId = 106,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-82),
                UpdatedAt = DateTime.Now.AddDays(-82),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 57,
                TotalCost = 26692000,
                ClientId = 84,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-145),
                UpdatedAt = DateTime.Now.AddDays(-145),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 58,
                TotalCost = 45684000,
                ClientId = 172,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-82),
                UpdatedAt = DateTime.Now.AddDays(-82),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 59,
                TotalCost = 100760000,
                ClientId = 66,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-158),
                UpdatedAt = DateTime.Now.AddDays(-158),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 60,
                TotalCost = 86827500,
                ClientId = 65,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-122),
                UpdatedAt = DateTime.Now.AddDays(-122),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 61,
                TotalCost = 115111000,
                ClientId = 126,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-193),
                UpdatedAt = DateTime.Now.AddDays(-193),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 62,
                TotalCost = 29200500,
                ClientId = 72,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-178),
                UpdatedAt = DateTime.Now.AddDays(-178),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 63,
                TotalCost = 104445000,
                ClientId = 91,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-162),
                UpdatedAt = DateTime.Now.AddDays(-162),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 64,
                TotalCost = 23736000,
                ClientId = 70,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-188),
                UpdatedAt = DateTime.Now.AddDays(-188),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 65,
                TotalCost = 9678000,
                ClientId = 132,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-168),
                UpdatedAt = DateTime.Now.AddDays(-168),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 66,
                TotalCost = 149904000,
                ClientId = 107,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-135),
                UpdatedAt = DateTime.Now.AddDays(-135),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 67,
                TotalCost = 13410000,
                ClientId = 164,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-102),
                UpdatedAt = DateTime.Now.AddDays(-102),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 68,
                TotalCost = 93666000,
                ClientId = 188,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-27),
                UpdatedAt = DateTime.Now.AddDays(-27),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 69,
                TotalCost = 13569000,
                ClientId = 163,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-128),
                UpdatedAt = DateTime.Now.AddDays(-128),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 70,
                TotalCost = 55749000,
                ClientId = 193,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-173),
                UpdatedAt = DateTime.Now.AddDays(-173),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 71,
                TotalCost = 107342500,
                ClientId = 5,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-61),
                UpdatedAt = DateTime.Now.AddDays(-61),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 72,
                TotalCost = 74964500,
                ClientId = 20,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-156),
                UpdatedAt = DateTime.Now.AddDays(-156),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 73,
                TotalCost = 82950000,
                ClientId = 198,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-20),
                UpdatedAt = DateTime.Now.AddDays(-20),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 74,
                TotalCost = 35700000,
                ClientId = 55,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-128),
                UpdatedAt = DateTime.Now.AddDays(-128),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 75,
                TotalCost = 107973000,
                ClientId = 47,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-59),
                UpdatedAt = DateTime.Now.AddDays(-59),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 76,
                TotalCost = 67865000,
                ClientId = 32,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-74),
                UpdatedAt = DateTime.Now.AddDays(-74),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 77,
                TotalCost = 61830000,
                ClientId = 144,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-122),
                UpdatedAt = DateTime.Now.AddDays(-122),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 78,
                TotalCost = 89851500,
                ClientId = 194,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-62),
                UpdatedAt = DateTime.Now.AddDays(-62),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 79,
                TotalCost = 44394000,
                ClientId = 81,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-66),
                UpdatedAt = DateTime.Now.AddDays(-66),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 80,
                TotalCost = 78074000,
                ClientId = 195,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-9),
                UpdatedAt = DateTime.Now.AddDays(-9),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 81,
                TotalCost = 124632000,
                ClientId = 37,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-70),
                UpdatedAt = DateTime.Now.AddDays(-70),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 82,
                TotalCost = 25182000,
                ClientId = 84,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-34),
                UpdatedAt = DateTime.Now.AddDays(-34),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 83,
                TotalCost = 101832000,
                ClientId = 101,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-151),
                UpdatedAt = DateTime.Now.AddDays(-151),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 84,
                TotalCost = 92543000,
                ClientId = 54,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-109),
                UpdatedAt = DateTime.Now.AddDays(-109),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 85,
                TotalCost = 181062000,
                ClientId = 176,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-47),
                UpdatedAt = DateTime.Now.AddDays(-47),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 86,
                TotalCost = 22363000,
                ClientId = 104,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-123),
                UpdatedAt = DateTime.Now.AddDays(-123),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 87,
                TotalCost = 67980000,
                ClientId = 117,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-79),
                UpdatedAt = DateTime.Now.AddDays(-79),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 88,
                TotalCost = 64552500,
                ClientId = 185,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-52),
                UpdatedAt = DateTime.Now.AddDays(-52),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 89,
                TotalCost = 39413000,
                ClientId = 158,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-180),
                UpdatedAt = DateTime.Now.AddDays(-180),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 90,
                TotalCost = 87044000,
                ClientId = 21,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-25),
                UpdatedAt = DateTime.Now.AddDays(-25),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 91,
                TotalCost = 4471500,
                ClientId = 114,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-43),
                UpdatedAt = DateTime.Now.AddDays(-43),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 92,
                TotalCost = 40788000,
                ClientId = 60,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-43),
                UpdatedAt = DateTime.Now.AddDays(-43),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 93,
                TotalCost = 12024000,
                ClientId = 33,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-55),
                UpdatedAt = DateTime.Now.AddDays(-55),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 94,
                TotalCost = 21169500,
                ClientId = 49,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-173),
                UpdatedAt = DateTime.Now.AddDays(-173),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 95,
                TotalCost = 75858000,
                ClientId = 31,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-38),
                UpdatedAt = DateTime.Now.AddDays(-38),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 96,
                TotalCost = 80826000,
                ClientId = 171,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-80),
                UpdatedAt = DateTime.Now.AddDays(-80),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 97,
                TotalCost = 91432000,
                ClientId = 67,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-122),
                UpdatedAt = DateTime.Now.AddDays(-122),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 98,
                TotalCost = 91608000,
                ClientId = 174,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-150),
                UpdatedAt = DateTime.Now.AddDays(-150),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 99,
                TotalCost = 16758500,
                ClientId = 36,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-32),
                UpdatedAt = DateTime.Now.AddDays(-32),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 100,
                TotalCost = 16143000,
                ClientId = 140,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-95),
                UpdatedAt = DateTime.Now.AddDays(-95),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 101,
                TotalCost = 188529000,
                ClientId = 34,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-37),
                UpdatedAt = DateTime.Now.AddDays(-37),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 102,
                TotalCost = 95887500,
                ClientId = 84,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-92),
                UpdatedAt = DateTime.Now.AddDays(-92),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 103,
                TotalCost = 31083000,
                ClientId = 74,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-78),
                UpdatedAt = DateTime.Now.AddDays(-78),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 104,
                TotalCost = 85536000,
                ClientId = 169,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-94),
                UpdatedAt = DateTime.Now.AddDays(-94),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 105,
                TotalCost = 81660000,
                ClientId = 9,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-44),
                UpdatedAt = DateTime.Now.AddDays(-44),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 106,
                TotalCost = 11320000,
                ClientId = 97,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-185),
                UpdatedAt = DateTime.Now.AddDays(-185),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 107,
                TotalCost = 13255000,
                ClientId = 69,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-115),
                UpdatedAt = DateTime.Now.AddDays(-115),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 108,
                TotalCost = 57720000,
                ClientId = 48,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-73),
                UpdatedAt = DateTime.Now.AddDays(-73),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 109,
                TotalCost = 23604000,
                ClientId = 95,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-172),
                UpdatedAt = DateTime.Now.AddDays(-172),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 110,
                TotalCost = 23626500,
                ClientId = 111,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-183),
                UpdatedAt = DateTime.Now.AddDays(-183),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 111,
                TotalCost = 77528000,
                ClientId = 37,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-55),
                UpdatedAt = DateTime.Now.AddDays(-55),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 112,
                TotalCost = 73590000,
                ClientId = 182,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-108),
                UpdatedAt = DateTime.Now.AddDays(-108),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 113,
                TotalCost = 71652500,
                ClientId = 149,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-152),
                UpdatedAt = DateTime.Now.AddDays(-152),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 114,
                TotalCost = 75912000,
                ClientId = 86,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-140),
                UpdatedAt = DateTime.Now.AddDays(-140),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 115,
                TotalCost = 43483000,
                ClientId = 16,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-190),
                UpdatedAt = DateTime.Now.AddDays(-190),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 116,
                TotalCost = 132357500,
                ClientId = 147,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-110),
                UpdatedAt = DateTime.Now.AddDays(-110),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 117,
                TotalCost = 36981000,
                ClientId = 47,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-142),
                UpdatedAt = DateTime.Now.AddDays(-142),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 118,
                TotalCost = 36045000,
                ClientId = 174,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-118),
                UpdatedAt = DateTime.Now.AddDays(-118),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 119,
                TotalCost = 21004500,
                ClientId = 153,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-87),
                UpdatedAt = DateTime.Now.AddDays(-87),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 120,
                TotalCost = 18936000,
                ClientId = 154,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-104),
                UpdatedAt = DateTime.Now.AddDays(-104),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 121,
                TotalCost = 142219000,
                ClientId = 54,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-58),
                UpdatedAt = DateTime.Now.AddDays(-58),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 122,
                TotalCost = 129639500,
                ClientId = 102,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-176),
                UpdatedAt = DateTime.Now.AddDays(-176),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 123,
                TotalCost = 112275000,
                ClientId = 163,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-178),
                UpdatedAt = DateTime.Now.AddDays(-178),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 124,
                TotalCost = 50188500,
                ClientId = 7,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-60),
                UpdatedAt = DateTime.Now.AddDays(-60),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 125,
                TotalCost = 19316000,
                ClientId = 124,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-190),
                UpdatedAt = DateTime.Now.AddDays(-190),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 126,
                TotalCost = 42840000,
                ClientId = 37,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-35),
                UpdatedAt = DateTime.Now.AddDays(-35),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 127,
                TotalCost = 110397000,
                ClientId = 194,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-63),
                UpdatedAt = DateTime.Now.AddDays(-63),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 128,
                TotalCost = 290059500,
                ClientId = 43,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-41),
                UpdatedAt = DateTime.Now.AddDays(-41),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 129,
                TotalCost = 141960000,
                ClientId = 12,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-40),
                UpdatedAt = DateTime.Now.AddDays(-40),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 130,
                TotalCost = 105811000,
                ClientId = 28,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-14),
                UpdatedAt = DateTime.Now.AddDays(-14),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 131,
                TotalCost = 164980500,
                ClientId = 14,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-120),
                UpdatedAt = DateTime.Now.AddDays(-120),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 132,
                TotalCost = 44826000,
                ClientId = 161,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-152),
                UpdatedAt = DateTime.Now.AddDays(-152),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 133,
                TotalCost = 29432500,
                ClientId = 121,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-88),
                UpdatedAt = DateTime.Now.AddDays(-88),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 134,
                TotalCost = 41614500,
                ClientId = 150,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-28),
                UpdatedAt = DateTime.Now.AddDays(-28),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 135,
                TotalCost = 24382500,
                ClientId = 62,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-175),
                UpdatedAt = DateTime.Now.AddDays(-175),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 136,
                TotalCost = 9004500,
                ClientId = 88,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-24),
                UpdatedAt = DateTime.Now.AddDays(-24),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 137,
                TotalCost = 79251000,
                ClientId = 58,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-48),
                UpdatedAt = DateTime.Now.AddDays(-48),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 138,
                TotalCost = 204864000,
                ClientId = 161,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-72),
                UpdatedAt = DateTime.Now.AddDays(-72),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 139,
                TotalCost = 63003000,
                ClientId = 165,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-183),
                UpdatedAt = DateTime.Now.AddDays(-183),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 140,
                TotalCost = 39295500,
                ClientId = 121,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-103),
                UpdatedAt = DateTime.Now.AddDays(-103),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 141,
                TotalCost = 36327500,
                ClientId = 125,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-142),
                UpdatedAt = DateTime.Now.AddDays(-142),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 142,
                TotalCost = 34386000,
                ClientId = 86,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-53),
                UpdatedAt = DateTime.Now.AddDays(-53),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 143,
                TotalCost = 156231000,
                ClientId = 175,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-35),
                UpdatedAt = DateTime.Now.AddDays(-35),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 144,
                TotalCost = 97226000,
                ClientId = 187,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-130),
                UpdatedAt = DateTime.Now.AddDays(-130),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 145,
                TotalCost = 78163000,
                ClientId = 26,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-31),
                UpdatedAt = DateTime.Now.AddDays(-31),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 146,
                TotalCost = 99823500,
                ClientId = 34,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-164),
                UpdatedAt = DateTime.Now.AddDays(-164),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 147,
                TotalCost = 81009500,
                ClientId = 24,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-81),
                UpdatedAt = DateTime.Now.AddDays(-81),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 148,
                TotalCost = 17505500,
                ClientId = 146,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-81),
                UpdatedAt = DateTime.Now.AddDays(-81),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 149,
                TotalCost = 56017500,
                ClientId = 107,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-89),
                UpdatedAt = DateTime.Now.AddDays(-89),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 150,
                TotalCost = 80277000,
                ClientId = 174,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-152),
                UpdatedAt = DateTime.Now.AddDays(-152),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 151,
                TotalCost = 4594500,
                ClientId = 147,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-154),
                UpdatedAt = DateTime.Now.AddDays(-154),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 152,
                TotalCost = 36120000,
                ClientId = 91,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-10),
                UpdatedAt = DateTime.Now.AddDays(-10),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 153,
                TotalCost = 106356000,
                ClientId = 115,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-139),
                UpdatedAt = DateTime.Now.AddDays(-139),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 154,
                TotalCost = 46794000,
                ClientId = 68,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-117),
                UpdatedAt = DateTime.Now.AddDays(-117),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 155,
                TotalCost = 18450000,
                ClientId = 78,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-127),
                UpdatedAt = DateTime.Now.AddDays(-127),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 156,
                TotalCost = 105039000,
                ClientId = 72,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-118),
                UpdatedAt = DateTime.Now.AddDays(-118),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 157,
                TotalCost = 53020000,
                ClientId = 92,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-52),
                UpdatedAt = DateTime.Now.AddDays(-52),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 158,
                TotalCost = 17217000,
                ClientId = 198,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-134),
                UpdatedAt = DateTime.Now.AddDays(-134),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 159,
                TotalCost = 67265000,
                ClientId = 63,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-88),
                UpdatedAt = DateTime.Now.AddDays(-88),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 160,
                TotalCost = 9948000,
                ClientId = 90,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-82),
                UpdatedAt = DateTime.Now.AddDays(-82),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 161,
                TotalCost = 86052000,
                ClientId = 83,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-127),
                UpdatedAt = DateTime.Now.AddDays(-127),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 162,
                TotalCost = 24500500,
                ClientId = 160,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-82),
                UpdatedAt = DateTime.Now.AddDays(-82),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 163,
                TotalCost = 14004000,
                ClientId = 199,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-162),
                UpdatedAt = DateTime.Now.AddDays(-162),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 164,
                TotalCost = 56035500,
                ClientId = 93,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-28),
                UpdatedAt = DateTime.Now.AddDays(-28),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 165,
                TotalCost = 48031500,
                ClientId = 194,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-151),
                UpdatedAt = DateTime.Now.AddDays(-151),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 166,
                TotalCost = 87975000,
                ClientId = 94,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-151),
                UpdatedAt = DateTime.Now.AddDays(-151),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 167,
                TotalCost = 47322000,
                ClientId = 45,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-99),
                UpdatedAt = DateTime.Now.AddDays(-99),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 168,
                TotalCost = 18930000,
                ClientId = 118,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-180),
                UpdatedAt = DateTime.Now.AddDays(-180),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 169,
                TotalCost = 138405500,
                ClientId = 152,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-170),
                UpdatedAt = DateTime.Now.AddDays(-170),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 170,
                TotalCost = 95922000,
                ClientId = 100,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-48),
                UpdatedAt = DateTime.Now.AddDays(-48),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 171,
                TotalCost = 81720000,
                ClientId = 102,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-111),
                UpdatedAt = DateTime.Now.AddDays(-111),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 172,
                TotalCost = 135169500,
                ClientId = 7,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-89),
                UpdatedAt = DateTime.Now.AddDays(-89),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 173,
                TotalCost = 71958000,
                ClientId = 22,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-40),
                UpdatedAt = DateTime.Now.AddDays(-40),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 174,
                TotalCost = 55572000,
                ClientId = 116,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-148),
                UpdatedAt = DateTime.Now.AddDays(-148),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 175,
                TotalCost = 69021000,
                ClientId = 22,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-61),
                UpdatedAt = DateTime.Now.AddDays(-61),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 176,
                TotalCost = 124896000,
                ClientId = 157,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-184),
                UpdatedAt = DateTime.Now.AddDays(-184),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 177,
                TotalCost = 58316500,
                ClientId = 135,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-110),
                UpdatedAt = DateTime.Now.AddDays(-110),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 178,
                TotalCost = 140832000,
                ClientId = 119,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-26),
                UpdatedAt = DateTime.Now.AddDays(-26),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 179,
                TotalCost = 16059000,
                ClientId = 41,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-159),
                UpdatedAt = DateTime.Now.AddDays(-159),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 180,
                TotalCost = 23779500,
                ClientId = 9,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-96),
                UpdatedAt = DateTime.Now.AddDays(-96),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 181,
                TotalCost = 56067000,
                ClientId = 158,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-12),
                UpdatedAt = DateTime.Now.AddDays(-12),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 182,
                TotalCost = 44886000,
                ClientId = 194,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-21),
                UpdatedAt = DateTime.Now.AddDays(-21),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 183,
                TotalCost = 97038000,
                ClientId = 184,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-148),
                UpdatedAt = DateTime.Now.AddDays(-148),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 184,
                TotalCost = 56410000,
                ClientId = 55,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-32),
                UpdatedAt = DateTime.Now.AddDays(-32),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 185,
                TotalCost = 118248000,
                ClientId = 89,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-124),
                UpdatedAt = DateTime.Now.AddDays(-124),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 186,
                TotalCost = 24490500,
                ClientId = 75,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-11),
                UpdatedAt = DateTime.Now.AddDays(-11),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 187,
                TotalCost = 102933000,
                ClientId = 53,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-46),
                UpdatedAt = DateTime.Now.AddDays(-46),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 188,
                TotalCost = 24696000,
                ClientId = 155,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-167),
                UpdatedAt = DateTime.Now.AddDays(-167),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 189,
                TotalCost = 82839000,
                ClientId = 196,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-88),
                UpdatedAt = DateTime.Now.AddDays(-88),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 190,
                TotalCost = 46686500,
                ClientId = 166,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-189),
                UpdatedAt = DateTime.Now.AddDays(-189),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 191,
                TotalCost = 3216000,
                ClientId = 35,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-112),
                UpdatedAt = DateTime.Now.AddDays(-112),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 192,
                TotalCost = 11912000,
                ClientId = 48,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-170),
                UpdatedAt = DateTime.Now.AddDays(-170),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 193,
                TotalCost = 156624000,
                ClientId = 175,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-192),
                UpdatedAt = DateTime.Now.AddDays(-192),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 194,
                TotalCost = 175047000,
                ClientId = 165,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-32),
                UpdatedAt = DateTime.Now.AddDays(-32),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 195,
                TotalCost = 81137500,
                ClientId = 45,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-91),
                UpdatedAt = DateTime.Now.AddDays(-91),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 196,
                TotalCost = 40224000,
                ClientId = 164,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-93),
                UpdatedAt = DateTime.Now.AddDays(-93),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 197,
                TotalCost = 76113000,
                ClientId = 61,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-94),
                UpdatedAt = DateTime.Now.AddDays(-94),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 198,
                TotalCost = 72068000,
                ClientId = 197,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-175),
                UpdatedAt = DateTime.Now.AddDays(-175),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 199,
                TotalCost = 19290000,
                ClientId = 142,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-154),
                UpdatedAt = DateTime.Now.AddDays(-154),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 200,
                TotalCost = 86800500,
                ClientId = 86,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-32),
                UpdatedAt = DateTime.Now.AddDays(-32),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 201,
                TotalCost = 116982000,
                ClientId = 52,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-33),
                UpdatedAt = DateTime.Now.AddDays(-33),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 202,
                TotalCost = 13560000,
                ClientId = 70,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-179),
                UpdatedAt = DateTime.Now.AddDays(-179),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 203,
                TotalCost = 28318500,
                ClientId = 27,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-194),
                UpdatedAt = DateTime.Now.AddDays(-194),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 204,
                TotalCost = 47928000,
                ClientId = 98,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-56),
                UpdatedAt = DateTime.Now.AddDays(-56),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 205,
                TotalCost = 101244000,
                ClientId = 92,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-50),
                UpdatedAt = DateTime.Now.AddDays(-50),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 206,
                TotalCost = 60291000,
                ClientId = 78,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-106),
                UpdatedAt = DateTime.Now.AddDays(-106),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 207,
                TotalCost = 21612000,
                ClientId = 74,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-197),
                UpdatedAt = DateTime.Now.AddDays(-197),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 208,
                TotalCost = 75210000,
                ClientId = 69,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-51),
                UpdatedAt = DateTime.Now.AddDays(-51),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 209,
                TotalCost = 30315500,
                ClientId = 75,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-162),
                UpdatedAt = DateTime.Now.AddDays(-162),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 210,
                TotalCost = 178932000,
                ClientId = 37,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-132),
                UpdatedAt = DateTime.Now.AddDays(-132),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 211,
                TotalCost = 155003000,
                ClientId = 187,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-174),
                UpdatedAt = DateTime.Now.AddDays(-174),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 212,
                TotalCost = 9837000,
                ClientId = 182,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-97),
                UpdatedAt = DateTime.Now.AddDays(-97),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 213,
                TotalCost = 67881000,
                ClientId = 195,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-183),
                UpdatedAt = DateTime.Now.AddDays(-183),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 214,
                TotalCost = 19020000,
                ClientId = 109,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-33),
                UpdatedAt = DateTime.Now.AddDays(-33),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 215,
                TotalCost = 45189000,
                ClientId = 43,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-160),
                UpdatedAt = DateTime.Now.AddDays(-160),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 216,
                TotalCost = 54816000,
                ClientId = 91,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-154),
                UpdatedAt = DateTime.Now.AddDays(-154),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 217,
                TotalCost = 12322000,
                ClientId = 29,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-117),
                UpdatedAt = DateTime.Now.AddDays(-117),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 218,
                TotalCost = 54381000,
                ClientId = 183,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-25),
                UpdatedAt = DateTime.Now.AddDays(-25),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 219,
                TotalCost = 21103500,
                ClientId = 115,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-11),
                UpdatedAt = DateTime.Now.AddDays(-11),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 220,
                TotalCost = 123696500,
                ClientId = 91,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-169),
                UpdatedAt = DateTime.Now.AddDays(-169),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 221,
                TotalCost = 86834000,
                ClientId = 165,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-99),
                UpdatedAt = DateTime.Now.AddDays(-99),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 222,
                TotalCost = 15066000,
                ClientId = 62,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-46),
                UpdatedAt = DateTime.Now.AddDays(-46),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 223,
                TotalCost = 78500000,
                ClientId = 131,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-188),
                UpdatedAt = DateTime.Now.AddDays(-188),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 224,
                TotalCost = 6489500,
                ClientId = 192,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-45),
                UpdatedAt = DateTime.Now.AddDays(-45),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 225,
                TotalCost = 99558000,
                ClientId = 67,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-137),
                UpdatedAt = DateTime.Now.AddDays(-137),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 226,
                TotalCost = 59770000,
                ClientId = 142,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-36),
                UpdatedAt = DateTime.Now.AddDays(-36),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 227,
                TotalCost = 75313000,
                ClientId = 66,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-80),
                UpdatedAt = DateTime.Now.AddDays(-80),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 228,
                TotalCost = 55294000,
                ClientId = 189,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-101),
                UpdatedAt = DateTime.Now.AddDays(-101),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 229,
                TotalCost = 91659500,
                ClientId = 81,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-89),
                UpdatedAt = DateTime.Now.AddDays(-89),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 230,
                TotalCost = 14584500,
                ClientId = 125,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-134),
                UpdatedAt = DateTime.Now.AddDays(-134),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 231,
                TotalCost = 27071000,
                ClientId = 18,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-147),
                UpdatedAt = DateTime.Now.AddDays(-147),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 232,
                TotalCost = 123158500,
                ClientId = 109,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-28),
                UpdatedAt = DateTime.Now.AddDays(-28),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 233,
                TotalCost = 10769000,
                ClientId = 181,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-8),
                UpdatedAt = DateTime.Now.AddDays(-8),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 234,
                TotalCost = 5995500,
                ClientId = 140,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-156),
                UpdatedAt = DateTime.Now.AddDays(-156),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 235,
                TotalCost = 149781500,
                ClientId = 172,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-126),
                UpdatedAt = DateTime.Now.AddDays(-126),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 236,
                TotalCost = 36984000,
                ClientId = 29,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-145),
                UpdatedAt = DateTime.Now.AddDays(-145),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 237,
                TotalCost = 55937500,
                ClientId = 65,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-53),
                UpdatedAt = DateTime.Now.AddDays(-53),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 238,
                TotalCost = 189378000,
                ClientId = 133,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-79),
                UpdatedAt = DateTime.Now.AddDays(-79),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 239,
                TotalCost = 24376500,
                ClientId = 100,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-31),
                UpdatedAt = DateTime.Now.AddDays(-31),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 240,
                TotalCost = 117405000,
                ClientId = 146,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-154),
                UpdatedAt = DateTime.Now.AddDays(-154),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 241,
                TotalCost = 36108000,
                ClientId = 81,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-195),
                UpdatedAt = DateTime.Now.AddDays(-195),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 242,
                TotalCost = 17028000,
                ClientId = 196,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-30),
                UpdatedAt = DateTime.Now.AddDays(-30),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 243,
                TotalCost = 92817000,
                ClientId = 96,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-166),
                UpdatedAt = DateTime.Now.AddDays(-166),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 244,
                TotalCost = 53614500,
                ClientId = 4,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-89),
                UpdatedAt = DateTime.Now.AddDays(-89),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 245,
                TotalCost = 9819000,
                ClientId = 115,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-164),
                UpdatedAt = DateTime.Now.AddDays(-164),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 246,
                TotalCost = 49342500,
                ClientId = 177,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-48),
                UpdatedAt = DateTime.Now.AddDays(-48),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 247,
                TotalCost = 68796000,
                ClientId = 104,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-28),
                UpdatedAt = DateTime.Now.AddDays(-28),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 248,
                TotalCost = 46051500,
                ClientId = 40,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-86),
                UpdatedAt = DateTime.Now.AddDays(-86),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 249,
                TotalCost = 2102000,
                ClientId = 2,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-150),
                UpdatedAt = DateTime.Now.AddDays(-150),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 250,
                TotalCost = 10449000,
                ClientId = 166,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-143),
                UpdatedAt = DateTime.Now.AddDays(-143),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 251,
                TotalCost = 16464000,
                ClientId = 30,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-127),
                UpdatedAt = DateTime.Now.AddDays(-127),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 252,
                TotalCost = 156550000,
                ClientId = 64,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-105),
                UpdatedAt = DateTime.Now.AddDays(-105),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 253,
                TotalCost = 15777000,
                ClientId = 107,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-117),
                UpdatedAt = DateTime.Now.AddDays(-117),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 254,
                TotalCost = 38692500,
                ClientId = 91,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-68),
                UpdatedAt = DateTime.Now.AddDays(-68),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 255,
                TotalCost = 12390000,
                ClientId = 98,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-145),
                UpdatedAt = DateTime.Now.AddDays(-145),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 256,
                TotalCost = 47025000,
                ClientId = 142,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-188),
                UpdatedAt = DateTime.Now.AddDays(-188),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 257,
                TotalCost = 28561500,
                ClientId = 128,
                EmployeeId = "7",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-59),
                UpdatedAt = DateTime.Now.AddDays(-59),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 258,
                TotalCost = 52922000,
                ClientId = 108,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-178),
                UpdatedAt = DateTime.Now.AddDays(-178),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 259,
                TotalCost = 25986000,
                ClientId = 143,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-60),
                UpdatedAt = DateTime.Now.AddDays(-60),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 260,
                TotalCost = 90342000,
                ClientId = 182,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-165),
                UpdatedAt = DateTime.Now.AddDays(-165),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 261,
                TotalCost = 151338000,
                ClientId = 65,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-127),
                UpdatedAt = DateTime.Now.AddDays(-127),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 262,
                TotalCost = 128940000,
                ClientId = 133,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-198),
                UpdatedAt = DateTime.Now.AddDays(-198),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 263,
                TotalCost = 28986000,
                ClientId = 196,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-70),
                UpdatedAt = DateTime.Now.AddDays(-70),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 264,
                TotalCost = 15147000,
                ClientId = 2,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-61),
                UpdatedAt = DateTime.Now.AddDays(-61),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 265,
                TotalCost = 25992000,
                ClientId = 129,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-154),
                UpdatedAt = DateTime.Now.AddDays(-154),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 266,
                TotalCost = 41370000,
                ClientId = 91,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-67),
                UpdatedAt = DateTime.Now.AddDays(-67),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 267,
                TotalCost = 76152000,
                ClientId = 165,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-60),
                UpdatedAt = DateTime.Now.AddDays(-60),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 268,
                TotalCost = 100386000,
                ClientId = 80,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-34),
                UpdatedAt = DateTime.Now.AddDays(-34),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 269,
                TotalCost = 37260000,
                ClientId = 200,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-114),
                UpdatedAt = DateTime.Now.AddDays(-114),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 270,
                TotalCost = 24570000,
                ClientId = 137,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-162),
                UpdatedAt = DateTime.Now.AddDays(-162),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 271,
                TotalCost = 6403500,
                ClientId = 52,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-138),
                UpdatedAt = DateTime.Now.AddDays(-138),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 272,
                TotalCost = 10407500,
                ClientId = 58,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-22),
                UpdatedAt = DateTime.Now.AddDays(-22),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 273,
                TotalCost = 165390000,
                ClientId = 133,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-179),
                UpdatedAt = DateTime.Now.AddDays(-179),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 274,
                TotalCost = 91791000,
                ClientId = 122,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-153),
                UpdatedAt = DateTime.Now.AddDays(-153),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 275,
                TotalCost = 278070000,
                ClientId = 21,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-179),
                UpdatedAt = DateTime.Now.AddDays(-179),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 276,
                TotalCost = 205792500,
                ClientId = 112,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-147),
                UpdatedAt = DateTime.Now.AddDays(-147),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 277,
                TotalCost = 5548500,
                ClientId = 21,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-64),
                UpdatedAt = DateTime.Now.AddDays(-64),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 278,
                TotalCost = 37890000,
                ClientId = 50,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-64),
                UpdatedAt = DateTime.Now.AddDays(-64),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 279,
                TotalCost = 107578500,
                ClientId = 55,
                EmployeeId = "4",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-20),
                UpdatedAt = DateTime.Now.AddDays(-20),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 280,
                TotalCost = 37962000,
                ClientId = 140,
                EmployeeId = "10",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-44),
                UpdatedAt = DateTime.Now.AddDays(-44),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 281,
                TotalCost = 41456000,
                ClientId = 199,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-95),
                UpdatedAt = DateTime.Now.AddDays(-95),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 282,
                TotalCost = 48438500,
                ClientId = 117,
                EmployeeId = "8",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-178),
                UpdatedAt = DateTime.Now.AddDays(-178),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 283,
                TotalCost = 41272500,
                ClientId = 11,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-46),
                UpdatedAt = DateTime.Now.AddDays(-46),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 284,
                TotalCost = 84360000,
                ClientId = 5,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-171),
                UpdatedAt = DateTime.Now.AddDays(-171),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 285,
                TotalCost = 36228000,
                ClientId = 13,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-123),
                UpdatedAt = DateTime.Now.AddDays(-123),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 286,
                TotalCost = 57259500,
                ClientId = 156,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-181),
                UpdatedAt = DateTime.Now.AddDays(-181),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 287,
                TotalCost = 27319500,
                ClientId = 118,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-72),
                UpdatedAt = DateTime.Now.AddDays(-72),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 288,
                TotalCost = 98556000,
                ClientId = 70,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-95),
                UpdatedAt = DateTime.Now.AddDays(-95),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 289,
                TotalCost = 23719500,
                ClientId = 24,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-162),
                UpdatedAt = DateTime.Now.AddDays(-162),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 290,
                TotalCost = 67162500,
                ClientId = 199,
                EmployeeId = "5",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-82),
                UpdatedAt = DateTime.Now.AddDays(-82),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 291,
                TotalCost = 40524000,
                ClientId = 28,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-22),
                UpdatedAt = DateTime.Now.AddDays(-22),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 292,
                TotalCost = 102120000,
                ClientId = 156,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-181),
                UpdatedAt = DateTime.Now.AddDays(-181),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 293,
                TotalCost = 16920000,
                ClientId = 186,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-124),
                UpdatedAt = DateTime.Now.AddDays(-124),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 294,
                TotalCost = 13860000,
                ClientId = 73,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-99),
                UpdatedAt = DateTime.Now.AddDays(-99),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 295,
                TotalCost = 19902000,
                ClientId = 157,
                EmployeeId = "1",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-9),
                UpdatedAt = DateTime.Now.AddDays(-9),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 296,
                TotalCost = 68634000,
                ClientId = 80,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-46),
                UpdatedAt = DateTime.Now.AddDays(-46),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 297,
                TotalCost = 18657000,
                ClientId = 161,
                EmployeeId = "2",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-130),
                UpdatedAt = DateTime.Now.AddDays(-130),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 298,
                TotalCost = 64248000,
                ClientId = 28,
                EmployeeId = "9",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-26),
                UpdatedAt = DateTime.Now.AddDays(-26),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 299,
                TotalCost = 157086000,
                ClientId = 129,
                EmployeeId = "3",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-138),
                UpdatedAt = DateTime.Now.AddDays(-138),
            });
            context.Payments.AddOrUpdate(new Payment()
            {
                Id = 300,
                TotalCost = 105182000,
                ClientId = 186,
                EmployeeId = "6",
                Status = PaymentStatus.Done,
                CreatedAt = DateTime.Now.AddDays(-103),
                UpdatedAt = DateTime.Now.AddDays(-103),
            });
            context.SaveChanges();
            //____________________PaymentDetail______________________
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 1,
                PaymentId = 1,
                ProductId = 145,
                ServiceId = 2,
                AmoutEmployee = 104,
                StartDate = DateTime.Now.AddDays(-20),
                EndDate = DateTime.Now.AddDays(-9),
                Cost = 8736000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-20),
                UpdatedAt = DateTime.Now.AddDays(-20),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 2,
                PaymentId = 1,
                ProductId = 22,
                ServiceId = 2,
                AmoutEmployee = 110,
                StartDate = DateTime.Now.AddDays(-37),
                EndDate = DateTime.Now.AddDays(-26),
                Cost = 12540000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-37),
                UpdatedAt = DateTime.Now.AddDays(-37),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 3,
                PaymentId = 2,
                ProductId = 102,
                ServiceId = 3,
                AmoutEmployee = 50,
                StartDate = DateTime.Now.AddDays(-36),
                EndDate = DateTime.Now.AddDays(-29),
                Cost = 8525000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-36),
                UpdatedAt = DateTime.Now.AddDays(-36),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 4,
                PaymentId = 2,
                ProductId = 91,
                ServiceId = 3,
                AmoutEmployee = 49,
                StartDate = DateTime.Now.AddDays(-100),
                EndDate = DateTime.Now.AddDays(-95),
                Cost = 6737500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-100),
                UpdatedAt = DateTime.Now.AddDays(-100),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 5,
                PaymentId = 3,
                ProductId = 191,
                ServiceId = 3,
                AmoutEmployee = 187,
                StartDate = DateTime.Now.AddDays(-88),
                EndDate = DateTime.Now.AddDays(-75),
                Cost = 60681500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-88),
                UpdatedAt = DateTime.Now.AddDays(-88),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 6,
                PaymentId = 3,
                ProductId = 10,
                ServiceId = 1,
                AmoutEmployee = 28,
                StartDate = DateTime.Now.AddDays(-85),
                EndDate = DateTime.Now.AddDays(-77),
                Cost = 7182000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-85),
                UpdatedAt = DateTime.Now.AddDays(-85),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 7,
                PaymentId = 4,
                ProductId = 18,
                ServiceId = 3,
                AmoutEmployee = 110,
                StartDate = DateTime.Now.AddDays(-184),
                EndDate = DateTime.Now.AddDays(-181),
                Cost = 51425000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-184),
                UpdatedAt = DateTime.Now.AddDays(-184),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 8,
                PaymentId = 4,
                ProductId = 142,
                ServiceId = 3,
                AmoutEmployee = 53,
                StartDate = DateTime.Now.AddDays(-97),
                EndDate = DateTime.Now.AddDays(-83),
                Cost = 14866500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-97),
                UpdatedAt = DateTime.Now.AddDays(-97),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 9,
                PaymentId = 5,
                ProductId = 55,
                ServiceId = 3,
                AmoutEmployee = 176,
                StartDate = DateTime.Now.AddDays(-28),
                EndDate = DateTime.Now.AddDays(-27),
                Cost = 11616000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-28),
                UpdatedAt = DateTime.Now.AddDays(-28),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 10,
                PaymentId = 5,
                ProductId = 43,
                ServiceId = 2,
                AmoutEmployee = 150,
                StartDate = DateTime.Now.AddDays(-191),
                EndDate = DateTime.Now.AddDays(-180),
                Cost = 22500000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-191),
                UpdatedAt = DateTime.Now.AddDays(-191),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 11,
                PaymentId = 6,
                ProductId = 155,
                ServiceId = 2,
                AmoutEmployee = 143,
                StartDate = DateTime.Now.AddDays(-117),
                EndDate = DateTime.Now.AddDays(-114),
                Cost = 38610000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-117),
                UpdatedAt = DateTime.Now.AddDays(-117),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 12,
                PaymentId = 6,
                ProductId = 14,
                ServiceId = 2,
                AmoutEmployee = 188,
                StartDate = DateTime.Now.AddDays(-8),
                EndDate = DateTime.Now.AddDays(2),
                Cost = 2256000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-8),
                UpdatedAt = DateTime.Now.AddDays(-8),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 13,
                PaymentId = 7,
                ProductId = 20,
                ServiceId = 2,
                AmoutEmployee = 44,
                StartDate = DateTime.Now.AddDays(-184),
                EndDate = DateTime.Now.AddDays(-177),
                Cost = 35376000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-184),
                UpdatedAt = DateTime.Now.AddDays(-184),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 14,
                PaymentId = 7,
                ProductId = 16,
                ServiceId = 3,
                AmoutEmployee = 70,
                StartDate = DateTime.Now.AddDays(-50),
                EndDate = DateTime.Now.AddDays(-40),
                Cost = 11550000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-50),
                UpdatedAt = DateTime.Now.AddDays(-50),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 15,
                PaymentId = 8,
                ProductId = 81,
                ServiceId = 2,
                AmoutEmployee = 103,
                StartDate = DateTime.Now.AddDays(-13),
                EndDate = DateTime.Now.AddDays(-7),
                Cost = 1854000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-13),
                UpdatedAt = DateTime.Now.AddDays(-13),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 16,
                PaymentId = 8,
                ProductId = 171,
                ServiceId = 1,
                AmoutEmployee = 34,
                StartDate = DateTime.Now.AddDays(-172),
                EndDate = DateTime.Now.AddDays(-167),
                Cost = 23562000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-172),
                UpdatedAt = DateTime.Now.AddDays(-172),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 17,
                PaymentId = 9,
                ProductId = 134,
                ServiceId = 1,
                AmoutEmployee = 115,
                StartDate = DateTime.Now.AddDays(-69),
                EndDate = DateTime.Now.AddDays(-68),
                Cost = 32602500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-69),
                UpdatedAt = DateTime.Now.AddDays(-69),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 18,
                PaymentId = 9,
                ProductId = 168,
                ServiceId = 3,
                AmoutEmployee = 28,
                StartDate = DateTime.Now.AddDays(-169),
                EndDate = DateTime.Now.AddDays(-158),
                Cost = 1848000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-169),
                UpdatedAt = DateTime.Now.AddDays(-169),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 19,
                PaymentId = 10,
                ProductId = 199,
                ServiceId = 1,
                AmoutEmployee = 65,
                StartDate = DateTime.Now.AddDays(-151),
                EndDate = DateTime.Now.AddDays(-143),
                Cost = 14040000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-151),
                UpdatedAt = DateTime.Now.AddDays(-151),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 20,
                PaymentId = 10,
                ProductId = 130,
                ServiceId = 1,
                AmoutEmployee = 50,
                StartDate = DateTime.Now.AddDays(-166),
                EndDate = DateTime.Now.AddDays(-163),
                Cost = 34875000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-166),
                UpdatedAt = DateTime.Now.AddDays(-166),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 21,
                PaymentId = 11,
                ProductId = 37,
                ServiceId = 3,
                AmoutEmployee = 31,
                StartDate = DateTime.Now.AddDays(-36),
                EndDate = DateTime.Now.AddDays(-34),
                Cost = 1875500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-36),
                UpdatedAt = DateTime.Now.AddDays(-36),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 22,
                PaymentId = 11,
                ProductId = 194,
                ServiceId = 2,
                AmoutEmployee = 170,
                StartDate = DateTime.Now.AddDays(-109),
                EndDate = DateTime.Now.AddDays(-97),
                Cost = 87720000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-109),
                UpdatedAt = DateTime.Now.AddDays(-109),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 23,
                PaymentId = 12,
                ProductId = 128,
                ServiceId = 3,
                AmoutEmployee = 112,
                StartDate = DateTime.Now.AddDays(-116),
                EndDate = DateTime.Now.AddDays(-102),
                Cost = 27720000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-116),
                UpdatedAt = DateTime.Now.AddDays(-116),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 24,
                PaymentId = 12,
                ProductId = 26,
                ServiceId = 3,
                AmoutEmployee = 105,
                StartDate = DateTime.Now.AddDays(-129),
                EndDate = DateTime.Now.AddDays(-115),
                Cost = 31185000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-129),
                UpdatedAt = DateTime.Now.AddDays(-129),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 25,
                PaymentId = 13,
                ProductId = 63,
                ServiceId = 1,
                AmoutEmployee = 196,
                StartDate = DateTime.Now.AddDays(-176),
                EndDate = DateTime.Now.AddDays(-171),
                Cost = 22050000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-176),
                UpdatedAt = DateTime.Now.AddDays(-176),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 26,
                PaymentId = 13,
                ProductId = 153,
                ServiceId = 3,
                AmoutEmployee = 174,
                StartDate = DateTime.Now.AddDays(-178),
                EndDate = DateTime.Now.AddDays(-164),
                Cost = 22968000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-178),
                UpdatedAt = DateTime.Now.AddDays(-178),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 27,
                PaymentId = 14,
                ProductId = 71,
                ServiceId = 1,
                AmoutEmployee = 115,
                StartDate = DateTime.Now.AddDays(-100),
                EndDate = DateTime.Now.AddDays(-94),
                Cost = 38295000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-100),
                UpdatedAt = DateTime.Now.AddDays(-100),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 28,
                PaymentId = 14,
                ProductId = 200,
                ServiceId = 3,
                AmoutEmployee = 38,
                StartDate = DateTime.Now.AddDays(-160),
                EndDate = DateTime.Now.AddDays(-153),
                Cost = 26543000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-160),
                UpdatedAt = DateTime.Now.AddDays(-160),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 29,
                PaymentId = 15,
                ProductId = 100,
                ServiceId = 3,
                AmoutEmployee = 181,
                StartDate = DateTime.Now.AddDays(-107),
                EndDate = DateTime.Now.AddDays(-100),
                Cost = 97559000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-107),
                UpdatedAt = DateTime.Now.AddDays(-107),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 30,
                PaymentId = 15,
                ProductId = 153,
                ServiceId = 1,
                AmoutEmployee = 28,
                StartDate = DateTime.Now.AddDays(-182),
                EndDate = DateTime.Now.AddDays(-180),
                Cost = 20790000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-182),
                UpdatedAt = DateTime.Now.AddDays(-182),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 31,
                PaymentId = 16,
                ProductId = 33,
                ServiceId = 3,
                AmoutEmployee = 158,
                StartDate = DateTime.Now.AddDays(-48),
                EndDate = DateTime.Now.AddDays(-44),
                Cost = 10428000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-48),
                UpdatedAt = DateTime.Now.AddDays(-48),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 32,
                PaymentId = 16,
                ProductId = 25,
                ServiceId = 1,
                AmoutEmployee = 121,
                StartDate = DateTime.Now.AddDays(-116),
                EndDate = DateTime.Now.AddDays(-114),
                Cost = 39748500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-116),
                UpdatedAt = DateTime.Now.AddDays(-116),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 33,
                PaymentId = 17,
                ProductId = 174,
                ServiceId = 2,
                AmoutEmployee = 191,
                StartDate = DateTime.Now.AddDays(-54),
                EndDate = DateTime.Now.AddDays(-42),
                Cost = 36672000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-54),
                UpdatedAt = DateTime.Now.AddDays(-54),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 34,
                PaymentId = 17,
                ProductId = 32,
                ServiceId = 3,
                AmoutEmployee = 92,
                StartDate = DateTime.Now.AddDays(-92),
                EndDate = DateTime.Now.AddDays(-78),
                Cost = 43010000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-92),
                UpdatedAt = DateTime.Now.AddDays(-92),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 35,
                PaymentId = 18,
                ProductId = 182,
                ServiceId = 3,
                AmoutEmployee = 67,
                StartDate = DateTime.Now.AddDays(-176),
                EndDate = DateTime.Now.AddDays(-164),
                Cost = 26163500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-176),
                UpdatedAt = DateTime.Now.AddDays(-176),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 36,
                PaymentId = 18,
                ProductId = 133,
                ServiceId = 3,
                AmoutEmployee = 77,
                StartDate = DateTime.Now.AddDays(-70),
                EndDate = DateTime.Now.AddDays(-65),
                Cost = 22445500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-70),
                UpdatedAt = DateTime.Now.AddDays(-70),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 37,
                PaymentId = 19,
                ProductId = 166,
                ServiceId = 3,
                AmoutEmployee = 36,
                StartDate = DateTime.Now.AddDays(-8),
                EndDate = DateTime.Now.AddDays(-5),
                Cost = 396000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-8),
                UpdatedAt = DateTime.Now.AddDays(-8),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 38,
                PaymentId = 19,
                ProductId = 83,
                ServiceId = 3,
                AmoutEmployee = 132,
                StartDate = DateTime.Now.AddDays(-23),
                EndDate = DateTime.Now.AddDays(-10),
                Cost = 2904000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-23),
                UpdatedAt = DateTime.Now.AddDays(-23),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 39,
                PaymentId = 20,
                ProductId = 70,
                ServiceId = 2,
                AmoutEmployee = 141,
                StartDate = DateTime.Now.AddDays(-64),
                EndDate = DateTime.Now.AddDays(-57),
                Cost = 32994000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-64),
                UpdatedAt = DateTime.Now.AddDays(-64),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 40,
                PaymentId = 20,
                ProductId = 156,
                ServiceId = 2,
                AmoutEmployee = 100,
                StartDate = DateTime.Now.AddDays(-171),
                EndDate = DateTime.Now.AddDays(-165),
                Cost = 3000000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-171),
                UpdatedAt = DateTime.Now.AddDays(-171),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 41,
                PaymentId = 21,
                ProductId = 157,
                ServiceId = 2,
                AmoutEmployee = 90,
                StartDate = DateTime.Now.AddDays(-185),
                EndDate = DateTime.Now.AddDays(-180),
                Cost = 55080000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-185),
                UpdatedAt = DateTime.Now.AddDays(-185),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 42,
                PaymentId = 21,
                ProductId = 6,
                ServiceId = 3,
                AmoutEmployee = 72,
                StartDate = DateTime.Now.AddDays(-27),
                EndDate = DateTime.Now.AddDays(-21),
                Cost = 3168000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-27),
                UpdatedAt = DateTime.Now.AddDays(-27),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 43,
                PaymentId = 22,
                ProductId = 83,
                ServiceId = 2,
                AmoutEmployee = 86,
                StartDate = DateTime.Now.AddDays(-132),
                EndDate = DateTime.Now.AddDays(-128),
                Cost = 16512000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-132),
                UpdatedAt = DateTime.Now.AddDays(-132),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 44,
                PaymentId = 22,
                ProductId = 117,
                ServiceId = 3,
                AmoutEmployee = 155,
                StartDate = DateTime.Now.AddDays(-91),
                EndDate = DateTime.Now.AddDays(-81),
                Cost = 23870000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-91),
                UpdatedAt = DateTime.Now.AddDays(-91),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 45,
                PaymentId = 23,
                ProductId = 122,
                ServiceId = 1,
                AmoutEmployee = 148,
                StartDate = DateTime.Now.AddDays(-51),
                EndDate = DateTime.Now.AddDays(-39),
                Cost = 21978000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-51),
                UpdatedAt = DateTime.Now.AddDays(-51),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 46,
                PaymentId = 23,
                ProductId = 44,
                ServiceId = 1,
                AmoutEmployee = 34,
                StartDate = DateTime.Now.AddDays(-100),
                EndDate = DateTime.Now.AddDays(-90),
                Cost = 13770000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-100),
                UpdatedAt = DateTime.Now.AddDays(-100),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 47,
                PaymentId = 24,
                ProductId = 113,
                ServiceId = 2,
                AmoutEmployee = 26,
                StartDate = DateTime.Now.AddDays(-106),
                EndDate = DateTime.Now.AddDays(-93),
                Cost = 8736000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-106),
                UpdatedAt = DateTime.Now.AddDays(-106),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 48,
                PaymentId = 24,
                ProductId = 75,
                ServiceId = 2,
                AmoutEmployee = 129,
                StartDate = DateTime.Now.AddDays(-163),
                EndDate = DateTime.Now.AddDays(-152),
                Cost = 110682000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-163),
                UpdatedAt = DateTime.Now.AddDays(-163),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 49,
                PaymentId = 25,
                ProductId = 27,
                ServiceId = 3,
                AmoutEmployee = 176,
                StartDate = DateTime.Now.AddDays(-187),
                EndDate = DateTime.Now.AddDays(-174),
                Cost = 122936000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-187),
                UpdatedAt = DateTime.Now.AddDays(-187),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 50,
                PaymentId = 25,
                ProductId = 100,
                ServiceId = 3,
                AmoutEmployee = 90,
                StartDate = DateTime.Now.AddDays(-20),
                EndDate = DateTime.Now.AddDays(-7),
                Cost = 1485000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-20),
                UpdatedAt = DateTime.Now.AddDays(-20),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 51,
                PaymentId = 26,
                ProductId = 134,
                ServiceId = 1,
                AmoutEmployee = 72,
                StartDate = DateTime.Now.AddDays(-99),
                EndDate = DateTime.Now.AddDays(-85),
                Cost = 5184000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-99),
                UpdatedAt = DateTime.Now.AddDays(-99),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 52,
                PaymentId = 26,
                ProductId = 194,
                ServiceId = 2,
                AmoutEmployee = 71,
                StartDate = DateTime.Now.AddDays(-55),
                EndDate = DateTime.Now.AddDays(-50),
                Cost = 7242000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-55),
                UpdatedAt = DateTime.Now.AddDays(-55),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 53,
                PaymentId = 27,
                ProductId = 190,
                ServiceId = 3,
                AmoutEmployee = 185,
                StartDate = DateTime.Now.AddDays(-119),
                EndDate = DateTime.Now.AddDays(-106),
                Cost = 90557500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-119),
                UpdatedAt = DateTime.Now.AddDays(-119),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 54,
                PaymentId = 27,
                ProductId = 87,
                ServiceId = 1,
                AmoutEmployee = 168,
                StartDate = DateTime.Now.AddDays(-103),
                EndDate = DateTime.Now.AddDays(-99),
                Cost = 32508000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-103),
                UpdatedAt = DateTime.Now.AddDays(-103),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 55,
                PaymentId = 28,
                ProductId = 172,
                ServiceId = 3,
                AmoutEmployee = 118,
                StartDate = DateTime.Now.AddDays(-191),
                EndDate = DateTime.Now.AddDays(-179),
                Cost = 99946000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-191),
                UpdatedAt = DateTime.Now.AddDays(-191),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 56,
                PaymentId = 28,
                ProductId = 156,
                ServiceId = 1,
                AmoutEmployee = 184,
                StartDate = DateTime.Now.AddDays(-82),
                EndDate = DateTime.Now.AddDays(-67),
                Cost = 5796000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-82),
                UpdatedAt = DateTime.Now.AddDays(-82),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 57,
                PaymentId = 29,
                ProductId = 128,
                ServiceId = 2,
                AmoutEmployee = 188,
                StartDate = DateTime.Now.AddDays(-145),
                EndDate = DateTime.Now.AddDays(-131),
                Cost = 136488000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-145),
                UpdatedAt = DateTime.Now.AddDays(-145),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 58,
                PaymentId = 29,
                ProductId = 159,
                ServiceId = 3,
                AmoutEmployee = 186,
                StartDate = DateTime.Now.AddDays(-82),
                EndDate = DateTime.Now.AddDays(-81),
                Cost = 74679000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-82),
                UpdatedAt = DateTime.Now.AddDays(-82),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 59,
                PaymentId = 30,
                ProductId = 70,
                ServiceId = 2,
                AmoutEmployee = 131,
                StartDate = DateTime.Now.AddDays(-158),
                EndDate = DateTime.Now.AddDays(-151),
                Cost = 117114000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-158),
                UpdatedAt = DateTime.Now.AddDays(-158),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 60,
                PaymentId = 30,
                ProductId = 124,
                ServiceId = 2,
                AmoutEmployee = 177,
                StartDate = DateTime.Now.AddDays(-122),
                EndDate = DateTime.Now.AddDays(-116),
                Cost = 12744000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-122),
                UpdatedAt = DateTime.Now.AddDays(-122),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 61,
                PaymentId = 31,
                ProductId = 135,
                ServiceId = 2,
                AmoutEmployee = 88,
                StartDate = DateTime.Now.AddDays(-193),
                EndDate = DateTime.Now.AddDays(-188),
                Cost = 7920000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-193),
                UpdatedAt = DateTime.Now.AddDays(-193),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 62,
                PaymentId = 31,
                ProductId = 16,
                ServiceId = 3,
                AmoutEmployee = 125,
                StartDate = DateTime.Now.AddDays(-178),
                EndDate = DateTime.Now.AddDays(-176),
                Cost = 39187500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-178),
                UpdatedAt = DateTime.Now.AddDays(-178),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 63,
                PaymentId = 32,
                ProductId = 95,
                ServiceId = 1,
                AmoutEmployee = 90,
                StartDate = DateTime.Now.AddDays(-162),
                EndDate = DateTime.Now.AddDays(-160),
                Cost = 42120000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-162),
                UpdatedAt = DateTime.Now.AddDays(-162),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 64,
                PaymentId = 32,
                ProductId = 121,
                ServiceId = 2,
                AmoutEmployee = 90,
                StartDate = DateTime.Now.AddDays(-188),
                EndDate = DateTime.Now.AddDays(-180),
                Cost = 31860000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-188),
                UpdatedAt = DateTime.Now.AddDays(-188),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 65,
                PaymentId = 33,
                ProductId = 1,
                ServiceId = 3,
                AmoutEmployee = 118,
                StartDate = DateTime.Now.AddDays(-168),
                EndDate = DateTime.Now.AddDays(-153),
                Cost = 67496000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-168),
                UpdatedAt = DateTime.Now.AddDays(-168),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 66,
                PaymentId = 33,
                ProductId = 184,
                ServiceId = 1,
                AmoutEmployee = 180,
                StartDate = DateTime.Now.AddDays(-135),
                EndDate = DateTime.Now.AddDays(-129),
                Cost = 47790000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-135),
                UpdatedAt = DateTime.Now.AddDays(-135),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 67,
                PaymentId = 34,
                ProductId = 109,
                ServiceId = 2,
                AmoutEmployee = 186,
                StartDate = DateTime.Now.AddDays(-102),
                EndDate = DateTime.Now.AddDays(-96),
                Cost = 2232000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-102),
                UpdatedAt = DateTime.Now.AddDays(-102),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 68,
                PaymentId = 34,
                ProductId = 105,
                ServiceId = 1,
                AmoutEmployee = 174,
                StartDate = DateTime.Now.AddDays(-27),
                EndDate = DateTime.Now.AddDays(-15),
                Cost = 16443000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-27),
                UpdatedAt = DateTime.Now.AddDays(-27),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 69,
                PaymentId = 35,
                ProductId = 121,
                ServiceId = 2,
                AmoutEmployee = 155,
                StartDate = DateTime.Now.AddDays(-128),
                EndDate = DateTime.Now.AddDays(-119),
                Cost = 5580000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-128),
                UpdatedAt = DateTime.Now.AddDays(-128),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 70,
                PaymentId = 35,
                ProductId = 30,
                ServiceId = 2,
                AmoutEmployee = 30,
                StartDate = DateTime.Now.AddDays(-173),
                EndDate = DateTime.Now.AddDays(-172),
                Cost = 360000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-173),
                UpdatedAt = DateTime.Now.AddDays(-173),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 71,
                PaymentId = 36,
                ProductId = 121,
                ServiceId = 2,
                AmoutEmployee = 95,
                StartDate = DateTime.Now.AddDays(-61),
                EndDate = DateTime.Now.AddDays(-55),
                Cost = 29640000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-61),
                UpdatedAt = DateTime.Now.AddDays(-61),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 72,
                PaymentId = 36,
                ProductId = 182,
                ServiceId = 3,
                AmoutEmployee = 40,
                StartDate = DateTime.Now.AddDays(-156),
                EndDate = DateTime.Now.AddDays(-141),
                Cost = 3960000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-156),
                UpdatedAt = DateTime.Now.AddDays(-156),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 73,
                PaymentId = 37,
                ProductId = 15,
                ServiceId = 3,
                AmoutEmployee = 167,
                StartDate = DateTime.Now.AddDays(-20),
                EndDate = DateTime.Now.AddDays(-16),
                Cost = 5511000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-20),
                UpdatedAt = DateTime.Now.AddDays(-20),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 74,
                PaymentId = 37,
                ProductId = 102,
                ServiceId = 1,
                AmoutEmployee = 134,
                StartDate = DateTime.Now.AddDays(-128),
                EndDate = DateTime.Now.AddDays(-127),
                Cost = 42813000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-128),
                UpdatedAt = DateTime.Now.AddDays(-128),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 75,
                PaymentId = 38,
                ProductId = 122,
                ServiceId = 3,
                AmoutEmployee = 116,
                StartDate = DateTime.Now.AddDays(-59),
                EndDate = DateTime.Now.AddDays(-52),
                Cost = 21054000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-59),
                UpdatedAt = DateTime.Now.AddDays(-59),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 76,
                PaymentId = 38,
                ProductId = 106,
                ServiceId = 3,
                AmoutEmployee = 111,
                StartDate = DateTime.Now.AddDays(-74),
                EndDate = DateTime.Now.AddDays(-62),
                Cost = 40293000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-74),
                UpdatedAt = DateTime.Now.AddDays(-74),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 77,
                PaymentId = 39,
                ProductId = 145,
                ServiceId = 1,
                AmoutEmployee = 80,
                StartDate = DateTime.Now.AddDays(-122),
                EndDate = DateTime.Now.AddDays(-112),
                Cost = 35280000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-122),
                UpdatedAt = DateTime.Now.AddDays(-122),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 78,
                PaymentId = 39,
                ProductId = 141,
                ServiceId = 1,
                AmoutEmployee = 141,
                StartDate = DateTime.Now.AddDays(-62),
                EndDate = DateTime.Now.AddDays(-48),
                Cost = 29821500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-62),
                UpdatedAt = DateTime.Now.AddDays(-62),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 79,
                PaymentId = 40,
                ProductId = 194,
                ServiceId = 3,
                AmoutEmployee = 71,
                StartDate = DateTime.Now.AddDays(-66),
                EndDate = DateTime.Now.AddDays(-55),
                Cost = 18353500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-66),
                UpdatedAt = DateTime.Now.AddDays(-66),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 80,
                PaymentId = 40,
                ProductId = 130,
                ServiceId = 2,
                AmoutEmployee = 44,
                StartDate = DateTime.Now.AddDays(-9),
                EndDate = DateTime.Now.AddDays(1),
                Cost = 1056000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-9),
                UpdatedAt = DateTime.Now.AddDays(-9),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 81,
                PaymentId = 41,
                ProductId = 89,
                ServiceId = 3,
                AmoutEmployee = 50,
                StartDate = DateTime.Now.AddDays(-70),
                EndDate = DateTime.Now.AddDays(-67),
                Cost = 3575000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-70),
                UpdatedAt = DateTime.Now.AddDays(-70),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 82,
                PaymentId = 41,
                ProductId = 70,
                ServiceId = 1,
                AmoutEmployee = 191,
                StartDate = DateTime.Now.AddDays(-34),
                EndDate = DateTime.Now.AddDays(-23),
                Cost = 1719000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-34),
                UpdatedAt = DateTime.Now.AddDays(-34),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 83,
                PaymentId = 42,
                ProductId = 195,
                ServiceId = 3,
                AmoutEmployee = 103,
                StartDate = DateTime.Now.AddDays(-151),
                EndDate = DateTime.Now.AddDays(-150),
                Cost = 60049000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-151),
                UpdatedAt = DateTime.Now.AddDays(-151),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 84,
                PaymentId = 42,
                ProductId = 59,
                ServiceId = 3,
                AmoutEmployee = 41,
                StartDate = DateTime.Now.AddDays(-109),
                EndDate = DateTime.Now.AddDays(-95),
                Cost = 1353000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-109),
                UpdatedAt = DateTime.Now.AddDays(-109),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 85,
                PaymentId = 43,
                ProductId = 1,
                ServiceId = 1,
                AmoutEmployee = 127,
                StartDate = DateTime.Now.AddDays(-47),
                EndDate = DateTime.Now.AddDays(-37),
                Cost = 15430500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-47),
                UpdatedAt = DateTime.Now.AddDays(-47),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 86,
                PaymentId = 43,
                ProductId = 114,
                ServiceId = 2,
                AmoutEmployee = 126,
                StartDate = DateTime.Now.AddDays(-123),
                EndDate = DateTime.Now.AddDays(-120),
                Cost = 65772000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-123),
                UpdatedAt = DateTime.Now.AddDays(-123),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 87,
                PaymentId = 44,
                ProductId = 25,
                ServiceId = 1,
                AmoutEmployee = 138,
                StartDate = DateTime.Now.AddDays(-79),
                EndDate = DateTime.Now.AddDays(-70),
                Cost = 32292000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-79),
                UpdatedAt = DateTime.Now.AddDays(-79),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 88,
                PaymentId = 44,
                ProductId = 197,
                ServiceId = 1,
                AmoutEmployee = 53,
                StartDate = DateTime.Now.AddDays(-52),
                EndDate = DateTime.Now.AddDays(-39),
                Cost = 8347500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-52),
                UpdatedAt = DateTime.Now.AddDays(-52),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 89,
                PaymentId = 45,
                ProductId = 101,
                ServiceId = 2,
                AmoutEmployee = 175,
                StartDate = DateTime.Now.AddDays(-180),
                EndDate = DateTime.Now.AddDays(-170),
                Cost = 29400000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-180),
                UpdatedAt = DateTime.Now.AddDays(-180),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 90,
                PaymentId = 45,
                ProductId = 96,
                ServiceId = 1,
                AmoutEmployee = 73,
                StartDate = DateTime.Now.AddDays(-25),
                EndDate = DateTime.Now.AddDays(-20),
                Cost = 5584500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-25),
                UpdatedAt = DateTime.Now.AddDays(-25),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 91,
                PaymentId = 46,
                ProductId = 194,
                ServiceId = 1,
                AmoutEmployee = 33,
                StartDate = DateTime.Now.AddDays(-43),
                EndDate = DateTime.Now.AddDays(-41),
                Cost = 1782000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-43),
                UpdatedAt = DateTime.Now.AddDays(-43),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 92,
                PaymentId = 46,
                ProductId = 180,
                ServiceId = 1,
                AmoutEmployee = 95,
                StartDate = DateTime.Now.AddDays(-43),
                EndDate = DateTime.Now.AddDays(-34),
                Cost = 5985000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-43),
                UpdatedAt = DateTime.Now.AddDays(-43),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 93,
                PaymentId = 47,
                ProductId = 189,
                ServiceId = 2,
                AmoutEmployee = 141,
                StartDate = DateTime.Now.AddDays(-55),
                EndDate = DateTime.Now.AddDays(-50),
                Cost = 37224000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-55),
                UpdatedAt = DateTime.Now.AddDays(-55),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 94,
                PaymentId = 47,
                ProductId = 114,
                ServiceId = 1,
                AmoutEmployee = 74,
                StartDate = DateTime.Now.AddDays(-173),
                EndDate = DateTime.Now.AddDays(-171),
                Cost = 15984000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-173),
                UpdatedAt = DateTime.Now.AddDays(-173),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 95,
                PaymentId = 48,
                ProductId = 127,
                ServiceId = 1,
                AmoutEmployee = 41,
                StartDate = DateTime.Now.AddDays(-38),
                EndDate = DateTime.Now.AddDays(-33),
                Cost = 2398500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-38),
                UpdatedAt = DateTime.Now.AddDays(-38),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 96,
                PaymentId = 48,
                ProductId = 26,
                ServiceId = 1,
                AmoutEmployee = 92,
                StartDate = DateTime.Now.AddDays(-80),
                EndDate = DateTime.Now.AddDays(-77),
                Cost = 4140000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-80),
                UpdatedAt = DateTime.Now.AddDays(-80),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 97,
                PaymentId = 49,
                ProductId = 18,
                ServiceId = 3,
                AmoutEmployee = 60,
                StartDate = DateTime.Now.AddDays(-122),
                EndDate = DateTime.Now.AddDays(-117),
                Cost = 9570000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-122),
                UpdatedAt = DateTime.Now.AddDays(-122),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 98,
                PaymentId = 49,
                ProductId = 182,
                ServiceId = 2,
                AmoutEmployee = 109,
                StartDate = DateTime.Now.AddDays(-150),
                EndDate = DateTime.Now.AddDays(-148),
                Cost = 85674000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-150),
                UpdatedAt = DateTime.Now.AddDays(-150),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 99,
                PaymentId = 50,
                ProductId = 185,
                ServiceId = 1,
                AmoutEmployee = 168,
                StartDate = DateTime.Now.AddDays(-32),
                EndDate = DateTime.Now.AddDays(-31),
                Cost = 9828000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-32),
                UpdatedAt = DateTime.Now.AddDays(-32),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 100,
                PaymentId = 50,
                ProductId = 172,
                ServiceId = 1,
                AmoutEmployee = 169,
                StartDate = DateTime.Now.AddDays(-95),
                EndDate = DateTime.Now.AddDays(-87),
                Cost = 8365500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-95),
                UpdatedAt = DateTime.Now.AddDays(-95),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 101,
                PaymentId = 51,
                ProductId = 38,
                ServiceId = 1,
                AmoutEmployee = 39,
                StartDate = DateTime.Now.AddDays(-37),
                EndDate = DateTime.Now.AddDays(-34),
                Cost = 4212000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-37),
                UpdatedAt = DateTime.Now.AddDays(-37),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 102,
                PaymentId = 51,
                ProductId = 125,
                ServiceId = 2,
                AmoutEmployee = 59,
                StartDate = DateTime.Now.AddDays(-92),
                EndDate = DateTime.Now.AddDays(-83),
                Cost = 28320000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-92),
                UpdatedAt = DateTime.Now.AddDays(-92),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 103,
                PaymentId = 52,
                ProductId = 90,
                ServiceId = 3,
                AmoutEmployee = 88,
                StartDate = DateTime.Now.AddDays(-78),
                EndDate = DateTime.Now.AddDays(-70),
                Cost = 1452000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-78),
                UpdatedAt = DateTime.Now.AddDays(-78),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 104,
                PaymentId = 52,
                ProductId = 91,
                ServiceId = 3,
                AmoutEmployee = 135,
                StartDate = DateTime.Now.AddDays(-94),
                EndDate = DateTime.Now.AddDays(-79),
                Cost = 49747500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-94),
                UpdatedAt = DateTime.Now.AddDays(-94),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 105,
                PaymentId = 53,
                ProductId = 38,
                ServiceId = 2,
                AmoutEmployee = 106,
                StartDate = DateTime.Now.AddDays(-44),
                EndDate = DateTime.Now.AddDays(-43),
                Cost = 636000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-44),
                UpdatedAt = DateTime.Now.AddDays(-44),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 106,
                PaymentId = 53,
                ProductId = 81,
                ServiceId = 2,
                AmoutEmployee = 124,
                StartDate = DateTime.Now.AddDays(-185),
                EndDate = DateTime.Now.AddDays(-181),
                Cost = 69192000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-185),
                UpdatedAt = DateTime.Now.AddDays(-185),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 107,
                PaymentId = 54,
                ProductId = 4,
                ServiceId = 1,
                AmoutEmployee = 103,
                StartDate = DateTime.Now.AddDays(-115),
                EndDate = DateTime.Now.AddDays(-110),
                Cost = 32908500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-115),
                UpdatedAt = DateTime.Now.AddDays(-115),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 108,
                PaymentId = 54,
                ProductId = 62,
                ServiceId = 2,
                AmoutEmployee = 186,
                StartDate = DateTime.Now.AddDays(-73),
                EndDate = DateTime.Now.AddDays(-62),
                Cost = 53568000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-73),
                UpdatedAt = DateTime.Now.AddDays(-73),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 109,
                PaymentId = 55,
                ProductId = 152,
                ServiceId = 2,
                AmoutEmployee = 198,
                StartDate = DateTime.Now.AddDays(-172),
                EndDate = DateTime.Now.AddDays(-159),
                Cost = 77220000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-172),
                UpdatedAt = DateTime.Now.AddDays(-172),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 110,
                PaymentId = 55,
                ProductId = 9,
                ServiceId = 3,
                AmoutEmployee = 26,
                StartDate = DateTime.Now.AddDays(-183),
                EndDate = DateTime.Now.AddDays(-176),
                Cost = 6435000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-183),
                UpdatedAt = DateTime.Now.AddDays(-183),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 111,
                PaymentId = 56,
                ProductId = 37,
                ServiceId = 2,
                AmoutEmployee = 56,
                StartDate = DateTime.Now.AddDays(-55),
                EndDate = DateTime.Now.AddDays(-42),
                Cost = 5376000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-55),
                UpdatedAt = DateTime.Now.AddDays(-55),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 112,
                PaymentId = 56,
                ProductId = 173,
                ServiceId = 2,
                AmoutEmployee = 183,
                StartDate = DateTime.Now.AddDays(-108),
                EndDate = DateTime.Now.AddDays(-104),
                Cost = 25254000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-108),
                UpdatedAt = DateTime.Now.AddDays(-108),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 113,
                PaymentId = 57,
                ProductId = 80,
                ServiceId = 1,
                AmoutEmployee = 72,
                StartDate = DateTime.Now.AddDays(-152),
                EndDate = DateTime.Now.AddDays(-150),
                Cost = 3240000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-152),
                UpdatedAt = DateTime.Now.AddDays(-152),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 114,
                PaymentId = 57,
                ProductId = 155,
                ServiceId = 3,
                AmoutEmployee = 82,
                StartDate = DateTime.Now.AddDays(-140),
                EndDate = DateTime.Now.AddDays(-131),
                Cost = 23452000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-140),
                UpdatedAt = DateTime.Now.AddDays(-140),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 115,
                PaymentId = 58,
                ProductId = 134,
                ServiceId = 1,
                AmoutEmployee = 59,
                StartDate = DateTime.Now.AddDays(-190),
                EndDate = DateTime.Now.AddDays(-183),
                Cost = 31860000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-190),
                UpdatedAt = DateTime.Now.AddDays(-190),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 116,
                PaymentId = 58,
                ProductId = 138,
                ServiceId = 2,
                AmoutEmployee = 36,
                StartDate = DateTime.Now.AddDays(-110),
                EndDate = DateTime.Now.AddDays(-105),
                Cost = 13824000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-110),
                UpdatedAt = DateTime.Now.AddDays(-110),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 117,
                PaymentId = 59,
                ProductId = 143,
                ServiceId = 3,
                AmoutEmployee = 184,
                StartDate = DateTime.Now.AddDays(-142),
                EndDate = DateTime.Now.AddDays(-135),
                Cost = 55660000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-142),
                UpdatedAt = DateTime.Now.AddDays(-142),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 118,
                PaymentId = 59,
                ProductId = 177,
                ServiceId = 3,
                AmoutEmployee = 82,
                StartDate = DateTime.Now.AddDays(-118),
                EndDate = DateTime.Now.AddDays(-116),
                Cost = 45100000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-118),
                UpdatedAt = DateTime.Now.AddDays(-118),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 119,
                PaymentId = 60,
                ProductId = 20,
                ServiceId = 1,
                AmoutEmployee = 175,
                StartDate = DateTime.Now.AddDays(-87),
                EndDate = DateTime.Now.AddDays(-84),
                Cost = 51187500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-87),
                UpdatedAt = DateTime.Now.AddDays(-87),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 120,
                PaymentId = 60,
                ProductId = 159,
                ServiceId = 1,
                AmoutEmployee = 198,
                StartDate = DateTime.Now.AddDays(-104),
                EndDate = DateTime.Now.AddDays(-101),
                Cost = 35640000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-104),
                UpdatedAt = DateTime.Now.AddDays(-104),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 121,
                PaymentId = 61,
                ProductId = 8,
                ServiceId = 2,
                AmoutEmployee = 114,
                StartDate = DateTime.Now.AddDays(-58),
                EndDate = DateTime.Now.AddDays(-51),
                Cost = 36252000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-58),
                UpdatedAt = DateTime.Now.AddDays(-58),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 122,
                PaymentId = 61,
                ProductId = 143,
                ServiceId = 3,
                AmoutEmployee = 134,
                StartDate = DateTime.Now.AddDays(-176),
                EndDate = DateTime.Now.AddDays(-166),
                Cost = 78859000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-176),
                UpdatedAt = DateTime.Now.AddDays(-176),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 123,
                PaymentId = 62,
                ProductId = 81,
                ServiceId = 2,
                AmoutEmployee = 36,
                StartDate = DateTime.Now.AddDays(-178),
                EndDate = DateTime.Now.AddDays(-167),
                Cost = 21168000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-178),
                UpdatedAt = DateTime.Now.AddDays(-178),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 124,
                PaymentId = 62,
                ProductId = 29,
                ServiceId = 1,
                AmoutEmployee = 85,
                StartDate = DateTime.Now.AddDays(-60),
                EndDate = DateTime.Now.AddDays(-45),
                Cost = 8032500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-60),
                UpdatedAt = DateTime.Now.AddDays(-60),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 125,
                PaymentId = 63,
                ProductId = 58,
                ServiceId = 2,
                AmoutEmployee = 143,
                StartDate = DateTime.Now.AddDays(-190),
                EndDate = DateTime.Now.AddDays(-182),
                Cost = 94380000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-190),
                UpdatedAt = DateTime.Now.AddDays(-190),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 126,
                PaymentId = 63,
                ProductId = 36,
                ServiceId = 3,
                AmoutEmployee = 61,
                StartDate = DateTime.Now.AddDays(-35),
                EndDate = DateTime.Now.AddDays(-23),
                Cost = 10065000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-35),
                UpdatedAt = DateTime.Now.AddDays(-35),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 127,
                PaymentId = 64,
                ProductId = 193,
                ServiceId = 2,
                AmoutEmployee = 55,
                StartDate = DateTime.Now.AddDays(-63),
                EndDate = DateTime.Now.AddDays(-52),
                Cost = 15840000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-63),
                UpdatedAt = DateTime.Now.AddDays(-63),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 128,
                PaymentId = 64,
                ProductId = 61,
                ServiceId = 2,
                AmoutEmployee = 94,
                StartDate = DateTime.Now.AddDays(-41),
                EndDate = DateTime.Now.AddDays(-38),
                Cost = 7896000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-41),
                UpdatedAt = DateTime.Now.AddDays(-41),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 129,
                PaymentId = 65,
                ProductId = 40,
                ServiceId = 2,
                AmoutEmployee = 97,
                StartDate = DateTime.Now.AddDays(-40),
                EndDate = DateTime.Now.AddDays(-29),
                Cost = 4656000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-40),
                UpdatedAt = DateTime.Now.AddDays(-40),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 130,
                PaymentId = 65,
                ProductId = 20,
                ServiceId = 1,
                AmoutEmployee = 186,
                StartDate = DateTime.Now.AddDays(-14),
                EndDate = DateTime.Now.AddDays(-1),
                Cost = 5022000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-14),
                UpdatedAt = DateTime.Now.AddDays(-14),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 131,
                PaymentId = 66,
                ProductId = 114,
                ServiceId = 1,
                AmoutEmployee = 94,
                StartDate = DateTime.Now.AddDays(-120),
                EndDate = DateTime.Now.AddDays(-111),
                Cost = 46953000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-120),
                UpdatedAt = DateTime.Now.AddDays(-120),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 132,
                PaymentId = 66,
                ProductId = 105,
                ServiceId = 1,
                AmoutEmployee = 186,
                StartDate = DateTime.Now.AddDays(-152),
                EndDate = DateTime.Now.AddDays(-147),
                Cost = 102951000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-152),
                UpdatedAt = DateTime.Now.AddDays(-152),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 133,
                PaymentId = 67,
                ProductId = 181,
                ServiceId = 1,
                AmoutEmployee = 60,
                StartDate = DateTime.Now.AddDays(-88),
                EndDate = DateTime.Now.AddDays(-76),
                Cost = 12420000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-88),
                UpdatedAt = DateTime.Now.AddDays(-88),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 134,
                PaymentId = 67,
                ProductId = 92,
                ServiceId = 1,
                AmoutEmployee = 110,
                StartDate = DateTime.Now.AddDays(-28),
                EndDate = DateTime.Now.AddDays(-22),
                Cost = 990000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-28),
                UpdatedAt = DateTime.Now.AddDays(-28),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 135,
                PaymentId = 68,
                ProductId = 35,
                ServiceId = 2,
                AmoutEmployee = 97,
                StartDate = DateTime.Now.AddDays(-175),
                EndDate = DateTime.Now.AddDays(-166),
                Cost = 90210000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-175),
                UpdatedAt = DateTime.Now.AddDays(-175),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 136,
                PaymentId = 68,
                ProductId = 21,
                ServiceId = 2,
                AmoutEmployee = 48,
                StartDate = DateTime.Now.AddDays(-24),
                EndDate = DateTime.Now.AddDays(-11),
                Cost = 3456000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-24),
                UpdatedAt = DateTime.Now.AddDays(-24),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 137,
                PaymentId = 69,
                ProductId = 9,
                ServiceId = 1,
                AmoutEmployee = 150,
                StartDate = DateTime.Now.AddDays(-48),
                EndDate = DateTime.Now.AddDays(-44),
                Cost = 2025000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-48),
                UpdatedAt = DateTime.Now.AddDays(-48),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 138,
                PaymentId = 69,
                ProductId = 47,
                ServiceId = 2,
                AmoutEmployee = 52,
                StartDate = DateTime.Now.AddDays(-72),
                EndDate = DateTime.Now.AddDays(-70),
                Cost = 11544000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-72),
                UpdatedAt = DateTime.Now.AddDays(-72),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 139,
                PaymentId = 70,
                ProductId = 53,
                ServiceId = 1,
                AmoutEmployee = 169,
                StartDate = DateTime.Now.AddDays(-183),
                EndDate = DateTime.Now.AddDays(-182),
                Cost = 31941000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-183),
                UpdatedAt = DateTime.Now.AddDays(-183),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 140,
                PaymentId = 70,
                ProductId = 139,
                ServiceId = 2,
                AmoutEmployee = 128,
                StartDate = DateTime.Now.AddDays(-103),
                EndDate = DateTime.Now.AddDays(-98),
                Cost = 23808000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-103),
                UpdatedAt = DateTime.Now.AddDays(-103),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 141,
                PaymentId = 71,
                ProductId = 100,
                ServiceId = 3,
                AmoutEmployee = 199,
                StartDate = DateTime.Now.AddDays(-142),
                EndDate = DateTime.Now.AddDays(-138),
                Cost = 106166500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-142),
                UpdatedAt = DateTime.Now.AddDays(-142),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 142,
                PaymentId = 71,
                ProductId = 172,
                ServiceId = 2,
                AmoutEmployee = 28,
                StartDate = DateTime.Now.AddDays(-53),
                EndDate = DateTime.Now.AddDays(-51),
                Cost = 1176000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-53),
                UpdatedAt = DateTime.Now.AddDays(-53),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 143,
                PaymentId = 72,
                ProductId = 151,
                ServiceId = 1,
                AmoutEmployee = 123,
                StartDate = DateTime.Now.AddDays(-35),
                EndDate = DateTime.Now.AddDays(-31),
                Cost = 1660500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-35),
                UpdatedAt = DateTime.Now.AddDays(-35),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 144,
                PaymentId = 72,
                ProductId = 96,
                ServiceId = 3,
                AmoutEmployee = 196,
                StartDate = DateTime.Now.AddDays(-130),
                EndDate = DateTime.Now.AddDays(-116),
                Cost = 73304000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-130),
                UpdatedAt = DateTime.Now.AddDays(-130),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 145,
                PaymentId = 73,
                ProductId = 35,
                ServiceId = 2,
                AmoutEmployee = 185,
                StartDate = DateTime.Now.AddDays(-31),
                EndDate = DateTime.Now.AddDays(-21),
                Cost = 25530000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-31),
                UpdatedAt = DateTime.Now.AddDays(-31),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 146,
                PaymentId = 73,
                ProductId = 110,
                ServiceId = 2,
                AmoutEmployee = 66,
                StartDate = DateTime.Now.AddDays(-164),
                EndDate = DateTime.Now.AddDays(-152),
                Cost = 57420000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-164),
                UpdatedAt = DateTime.Now.AddDays(-164),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 147,
                PaymentId = 74,
                ProductId = 66,
                ServiceId = 2,
                AmoutEmployee = 158,
                StartDate = DateTime.Now.AddDays(-81),
                EndDate = DateTime.Now.AddDays(-80),
                Cost = 27492000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-81),
                UpdatedAt = DateTime.Now.AddDays(-81),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 148,
                PaymentId = 74,
                ProductId = 82,
                ServiceId = 2,
                AmoutEmployee = 72,
                StartDate = DateTime.Now.AddDays(-81),
                EndDate = DateTime.Now.AddDays(-66),
                Cost = 8208000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-81),
                UpdatedAt = DateTime.Now.AddDays(-81),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 149,
                PaymentId = 75,
                ProductId = 25,
                ServiceId = 2,
                AmoutEmployee = 162,
                StartDate = DateTime.Now.AddDays(-89),
                EndDate = DateTime.Now.AddDays(-75),
                Cost = 69984000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-89),
                UpdatedAt = DateTime.Now.AddDays(-89),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 150,
                PaymentId = 75,
                ProductId = 124,
                ServiceId = 1,
                AmoutEmployee = 67,
                StartDate = DateTime.Now.AddDays(-152),
                EndDate = DateTime.Now.AddDays(-141),
                Cost = 37989000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-152),
                UpdatedAt = DateTime.Now.AddDays(-152),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 151,
                PaymentId = 76,
                ProductId = 13,
                ServiceId = 2,
                AmoutEmployee = 185,
                StartDate = DateTime.Now.AddDays(-154),
                EndDate = DateTime.Now.AddDays(-141),
                Cost = 66600000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-154),
                UpdatedAt = DateTime.Now.AddDays(-154),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 152,
                PaymentId = 76,
                ProductId = 101,
                ServiceId = 3,
                AmoutEmployee = 46,
                StartDate = DateTime.Now.AddDays(-10),
                EndDate = DateTime.Now.AddDays(2),
                Cost = 1265000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-10),
                UpdatedAt = DateTime.Now.AddDays(-10),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 153,
                PaymentId = 77,
                ProductId = 182,
                ServiceId = 2,
                AmoutEmployee = 39,
                StartDate = DateTime.Now.AddDays(-139),
                EndDate = DateTime.Now.AddDays(-131),
                Cost = 4914000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-139),
                UpdatedAt = DateTime.Now.AddDays(-139),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 154,
                PaymentId = 77,
                ProductId = 132,
                ServiceId = 1,
                AmoutEmployee = 124,
                StartDate = DateTime.Now.AddDays(-117),
                EndDate = DateTime.Now.AddDays(-102),
                Cost = 56916000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-117),
                UpdatedAt = DateTime.Now.AddDays(-117),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 155,
                PaymentId = 78,
                ProductId = 79,
                ServiceId = 2,
                AmoutEmployee = 174,
                StartDate = DateTime.Now.AddDays(-127),
                EndDate = DateTime.Now.AddDays(-121),
                Cost = 44892000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-127),
                UpdatedAt = DateTime.Now.AddDays(-127),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 156,
                PaymentId = 78,
                ProductId = 40,
                ServiceId = 1,
                AmoutEmployee = 103,
                StartDate = DateTime.Now.AddDays(-118),
                EndDate = DateTime.Now.AddDays(-104),
                Cost = 44959500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-118),
                UpdatedAt = DateTime.Now.AddDays(-118),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 157,
                PaymentId = 79,
                ProductId = 147,
                ServiceId = 1,
                AmoutEmployee = 136,
                StartDate = DateTime.Now.AddDays(-52),
                EndDate = DateTime.Now.AddDays(-38),
                Cost = 22644000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-52),
                UpdatedAt = DateTime.Now.AddDays(-52),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 158,
                PaymentId = 79,
                ProductId = 194,
                ServiceId = 2,
                AmoutEmployee = 145,
                StartDate = DateTime.Now.AddDays(-134),
                EndDate = DateTime.Now.AddDays(-129),
                Cost = 21750000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-134),
                UpdatedAt = DateTime.Now.AddDays(-134),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 159,
                PaymentId = 80,
                ProductId = 94,
                ServiceId = 1,
                AmoutEmployee = 156,
                StartDate = DateTime.Now.AddDays(-88),
                EndDate = DateTime.Now.AddDays(-73),
                Cost = 24570000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-88),
                UpdatedAt = DateTime.Now.AddDays(-88),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 160,
                PaymentId = 80,
                ProductId = 189,
                ServiceId = 3,
                AmoutEmployee = 128,
                StartDate = DateTime.Now.AddDays(-82),
                EndDate = DateTime.Now.AddDays(-80),
                Cost = 53504000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-82),
                UpdatedAt = DateTime.Now.AddDays(-82),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 161,
                PaymentId = 81,
                ProductId = 147,
                ServiceId = 2,
                AmoutEmployee = 156,
                StartDate = DateTime.Now.AddDays(-127),
                EndDate = DateTime.Now.AddDays(-122),
                Cost = 87048000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-127),
                UpdatedAt = DateTime.Now.AddDays(-127),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 162,
                PaymentId = 81,
                ProductId = 170,
                ServiceId = 2,
                AmoutEmployee = 108,
                StartDate = DateTime.Now.AddDays(-82),
                EndDate = DateTime.Now.AddDays(-68),
                Cost = 37584000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-82),
                UpdatedAt = DateTime.Now.AddDays(-82),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 163,
                PaymentId = 82,
                ProductId = 37,
                ServiceId = 3,
                AmoutEmployee = 198,
                StartDate = DateTime.Now.AddDays(-162),
                EndDate = DateTime.Now.AddDays(-159),
                Cost = 21780000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-162),
                UpdatedAt = DateTime.Now.AddDays(-162),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 164,
                PaymentId = 82,
                ProductId = 163,
                ServiceId = 2,
                AmoutEmployee = 27,
                StartDate = DateTime.Now.AddDays(-28),
                EndDate = DateTime.Now.AddDays(-21),
                Cost = 3402000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-28),
                UpdatedAt = DateTime.Now.AddDays(-28),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 165,
                PaymentId = 83,
                ProductId = 122,
                ServiceId = 1,
                AmoutEmployee = 88,
                StartDate = DateTime.Now.AddDays(-151),
                EndDate = DateTime.Now.AddDays(-145),
                Cost = 41184000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-151),
                UpdatedAt = DateTime.Now.AddDays(-151),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 166,
                PaymentId = 83,
                ProductId = 111,
                ServiceId = 2,
                AmoutEmployee = 76,
                StartDate = DateTime.Now.AddDays(-151),
                EndDate = DateTime.Now.AddDays(-145),
                Cost = 60648000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-151),
                UpdatedAt = DateTime.Now.AddDays(-151),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 167,
                PaymentId = 84,
                ProductId = 42,
                ServiceId = 1,
                AmoutEmployee = 154,
                StartDate = DateTime.Now.AddDays(-99),
                EndDate = DateTime.Now.AddDays(-90),
                Cost = 16632000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-99),
                UpdatedAt = DateTime.Now.AddDays(-99),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 168,
                PaymentId = 84,
                ProductId = 154,
                ServiceId = 3,
                AmoutEmployee = 134,
                StartDate = DateTime.Now.AddDays(-180),
                EndDate = DateTime.Now.AddDays(-178),
                Cost = 75911000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-180),
                UpdatedAt = DateTime.Now.AddDays(-180),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 169,
                PaymentId = 85,
                ProductId = 65,
                ServiceId = 2,
                AmoutEmployee = 162,
                StartDate = DateTime.Now.AddDays(-170),
                EndDate = DateTime.Now.AddDays(-160),
                Cost = 156492000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-170),
                UpdatedAt = DateTime.Now.AddDays(-170),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 170,
                PaymentId = 85,
                ProductId = 69,
                ServiceId = 2,
                AmoutEmployee = 117,
                StartDate = DateTime.Now.AddDays(-48),
                EndDate = DateTime.Now.AddDays(-33),
                Cost = 24570000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-48),
                UpdatedAt = DateTime.Now.AddDays(-48),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 171,
                PaymentId = 86,
                ProductId = 131,
                ServiceId = 3,
                AmoutEmployee = 182,
                StartDate = DateTime.Now.AddDays(-111),
                EndDate = DateTime.Now.AddDays(-99),
                Cost = 17017000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-111),
                UpdatedAt = DateTime.Now.AddDays(-111),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 172,
                PaymentId = 86,
                ProductId = 49,
                ServiceId = 3,
                AmoutEmployee = 27,
                StartDate = DateTime.Now.AddDays(-89),
                EndDate = DateTime.Now.AddDays(-87),
                Cost = 5346000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-89),
                UpdatedAt = DateTime.Now.AddDays(-89),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 173,
                PaymentId = 87,
                ProductId = 185,
                ServiceId = 2,
                AmoutEmployee = 44,
                StartDate = DateTime.Now.AddDays(-40),
                EndDate = DateTime.Now.AddDays(-29),
                Cost = 7920000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-40),
                UpdatedAt = DateTime.Now.AddDays(-40),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 174,
                PaymentId = 87,
                ProductId = 189,
                ServiceId = 3,
                AmoutEmployee = 156,
                StartDate = DateTime.Now.AddDays(-148),
                EndDate = DateTime.Now.AddDays(-138),
                Cost = 60060000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-148),
                UpdatedAt = DateTime.Now.AddDays(-148),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 175,
                PaymentId = 88,
                ProductId = 36,
                ServiceId = 2,
                AmoutEmployee = 60,
                StartDate = DateTime.Now.AddDays(-61),
                EndDate = DateTime.Now.AddDays(-60),
                Cost = 17280000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-61),
                UpdatedAt = DateTime.Now.AddDays(-61),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 176,
                PaymentId = 88,
                ProductId = 41,
                ServiceId = 3,
                AmoutEmployee = 191,
                StartDate = DateTime.Now.AddDays(-184),
                EndDate = DateTime.Now.AddDays(-179),
                Cost = 47272500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-184),
                UpdatedAt = DateTime.Now.AddDays(-184),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 177,
                PaymentId = 89,
                ProductId = 165,
                ServiceId = 3,
                AmoutEmployee = 79,
                StartDate = DateTime.Now.AddDays(-110),
                EndDate = DateTime.Now.AddDays(-103),
                Cost = 34325500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-110),
                UpdatedAt = DateTime.Now.AddDays(-110),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 178,
                PaymentId = 89,
                ProductId = 189,
                ServiceId = 3,
                AmoutEmployee = 185,
                StartDate = DateTime.Now.AddDays(-26),
                EndDate = DateTime.Now.AddDays(-24),
                Cost = 5087500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-26),
                UpdatedAt = DateTime.Now.AddDays(-26),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 179,
                PaymentId = 90,
                ProductId = 126,
                ServiceId = 2,
                AmoutEmployee = 94,
                StartDate = DateTime.Now.AddDays(-159),
                EndDate = DateTime.Now.AddDays(-149),
                Cost = 76704000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-159),
                UpdatedAt = DateTime.Now.AddDays(-159),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 180,
                PaymentId = 90,
                ProductId = 84,
                ServiceId = 3,
                AmoutEmployee = 40,
                StartDate = DateTime.Now.AddDays(-96),
                EndDate = DateTime.Now.AddDays(-95),
                Cost = 10340000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-96),
                UpdatedAt = DateTime.Now.AddDays(-96),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 181,
                PaymentId = 91,
                ProductId = 55,
                ServiceId = 3,
                AmoutEmployee = 108,
                StartDate = DateTime.Now.AddDays(-12),
                EndDate = DateTime.Now.AddDays(-2),
                Cost = 594000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-12),
                UpdatedAt = DateTime.Now.AddDays(-12),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 182,
                PaymentId = 91,
                ProductId = 178,
                ServiceId = 3,
                AmoutEmployee = 47,
                StartDate = DateTime.Now.AddDays(-21),
                EndDate = DateTime.Now.AddDays(-12),
                Cost = 3877500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-21),
                UpdatedAt = DateTime.Now.AddDays(-21),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 183,
                PaymentId = 92,
                ProductId = 101,
                ServiceId = 1,
                AmoutEmployee = 115,
                StartDate = DateTime.Now.AddDays(-148),
                EndDate = DateTime.Now.AddDays(-138),
                Cost = 22770000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-148),
                UpdatedAt = DateTime.Now.AddDays(-148),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 184,
                PaymentId = 92,
                ProductId = 138,
                ServiceId = 1,
                AmoutEmployee = 154,
                StartDate = DateTime.Now.AddDays(-32),
                EndDate = DateTime.Now.AddDays(-20),
                Cost = 18018000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-32),
                UpdatedAt = DateTime.Now.AddDays(-32),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 185,
                PaymentId = 93,
                ProductId = 78,
                ServiceId = 1,
                AmoutEmployee = 38,
                StartDate = DateTime.Now.AddDays(-124),
                EndDate = DateTime.Now.AddDays(-116),
                Cost = 10944000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-124),
                UpdatedAt = DateTime.Now.AddDays(-124),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 186,
                PaymentId = 93,
                ProductId = 182,
                ServiceId = 1,
                AmoutEmployee = 120,
                StartDate = DateTime.Now.AddDays(-11),
                EndDate = DateTime.Now.AddDays(-9),
                Cost = 1080000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-11),
                UpdatedAt = DateTime.Now.AddDays(-11),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 187,
                PaymentId = 94,
                ProductId = 12,
                ServiceId = 3,
                AmoutEmployee = 168,
                StartDate = DateTime.Now.AddDays(-46),
                EndDate = DateTime.Now.AddDays(-32),
                Cost = 16632000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-46),
                UpdatedAt = DateTime.Now.AddDays(-46),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 188,
                PaymentId = 94,
                ProductId = 4,
                ServiceId = 3,
                AmoutEmployee = 165,
                StartDate = DateTime.Now.AddDays(-167),
                EndDate = DateTime.Now.AddDays(-160),
                Cost = 4537500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-167),
                UpdatedAt = DateTime.Now.AddDays(-167),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 189,
                PaymentId = 95,
                ProductId = 40,
                ServiceId = 2,
                AmoutEmployee = 115,
                StartDate = DateTime.Now.AddDays(-88),
                EndDate = DateTime.Now.AddDays(-84),
                Cost = 56580000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-88),
                UpdatedAt = DateTime.Now.AddDays(-88),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 190,
                PaymentId = 95,
                ProductId = 63,
                ServiceId = 1,
                AmoutEmployee = 126,
                StartDate = DateTime.Now.AddDays(-189),
                EndDate = DateTime.Now.AddDays(-179),
                Cost = 19278000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-189),
                UpdatedAt = DateTime.Now.AddDays(-189),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 191,
                PaymentId = 96,
                ProductId = 194,
                ServiceId = 2,
                AmoutEmployee = 49,
                StartDate = DateTime.Now.AddDays(-112),
                EndDate = DateTime.Now.AddDays(-101),
                Cost = 14406000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-112),
                UpdatedAt = DateTime.Now.AddDays(-112),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 192,
                PaymentId = 96,
                ProductId = 39,
                ServiceId = 1,
                AmoutEmployee = 120,
                StartDate = DateTime.Now.AddDays(-170),
                EndDate = DateTime.Now.AddDays(-158),
                Cost = 66420000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-170),
                UpdatedAt = DateTime.Now.AddDays(-170),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 193,
                PaymentId = 97,
                ProductId = 19,
                ServiceId = 3,
                AmoutEmployee = 176,
                StartDate = DateTime.Now.AddDays(-192),
                EndDate = DateTime.Now.AddDays(-183),
                Cost = 81312000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-192),
                UpdatedAt = DateTime.Now.AddDays(-192),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 194,
                PaymentId = 97,
                ProductId = 34,
                ServiceId = 3,
                AmoutEmployee = 115,
                StartDate = DateTime.Now.AddDays(-32),
                EndDate = DateTime.Now.AddDays(-22),
                Cost = 10120000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-32),
                UpdatedAt = DateTime.Now.AddDays(-32),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 195,
                PaymentId = 98,
                ProductId = 8,
                ServiceId = 3,
                AmoutEmployee = 47,
                StartDate = DateTime.Now.AddDays(-91),
                EndDate = DateTime.Now.AddDays(-88),
                Cost = 14993000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-91),
                UpdatedAt = DateTime.Now.AddDays(-91),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 196,
                PaymentId = 98,
                ProductId = 7,
                ServiceId = 3,
                AmoutEmployee = 199,
                StartDate = DateTime.Now.AddDays(-93),
                EndDate = DateTime.Now.AddDays(-80),
                Cost = 76615000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-93),
                UpdatedAt = DateTime.Now.AddDays(-93),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 197,
                PaymentId = 99,
                ProductId = 27,
                ServiceId = 3,
                AmoutEmployee = 108,
                StartDate = DateTime.Now.AddDays(-94),
                EndDate = DateTime.Now.AddDays(-86),
                Cost = 6534000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-94),
                UpdatedAt = DateTime.Now.AddDays(-94),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 198,
                PaymentId = 99,
                ProductId = 65,
                ServiceId = 3,
                AmoutEmployee = 169,
                StartDate = DateTime.Now.AddDays(-175),
                EndDate = DateTime.Now.AddDays(-171),
                Cost = 10224500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-175),
                UpdatedAt = DateTime.Now.AddDays(-175),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 199,
                PaymentId = 100,
                ProductId = 155,
                ServiceId = 3,
                AmoutEmployee = 54,
                StartDate = DateTime.Now.AddDays(-154),
                EndDate = DateTime.Now.AddDays(-148),
                Cost = 6237000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-154),
                UpdatedAt = DateTime.Now.AddDays(-154),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 200,
                PaymentId = 100,
                ProductId = 149,
                ServiceId = 2,
                AmoutEmployee = 127,
                StartDate = DateTime.Now.AddDays(-32),
                EndDate = DateTime.Now.AddDays(-22),
                Cost = 9906000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-32),
                UpdatedAt = DateTime.Now.AddDays(-32),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 201,
                PaymentId = 101,
                ProductId = 143,
                ServiceId = 3,
                AmoutEmployee = 152,
                StartDate = DateTime.Now.AddDays(-33),
                EndDate = DateTime.Now.AddDays(-22),
                Cost = 17556000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-33),
                UpdatedAt = DateTime.Now.AddDays(-33),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 202,
                PaymentId = 101,
                ProductId = 36,
                ServiceId = 3,
                AmoutEmployee = 198,
                StartDate = DateTime.Now.AddDays(-179),
                EndDate = DateTime.Now.AddDays(-177),
                Cost = 170973000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-179),
                UpdatedAt = DateTime.Now.AddDays(-179),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 203,
                PaymentId = 102,
                ProductId = 28,
                ServiceId = 2,
                AmoutEmployee = 175,
                StartDate = DateTime.Now.AddDays(-194),
                EndDate = DateTime.Now.AddDays(-182),
                Cost = 79800000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-194),
                UpdatedAt = DateTime.Now.AddDays(-194),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 204,
                PaymentId = 102,
                ProductId = 1,
                ServiceId = 3,
                AmoutEmployee = 195,
                StartDate = DateTime.Now.AddDays(-56),
                EndDate = DateTime.Now.AddDays(-47),
                Cost = 16087500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-56),
                UpdatedAt = DateTime.Now.AddDays(-56),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 205,
                PaymentId = 103,
                ProductId = 36,
                ServiceId = 1,
                AmoutEmployee = 54,
                StartDate = DateTime.Now.AddDays(-50),
                EndDate = DateTime.Now.AddDays(-42),
                Cost = 7533000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-50),
                UpdatedAt = DateTime.Now.AddDays(-50),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 206,
                PaymentId = 103,
                ProductId = 123,
                ServiceId = 2,
                AmoutEmployee = 157,
                StartDate = DateTime.Now.AddDays(-106),
                EndDate = DateTime.Now.AddDays(-93),
                Cost = 23550000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-106),
                UpdatedAt = DateTime.Now.AddDays(-106),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 207,
                PaymentId = 104,
                ProductId = 34,
                ServiceId = 2,
                AmoutEmployee = 81,
                StartDate = DateTime.Now.AddDays(-197),
                EndDate = DateTime.Now.AddDays(-188),
                Cost = 71928000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-197),
                UpdatedAt = DateTime.Now.AddDays(-197),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 208,
                PaymentId = 104,
                ProductId = 40,
                ServiceId = 2,
                AmoutEmployee = 54,
                StartDate = DateTime.Now.AddDays(-51),
                EndDate = DateTime.Now.AddDays(-37),
                Cost = 13608000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-51),
                UpdatedAt = DateTime.Now.AddDays(-51),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 209,
                PaymentId = 105,
                ProductId = 7,
                ServiceId = 2,
                AmoutEmployee = 78,
                StartDate = DateTime.Now.AddDays(-162),
                EndDate = DateTime.Now.AddDays(-150),
                Cost = 63180000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-162),
                UpdatedAt = DateTime.Now.AddDays(-162),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 210,
                PaymentId = 105,
                ProductId = 13,
                ServiceId = 3,
                AmoutEmployee = 160,
                StartDate = DateTime.Now.AddDays(-132),
                EndDate = DateTime.Now.AddDays(-121),
                Cost = 18480000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-132),
                UpdatedAt = DateTime.Now.AddDays(-132),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 211,
                PaymentId = 106,
                ProductId = 168,
                ServiceId = 1,
                AmoutEmployee = 166,
                StartDate = DateTime.Now.AddDays(-174),
                EndDate = DateTime.Now.AddDays(-172),
                Cost = 7470000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-174),
                UpdatedAt = DateTime.Now.AddDays(-174),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 212,
                PaymentId = 106,
                ProductId = 21,
                ServiceId = 3,
                AmoutEmployee = 50,
                StartDate = DateTime.Now.AddDays(-97),
                EndDate = DateTime.Now.AddDays(-90),
                Cost = 3850000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-97),
                UpdatedAt = DateTime.Now.AddDays(-97),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 213,
                PaymentId = 107,
                ProductId = 139,
                ServiceId = 3,
                AmoutEmployee = 62,
                StartDate = DateTime.Now.AddDays(-183),
                EndDate = DateTime.Now.AddDays(-168),
                Cost = 6820000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-183),
                UpdatedAt = DateTime.Now.AddDays(-183),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 214,
                PaymentId = 107,
                ProductId = 9,
                ServiceId = 3,
                AmoutEmployee = 90,
                StartDate = DateTime.Now.AddDays(-33),
                EndDate = DateTime.Now.AddDays(-18),
                Cost = 6435000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-33),
                UpdatedAt = DateTime.Now.AddDays(-33),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 215,
                PaymentId = 108,
                ProductId = 175,
                ServiceId = 1,
                AmoutEmployee = 163,
                StartDate = DateTime.Now.AddDays(-160),
                EndDate = DateTime.Now.AddDays(-154),
                Cost = 21271500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-160),
                UpdatedAt = DateTime.Now.AddDays(-160),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 216,
                PaymentId = 108,
                ProductId = 94,
                ServiceId = 3,
                AmoutEmployee = 47,
                StartDate = DateTime.Now.AddDays(-154),
                EndDate = DateTime.Now.AddDays(-140),
                Cost = 36448500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-154),
                UpdatedAt = DateTime.Now.AddDays(-154),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 217,
                PaymentId = 109,
                ProductId = 134,
                ServiceId = 3,
                AmoutEmployee = 97,
                StartDate = DateTime.Now.AddDays(-117),
                EndDate = DateTime.Now.AddDays(-105),
                Cost = 22407000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-117),
                UpdatedAt = DateTime.Now.AddDays(-117),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 218,
                PaymentId = 109,
                ProductId = 180,
                ServiceId = 1,
                AmoutEmployee = 38,
                StartDate = DateTime.Now.AddDays(-25),
                EndDate = DateTime.Now.AddDays(-18),
                Cost = 1197000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-25),
                UpdatedAt = DateTime.Now.AddDays(-25),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 219,
                PaymentId = 110,
                ProductId = 196,
                ServiceId = 1,
                AmoutEmployee = 39,
                StartDate = DateTime.Now.AddDays(-11),
                EndDate = DateTime.Now.AddDays(-7),
                Cost = 526500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-11),
                UpdatedAt = DateTime.Now.AddDays(-11),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 220,
                PaymentId = 110,
                ProductId = 94,
                ServiceId = 3,
                AmoutEmployee = 75,
                StartDate = DateTime.Now.AddDays(-169),
                EndDate = DateTime.Now.AddDays(-157),
                Cost = 23100000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-169),
                UpdatedAt = DateTime.Now.AddDays(-169),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 221,
                PaymentId = 111,
                ProductId = 122,
                ServiceId = 2,
                AmoutEmployee = 142,
                StartDate = DateTime.Now.AddDays(-99),
                EndDate = DateTime.Now.AddDays(-93),
                Cost = 46860000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-99),
                UpdatedAt = DateTime.Now.AddDays(-99),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 222,
                PaymentId = 111,
                ProductId = 69,
                ServiceId = 3,
                AmoutEmployee = 164,
                StartDate = DateTime.Now.AddDays(-46),
                EndDate = DateTime.Now.AddDays(-31),
                Cost = 30668000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-46),
                UpdatedAt = DateTime.Now.AddDays(-46),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 223,
                PaymentId = 112,
                ProductId = 85,
                ServiceId = 1,
                AmoutEmployee = 90,
                StartDate = DateTime.Now.AddDays(-188),
                EndDate = DateTime.Now.AddDays(-182),
                Cost = 62370000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-188),
                UpdatedAt = DateTime.Now.AddDays(-188),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 224,
                PaymentId = 112,
                ProductId = 169,
                ServiceId = 2,
                AmoutEmployee = 110,
                StartDate = DateTime.Now.AddDays(-45),
                EndDate = DateTime.Now.AddDays(-38),
                Cost = 11220000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-45),
                UpdatedAt = DateTime.Now.AddDays(-45),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 225,
                PaymentId = 113,
                ProductId = 101,
                ServiceId = 1,
                AmoutEmployee = 135,
                StartDate = DateTime.Now.AddDays(-137),
                EndDate = DateTime.Now.AddDays(-128),
                Cost = 63787500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-137),
                UpdatedAt = DateTime.Now.AddDays(-137),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 226,
                PaymentId = 113,
                ProductId = 35,
                ServiceId = 3,
                AmoutEmployee = 65,
                StartDate = DateTime.Now.AddDays(-36),
                EndDate = DateTime.Now.AddDays(-25),
                Cost = 7865000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-36),
                UpdatedAt = DateTime.Now.AddDays(-36),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 227,
                PaymentId = 114,
                ProductId = 119,
                ServiceId = 2,
                AmoutEmployee = 43,
                StartDate = DateTime.Now.AddDays(-80),
                EndDate = DateTime.Now.AddDays(-65),
                Cost = 1032000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-80),
                UpdatedAt = DateTime.Now.AddDays(-80),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 228,
                PaymentId = 114,
                ProductId = 81,
                ServiceId = 2,
                AmoutEmployee = 156,
                StartDate = DateTime.Now.AddDays(-101),
                EndDate = DateTime.Now.AddDays(-88),
                Cost = 74880000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-101),
                UpdatedAt = DateTime.Now.AddDays(-101),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 229,
                PaymentId = 115,
                ProductId = 184,
                ServiceId = 3,
                AmoutEmployee = 163,
                StartDate = DateTime.Now.AddDays(-89),
                EndDate = DateTime.Now.AddDays(-88),
                Cost = 19723000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-89),
                UpdatedAt = DateTime.Now.AddDays(-89),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 230,
                PaymentId = 115,
                ProductId = 45,
                ServiceId = 2,
                AmoutEmployee = 55,
                StartDate = DateTime.Now.AddDays(-134),
                EndDate = DateTime.Now.AddDays(-127),
                Cost = 23760000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-134),
                UpdatedAt = DateTime.Now.AddDays(-134),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 231,
                PaymentId = 116,
                ProductId = 166,
                ServiceId = 3,
                AmoutEmployee = 166,
                StartDate = DateTime.Now.AddDays(-147),
                EndDate = DateTime.Now.AddDays(-137),
                Cost = 110473000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-147),
                UpdatedAt = DateTime.Now.AddDays(-147),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 232,
                PaymentId = 116,
                ProductId = 22,
                ServiceId = 3,
                AmoutEmployee = 173,
                StartDate = DateTime.Now.AddDays(-28),
                EndDate = DateTime.Now.AddDays(-17),
                Cost = 21884500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-28),
                UpdatedAt = DateTime.Now.AddDays(-28),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 233,
                PaymentId = 117,
                ProductId = 62,
                ServiceId = 2,
                AmoutEmployee = 141,
                StartDate = DateTime.Now.AddDays(-8),
                EndDate = DateTime.Now.AddDays(5),
                Cost = 2538000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-8),
                UpdatedAt = DateTime.Now.AddDays(-8),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 234,
                PaymentId = 117,
                ProductId = 166,
                ServiceId = 1,
                AmoutEmployee = 89,
                StartDate = DateTime.Now.AddDays(-156),
                EndDate = DateTime.Now.AddDays(-142),
                Cost = 34443000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-156),
                UpdatedAt = DateTime.Now.AddDays(-156),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 235,
                PaymentId = 118,
                ProductId = 104,
                ServiceId = 1,
                AmoutEmployee = 107,
                StartDate = DateTime.Now.AddDays(-126),
                EndDate = DateTime.Now.AddDays(-123),
                Cost = 34668000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-126),
                UpdatedAt = DateTime.Now.AddDays(-126),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 236,
                PaymentId = 118,
                ProductId = 85,
                ServiceId = 1,
                AmoutEmployee = 51,
                StartDate = DateTime.Now.AddDays(-145),
                EndDate = DateTime.Now.AddDays(-133),
                Cost = 1377000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-145),
                UpdatedAt = DateTime.Now.AddDays(-145),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 237,
                PaymentId = 119,
                ProductId = 157,
                ServiceId = 3,
                AmoutEmployee = 162,
                StartDate = DateTime.Now.AddDays(-53),
                EndDate = DateTime.Now.AddDays(-48),
                Cost = 3564000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-53),
                UpdatedAt = DateTime.Now.AddDays(-53),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 238,
                PaymentId = 119,
                ProductId = 51,
                ServiceId = 3,
                AmoutEmployee = 151,
                StartDate = DateTime.Now.AddDays(-79),
                EndDate = DateTime.Now.AddDays(-68),
                Cost = 17440500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-79),
                UpdatedAt = DateTime.Now.AddDays(-79),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 239,
                PaymentId = 120,
                ProductId = 22,
                ServiceId = 1,
                AmoutEmployee = 60,
                StartDate = DateTime.Now.AddDays(-31),
                EndDate = DateTime.Now.AddDays(-23),
                Cost = 4860000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-31),
                UpdatedAt = DateTime.Now.AddDays(-31),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 240,
                PaymentId = 120,
                ProductId = 108,
                ServiceId = 1,
                AmoutEmployee = 46,
                StartDate = DateTime.Now.AddDays(-154),
                EndDate = DateTime.Now.AddDays(-146),
                Cost = 14076000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-154),
                UpdatedAt = DateTime.Now.AddDays(-154),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 241,
                PaymentId = 121,
                ProductId = 26,
                ServiceId = 3,
                AmoutEmployee = 142,
                StartDate = DateTime.Now.AddDays(-195),
                EndDate = DateTime.Now.AddDays(-188),
                Cost = 136675000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-195),
                UpdatedAt = DateTime.Now.AddDays(-195),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 242,
                PaymentId = 121,
                ProductId = 94,
                ServiceId = 2,
                AmoutEmployee = 77,
                StartDate = DateTime.Now.AddDays(-30),
                EndDate = DateTime.Now.AddDays(-28),
                Cost = 5544000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-30),
                UpdatedAt = DateTime.Now.AddDays(-30),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 243,
                PaymentId = 122,
                ProductId = 121,
                ServiceId = 2,
                AmoutEmployee = 169,
                StartDate = DateTime.Now.AddDays(-166),
                EndDate = DateTime.Now.AddDays(-163),
                Cost = 116610000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-166),
                UpdatedAt = DateTime.Now.AddDays(-166),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 244,
                PaymentId = 122,
                ProductId = 58,
                ServiceId = 3,
                AmoutEmployee = 103,
                StartDate = DateTime.Now.AddDays(-89),
                EndDate = DateTime.Now.AddDays(-75),
                Cost = 13029500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-89),
                UpdatedAt = DateTime.Now.AddDays(-89),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 245,
                PaymentId = 123,
                ProductId = 43,
                ServiceId = 3,
                AmoutEmployee = 198,
                StartDate = DateTime.Now.AddDays(-164),
                EndDate = DateTime.Now.AddDays(-151),
                Cost = 103455000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-164),
                UpdatedAt = DateTime.Now.AddDays(-164),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 246,
                PaymentId = 123,
                ProductId = 65,
                ServiceId = 2,
                AmoutEmployee = 42,
                StartDate = DateTime.Now.AddDays(-48),
                EndDate = DateTime.Now.AddDays(-46),
                Cost = 8820000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-48),
                UpdatedAt = DateTime.Now.AddDays(-48),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 247,
                PaymentId = 124,
                ProductId = 133,
                ServiceId = 2,
                AmoutEmployee = 26,
                StartDate = DateTime.Now.AddDays(-28),
                EndDate = DateTime.Now.AddDays(-13),
                Cost = 3276000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-28),
                UpdatedAt = DateTime.Now.AddDays(-28),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 248,
                PaymentId = 124,
                ProductId = 6,
                ServiceId = 1,
                AmoutEmployee = 139,
                StartDate = DateTime.Now.AddDays(-86),
                EndDate = DateTime.Now.AddDays(-76),
                Cost = 46912500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-86),
                UpdatedAt = DateTime.Now.AddDays(-86),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 249,
                PaymentId = 125,
                ProductId = 86,
                ServiceId = 3,
                AmoutEmployee = 162,
                StartDate = DateTime.Now.AddDays(-150),
                EndDate = DateTime.Now.AddDays(-146),
                Cost = 6237000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-150),
                UpdatedAt = DateTime.Now.AddDays(-150),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 250,
                PaymentId = 125,
                ProductId = 116,
                ServiceId = 3,
                AmoutEmployee = 58,
                StartDate = DateTime.Now.AddDays(-143),
                EndDate = DateTime.Now.AddDays(-136),
                Cost = 13079000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-143),
                UpdatedAt = DateTime.Now.AddDays(-143),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 251,
                PaymentId = 126,
                ProductId = 106,
                ServiceId = 1,
                AmoutEmployee = 69,
                StartDate = DateTime.Now.AddDays(-127),
                EndDate = DateTime.Now.AddDays(-123),
                Cost = 13041000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-127),
                UpdatedAt = DateTime.Now.AddDays(-127),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 252,
                PaymentId = 126,
                ProductId = 76,
                ServiceId = 3,
                AmoutEmployee = 86,
                StartDate = DateTime.Now.AddDays(-105),
                EndDate = DateTime.Now.AddDays(-99),
                Cost = 29799000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-105),
                UpdatedAt = DateTime.Now.AddDays(-105),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 253,
                PaymentId = 127,
                ProductId = 44,
                ServiceId = 3,
                AmoutEmployee = 154,
                StartDate = DateTime.Now.AddDays(-117),
                EndDate = DateTime.Now.AddDays(-107),
                Cost = 43197000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-117),
                UpdatedAt = DateTime.Now.AddDays(-117),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 254,
                PaymentId = 127,
                ProductId = 131,
                ServiceId = 2,
                AmoutEmployee = 200,
                StartDate = DateTime.Now.AddDays(-68),
                EndDate = DateTime.Now.AddDays(-61),
                Cost = 67200000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-68),
                UpdatedAt = DateTime.Now.AddDays(-68),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 255,
                PaymentId = 128,
                ProductId = 116,
                ServiceId = 1,
                AmoutEmployee = 193,
                StartDate = DateTime.Now.AddDays(-145),
                EndDate = DateTime.Now.AddDays(-142),
                Cost = 120721500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-145),
                UpdatedAt = DateTime.Now.AddDays(-145),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 256,
                PaymentId = 128,
                ProductId = 188,
                ServiceId = 2,
                AmoutEmployee = 167,
                StartDate = DateTime.Now.AddDays(-188),
                EndDate = DateTime.Now.AddDays(-175),
                Cost = 169338000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-188),
                UpdatedAt = DateTime.Now.AddDays(-188),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 257,
                PaymentId = 129,
                ProductId = 36,
                ServiceId = 2,
                AmoutEmployee = 127,
                StartDate = DateTime.Now.AddDays(-59),
                EndDate = DateTime.Now.AddDays(-44),
                Cost = 32004000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-59),
                UpdatedAt = DateTime.Now.AddDays(-59),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 258,
                PaymentId = 129,
                ProductId = 164,
                ServiceId = 3,
                AmoutEmployee = 147,
                StartDate = DateTime.Now.AddDays(-178),
                EndDate = DateTime.Now.AddDays(-167),
                Cost = 109956000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-178),
                UpdatedAt = DateTime.Now.AddDays(-178),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 259,
                PaymentId = 130,
                ProductId = 86,
                ServiceId = 3,
                AmoutEmployee = 164,
                StartDate = DateTime.Now.AddDays(-60),
                EndDate = DateTime.Now.AddDays(-50),
                Cost = 31570000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-60),
                UpdatedAt = DateTime.Now.AddDays(-60),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 260,
                PaymentId = 130,
                ProductId = 32,
                ServiceId = 1,
                AmoutEmployee = 113,
                StartDate = DateTime.Now.AddDays(-165),
                EndDate = DateTime.Now.AddDays(-153),
                Cost = 74241000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-165),
                UpdatedAt = DateTime.Now.AddDays(-165),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 261,
                PaymentId = 131,
                ProductId = 188,
                ServiceId = 3,
                AmoutEmployee = 169,
                StartDate = DateTime.Now.AddDays(-127),
                EndDate = DateTime.Now.AddDays(-125),
                Cost = 64135500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-127),
                UpdatedAt = DateTime.Now.AddDays(-127),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 262,
                PaymentId = 131,
                ProductId = 100,
                ServiceId = 1,
                AmoutEmployee = 135,
                StartDate = DateTime.Now.AddDays(-198),
                EndDate = DateTime.Now.AddDays(-192),
                Cost = 100845000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-198),
                UpdatedAt = DateTime.Now.AddDays(-198),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 263,
                PaymentId = 132,
                ProductId = 46,
                ServiceId = 2,
                AmoutEmployee = 172,
                StartDate = DateTime.Now.AddDays(-70),
                EndDate = DateTime.Now.AddDays(-59),
                Cost = 4128000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-70),
                UpdatedAt = DateTime.Now.AddDays(-70),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 264,
                PaymentId = 132,
                ProductId = 72,
                ServiceId = 2,
                AmoutEmployee = 133,
                StartDate = DateTime.Now.AddDays(-61),
                EndDate = DateTime.Now.AddDays(-55),
                Cost = 40698000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-61),
                UpdatedAt = DateTime.Now.AddDays(-61),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 265,
                PaymentId = 133,
                ProductId = 64,
                ServiceId = 1,
                AmoutEmployee = 71,
                StartDate = DateTime.Now.AddDays(-154),
                EndDate = DateTime.Now.AddDays(-146),
                Cost = 4792500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-154),
                UpdatedAt = DateTime.Now.AddDays(-154),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 266,
                PaymentId = 133,
                ProductId = 166,
                ServiceId = 3,
                AmoutEmployee = 128,
                StartDate = DateTime.Now.AddDays(-67),
                EndDate = DateTime.Now.AddDays(-54),
                Cost = 24640000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-67),
                UpdatedAt = DateTime.Now.AddDays(-67),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 267,
                PaymentId = 134,
                ProductId = 175,
                ServiceId = 2,
                AmoutEmployee = 188,
                StartDate = DateTime.Now.AddDays(-60),
                EndDate = DateTime.Now.AddDays(-50),
                Cost = 21432000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-60),
                UpdatedAt = DateTime.Now.AddDays(-60),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 268,
                PaymentId = 134,
                ProductId = 109,
                ServiceId = 1,
                AmoutEmployee = 195,
                StartDate = DateTime.Now.AddDays(-34),
                EndDate = DateTime.Now.AddDays(-27),
                Cost = 20182500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-34),
                UpdatedAt = DateTime.Now.AddDays(-34),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 269,
                PaymentId = 135,
                ProductId = 26,
                ServiceId = 2,
                AmoutEmployee = 94,
                StartDate = DateTime.Now.AddDays(-114),
                EndDate = DateTime.Now.AddDays(-102),
                Cost = 564000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-114),
                UpdatedAt = DateTime.Now.AddDays(-114),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 270,
                PaymentId = 135,
                ProductId = 27,
                ServiceId = 1,
                AmoutEmployee = 79,
                StartDate = DateTime.Now.AddDays(-162),
                EndDate = DateTime.Now.AddDays(-158),
                Cost = 23818500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-162),
                UpdatedAt = DateTime.Now.AddDays(-162),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 271,
                PaymentId = 136,
                ProductId = 161,
                ServiceId = 2,
                AmoutEmployee = 41,
                StartDate = DateTime.Now.AddDays(-138),
                EndDate = DateTime.Now.AddDays(-127),
                Cost = 8856000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-138),
                UpdatedAt = DateTime.Now.AddDays(-138),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 272,
                PaymentId = 136,
                ProductId = 186,
                ServiceId = 1,
                AmoutEmployee = 33,
                StartDate = DateTime.Now.AddDays(-22),
                EndDate = DateTime.Now.AddDays(-15),
                Cost = 148500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-22),
                UpdatedAt = DateTime.Now.AddDays(-22),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 273,
                PaymentId = 137,
                ProductId = 60,
                ServiceId = 1,
                AmoutEmployee = 134,
                StartDate = DateTime.Now.AddDays(-179),
                EndDate = DateTime.Now.AddDays(-176),
                Cost = 41004000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-179),
                UpdatedAt = DateTime.Now.AddDays(-179),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 274,
                PaymentId = 137,
                ProductId = 4,
                ServiceId = 3,
                AmoutEmployee = 61,
                StartDate = DateTime.Now.AddDays(-153),
                EndDate = DateTime.Now.AddDays(-142),
                Cost = 38247000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-153),
                UpdatedAt = DateTime.Now.AddDays(-153),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 275,
                PaymentId = 138,
                ProductId = 191,
                ServiceId = 2,
                AmoutEmployee = 88,
                StartDate = DateTime.Now.AddDays(-179),
                EndDate = DateTime.Now.AddDays(-178),
                Cost = 82896000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-179),
                UpdatedAt = DateTime.Now.AddDays(-179),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 276,
                PaymentId = 138,
                ProductId = 93,
                ServiceId = 3,
                AmoutEmployee = 168,
                StartDate = DateTime.Now.AddDays(-147),
                EndDate = DateTime.Now.AddDays(-132),
                Cost = 121968000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-147),
                UpdatedAt = DateTime.Now.AddDays(-147),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 277,
                PaymentId = 139,
                ProductId = 196,
                ServiceId = 2,
                AmoutEmployee = 142,
                StartDate = DateTime.Now.AddDays(-64),
                EndDate = DateTime.Now.AddDays(-52),
                Cost = 37488000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-64),
                UpdatedAt = DateTime.Now.AddDays(-64),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 278,
                PaymentId = 139,
                ProductId = 148,
                ServiceId = 1,
                AmoutEmployee = 135,
                StartDate = DateTime.Now.AddDays(-64),
                EndDate = DateTime.Now.AddDays(-60),
                Cost = 25515000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-64),
                UpdatedAt = DateTime.Now.AddDays(-64),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 279,
                PaymentId = 140,
                ProductId = 140,
                ServiceId = 3,
                AmoutEmployee = 123,
                StartDate = DateTime.Now.AddDays(-20),
                EndDate = DateTime.Now.AddDays(-15),
                Cost = 4735500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-20),
                UpdatedAt = DateTime.Now.AddDays(-20),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 280,
                PaymentId = 140,
                ProductId = 82,
                ServiceId = 2,
                AmoutEmployee = 192,
                StartDate = DateTime.Now.AddDays(-44),
                EndDate = DateTime.Now.AddDays(-31),
                Cost = 34560000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-44),
                UpdatedAt = DateTime.Now.AddDays(-44),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 281,
                PaymentId = 141,
                ProductId = 129,
                ServiceId = 3,
                AmoutEmployee = 72,
                StartDate = DateTime.Now.AddDays(-95),
                EndDate = DateTime.Now.AddDays(-90),
                Cost = 25740000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-95),
                UpdatedAt = DateTime.Now.AddDays(-95),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 282,
                PaymentId = 141,
                ProductId = 64,
                ServiceId = 3,
                AmoutEmployee = 55,
                StartDate = DateTime.Now.AddDays(-178),
                EndDate = DateTime.Now.AddDays(-169),
                Cost = 10587500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-178),
                UpdatedAt = DateTime.Now.AddDays(-178),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 283,
                PaymentId = 142,
                ProductId = 88,
                ServiceId = 2,
                AmoutEmployee = 98,
                StartDate = DateTime.Now.AddDays(-46),
                EndDate = DateTime.Now.AddDays(-35),
                Cost = 6468000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-46),
                UpdatedAt = DateTime.Now.AddDays(-46),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 284,
                PaymentId = 142,
                ProductId = 172,
                ServiceId = 3,
                AmoutEmployee = 188,
                StartDate = DateTime.Now.AddDays(-171),
                EndDate = DateTime.Now.AddDays(-160),
                Cost = 27918000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-171),
                UpdatedAt = DateTime.Now.AddDays(-171),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 285,
                PaymentId = 143,
                ProductId = 42,
                ServiceId = 3,
                AmoutEmployee = 162,
                StartDate = DateTime.Now.AddDays(-123),
                EndDate = DateTime.Now.AddDays(-112),
                Cost = 49896000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-123),
                UpdatedAt = DateTime.Now.AddDays(-123),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 286,
                PaymentId = 143,
                ProductId = 46,
                ServiceId = 1,
                AmoutEmployee = 139,
                StartDate = DateTime.Now.AddDays(-181),
                EndDate = DateTime.Now.AddDays(-168),
                Cost = 106335000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-181),
                UpdatedAt = DateTime.Now.AddDays(-181),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 287,
                PaymentId = 144,
                ProductId = 160,
                ServiceId = 1,
                AmoutEmployee = 189,
                StartDate = DateTime.Now.AddDays(-72),
                EndDate = DateTime.Now.AddDays(-66),
                Cost = 34020000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-72),
                UpdatedAt = DateTime.Now.AddDays(-72),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 288,
                PaymentId = 144,
                ProductId = 118,
                ServiceId = 3,
                AmoutEmployee = 169,
                StartDate = DateTime.Now.AddDays(-95),
                EndDate = DateTime.Now.AddDays(-92),
                Cost = 63206000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-95),
                UpdatedAt = DateTime.Now.AddDays(-95),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 289,
                PaymentId = 145,
                ProductId = 137,
                ServiceId = 3,
                AmoutEmployee = 131,
                StartDate = DateTime.Now.AddDays(-162),
                EndDate = DateTime.Now.AddDays(-161),
                Cost = 61963000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-162),
                UpdatedAt = DateTime.Now.AddDays(-162),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 290,
                PaymentId = 145,
                ProductId = 178,
                ServiceId = 2,
                AmoutEmployee = 45,
                StartDate = DateTime.Now.AddDays(-82),
                EndDate = DateTime.Now.AddDays(-76),
                Cost = 16200000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-82),
                UpdatedAt = DateTime.Now.AddDays(-82),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 291,
                PaymentId = 146,
                ProductId = 70,
                ServiceId = 3,
                AmoutEmployee = 147,
                StartDate = DateTime.Now.AddDays(-22),
                EndDate = DateTime.Now.AddDays(-9),
                Cost = 12127500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-22),
                UpdatedAt = DateTime.Now.AddDays(-22),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 292,
                PaymentId = 146,
                ProductId = 185,
                ServiceId = 2,
                AmoutEmployee = 87,
                StartDate = DateTime.Now.AddDays(-181),
                EndDate = DateTime.Now.AddDays(-172),
                Cost = 87696000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-181),
                UpdatedAt = DateTime.Now.AddDays(-181),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 293,
                PaymentId = 147,
                ProductId = 168,
                ServiceId = 3,
                AmoutEmployee = 131,
                StartDate = DateTime.Now.AddDays(-124),
                EndDate = DateTime.Now.AddDays(-115),
                Cost = 56919500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-124),
                UpdatedAt = DateTime.Now.AddDays(-124),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 294,
                PaymentId = 147,
                ProductId = 40,
                ServiceId = 3,
                AmoutEmployee = 60,
                StartDate = DateTime.Now.AddDays(-99),
                EndDate = DateTime.Now.AddDays(-85),
                Cost = 24090000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-99),
                UpdatedAt = DateTime.Now.AddDays(-99),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 295,
                PaymentId = 148,
                ProductId = 28,
                ServiceId = 2,
                AmoutEmployee = 142,
                StartDate = DateTime.Now.AddDays(-9),
                EndDate = DateTime.Now.AddDays(5),
                Cost = 1704000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-9),
                UpdatedAt = DateTime.Now.AddDays(-9),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 296,
                PaymentId = 148,
                ProductId = 65,
                ServiceId = 3,
                AmoutEmployee = 169,
                StartDate = DateTime.Now.AddDays(-46),
                EndDate = DateTime.Now.AddDays(-32),
                Cost = 15801500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-46),
                UpdatedAt = DateTime.Now.AddDays(-46),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 297,
                PaymentId = 149,
                ProductId = 200,
                ServiceId = 1,
                AmoutEmployee = 113,
                StartDate = DateTime.Now.AddDays(-130),
                EndDate = DateTime.Now.AddDays(-128),
                Cost = 46273500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-130),
                UpdatedAt = DateTime.Now.AddDays(-130),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 298,
                PaymentId = 149,
                ProductId = 37,
                ServiceId = 2,
                AmoutEmployee = 116,
                StartDate = DateTime.Now.AddDays(-26),
                EndDate = DateTime.Now.AddDays(-18),
                Cost = 9744000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-26),
                UpdatedAt = DateTime.Now.AddDays(-26),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 299,
                PaymentId = 150,
                ProductId = 62,
                ServiceId = 1,
                AmoutEmployee = 25,
                StartDate = DateTime.Now.AddDays(-138),
                EndDate = DateTime.Now.AddDays(-131),
                Cost = 6075000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-138),
                UpdatedAt = DateTime.Now.AddDays(-138),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 300,
                PaymentId = 150,
                ProductId = 86,
                ServiceId = 2,
                AmoutEmployee = 149,
                StartDate = DateTime.Now.AddDays(-103),
                EndDate = DateTime.Now.AddDays(-89),
                Cost = 74202000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-103),
                UpdatedAt = DateTime.Now.AddDays(-103),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 301,
                PaymentId = 151,
                ProductId = 33,
                ServiceId = 2,
                AmoutEmployee = 117,
                StartDate = DateTime.Now.AddDays(-8),
                EndDate = DateTime.Now.AddDays(2),
                Cost = 2106000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-8),
                UpdatedAt = DateTime.Now.AddDays(-8),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 302,
                PaymentId = 151,
                ProductId = 103,
                ServiceId = 1,
                AmoutEmployee = 79,
                StartDate = DateTime.Now.AddDays(-14),
                EndDate = DateTime.Now.AddDays(-3),
                Cost = 2488500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-14),
                UpdatedAt = DateTime.Now.AddDays(-14),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 303,
                PaymentId = 152,
                ProductId = 92,
                ServiceId = 1,
                AmoutEmployee = 93,
                StartDate = DateTime.Now.AddDays(-49),
                EndDate = DateTime.Now.AddDays(-35),
                Cost = 16740000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-49),
                UpdatedAt = DateTime.Now.AddDays(-49),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 304,
                PaymentId = 152,
                ProductId = 134,
                ServiceId = 2,
                AmoutEmployee = 170,
                StartDate = DateTime.Now.AddDays(-32),
                EndDate = DateTime.Now.AddDays(-23),
                Cost = 19380000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-32),
                UpdatedAt = DateTime.Now.AddDays(-32),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 305,
                PaymentId = 153,
                ProductId = 28,
                ServiceId = 2,
                AmoutEmployee = 143,
                StartDate = DateTime.Now.AddDays(-142),
                EndDate = DateTime.Now.AddDays(-138),
                Cost = 34320000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-142),
                UpdatedAt = DateTime.Now.AddDays(-142),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 306,
                PaymentId = 153,
                ProductId = 193,
                ServiceId = 2,
                AmoutEmployee = 174,
                StartDate = DateTime.Now.AddDays(-88),
                EndDate = DateTime.Now.AddDays(-87),
                Cost = 72036000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-88),
                UpdatedAt = DateTime.Now.AddDays(-88),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 307,
                PaymentId = 154,
                ProductId = 115,
                ServiceId = 1,
                AmoutEmployee = 132,
                StartDate = DateTime.Now.AddDays(-174),
                EndDate = DateTime.Now.AddDays(-162),
                Cost = 34452000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-174),
                UpdatedAt = DateTime.Now.AddDays(-174),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 308,
                PaymentId = 154,
                ProductId = 59,
                ServiceId = 2,
                AmoutEmployee = 121,
                StartDate = DateTime.Now.AddDays(-40),
                EndDate = DateTime.Now.AddDays(-26),
                Cost = 12342000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-40),
                UpdatedAt = DateTime.Now.AddDays(-40),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 309,
                PaymentId = 155,
                ProductId = 150,
                ServiceId = 1,
                AmoutEmployee = 80,
                StartDate = DateTime.Now.AddDays(-67),
                EndDate = DateTime.Now.AddDays(-60),
                Cost = 18000000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-67),
                UpdatedAt = DateTime.Now.AddDays(-67),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 310,
                PaymentId = 155,
                ProductId = 40,
                ServiceId = 1,
                AmoutEmployee = 50,
                StartDate = DateTime.Now.AddDays(-30),
                EndDate = DateTime.Now.AddDays(-23),
                Cost = 450000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-30),
                UpdatedAt = DateTime.Now.AddDays(-30),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 311,
                PaymentId = 156,
                ProductId = 134,
                ServiceId = 3,
                AmoutEmployee = 57,
                StartDate = DateTime.Now.AddDays(-161),
                EndDate = DateTime.Now.AddDays(-147),
                Cost = 38247000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-161),
                UpdatedAt = DateTime.Now.AddDays(-161),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 312,
                PaymentId = 156,
                ProductId = 102,
                ServiceId = 3,
                AmoutEmployee = 92,
                StartDate = DateTime.Now.AddDays(-179),
                EndDate = DateTime.Now.AddDays(-174),
                Cost = 66792000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-179),
                UpdatedAt = DateTime.Now.AddDays(-179),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 313,
                PaymentId = 157,
                ProductId = 129,
                ServiceId = 3,
                AmoutEmployee = 62,
                StartDate = DateTime.Now.AddDays(-150),
                EndDate = DateTime.Now.AddDays(-138),
                Cost = 23188000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-150),
                UpdatedAt = DateTime.Now.AddDays(-150),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 314,
                PaymentId = 157,
                ProductId = 18,
                ServiceId = 2,
                AmoutEmployee = 113,
                StartDate = DateTime.Now.AddDays(-155),
                EndDate = DateTime.Now.AddDays(-146),
                Cost = 29832000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-155),
                UpdatedAt = DateTime.Now.AddDays(-155),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 315,
                PaymentId = 158,
                ProductId = 131,
                ServiceId = 1,
                AmoutEmployee = 90,
                StartDate = DateTime.Now.AddDays(-36),
                EndDate = DateTime.Now.AddDays(-32),
                Cost = 11745000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-36),
                UpdatedAt = DateTime.Now.AddDays(-36),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 316,
                PaymentId = 158,
                ProductId = 167,
                ServiceId = 2,
                AmoutEmployee = 152,
                StartDate = DateTime.Now.AddDays(-17),
                EndDate = DateTime.Now.AddDays(-7),
                Cost = 5472000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-17),
                UpdatedAt = DateTime.Now.AddDays(-17),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 317,
                PaymentId = 159,
                ProductId = 109,
                ServiceId = 3,
                AmoutEmployee = 142,
                StartDate = DateTime.Now.AddDays(-147),
                EndDate = DateTime.Now.AddDays(-142),
                Cost = 50765000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-147),
                UpdatedAt = DateTime.Now.AddDays(-147),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 318,
                PaymentId = 159,
                ProductId = 132,
                ServiceId = 3,
                AmoutEmployee = 60,
                StartDate = DateTime.Now.AddDays(-68),
                EndDate = DateTime.Now.AddDays(-63),
                Cost = 16500000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-68),
                UpdatedAt = DateTime.Now.AddDays(-68),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 319,
                PaymentId = 160,
                ProductId = 39,
                ServiceId = 1,
                AmoutEmployee = 52,
                StartDate = DateTime.Now.AddDays(-33),
                EndDate = DateTime.Now.AddDays(-26),
                Cost = 5148000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-33),
                UpdatedAt = DateTime.Now.AddDays(-33),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 320,
                PaymentId = 160,
                ProductId = 16,
                ServiceId = 2,
                AmoutEmployee = 160,
                StartDate = DateTime.Now.AddDays(-12),
                EndDate = DateTime.Now.AddDays(-7),
                Cost = 4800000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-12),
                UpdatedAt = DateTime.Now.AddDays(-12),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 321,
                PaymentId = 161,
                ProductId = 113,
                ServiceId = 2,
                AmoutEmployee = 169,
                StartDate = DateTime.Now.AddDays(-81),
                EndDate = DateTime.Now.AddDays(-73),
                Cost = 62868000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-81),
                UpdatedAt = DateTime.Now.AddDays(-81),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 322,
                PaymentId = 161,
                ProductId = 41,
                ServiceId = 2,
                AmoutEmployee = 92,
                StartDate = DateTime.Now.AddDays(-72),
                EndDate = DateTime.Now.AddDays(-60),
                Cost = 23184000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-72),
                UpdatedAt = DateTime.Now.AddDays(-72),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 323,
                PaymentId = 162,
                ProductId = 159,
                ServiceId = 3,
                AmoutEmployee = 74,
                StartDate = DateTime.Now.AddDays(-115),
                EndDate = DateTime.Now.AddDays(-113),
                Cost = 21571000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-115),
                UpdatedAt = DateTime.Now.AddDays(-115),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 324,
                PaymentId = 162,
                ProductId = 66,
                ServiceId = 1,
                AmoutEmployee = 31,
                StartDate = DateTime.Now.AddDays(-29),
                EndDate = DateTime.Now.AddDays(-24),
                Cost = 2929500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-29),
                UpdatedAt = DateTime.Now.AddDays(-29),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 325,
                PaymentId = 163,
                ProductId = 72,
                ServiceId = 1,
                AmoutEmployee = 48,
                StartDate = DateTime.Now.AddDays(-24),
                EndDate = DateTime.Now.AddDays(-17),
                Cost = 4104000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-24),
                UpdatedAt = DateTime.Now.AddDays(-24),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 326,
                PaymentId = 163,
                ProductId = 87,
                ServiceId = 1,
                AmoutEmployee = 110,
                StartDate = DateTime.Now.AddDays(-100),
                EndDate = DateTime.Now.AddDays(-98),
                Cost = 9900000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-100),
                UpdatedAt = DateTime.Now.AddDays(-100),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 327,
                PaymentId = 164,
                ProductId = 146,
                ServiceId = 2,
                AmoutEmployee = 64,
                StartDate = DateTime.Now.AddDays(-52),
                EndDate = DateTime.Now.AddDays(-48),
                Cost = 14208000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-52),
                UpdatedAt = DateTime.Now.AddDays(-52),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 328,
                PaymentId = 164,
                ProductId = 61,
                ServiceId = 1,
                AmoutEmployee = 143,
                StartDate = DateTime.Now.AddDays(-126),
                EndDate = DateTime.Now.AddDays(-123),
                Cost = 41827500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-126),
                UpdatedAt = DateTime.Now.AddDays(-126),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 329,
                PaymentId = 165,
                ProductId = 169,
                ServiceId = 3,
                AmoutEmployee = 132,
                StartDate = DateTime.Now.AddDays(-70),
                EndDate = DateTime.Now.AddDays(-66),
                Cost = 21780000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-70),
                UpdatedAt = DateTime.Now.AddDays(-70),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 330,
                PaymentId = 165,
                ProductId = 135,
                ServiceId = 3,
                AmoutEmployee = 37,
                StartDate = DateTime.Now.AddDays(-168),
                EndDate = DateTime.Now.AddDays(-157),
                Cost = 26251500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-168),
                UpdatedAt = DateTime.Now.AddDays(-168),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 331,
                PaymentId = 166,
                ProductId = 172,
                ServiceId = 1,
                AmoutEmployee = 98,
                StartDate = DateTime.Now.AddDays(-9),
                EndDate = DateTime.Now.AddDays(4),
                Cost = 1323000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-9),
                UpdatedAt = DateTime.Now.AddDays(-9),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 332,
                PaymentId = 166,
                ProductId = 166,
                ServiceId = 2,
                AmoutEmployee = 174,
                StartDate = DateTime.Now.AddDays(-90),
                EndDate = DateTime.Now.AddDays(-80),
                Cost = 86652000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-90),
                UpdatedAt = DateTime.Now.AddDays(-90),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 333,
                PaymentId = 167,
                ProductId = 76,
                ServiceId = 3,
                AmoutEmployee = 81,
                StartDate = DateTime.Now.AddDays(-94),
                EndDate = DateTime.Now.AddDays(-86),
                Cost = 32076000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-94),
                UpdatedAt = DateTime.Now.AddDays(-94),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 334,
                PaymentId = 167,
                ProductId = 186,
                ServiceId = 3,
                AmoutEmployee = 198,
                StartDate = DateTime.Now.AddDays(-21),
                EndDate = DateTime.Now.AddDays(-10),
                Cost = 15246000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-21),
                UpdatedAt = DateTime.Now.AddDays(-21),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 335,
                PaymentId = 168,
                ProductId = 185,
                ServiceId = 2,
                AmoutEmployee = 31,
                StartDate = DateTime.Now.AddDays(-102),
                EndDate = DateTime.Now.AddDays(-89),
                Cost = 3348000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-102),
                UpdatedAt = DateTime.Now.AddDays(-102),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 336,
                PaymentId = 168,
                ProductId = 173,
                ServiceId = 2,
                AmoutEmployee = 49,
                StartDate = DateTime.Now.AddDays(-63),
                EndDate = DateTime.Now.AddDays(-50),
                Cost = 15582000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-63),
                UpdatedAt = DateTime.Now.AddDays(-63),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 337,
                PaymentId = 169,
                ProductId = 72,
                ServiceId = 1,
                AmoutEmployee = 134,
                StartDate = DateTime.Now.AddDays(-79),
                EndDate = DateTime.Now.AddDays(-69),
                Cost = 40401000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-79),
                UpdatedAt = DateTime.Now.AddDays(-79),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 338,
                PaymentId = 169,
                ProductId = 64,
                ServiceId = 3,
                AmoutEmployee = 173,
                StartDate = DateTime.Now.AddDays(-124),
                EndDate = DateTime.Now.AddDays(-122),
                Cost = 98004500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-124),
                UpdatedAt = DateTime.Now.AddDays(-124),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 339,
                PaymentId = 170,
                ProductId = 64,
                ServiceId = 1,
                AmoutEmployee = 104,
                StartDate = DateTime.Now.AddDays(-129),
                EndDate = DateTime.Now.AddDays(-121),
                Cost = 53352000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-129),
                UpdatedAt = DateTime.Now.AddDays(-129),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 340,
                PaymentId = 170,
                ProductId = 69,
                ServiceId = 3,
                AmoutEmployee = 86,
                StartDate = DateTime.Now.AddDays(-195),
                EndDate = DateTime.Now.AddDays(-188),
                Cost = 42570000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-195),
                UpdatedAt = DateTime.Now.AddDays(-195),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 341,
                PaymentId = 171,
                ProductId = 83,
                ServiceId = 2,
                AmoutEmployee = 158,
                StartDate = DateTime.Now.AddDays(-144),
                EndDate = DateTime.Now.AddDays(-139),
                Cost = 78684000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-144),
                UpdatedAt = DateTime.Now.AddDays(-144),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 342,
                PaymentId = 171,
                ProductId = 178,
                ServiceId = 3,
                AmoutEmployee = 138,
                StartDate = DateTime.Now.AddDays(-43),
                EndDate = DateTime.Now.AddDays(-33),
                Cost = 3036000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-43),
                UpdatedAt = DateTime.Now.AddDays(-43),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 343,
                PaymentId = 172,
                ProductId = 189,
                ServiceId = 2,
                AmoutEmployee = 98,
                StartDate = DateTime.Now.AddDays(-147),
                EndDate = DateTime.Now.AddDays(-145),
                Cost = 62916000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-147),
                UpdatedAt = DateTime.Now.AddDays(-147),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 344,
                PaymentId = 172,
                ProductId = 78,
                ServiceId = 3,
                AmoutEmployee = 151,
                StartDate = DateTime.Now.AddDays(-192),
                EndDate = DateTime.Now.AddDays(-191),
                Cost = 72253500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-192),
                UpdatedAt = DateTime.Now.AddDays(-192),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 345,
                PaymentId = 173,
                ProductId = 88,
                ServiceId = 2,
                AmoutEmployee = 82,
                StartDate = DateTime.Now.AddDays(-167),
                EndDate = DateTime.Now.AddDays(-158),
                Cost = 60024000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-167),
                UpdatedAt = DateTime.Now.AddDays(-167),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 346,
                PaymentId = 173,
                ProductId = 171,
                ServiceId = 2,
                AmoutEmployee = 39,
                StartDate = DateTime.Now.AddDays(-131),
                EndDate = DateTime.Now.AddDays(-122),
                Cost = 11934000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-131),
                UpdatedAt = DateTime.Now.AddDays(-131),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 347,
                PaymentId = 174,
                ProductId = 74,
                ServiceId = 3,
                AmoutEmployee = 54,
                StartDate = DateTime.Now.AddDays(-121),
                EndDate = DateTime.Now.AddDays(-106),
                Cost = 13068000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-121),
                UpdatedAt = DateTime.Now.AddDays(-121),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 348,
                PaymentId = 174,
                ProductId = 176,
                ServiceId = 3,
                AmoutEmployee = 138,
                StartDate = DateTime.Now.AddDays(-99),
                EndDate = DateTime.Now.AddDays(-85),
                Cost = 42504000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-99),
                UpdatedAt = DateTime.Now.AddDays(-99),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 349,
                PaymentId = 175,
                ProductId = 12,
                ServiceId = 2,
                AmoutEmployee = 156,
                StartDate = DateTime.Now.AddDays(-177),
                EndDate = DateTime.Now.AddDays(-169),
                Cost = 26208000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-177),
                UpdatedAt = DateTime.Now.AddDays(-177),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 350,
                PaymentId = 175,
                ProductId = 117,
                ServiceId = 1,
                AmoutEmployee = 134,
                StartDate = DateTime.Now.AddDays(-143),
                EndDate = DateTime.Now.AddDays(-128),
                Cost = 42813000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-143),
                UpdatedAt = DateTime.Now.AddDays(-143),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 351,
                PaymentId = 176,
                ProductId = 193,
                ServiceId = 2,
                AmoutEmployee = 168,
                StartDate = DateTime.Now.AddDays(-177),
                EndDate = DateTime.Now.AddDays(-173),
                Cost = 97776000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-177),
                UpdatedAt = DateTime.Now.AddDays(-177),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 352,
                PaymentId = 176,
                ProductId = 40,
                ServiceId = 2,
                AmoutEmployee = 40,
                StartDate = DateTime.Now.AddDays(-176),
                EndDate = DateTime.Now.AddDays(-168),
                Cost = 27120000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-176),
                UpdatedAt = DateTime.Now.AddDays(-176),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 353,
                PaymentId = 177,
                ProductId = 42,
                ServiceId = 3,
                AmoutEmployee = 163,
                StartDate = DateTime.Now.AddDays(-152),
                EndDate = DateTime.Now.AddDays(-144),
                Cost = 57376000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-152),
                UpdatedAt = DateTime.Now.AddDays(-152),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 354,
                PaymentId = 177,
                ProductId = 23,
                ServiceId = 3,
                AmoutEmployee = 171,
                StartDate = DateTime.Now.AddDays(-18),
                EndDate = DateTime.Now.AddDays(-11),
                Cost = 940500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-18),
                UpdatedAt = DateTime.Now.AddDays(-18),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 355,
                PaymentId = 178,
                ProductId = 95,
                ServiceId = 2,
                AmoutEmployee = 119,
                StartDate = DateTime.Now.AddDays(-172),
                EndDate = DateTime.Now.AddDays(-162),
                Cost = 17850000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-172),
                UpdatedAt = DateTime.Now.AddDays(-172),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 356,
                PaymentId = 178,
                ProductId = 178,
                ServiceId = 2,
                AmoutEmployee = 199,
                StartDate = DateTime.Now.AddDays(-159),
                EndDate = DateTime.Now.AddDays(-147),
                Cost = 122982000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-159),
                UpdatedAt = DateTime.Now.AddDays(-159),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 357,
                PaymentId = 179,
                ProductId = 199,
                ServiceId = 2,
                AmoutEmployee = 31,
                StartDate = DateTime.Now.AddDays(-94),
                EndDate = DateTime.Now.AddDays(-87),
                Cost = 14508000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-94),
                UpdatedAt = DateTime.Now.AddDays(-94),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 358,
                PaymentId = 179,
                ProductId = 178,
                ServiceId = 3,
                AmoutEmployee = 141,
                StartDate = DateTime.Now.AddDays(-38),
                EndDate = DateTime.Now.AddDays(-32),
                Cost = 1551000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-38),
                UpdatedAt = DateTime.Now.AddDays(-38),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 359,
                PaymentId = 180,
                ProductId = 17,
                ServiceId = 1,
                AmoutEmployee = 129,
                StartDate = DateTime.Now.AddDays(-9),
                EndDate = DateTime.Now.AddDays(4),
                Cost = 580500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-9),
                UpdatedAt = DateTime.Now.AddDays(-9),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 360,
                PaymentId = 180,
                ProductId = 96,
                ServiceId = 3,
                AmoutEmployee = 111,
                StartDate = DateTime.Now.AddDays(-96),
                EndDate = DateTime.Now.AddDays(-93),
                Cost = 23199000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-96),
                UpdatedAt = DateTime.Now.AddDays(-96),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 361,
                PaymentId = 181,
                ProductId = 4,
                ServiceId = 3,
                AmoutEmployee = 87,
                StartDate = DateTime.Now.AddDays(-107),
                EndDate = DateTime.Now.AddDays(-102),
                Cost = 33495000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-107),
                UpdatedAt = DateTime.Now.AddDays(-107),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 362,
                PaymentId = 181,
                ProductId = 77,
                ServiceId = 1,
                AmoutEmployee = 114,
                StartDate = DateTime.Now.AddDays(-87),
                EndDate = DateTime.Now.AddDays(-84),
                Cost = 22572000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-87),
                UpdatedAt = DateTime.Now.AddDays(-87),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 363,
                PaymentId = 182,
                ProductId = 148,
                ServiceId = 2,
                AmoutEmployee = 107,
                StartDate = DateTime.Now.AddDays(-94),
                EndDate = DateTime.Now.AddDays(-86),
                Cost = 4494000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-94),
                UpdatedAt = DateTime.Now.AddDays(-94),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 364,
                PaymentId = 182,
                ProductId = 28,
                ServiceId = 3,
                AmoutEmployee = 144,
                StartDate = DateTime.Now.AddDays(-62),
                EndDate = DateTime.Now.AddDays(-47),
                Cost = 40392000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-62),
                UpdatedAt = DateTime.Now.AddDays(-62),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 365,
                PaymentId = 183,
                ProductId = 8,
                ServiceId = 1,
                AmoutEmployee = 74,
                StartDate = DateTime.Now.AddDays(-65),
                EndDate = DateTime.Now.AddDays(-59),
                Cost = 18981000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-65),
                UpdatedAt = DateTime.Now.AddDays(-65),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 366,
                PaymentId = 183,
                ProductId = 156,
                ServiceId = 1,
                AmoutEmployee = 147,
                StartDate = DateTime.Now.AddDays(-144),
                EndDate = DateTime.Now.AddDays(-131),
                Cost = 78057000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-144),
                UpdatedAt = DateTime.Now.AddDays(-144),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 367,
                PaymentId = 184,
                ProductId = 35,
                ServiceId = 3,
                AmoutEmployee = 55,
                StartDate = DateTime.Now.AddDays(-183),
                EndDate = DateTime.Now.AddDays(-170),
                Cost = 7562500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-183),
                UpdatedAt = DateTime.Now.AddDays(-183),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 368,
                PaymentId = 184,
                ProductId = 175,
                ServiceId = 1,
                AmoutEmployee = 167,
                StartDate = DateTime.Now.AddDays(-84),
                EndDate = DateTime.Now.AddDays(-71),
                Cost = 48847500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-84),
                UpdatedAt = DateTime.Now.AddDays(-84),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 369,
                PaymentId = 185,
                ProductId = 163,
                ServiceId = 2,
                AmoutEmployee = 182,
                StartDate = DateTime.Now.AddDays(-61),
                EndDate = DateTime.Now.AddDays(-54),
                Cost = 25116000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-61),
                UpdatedAt = DateTime.Now.AddDays(-61),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 370,
                PaymentId = 185,
                ProductId = 90,
                ServiceId = 2,
                AmoutEmployee = 199,
                StartDate = DateTime.Now.AddDays(-103),
                EndDate = DateTime.Now.AddDays(-89),
                Cost = 93132000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-103),
                UpdatedAt = DateTime.Now.AddDays(-103),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 371,
                PaymentId = 186,
                ProductId = 196,
                ServiceId = 1,
                AmoutEmployee = 57,
                StartDate = DateTime.Now.AddDays(-142),
                EndDate = DateTime.Now.AddDays(-137),
                Cost = 23854500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-142),
                UpdatedAt = DateTime.Now.AddDays(-142),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 372,
                PaymentId = 186,
                ProductId = 18,
                ServiceId = 2,
                AmoutEmployee = 106,
                StartDate = DateTime.Now.AddDays(-165),
                EndDate = DateTime.Now.AddDays(-157),
                Cost = 636000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-165),
                UpdatedAt = DateTime.Now.AddDays(-165),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 373,
                PaymentId = 187,
                ProductId = 157,
                ServiceId = 2,
                AmoutEmployee = 101,
                StartDate = DateTime.Now.AddDays(-158),
                EndDate = DateTime.Now.AddDays(-151),
                Cost = 83628000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-158),
                UpdatedAt = DateTime.Now.AddDays(-158),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 374,
                PaymentId = 187,
                ProductId = 184,
                ServiceId = 3,
                AmoutEmployee = 39,
                StartDate = DateTime.Now.AddDays(-164),
                EndDate = DateTime.Now.AddDays(-158),
                Cost = 19305000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-164),
                UpdatedAt = DateTime.Now.AddDays(-164),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 375,
                PaymentId = 188,
                ProductId = 124,
                ServiceId = 3,
                AmoutEmployee = 84,
                StartDate = DateTime.Now.AddDays(-23),
                EndDate = DateTime.Now.AddDays(-11),
                Cost = 6930000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-23),
                UpdatedAt = DateTime.Now.AddDays(-23),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 376,
                PaymentId = 188,
                ProductId = 152,
                ServiceId = 1,
                AmoutEmployee = 42,
                StartDate = DateTime.Now.AddDays(-117),
                EndDate = DateTime.Now.AddDays(-114),
                Cost = 17766000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-117),
                UpdatedAt = DateTime.Now.AddDays(-117),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 377,
                PaymentId = 189,
                ProductId = 56,
                ServiceId = 3,
                AmoutEmployee = 30,
                StartDate = DateTime.Now.AddDays(-149),
                EndDate = DateTime.Now.AddDays(-144),
                Cost = 6105000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-149),
                UpdatedAt = DateTime.Now.AddDays(-149),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 378,
                PaymentId = 189,
                ProductId = 53,
                ServiceId = 1,
                AmoutEmployee = 147,
                StartDate = DateTime.Now.AddDays(-200),
                EndDate = DateTime.Now.AddDays(-186),
                Cost = 76734000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-200),
                UpdatedAt = DateTime.Now.AddDays(-200),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 379,
                PaymentId = 190,
                ProductId = 83,
                ServiceId = 3,
                AmoutEmployee = 169,
                StartDate = DateTime.Now.AddDays(-179),
                EndDate = DateTime.Now.AddDays(-173),
                Cost = 43686500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-179),
                UpdatedAt = DateTime.Now.AddDays(-179),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 380,
                PaymentId = 190,
                ProductId = 50,
                ServiceId = 2,
                AmoutEmployee = 125,
                StartDate = DateTime.Now.AddDays(-143),
                EndDate = DateTime.Now.AddDays(-141),
                Cost = 3000000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-143),
                UpdatedAt = DateTime.Now.AddDays(-143),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 381,
                PaymentId = 191,
                ProductId = 161,
                ServiceId = 1,
                AmoutEmployee = 146,
                StartDate = DateTime.Now.AddDays(-73),
                EndDate = DateTime.Now.AddDays(-68),
                Cost = 2628000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-73),
                UpdatedAt = DateTime.Now.AddDays(-73),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 382,
                PaymentId = 191,
                ProductId = 73,
                ServiceId = 2,
                AmoutEmployee = 49,
                StartDate = DateTime.Now.AddDays(-12),
                EndDate = DateTime.Now.AddDays(-4),
                Cost = 588000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-12),
                UpdatedAt = DateTime.Now.AddDays(-12),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 383,
                PaymentId = 192,
                ProductId = 7,
                ServiceId = 1,
                AmoutEmployee = 64,
                StartDate = DateTime.Now.AddDays(-62),
                EndDate = DateTime.Now.AddDays(-52),
                Cost = 7776000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-62),
                UpdatedAt = DateTime.Now.AddDays(-62),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 384,
                PaymentId = 192,
                ProductId = 162,
                ServiceId = 3,
                AmoutEmployee = 188,
                StartDate = DateTime.Now.AddDays(-48),
                EndDate = DateTime.Now.AddDays(-42),
                Cost = 4136000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-48),
                UpdatedAt = DateTime.Now.AddDays(-48),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 385,
                PaymentId = 193,
                ProductId = 200,
                ServiceId = 3,
                AmoutEmployee = 188,
                StartDate = DateTime.Now.AddDays(-155),
                EndDate = DateTime.Now.AddDays(-152),
                Cost = 142692000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-155),
                UpdatedAt = DateTime.Now.AddDays(-155),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 386,
                PaymentId = 193,
                ProductId = 45,
                ServiceId = 1,
                AmoutEmployee = 72,
                StartDate = DateTime.Now.AddDays(-121),
                EndDate = DateTime.Now.AddDays(-114),
                Cost = 13932000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-121),
                UpdatedAt = DateTime.Now.AddDays(-121),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 387,
                PaymentId = 194,
                ProductId = 53,
                ServiceId = 2,
                AmoutEmployee = 163,
                StartDate = DateTime.Now.AddDays(-196),
                EndDate = DateTime.Now.AddDays(-190),
                Cost = 168216000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-196),
                UpdatedAt = DateTime.Now.AddDays(-196),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 388,
                PaymentId = 194,
                ProductId = 19,
                ServiceId = 3,
                AmoutEmployee = 138,
                StartDate = DateTime.Now.AddDays(-48),
                EndDate = DateTime.Now.AddDays(-40),
                Cost = 6831000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-48),
                UpdatedAt = DateTime.Now.AddDays(-48),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 389,
                PaymentId = 195,
                ProductId = 175,
                ServiceId = 1,
                AmoutEmployee = 127,
                StartDate = DateTime.Now.AddDays(-60),
                EndDate = DateTime.Now.AddDays(-52),
                Cost = 23431500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-60),
                UpdatedAt = DateTime.Now.AddDays(-60),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 390,
                PaymentId = 195,
                ProductId = 114,
                ServiceId = 3,
                AmoutEmployee = 172,
                StartDate = DateTime.Now.AddDays(-102),
                EndDate = DateTime.Now.AddDays(-96),
                Cost = 57706000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-102),
                UpdatedAt = DateTime.Now.AddDays(-102),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 391,
                PaymentId = 196,
                ProductId = 76,
                ServiceId = 2,
                AmoutEmployee = 172,
                StartDate = DateTime.Now.AddDays(-89),
                EndDate = DateTime.Now.AddDays(-85),
                Cost = 18576000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-89),
                UpdatedAt = DateTime.Now.AddDays(-89),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 392,
                PaymentId = 196,
                ProductId = 111,
                ServiceId = 3,
                AmoutEmployee = 164,
                StartDate = DateTime.Now.AddDays(-180),
                EndDate = DateTime.Now.AddDays(-168),
                Cost = 21648000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-180),
                UpdatedAt = DateTime.Now.AddDays(-180),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 393,
                PaymentId = 197,
                ProductId = 10,
                ServiceId = 2,
                AmoutEmployee = 110,
                StartDate = DateTime.Now.AddDays(-85),
                EndDate = DateTime.Now.AddDays(-76),
                Cost = 51480000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-85),
                UpdatedAt = DateTime.Now.AddDays(-85),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 394,
                PaymentId = 197,
                ProductId = 98,
                ServiceId = 1,
                AmoutEmployee = 34,
                StartDate = DateTime.Now.AddDays(-182),
                EndDate = DateTime.Now.AddDays(-178),
                Cost = 24633000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-182),
                UpdatedAt = DateTime.Now.AddDays(-182),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 395,
                PaymentId = 198,
                ProductId = 152,
                ServiceId = 2,
                AmoutEmployee = 185,
                StartDate = DateTime.Now.AddDays(-143),
                EndDate = DateTime.Now.AddDays(-132),
                Cost = 65490000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-143),
                UpdatedAt = DateTime.Now.AddDays(-143),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 396,
                PaymentId = 198,
                ProductId = 111,
                ServiceId = 3,
                AmoutEmployee = 52,
                StartDate = DateTime.Now.AddDays(-34),
                EndDate = DateTime.Now.AddDays(-21),
                Cost = 6578000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-34),
                UpdatedAt = DateTime.Now.AddDays(-34),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 397,
                PaymentId = 199,
                ProductId = 127,
                ServiceId = 2,
                AmoutEmployee = 80,
                StartDate = DateTime.Now.AddDays(-18),
                EndDate = DateTime.Now.AddDays(-17),
                Cost = 4800000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-18),
                UpdatedAt = DateTime.Now.AddDays(-18),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 398,
                PaymentId = 199,
                ProductId = 30,
                ServiceId = 2,
                AmoutEmployee = 161,
                StartDate = DateTime.Now.AddDays(-117),
                EndDate = DateTime.Now.AddDays(-106),
                Cost = 14490000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-117),
                UpdatedAt = DateTime.Now.AddDays(-117),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 399,
                PaymentId = 200,
                ProductId = 7,
                ServiceId = 1,
                AmoutEmployee = 35,
                StartDate = DateTime.Now.AddDays(-29),
                EndDate = DateTime.Now.AddDays(-16),
                Cost = 472500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-29),
                UpdatedAt = DateTime.Now.AddDays(-29),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 400,
                PaymentId = 200,
                ProductId = 8,
                ServiceId = 3,
                AmoutEmployee = 109,
                StartDate = DateTime.Now.AddDays(-157),
                EndDate = DateTime.Now.AddDays(-143),
                Cost = 86328000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-157),
                UpdatedAt = DateTime.Now.AddDays(-157),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 401,
                PaymentId = 201,
                ProductId = 150,
                ServiceId = 1,
                AmoutEmployee = 36,
                StartDate = DateTime.Now.AddDays(-136),
                EndDate = DateTime.Now.AddDays(-133),
                Cost = 17982000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-136),
                UpdatedAt = DateTime.Now.AddDays(-136),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 402,
                PaymentId = 201,
                ProductId = 188,
                ServiceId = 3,
                AmoutEmployee = 100,
                StartDate = DateTime.Now.AddDays(-197),
                EndDate = DateTime.Now.AddDays(-192),
                Cost = 99000000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-197),
                UpdatedAt = DateTime.Now.AddDays(-197),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 403,
                PaymentId = 202,
                ProductId = 60,
                ServiceId = 2,
                AmoutEmployee = 100,
                StartDate = DateTime.Now.AddDays(-148),
                EndDate = DateTime.Now.AddDays(-140),
                Cost = 600000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-148),
                UpdatedAt = DateTime.Now.AddDays(-148),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 404,
                PaymentId = 202,
                ProductId = 30,
                ServiceId = 1,
                AmoutEmployee = 48,
                StartDate = DateTime.Now.AddDays(-178),
                EndDate = DateTime.Now.AddDays(-177),
                Cost = 12960000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-178),
                UpdatedAt = DateTime.Now.AddDays(-178),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 405,
                PaymentId = 203,
                ProductId = 123,
                ServiceId = 1,
                AmoutEmployee = 109,
                StartDate = DateTime.Now.AddDays(-159),
                EndDate = DateTime.Now.AddDays(-149),
                Cost = 14224500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-159),
                UpdatedAt = DateTime.Now.AddDays(-159),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 406,
                PaymentId = 203,
                ProductId = 41,
                ServiceId = 1,
                AmoutEmployee = 174,
                StartDate = DateTime.Now.AddDays(-36),
                EndDate = DateTime.Now.AddDays(-30),
                Cost = 14094000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-36),
                UpdatedAt = DateTime.Now.AddDays(-36),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 407,
                PaymentId = 204,
                ProductId = 161,
                ServiceId = 3,
                AmoutEmployee = 118,
                StartDate = DateTime.Now.AddDays(-94),
                EndDate = DateTime.Now.AddDays(-85),
                Cost = 27258000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-94),
                UpdatedAt = DateTime.Now.AddDays(-94),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 408,
                PaymentId = 204,
                ProductId = 158,
                ServiceId = 2,
                AmoutEmployee = 65,
                StartDate = DateTime.Now.AddDays(-131),
                EndDate = DateTime.Now.AddDays(-116),
                Cost = 20670000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-131),
                UpdatedAt = DateTime.Now.AddDays(-131),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 409,
                PaymentId = 205,
                ProductId = 92,
                ServiceId = 2,
                AmoutEmployee = 43,
                StartDate = DateTime.Now.AddDays(-149),
                EndDate = DateTime.Now.AddDays(-146),
                Cost = 11868000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-149),
                UpdatedAt = DateTime.Now.AddDays(-149),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 410,
                PaymentId = 205,
                ProductId = 109,
                ServiceId = 2,
                AmoutEmployee = 152,
                StartDate = DateTime.Now.AddDays(-109),
                EndDate = DateTime.Now.AddDays(-105),
                Cost = 89376000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-109),
                UpdatedAt = DateTime.Now.AddDays(-109),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 411,
                PaymentId = 206,
                ProductId = 156,
                ServiceId = 3,
                AmoutEmployee = 86,
                StartDate = DateTime.Now.AddDays(-49),
                EndDate = DateTime.Now.AddDays(-38),
                Cost = 12771000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-49),
                UpdatedAt = DateTime.Now.AddDays(-49),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 412,
                PaymentId = 206,
                ProductId = 39,
                ServiceId = 3,
                AmoutEmployee = 80,
                StartDate = DateTime.Now.AddDays(-117),
                EndDate = DateTime.Now.AddDays(-111),
                Cost = 47520000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-117),
                UpdatedAt = DateTime.Now.AddDays(-117),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 413,
                PaymentId = 207,
                ProductId = 128,
                ServiceId = 3,
                AmoutEmployee = 146,
                StartDate = DateTime.Now.AddDays(-49),
                EndDate = DateTime.Now.AddDays(-46),
                Cost = 19272000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-49),
                UpdatedAt = DateTime.Now.AddDays(-49),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 414,
                PaymentId = 207,
                ProductId = 15,
                ServiceId = 1,
                AmoutEmployee = 65,
                StartDate = DateTime.Now.AddDays(-23),
                EndDate = DateTime.Now.AddDays(-17),
                Cost = 2340000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-23),
                UpdatedAt = DateTime.Now.AddDays(-23),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 415,
                PaymentId = 208,
                ProductId = 180,
                ServiceId = 3,
                AmoutEmployee = 180,
                StartDate = DateTime.Now.AddDays(-109),
                EndDate = DateTime.Now.AddDays(-108),
                Cost = 64350000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-109),
                UpdatedAt = DateTime.Now.AddDays(-109),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 416,
                PaymentId = 208,
                ProductId = 144,
                ServiceId = 2,
                AmoutEmployee = 181,
                StartDate = DateTime.Now.AddDays(-52),
                EndDate = DateTime.Now.AddDays(-43),
                Cost = 10860000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-52),
                UpdatedAt = DateTime.Now.AddDays(-52),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 417,
                PaymentId = 209,
                ProductId = 133,
                ServiceId = 3,
                AmoutEmployee = 58,
                StartDate = DateTime.Now.AddDays(-193),
                EndDate = DateTime.Now.AddDays(-187),
                Cost = 23606000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-193),
                UpdatedAt = DateTime.Now.AddDays(-193),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 418,
                PaymentId = 209,
                ProductId = 70,
                ServiceId = 1,
                AmoutEmployee = 71,
                StartDate = DateTime.Now.AddDays(-139),
                EndDate = DateTime.Now.AddDays(-134),
                Cost = 6709500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-139),
                UpdatedAt = DateTime.Now.AddDays(-139),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 419,
                PaymentId = 210,
                ProductId = 70,
                ServiceId = 3,
                AmoutEmployee = 158,
                StartDate = DateTime.Now.AddDays(-80),
                EndDate = DateTime.Now.AddDays(-66),
                Cost = 36498000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-80),
                UpdatedAt = DateTime.Now.AddDays(-80),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 420,
                PaymentId = 210,
                ProductId = 161,
                ServiceId = 2,
                AmoutEmployee = 193,
                StartDate = DateTime.Now.AddDays(-142),
                EndDate = DateTime.Now.AddDays(-135),
                Cost = 142434000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-142),
                UpdatedAt = DateTime.Now.AddDays(-142),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 421,
                PaymentId = 211,
                ProductId = 192,
                ServiceId = 3,
                AmoutEmployee = 173,
                StartDate = DateTime.Now.AddDays(-177),
                EndDate = DateTime.Now.AddDays(-169),
                Cost = 135113000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-177),
                UpdatedAt = DateTime.Now.AddDays(-177),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 422,
                PaymentId = 211,
                ProductId = 164,
                ServiceId = 1,
                AmoutEmployee = 130,
                StartDate = DateTime.Now.AddDays(-66),
                EndDate = DateTime.Now.AddDays(-53),
                Cost = 19890000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-66),
                UpdatedAt = DateTime.Now.AddDays(-66),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 423,
                PaymentId = 212,
                ProductId = 61,
                ServiceId = 3,
                AmoutEmployee = 45,
                StartDate = DateTime.Now.AddDays(-44),
                EndDate = DateTime.Now.AddDays(-32),
                Cost = 6435000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-44),
                UpdatedAt = DateTime.Now.AddDays(-44),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 424,
                PaymentId = 212,
                ProductId = 133,
                ServiceId = 1,
                AmoutEmployee = 126,
                StartDate = DateTime.Now.AddDays(-75),
                EndDate = DateTime.Now.AddDays(-69),
                Cost = 3402000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-75),
                UpdatedAt = DateTime.Now.AddDays(-75),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 425,
                PaymentId = 213,
                ProductId = 154,
                ServiceId = 3,
                AmoutEmployee = 114,
                StartDate = DateTime.Now.AddDays(-54),
                EndDate = DateTime.Now.AddDays(-45),
                Cost = 20064000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-54),
                UpdatedAt = DateTime.Now.AddDays(-54),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 426,
                PaymentId = 213,
                ProductId = 62,
                ServiceId = 1,
                AmoutEmployee = 154,
                StartDate = DateTime.Now.AddDays(-131),
                EndDate = DateTime.Now.AddDays(-117),
                Cost = 47817000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-131),
                UpdatedAt = DateTime.Now.AddDays(-131),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 427,
                PaymentId = 214,
                ProductId = 13,
                ServiceId = 3,
                AmoutEmployee = 39,
                StartDate = DateTime.Now.AddDays(-109),
                EndDate = DateTime.Now.AddDays(-98),
                Cost = 214500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-109),
                UpdatedAt = DateTime.Now.AddDays(-109),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 428,
                PaymentId = 214,
                ProductId = 106,
                ServiceId = 1,
                AmoutEmployee = 199,
                StartDate = DateTime.Now.AddDays(-169),
                EndDate = DateTime.Now.AddDays(-167),
                Cost = 18805500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-169),
                UpdatedAt = DateTime.Now.AddDays(-169),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 429,
                PaymentId = 215,
                ProductId = 121,
                ServiceId = 1,
                AmoutEmployee = 197,
                StartDate = DateTime.Now.AddDays(-169),
                EndDate = DateTime.Now.AddDays(-165),
                Cost = 40779000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-169),
                UpdatedAt = DateTime.Now.AddDays(-169),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 430,
                PaymentId = 215,
                ProductId = 175,
                ServiceId = 1,
                AmoutEmployee = 140,
                StartDate = DateTime.Now.AddDays(-35),
                EndDate = DateTime.Now.AddDays(-29),
                Cost = 4410000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-35),
                UpdatedAt = DateTime.Now.AddDays(-35),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 431,
                PaymentId = 216,
                ProductId = 37,
                ServiceId = 2,
                AmoutEmployee = 64,
                StartDate = DateTime.Now.AddDays(-98),
                EndDate = DateTime.Now.AddDays(-85),
                Cost = 28416000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-98),
                UpdatedAt = DateTime.Now.AddDays(-98),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 432,
                PaymentId = 216,
                ProductId = 128,
                ServiceId = 2,
                AmoutEmployee = 110,
                StartDate = DateTime.Now.AddDays(-57),
                EndDate = DateTime.Now.AddDays(-53),
                Cost = 26400000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-57),
                UpdatedAt = DateTime.Now.AddDays(-57),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 433,
                PaymentId = 217,
                ProductId = 59,
                ServiceId = 3,
                AmoutEmployee = 146,
                StartDate = DateTime.Now.AddDays(-53),
                EndDate = DateTime.Now.AddDays(-46),
                Cost = 11242000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-53),
                UpdatedAt = DateTime.Now.AddDays(-53),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 434,
                PaymentId = 217,
                ProductId = 133,
                ServiceId = 1,
                AmoutEmployee = 30,
                StartDate = DateTime.Now.AddDays(-140),
                EndDate = DateTime.Now.AddDays(-138),
                Cost = 1080000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-140),
                UpdatedAt = DateTime.Now.AddDays(-140),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 435,
                PaymentId = 218,
                ProductId = 49,
                ServiceId = 2,
                AmoutEmployee = 85,
                StartDate = DateTime.Now.AddDays(-23),
                EndDate = DateTime.Now.AddDays(-13),
                Cost = 1020000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-23),
                UpdatedAt = DateTime.Now.AddDays(-23),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 436,
                PaymentId = 218,
                ProductId = 155,
                ServiceId = 3,
                AmoutEmployee = 66,
                StartDate = DateTime.Now.AddDays(-174),
                EndDate = DateTime.Now.AddDays(-169),
                Cost = 53361000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-174),
                UpdatedAt = DateTime.Now.AddDays(-174),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 437,
                PaymentId = 219,
                ProductId = 180,
                ServiceId = 3,
                AmoutEmployee = 30,
                StartDate = DateTime.Now.AddDays(-102),
                EndDate = DateTime.Now.AddDays(-88),
                Cost = 8580000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-102),
                UpdatedAt = DateTime.Now.AddDays(-102),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 438,
                PaymentId = 219,
                ProductId = 118,
                ServiceId = 3,
                AmoutEmployee = 99,
                StartDate = DateTime.Now.AddDays(-49),
                EndDate = DateTime.Now.AddDays(-43),
                Cost = 12523500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-49),
                UpdatedAt = DateTime.Now.AddDays(-49),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 439,
                PaymentId = 220,
                ProductId = 37,
                ServiceId = 3,
                AmoutEmployee = 79,
                StartDate = DateTime.Now.AddDays(-62),
                EndDate = DateTime.Now.AddDays(-59),
                Cost = 20421500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-62),
                UpdatedAt = DateTime.Now.AddDays(-62),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 440,
                PaymentId = 220,
                ProductId = 22,
                ServiceId = 1,
                AmoutEmployee = 170,
                StartDate = DateTime.Now.AddDays(-174),
                EndDate = DateTime.Now.AddDays(-160),
                Cost = 103275000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-174),
                UpdatedAt = DateTime.Now.AddDays(-174),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 441,
                PaymentId = 221,
                ProductId = 77,
                ServiceId = 3,
                AmoutEmployee = 116,
                StartDate = DateTime.Now.AddDays(-189),
                EndDate = DateTime.Now.AddDays(-187),
                Cost = 81026000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-189),
                UpdatedAt = DateTime.Now.AddDays(-189),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 442,
                PaymentId = 221,
                ProductId = 136,
                ServiceId = 2,
                AmoutEmployee = 44,
                StartDate = DateTime.Now.AddDays(-40),
                EndDate = DateTime.Now.AddDays(-35),
                Cost = 5808000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-40),
                UpdatedAt = DateTime.Now.AddDays(-40),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 443,
                PaymentId = 222,
                ProductId = 96,
                ServiceId = 1,
                AmoutEmployee = 26,
                StartDate = DateTime.Now.AddDays(-16),
                EndDate = DateTime.Now.AddDays(-6),
                Cost = 1053000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-16),
                UpdatedAt = DateTime.Now.AddDays(-16),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 444,
                PaymentId = 222,
                ProductId = 103,
                ServiceId = 1,
                AmoutEmployee = 173,
                StartDate = DateTime.Now.AddDays(-43),
                EndDate = DateTime.Now.AddDays(-40),
                Cost = 14013000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-43),
                UpdatedAt = DateTime.Now.AddDays(-43),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 445,
                PaymentId = 223,
                ProductId = 17,
                ServiceId = 2,
                AmoutEmployee = 169,
                StartDate = DateTime.Now.AddDays(-9),
                EndDate = DateTime.Now.AddDays(-7),
                Cost = 2028000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-9),
                UpdatedAt = DateTime.Now.AddDays(-9),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 446,
                PaymentId = 223,
                ProductId = 130,
                ServiceId = 3,
                AmoutEmployee = 176,
                StartDate = DateTime.Now.AddDays(-113),
                EndDate = DateTime.Now.AddDays(-107),
                Cost = 76472000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-113),
                UpdatedAt = DateTime.Now.AddDays(-113),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 447,
                PaymentId = 224,
                ProductId = 144,
                ServiceId = 3,
                AmoutEmployee = 149,
                StartDate = DateTime.Now.AddDays(-164),
                EndDate = DateTime.Now.AddDays(-158),
                Cost = 819500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-164),
                UpdatedAt = DateTime.Now.AddDays(-164),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 448,
                PaymentId = 224,
                ProductId = 148,
                ServiceId = 1,
                AmoutEmployee = 36,
                StartDate = DateTime.Now.AddDays(-40),
                EndDate = DateTime.Now.AddDays(-34),
                Cost = 5670000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-40),
                UpdatedAt = DateTime.Now.AddDays(-40),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 449,
                PaymentId = 225,
                ProductId = 183,
                ServiceId = 2,
                AmoutEmployee = 199,
                StartDate = DateTime.Now.AddDays(-22),
                EndDate = DateTime.Now.AddDays(-16),
                Cost = 19104000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-22),
                UpdatedAt = DateTime.Now.AddDays(-22),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 450,
                PaymentId = 225,
                ProductId = 158,
                ServiceId = 3,
                AmoutEmployee = 138,
                StartDate = DateTime.Now.AddDays(-172),
                EndDate = DateTime.Now.AddDays(-157),
                Cost = 80454000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-172),
                UpdatedAt = DateTime.Now.AddDays(-172),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 451,
                PaymentId = 226,
                ProductId = 120,
                ServiceId = 2,
                AmoutEmployee = 183,
                StartDate = DateTime.Now.AddDays(-92),
                EndDate = DateTime.Now.AddDays(-80),
                Cost = 26352000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-92),
                UpdatedAt = DateTime.Now.AddDays(-92),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 452,
                PaymentId = 226,
                ProductId = 173,
                ServiceId = 3,
                AmoutEmployee = 62,
                StartDate = DateTime.Now.AddDays(-121),
                EndDate = DateTime.Now.AddDays(-109),
                Cost = 33418000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-121),
                UpdatedAt = DateTime.Now.AddDays(-121),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 453,
                PaymentId = 227,
                ProductId = 82,
                ServiceId = 3,
                AmoutEmployee = 55,
                StartDate = DateTime.Now.AddDays(-172),
                EndDate = DateTime.Now.AddDays(-170),
                Cost = 17545000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-172),
                UpdatedAt = DateTime.Now.AddDays(-172),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 454,
                PaymentId = 227,
                ProductId = 118,
                ServiceId = 2,
                AmoutEmployee = 166,
                StartDate = DateTime.Now.AddDays(-70),
                EndDate = DateTime.Now.AddDays(-67),
                Cost = 57768000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-70),
                UpdatedAt = DateTime.Now.AddDays(-70),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 455,
                PaymentId = 228,
                ProductId = 145,
                ServiceId = 3,
                AmoutEmployee = 26,
                StartDate = DateTime.Now.AddDays(-36),
                EndDate = DateTime.Now.AddDays(-25),
                Cost = 286000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-36),
                UpdatedAt = DateTime.Now.AddDays(-36),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 456,
                PaymentId = 228,
                ProductId = 100,
                ServiceId = 2,
                AmoutEmployee = 191,
                StartDate = DateTime.Now.AddDays(-112),
                EndDate = DateTime.Now.AddDays(-102),
                Cost = 55008000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-112),
                UpdatedAt = DateTime.Now.AddDays(-112),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 457,
                PaymentId = 229,
                ProductId = 100,
                ServiceId = 3,
                AmoutEmployee = 139,
                StartDate = DateTime.Now.AddDays(-175),
                EndDate = DateTime.Now.AddDays(-173),
                Cost = 77214500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-175),
                UpdatedAt = DateTime.Now.AddDays(-175),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 458,
                PaymentId = 229,
                ProductId = 118,
                ServiceId = 1,
                AmoutEmployee = 107,
                StartDate = DateTime.Now.AddDays(-44),
                EndDate = DateTime.Now.AddDays(-43),
                Cost = 14445000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-44),
                UpdatedAt = DateTime.Now.AddDays(-44),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 459,
                PaymentId = 230,
                ProductId = 12,
                ServiceId = 1,
                AmoutEmployee = 73,
                StartDate = DateTime.Now.AddDays(-56),
                EndDate = DateTime.Now.AddDays(-43),
                Cost = 13468500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-56),
                UpdatedAt = DateTime.Now.AddDays(-56),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 460,
                PaymentId = 230,
                ProductId = 83,
                ServiceId = 1,
                AmoutEmployee = 31,
                StartDate = DateTime.Now.AddDays(-13),
                EndDate = DateTime.Now.AddDays(2),
                Cost = 1116000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-13),
                UpdatedAt = DateTime.Now.AddDays(-13),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 461,
                PaymentId = 231,
                ProductId = 63,
                ServiceId = 3,
                AmoutEmployee = 30,
                StartDate = DateTime.Now.AddDays(-183),
                EndDate = DateTime.Now.AddDays(-179),
                Cost = 18975000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-183),
                UpdatedAt = DateTime.Now.AddDays(-183),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 462,
                PaymentId = 231,
                ProductId = 174,
                ServiceId = 3,
                AmoutEmployee = 64,
                StartDate = DateTime.Now.AddDays(-164),
                EndDate = DateTime.Now.AddDays(-156),
                Cost = 8096000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-164),
                UpdatedAt = DateTime.Now.AddDays(-164),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 463,
                PaymentId = 232,
                ProductId = 76,
                ServiceId = 2,
                AmoutEmployee = 180,
                StartDate = DateTime.Now.AddDays(-131),
                EndDate = DateTime.Now.AddDays(-121),
                Cost = 111240000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-131),
                UpdatedAt = DateTime.Now.AddDays(-131),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 464,
                PaymentId = 232,
                ProductId = 22,
                ServiceId = 3,
                AmoutEmployee = 197,
                StartDate = DateTime.Now.AddDays(-55),
                EndDate = DateTime.Now.AddDays(-48),
                Cost = 11918500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-55),
                UpdatedAt = DateTime.Now.AddDays(-55),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 465,
                PaymentId = 233,
                ProductId = 42,
                ServiceId = 3,
                AmoutEmployee = 83,
                StartDate = DateTime.Now.AddDays(-132),
                EndDate = DateTime.Now.AddDays(-125),
                Cost = 10043000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-132),
                UpdatedAt = DateTime.Now.AddDays(-132),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 466,
                PaymentId = 233,
                ProductId = 37,
                ServiceId = 3,
                AmoutEmployee = 33,
                StartDate = DateTime.Now.AddDays(-11),
                EndDate = DateTime.Now.AddDays(-4),
                Cost = 726000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-11),
                UpdatedAt = DateTime.Now.AddDays(-11),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 467,
                PaymentId = 234,
                ProductId = 104,
                ServiceId = 2,
                AmoutEmployee = 34,
                StartDate = DateTime.Now.AddDays(-69),
                EndDate = DateTime.Now.AddDays(-54),
                Cost = 5712000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-69),
                UpdatedAt = DateTime.Now.AddDays(-69),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 468,
                PaymentId = 234,
                ProductId = 121,
                ServiceId = 1,
                AmoutEmployee = 63,
                StartDate = DateTime.Now.AddDays(-9),
                EndDate = DateTime.Now.AddDays(-2),
                Cost = 283500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-9),
                UpdatedAt = DateTime.Now.AddDays(-9),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 469,
                PaymentId = 235,
                ProductId = 82,
                ServiceId = 3,
                AmoutEmployee = 173,
                StartDate = DateTime.Now.AddDays(-139),
                EndDate = DateTime.Now.AddDays(-124),
                Cost = 106568000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-139),
                UpdatedAt = DateTime.Now.AddDays(-139),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 470,
                PaymentId = 235,
                ProductId = 48,
                ServiceId = 3,
                AmoutEmployee = 81,
                StartDate = DateTime.Now.AddDays(-188),
                EndDate = DateTime.Now.AddDays(-181),
                Cost = 43213500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-188),
                UpdatedAt = DateTime.Now.AddDays(-188),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 471,
                PaymentId = 236,
                ProductId = 160,
                ServiceId = 2,
                AmoutEmployee = 56,
                StartDate = DateTime.Now.AddDays(-95),
                EndDate = DateTime.Now.AddDays(-94),
                Cost = 19824000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-95),
                UpdatedAt = DateTime.Now.AddDays(-95),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 472,
                PaymentId = 236,
                ProductId = 19,
                ServiceId = 3,
                AmoutEmployee = 80,
                StartDate = DateTime.Now.AddDays(-151),
                EndDate = DateTime.Now.AddDays(-145),
                Cost = 17160000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-151),
                UpdatedAt = DateTime.Now.AddDays(-151),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 473,
                PaymentId = 237,
                ProductId = 181,
                ServiceId = 3,
                AmoutEmployee = 125,
                StartDate = DateTime.Now.AddDays(-161),
                EndDate = DateTime.Now.AddDays(-156),
                Cost = 50875000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-161),
                UpdatedAt = DateTime.Now.AddDays(-161),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 474,
                PaymentId = 237,
                ProductId = 161,
                ServiceId = 1,
                AmoutEmployee = 125,
                StartDate = DateTime.Now.AddDays(-37),
                EndDate = DateTime.Now.AddDays(-29),
                Cost = 5062500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-37),
                UpdatedAt = DateTime.Now.AddDays(-37),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 475,
                PaymentId = 238,
                ProductId = 125,
                ServiceId = 3,
                AmoutEmployee = 164,
                StartDate = DateTime.Now.AddDays(-144),
                EndDate = DateTime.Now.AddDays(-135),
                Cost = 89298000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-144),
                UpdatedAt = DateTime.Now.AddDays(-144),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 476,
                PaymentId = 238,
                ProductId = 77,
                ServiceId = 1,
                AmoutEmployee = 160,
                StartDate = DateTime.Now.AddDays(-197),
                EndDate = DateTime.Now.AddDays(-193),
                Cost = 100080000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-197),
                UpdatedAt = DateTime.Now.AddDays(-197),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 477,
                PaymentId = 239,
                ProductId = 80,
                ServiceId = 2,
                AmoutEmployee = 147,
                StartDate = DateTime.Now.AddDays(-33),
                EndDate = DateTime.Now.AddDays(-21),
                Cost = 23814000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-33),
                UpdatedAt = DateTime.Now.AddDays(-33),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 478,
                PaymentId = 239,
                ProductId = 72,
                ServiceId = 1,
                AmoutEmployee = 25,
                StartDate = DateTime.Now.AddDays(-11),
                EndDate = DateTime.Now.AddDays(2),
                Cost = 562500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-11),
                UpdatedAt = DateTime.Now.AddDays(-11),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 479,
                PaymentId = 240,
                ProductId = 144,
                ServiceId = 1,
                AmoutEmployee = 134,
                StartDate = DateTime.Now.AddDays(-177),
                EndDate = DateTime.Now.AddDays(-171),
                Cost = 98289000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-177),
                UpdatedAt = DateTime.Now.AddDays(-177),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 480,
                PaymentId = 240,
                ProductId = 6,
                ServiceId = 1,
                AmoutEmployee = 72,
                StartDate = DateTime.Now.AddDays(-72),
                EndDate = DateTime.Now.AddDays(-68),
                Cost = 19116000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-72),
                UpdatedAt = DateTime.Now.AddDays(-72),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 481,
                PaymentId = 241,
                ProductId = 65,
                ServiceId = 2,
                AmoutEmployee = 87,
                StartDate = DateTime.Now.AddDays(-118),
                EndDate = DateTime.Now.AddDays(-104),
                Cost = 2088000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-118),
                UpdatedAt = DateTime.Now.AddDays(-118),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 482,
                PaymentId = 241,
                ProductId = 151,
                ServiceId = 2,
                AmoutEmployee = 81,
                StartDate = DateTime.Now.AddDays(-83),
                EndDate = DateTime.Now.AddDays(-74),
                Cost = 34020000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-83),
                UpdatedAt = DateTime.Now.AddDays(-83),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 483,
                PaymentId = 242,
                ProductId = 49,
                ServiceId = 2,
                AmoutEmployee = 191,
                StartDate = DateTime.Now.AddDays(-16),
                EndDate = DateTime.Now.AddDays(-3),
                Cost = 4584000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-16),
                UpdatedAt = DateTime.Now.AddDays(-16),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 484,
                PaymentId = 242,
                ProductId = 191,
                ServiceId = 2,
                AmoutEmployee = 34,
                StartDate = DateTime.Now.AddDays(-66),
                EndDate = DateTime.Now.AddDays(-62),
                Cost = 12444000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-66),
                UpdatedAt = DateTime.Now.AddDays(-66),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 485,
                PaymentId = 243,
                ProductId = 56,
                ServiceId = 1,
                AmoutEmployee = 187,
                StartDate = DateTime.Now.AddDays(-120),
                EndDate = DateTime.Now.AddDays(-112),
                Cost = 72369000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-120),
                UpdatedAt = DateTime.Now.AddDays(-120),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 486,
                PaymentId = 243,
                ProductId = 184,
                ServiceId = 2,
                AmoutEmployee = 142,
                StartDate = DateTime.Now.AddDays(-42),
                EndDate = DateTime.Now.AddDays(-35),
                Cost = 20448000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-42),
                UpdatedAt = DateTime.Now.AddDays(-42),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 487,
                PaymentId = 244,
                ProductId = 125,
                ServiceId = 2,
                AmoutEmployee = 47,
                StartDate = DateTime.Now.AddDays(-166),
                EndDate = DateTime.Now.AddDays(-160),
                Cost = 44556000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-166),
                UpdatedAt = DateTime.Now.AddDays(-166),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 488,
                PaymentId = 244,
                ProductId = 149,
                ServiceId = 3,
                AmoutEmployee = 183,
                StartDate = DateTime.Now.AddDays(-108),
                EndDate = DateTime.Now.AddDays(-99),
                Cost = 9058500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-108),
                UpdatedAt = DateTime.Now.AddDays(-108),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 489,
                PaymentId = 245,
                ProductId = 96,
                ServiceId = 3,
                AmoutEmployee = 42,
                StartDate = DateTime.Now.AddDays(-52),
                EndDate = DateTime.Now.AddDays(-47),
                Cost = 4851000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-52),
                UpdatedAt = DateTime.Now.AddDays(-52),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 490,
                PaymentId = 245,
                ProductId = 9,
                ServiceId = 2,
                AmoutEmployee = 92,
                StartDate = DateTime.Now.AddDays(-89),
                EndDate = DateTime.Now.AddDays(-88),
                Cost = 4968000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-89),
                UpdatedAt = DateTime.Now.AddDays(-89),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 491,
                PaymentId = 246,
                ProductId = 126,
                ServiceId = 1,
                AmoutEmployee = 93,
                StartDate = DateTime.Now.AddDays(-73),
                EndDate = DateTime.Now.AddDays(-65),
                Cost = 23854500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-73),
                UpdatedAt = DateTime.Now.AddDays(-73),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 492,
                PaymentId = 246,
                ProductId = 89,
                ServiceId = 1,
                AmoutEmployee = 177,
                StartDate = DateTime.Now.AddDays(-41),
                EndDate = DateTime.Now.AddDays(-33),
                Cost = 25488000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-41),
                UpdatedAt = DateTime.Now.AddDays(-41),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 493,
                PaymentId = 247,
                ProductId = 55,
                ServiceId = 1,
                AmoutEmployee = 52,
                StartDate = DateTime.Now.AddDays(-50),
                EndDate = DateTime.Now.AddDays(-40),
                Cost = 9360000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-50),
                UpdatedAt = DateTime.Now.AddDays(-50),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 494,
                PaymentId = 247,
                ProductId = 138,
                ServiceId = 1,
                AmoutEmployee = 104,
                StartDate = DateTime.Now.AddDays(-177),
                EndDate = DateTime.Now.AddDays(-174),
                Cost = 59436000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-177),
                UpdatedAt = DateTime.Now.AddDays(-177),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 495,
                PaymentId = 248,
                ProductId = 189,
                ServiceId = 3,
                AmoutEmployee = 129,
                StartDate = DateTime.Now.AddDays(-23),
                EndDate = DateTime.Now.AddDays(-18),
                Cost = 2838000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-23),
                UpdatedAt = DateTime.Now.AddDays(-23),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 496,
                PaymentId = 248,
                ProductId = 97,
                ServiceId = 3,
                AmoutEmployee = 81,
                StartDate = DateTime.Now.AddDays(-143),
                EndDate = DateTime.Now.AddDays(-142),
                Cost = 43213500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-143),
                UpdatedAt = DateTime.Now.AddDays(-143),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 497,
                PaymentId = 249,
                ProductId = 181,
                ServiceId = 3,
                AmoutEmployee = 176,
                StartDate = DateTime.Now.AddDays(-16),
                EndDate = DateTime.Now.AddDays(-3),
                Cost = 968000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-16),
                UpdatedAt = DateTime.Now.AddDays(-16),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 498,
                PaymentId = 249,
                ProductId = 63,
                ServiceId = 1,
                AmoutEmployee = 28,
                StartDate = DateTime.Now.AddDays(-40),
                EndDate = DateTime.Now.AddDays(-36),
                Cost = 1134000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-40),
                UpdatedAt = DateTime.Now.AddDays(-40),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 499,
                PaymentId = 250,
                ProductId = 65,
                ServiceId = 1,
                AmoutEmployee = 87,
                StartDate = DateTime.Now.AddDays(-154),
                EndDate = DateTime.Now.AddDays(-140),
                Cost = 5481000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-154),
                UpdatedAt = DateTime.Now.AddDays(-154),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 500,
                PaymentId = 250,
                ProductId = 131,
                ServiceId = 1,
                AmoutEmployee = 69,
                StartDate = DateTime.Now.AddDays(-37),
                EndDate = DateTime.Now.AddDays(-36),
                Cost = 4968000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-37),
                UpdatedAt = DateTime.Now.AddDays(-37),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 501,
                PaymentId = 251,
                ProductId = 88,
                ServiceId = 2,
                AmoutEmployee = 38,
                StartDate = DateTime.Now.AddDays(-147),
                EndDate = DateTime.Now.AddDays(-141),
                Cost = 7068000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-147),
                UpdatedAt = DateTime.Now.AddDays(-147),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 502,
                PaymentId = 251,
                ProductId = 56,
                ServiceId = 1,
                AmoutEmployee = 72,
                StartDate = DateTime.Now.AddDays(-38),
                EndDate = DateTime.Now.AddDays(-27),
                Cost = 9396000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-38),
                UpdatedAt = DateTime.Now.AddDays(-38),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 503,
                PaymentId = 252,
                ProductId = 22,
                ServiceId = 3,
                AmoutEmployee = 124,
                StartDate = DateTime.Now.AddDays(-156),
                EndDate = DateTime.Now.AddDays(-151),
                Cost = 66154000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-156),
                UpdatedAt = DateTime.Now.AddDays(-156),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 504,
                PaymentId = 252,
                ProductId = 76,
                ServiceId = 2,
                AmoutEmployee = 162,
                StartDate = DateTime.Now.AddDays(-128),
                EndDate = DateTime.Now.AddDays(-120),
                Cost = 90396000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-128),
                UpdatedAt = DateTime.Now.AddDays(-128),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 505,
                PaymentId = 253,
                ProductId = 167,
                ServiceId = 3,
                AmoutEmployee = 62,
                StartDate = DateTime.Now.AddDays(-131),
                EndDate = DateTime.Now.AddDays(-119),
                Cost = 15345000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-131),
                UpdatedAt = DateTime.Now.AddDays(-131),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 506,
                PaymentId = 253,
                ProductId = 182,
                ServiceId = 2,
                AmoutEmployee = 36,
                StartDate = DateTime.Now.AddDays(-9),
                EndDate = DateTime.Now.AddDays(1),
                Cost = 432000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-9),
                UpdatedAt = DateTime.Now.AddDays(-9),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 507,
                PaymentId = 254,
                ProductId = 148,
                ServiceId = 2,
                AmoutEmployee = 61,
                StartDate = DateTime.Now.AddDays(-186),
                EndDate = DateTime.Now.AddDays(-183),
                Cost = 28914000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-186),
                UpdatedAt = DateTime.Now.AddDays(-186),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 508,
                PaymentId = 254,
                ProductId = 72,
                ServiceId = 1,
                AmoutEmployee = 41,
                StartDate = DateTime.Now.AddDays(-148),
                EndDate = DateTime.Now.AddDays(-147),
                Cost = 9778500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-148),
                UpdatedAt = DateTime.Now.AddDays(-148),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 509,
                PaymentId = 255,
                ProductId = 191,
                ServiceId = 2,
                AmoutEmployee = 84,
                StartDate = DateTime.Now.AddDays(-95),
                EndDate = DateTime.Now.AddDays(-81),
                Cost = 10080000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-95),
                UpdatedAt = DateTime.Now.AddDays(-95),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 510,
                PaymentId = 255,
                ProductId = 103,
                ServiceId = 3,
                AmoutEmployee = 84,
                StartDate = DateTime.Now.AddDays(-11),
                EndDate = DateTime.Now.AddDays(-1),
                Cost = 2310000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-11),
                UpdatedAt = DateTime.Now.AddDays(-11),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 511,
                PaymentId = 256,
                ProductId = 151,
                ServiceId = 1,
                AmoutEmployee = 76,
                StartDate = DateTime.Now.AddDays(-111),
                EndDate = DateTime.Now.AddDays(-108),
                Cost = 33858000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-111),
                UpdatedAt = DateTime.Now.AddDays(-111),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 512,
                PaymentId = 256,
                ProductId = 139,
                ServiceId = 3,
                AmoutEmployee = 126,
                StartDate = DateTime.Now.AddDays(-32),
                EndDate = DateTime.Now.AddDays(-22),
                Cost = 13167000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-32),
                UpdatedAt = DateTime.Now.AddDays(-32),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 513,
                PaymentId = 257,
                ProductId = 91,
                ServiceId = 3,
                AmoutEmployee = 93,
                StartDate = DateTime.Now.AddDays(-42),
                EndDate = DateTime.Now.AddDays(-39),
                Cost = 9207000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-42),
                UpdatedAt = DateTime.Now.AddDays(-42),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 514,
                PaymentId = 257,
                ProductId = 26,
                ServiceId = 3,
                AmoutEmployee = 69,
                StartDate = DateTime.Now.AddDays(-88),
                EndDate = DateTime.Now.AddDays(-75),
                Cost = 19354500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-88),
                UpdatedAt = DateTime.Now.AddDays(-88),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 515,
                PaymentId = 258,
                ProductId = 144,
                ServiceId = 2,
                AmoutEmployee = 151,
                StartDate = DateTime.Now.AddDays(-24),
                EndDate = DateTime.Now.AddDays(-19),
                Cost = 2718000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-24),
                UpdatedAt = DateTime.Now.AddDays(-24),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 516,
                PaymentId = 258,
                ProductId = 146,
                ServiceId = 3,
                AmoutEmployee = 163,
                StartDate = DateTime.Now.AddDays(-77),
                EndDate = DateTime.Now.AddDays(-75),
                Cost = 50204000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-77),
                UpdatedAt = DateTime.Now.AddDays(-77),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 517,
                PaymentId = 259,
                ProductId = 79,
                ServiceId = 2,
                AmoutEmployee = 88,
                StartDate = DateTime.Now.AddDays(-156),
                EndDate = DateTime.Now.AddDays(-152),
                Cost = 20592000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-156),
                UpdatedAt = DateTime.Now.AddDays(-156),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 518,
                PaymentId = 259,
                ProductId = 146,
                ServiceId = 2,
                AmoutEmployee = 31,
                StartDate = DateTime.Now.AddDays(-92),
                EndDate = DateTime.Now.AddDays(-81),
                Cost = 5394000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-92),
                UpdatedAt = DateTime.Now.AddDays(-92),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 519,
                PaymentId = 260,
                ProductId = 55,
                ServiceId = 1,
                AmoutEmployee = 194,
                StartDate = DateTime.Now.AddDays(-188),
                EndDate = DateTime.Now.AddDays(-186),
                Cost = 47142000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-188),
                UpdatedAt = DateTime.Now.AddDays(-188),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 520,
                PaymentId = 260,
                ProductId = 139,
                ServiceId = 2,
                AmoutEmployee = 96,
                StartDate = DateTime.Now.AddDays(-140),
                EndDate = DateTime.Now.AddDays(-136),
                Cost = 43200000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-140),
                UpdatedAt = DateTime.Now.AddDays(-140),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 521,
                PaymentId = 261,
                ProductId = 118,
                ServiceId = 3,
                AmoutEmployee = 114,
                StartDate = DateTime.Now.AddDays(-187),
                EndDate = DateTime.Now.AddDays(-176),
                Cost = 94677000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-187),
                UpdatedAt = DateTime.Now.AddDays(-187),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 522,
                PaymentId = 261,
                ProductId = 29,
                ServiceId = 3,
                AmoutEmployee = 102,
                StartDate = DateTime.Now.AddDays(-113),
                EndDate = DateTime.Now.AddDays(-104),
                Cost = 56661000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-113),
                UpdatedAt = DateTime.Now.AddDays(-113),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 523,
                PaymentId = 262,
                ProductId = 118,
                ServiceId = 3,
                AmoutEmployee = 160,
                StartDate = DateTime.Now.AddDays(-179),
                EndDate = DateTime.Now.AddDays(-175),
                Cost = 124080000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-179),
                UpdatedAt = DateTime.Now.AddDays(-179),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 524,
                PaymentId = 262,
                ProductId = 172,
                ServiceId = 2,
                AmoutEmployee = 135,
                StartDate = DateTime.Now.AddDays(-124),
                EndDate = DateTime.Now.AddDays(-113),
                Cost = 4860000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-124),
                UpdatedAt = DateTime.Now.AddDays(-124),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 525,
                PaymentId = 263,
                ProductId = 119,
                ServiceId = 2,
                AmoutEmployee = 27,
                StartDate = DateTime.Now.AddDays(-186),
                EndDate = DateTime.Now.AddDays(-175),
                Cost = 2106000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-186),
                UpdatedAt = DateTime.Now.AddDays(-186),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 526,
                PaymentId = 263,
                ProductId = 73,
                ServiceId = 2,
                AmoutEmployee = 70,
                StartDate = DateTime.Now.AddDays(-122),
                EndDate = DateTime.Now.AddDays(-119),
                Cost = 26880000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-122),
                UpdatedAt = DateTime.Now.AddDays(-122),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 527,
                PaymentId = 264,
                ProductId = 100,
                ServiceId = 2,
                AmoutEmployee = 51,
                StartDate = DateTime.Now.AddDays(-121),
                EndDate = DateTime.Now.AddDays(-108),
                Cost = 13464000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-121),
                UpdatedAt = DateTime.Now.AddDays(-121),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 528,
                PaymentId = 264,
                ProductId = 27,
                ServiceId = 3,
                AmoutEmployee = 153,
                StartDate = DateTime.Now.AddDays(-51),
                EndDate = DateTime.Now.AddDays(-43),
                Cost = 1683000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-51),
                UpdatedAt = DateTime.Now.AddDays(-51),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 529,
                PaymentId = 265,
                ProductId = 136,
                ServiceId = 3,
                AmoutEmployee = 27,
                StartDate = DateTime.Now.AddDays(-128),
                EndDate = DateTime.Now.AddDays(-126),
                Cost = 6534000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-128),
                UpdatedAt = DateTime.Now.AddDays(-128),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 530,
                PaymentId = 265,
                ProductId = 200,
                ServiceId = 1,
                AmoutEmployee = 188,
                StartDate = DateTime.Now.AddDays(-43),
                EndDate = DateTime.Now.AddDays(-40),
                Cost = 19458000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-43),
                UpdatedAt = DateTime.Now.AddDays(-43),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 531,
                PaymentId = 266,
                ProductId = 78,
                ServiceId = 2,
                AmoutEmployee = 134,
                StartDate = DateTime.Now.AddDays(-8),
                EndDate = DateTime.Now.AddDays(-6),
                Cost = 1608000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-8),
                UpdatedAt = DateTime.Now.AddDays(-8),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 532,
                PaymentId = 266,
                ProductId = 112,
                ServiceId = 2,
                AmoutEmployee = 141,
                StartDate = DateTime.Now.AddDays(-154),
                EndDate = DateTime.Now.AddDays(-150),
                Cost = 39762000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-154),
                UpdatedAt = DateTime.Now.AddDays(-154),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 533,
                PaymentId = 267,
                ProductId = 177,
                ServiceId = 2,
                AmoutEmployee = 100,
                StartDate = DateTime.Now.AddDays(-19),
                EndDate = DateTime.Now.AddDays(-12),
                Cost = 6600000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-19),
                UpdatedAt = DateTime.Now.AddDays(-19),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 534,
                PaymentId = 267,
                ProductId = 132,
                ServiceId = 1,
                AmoutEmployee = 138,
                StartDate = DateTime.Now.AddDays(-142),
                EndDate = DateTime.Now.AddDays(-139),
                Cost = 69552000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-142),
                UpdatedAt = DateTime.Now.AddDays(-142),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 535,
                PaymentId = 268,
                ProductId = 58,
                ServiceId = 1,
                AmoutEmployee = 164,
                StartDate = DateTime.Now.AddDays(-106),
                EndDate = DateTime.Now.AddDays(-104),
                Cost = 55350000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-106),
                UpdatedAt = DateTime.Now.AddDays(-106),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 536,
                PaymentId = 268,
                ProductId = 130,
                ServiceId = 2,
                AmoutEmployee = 54,
                StartDate = DateTime.Now.AddDays(-145),
                EndDate = DateTime.Now.AddDays(-132),
                Cost = 45036000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-145),
                UpdatedAt = DateTime.Now.AddDays(-145),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 537,
                PaymentId = 269,
                ProductId = 165,
                ServiceId = 2,
                AmoutEmployee = 150,
                StartDate = DateTime.Now.AddDays(-47),
                EndDate = DateTime.Now.AddDays(-41),
                Cost = 3600000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-47),
                UpdatedAt = DateTime.Now.AddDays(-47),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 538,
                PaymentId = 269,
                ProductId = 142,
                ServiceId = 1,
                AmoutEmployee = 110,
                StartDate = DateTime.Now.AddDays(-124),
                EndDate = DateTime.Now.AddDays(-115),
                Cost = 33660000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-124),
                UpdatedAt = DateTime.Now.AddDays(-124),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 539,
                PaymentId = 270,
                ProductId = 69,
                ServiceId = 1,
                AmoutEmployee = 67,
                StartDate = DateTime.Now.AddDays(-67),
                EndDate = DateTime.Now.AddDays(-58),
                Cost = 14472000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-67),
                UpdatedAt = DateTime.Now.AddDays(-67),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 540,
                PaymentId = 270,
                ProductId = 149,
                ServiceId = 3,
                AmoutEmployee = 51,
                StartDate = DateTime.Now.AddDays(-117),
                EndDate = DateTime.Now.AddDays(-114),
                Cost = 10098000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-117),
                UpdatedAt = DateTime.Now.AddDays(-117),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 541,
                PaymentId = 271,
                ProductId = 159,
                ServiceId = 2,
                AmoutEmployee = 89,
                StartDate = DateTime.Now.AddDays(-163),
                EndDate = DateTime.Now.AddDays(-159),
                Cost = 3204000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-163),
                UpdatedAt = DateTime.Now.AddDays(-163),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 542,
                PaymentId = 271,
                ProductId = 75,
                ServiceId = 1,
                AmoutEmployee = 79,
                StartDate = DateTime.Now.AddDays(-16),
                EndDate = DateTime.Now.AddDays(-3),
                Cost = 3199500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-16),
                UpdatedAt = DateTime.Now.AddDays(-16),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 543,
                PaymentId = 272,
                ProductId = 41,
                ServiceId = 3,
                AmoutEmployee = 59,
                StartDate = DateTime.Now.AddDays(-47),
                EndDate = DateTime.Now.AddDays(-36),
                Cost = 8112500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-47),
                UpdatedAt = DateTime.Now.AddDays(-47),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 544,
                PaymentId = 272,
                ProductId = 120,
                ServiceId = 1,
                AmoutEmployee = 34,
                StartDate = DateTime.Now.AddDays(-21),
                EndDate = DateTime.Now.AddDays(-6),
                Cost = 2295000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-21),
                UpdatedAt = DateTime.Now.AddDays(-21),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 545,
                PaymentId = 273,
                ProductId = 41,
                ServiceId = 3,
                AmoutEmployee = 186,
                StartDate = DateTime.Now.AddDays(-88),
                EndDate = DateTime.Now.AddDays(-76),
                Cost = 22506000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-88),
                UpdatedAt = DateTime.Now.AddDays(-88),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 546,
                PaymentId = 273,
                ProductId = 87,
                ServiceId = 2,
                AmoutEmployee = 162,
                StartDate = DateTime.Now.AddDays(-179),
                EndDate = DateTime.Now.AddDays(-172),
                Cost = 142884000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-179),
                UpdatedAt = DateTime.Now.AddDays(-179),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 547,
                PaymentId = 274,
                ProductId = 170,
                ServiceId = 3,
                AmoutEmployee = 62,
                StartDate = DateTime.Now.AddDays(-200),
                EndDate = DateTime.Now.AddDays(-195),
                Cost = 39897000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-200),
                UpdatedAt = DateTime.Now.AddDays(-200),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 548,
                PaymentId = 274,
                ProductId = 34,
                ServiceId = 1,
                AmoutEmployee = 186,
                StartDate = DateTime.Now.AddDays(-85),
                EndDate = DateTime.Now.AddDays(-82),
                Cost = 51894000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-85),
                UpdatedAt = DateTime.Now.AddDays(-85),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 549,
                PaymentId = 275,
                ProductId = 104,
                ServiceId = 2,
                AmoutEmployee = 187,
                StartDate = DateTime.Now.AddDays(-200),
                EndDate = DateTime.Now.AddDays(-189),
                Cost = 166056000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-200),
                UpdatedAt = DateTime.Now.AddDays(-200),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 550,
                PaymentId = 275,
                ProductId = 160,
                ServiceId = 1,
                AmoutEmployee = 196,
                StartDate = DateTime.Now.AddDays(-137),
                EndDate = DateTime.Now.AddDays(-131),
                Cost = 112014000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-137),
                UpdatedAt = DateTime.Now.AddDays(-137),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 551,
                PaymentId = 276,
                ProductId = 126,
                ServiceId = 3,
                AmoutEmployee = 197,
                StartDate = DateTime.Now.AddDays(-192),
                EndDate = DateTime.Now.AddDays(-184),
                Cost = 146272500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-192),
                UpdatedAt = DateTime.Now.AddDays(-192),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 552,
                PaymentId = 276,
                ProductId = 35,
                ServiceId = 2,
                AmoutEmployee = 155,
                StartDate = DateTime.Now.AddDays(-164),
                EndDate = DateTime.Now.AddDays(-150),
                Cost = 59520000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-164),
                UpdatedAt = DateTime.Now.AddDays(-164),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 553,
                PaymentId = 277,
                ProductId = 47,
                ServiceId = 1,
                AmoutEmployee = 147,
                StartDate = DateTime.Now.AddDays(-149),
                EndDate = DateTime.Now.AddDays(-148),
                Cost = 1984500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-149),
                UpdatedAt = DateTime.Now.AddDays(-149),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 554,
                PaymentId = 277,
                ProductId = 31,
                ServiceId = 1,
                AmoutEmployee = 66,
                StartDate = DateTime.Now.AddDays(-30),
                EndDate = DateTime.Now.AddDays(-24),
                Cost = 3564000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-30),
                UpdatedAt = DateTime.Now.AddDays(-30),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 555,
                PaymentId = 278,
                ProductId = 78,
                ServiceId = 2,
                AmoutEmployee = 89,
                StartDate = DateTime.Now.AddDays(-42),
                EndDate = DateTime.Now.AddDays(-31),
                Cost = 18156000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-42),
                UpdatedAt = DateTime.Now.AddDays(-42),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 556,
                PaymentId = 278,
                ProductId = 77,
                ServiceId = 3,
                AmoutEmployee = 52,
                StartDate = DateTime.Now.AddDays(-110),
                EndDate = DateTime.Now.AddDays(-101),
                Cost = 19734000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-110),
                UpdatedAt = DateTime.Now.AddDays(-110),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 557,
                PaymentId = 279,
                ProductId = 145,
                ServiceId = 2,
                AmoutEmployee = 115,
                StartDate = DateTime.Now.AddDays(-186),
                EndDate = DateTime.Now.AddDays(-183),
                Cost = 89700000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-186),
                UpdatedAt = DateTime.Now.AddDays(-186),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 558,
                PaymentId = 279,
                ProductId = 91,
                ServiceId = 1,
                AmoutEmployee = 137,
                StartDate = DateTime.Now.AddDays(-47),
                EndDate = DateTime.Now.AddDays(-36),
                Cost = 17878500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-47),
                UpdatedAt = DateTime.Now.AddDays(-47),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 559,
                PaymentId = 280,
                ProductId = 191,
                ServiceId = 2,
                AmoutEmployee = 163,
                StartDate = DateTime.Now.AddDays(-168),
                EndDate = DateTime.Now.AddDays(-157),
                Cost = 35208000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-168),
                UpdatedAt = DateTime.Now.AddDays(-168),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 560,
                PaymentId = 280,
                ProductId = 143,
                ServiceId = 2,
                AmoutEmployee = 51,
                StartDate = DateTime.Now.AddDays(-14),
                EndDate = DateTime.Now.AddDays(-5),
                Cost = 2754000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-14),
                UpdatedAt = DateTime.Now.AddDays(-14),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 561,
                PaymentId = 281,
                ProductId = 43,
                ServiceId = 2,
                AmoutEmployee = 58,
                StartDate = DateTime.Now.AddDays(-30),
                EndDate = DateTime.Now.AddDays(-27),
                Cost = 6960000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-30),
                UpdatedAt = DateTime.Now.AddDays(-30),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 562,
                PaymentId = 281,
                ProductId = 78,
                ServiceId = 3,
                AmoutEmployee = 128,
                StartDate = DateTime.Now.AddDays(-192),
                EndDate = DateTime.Now.AddDays(-181),
                Cost = 34496000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-192),
                UpdatedAt = DateTime.Now.AddDays(-192),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 563,
                PaymentId = 282,
                ProductId = 45,
                ServiceId = 1,
                AmoutEmployee = 33,
                StartDate = DateTime.Now.AddDays(-95),
                EndDate = DateTime.Now.AddDays(-89),
                Cost = 2376000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-95),
                UpdatedAt = DateTime.Now.AddDays(-95),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 564,
                PaymentId = 282,
                ProductId = 12,
                ServiceId = 3,
                AmoutEmployee = 125,
                StartDate = DateTime.Now.AddDays(-186),
                EndDate = DateTime.Now.AddDays(-185),
                Cost = 46062500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-186),
                UpdatedAt = DateTime.Now.AddDays(-186),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 565,
                PaymentId = 283,
                ProductId = 98,
                ServiceId = 3,
                AmoutEmployee = 100,
                StartDate = DateTime.Now.AddDays(-155),
                EndDate = DateTime.Now.AddDays(-145),
                Cost = 31350000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-155),
                UpdatedAt = DateTime.Now.AddDays(-155),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 566,
                PaymentId = 283,
                ProductId = 62,
                ServiceId = 1,
                AmoutEmployee = 49,
                StartDate = DateTime.Now.AddDays(-77),
                EndDate = DateTime.Now.AddDays(-63),
                Cost = 9922500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-77),
                UpdatedAt = DateTime.Now.AddDays(-77),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 567,
                PaymentId = 284,
                ProductId = 153,
                ServiceId = 1,
                AmoutEmployee = 76,
                StartDate = DateTime.Now.AddDays(-191),
                EndDate = DateTime.Now.AddDays(-182),
                Cost = 58824000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-191),
                UpdatedAt = DateTime.Now.AddDays(-191),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 568,
                PaymentId = 284,
                ProductId = 131,
                ServiceId = 2,
                AmoutEmployee = 152,
                StartDate = DateTime.Now.AddDays(-33),
                EndDate = DateTime.Now.AddDays(-20),
                Cost = 25536000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-33),
                UpdatedAt = DateTime.Now.AddDays(-33),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 569,
                PaymentId = 285,
                ProductId = 74,
                ServiceId = 2,
                AmoutEmployee = 107,
                StartDate = DateTime.Now.AddDays(-42),
                EndDate = DateTime.Now.AddDays(-29),
                Cost = 3852000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-42),
                UpdatedAt = DateTime.Now.AddDays(-42),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 570,
                PaymentId = 285,
                ProductId = 169,
                ServiceId = 2,
                AmoutEmployee = 142,
                StartDate = DateTime.Now.AddDays(-44),
                EndDate = DateTime.Now.AddDays(-34),
                Cost = 32376000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-44),
                UpdatedAt = DateTime.Now.AddDays(-44),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 571,
                PaymentId = 286,
                ProductId = 162,
                ServiceId = 2,
                AmoutEmployee = 137,
                StartDate = DateTime.Now.AddDays(-188),
                EndDate = DateTime.Now.AddDays(-181),
                Cost = 48498000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-188),
                UpdatedAt = DateTime.Now.AddDays(-188),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 572,
                PaymentId = 286,
                ProductId = 19,
                ServiceId = 3,
                AmoutEmployee = 177,
                StartDate = DateTime.Now.AddDays(-17),
                EndDate = DateTime.Now.AddDays(-16),
                Cost = 8761500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-17),
                UpdatedAt = DateTime.Now.AddDays(-17),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 573,
                PaymentId = 287,
                ProductId = 101,
                ServiceId = 2,
                AmoutEmployee = 86,
                StartDate = DateTime.Now.AddDays(-112),
                EndDate = DateTime.Now.AddDays(-108),
                Cost = 5160000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-112),
                UpdatedAt = DateTime.Now.AddDays(-112),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 574,
                PaymentId = 287,
                ProductId = 77,
                ServiceId = 3,
                AmoutEmployee = 79,
                StartDate = DateTime.Now.AddDays(-122),
                EndDate = DateTime.Now.AddDays(-108),
                Cost = 22159500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-122),
                UpdatedAt = DateTime.Now.AddDays(-122),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 575,
                PaymentId = 288,
                ProductId = 16,
                ServiceId = 3,
                AmoutEmployee = 183,
                StartDate = DateTime.Now.AddDays(-92),
                EndDate = DateTime.Now.AddDays(-78),
                Cost = 80520000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-92),
                UpdatedAt = DateTime.Now.AddDays(-92),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 576,
                PaymentId = 288,
                ProductId = 98,
                ServiceId = 2,
                AmoutEmployee = 167,
                StartDate = DateTime.Now.AddDays(-173),
                EndDate = DateTime.Now.AddDays(-172),
                Cost = 18036000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-173),
                UpdatedAt = DateTime.Now.AddDays(-173),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 577,
                PaymentId = 289,
                ProductId = 97,
                ServiceId = 2,
                AmoutEmployee = 99,
                StartDate = DateTime.Now.AddDays(-33),
                EndDate = DateTime.Now.AddDays(-19),
                Cost = 16632000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-33),
                UpdatedAt = DateTime.Now.AddDays(-33),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 578,
                PaymentId = 289,
                ProductId = 11,
                ServiceId = 1,
                AmoutEmployee = 45,
                StartDate = DateTime.Now.AddDays(-134),
                EndDate = DateTime.Now.AddDays(-123),
                Cost = 7087500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-134),
                UpdatedAt = DateTime.Now.AddDays(-134),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 579,
                PaymentId = 290,
                ProductId = 44,
                ServiceId = 1,
                AmoutEmployee = 184,
                StartDate = DateTime.Now.AddDays(-63),
                EndDate = DateTime.Now.AddDays(-52),
                Cost = 32292000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-63),
                UpdatedAt = DateTime.Now.AddDays(-63),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 580,
                PaymentId = 290,
                ProductId = 43,
                ServiceId = 1,
                AmoutEmployee = 189,
                StartDate = DateTime.Now.AddDays(-54),
                EndDate = DateTime.Now.AddDays(-49),
                Cost = 34870500,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-54),
                UpdatedAt = DateTime.Now.AddDays(-54),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 581,
                PaymentId = 291,
                ProductId = 154,
                ServiceId = 2,
                AmoutEmployee = 136,
                StartDate = DateTime.Now.AddDays(-50),
                EndDate = DateTime.Now.AddDays(-41),
                Cost = 30192000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-50),
                UpdatedAt = DateTime.Now.AddDays(-50),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 582,
                PaymentId = 291,
                ProductId = 9,
                ServiceId = 2,
                AmoutEmployee = 123,
                StartDate = DateTime.Now.AddDays(-92),
                EndDate = DateTime.Now.AddDays(-77),
                Cost = 10332000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-92),
                UpdatedAt = DateTime.Now.AddDays(-92),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 583,
                PaymentId = 292,
                ProductId = 7,
                ServiceId = 2,
                AmoutEmployee = 191,
                StartDate = DateTime.Now.AddDays(-125),
                EndDate = DateTime.Now.AddDays(-111),
                Cost = 98556000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-125),
                UpdatedAt = DateTime.Now.AddDays(-125),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 584,
                PaymentId = 292,
                ProductId = 134,
                ServiceId = 2,
                AmoutEmployee = 33,
                StartDate = DateTime.Now.AddDays(-29),
                EndDate = DateTime.Now.AddDays(-22),
                Cost = 3564000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-29),
                UpdatedAt = DateTime.Now.AddDays(-29),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 585,
                PaymentId = 293,
                ProductId = 118,
                ServiceId = 1,
                AmoutEmployee = 144,
                StartDate = DateTime.Now.AddDays(-30),
                EndDate = DateTime.Now.AddDays(-15),
                Cost = 12960000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-30),
                UpdatedAt = DateTime.Now.AddDays(-30),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 586,
                PaymentId = 293,
                ProductId = 88,
                ServiceId = 2,
                AmoutEmployee = 44,
                StartDate = DateTime.Now.AddDays(-21),
                EndDate = DateTime.Now.AddDays(-8),
                Cost = 3960000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-21),
                UpdatedAt = DateTime.Now.AddDays(-21),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 587,
                PaymentId = 294,
                ProductId = 13,
                ServiceId = 2,
                AmoutEmployee = 44,
                StartDate = DateTime.Now.AddDays(-47),
                EndDate = DateTime.Now.AddDays(-45),
                Cost = 11088000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-47),
                UpdatedAt = DateTime.Now.AddDays(-47),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 588,
                PaymentId = 294,
                ProductId = 176,
                ServiceId = 3,
                AmoutEmployee = 84,
                StartDate = DateTime.Now.AddDays(-28),
                EndDate = DateTime.Now.AddDays(-20),
                Cost = 2772000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-28),
                UpdatedAt = DateTime.Now.AddDays(-28),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 589,
                PaymentId = 295,
                ProductId = 82,
                ServiceId = 2,
                AmoutEmployee = 78,
                StartDate = DateTime.Now.AddDays(-84),
                EndDate = DateTime.Now.AddDays(-76),
                Cost = 14508000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-84),
                UpdatedAt = DateTime.Now.AddDays(-84),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 590,
                PaymentId = 295,
                ProductId = 78,
                ServiceId = 2,
                AmoutEmployee = 29,
                StartDate = DateTime.Now.AddDays(-196),
                EndDate = DateTime.Now.AddDays(-194),
                Cost = 5394000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-196),
                UpdatedAt = DateTime.Now.AddDays(-196),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 591,
                PaymentId = 296,
                ProductId = 148,
                ServiceId = 2,
                AmoutEmployee = 116,
                StartDate = DateTime.Now.AddDays(-177),
                EndDate = DateTime.Now.AddDays(-170),
                Cost = 64728000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-177),
                UpdatedAt = DateTime.Now.AddDays(-177),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 592,
                PaymentId = 296,
                ProductId = 74,
                ServiceId = 2,
                AmoutEmployee = 93,
                StartDate = DateTime.Now.AddDays(-14),
                EndDate = DateTime.Now.AddDays(-5),
                Cost = 3906000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-14),
                UpdatedAt = DateTime.Now.AddDays(-14),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 593,
                PaymentId = 297,
                ProductId = 70,
                ServiceId = 1,
                AmoutEmployee = 114,
                StartDate = DateTime.Now.AddDays(-77),
                EndDate = DateTime.Now.AddDays(-71),
                Cost = 17955000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-77),
                UpdatedAt = DateTime.Now.AddDays(-77),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 594,
                PaymentId = 297,
                ProductId = 45,
                ServiceId = 1,
                AmoutEmployee = 78,
                StartDate = DateTime.Now.AddDays(-62),
                EndDate = DateTime.Now.AddDays(-55),
                Cost = 702000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-62),
                UpdatedAt = DateTime.Now.AddDays(-62),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 595,
                PaymentId = 298,
                ProductId = 129,
                ServiceId = 1,
                AmoutEmployee = 31,
                StartDate = DateTime.Now.AddDays(-174),
                EndDate = DateTime.Now.AddDays(-169),
                Cost = 3348000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-174),
                UpdatedAt = DateTime.Now.AddDays(-174),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 596,
                PaymentId = 298,
                ProductId = 149,
                ServiceId = 2,
                AmoutEmployee = 175,
                StartDate = DateTime.Now.AddDays(-91),
                EndDate = DateTime.Now.AddDays(-85),
                Cost = 60900000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-91),
                UpdatedAt = DateTime.Now.AddDays(-91),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 597,
                PaymentId = 299,
                ProductId = 80,
                ServiceId = 2,
                AmoutEmployee = 29,
                StartDate = DateTime.Now.AddDays(-22),
                EndDate = DateTime.Now.AddDays(-15),
                Cost = 348000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-22),
                UpdatedAt = DateTime.Now.AddDays(-22),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 598,
                PaymentId = 299,
                ProductId = 103,
                ServiceId = 2,
                AmoutEmployee = 151,
                StartDate = DateTime.Now.AddDays(-195),
                EndDate = DateTime.Now.AddDays(-190),
                Cost = 156738000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-195),
                UpdatedAt = DateTime.Now.AddDays(-195),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 599,
                PaymentId = 300,
                ProductId = 6,
                ServiceId = 3,
                AmoutEmployee = 40,
                StartDate = DateTime.Now.AddDays(-183),
                EndDate = DateTime.Now.AddDays(-168),
                Cost = 5060000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-183),
                UpdatedAt = DateTime.Now.AddDays(-183),
            });
            context.PaymentDetails.AddOrUpdate(new PaymentDetail()
            {
                Id = 600,
                PaymentId = 300,
                ProductId = 96,
                ServiceId = 3,
                AmoutEmployee = 148,
                StartDate = DateTime.Now.AddDays(-186),
                EndDate = DateTime.Now.AddDays(-178),
                Cost = 100122000,
                Status = PaymentDetailStatus.Active,
                CreatedAt = DateTime.Now.AddDays(-186),
                UpdatedAt = DateTime.Now.AddDays(-186),
            });
            context.SaveChanges();











        }
    }
}
