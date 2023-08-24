using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Postgres.EntityFramework.Configurations.Base;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class ReservationConfiguration : BaseConfiguration<Reservations, int>
    {
        public override void Configure(EntityTypeBuilder<Reservations> builder)
        {
            builder.ToTable("Reservations");

            base.Configure(builder);

            builder.Property(r => r.User_id)
                .IsRequired();

            builder.Property(r => r.Car_id)
                .IsRequired();

            builder.Property(r => r.Car_pickup_location)
                .IsRequired();

            builder.Property(r => r.Car_dropoff_location)
                .IsRequired();

            builder.Property(r => r.Pick_Up_Date)
                .IsRequired();

            builder.Property(r => r.Choose_A_Date)
                .IsRequired();

            builder.HasOne(r => r.User)
                .WithMany(u => u.Reservations)
                .HasForeignKey(r => r.User_id)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(r => r.Cars)
                .WithMany(c => c.Reservations)
                .HasForeignKey(r => r.Car_id)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
