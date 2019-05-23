using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStat_Tracker
{
    class Player
    {
        public List<GameHolder> games;
        public Player()
        {
            games = new List<GameHolder>();
        }

        public override string ToString()
        {
            //objListOrder.Sort((x, y) => x.OrderDate.CompareTo(y.OrderDate));
            games.Sort((x,y) => x.Title.CompareTo(y.Title));
            StringBuilder str = new StringBuilder();
            str.AppendLine("===============");
            str.AppendLine("Game  Platform  UserName");
            foreach (GameHolder game in games)
            {
                str.Append(game.Title);
                str.Append("  ");
                str.Append(game.Platform);
                str.Append("  ");
                str.Append(game.Username);
                str.AppendLine("");
            }
            str.AppendLine("===============");
            return str.ToString();
        }

        public void AddGame(string user, string title, string platform)
        {
            bool add = true;
            GameHolder game = new GameHolder(user,title,platform);
            foreach(GameHolder g in games)
            {
                if (g.Username == game.Username && g.Title == game.Title && g.Platform == game.Platform)
                    add = false;
            }
            if (add)
                games.Add(game);
        }

        public GameHolder GetGame(int index)
        {
            /*Returns game at index*/
            if (index < games.Count)
                return null;
            return games[index];
        }

        public List<GameHolder> GetGamesUser(List<string> user)
        {
            /*Returns all games with user*/
            List<GameHolder> gms = new List<GameHolder>();
            foreach (GameHolder game in games)
            {
                if (user.Contains(game.Username))
                {
                    gms.Add(game);
                }
            }
            return gms;
        }

        public List<GameHolder> GetGamesTitle(List<string> title)
        {
            /*Returns all games with user*/
            List<GameHolder> gms = new List<GameHolder>();
            foreach (GameHolder game in games)
            {
                if (title.Contains(game.Title))
                {
                    gms.Add(game);
                }
            }
            return gms;
        }

        public List<GameHolder> GetGamesPlatform(List<string> platform)
        {
            /*Returns all games with user*/
            List<GameHolder> gms = new List<GameHolder>();
            foreach (GameHolder game in games)
            {
                if (platform.Contains(game.Platform))
                {
                    gms.Add(game);
                }
            }
            return gms;
        }


    }
}
