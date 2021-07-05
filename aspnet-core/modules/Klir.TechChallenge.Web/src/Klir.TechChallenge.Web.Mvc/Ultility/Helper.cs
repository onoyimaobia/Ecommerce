using Klir.TechChallenge.Web.Domain.Models.Entity;
using Klir.TechChallenge.Web.Infrastructure.DataContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Web.Mvc.Ultility
{
    public class Helper
    {
        public static string GetPicture(string userName)
        {
            var options = new DbContextOptions<AppDbContext>();
            var u = new AppDbContext(options).Users.Where(a => a.UserName == userName).FirstOrDefault();

            if (u == null)
            {
                return "";
            }

            var profilepic = u.ProfilePic;
            return profilepic;
        }
        public static string GetUserFullName(string userName)
        {
            var options = new DbContextOptions<AppDbContext>();
            var u = new AppDbContext(options).Users.Where(a => a.UserName == userName).FirstOrDefault();

            if (u == null)
            {
                return "";
            }

            var fullname = u.FirstName + " " + u.LastName;
            return fullname;
        }
        public static string GetUserRole(string userName)
        {
            var options = new DbContextOptions<AppDbContext>();
            var u = new AppDbContext(options).Users.Where(a => a.UserName == userName).FirstOrDefault();

            if (u == null)
            {
                return "";
            }

            var fullname = u.FirstName + " " + u.LastName;
            return fullname;
        }
        public static IList<ImageSlider> GetAll()
        {
            var options = new DbContextOptions<AppDbContext>();
            var allMenuItem = new AppDbContext(options).ImageSliders.ToList();

            return allMenuItem;
        }
    }
}
