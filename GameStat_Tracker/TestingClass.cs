using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace GameStat_Tracker
{
    class TestingClass
    {
        public List<string> AvaliableGames = new List<string> { "Pubg" , "CoD WW1"};
        public List<string> GameDescriptions = new List<string> { "PLAYER UNKNOWN'S Battlegrounds", "Call of Duty World War 1" };
        public List<string> AvaliablePlatforms = new List<string> { "PC", "Xbox", "PS4" };

        public List<string> PlayerGames;
        public List<string> PlayerPlatforms;
        public Player CurrentPlayer;

        public TestingClass()
        {
            PlayerGames = new List<string>();
            PlayerPlatforms = new List<string>();
            CurrentPlayer = new Player();
        }
        
        public void AddGame(string name, string game, string platform)
        {
            /*Adds a game to the player in the testing class*/
            CurrentPlayer.AddGame(name, game, platform);
            if (!PlayerGames.Contains(game))
            {
                PlayerGames.Add(game);
            }
            if (!PlayerPlatforms.Contains(platform))
            {
                PlayerPlatforms.Add(platform);
            }
        }

        public string PlayerString()
        {
            return CurrentPlayer.ToString();
        }

    }
}
