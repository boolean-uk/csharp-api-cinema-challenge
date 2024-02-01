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
    [Migration("20240201151231_CreateAllTables")]
    partial class CreateAllTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("api_cinema_challenge.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("MovieId"));

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("descriptions");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("ratings");

                    b.Property<int>("RuntimeMins")
                        .HasColumnType("integer")
                        .HasColumnName("runtime_in_mins");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("titles");

                    b.Property<DateTime>("Updated_at")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("MovieId");

                    b.ToTable("movies");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            Created_at = new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8679),
                            Description = "A computer hacker learns about the true nature of his reality",
                            Rating = "R",
                            RuntimeMins = 136,
                            Title = "The Matrix",
                            Updated_at = new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8680)
                        },
                        new
                        {
                            MovieId = 2,
                            Created_at = new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8681),
                            Description = "A thief who enters the dreams of others to steal their secrets",
                            Rating = "PG-13",
                            RuntimeMins = 148,
                            Title = "Inception",
                            Updated_at = new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8682)
                        },
                        new
                        {
                            MovieId = 3,
                            Created_at = new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8683),
                            Description = "Two imprisoned men bond over a number of years",
                            Rating = "R",
                            RuntimeMins = 142,
                            Title = "The Shawshank Redemption",
                            Updated_at = new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8683)
                        },
                        new
                        {
                            MovieId = 4,
                            Created_at = new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8685),
                            Description = "Various interconnected stories of criminals in Los Angeles",
                            Rating = "R",
                            RuntimeMins = 154,
                            Title = "Pulp Fiction",
                            Updated_at = new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8685)
                        },
                        new
                        {
                            MovieId = 5,
                            Created_at = new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8686),
                            Description = "The aging patriarch of an organized crime dynasty transfers control to his son",
                            Rating = "R",
                            RuntimeMins = 175,
                            Title = "The Godfather",
                            Updated_at = new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8687)
                        },
                        new
                        {
                            MovieId = 6,
                            Created_at = new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8688),
                            Description = "A man with a low IQ witnesses and unwittingly influences several defining historical events",
                            Rating = "PG-13",
                            RuntimeMins = 142,
                            Title = "Forrest Gump",
                            Updated_at = new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8688)
                        },
                        new
                        {
                            MovieId = 7,
                            Created_at = new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8689),
                            Description = "A masked vigilante battles the criminal underworld in Gotham City",
                            Rating = "PG-13",
                            RuntimeMins = 152,
                            Title = "The Dark Knight",
                            Updated_at = new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8690)
                        },
                        new
                        {
                            MovieId = 8,
                            Created_at = new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8691),
                            Description = "An insomniac office worker and a soapmaker form an underground fight club",
                            Rating = "R",
                            RuntimeMins = 139,
                            Title = "Fight Club",
                            Updated_at = new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8691)
                        },
                        new
                        {
                            MovieId = 9,
                            Created_at = new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8692),
                            Description = "A young FBI cadet must receive the help of an incarcerated and manipulative cannibal killer",
                            Rating = "R",
                            RuntimeMins = 118,
                            Title = "The Silence of the Lambs",
                            Updated_at = new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8693)
                        },
                        new
                        {
                            MovieId = 10,
                            Created_at = new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8694),
                            Description = "In Nazi-occupied France, a group of Jewish-American soldiers plan to assassinate Hitler",
                            Rating = "R",
                            RuntimeMins = 153,
                            Title = "Inglourious Basterds",
                            Updated_at = new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8695)
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
                        .HasColumnName("capacities");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<int>("MovieId")
                        .HasColumnType("integer");

                    b.Property<int>("ScreenNumber")
                        .HasColumnType("integer")
                        .HasColumnName("screen_numbers");

                    b.Property<DateTime>("StartsAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("starts_at");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("screenings");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserId"));

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("emails");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("names");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("phonenumbers");

                    b.Property<DateTime>("Updated_at")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("UserId");

                    b.ToTable("users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Created_at = new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8465),
                            Email = "john.doe@example.com",
                            Name = "John Doe",
                            Phone = "+1234567890",
                            Updated_at = new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8471)
                        },
                        new
                        {
                            UserId = 2,
                            Created_at = new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8475),
                            Email = "jane.smith@example.com",
                            Name = "Jane Smith",
                            Phone = "+9876543210",
                            Updated_at = new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8476)
                        },
                        new
                        {
                            UserId = 3,
                            Created_at = new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8477),
                            Email = "alice.johnson@example.com",
                            Name = "Alice Johnson",
                            Phone = "+1122334455",
                            Updated_at = new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8477)
                        },
                        new
                        {
                            UserId = 4,
                            Created_at = new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8478),
                            Email = "bob.anderson@example.com",
                            Name = "Bob Anderson",
                            Phone = "+9988776655",
                            Updated_at = new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8479)
                        },
                        new
                        {
                            UserId = 5,
                            Created_at = new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8480),
                            Email = "eva.white@example.com",
                            Name = "Eva White",
                            Phone = "+6677889900",
                            Updated_at = new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8480)
                        },
                        new
                        {
                            UserId = 6,
                            Created_at = new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8481),
                            Email = "david.brown@example.com",
                            Name = "David Brown",
                            Phone = "+1122337788",
                            Updated_at = new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8482)
                        },
                        new
                        {
                            UserId = 7,
                            Created_at = new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8483),
                            Email = "sophia.miller@example.com",
                            Name = "Sophia Miller",
                            Phone = "+9988771122",
                            Updated_at = new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8483)
                        },
                        new
                        {
                            UserId = 8,
                            Created_at = new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8484),
                            Email = "michael.wilson@example.com",
                            Name = "Michael Wilson",
                            Phone = "+4455667788",
                            Updated_at = new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8484)
                        },
                        new
                        {
                            UserId = 9,
                            Created_at = new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8485),
                            Email = "olivia.davis@example.com",
                            Name = "Olivia Davis",
                            Phone = "+1122334466",
                            Updated_at = new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8486)
                        },
                        new
                        {
                            UserId = 10,
                            Created_at = new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8487),
                            Email = "daniel.taylor@example.com",
                            Name = "Daniel Taylor",
                            Phone = "+9988775544",
                            Updated_at = new DateTime(2024, 2, 1, 15, 12, 28, 598, DateTimeKind.Utc).AddTicks(8487)
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

            modelBuilder.Entity("api_cinema_challenge.Models.Movie", b =>
                {
                    b.Navigation("Screenings");
                });
#pragma warning restore 612, 618
        }
    }
}