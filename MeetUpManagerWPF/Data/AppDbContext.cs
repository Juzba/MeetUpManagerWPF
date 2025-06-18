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

            modelBuilder.Entity<User>().HasData
            (
                new User
                {
                    Id = "Juzba-admin-sffdf4-54fdds-sdf17-147",
                    Name = "Jiří Novák",
                    Email = "Juzba88@gmail.com",
                    Password = "123456",
                    UserRoleId = "",
                },
                new User
                {
                    Id = "Katka-eventmanager-sffdf4-54fdds-eg58k",
                    Name = "Katka Nováková",
                    Email = "Katka@gmail.com",
                    Password = "123456",
                    UserRoleId = "",
                },
                new User
                {
                    Id = "Karel-visitor-sffdf4-54fdds-ter98-895",
                    Name = "Karel Novák",
                    Email = "Karel@gmail.com",
                    Password = "123456",
                    UserRoleId = "",
                }
            );
        }
    }
}
