using StatlerWaldorfCorp.TeamService.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatlerWaldorfCorp.TeamService.Persistence
{
    public class TestMemoryTeamRepository: MemoryTeamRepository {

		public TestMemoryTeamRepository() : base(CreateInitialFake())
        {

        }

        private static ICollection<Team> CreateInitialFake()
        {
            var teams = new List<Team>();
            teams.Add(new Team("one",Guid.Parse("37803598-5275-4db9-ac60-428adbef6970")));
            teams.Add(new Team("two",Guid.Parse("935b18a4-16ab-4652-9f38-de0ac2008da7")));

            return teams;
        }
    }
}
