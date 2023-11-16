using forFluentApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace forFluentApi.Configuration
{
    public class HomeTypeConfiguration:IEntityTypeConfiguration<Home>
    {
        public void Configure(EntityTypeBuilder<Home> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x=>x.UserHomes)
                .WithOne(x=>x.homes)
                .HasForeignKey(x=>x.HomeId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.Id).IsRequired();
            builder.Property(x=>x.Address).IsRequired();
            builder.Property(x => x.Address).HasComment("Uyning manzili ");
            builder.HasData(
                new Home { Id = 1, Address = "Andijon viloyati Xo'jaobod tumani" },
                new Home { Id = 2, Address = "Andijon viloyati Buloqboshi tumani" });
        }

    }
}
