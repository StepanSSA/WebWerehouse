using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebWerehouse.Data;
using WebWerehouse.Models;

namespace WebWerehouse.Controllers
{
    [Authorize(Roles = "boss")]
    public class BossController : Controller
    {

        public BossController()
        {
            
        }

        public IActionResult List()
        {
            var users = DataHelper.EmployeeList();
            List<UsersViewModel> v = new List<UsersViewModel>();
            foreach (var item in users)
            {
                v.Add
                    (new UsersViewModel()
                    {
                        Firstname = item.Firstname,
                        Lastname = item.Lastname,
                        Position = item.Position
                    });
            }
            return View(v);
        }

        public IActionResult Create()
        {
            AddEmployee employee = new AddEmployee(); 
            return View(employee);
        }

        [HttpPost]
        public IActionResult Create(AddEmployee employee)
        {
            if (ModelState.IsValid)
            {
                DataHelper.Create(employee);
                return RedirectToAction("Index","Home");
            }
            return View("Error");
        }
        
    }
}
