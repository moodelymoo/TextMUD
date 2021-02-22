using System.Collections.Generic;
using System.Linq;
using TextMUD.MiscObjects;

namespace TextMUD.Eukaryotes.EukaryoteObjects
{
    public class Inventory
    {
        public Inventory(int money, List<Item> items, List<Item> activeItems)
        {
            Money = money;
            Items = items;
            ActiveItems = activeItems;
        }


        public List<Item> Items { get; set; }

        public int Money { get; set; }

        public List<Item> ActiveItems { get; set; }

        public void AddActiveItem(Item item, int slot)
        {
            ActiveItems.Insert(slot, item);
        }

        public void AddPassiveItem(Item item, int slot)
        {
            Items.Insert(slot, item);
        }

        public override string ToString()
        {
            return $"{nameof(ActiveItems)}:";
        }

        public string GetAllActiveInv()
        {
            return ActiveItems.Aggregate("", (current, item) => current + $"{item}\n");
        }

        public string GetAllPassiveInv()
        {
            return Items.Aggregate("", (current, item) => current + $"{item}\n");
        }
    }
}