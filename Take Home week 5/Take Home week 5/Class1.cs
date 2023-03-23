using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Take_Home_week_5
{
    internal class Team
    {
        public string TeamName { get; set; }
        public string TeamCountry { get; set; }
        public string TeamCity { get; set; }

        public List<Player> Playerlist;
        public List<Player> Playerlist2
        {
            get { return Playerlist; }
            set { Playerlist = value; }
        }
    }
}
