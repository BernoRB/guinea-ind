using DacTienda.Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DacTienda.Data
{
    public class DBTiendaContext : DbContext
    {
        public DBTiendaContext() : base("keydbTiendaInfantil") { }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Roles> Users { get; set; }
        public DbSet<Venta> Ventas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>().ToTable("Producto");
            modelBuilder.Entity<Roles>().ToTable("Users");
            modelBuilder.Entity<Venta>().ToTable("Ventas");
        }


    }
}
