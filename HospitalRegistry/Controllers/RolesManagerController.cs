using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Open.HospitalRegistry.Controllers
{
    public class RolesManagerController : Controller
    {
        //Here you can see all registred users and give them the role.
        public IActionResult Index()
        {
            return View();
        }
    }
}