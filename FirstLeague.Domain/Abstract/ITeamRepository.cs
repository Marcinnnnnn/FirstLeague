using System.Collections.Generic;
using FirstLeague.Domain.Entities;

namespace FirstLeague.Domain.Abstract
{
    public interface ITeamRepository
    {
        IEnumerable<Team> Teams { get; }
    }
}
