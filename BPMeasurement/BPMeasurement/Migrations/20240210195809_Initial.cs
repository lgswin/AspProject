using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BPMeasurement.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BloodPressures",
                columns: table => new
                {
                    BloodPressureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Systolic = table.Column<int>(type: "int", nullable: false),
                    Diastolic = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodPressures", x => x.BloodPressureId);
                });

            migrationBuilder.InsertData(
                table: "BloodPressures",
                columns: new[] { "BloodPressureId", "DateTime", "Diastolic", "Systolic" },
                values: new object[,]
                {
                    { 1, "2000-02-09", 80, 120 },
                    { 2, "2010-02-09", 79, 122 },
                    { 3, "1996-02-09", 85, 130 },
                    { 4, "1996-02-09", 85, 230 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BloodPressures");
        }
    }
}
