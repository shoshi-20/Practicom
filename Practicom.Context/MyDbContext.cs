using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Practicom.Repositories.Interfaces;
using Practicom.Repositories.Entities;

namespace Practicom.Context
{
    public class MyDbContext : DbContext, IContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Child> Children { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //options.UseSqlServer("Data Source = DESKTOP-QM3UF42; Initial Catalog = PractikumDbProject; Integrated Security = True;Trusted_Connection=True");
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=shoshiDb;Trusted_Connection=True");
        }
    }
}
