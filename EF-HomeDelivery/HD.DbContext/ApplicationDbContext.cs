using System.Data.Entity;
using HD.DbContext.Migrations;
using HD.Entities;
using HD.Entities.Common;
using HD.Entities.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace HD.DbContext
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {


        public virtual IDbSet<Order> Orders { get; set; }
        public virtual IDbSet<Restaurant> Restaurants { get; set; }
        public virtual IDbSet<City> Cities { get; set; }

        public ApplicationDbContext()
            //: base("HDDevConnection", throwIfV1Schema: false)
          : base("HDConnection", throwIfV1Schema: false)
        {

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());

        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
