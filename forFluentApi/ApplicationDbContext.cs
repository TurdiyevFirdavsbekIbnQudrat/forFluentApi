using forFluentApi.Configuration;
using forFluentApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace forFluentApi
{
    public class ApplicationDbContext:DbContext
    {
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) 
        {
            Database.Migrate();
        }
        
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Home> Homes { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<UserHome> UserHomes { get; set; }
        public virtual DbSet<UserCar> UserCars { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //   modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetCallingAssembly());
            modelBuilder.ApplyConfiguration(new CarTypeConfiguration());
            modelBuilder.ApplyConfiguration(new HomeTypeConfiguration());
            modelBuilder.ApplyConfiguration(new UserCarTypeConfiguration());
            modelBuilder.ApplyConfiguration(new UserTypeConfiguration());
            modelBuilder.ApplyConfiguration(new UserHomeTypeConfiguration());
        }
    }

}
