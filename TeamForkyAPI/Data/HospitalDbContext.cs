using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamForkyAPI.Models;

namespace TeamForkyAPI.Data
{
    public class HospitalDbContext : DbContext
    {
        public HospitalDbContext(DbContextOptions<HospitalDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PatientResources>().HasKey(x => new { x.PatientID, x.ResourcesID });

            modelBuilder.Entity<Patient>().HasData(
                new Patient
                {
                    ID = 1,
                    Name = "Teddy",
                    Birthday = "02/16/1991",
                    CheckIn = DateTime.Now,
                    Status =0,
                },
                new Patient
                {
                    ID = 2,
                    Name = "Joseph",
                    Birthday = "03/23/1986",
                    CheckIn = DateTime.Now,
                    Status = 0
                },
                new Patient
                {
                    ID = 3,
                    Name = "Matthew",
                    Birthday = "08/29/1992",
                    CheckIn = DateTime.Now,
                    Status = 0
                }
                );

            modelBuilder.Entity<Resources>().HasData(
                new Resources
                {
                    ID = 1,
                    Name = "Dr. Amanda",
                    Description = "Specialist in C# surgery",
                    ResourcesType = 0,
                },
                new Resources
                {
                    ID = 2,
                    Name = "Dr. Brook",
                    Description = "Specialist in education touch up",
                    ResourcesType = 0,
                },
                new Resources
                {
                    ID = 3,
                    Name = "Microwave",
                    Description = "Bacteria sanitizer",
                    ResourcesType = 0,
                }
                );

            modelBuilder.Entity<PatientResources>().HasData(
                new PatientResources
                {
                    //ID = 1,
                    PatientID = 1,
                    ResourcesID = 1,
                },
                new PatientResources
                {
                    //ID = 2,
                    PatientID = 1,
                    ResourcesID = 3,
                },
                new PatientResources
                {
                    //ID = 3,
                    PatientID = 3,
                    ResourcesID = 2,
                },
                new PatientResources
                {
                    //ID = 4,
                    PatientID = 2,
                    ResourcesID = 1,
                }
                );
        }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<Resources> Resources { get; set; }
        public DbSet<PatientResources> PatientResources { get; set; }
    }
}
