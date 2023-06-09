﻿// <auto-generated />
using FinalPracticeNormal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FinalPracticeNormal.Migrations
{
    [DbContext(typeof(BryceApplicationContext))]
    [Migration("20230422154644_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("FinalPracticeNormal.Models.GetBryce", b =>
                {
                    b.Property<int>("ApplicationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Major")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TommyJohn")
                        .HasColumnType("INTEGER");

                    b.HasKey("ApplicationId");

                    b.ToTable("HopefulResponses");

                    b.HasData(
                        new
                        {
                            ApplicationId = 1,
                            Age = 22,
                            FirstName = "Ben",
                            LastName = "Daley",
                            Major = "Information Systems",
                            Phone = "385-867-5309",
                            TommyJohn = true
                        },
                        new
                        {
                            ApplicationId = 2,
                            Age = 22,
                            FirstName = "Jessica",
                            LastName = "Daley",
                            Major = "Information Systems",
                            Phone = "435-435-4354",
                            TommyJohn = false
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
