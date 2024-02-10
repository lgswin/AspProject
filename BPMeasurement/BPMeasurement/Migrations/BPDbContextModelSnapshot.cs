﻿// <auto-generated />
using BPMeasurement.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BPMeasurement.Migrations
{
    [DbContext(typeof(BPDbContext))]
    partial class BPDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BPMeasurement.Entities.BloodPressure", b =>
                {
                    b.Property<int>("BloodPressureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BloodPressureId"));

                    b.Property<string>("DateTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Diastolic")
                        .HasColumnType("int");

                    b.Property<int>("Systolic")
                        .HasColumnType("int");

                    b.HasKey("BloodPressureId");

                    b.ToTable("BloodPressures");

                    b.HasData(
                        new
                        {
                            BloodPressureId = 1,
                            DateTime = "2000-02-09",
                            Diastolic = 80,
                            Systolic = 120
                        },
                        new
                        {
                            BloodPressureId = 2,
                            DateTime = "2010-02-09",
                            Diastolic = 79,
                            Systolic = 122
                        },
                        new
                        {
                            BloodPressureId = 3,
                            DateTime = "1996-02-09",
                            Diastolic = 85,
                            Systolic = 130
                        },
                        new
                        {
                            BloodPressureId = 4,
                            DateTime = "1996-02-09",
                            Diastolic = 85,
                            Systolic = 230
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
