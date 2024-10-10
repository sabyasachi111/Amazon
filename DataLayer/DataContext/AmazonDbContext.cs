using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.Models;
using AmazonModel.Models;

namespace DataLayer.DataContext
{
    public  class AmazonDbContext : DbContext
    {
        public AmazonDbContext(DbContextOptions<AmazonDbContext> options):base(options)
        {

        }

        public DbSet<UserModel> StoreUsers { get; set; }

        public DbSet<StoreProductsModel> StoreProducts { get; set; }

        public DbSet<CatagoryModel> StoreCatagory { get; set; }

        public DbSet<CartModel> StoreCart { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserModel>().HasData(
                new UserModel 
                {
                    UserID=1,
                    UserFirstName="Sabyasachi_Host",
                    UserLastName="Nayak",
                    Email="nayaksabyasachi@gmail.com",
                    TelephonePrim="9083889959",
                    Password="Host@123"
                    
                
                  
                }
                
                );;
                
        }

    }
}
