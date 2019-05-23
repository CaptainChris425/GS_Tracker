using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStat_Tracker
{
    class GameHolder
    {
        public string Username { get; set; }
        public string Title { get; set; }
        public string Platform { get; set; }
        public GameHolder(string user, string title, string platform)
        {
            Username = user; Title = title; Platform = platform;
        }
        public GameHolder()
        {

        }
    }
}
