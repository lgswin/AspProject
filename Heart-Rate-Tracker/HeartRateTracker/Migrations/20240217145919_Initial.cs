using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HeartRateTracker.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HeartRateMeasurements",
                columns: table => new
                {
                    HeartRateMeasurementId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BPMValue = table.Column<int>(type: "int", nullable: false),
                    MeasurementDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeartRateMeasurements", x => x.HeartRateMeasurementId);
                });

            migrationBuilder.InsertData(
                table: "HeartRateMeasurements",
                columns: new[] { "HeartRateMeasurementId", "BPMValue", "MeasurementDate", "Position" },
                values: new object[,]
                {
                    { 1, 148, new DateTime(2024, 2, 12, 9, 59, 19, 439, DateTimeKind.Local).AddTicks(4900), "Standing" },
                    { 2, 148, new DateTime(2024, 2, 16, 9, 59, 19, 439, DateTimeKind.Local).AddTicks(4950), "Standing" },
                    { 3, 148, new DateTime(2024, 2, 13, 9, 59, 19, 439, DateTimeKind.Local).AddTicks(4960), "Standing" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HeartRateMeasurements");
        }
    }
}
