using Microsoft.EntityFrameworkCore;

namespace AlbumApp.Entities
{
    public class AlbumsDbContext : DbContext
    {
        public AlbumsDbContext(DbContextOptions<AlbumsDbContext> options)
            : base(options)
        {
        }

        // Add your properties for accessing your entities here...
        public DbSet<Album> Albums { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Do your initializing/seeding here...
            modelBuilder.Entity<Album>().HasData(
                new Album() {
                    AlbumId = 1,
                    Title = "To Seek the Truth of The Cosmos",
                    Artist = "The Clash",
                    Song = "Lost In The Supermarket",
                    Rating = 9.8
                },
                new Album()
                {
                    AlbumId = 2,
                    Title = "Beyond The Veil of Time",
                    Artist = "George Harrison",
                    Song = "All Things Must Pass",
                    Rating = 9.5
                },
                new Album()
                {
                    AlbumId = 3,
                    Title = "Bad Company",
                    Artist = "the Beatles",
                    Song = "Let It Be",
                    Rating = 9.5
                },
                new Album()
                {
                    AlbumId = 4,
                    Title = "Ready, Set, Go!",
                    Artist = "John Lennon",
                    Song = "Imagine",
                    Rating = 9.1
                },
                new Album()
                {
                    AlbumId = 5,
                    Title = "The Rhythm of Life",
                    Artist = "Elton John",
                    Song = "Your Song",
                    Rating = 8.8
                }

            );
        }
    }
}
