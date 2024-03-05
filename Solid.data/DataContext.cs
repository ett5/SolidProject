using Microsoft.EntityFrameworkCore;
using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data

{
    public class DataContext:DbContext
    {

        public DbSet<Employee> EmployeeList { get; set; }
        public DbSet<Hours> HoursList { get; set; }
        public DbSet<Tasks> TasksList { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Eti0");
        }

    }
}

