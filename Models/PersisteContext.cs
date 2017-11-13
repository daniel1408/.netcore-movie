using movie.Models;

namespace movie.Database
{
    public class PersisteContext : DbContext
    {
        public BloggingContext(DbContextOptions<PersisteContext> options)
            : base(options)
        { }

        public DbSet<Filmes> Filmes { get; set; }
        public DbSet<Ratings> Ratings { get; set; }

    }

}
