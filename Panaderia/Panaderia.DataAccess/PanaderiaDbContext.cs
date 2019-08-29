using Microsoft.EntityFrameworkCore;
using Panaderia.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Panaderia.DataAccess
{
    public class PanaderiaDbContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<ProductoVendido> ProductoVendido { get; set; }
        public DbSet<Venta> Venta { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Vendedor> Vendedor { get; set; }

        public PanaderiaDbContext(DbContextOptions<PanaderiaDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.RemovePluralizingTableNameConvention();
            Seed.SeedData(modelBuilder);
        }
    }
}
