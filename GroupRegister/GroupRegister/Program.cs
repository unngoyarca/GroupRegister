using System.Reflection.Emit;

namespace GroupRegister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var membersStatus = new Guild("Arcana", "Small porject");

            var eachTeam = new TeamInfo("Adrian", 10);

            //var player = new PlayersInfo("Adrian1", 29);

            var isAdding = true;
            while (isAdding)
            {
                System.Console.WriteLine("Name of the team: ");
                var teamName = Console.ReadLine();

                System.Console.WriteLine("Level: ");
                int level = Convert.ToInt32(Console.ReadLine());

                var team = new TeamInfo(teamName, level);

                System.Console.WriteLine("Name of the members: ");
                var playerName = Console.ReadLine();
                

                System.Console.WriteLine("Weapon: ");
                int age = Convert.ToInt32(Console.ReadLine());

                eachTeam.AddNewMember(teamName, level);
            }

            membersStatus.ListAllTeams();
            eachTeam.ListAllplayers();
             
        }
    }
}