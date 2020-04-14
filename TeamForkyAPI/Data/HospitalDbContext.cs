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
                    Status = Status.stable,
                },
                new Patient
                {
                    ID = 2,
                    Name = "Joseph",
                    Birthday = "03/23/1986",
                    CheckIn = DateTime.Now,
                    Status = Status.critical
                }
                );

            modelBuilder.Entity<Resources>().HasData(
                new Resources
                {
                    ID = 1,
                    Name = "Teddy",
                    Description = "02/16/1991",
                    ResourcesType = ResourcesType.staff,
                },
                new Resources
                {
                    ID = 2,
                    Name = "Joseph",
                    Description = "02/16/1991",
                    ResourcesType = ResourcesType.room,
                }
                );
        }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<Resources> Resources { get; set; }
        public DbSet<PatientResources> PatientResources { get; set; }
    }
}
