using MeetUpManagerWPF.Models;
using Microsoft.EntityFrameworkCore;

namespace MeetUpManagerWPF.Data
{
    public class AppDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MeetUpManager;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Event> Events { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserRole>().HasData
            (
                new UserRole
                {
                    Id = "admin-roleid-1",
                    Role = "Admin"
                },
                new UserRole
                {
                    Id = "eventmanager-roleid-2",
                    Role = "EventManager"
                },
                new UserRole
                {
                    Id = "visitor-roleid-3",
                    Role = "Visitor"
                }
            );

            modelBuilder.Entity<User>().HasData
            (
                new User
                {
                    Id = "Juzba-admin-sffdf4-54fdds-sdf17-147",
                    Name = "Jiří Novák",
                    Email = "Juzba88@gmail.com",
                    Password = "123456",
                    UserRoleId = "admin-roleid-1",
                },
                new User
                {
                    Id = "Katka-eventmanager-sffdf4-54fdds-eg58k",
                    Name = "Katka Nováková",
                    Email = "Katka@gmail.com",
                    Password = "123456",
                    UserRoleId = "eventmanager-roleid-2",
                },
                new User
                {
                    Id = "Karel-visitor-sffdf4-54fdds-ter98-895",
                    Name = "Karel Novák",
                    Email = "Karel@gmail.com",
                    Password = "123456",
                    UserRoleId = "visitor-roleid-3",
                }
            );
        }
    }
}
