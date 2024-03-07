﻿// <auto-generated />
using System;
using BarberShop.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BarberShop.Migrations
{
    [DbContext(typeof(BarbershopDbContext))]
    [Migration("20240307050900_InitialBarbershopDb")]
    partial class InitialBarbershopDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BarberShop.Models.Appointments.Appointment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("BarberShopId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<TimeOnly>("Time")
                        .HasColumnType("time without time zone");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("BarberShopId");

                    b.HasIndex("UserId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("BarberShop.Models.Barbershops.Barbershop", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Latitude")
                        .HasColumnType("text");

                    b.Property<string>("Longitude")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Barbershops");
                });

            modelBuilder.Entity("BarberShop.Models.Users.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BarberShop.Models.Appointments.Appointment", b =>
                {
                    b.HasOne("BarberShop.Models.Barbershops.Barbershop", "BarberShop")
                        .WithMany("Appointments")
                        .HasForeignKey("BarberShopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BarberShop.Models.Users.User", "User")
                        .WithMany("Appointments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BarberShop");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BarberShop.Models.Barbershops.Barbershop", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("BarberShop.Models.Users.User", b =>
                {
                    b.Navigation("Appointments");
                });
#pragma warning restore 612, 618
        }
    }
}