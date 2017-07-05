using System.Collections.Generic;
using FirstLeague.Domain.Entities;

namespace FirstLeague.WebUI.Models
{
    public class TeamViewListModel
    {
        public IEnumerable<Team> Teams { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}