using StatlerWaldorfCorp.TeamService.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StatlerWaldorfCorp.TeamService.Persistence
{
    public interface ITeamRepository
    {
        IEnumerable<Team> GetTeams();
        bool AddTeam(Team team);
        bool UpdateTeam(Team team,Guid id);
        bool DeleteTeam(Guid id);
        Team GeById(Guid id);
    }
}
