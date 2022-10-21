using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupRegister
{
    internal class PlayersInfo
    {
        public string PlayerName { get; set; }
        public int Age { get; set; }

        public PlayersInfo(string playerName, int age)
        {
            PlayerName = playerName;
            Age = age;
        }
    }

}
