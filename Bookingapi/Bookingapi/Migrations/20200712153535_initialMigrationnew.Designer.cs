﻿// <auto-generated />
using System;
using Bookingapi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Bookingapi.Migrations
{
    [DbContext(typeof(BookingRepository))]
    [Migration("20200712153535_initialMigrationnew")]
    partial class initialMigrationnew
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Bookingapi.Models.Booking", b =>
                {
                    b.Property<int>("roomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Customer_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date_of_booking")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email_of_customer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HotelName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status_of_booking")
                        .HasColumnType("bit");

                    b.HasKey("roomId");

                    b.ToTable("Booking");
                });
#pragma warning restore 612, 618
        }
    }
}
