
namespace NorthWind.Sales.Backend.DataContext.EFCore.DataContexts
{
    internal class NorthWindSalesContext(IOptions<DBOptions> dbOpctions) : DbContext
    {
        public DbSet<Order> Orders { get; set; }  
        public DbSet<OrderDetail> OrderDetails { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(dbOpctions.Value.ConnectionString);
            //Base.OnConfiguring(optionsBuilder);
        }
        //Permite a las herramientas de l EntityFramework Core crear el modelo de la base de datos,
        //es decir migrar las tablas 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //bae.onModelCreating(modelBuilder);
        }
    }
}
