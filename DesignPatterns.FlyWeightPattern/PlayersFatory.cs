using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FlyWeightPattern
{
    class PlayersFatory
    {
        Dictionary<string, IPlayer> Players;
        public PlayersFatory()
        {
            Players = new Dictionary<string, IPlayer>();
        }
        public IPlayer GetPlayer(string key)
        {
            IPlayer player;
            if (Players.ContainsKey(key))
            {
                player = Players[key];
            }               
            else
            {
                if (key == "terriost")
                    player = new Terriost();
                else
                    player = new CounterTerriost();
                Players.Add(key, player);
            }
            return player;
        }
    }
}
