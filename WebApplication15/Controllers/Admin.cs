using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication15.Controllers
{
    public class Admin : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
 
        public Admin(RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;

        }
        [HttpGet]
        public IActionResult createRole()
        {
            return View();
        }


    }
}
