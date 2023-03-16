using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebWerehouse.Models;

namespace WebWerehouse.Data
{
    public class DataHelper
    {// для начального заполнения бд

        private static IApplicationBuilder app;

        public async static void Seed(IApplicationBuilder _app)
        {
            app = _app;
            //  1) добавим базовые роли в систему
            var services = app.ApplicationServices;
            var userManager = services.GetRequiredService<UserManager<AppUser>>();
            var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
            string password = "!Qwerty1";
            string[] rolesNames = { "storekeeper", "manager", "boss" };
            string[] usersNames = { "sklad@mail.ru", "manager@mail.ru", "boss@mail.ru" };
            string[] usersFirstname = { "Ирина", "Андрей", "Павел" };
            string[] usersLastname = { "Иванова", "Маркович", "Дроздов"};
            string[] usersPost = { "Кладовщик", "Менеджер", "Директор" };

            for (int i = 0; i < rolesNames.Length; i++)
            {
                string roleName = rolesNames[i];
                var role = await roleManager.FindByNameAsync(roleName);
                if (role == null)
                {
                    role = new IdentityRole()
                    {
                        Name = roleName
                    };
                    IdentityResult result = await roleManager.CreateAsync(role);
                    if (result.Succeeded)
                    {
                        var user = new AppUser()
                        {
                            UserName = usersNames[i],
                            Email= usersNames[i],
                            Firstname= usersFirstname[i],
                            Lastname= usersLastname[i],
                            Position = usersPost[i],
                        };
                        result = await userManager.CreateAsync(user, password);
                        if (result.Succeeded)
                        {
                            await userManager.AddToRoleAsync(user, roleName);
                        }

                    }
                }
            }

            // 2) добавляем в базу
            var context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();

            if (context.Products.Any()) return;

            context.Products.AddRange(new SimpleProductRepository().Products);
            context.SaveChanges();
        }

        public async static void Create(AddEmployee employee)
        {
            var services = app.ApplicationServices;
            var userManager = services.GetRequiredService<UserManager<AppUser>>();
            var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
            IdentityResult result;

            var role = await roleManager.FindByNameAsync(employee.Role);
            string password = "!Qwerty1";
            if (role == null)
            {
                role = new IdentityRole()
                {
                    Name = employee.Role
                };
                result = await roleManager.CreateAsync(role);
            }
            else
            {
                result = await roleManager.UpdateAsync(role);
            }
            
            if (result.Succeeded)
            {
                var user = new AppUser()
                {
                    UserName = employee.Email,
                    Firstname = employee.Firstname,
                    Email = employee.Email,
                    Lastname = employee.Lastname,
                    Position = employee.Position
                };
                result = await userManager.CreateAsync(user, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, employee.Role);
                }

            }
            var context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.SaveChanges();
        }

        public static List<AppUser> EmployeeList()
        {
            var services = app.ApplicationServices;
            var users = services.GetRequiredService<UserManager<AppUser>>();
            return users.Users.ToList(); ;
        }
    }
}
