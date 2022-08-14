using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAMostValuablePlayer
{
    public class HandballDataGetter : DataGetter<HandballPlayer>
    {
        public override List<HandballPlayer> GetPlayers()
        {
            var players = new List<HandballPlayer>();

            players.Add(new GoalKeeper { InitialRatingPoints = 50, GoalMade = 5, GoalReceived = -2 });
            players.Add(new FieldPlayer { InitialRatingPoints = 20, GoalMade = 1, GoalReceived = -1 });

            return players;
        }
    }
}
