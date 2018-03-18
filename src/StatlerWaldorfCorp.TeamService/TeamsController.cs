using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using StatlerWaldorfCorp.TeamServiceModels;

namespace  StatlerWaldorfCorp.TeamServiceModels
{
    public class TeamsController
    {
        public TeamsController()
        {
            
        }
        [HtppGet]
        public IEnumerable<Team> GetAllTeams()
        {
            return Enumerable.Empty<Team>();
        }
    }
}