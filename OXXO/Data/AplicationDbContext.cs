using OXXO.Models;
using Microsoft.EntityFrameworkCore;

namespace OXXO.Data
{
    public class AplicationDbContext: DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options) { }
        public DbSet<Banco> Banco { get; set; }
        public DbSet<Comercio> Comercio { get; set; }
    }
}
