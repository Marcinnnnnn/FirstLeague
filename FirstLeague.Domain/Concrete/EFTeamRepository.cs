using System.Collections.Generic;
using FirstLeague.Domain.Entities;
using FirstLeague.Domain.Abstract;

namespace FirstLeague.Domain.Concrete
{
    public class EFTeamRepository : ITeamRepository
    {
        private EfDbContext context = new EfDbContext();

        public IEnumerable<Team> Teams
        {
            get { return context.Teams; }
        }
    }
}
