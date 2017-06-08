using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HD.Entities;
using ITGigs.Common.Extensions;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace HD.DbContext.Migrations
{
    class Initializer
    {
        public static void SeedRoles(ApplicationDbContext context)
        {
            string[] roles =
            {
                "Administrator",
                "Manager",
                "Editor",
                "Buyer",
                "Business",
                "Seller",
                "Subscriber",
                "Guest",
                "Student"
            };

            foreach (var role in roles)
            {
                var roleStore = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

                if (!context.Roles.Any(r => r.Name == role))
                {
                    roleStore.Create(new IdentityRole(role));
                }
            }
        }

        public static void SeedUser(ApplicationDbContext context)
        {
            string userName = "AsenHodzhev";
            string owner = "Admin";
            var ownerRole = new IdentityRole() { Id = new CustomId().ToString(), Name = owner };
            context.Roles.Add(ownerRole);

            var hasher = new PasswordHasher();

            var user = new User
            {
                UserName = userName,
                PasswordHash = hasher.HashPassword("123456"),
                Email = "asen@domain.com",
                EmailConfirmed = true,
                SecurityStamp = new CustomId().ToString()
            };
            user.Roles.Add(new IdentityUserRole { RoleId = ownerRole.Id, UserId = user.Id });
            context.Users.Add(user);
        }
    }
}
