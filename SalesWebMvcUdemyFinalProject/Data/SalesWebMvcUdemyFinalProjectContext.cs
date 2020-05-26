using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvcUdemyFinalProject.Models;

namespace SalesWebMvcUdemyFinalProject.Data
{
    public class SalesWebMvcUdemyFinalProjectContext : DbContext
    {
        public SalesWebMvcUdemyFinalProjectContext (DbContextOptions<SalesWebMvcUdemyFinalProjectContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }


    }
}
