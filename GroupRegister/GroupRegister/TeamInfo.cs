using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace GroupRegister
{
    internal class TeamInfo
    {
        public string TeamName { get; set; }
        public int Level { get; set; }
        public List<PlayersInfo> Members { get; set; }

        public TeamInfo(string teamName, int level)
        {
            TeamName = teamName;
            Level = level;
        }

        public void AddNewMember(string playerName, int age)
        {
            Members.Add(new PlayersInfo(playerName, age));
        }
        public void ListAllplayers()
        {
            foreach (var playersInfor in Members)
            {
                System.Console.WriteLine(playersInfor.PlayerName + " " + playersInfor.Age);
            }
        }

    }
}
