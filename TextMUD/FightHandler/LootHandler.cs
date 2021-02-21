using System.Collections.Generic;
using TextMUD.Eukaryotes.EukaryoteObjects;
using TextMUD.LootHandler;

namespace TextMUD.FightHandler
{
    public class LootHandler
    {
        public LootHandler()
        {
            
        }
        
        public List<Item> GenLootOnDeath(Inventory inventory)
        {
            //TODO imp, make it so that it returns some random items, number scaled with level
            return inventory.ActiveItems;
        }
    }
}