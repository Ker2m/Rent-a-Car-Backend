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
    public class ContactConfiguration : BaseConfiguration<Contact, int>
    {
        public override void Configure(EntityTypeBuilder<Contact> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.name).IsRequired();
            builder.Property(x => x.email).IsRequired();
            builder.Property(x => x.subject).IsRequired();
            builder.Property(x => x.message).IsRequired();
            //builder.Property(x => x.CreatedAt).IsRequired();
            //builder.Property(x => x.IsDeleted).IsRequired();
        }
    }
}
