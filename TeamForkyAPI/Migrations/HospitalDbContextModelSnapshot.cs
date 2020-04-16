﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TeamForkyAPI.Data;

namespace TeamForkyAPI.Migrations
{
    [DbContext(typeof(HospitalDbContext))]
    partial class HospitalDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TeamForkyAPI.Models.Patient", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Birthday")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CheckIn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Patient");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Birthday = "02/16/1991",
                            CheckIn = new DateTime(2020, 4, 15, 11, 36, 52, 544, DateTimeKind.Local).AddTicks(6),
                            Name = "Teddy",
                            Status = 0
                        },
                        new
                        {
                            ID = 2,
                            Birthday = "03/23/1986",
                            CheckIn = new DateTime(2020, 4, 15, 11, 36, 52, 547, DateTimeKind.Local).AddTicks(4913),
                            Name = "Joseph",
                            Status = 2
                        },
                        new
                        {
                            ID = 3,
                            Birthday = "08/29/1992",
                            CheckIn = new DateTime(2020, 4, 15, 11, 36, 52, 547, DateTimeKind.Local).AddTicks(4976),
                            Name = "Matthew",
                            Status = 2
                        });
                });

            modelBuilder.Entity("TeamForkyAPI.Models.PatientResources", b =>
                {
                    b.Property<int>("PatientID")
                        .HasColumnType("int");

                    b.Property<int>("ResourcesID")
                        .HasColumnType("int");

                    b.HasKey("PatientID", "ResourcesID");

                    b.HasIndex("ResourcesID");

                    b.ToTable("PatientResources");

                    b.HasData(
                        new
                        {
                            PatientID = 1,
                            ResourcesID = 1
                        },
                        new
                        {
                            PatientID = 1,
                            ResourcesID = 3
                        },
                        new
                        {
                            PatientID = 3,
                            ResourcesID = 2
                        },
                        new
                        {
                            PatientID = 2,
                            ResourcesID = 1
                        });
                });

            modelBuilder.Entity("TeamForkyAPI.Models.Resources", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PatientID")
                        .HasColumnType("int");

                    b.Property<int>("ResourcesType")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("PatientID");

                    b.ToTable("Resources");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Description = "Specialist in C# surgery",
                            Name = "Dr. Amanda",
                            ResourcesType = 0
                        },
                        new
                        {
                            ID = 2,
                            Description = "Specialist in education touch up",
                            Name = "Dr. Brook",
                            ResourcesType = 0
                        },
                        new
                        {
                            ID = 3,
                            Description = "Bacteria sanitizer",
                            Name = "Microwave",
                            ResourcesType = 1
                        });
                });

            modelBuilder.Entity("TeamForkyAPI.Models.PatientResources", b =>
                {
                    b.HasOne("TeamForkyAPI.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TeamForkyAPI.Models.Resources", "Resources")
                        .WithMany()
                        .HasForeignKey("ResourcesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TeamForkyAPI.Models.Resources", b =>
                {
                    b.HasOne("TeamForkyAPI.Models.Patient", null)
                        .WithMany("Resources")
                        .HasForeignKey("PatientID");
                });
#pragma warning restore 612, 618
        }
    }
}
