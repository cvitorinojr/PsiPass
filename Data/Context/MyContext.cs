using Data.Mapping.Users;
using Domain.Entities.User;
using Microsoft.EntityFrameworkCore;


namespace Data.Context
{
    public class MyContext : DbContext
    {
        public System.Data.Entity.DbSet<User> Users { get; set; }
        public System.Data.Entity.DbSet<UserType> UserType { get; set; }
        public System.Data.Entity.DbSet<UserSpecialty> UserSpecialty { get; set; }

        public MyContext(DbContextOptions<MyContext> options) : base (options) { }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {

            base.OnModelCreating(modelbuilder);
            
            modelbuilder.Entity<User>(new UserMap().Configure);

            modelbuilder.Entity<UserType>(new UserTypeMap().Configure);

            modelbuilder.Entity<UserSpecialty>(new UserSpecialtyMap().Configure);


        }
    }
}
