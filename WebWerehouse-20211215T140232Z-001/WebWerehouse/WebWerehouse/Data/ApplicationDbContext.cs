using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebWerehouse.Domains;
using WebWerehouse.Models;

namespace WebWerehouse.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Сhemistry> Сhemistry { get; set; }
        public DbSet<AddEmployee> AddEmployee { get; set; }
        public DbSet<UsersViewModel> UsersViewModel { get; set; }
    }
}
