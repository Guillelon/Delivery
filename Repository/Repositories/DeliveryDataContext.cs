using Repository.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class DeliveryDataContext: DbContext
    {
        public DbSet<Sale> Sale { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<TypeMenuItem> TypeMenuItem { get; set; }
        public DbSet<MenuItem> MenuItem  { get; set; }
        public DbSet<Extra> Extra { get; set; }
        public DbSet<SaleDetail> SaleDetail { get; set; }
        public DbSet<ExtraSaleDetail> ExtraSaleDetail { get; set; }
}
}
