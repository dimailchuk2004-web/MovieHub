using Microsoft.EntityFrameworkCore;
using MovieHub.Models;

namespace MovieHub.Data;

public class MovieHubContext : DbContext
{
    public MovieHubContext(DbContextOptions<MovieHubContext> options)
        : base(options) { }

    public DbSet<Movie> Movies => Set<Movie>();

    protected override void OnModelCreating(ModelBuilder b)
    {
        b.Entity<Movie>().Property(x => x.Rating).HasConversion<double>();
    }
}