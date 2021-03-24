using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace eProject.Models
{
    public class AuthRepository : IDisposable
    {
        private ExcelDbContext _ctx;

        private UserManager<Employee> _userManager;

        public AuthRepository()
        {
            _ctx = new ExcelDbContext();
            _userManager = new UserManager<Employee>(new UserStore<Employee>(_ctx));
        }

        public async Task<IdentityResult> RegisterUser(Employee userModel)
        {
            Employee employee = new Employee
            {
                UserName = userModel.UserName,
                PhoneNumber = userModel.PhoneNumber,
                Email = userModel.Email,
                Status = EmployeeStatus.Active,
                Address = userModel.Address,
                DepartmentId = 1,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };

            var result = await _userManager.CreateAsync(employee, userModel.PasswordHash);

            return result;
        }

        public async Task<Employee> FindUser(string userName, string password)
        {
            Employee employee = await _userManager.FindAsync(userName, password);

            return employee;
        }

        public void Dispose()
        {
            _ctx.Dispose();
            _userManager.Dispose();

        }
    }
}