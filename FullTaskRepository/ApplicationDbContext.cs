using FullTaskRepository.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace FullTaskRepository
{

   public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

       private static ApplicationDbContext context=null;
        public static ApplicationDbContext Create()
        {
            if (context == null)
            {
                context=new ApplicationDbContext();
            }
            return context;
        }
        #region DbSets

        public DbSet<Test> Tests { get; set; }
        public DbSet<Student> Students { get; set; }

        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //add configration and constraint that should be applied before entity created 
            base.OnModelCreating(modelBuilder);
        }
        public override int SaveChanges()
        {
            //override it to add changes that should be added to entity before every save it to database
            return base.SaveChanges();
        }
    }
}
