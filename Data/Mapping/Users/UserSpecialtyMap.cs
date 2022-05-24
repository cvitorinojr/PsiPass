using Domain.Entities.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping.Users
{
    public class UserSpecialtyMap : IEntityTypeConfiguration<UserSpecialty>
    {
        public void Configure(EntityTypeBuilder<UserSpecialty> builder)
        {
            builder.ToTable("UserSpecialty");
            builder.HasKey(i => i.Id);

            builder.HasData(
                     new UserSpecialty { Id = 1, Description = "Educacional", CreateAt = DateTime.Now, UpdateAt = DateTime.Now }
                    ,new UserSpecialty { Id = 2, Description = "Jurídica", CreateAt = DateTime.Now, UpdateAt = DateTime.Now }
                    ,new UserSpecialty { Id = 3, Description = "Esportiva", CreateAt = DateTime.Now, UpdateAt = DateTime.Now }
                    ,new UserSpecialty { Id = 4, Description = "Hospitalar", CreateAt = DateTime.Now, UpdateAt = DateTime.Now }
                    ,new UserSpecialty { Id = 5, Description = "Social", CreateAt = DateTime.Now, UpdateAt = DateTime.Now }
                    ,new UserSpecialty { Id = 6, Description = "Neuropsicologia", CreateAt = DateTime.Now, UpdateAt = DateTime.Now }
                    ,new UserSpecialty { Id = 7, Description = "Clínica", CreateAt = DateTime.Now, UpdateAt = DateTime.Now }
                    ,new UserSpecialty { Id = 8, Description = "Idoso", CreateAt = DateTime.Now, UpdateAt = DateTime.Now }
                    ,new UserSpecialty { Id = 9, Description = "Trânsito", CreateAt = DateTime.Now, UpdateAt = DateTime.Now }
                    ,new UserSpecialty { Id = 10, Description = "Comportamental", CreateAt = DateTime.Now, UpdateAt = DateTime.Now }
                    ,new UserSpecialty { Id = 11, Description = "Psicopedagogia", CreateAt = DateTime.Now, UpdateAt = DateTime.Now }
                    ,new UserSpecialty { Id = 12, Description = "Avaliação Psicológica", CreateAt = DateTime.Now, UpdateAt = DateTime.Now });
        }
    }
}
