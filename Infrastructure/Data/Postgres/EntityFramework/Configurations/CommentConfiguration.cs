using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.Entities.Base;
using Infrastructure.Data.Postgres.EntityFramework.Configurations.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class CommentConfiguration : BaseConfiguration<Comment, int>
    {
        public override void Configure(EntityTypeBuilder<Comment> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.user_id).IsRequired();
            //builder.HasIndex(x => x.user_id).IsUnique();
            builder.Property(x => x.Car_id).IsRequired();
            //builder.HasIndex(x => x.car_id).IsUnique();
            builder.Property(x => x.comment_title).IsRequired();
            //builder.HasIndex(x => x.comment_title).IsUnique();
            builder.Property(x => x.comment).IsRequired();
            //builder.HasIndex(x => x.comment).IsUnique();
            builder.Property(x => x.star_point).IsRequired();
            //builder.Property(x => x.CreatedAt).IsRequired();
            //builder.Property(x => x.IsDeleted).IsRequired();

            builder.HasOne(x => x.User)
            .WithMany(u => u.Comments)
            .HasForeignKey(x => x.user_id)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Cars)
                .WithMany(c => c.Comments)
                .HasForeignKey(x => x.Car_id)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
