using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridgeBackendApi.Model
{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(
        //           @"Server=(localdb)\mssqllocaldb;Database=ProductsDB;Trusted_Connection=True;");
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //seeding dummy data in database
            modelBuilder.Entity<Product>().HasData(
               new Product()
               {
                   Id = 10001,
                   Name = "xyz 1",
                   Price = 100,
                   Description = "ausjn mdvnjdi"
               },
               new Product()
               {
                   Id = 10002,
                   Name = "xyz 2",
                   Price = 101,
                   Description = "ausjn mdvnjdi"
               },
               new Product()
               {
                   Id = 10003,
                   Name = "xyz 3",
                   Price = 102,
                   Description = "ausjn mdvnjdi"
               },
               new Product()
               {
                   Id = 10004,
                   Name = "xyz 4",
                   Price = 100,
                   Description = "ausjn mdvnjdi"
               },
               new Product()
               {
                   Id = 10005,
                   Name = "xyz 5",
                   Price = 100,
                   Description = "ausjn mdvnjdi"
               },
               new Product()
               {
                   Id = 10006,
                   Name = "xyz 6",
                   Price = 100,
                   Description = "ausjn mdvnjdi"
               },
                new Product()
                {
                   Id = 10007,
                   Name = "xyz 7",
                   Price=100,
                   Description = "ausjn mdvnjdi"
               }
               );
            base.OnModelCreating(modelBuilder);

        }




    }
}
