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
                .HasAnnotation("ProductVersion", "8.0.1")
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
                        .HasColumnName("created_at")
                        .HasAnnotation("Identity", new DateTime(2024, 2, 9, 9, 11, 3, 312, DateTimeKind.Utc).AddTicks(1758));

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
                        .HasColumnName("updated_at")
                        .HasAnnotation("Computed", new DateTime(2024, 2, 9, 9, 11, 3, 312, DateTimeKind.Utc).AddTicks(3858));

                    b.HasKey("Id")
                        .HasAnnotation("Identity", 1);

                    b.ToTable("customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 2, 9, 9, 11, 3, 314, DateTimeKind.Utc).AddTicks(5045),
                            Email = "Oscar@Olsson.com",
                            Name = "Oscar Olsson",
                            Phone = "09876543",
                            UpdatedAt = new DateTime(2024, 2, 9, 9, 11, 3, 314, DateTimeKind.Utc).AddTicks(5055)
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
                        .HasColumnName("created_at")
                        .HasAnnotation("Identity", new DateTime(2024, 2, 9, 9, 11, 3, 312, DateTimeKind.Utc).AddTicks(2287));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<int>("Rating")
                        .HasColumnType("integer")
                        .HasColumnName("rating");

                    b.Property<double>("RunTime")
                        .HasColumnType("double precision")
                        .HasColumnName("runtime_mins");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at")
                        .HasAnnotation("Computed", new DateTime(2024, 2, 9, 9, 11, 3, 312, DateTimeKind.Utc).AddTicks(4249));

                    b.HasKey("Id");

                    b.ToTable("movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 2, 9, 9, 11, 3, 314, DateTimeKind.Utc).AddTicks(5261),
                            Description = "Horror movie by famous programmer Steven",
                            Rating = 3,
                            RunTime = 124.0,
                            Title = "Empty Relations",
                            UpdatedAt = new DateTime(2024, 2, 9, 9, 11, 3, 314, DateTimeKind.Utc).AddTicks(5261)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 2, 9, 9, 11, 3, 314, DateTimeKind.Utc).AddTicks(5291),
                            Description = "Follow up from Steven",
                            Rating = 5,
                            RunTime = 124.0,
                            Title = "Empty Relations 2",
                            UpdatedAt = new DateTime(2024, 2, 9, 9, 11, 3, 314, DateTimeKind.Utc).AddTicks(5292)
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
                        .HasColumnName("created_at")
                        .HasAnnotation("Identity", new DateTime(2024, 2, 9, 9, 11, 3, 312, DateTimeKind.Utc).AddTicks(2881));

                    b.Property<int>("MovieId")
                        .HasColumnType("integer")
                        .HasColumnName("fk_movie_id");

                    b.Property<int>("ScreenNumber")
                        .HasColumnType("integer")
                        .HasColumnName("screen_number");

                    b.Property<DateTime>("StartsAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("starts_at");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at")
                        .HasAnnotation("Computed", new DateTime(2024, 2, 9, 9, 11, 3, 312, DateTimeKind.Utc).AddTicks(4748));

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("screenings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Capacity = 320,
                            CreatedAt = new DateTime(2024, 2, 9, 9, 11, 3, 314, DateTimeKind.Utc).AddTicks(5296),
                            MovieId = 1,
                            ScreenNumber = 2,
                            StartsAt = new DateTime(2024, 4, 10, 8, 10, 0, 0, DateTimeKind.Utc),
                            UpdatedAt = new DateTime(2024, 2, 9, 9, 11, 3, 314, DateTimeKind.Utc).AddTicks(5296)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Ticket", b =>
                {
                    b.Property<int>("ScreeningId")
                        .HasColumnType("integer")
                        .HasColumnName("fk_screening_id");

                    b.Property<int>("CustomerId")
                        .HasColumnType("integer")
                        .HasColumnName("fk_customer_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at")
                        .HasAnnotation("Identity", new DateTime(2024, 2, 9, 9, 11, 3, 312, DateTimeKind.Utc).AddTicks(3399));

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("NumSeats")
                        .HasColumnType("integer")
                        .HasColumnName("num_seats");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at")
                        .HasAnnotation("Computed", new DateTime(2024, 2, 9, 9, 11, 3, 312, DateTimeKind.Utc).AddTicks(5372));

                    b.HasKey("ScreeningId", "CustomerId");

                    b.HasIndex("CustomerId");

                    b.ToTable("tickets");

                    b.HasData(
                        new
                        {
                            ScreeningId = 1,
                            CustomerId = 1,
                            CreatedAt = new DateTime(2024, 2, 9, 9, 11, 3, 314, DateTimeKind.Utc).AddTicks(5341),
                            Id = 0,
                            NumSeats = 3,
                            UpdatedAt = new DateTime(2024, 2, 9, 9, 11, 3, 314, DateTimeKind.Utc).AddTicks(5342)
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
