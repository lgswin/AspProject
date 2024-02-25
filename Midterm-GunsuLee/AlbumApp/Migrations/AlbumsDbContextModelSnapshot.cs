﻿// <auto-generated />
using AlbumApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AlbumApp.Migrations
{
    [DbContext(typeof(AlbumsDbContext))]
    partial class AlbumsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AlbumApp.Entities.Album", b =>
                {
                    b.Property<int>("AlbumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AlbumId"));

                    b.Property<string>("Artist")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<string>("Song")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AlbumId");

                    b.ToTable("Albums");

                    b.HasData(
                        new
                        {
                            AlbumId = 1,
                            Artist = "The Clash",
                            Rating = 9.8000000000000007,
                            Song = "Lost In The Supermarket",
                            Title = "To Seek the Truth of The Cosmos"
                        },
                        new
                        {
                            AlbumId = 2,
                            Artist = "George Harrison",
                            Rating = 9.5,
                            Song = "All Things Must Pass",
                            Title = "Beyond The Veil of Time"
                        },
                        new
                        {
                            AlbumId = 3,
                            Artist = "the Beatles",
                            Rating = 9.5,
                            Song = "Let It Be",
                            Title = "Bad Company"
                        },
                        new
                        {
                            AlbumId = 4,
                            Artist = "John Lennon",
                            Rating = 9.0999999999999996,
                            Song = "Imagine",
                            Title = "Ready, Set, Go!"
                        },
                        new
                        {
                            AlbumId = 5,
                            Artist = "Elton John",
                            Rating = 8.8000000000000007,
                            Song = "Your Song",
                            Title = "The Rhythm of Life"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
