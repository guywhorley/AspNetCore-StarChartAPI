using Microsoft.EntityFrameworkCore;

using StarChart.Models;

namespace StarChart.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        /// <summary>The heavenly bodies.</summary>
        public DbSet<CelestialObject> CelestialObjects { get; set; }
    }
}
