using System.Collections.Generic;
using TextMUD.Eukaryotes.EukaryoteObjects;
using TextMUD.MiscObjects;

namespace TextMUD.FightHandler
{
    public class LootHandler
    {

        public List<Item> GenLootOnDeath(Inventory inventory)
        {
            //TODO imp, make it so that it returns some random items, number scaled with level and so on...
            return inventory.ActiveItems;
        }
    }
}