using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AlbumApp.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    AlbumId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Artist = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    Song = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.AlbumId);
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "AlbumId", "Artist", "Rating", "Song", "Title" },
                values: new object[,]
                {
                    { 1, "The Clash", 9.8000000000000007, "Lost In The Supermarket", "To Seek the Truth of The Cosmos" },
                    { 2, "George Harrison", 9.5, "All Things Must Pass", "Beyond The Veil of Time" },
                    { 3, "the Beatles", 9.5, "Let It Be", "Bad Company" },
                    { 4, "John Lennon", 9.0999999999999996, "Imagine", "Ready, Set, Go!" },
                    { 5, "Elton John", 8.8000000000000007, "Your Song", "The Rhythm of Life" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Albums");
        }
    }
}
