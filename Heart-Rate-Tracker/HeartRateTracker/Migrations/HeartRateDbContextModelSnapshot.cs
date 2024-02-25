﻿// <auto-generated />
using System;
using HeartRateTracker.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HeartRateTracker.Migrations
{
    [DbContext(typeof(HeartRateDbContext))]
    partial class HeartRateDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HeartRateTracker.Entities.HeartRateMeasurement", b =>
                {
                    b.Property<int>("HeartRateMeasurementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HeartRateMeasurementId"));

                    b.Property<int?>("BPMValue")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<DateTime?>("MeasurementDate")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HeartRateMeasurementId");

                    b.ToTable("HeartRateMeasurements");

                    b.HasData(
                        new
                        {
                            HeartRateMeasurementId = 1,
                            BPMValue = 148,
                            MeasurementDate = new DateTime(2024, 2, 12, 9, 59, 19, 439, DateTimeKind.Local).AddTicks(4900),
                            Position = "Standing"
                        },
                        new
                        {
                            HeartRateMeasurementId = 2,
                            BPMValue = 148,
                            MeasurementDate = new DateTime(2024, 2, 16, 9, 59, 19, 439, DateTimeKind.Local).AddTicks(4950),
                            Position = "Standing"
                        },
                        new
                        {
                            HeartRateMeasurementId = 3,
                            BPMValue = 148,
                            MeasurementDate = new DateTime(2024, 2, 13, 9, 59, 19, 439, DateTimeKind.Local).AddTicks(4960),
                            Position = "Standing"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
