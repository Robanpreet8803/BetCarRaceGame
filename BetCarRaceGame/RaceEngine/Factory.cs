using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetCarRaceGame.RaceEngine
{
    public static class Factory
    {
        public static Punter GetPunter(string pun)
        {
            if(pun.Equals("Thomas"))
            {
                return new Thomas() { Name = "Thomas", Cash = 50 };
            }
            else if(pun.Equals("Jack"))
            {
                return new Jack() { Name = "Jack", Cash = 50 };
            }
            else if (pun.Equals("Alex"))
            {
                return new Alex() { Name = "Alex", Cash = 50 };
            }
            else
            {
                return null;
            }
        }
    }
}
