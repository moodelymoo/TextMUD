using System.Collections.Generic;
using TextMUD.Eukaryotes.Implementations;

namespace TextMUD.FightHandler
{
    public class Fight
    {
        public Fight(Player player, List<Monster> monsters)
        {
            Player = player;
            Monsters = monsters;
        }

        public Player Player { get; set; }

        public List<Monster> Monsters { get; set; }

        //TODO imp, a placeholder file for the fight logic and calculations
    }
}