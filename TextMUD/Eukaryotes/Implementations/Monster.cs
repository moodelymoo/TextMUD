using System.Collections.Generic;
using System.Text.Json.Serialization;
using TextMUD.Eukaryotes.EukaryoteObjects;
using TextMUD.LootHandler;


namespace TextMUD.Eukaryotes.Implementations
{
    public class Monster : Eukaryote
    {
        [JsonConstructor]
        public Monster()
        {
            
        }
        
        
        public Monster(string name, Inventory inventory, int level, int hp, int stamina, int mana, int spirit,
            bool killable, IReadOnlyList<int> attack, IReadOnlyList<int> defence) : base(name, inventory, level, hp,
            stamina, mana, spirit, killable, attack, defence)
        {
            
        }

        // public Monster(string name, int level, int[] attack, int[] defence) : base(name, level, attack, defence)
        // {
        //     
        // }

        public List<Item> OnDeath()
        {
            FightHandler.LootHandler lootHandler = new FightHandler.LootHandler();
            return lootHandler.GenLootOnDeath(Inventory);
        }
    }
}