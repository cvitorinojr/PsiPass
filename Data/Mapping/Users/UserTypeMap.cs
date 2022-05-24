using Domain.Entities.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Data.Mapping.Users
{
    internal class UserTypeMap : IEntityTypeConfiguration<UserType>
    {
        public void Configure(EntityTypeBuilder<UserType> builder)
        {
            builder.ToTable("UserType");
            builder.HasKey(i => i.Id);

            builder.HasData(new UserType { Id = 1, Description = "Paciente", CreateAt = DateTime.Now, UpdateAt = DateTime.Now }
                           ,new UserType { Id = 2, Description = "Profissional", CreateAt = DateTime.Now, UpdateAt = DateTime.Now });
        }
    }
}
