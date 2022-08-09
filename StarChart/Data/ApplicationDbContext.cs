using Microsoft.EntityFrameworkCore;
using StarChart.Models;

namespace StarChart.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<CelestialObject> CelestialObjects { get; set; }
        private readonly ApplicationDbContext _context;

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            _context = new ApplicationDbContext(options);
        }
    }
}
