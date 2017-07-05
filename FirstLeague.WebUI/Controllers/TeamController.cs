using System.Linq;
using System.Web.Mvc;
using FirstLeague.Domain.Abstract;
using FirstLeague.WebUI.Models;

namespace FirstLeague.WebUI.Controllers
{
    public class TeamController : Controller
    {
        private ITeamRepository repository;
        public int size = 8;

        public TeamController(ITeamRepository teamRepository)
        {
            this.repository = teamRepository;
        }

        public ViewResult List(int page = 1)
        {
            TeamViewListModel model = new TeamViewListModel
            {
                Teams = repository.Teams
                .OrderBy(p => p.TeamID)
                .Skip((page - 1) * size)
                .Take(size),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ClubsPerPage = size,
                    TotalClubs = repository.Teams.Count()                   
                }
            };
            return View(model);
        }

        public ViewResult Menu()
        {
            TeamViewListModel model = new TeamViewListModel
            {
                Teams = repository.Teams
               .OrderBy(p => p.TeamID)  
            };
            return View(model);
        }
    }
}