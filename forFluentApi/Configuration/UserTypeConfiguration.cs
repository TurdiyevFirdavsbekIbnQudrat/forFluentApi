using forFluentApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace forFluentApi.Configuration
{
    public class UserTypeConfiguration:IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x=>x.UserCars)
                .WithOne(x=>x.users)
                .HasForeignKey(x=>x.CarId);

            builder.HasMany(x=>x.UserHomes)
                .WithOne(x=>x.users)
                .HasForeignKey(x=>x.HomeId);
            
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.FirstName).IsRequired();
            builder.Property(x => x.LastName).IsRequired();
            builder.HasData(
                new User { Id = 1, FirstName = "Firdavsbek", LastName = "Turdiyev" },
                new User { Id = 2, FirstName = "Quvvatbek", LastName = "Turdiyev" }
                );
            builder.Property(x => x.FirstName).HasComment("Foydalanuvchining ismi ");
            builder.Property(x => x.LastName).HasComment("Foydalanuvchining familiyasi ");

            
        }

    }
}
