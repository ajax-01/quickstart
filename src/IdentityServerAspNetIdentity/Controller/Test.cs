using System.Collections.Generic;
using System.Threading.Tasks;
using IdentityServerAspNetIdentity.Data;
using IdentityServerAspNetIdentity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IdentityServerAspNetIdentity.Controller
{
    [Route("test")]
    public class Test : ControllerBase
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public Test(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        [HttpGet("userList")]
        public Task<List<ApplicationUser>> UserLIst()
        {
            return _applicationDbContext.Users.ToListAsync();
        }

        [HttpGet]
        public string Get()
        {
            return "hello world";
        }
    }
}