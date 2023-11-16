using forFluentApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace forFluentApi.Configuration
{
    public class UserCarTypeConfiguration : IEntityTypeConfiguration<UserCar>
    {
        public void Configure(EntityTypeBuilder<UserCar> builder)
        {
            builder.HasKey(x => new {x.CarId,x.UserId});
            builder.HasOne(x => x.users)
                .WithMany(x => x.UserCars)
                .HasForeignKey(x => x.UserId);

            builder.Property(x => x.Id).IsRequired();
            builder.Property(x=>x.UserId).IsRequired();
            builder.Property(x=>x.CarId).IsRequired();
            
        }
    }
}
