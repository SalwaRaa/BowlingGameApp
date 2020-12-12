using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingClassLibrary
{
   public class BowlingGame
    {
        private int _count = 0;
        private bool _firstRoll = true;

        public List<Player> PlayerList { get; set; } = new List<Player>();

        public Player _currentPlayer => PlayerList[_count];

        public BowlingGame(List<string> names)
        {
            foreach (var name in names)
            {
                var player = new Player(name);
                PlayerList.Add(player);
            }
        }

        public void Roll(int pins)
        {
            _currentPlayer.Round.Roll(pins);
            if (pins == 10)
            {
                _count++;
            }
            else
            {
                if (_firstRoll == true)
                {
                    _firstRoll = false;
                }
                else
                {
                    _firstRoll = true;
                    _count++;
                }
            }
        }
    }


}