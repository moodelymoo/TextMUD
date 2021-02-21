using System.Collections.Generic;
using System.Text.Json.Serialization;
using TextMUD.Eukaryotes.EukaryoteObjects;

namespace TextMUD.Eukaryotes.Implementations
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Player : Eukaryote
    {
        [JsonConstructor]
        public Player()
        {
        }

        public Player(string name, Inventory inventory, int level, int hp, int stamina, int mana, int spirit,
            bool killable, IReadOnlyList<int> attack, IReadOnlyList<int> defence) : base(name, inventory, level, hp,
            stamina, mana, spirit, killable, attack, defence)
        {
            
        }
    }
}