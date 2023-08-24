using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework.Configurations.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class CarsConfiguration : BaseConfiguration<Cars, int>
{
    public override void Configure(EntityTypeBuilder<Cars> builder)
    {
        base.Configure(builder); // Base configuration from the abstract class

        // Additional configuration specific to Cars entity
        builder.Property(x => x.arac_adi).IsRequired();
        builder.Property(x => x.arac_resmi).IsRequired();
        builder.Property(x => x.vites_tipi).IsRequired();
        builder.Property(x => x.yakit_tipi).IsRequired();
        builder.Property(x => x.arac_kilometre).IsRequired();
        builder.Property(x => x.arac_tipi).IsRequired();
        builder.Property(x => x.arac_koltuk).IsRequired();
        builder.Property(x => x.arac_popularite).IsRequired();
        builder.Property(x => x.price).IsRequired();

        builder.HasMany(c => c.Comments)
            .WithOne(c => c.Cars)
            .HasForeignKey(c => c.Car_id);

        builder.HasMany(c => c.Reservations)
            .WithOne(r => r.Cars)
            .HasForeignKey(r => r.Car_id);
    }
}
