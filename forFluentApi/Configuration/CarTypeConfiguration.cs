using forFluentApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace forFluentApi.Configuration
{
    public class CarTypeConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.UserCars)
                .WithOne(x => x.cars)
                .HasForeignKey(x=>x.CarId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.Property(x=>x.Id).IsRequired();
            builder.Property(x=>x.Name).IsRequired();

            builder.HasData(
                new Car { Id = 1, Name = "Matiz" },
                new Car { Id = 2, Name = "Spark" }
                );
            builder.Property(x => x.Name).HasComment("mashinaning nomi ");
                
        }
    }
}
