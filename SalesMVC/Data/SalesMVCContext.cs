using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesMVC.Models;
using SalesMVC.Models.ViewModels;

namespace SalesMVC.Data
{
    public class SalesMVCContext : DbContext
    {
        public SalesMVCContext (DbContextOptions<SalesMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecords { get; set; }
        public object SalesRecord { get; internal set; }
    }
}
