using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaDeVendasMVC.Models;

namespace SistemaDeVendasMVC.Data
{
    public class SistemaDeVendasMVCContext : DbContext
    {
        public SistemaDeVendasMVCContext (DbContextOptions<SistemaDeVendasMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }

        public DbSet<Seller> Sellers { get; set; }

        public DbSet<SalesRecord> SalesRecords { get; set; }
        
        
    }
}
