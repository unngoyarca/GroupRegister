using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupRegister
{
    internal class Guild
    {   
        public string GuildName { get; set; }
        public string About { get; set; }

        // in the Guild we found the team and members
        public List<TeamInfo> Teams { get; set; }
        public List<PlayersInfo> Players { get; set; }

        public Guild(string guildName, string about)
        {
            GuildName = guildName;
            About = about;

            //One Guild have several Teams
            Teams = new List<TeamInfo>();

            //A team have severals members/Players (here max 6)
            Players = new List<PlayersInfo>();
        }

        public void AddNewTeam(string teamName, int level)
        {
            Teams.Add(new TeamInfo(teamName, level));

        }

        public void ListAllTeams()
        {
            foreach (var teamInfo in Teams)
            {
                System.Console.WriteLine(teamInfo.TeamName + " " + teamInfo.Level);
            }
        }
    }
}
