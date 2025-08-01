﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhiteLagoon.Domain.Entites;

namespace WhiteLagoon.Infrastructure.Data
{
    public  class AppDbContext :IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Villa> Villas { get; set; }
        public DbSet<VillaNumber> VillaNumbers { get; set; }    
        public DbSet<Amenity> Amenities { get; set; } 
        public DbSet<AppUser> AppUsers { get; set; }    
        public DbSet<Booking> Bookings { get; set; }        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Villa>().HasData(
                new Villa
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Description = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                    ImageUrl = "https://placehold.co/600x400",
                    Occupancy = 4,
                    Price = 200,
                    Sqft = 550,
                },
                new Villa
                {
                    Id = 2,
                    Name = "Premium Pool Villa",
                    Description = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                    ImageUrl = "https://placehold.co/600x401",
                    Occupancy = 4,
                    Price = 300,
                    Sqft = 550,
                },
                new Villa
                {
                    Id = 3,
                    Name = "Luxury Pool Villa",
                    Description = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                    ImageUrl = "https://placehold.co/600x402",
                    Occupancy = 4,
                    Price = 400,
                    Sqft = 750,
                });
            modelBuilder.Entity<VillaNumber>().HasData(
                new VillaNumber
                {
                    Villa_Number = 101,
                    Villa_id= 1
                },
                new VillaNumber
                {
                    Villa_Number = 102,
                    Villa_id = 1
                },
                new VillaNumber
                {
                    Villa_Number = 103,
                    Villa_id = 1
                },
                new VillaNumber
                {
                    Villa_Number = 104 ,
                    Villa_id = 1
                },

                new VillaNumber
                {
                    Villa_Number = 201,
                    Villa_id = 2
                },
                new VillaNumber
                {
                    Villa_Number = 202,
                    Villa_id = 2
                },
                new VillaNumber
                {
                    Villa_Number = 203,
                    Villa_id = 2
                },
                new VillaNumber
                {
                    Villa_Number = 204,
                    Villa_id = 2
                }
                );
            modelBuilder.Entity<Amenity>().HasData(
         new Amenity
         {
             Id = 1,
             VillaId = 1,
             Name = "Private Pool"
         }, new Amenity
         {
             Id = 2,
             VillaId = 1,
             Name = "Microwave"
         }, new Amenity
         {
             Id = 3,
             VillaId = 1,
             Name = "Private Balcony"
         }, new Amenity
         {
             Id = 4,
             VillaId = 1,
             Name = "1 king bed and 1 sofa bed"
         },

         new Amenity
         {
             Id = 5,
             VillaId = 2,
             Name = "Private Plunge Pool"
         }, new Amenity
         {
             Id = 6,
             VillaId = 2,
             Name = "Microwave and Mini Refrigerator"
         }, new Amenity
         {
             Id = 7,
             VillaId = 2,
             Name = "Private Balcony"
         }, new Amenity
         {
             Id = 8,
             VillaId = 2,
             Name = "king bed or 2 double beds"
         }

        
         );
        }
    }
}
