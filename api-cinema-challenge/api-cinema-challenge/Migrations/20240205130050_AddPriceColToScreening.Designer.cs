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
    [Migration("20240205130050_AddPriceColToScreening")]
    partial class AddPriceColToScreening
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("api_cinema_challenge.Models.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("CustomerId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Bookings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140),
                            CustomerId = 1,
                            UpdatedAt = new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140),
                            CustomerId = 2,
                            UpdatedAt = new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140)
                        });
                });

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
                            CreatedAt = new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140),
                            Email = "john.doe@example.com",
                            Name = "John Doe",
                            Phone = "123-456-7890",
                            UpdatedAt = new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140),
                            Email = "jane.smith@example.com",
                            Name = "Jane Smith",
                            Phone = "098-765-4321",
                            UpdatedAt = new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140),
                            Email = "alice.johnson@example.com",
                            Name = "Alice Johnson",
                            Phone = "123-555-7890",
                            UpdatedAt = new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140)
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

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("Runtime")
                        .HasColumnType("timestamp with time zone");

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
                            CreatedAt = new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140),
                            Description = "An epic adventure.",
                            Director = "Alice Jones",
                            Rating = "PG",
                            ReleaseDate = new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Utc),
                            Runtime = new DateTime(2024, 1, 2, 2, 0, 0, 0, DateTimeKind.Utc),
                            Title = "The Great Adventure",
                            UpdatedAt = new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140),
                            Description = "A journey through space.",
                            Director = "Chris Nolan",
                            Rating = "PG-13",
                            ReleaseDate = new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Utc),
                            Runtime = new DateTime(2024, 1, 2, 2, 30, 0, 0, DateTimeKind.Utc),
                            Title = "Space Odyssey",
                            UpdatedAt = new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Screen", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Screens");

                    b.HasData(
                        new
                        {
                            id = 1,
                            CreatedAt = new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140),
                            UpdatedAt = new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140),
                            name = "Screen 1"
                        },
                        new
                        {
                            id = 2,
                            CreatedAt = new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140),
                            UpdatedAt = new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140),
                            name = "Screen 2"
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Screening", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("MovieId")
                        .HasColumnType("integer");

                    b.Property<int>("ScreenId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("StartsAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("price")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasAlternateKey("ScreenId", "StartsAt");

                    b.HasIndex("MovieId");

                    b.ToTable("Screenings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140),
                            MovieId = 1,
                            ScreenId = 1,
                            StartsAt = new DateTime(2024, 2, 5, 16, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140),
                            UpdatedAt = new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140),
                            price = 100
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140),
                            MovieId = 2,
                            ScreenId = 2,
                            StartsAt = new DateTime(2024, 2, 5, 18, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140),
                            UpdatedAt = new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140),
                            price = 100
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Seat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("ScreenId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("rowNumber")
                        .HasColumnType("integer");

                    b.Property<int>("seatNumber")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasAlternateKey("ScreenId", "seatNumber");

                    b.ToTable("Seats");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140),
                            ScreenId = 1,
                            UpdatedAt = new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140),
                            rowNumber = 1,
                            seatNumber = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140),
                            ScreenId = 1,
                            UpdatedAt = new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140),
                            rowNumber = 1,
                            seatNumber = 2
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140),
                            ScreenId = 1,
                            UpdatedAt = new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140),
                            rowNumber = 2,
                            seatNumber = 3
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140),
                            ScreenId = 1,
                            UpdatedAt = new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140),
                            rowNumber = 2,
                            seatNumber = 4
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140),
                            ScreenId = 2,
                            UpdatedAt = new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140),
                            rowNumber = 1,
                            seatNumber = 1
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140),
                            ScreenId = 2,
                            UpdatedAt = new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140),
                            rowNumber = 1,
                            seatNumber = 2
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140),
                            ScreenId = 2,
                            UpdatedAt = new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140),
                            rowNumber = 2,
                            seatNumber = 3
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140),
                            ScreenId = 2,
                            UpdatedAt = new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140),
                            rowNumber = 2,
                            seatNumber = 4
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Ticket", b =>
                {
                    b.Property<int>("screeningId")
                        .HasColumnType("integer");

                    b.Property<int>("seatId")
                        .HasColumnType("integer");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("bookingId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<float>("price")
                        .HasColumnType("real");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("screeningId", "seatId");

                    b.HasAlternateKey("Id");

                    b.HasIndex("bookingId");

                    b.HasIndex("seatId");

                    b.ToTable("Tickets");

                    b.HasData(
                        new
                        {
                            screeningId = 1,
                            seatId = 1,
                            Id = 1,
                            bookingId = 1,
                            createdAt = new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140),
                            price = 12.5f,
                            updatedAt = new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140)
                        },
                        new
                        {
                            screeningId = 1,
                            seatId = 2,
                            Id = 2,
                            createdAt = new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140),
                            price = 12.5f,
                            updatedAt = new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140)
                        },
                        new
                        {
                            screeningId = 2,
                            seatId = 1,
                            Id = 3,
                            bookingId = 2,
                            createdAt = new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140),
                            price = 15f,
                            updatedAt = new DateTime(2024, 2, 5, 13, 0, 49, 776, DateTimeKind.Utc).AddTicks(6140)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Booking", b =>
                {
                    b.HasOne("api_cinema_challenge.Models.Customer", "Customer")
                        .WithMany("Bookings")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Screening", b =>
                {
                    b.HasOne("api_cinema_challenge.Models.Movie", "Movie")
                        .WithMany("Screenings")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("api_cinema_challenge.Models.Screen", "Screen")
                        .WithMany("Screenings")
                        .HasForeignKey("ScreenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("Screen");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Seat", b =>
                {
                    b.HasOne("api_cinema_challenge.Models.Screen", "Screen")
                        .WithMany("Seats")
                        .HasForeignKey("ScreenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Screen");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Ticket", b =>
                {
                    b.HasOne("api_cinema_challenge.Models.Booking", "booking")
                        .WithMany("tickets")
                        .HasForeignKey("bookingId");

                    b.HasOne("api_cinema_challenge.Models.Screening", "screening")
                        .WithMany("Tickets")
                        .HasForeignKey("screeningId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("api_cinema_challenge.Models.Seat", "seat")
                        .WithMany("Tickets")
                        .HasForeignKey("seatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("booking");

                    b.Navigation("screening");

                    b.Navigation("seat");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Booking", b =>
                {
                    b.Navigation("tickets");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Customer", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Movie", b =>
                {
                    b.Navigation("Screenings");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Screen", b =>
                {
                    b.Navigation("Screenings");

                    b.Navigation("Seats");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Screening", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Seat", b =>
                {
                    b.Navigation("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}
