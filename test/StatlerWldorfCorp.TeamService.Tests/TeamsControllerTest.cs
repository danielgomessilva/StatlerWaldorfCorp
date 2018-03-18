using Xunit;
using StatlerWaldorfCorp.TeamService.Models;
using System.Collections.Generic;

namespace StatlerWldorfCorp.TeamService.Tests
{
    public class TeamsControllerTest
    {
        var controller = new TeamsController();

        [[Fact]
        public void QueryTeamListReturnsCorrectTeams()
        {
            var teams = new List<Team>(
                controller.GetAllTeams());
            )
        //Given
        
        //When
        
        //Then
        }]
    }
}