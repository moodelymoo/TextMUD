using System.Collections.Generic;
using System.Numerics;
using TextMUD.Eukaryotes.Implementations;

namespace TextMUD.FightHandler
{
    public class Fight
    {
        private Player _player;
        private List<Monster> _monsters;

        public Fight(Player player, List<Monster> monsters)
        {
            _player = player;
            _monsters = monsters;
        }
        
        //TODO imp, a placeholder file for the fight logic and calculations
    }
}