﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieApp.Data;

namespace MovieApp.Migrations
{
    [DbContext(typeof(MovieDbContext))]
    partial class MovieDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MovieApp.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateRelease")
                        .HasColumnType("datetime2");

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<string>("MainActor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateRelease = new DateTime(2011, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Genre = "Drama",
                            Length = 3,
                            MainActor = "Haluk Bilginer",
                            Title = "Winter sleep"
                        },
                        new
                        {
                            Id = 2,
                            DateRelease = new DateTime(2009, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Genre = "Action",
                            Length = 2,
                            MainActor = "Jean Belmondo",
                            Title = "A Bout De Soufle"
                        },
                        new
                        {
                            Id = 3,
                            DateRelease = new DateTime(1959, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Genre = "Drama",
                            Length = 2,
                            MainActor = "Michael Caine",
                            Title = "Umbrellas of Cherbourg"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}