using Microsoft.EntityFrameworkCore;
using PS.BioBoard_Simple.Web.Models;

namespace PS.BioBoard_Simple.Web.Data
{
    public class BioBoardSimpleDbContext : DbContext
    {
        public BioBoardSimpleDbContext(DbContextOptions<BioBoardSimpleDbContext> options) : base(options)
        {

        }

        public DbSet<Person> Persons { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .ApplyConfigurationsFromAssembly(typeof(BioBoardSimpleDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }

    }
}
