using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Open.Facade.RoleListView;

namespace Open.HospitalRegistry.Controllers
{
    public class ApplicationRoleController : Controller
    {
        public IActionResult Index()
        {
            //List<ApplicationRoleListViewModel> model = new List<ApplicationRoleListViewModel>();
            //model = roleManager.Roles.Select(r => new ApplicationRoleListViewModel
            //{
            //    RoleName = r.Name,
            //    Id = r.Id,
            //    NumberOfUsers = r.Users.Count
            //}).ToList();
            return View("ApplicationRoleListView");
        }
    }
}