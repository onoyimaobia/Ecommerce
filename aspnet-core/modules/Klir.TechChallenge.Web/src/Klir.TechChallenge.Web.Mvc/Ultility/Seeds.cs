using Klir.TechChallenge.Web.Domain.Models;
using Klir.TechChallenge.Web.Domain.Models.Entity;
using Klir.TechChallenge.Web.Infrastructure.DataContext;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Web.Mvc.Ultility
{
    public static class Seeds
    {
        public static void SeedUserRole(AppDbContext appContext)
        {
            if (!appContext.Roles.Any(c => c.Name == RoleConstants.SuperAdmin))
            {
                var identityResult = appContext.Roles.Add(RoleConstants.GetDefaultOperationsRole());
                appContext.SaveChanges();

                Console.WriteLine("Role Seed Completed");
            }

        }
        public static void SeedRootAdmin(UserManager<Persona> userManager, AppDbContext dbContext)
        {
            const string email = "root@user.ng";
            if (dbContext.Users.Any(c => c.Email == email)) return;
            const string password = "password123";

            var person = new Persona
            {
                Email = email,
                FirstName = "Root",
                LastName = "Admin",
                PhoneNumber = "+2348103449953",
                UserName = email
            };

            var result = userManager.CreateAsync(person, password).GetAwaiter().GetResult();

            if (result.Succeeded)
            {
                var role = dbContext.Roles.FirstOrDefault(c => c.Name == RoleConstants.SuperAdmin);
                var userInRole = dbContext.UserRoles.Add(new UserInRole { RoleId = role.Id, UserId = person.Id });
                dbContext.SaveChanges();
                Console.WriteLine("Root User Successfully Created");
                return;
            }

            Console.WriteLine("Root User Unsuccessfully Created");
        }
        public static void SeedImageSliders(AppDbContext context)
        {
            if (!context.ImageSliders.Any())
            {
                var images = new List<ImageSlider>
            {
                new ImageSlider { ImageUrl = "/ImageSlider/062c00d7-71bb-4c4d-beea-38a76ccbfc2e_50129444.png" },
                new ImageSlider { ImageUrl = "/ImageSlider/92e98c65-d30e-43e5-9e22-535acdabe457_50145239.png"},
                new ImageSlider { ImageUrl = "/ImageSlider/e36c3d56-6453-4d6c-92fb-b6feb3f96ce8_50181250.jpg"},
                new ImageSlider { ImageUrl = "/ImageSlider/63294c0c-838e-4e9f-81a6-1eda3f079e13_50157912.png" },
                new ImageSlider { ImageUrl = "/ImageSlider/ccbddac4-dea3-4287-9d90-fe59598de6b4_10044651.png" },
                new ImageSlider { ImageUrl = "/ImageSlider/9c6603a1-f6b1-4419-9605-9aab6b8a23ee_37168798.jpg" },
                new ImageSlider { ImageUrl = "/ImageSlider/8331b267-c4a2-4424-aad5-ca742362fbeb_50043851.png" },
                new ImageSlider { ImageUrl = "/ImageSlider/705b062c-c637-4084-9919-655cf1c59a6d_50151737.png" },
                new ImageSlider { ImageUrl = "/ImageSlider/073576ad-387b-4a65-a26c-ea074545f101_50138179.png" },
                new ImageSlider { ImageUrl = "/ImageSlider/ccbddac4-dea3-4287-9d90-fe59598de6b4_10044651.png" }
            };
                context.AddRange(images);
                context.SaveChanges();
            }
        }
    }
}
