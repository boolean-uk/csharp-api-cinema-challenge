﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using api_cinema_challenge.Data;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    [DbContext(typeof(CinemaContext))]
    partial class CinemaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("api_cinema_challenge.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 9, 13, 8, 21, 31, 808, DateTimeKind.Utc).AddTicks(4720),
                            Email = "anderh2@gmail.com",
                            Name = "Anders Hagen Ottersland",
                            Phone = "1234",
                            UpdatedAt = new DateTime(2024, 9, 13, 8, 21, 31, 808, DateTimeKind.Utc).AddTicks(4720)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 9, 13, 8, 21, 31, 808, DateTimeKind.Utc).AddTicks(4721),
                            Email = "Nigel@teacher.com",
                            Name = "Nigel Teacher",
                            Phone = "90909090",
                            UpdatedAt = new DateTime(2024, 9, 13, 8, 21, 31, 808, DateTimeKind.Utc).AddTicks(4721)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("RuntimeMins")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 9, 13, 8, 21, 31, 808, DateTimeKind.Utc).AddTicks(4696),
                            Description = "Magic staffs goes boom",
                            Rating = "PG-13",
                            RuntimeMins = 123,
                            Title = "Harry Potter",
                            UpdatedAt = new DateTime(2024, 9, 13, 8, 21, 31, 808, DateTimeKind.Utc).AddTicks(4696)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 9, 13, 8, 21, 31, 808, DateTimeKind.Utc).AddTicks(4699),
                            Description = "Swords, Wizards and fun",
                            Rating = "PG-16",
                            RuntimeMins = 205,
                            Title = "Lord Of The Rings",
                            UpdatedAt = new DateTime(2024, 9, 13, 8, 21, 31, 808, DateTimeKind.Utc).AddTicks(4699)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 9, 13, 8, 21, 31, 808, DateTimeKind.Utc).AddTicks(4700),
                            Description = "Singing",
                            Rating = "PG-All",
                            RuntimeMins = 89,
                            Title = "Frozen",
                            UpdatedAt = new DateTime(2024, 9, 13, 8, 21, 31, 808, DateTimeKind.Utc).AddTicks(4700)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Screening", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacity")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("MovieId")
                        .HasColumnType("integer");

                    b.Property<int>("ScreenNumber")
                        .HasColumnType("integer");

                    b.Property<DateTime>("StartsAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("Screenings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Capacity = 50,
                            CreatedAt = new DateTime(2024, 9, 13, 8, 21, 31, 808, DateTimeKind.Utc).AddTicks(4726),
                            MovieId = 1,
                            ScreenNumber = 1,
                            StartsAt = new DateTime(2024, 9, 13, 8, 21, 31, 808, DateTimeKind.Utc).AddTicks(4723),
                            UpdatedAt = new DateTime(2024, 9, 13, 8, 21, 31, 808, DateTimeKind.Utc).AddTicks(4726)
                        },
                        new
                        {
                            Id = 2,
                            Capacity = 100,
                            CreatedAt = new DateTime(2024, 9, 13, 8, 21, 31, 808, DateTimeKind.Utc).AddTicks(4728),
                            MovieId = 2,
                            ScreenNumber = 2,
                            StartsAt = new DateTime(2024, 9, 13, 8, 21, 31, 808, DateTimeKind.Utc).AddTicks(4727),
                            UpdatedAt = new DateTime(2024, 9, 13, 8, 21, 31, 808, DateTimeKind.Utc).AddTicks(4728)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Screening", b =>
                {
                    b.HasOne("api_cinema_challenge.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");
                });
#pragma warning restore 612, 618
        }
    }
}
