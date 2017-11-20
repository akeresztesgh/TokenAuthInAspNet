namespace api.Migrations
{
    using api.Models;
    using api.Utils;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity;
    using WebApplication1.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<MyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MyDbContext context)
        {
            SeedUsers(context);
        }

        private void SeedUsers(MyDbContext db)
        {
            var userManager = new ApplicationUserManager(new UserStore<User>(db));

            var admins = new[]
            {
                new User { UserName = "admin", Email = "testuser@unknown.com", EmailConfirmed = true, IsActive = true },
                new User { UserName = "admin2", Email = "testuser2@unknown.com", EmailConfirmed = true, IsActive = true }
            };

            foreach (var user in admins)
            {
                if (userManager.Users.Any(i => i.UserName == user.UserName))
                    continue;
                userManager.Create(user, "Admin1234!");
            }

        }
    }
}
