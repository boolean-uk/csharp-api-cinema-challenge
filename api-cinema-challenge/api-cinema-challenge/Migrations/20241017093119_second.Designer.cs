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
    [Migration("20241017093119_second")]
    partial class second
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
                        .HasColumnName("createdat");

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
                        .HasColumnName("updatedat");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 10, 17, 9, 31, 18, 591, DateTimeKind.Utc).AddTicks(4205),
                            Email = "John@mail.no",
                            Name = "John Bravo",
                            Phone = "99887766",
                            UpdatedAt = new DateTime(2024, 10, 17, 9, 31, 18, 591, DateTimeKind.Utc).AddTicks(4206)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 10, 17, 9, 31, 18, 591, DateTimeKind.Utc).AddTicks(4208),
                            Email = "Fly@mail.no",
                            Name = "Thomas Fly",
                            Phone = "98765432",
                            UpdatedAt = new DateTime(2024, 10, 17, 9, 31, 18, 591, DateTimeKind.Utc).AddTicks(4208)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 10, 17, 9, 31, 18, 591, DateTimeKind.Utc).AddTicks(4210),
                            Email = "Ibb@live.no",
                            Name = "Ibby Secka",
                            Phone = "45094509",
                            UpdatedAt = new DateTime(2024, 10, 17, 9, 31, 18, 591, DateTimeKind.Utc).AddTicks(4210)
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
                        .HasColumnName("createdat");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("rating");

                    b.Property<int>("RuntimeMins")
                        .HasColumnType("integer")
                        .HasColumnName("runtimeMins");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updatedat");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 10, 17, 9, 31, 18, 591, DateTimeKind.Utc).AddTicks(4320),
                            Description = "Leo in Hollywood",
                            Rating = "9.3",
                            RuntimeMins = 220,
                            Title = "Once Upon A Time In Hollywood",
                            UpdatedAt = new DateTime(2024, 10, 17, 9, 31, 18, 591, DateTimeKind.Utc).AddTicks(4321)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 10, 17, 9, 31, 18, 591, DateTimeKind.Utc).AddTicks(4323),
                            Description = "Iron suit man kills enemies.",
                            Rating = "7.3",
                            RuntimeMins = 180,
                            Title = "Iron Man",
                            UpdatedAt = new DateTime(2024, 10, 17, 9, 31, 18, 591, DateTimeKind.Utc).AddTicks(4323)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 10, 17, 9, 31, 18, 591, DateTimeKind.Utc).AddTicks(4324),
                            Description = "Man in space",
                            Rating = "8",
                            RuntimeMins = 90,
                            Title = "Interstellar",
                            UpdatedAt = new DateTime(2024, 10, 17, 9, 31, 18, 591, DateTimeKind.Utc).AddTicks(4325)
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
                        .HasColumnName("createdat");

                    b.Property<int>("MovieId")
                        .HasColumnType("integer")
                        .HasColumnName("movieid");

                    b.Property<int>("ScreenNumber")
                        .HasColumnType("integer")
                        .HasColumnName("screennumber");

                    b.Property<DateTime>("StartsAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("startsat");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updatedat");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("Screenings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Capacity = 50,
                            CreatedAt = new DateTime(2024, 10, 17, 9, 31, 18, 591, DateTimeKind.Utc).AddTicks(4343),
                            MovieId = 1,
                            ScreenNumber = 1,
                            StartsAt = new DateTime(2024, 10, 17, 13, 31, 18, 591, DateTimeKind.Utc).AddTicks(4337),
                            UpdatedAt = new DateTime(2024, 10, 17, 9, 31, 18, 591, DateTimeKind.Utc).AddTicks(4343)
                        },
                        new
                        {
                            Id = 2,
                            Capacity = 30,
                            CreatedAt = new DateTime(2024, 10, 17, 9, 31, 18, 591, DateTimeKind.Utc).AddTicks(4346),
                            MovieId = 1,
                            ScreenNumber = 2,
                            StartsAt = new DateTime(2024, 10, 17, 14, 31, 18, 591, DateTimeKind.Utc).AddTicks(4345),
                            UpdatedAt = new DateTime(2024, 10, 17, 9, 31, 18, 591, DateTimeKind.Utc).AddTicks(4346)
                        },
                        new
                        {
                            Id = 3,
                            Capacity = 50,
                            CreatedAt = new DateTime(2024, 10, 17, 9, 31, 18, 591, DateTimeKind.Utc).AddTicks(4348),
                            MovieId = 2,
                            ScreenNumber = 3,
                            StartsAt = new DateTime(2024, 10, 17, 14, 31, 18, 591, DateTimeKind.Utc).AddTicks(4347),
                            UpdatedAt = new DateTime(2024, 10, 17, 9, 31, 18, 591, DateTimeKind.Utc).AddTicks(4348)
                        },
                        new
                        {
                            Id = 4,
                            Capacity = 25,
                            CreatedAt = new DateTime(2024, 10, 17, 9, 31, 18, 591, DateTimeKind.Utc).AddTicks(4350),
                            MovieId = 3,
                            ScreenNumber = 4,
                            StartsAt = new DateTime(2024, 10, 17, 16, 31, 18, 591, DateTimeKind.Utc).AddTicks(4349),
                            UpdatedAt = new DateTime(2024, 10, 17, 9, 31, 18, 591, DateTimeKind.Utc).AddTicks(4350)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("createdat");

                    b.Property<int>("CustomerId")
                        .HasColumnType("integer")
                        .HasColumnName("customerid");

                    b.Property<int>("NumSeats")
                        .HasColumnType("integer")
                        .HasColumnName("numseats");

                    b.Property<int>("ScreeningId")
                        .HasColumnType("integer")
                        .HasColumnName("screeningId");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updatedat");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ScreeningId");

                    b.ToTable("Tickets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 10, 17, 9, 31, 18, 591, DateTimeKind.Utc).AddTicks(4364),
                            CustomerId = 1,
                            NumSeats = 4,
                            ScreeningId = 1,
                            UpdatedAt = new DateTime(2024, 10, 17, 9, 31, 18, 591, DateTimeKind.Utc).AddTicks(4364)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 10, 17, 9, 31, 18, 591, DateTimeKind.Utc).AddTicks(4366),
                            CustomerId = 2,
                            NumSeats = 27,
                            ScreeningId = 3,
                            UpdatedAt = new DateTime(2024, 10, 17, 9, 31, 18, 591, DateTimeKind.Utc).AddTicks(4366)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 10, 17, 9, 31, 18, 591, DateTimeKind.Utc).AddTicks(4368),
                            CustomerId = 3,
                            NumSeats = 12,
                            ScreeningId = 2,
                            UpdatedAt = new DateTime(2024, 10, 17, 9, 31, 18, 591, DateTimeKind.Utc).AddTicks(4368)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Screening", b =>
                {
                    b.HasOne("api_cinema_challenge.Models.Movie", "Movie")
                        .WithMany("Screenings")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Ticket", b =>
                {
                    b.HasOne("api_cinema_challenge.Models.Customer", "Customer")
                        .WithMany("Tickets")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("api_cinema_challenge.Models.Screening", "Screening")
                        .WithMany("Tickets")
                        .HasForeignKey("ScreeningId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Screening");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Customer", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Movie", b =>
                {
                    b.Navigation("Screenings");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Screening", b =>
                {
                    b.Navigation("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}
