﻿// <auto-generated />
using Gemicle.MarketerTool.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Gemicle.MarketerTool.Data.Migrations
{
    [DbContext(typeof(MarketerToolContext))]
    [Migration("20240607101958_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("Gemicle.MarketerTool.Data.Models.Customer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Deposite")
                        .HasColumnType("TEXT");

                    b.Property<int>("Gender")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsNewCustomer")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Customer");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Age = 53,
                            City = "London",
                            Deposite = 104m,
                            Gender = 1,
                            IsNewCustomer = false
                        },
                        new
                        {
                            Id = 2L,
                            Age = 44,
                            City = "New York",
                            Deposite = 209m,
                            Gender = 0,
                            IsNewCustomer = true
                        },
                        new
                        {
                            Id = 3L,
                            Age = 36,
                            City = "New York",
                            Deposite = 208m,
                            Gender = 1,
                            IsNewCustomer = true
                        },
                        new
                        {
                            Id = 4L,
                            Age = 87,
                            City = "London",
                            Deposite = 134m,
                            Gender = 0,
                            IsNewCustomer = false
                        },
                        new
                        {
                            Id = 5L,
                            Age = 54,
                            City = "Paris",
                            Deposite = 123m,
                            Gender = 1,
                            IsNewCustomer = true
                        },
                        new
                        {
                            Id = 6L,
                            Age = 45,
                            City = "New York",
                            Deposite = 210m,
                            Gender = 0,
                            IsNewCustomer = true
                        },
                        new
                        {
                            Id = 7L,
                            Age = 49,
                            City = "Tel-Aviv",
                            Deposite = 174m,
                            Gender = 0,
                            IsNewCustomer = false
                        },
                        new
                        {
                            Id = 8L,
                            Age = 35,
                            City = "Paris",
                            Deposite = 52m,
                            Gender = 1,
                            IsNewCustomer = true
                        },
                        new
                        {
                            Id = 9L,
                            Age = 61,
                            City = "Tel-Aviv",
                            Deposite = 151m,
                            Gender = 1,
                            IsNewCustomer = false
                        },
                        new
                        {
                            Id = 10L,
                            Age = 78,
                            City = "Paris",
                            Deposite = 57m,
                            Gender = 1,
                            IsNewCustomer = false
                        },
                        new
                        {
                            Id = 11L,
                            Age = 41,
                            City = "New York",
                            Deposite = 131m,
                            Gender = 0,
                            IsNewCustomer = false
                        },
                        new
                        {
                            Id = 12L,
                            Age = 32,
                            City = "Tel-Aviv",
                            Deposite = 154m,
                            Gender = 0,
                            IsNewCustomer = true
                        },
                        new
                        {
                            Id = 13L,
                            Age = 62,
                            City = "Paris",
                            Deposite = 135m,
                            Gender = 0,
                            IsNewCustomer = false
                        },
                        new
                        {
                            Id = 14L,
                            Age = 67,
                            City = "Tel-Aviv",
                            Deposite = 153m,
                            Gender = 1,
                            IsNewCustomer = true
                        },
                        new
                        {
                            Id = 15L,
                            Age = 68,
                            City = "London",
                            Deposite = 241m,
                            Gender = 0,
                            IsNewCustomer = true
                        },
                        new
                        {
                            Id = 16L,
                            Age = 41,
                            City = "London",
                            Deposite = 134m,
                            Gender = 1,
                            IsNewCustomer = false
                        },
                        new
                        {
                            Id = 17L,
                            Age = 46,
                            City = "London",
                            Deposite = 212m,
                            Gender = 0,
                            IsNewCustomer = false
                        },
                        new
                        {
                            Id = 18L,
                            Age = 77,
                            City = "Tel-Aviv",
                            Deposite = 97m,
                            Gender = 0,
                            IsNewCustomer = true
                        },
                        new
                        {
                            Id = 19L,
                            Age = 51,
                            City = "London",
                            Deposite = 141m,
                            Gender = 1,
                            IsNewCustomer = true
                        },
                        new
                        {
                            Id = 20L,
                            Age = 80,
                            City = "Paris",
                            Deposite = 189m,
                            Gender = 1,
                            IsNewCustomer = false
                        },
                        new
                        {
                            Id = 21L,
                            Age = 31,
                            City = "Tel-Aviv",
                            Deposite = 134m,
                            Gender = 0,
                            IsNewCustomer = true
                        },
                        new
                        {
                            Id = 22L,
                            Age = 80,
                            City = "Tel-Aviv",
                            Deposite = 81m,
                            Gender = 0,
                            IsNewCustomer = false
                        },
                        new
                        {
                            Id = 23L,
                            Age = 36,
                            City = "London",
                            Deposite = 237m,
                            Gender = 0,
                            IsNewCustomer = true
                        },
                        new
                        {
                            Id = 24L,
                            Age = 65,
                            City = "Tel-Aviv",
                            Deposite = 119m,
                            Gender = 0,
                            IsNewCustomer = false
                        },
                        new
                        {
                            Id = 25L,
                            Age = 72,
                            City = "Tel-Aviv",
                            Deposite = 139m,
                            Gender = 1,
                            IsNewCustomer = false
                        },
                        new
                        {
                            Id = 26L,
                            Age = 64,
                            City = "Tel-Aviv",
                            Deposite = 128m,
                            Gender = 1,
                            IsNewCustomer = true
                        },
                        new
                        {
                            Id = 27L,
                            Age = 29,
                            City = "London",
                            Deposite = 76m,
                            Gender = 1,
                            IsNewCustomer = true
                        },
                        new
                        {
                            Id = 28L,
                            Age = 25,
                            City = "London",
                            Deposite = 203m,
                            Gender = 1,
                            IsNewCustomer = true
                        },
                        new
                        {
                            Id = 29L,
                            Age = 77,
                            City = "New York",
                            Deposite = 54m,
                            Gender = 1,
                            IsNewCustomer = true
                        },
                        new
                        {
                            Id = 30L,
                            Age = 79,
                            City = "Paris",
                            Deposite = 165m,
                            Gender = 0,
                            IsNewCustomer = true
                        },
                        new
                        {
                            Id = 31L,
                            Age = 26,
                            City = "Paris",
                            Deposite = 143m,
                            Gender = 0,
                            IsNewCustomer = true
                        },
                        new
                        {
                            Id = 32L,
                            Age = 74,
                            City = "London",
                            Deposite = 61m,
                            Gender = 0,
                            IsNewCustomer = false
                        },
                        new
                        {
                            Id = 33L,
                            Age = 74,
                            City = "New York",
                            Deposite = 103m,
                            Gender = 1,
                            IsNewCustomer = false
                        },
                        new
                        {
                            Id = 34L,
                            Age = 46,
                            City = "New York",
                            Deposite = 121m,
                            Gender = 0,
                            IsNewCustomer = true
                        },
                        new
                        {
                            Id = 35L,
                            Age = 47,
                            City = "New York",
                            Deposite = 214m,
                            Gender = 0,
                            IsNewCustomer = false
                        },
                        new
                        {
                            Id = 36L,
                            Age = 78,
                            City = "New York",
                            Deposite = 111m,
                            Gender = 0,
                            IsNewCustomer = false
                        },
                        new
                        {
                            Id = 37L,
                            Age = 46,
                            City = "New York",
                            Deposite = 223m,
                            Gender = 0,
                            IsNewCustomer = true
                        },
                        new
                        {
                            Id = 38L,
                            Age = 26,
                            City = "New York",
                            Deposite = 78m,
                            Gender = 0,
                            IsNewCustomer = true
                        },
                        new
                        {
                            Id = 39L,
                            Age = 49,
                            City = "Tel-Aviv",
                            Deposite = 60m,
                            Gender = 0,
                            IsNewCustomer = false
                        },
                        new
                        {
                            Id = 40L,
                            Age = 74,
                            City = "New York",
                            Deposite = 53m,
                            Gender = 0,
                            IsNewCustomer = true
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
