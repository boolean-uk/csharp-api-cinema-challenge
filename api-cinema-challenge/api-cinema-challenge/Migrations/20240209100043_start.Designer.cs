﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using api_cinema_challenge.Data;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    [DbContext(typeof(CinemaContext))]
    [Migration("20240209100043_start")]
    partial class start
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("api_cinema_challenge.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("createdAt");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("phone");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updatedAt");

                    b.HasKey("Id");

                    b.ToTable("customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 2, 9, 10, 0, 43, 747, DateTimeKind.Utc).AddTicks(5207),
                            Email = "First.Name@email.provider",
                            Name = "First Name",
                            Phone = "+01 012 34 567",
                            UpdatedAt = new DateTime(2024, 2, 9, 10, 0, 43, 747, DateTimeKind.Utc).AddTicks(5208)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 2, 9, 10, 0, 43, 747, DateTimeKind.Utc).AddTicks(5211),
                            Email = "Second.Name@email.provider",
                            Name = "Second Name",
                            Phone = "+01 112 34 567",
                            UpdatedAt = new DateTime(2024, 2, 9, 10, 0, 43, 747, DateTimeKind.Utc).AddTicks(5212)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 2, 9, 10, 0, 43, 747, DateTimeKind.Utc).AddTicks(5213),
                            Email = "Third.Name@email.provider",
                            Name = "Third Name",
                            Phone = "+01 122 34 567",
                            UpdatedAt = new DateTime(2024, 2, 9, 10, 0, 43, 747, DateTimeKind.Utc).AddTicks(5214)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("createdAt");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<int>("RuntimeMins")
                        .HasColumnType("integer")
                        .HasColumnName("rutimeMins");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updatedAt");

                    b.HasKey("Id");

                    b.ToTable("movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 2, 9, 10, 0, 43, 747, DateTimeKind.Utc).AddTicks(5238),
                            Description = "description",
                            RuntimeMins = 1,
                            Title = "title",
                            UpdatedAt = new DateTime(2024, 2, 9, 10, 0, 43, 747, DateTimeKind.Utc).AddTicks(5239)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 2, 9, 10, 0, 43, 747, DateTimeKind.Utc).AddTicks(5241),
                            Description = "Another description",
                            RuntimeMins = 1,
                            Title = "title1",
                            UpdatedAt = new DateTime(2024, 2, 9, 10, 0, 43, 747, DateTimeKind.Utc).AddTicks(5241)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 2, 9, 10, 0, 43, 747, DateTimeKind.Utc).AddTicks(5243),
                            Description = "Yet another description",
                            RuntimeMins = 1,
                            Title = "title2",
                            UpdatedAt = new DateTime(2024, 2, 9, 10, 0, 43, 747, DateTimeKind.Utc).AddTicks(5243)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Screening", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacity")
                        .HasColumnType("integer")
                        .HasColumnName("capacity");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("createdAt");

                    b.Property<int>("ScreenNumber")
                        .HasColumnType("integer")
                        .HasColumnName("screenNumber");

                    b.Property<DateTime>("StartsAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("startsAt");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updatedAt");

                    b.HasKey("Id");

                    b.ToTable("screening");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Capacity = 1,
                            CreatedAt = new DateTime(2024, 2, 9, 10, 0, 43, 747, DateTimeKind.Utc).AddTicks(5260),
                            ScreenNumber = 1,
                            StartsAt = new DateTime(2024, 2, 9, 20, 0, 0, 0, DateTimeKind.Utc),
                            UpdatedAt = new DateTime(2024, 2, 9, 10, 0, 43, 747, DateTimeKind.Utc).AddTicks(5260)
                        },
                        new
                        {
                            Id = 2,
                            Capacity = 1,
                            CreatedAt = new DateTime(2024, 2, 9, 10, 0, 43, 747, DateTimeKind.Utc).AddTicks(5265),
                            ScreenNumber = 1,
                            StartsAt = new DateTime(2024, 2, 11, 20, 0, 0, 0, DateTimeKind.Utc),
                            UpdatedAt = new DateTime(2024, 2, 9, 10, 0, 43, 747, DateTimeKind.Utc).AddTicks(5265)
                        },
                        new
                        {
                            Id = 3,
                            Capacity = 1,
                            CreatedAt = new DateTime(2024, 2, 9, 10, 0, 43, 747, DateTimeKind.Utc).AddTicks(5267),
                            ScreenNumber = 1,
                            StartsAt = new DateTime(2024, 2, 15, 20, 0, 0, 0, DateTimeKind.Utc),
                            UpdatedAt = new DateTime(2024, 2, 9, 10, 0, 43, 747, DateTimeKind.Utc).AddTicks(5267)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
