using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstLeague.Domain.Abstract;
using FirstLeague.Domain.Entities;

namespace FirstLeague.WebUI.Controllers
{
    public class TeamController : Controller
    {
        private ITeamRepository repository;
        
        public TeamController(ITeamRepository teamRepository)
        {
            this.repository = teamRepository;
        }

        public ViewResult List()
        {
            return View(repository.Teams);
        }
    }
}