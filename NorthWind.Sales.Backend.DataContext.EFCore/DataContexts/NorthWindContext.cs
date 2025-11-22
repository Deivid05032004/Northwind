using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Sales.Backend.DataContext.EFCore.DataContexts
{
    internal class NorthWindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=NorthWindDB;User ID=sa;Password=Deivid123!;TrustServerCertificate=True;");
            //Base.OnConfiguring(optionsBuilder);

        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        //Permite a las herramientas de l EntityFramework Core crear el modelo de la base de datos, es decir 
        // migrar las tablas 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //bae.onModelCreating(modelBuilder);
        }
    }


}
