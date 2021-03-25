﻿using eProject.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace eProject.Controllers
{
    [System.Web.Http.RoutePrefix("api/Employee")]
    public class EmployeeController : ApiController
    {
        private AuthRepository _repo = null;
        protected ExcelDbContext excelDbContext { get; set; }
        protected UserManager<Employee> userManager { get; set; }
        public EmployeeController()
        {
            _repo = new AuthRepository();
            this.excelDbContext = new ExcelDbContext();
            this.userManager = new UserManager<Employee>(new UserStore<Employee>(this.excelDbContext));
        }

        
        // POST api/Account/Register
        [System.Web.Http.AllowAnonymous]
        [System.Web.Http.Route("Register")]
        public async Task<IHttpActionResult> Register(Employee userModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            IdentityResult result = await _repo.RegisterUser(userModel);

            IHttpActionResult errorResult = GetErrorResult(result);

            if (errorResult != null)
            {
                return errorResult;
            }

            return Ok(result);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _repo.Dispose();
            }

            base.Dispose(disposing);
        }

        private IHttpActionResult GetErrorResult(IdentityResult result)
        {
            if (result == null)
            {
                return InternalServerError();
            }

            if (!result.Succeeded)
            {
                if (result.Errors != null)
                {
                    foreach (string error in result.Errors)
                    {
                        ModelState.AddModelError("", error);
                    }
                }

                if (ModelState.IsValid)
                {
                    // No ModelState errors are available to send, so just return an empty BadRequest.
                    return BadRequest();
                }

                return BadRequest(ModelState);
            }

            return null;
        }

        [System.Web.Http.Authorize]
        [HostAuthentication(DefaultAuthenticationTypes.ExternalBearer)]
        [System.Web.Http.Route("EmployeeInfo")]
        public Employee GetUserInfo()
        {
            var userName = User.Identity.GetUserName();
            var user = userManager.FindByName(userName);
            return user;
          
        }
    }
}