using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SNT_WEB.Domain.Entities;
using System;

namespace SNT_WEB.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TextField> TextFields { get; set; }
        public DbSet<ServiceItem> ServiceItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "61e069e6-926e-41cb-8d1f-9daff50f3d6e",
                Name = "admin",
                NormalizedName = "ADMIN",
            });

            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "081c0a6b-df14-4f2c-a965-036ac27d2804",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "my@email.com",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
                SecurityStamp = string.Empty
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "61e069e6-926e-41cb-8d1f-9daff50f3d6e",
                UserId = "081c0a6b-df14-4f2c-a965-036ac27d2804"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("a30a3790-7005-4e46-b757-f3e112c8e74f"),
                CodeWord = "PageIndex",
                Title = "Главная"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("4dca876a-233f-4985-ae00-a54b5ac86d92"),
                CodeWord = "PageServices",
                Title = "Наши услуги"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("bd0ab0ea-1a25-4b79-862f-f29d44a3a919"),
                CodeWord = "PageContacts",
                Title = "Контакты"
            });
        }

    }
}
