using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using StatlerWaldorfCorp.TeamService.Models;
using StatlerWaldorfCorp.TeamService.Persistence;
using System.Threading.Tasks;

namespace StatlerWaldorfCorp.TeamService
{
    public class TeamsController : Controller
    {
        private ITeamRepository _repostory;

        public TeamsController(ITeamRepository repo)
        {
            _repostory = repo;
        }
        [HttpGet]
        public IActionResult GetAllTeams()
        {
            return Ok(_repostory.GetTeams());
        }
        [HttpDelete]
        public IActionResult DeleteTeam(Guid id)
        {
            return Ok(_repostory.DeleteTeam(id));
        }
        [HttpPost]
        public IActionResult CreateTeam(Team team)
        {
            return Created($"/teams/{team.Id}",_repostory.AddTeam(team));
        }
        [HttpPost]
        public IActionResult UpdateTeam(Team team,Guid id)
        {
            return Ok(_repostory.UpdateTeam(team, id));
        }
        [HttpDelete]
        public IActionResult GetTeam(Guid Id)
        {
            var team = _repostory.GeById(Id);
            if (team == null)
                return NotFound();
            else
                return Ok(_repostory.GeById(Id));
        }

    }
}
