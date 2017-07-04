using FirstLeague.Domain.Entities;
using System.Data.Entity;

namespace FirstLeague.Domain.Concrete
{
    public class EfDbContext : DbContext
    {
        public DbSet<Team> Teams { get; set; }
    }
}
