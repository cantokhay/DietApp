using DietApp.DAL.Mapping;
using DietApp.DATA;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.DAL.Context
{
    public class AppDBContext : DbContext
    {
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Activity> Activities { get; set; }
      
       
        


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-IG8RINO\MSSQLSERVER01;Database=DietApp006;Trusted_Connection=True;");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new AppUserMapping().Configure(modelBuilder.Entity<AppUser>());
            new CategoryMapping().Configure(modelBuilder.Entity<Category>());
            new MealMapping().Configure(modelBuilder.Entity<Meal>());
            new ProductMapping().Configure(modelBuilder.Entity<Product>());
            new ActivityMapping().Configure(modelBuilder.Entity<Activity>());
          

         
           

            base.OnModelCreating(modelBuilder);

        }
    }
}
