using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstMigration.Context
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions options) : base(options)
        {
        }

        DbSet<Employee> Employees { get; set; }
        DbSet<Issues> Issues { get; set; }
        DbSet<Status> Status { get; set; }
    }

}
