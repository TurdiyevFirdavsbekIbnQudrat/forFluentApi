using forFluentApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace forFluentApi.Configuration
{
    public class UserHomeTypeConfiguration:IEntityTypeConfiguration<UserHome>
    {
        public void Configure(EntityTypeBuilder<UserHome> builder)
        {
            builder.HasKey(x => new {x.UserId,x.HomeId});
            builder.HasOne(x => x.users)
                .WithMany(x => x.UserHomes)
                .HasForeignKey(x => x.UserId);

            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.UserId).IsRequired();
            builder.Property(x => x.HomeId).IsRequired();
        }
    }
}
