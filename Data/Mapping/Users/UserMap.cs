using Domain.Entities.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mapping.Users
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(i => i.Id);

            builder.HasIndex(c => c.CRP).IsUnique();
            builder.Property(n => n.Name).IsRequired().HasMaxLength(100);

            builder.HasOne(t => t.UserType);

            builder.HasOne(s => s.UserSpecialty);


        }
    }
}
