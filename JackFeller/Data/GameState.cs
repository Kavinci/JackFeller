using System;
using System.Collections.Generic;
using System.Text;

namespace JackFeller.Data
{
    [Serializable]
    public class GameState
    {
        public GameState()
        {
            Player = null;
            Environment = null;
        }
        public Player Player { get; private set; }
        public Environment Environment { get; private set; }
        public void SetPlayer(Player player) 
        {
            if(Player == null)
            {
                Player = player;
            }
        }
        public void SetEnvironment(Environment environment)
        {
            if(Environment == null)
            {
                Environment = environment;
            }
        }
    }
}
