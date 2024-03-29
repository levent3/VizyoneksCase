﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using VizyoneksCase.EntityLayer.Concrete;

namespace VizyoneksCase.DataAccesLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {


        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartLine> CartLines { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedData(builder);
        }



        private void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new Category()
            {
                CategoryId = 1,
                CategoryName = "Telefon"
            });

            modelBuilder.Entity<Product>().HasData(

                new Product()
                {
                    ProductId = 1,
                    CategoryId = 1,
                    Name = "Iphone 15",
                    UnitPrice = 50000,
                    Image = "img/indir.jpg"
                },
                      new Product()

                      {

                          ProductId = 2,
                          CategoryId = 1,
                          Name = "Iphone 14",
                          UnitPrice = 30000,
                          Image = "img/indir.jpg"

                      },
                        new Product()

                        {
                            ProductId = 3,
                            CategoryId = 1,
                            Name = "Iphone 12",
                            UnitPrice = 20000,
                            Image = "img/indir.jpg"

                        }

            );


        }

    }
}
