using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BPMeasurement.Migrations
{
    /// <inheritdoc />
    public partial class Update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Positons",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positons", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BloodPressures",
                columns: table => new
                {
                    BloodPressureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Systolic = table.Column<int>(type: "int", nullable: false),
                    Diastolic = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PositionId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodPressures", x => x.BloodPressureId);
                    table.ForeignKey(
                        name: "FK_BloodPressures_Positons_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Positons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Positons",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { "1", "Standing" },
                    { "2", "Sitting" },
                    { "3", "Lying down" }
                });

            migrationBuilder.InsertData(
                table: "BloodPressures",
                columns: new[] { "BloodPressureId", "DateTime", "Diastolic", "PositionId", "Systolic" },
                values: new object[,]
                {
                    { 1, new DateTime(2000, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 80, "1", 120 },
                    { 2, new DateTime(2000, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 79, "1", 122 },
                    { 3, new DateTime(2000, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, "1", 130 },
                    { 4, new DateTime(2000, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, "1", 230 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BloodPressures_PositionId",
                table: "BloodPressures",
                column: "PositionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BloodPressures");

            migrationBuilder.DropTable(
                name: "Positons");
        }
    }
}
