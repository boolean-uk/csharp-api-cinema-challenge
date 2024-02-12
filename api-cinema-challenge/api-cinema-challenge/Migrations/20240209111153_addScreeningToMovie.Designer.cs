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
    [Migration("20240209111153_addScreeningToMovie")]
    partial class addScreeningToMovie
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("api_cinema_challenge.Models.DataClasses.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("ticket_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("ticket_created_at");

                    b.Property<int>("CustomerId")
                        .HasColumnType("integer")
                        .HasColumnName("fk_customer_id");

                    b.Property<int>("NumSeats")
                        .HasColumnType("integer");

                    b.Property<int>("ScreeningId")
                        .HasColumnType("integer")
                        .HasColumnName("fk_screening_id");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("ticket_updated_at");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ScreeningId");

                    b.ToTable("Tickets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 8, 14, 22, 0, 0, 0, DateTimeKind.Utc),
                            CustomerId = 1,
                            NumSeats = 3,
                            ScreeningId = 1,
                            UpdatedAt = new DateTime(2024, 8, 14, 22, 0, 0, 0, DateTimeKind.Utc)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.NewFolder.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("customer_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("customer_created_at");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("customer_email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("customer_name");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("customer_phone");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("customer_updated_at");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 6, 9, 22, 0, 0, 0, DateTimeKind.Utc),
                            Email = "FrankOcean@Orange.com",
                            Name = "Frank Ocean",
                            Phone = "+3382798719",
                            UpdatedAt = new DateTime(2024, 6, 9, 22, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 7, 4, 22, 0, 0, 0, DateTimeKind.Utc),
                            Email = "Alice@Wonderland.com",
                            Name = "Alice Wonderland",
                            Phone = "+44123456789",
                            UpdatedAt = new DateTime(2024, 7, 4, 22, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 8, 14, 22, 0, 0, 0, DateTimeKind.Utc),
                            Email = "JohnDoe@email.com",
                            Name = "John Doe",
                            Phone = "+15555555555",
                            UpdatedAt = new DateTime(2024, 8, 14, 22, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 9, 24, 22, 0, 0, 0, DateTimeKind.Utc),
                            Email = "MiaJohnson@email.com",
                            Name = "Mia Johnson",
                            Phone = "+18881234567",
                            UpdatedAt = new DateTime(2024, 9, 24, 22, 0, 0, 0, DateTimeKind.Utc)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.NewFolder.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("movie_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("movie_created_at");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("movie_description");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("movie_rating");

                    b.Property<int>("Runtime")
                        .HasColumnType("integer")
                        .HasColumnName("movie_runtime");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("movie_title");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("movie_update_at");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 3, 1, 23, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Movie about dragons",
                            Rating = "Excellent",
                            Runtime = 145,
                            Title = "How to Train your Dragon",
                            UpdatedAt = new DateTime(2024, 3, 1, 23, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 4, 14, 22, 0, 0, 0, DateTimeKind.Utc),
                            Description = "A magical journey in a hidden garden",
                            Rating = "Enchanting",
                            Runtime = 110,
                            Title = "The Secret Garden",
                            UpdatedAt = new DateTime(2024, 4, 14, 22, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 5, 19, 22, 0, 0, 0, DateTimeKind.Utc),
                            Description = "A mind-bending heist in dreams",
                            Rating = "Masterpiece",
                            Runtime = 148,
                            Title = "Inception",
                            UpdatedAt = new DateTime(2024, 5, 19, 22, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 6, 9, 22, 0, 0, 0, DateTimeKind.Utc),
                            Description = "A superhero's journey to save the world",
                            Rating = "Epic",
                            Runtime = 152,
                            Title = "Wonder Woman",
                            UpdatedAt = new DateTime(2024, 6, 9, 22, 0, 0, 0, DateTimeKind.Utc)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.NewFolder.Screening", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("screening_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacity")
                        .HasColumnType("integer")
                        .HasColumnName("screening_capacity");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("screening_created_at");

                    b.Property<int>("MovieId")
                        .HasColumnType("integer")
                        .HasColumnName("fk_movie_id");

                    b.Property<int>("ScreenNumber")
                        .HasColumnType("integer")
                        .HasColumnName("screening_screen_number");

                    b.Property<DateTime>("StartsAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("screening_starts_at");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("screening_updated_at");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("Screenings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Capacity = 30,
                            CreatedAt = new DateTime(2024, 8, 14, 22, 0, 0, 0, DateTimeKind.Utc),
                            MovieId = 1,
                            ScreenNumber = 1,
                            StartsAt = new DateTime(2024, 9, 24, 22, 0, 0, 0, DateTimeKind.Utc),
                            UpdatedAt = new DateTime(2024, 8, 14, 22, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 2,
                            Capacity = 40,
                            CreatedAt = new DateTime(2024, 9, 4, 22, 0, 0, 0, DateTimeKind.Utc),
                            MovieId = 2,
                            ScreenNumber = 5,
                            StartsAt = new DateTime(2024, 10, 9, 22, 0, 0, 0, DateTimeKind.Utc),
                            UpdatedAt = new DateTime(2024, 9, 4, 22, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 3,
                            Capacity = 25,
                            CreatedAt = new DateTime(2024, 10, 19, 22, 0, 0, 0, DateTimeKind.Utc),
                            MovieId = 3,
                            ScreenNumber = 2,
                            StartsAt = new DateTime(2024, 10, 31, 23, 0, 0, 0, DateTimeKind.Utc),
                            UpdatedAt = new DateTime(2024, 10, 19, 22, 0, 0, 0, DateTimeKind.Utc)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.DataClasses.Ticket", b =>
                {
                    b.HasOne("api_cinema_challenge.Models.NewFolder.Customer", null)
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("api_cinema_challenge.Models.NewFolder.Screening", null)
                        .WithMany()
                        .HasForeignKey("ScreeningId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("api_cinema_challenge.Models.NewFolder.Screening", b =>
                {
                    b.HasOne("api_cinema_challenge.Models.NewFolder.Movie", null)
                        .WithMany("Screenings")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("api_cinema_challenge.Models.NewFolder.Movie", b =>
                {
                    b.Navigation("Screenings");
                });
#pragma warning restore 612, 618
        }
    }
}
