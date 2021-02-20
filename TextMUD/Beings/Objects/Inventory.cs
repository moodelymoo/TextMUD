using System;
using System.Collections;
using System.Collections.Generic;

namespace TextMUD.Beings.Objects
{
    public class Inventory
    {
        private int _money;
        private ArrayList _items;
        private ArrayList _activeItems;


        public Inventory(int money, ArrayList items, ArrayList activeItems)
        {
            _money = money;
            _items = items;
            _activeItems = activeItems;
        }


        public ArrayList Items
        {
            get => _items;
            set => _items = value;
        }

        public int Money
        {
            get => _money;
            set => _money = value;
        }

        public ArrayList ActiveItems
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
            /*TODO imp, should return name of eukaryote along with
            a formatted grid with the active inv and then the inactive inv*/
            
            return base.ToString();
        }
    }
}