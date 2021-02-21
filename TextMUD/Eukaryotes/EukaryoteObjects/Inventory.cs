using System.Collections.Generic;
using System.Linq;
using TextMUD.LootHandler;

namespace TextMUD.Eukaryotes.EukaryoteObjects
{
    public class Inventory
    {
        private int _money;
        private List<Item> _items;
        private List<Item> _activeItems;


        public Inventory(int money, List<Item> items, List<Item> activeItems)
        {
            _money = money;
            _items = items;
            _activeItems = activeItems;
        }


        public List<Item> Items
        {
            get => _items;
            set => _items = value;
        }

        public int Money
        {
            get => _money;
            set => _money = value;
        }

        public List<Item> ActiveItems
        {
            get => _activeItems;
            set => _activeItems = value;
        }

        public void AddActiveItem(Item item, int slot)
        {
            _activeItems.Insert(slot, item);
        }

        public void AddPassiveItem(Item item, int slot)
        {
            _items.Insert(slot, item);
        }

        public override string ToString()
        {
            return $"{nameof(_activeItems)}:";
        }

        public string GetAllActiveInv()
        {
            return _activeItems.Aggregate("", (current, item) => current + $"{item}\n");
        }

        public string GetAllPassiveInv()
        {
            return _items.Aggregate("", (current, item) => current + $"{item}\n");
        }
    }
}