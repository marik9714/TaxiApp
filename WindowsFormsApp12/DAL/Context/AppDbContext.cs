using System.Data.Entity;
using WindowsFormsApp12.DAL.Models;

namespace WindowsFormsApp12.DAL.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarColor> CarColors { get; set; }
        public DbSet<Cashbox> Cashboxs { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Dispatcher> Dispatchers { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Mark> Marks { get; set; }
        public DbSet<Street> Streets { get; set; }
        public DbSet<Traffic> Traffics { get; set; }

        public AppDbContext() : base("name=AppContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
