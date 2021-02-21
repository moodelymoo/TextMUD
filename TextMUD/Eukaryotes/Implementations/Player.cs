using System.Collections.Generic;
using TextMUD.Eukaryotes.EukaryoteObjects;

namespace TextMUD.Eukaryotes.Implementations
{
    public class Player : Eukaryote
    {
        public Player(string name, Inventory inventory, int level, int hp, int stamina, int mana, int spirit,
            bool killable, IReadOnlyList<int> attack, IReadOnlyList<int> defence) : base(name, inventory, level, hp,
            stamina, mana, spirit, killable, attack, defence)
        {
            
        }
    }
}