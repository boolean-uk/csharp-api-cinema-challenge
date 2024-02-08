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
    [Migration("20240208100520_02BasicTablesSeed")]
    partial class _02BasicTablesSeed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                        .HasColumnName("created_at");

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
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.ToTable("customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8164),
                            Email = "keith.windsor@gov.ru",
                            Name = "Keith Windsor",
                            Phone = "79 70 44 13",
                            UpdatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8165)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8171),
                            Email = "bill.moon@bbc.co.uk",
                            Name = "Bill Moon",
                            Phone = "95 57 08 94",
                            UpdatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8171)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8174),
                            Email = "jimi.moon@something.com",
                            Name = "Jimi Moon",
                            Phone = "49 25 63 99",
                            UpdatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8174)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8177),
                            Email = "elvis.hepburn@google.com",
                            Name = "Elvis Hepburn",
                            Phone = "58 09 24 68",
                            UpdatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8177)
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8180),
                            Email = "oprah.butler@gov.ru",
                            Name = "Oprah Butler",
                            Phone = "97 82 67 94",
                            UpdatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8181)
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8184),
                            Email = "barack.winslet@google.com",
                            Name = "Barack Winslet",
                            Phone = "72 64 60 26",
                            UpdatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8184)
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8187),
                            Email = "ronnie.trump@gov.us",
                            Name = "Ronnie Trump",
                            Phone = "58 76 89 67",
                            UpdatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8187)
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8190),
                            Email = "donald.butler@gov.us",
                            Name = "Donald Butler",
                            Phone = "79 50 61 18",
                            UpdatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8190)
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8193),
                            Email = "barack.trump@bbc.co.uk",
                            Name = "Barack Trump",
                            Phone = "47 18 55 83",
                            UpdatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8193)
                        },
                        new
                        {
                            Id = 10,
                            CreatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8196),
                            Email = "ozzy.middleton@something.com",
                            Name = "Ozzy Middleton",
                            Phone = "79 02 01 31",
                            UpdatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8196)
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
                        .HasColumnName("created_at");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("rating");

                    b.Property<int>("Runtime")
                        .HasColumnType("integer")
                        .HasColumnName("runtime");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.ToTable("movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8199),
                            Description = "The story of Henry Hill and his life in the mafia, covering his relationship with his wife Karen and his mob partners Jimmy Conway and Tommy DeVito.",
                            Rating = "R",
                            Runtime = 148,
                            Title = "Goodfellas",
                            UpdatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8200)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8201),
                            Description = "In 1980 Miami, a determined Cuban immigrant takes over a drug cartel and succumbs to greed.",
                            Rating = "R",
                            Runtime = 170,
                            Title = "Scarface",
                            UpdatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8201)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8202),
                            Description = "A family in 1630s New England is torn apart by the forces of witchcraft, black magic and possession.",
                            Rating = "R",
                            Runtime = 93,
                            Title = "The VVitch: A New-England Folktale",
                            UpdatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8203)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8204),
                            Description = "Vampire Count Orlok expresses interest in a new residence and real estate agent Hutter's wife.",
                            Rating = "Not Rated",
                            Runtime = 94,
                            Title = "Nosferatu",
                            UpdatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8204)
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8205),
                            Description = "When a cockerel apparently flies into a chicken farm, the chickens see him as an opportunity to escape their evil owners.",
                            Rating = "G",
                            Runtime = 84,
                            Title = "Chicken Run",
                            UpdatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8205)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Screening", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<int>("MovieId")
                        .HasColumnType("integer")
                        .HasColumnName("fk_movie_id");

                    b.Property<int>("SilverScreenId")
                        .HasColumnType("integer")
                        .HasColumnName("fk_silver_screen_id");

                    b.Property<DateTime>("StartsAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("starts_at");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.ToTable("screenings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8221),
                            MovieId = 3,
                            SilverScreenId = 2,
                            StartsAt = new DateTime(2024, 2, 8, 13, 5, 19, 789, DateTimeKind.Utc).AddTicks(8215),
                            UpdatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8221)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8223),
                            MovieId = 2,
                            SilverScreenId = 2,
                            StartsAt = new DateTime(2024, 2, 8, 15, 5, 19, 789, DateTimeKind.Utc).AddTicks(8222),
                            UpdatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8223)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8224),
                            MovieId = 1,
                            SilverScreenId = 2,
                            StartsAt = new DateTime(2024, 2, 8, 15, 5, 19, 789, DateTimeKind.Utc).AddTicks(8223),
                            UpdatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8224)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8225),
                            MovieId = 1,
                            SilverScreenId = 2,
                            StartsAt = new DateTime(2024, 2, 8, 13, 5, 19, 789, DateTimeKind.Utc).AddTicks(8225),
                            UpdatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8225)
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8226),
                            MovieId = 3,
                            SilverScreenId = 2,
                            StartsAt = new DateTime(2024, 2, 8, 13, 5, 19, 789, DateTimeKind.Utc).AddTicks(8225),
                            UpdatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8226)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.SilverScreen", b =>
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
                        .HasColumnName("created_at");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.ToTable("silver_screens");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Capacity = 200,
                            CreatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8209),
                            Name = "Inger Johanne",
                            UpdatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8209)
                        },
                        new
                        {
                            Id = 2,
                            Capacity = 50,
                            CreatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8210),
                            Name = "Dikken",
                            UpdatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8210)
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
                        .HasColumnName("created_at");

                    b.Property<int>("CustomerId")
                        .HasColumnType("integer")
                        .HasColumnName("fk_customer_id");

                    b.Property<int>("ScreeningId")
                        .HasColumnType("integer")
                        .HasColumnName("fk_screening_id");

                    b.Property<int>("SeatsBought")
                        .HasColumnType("integer")
                        .HasColumnName("seats_bought");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.ToTable("tickets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8229),
                            CustomerId = 6,
                            ScreeningId = 5,
                            SeatsBought = 0,
                            UpdatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8229)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8230),
                            CustomerId = 10,
                            ScreeningId = 1,
                            SeatsBought = 0,
                            UpdatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8230)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8231),
                            CustomerId = 1,
                            ScreeningId = 3,
                            SeatsBought = 0,
                            UpdatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8231)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8232),
                            CustomerId = 10,
                            ScreeningId = 3,
                            SeatsBought = 0,
                            UpdatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8232)
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8232),
                            CustomerId = 7,
                            ScreeningId = 5,
                            SeatsBought = 0,
                            UpdatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8233)
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8233),
                            CustomerId = 2,
                            ScreeningId = 3,
                            SeatsBought = 0,
                            UpdatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8234)
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8234),
                            CustomerId = 6,
                            ScreeningId = 4,
                            SeatsBought = 0,
                            UpdatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8234)
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8235),
                            CustomerId = 1,
                            ScreeningId = 3,
                            SeatsBought = 0,
                            UpdatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8235)
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8235),
                            CustomerId = 9,
                            ScreeningId = 5,
                            SeatsBought = 0,
                            UpdatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8236)
                        },
                        new
                        {
                            Id = 10,
                            CreatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8236),
                            CustomerId = 5,
                            ScreeningId = 5,
                            SeatsBought = 0,
                            UpdatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8237)
                        },
                        new
                        {
                            Id = 11,
                            CreatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8237),
                            CustomerId = 9,
                            ScreeningId = 2,
                            SeatsBought = 0,
                            UpdatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8237)
                        },
                        new
                        {
                            Id = 12,
                            CreatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8238),
                            CustomerId = 9,
                            ScreeningId = 5,
                            SeatsBought = 0,
                            UpdatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8238)
                        },
                        new
                        {
                            Id = 13,
                            CreatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8238),
                            CustomerId = 8,
                            ScreeningId = 4,
                            SeatsBought = 0,
                            UpdatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8239)
                        },
                        new
                        {
                            Id = 14,
                            CreatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8239),
                            CustomerId = 3,
                            ScreeningId = 5,
                            SeatsBought = 0,
                            UpdatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8239)
                        },
                        new
                        {
                            Id = 15,
                            CreatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8240),
                            CustomerId = 7,
                            ScreeningId = 2,
                            SeatsBought = 0,
                            UpdatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8240)
                        },
                        new
                        {
                            Id = 16,
                            CreatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8240),
                            CustomerId = 7,
                            ScreeningId = 1,
                            SeatsBought = 0,
                            UpdatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8241)
                        },
                        new
                        {
                            Id = 17,
                            CreatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8241),
                            CustomerId = 1,
                            ScreeningId = 3,
                            SeatsBought = 0,
                            UpdatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8241)
                        },
                        new
                        {
                            Id = 18,
                            CreatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8242),
                            CustomerId = 9,
                            ScreeningId = 1,
                            SeatsBought = 0,
                            UpdatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8242)
                        },
                        new
                        {
                            Id = 19,
                            CreatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8243),
                            CustomerId = 3,
                            ScreeningId = 3,
                            SeatsBought = 0,
                            UpdatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8243)
                        },
                        new
                        {
                            Id = 20,
                            CreatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8243),
                            CustomerId = 4,
                            ScreeningId = 3,
                            SeatsBought = 0,
                            UpdatedAt = new DateTime(2024, 2, 8, 10, 5, 19, 789, DateTimeKind.Utc).AddTicks(8244)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
