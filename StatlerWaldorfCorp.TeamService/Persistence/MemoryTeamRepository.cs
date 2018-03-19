using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using StatlerWaldorfCorp.TeamService.Models;

namespace StatlerWaldorfCorp.TeamService.Persistence
{
    public class MemoryTeamRepository : ITeamRepository
    {
        protected static ICollection<Team> _teams;

        public  MemoryTeamRepository()
        {
            if (_teams == null)
                _teams = new List<Team>();
        }

        public MemoryTeamRepository(ICollection<Team> teams)
        {
            _teams = teams;
        }

        public bool AddTeam(Team team)
        {
            _teams.Add(team);
            return true;
        }
        public bool DeleteTeam(Guid id)
        {
            var team = _teams.Where(x => x.Id == id).First();
            _teams.Remove(team);
            return true;
        }

        public Team GeById(Guid id)
        {
            if(_teams.Where(x => x.Id == id).Count() > 0)
                return _teams.Where(x => x.Id == id).First();
            return null;
        }

        public IEnumerable<Team> GetTeams()
        {
            return _teams;
        }

        public bool UpdateTeam(Team team, Guid id)
        {
            _teams.Where(x => x.Id == id).ToList().ForEach(x =>
             {
                 x.Name = team.Name;
                 x.Members = team.Members;
             });
            return true;
        }
    }
}
