using System.Collections.Generic;
using TextMUD.LootHandler;

namespace TextMUD.Eukaryotes.EukaryoteObjects
{
    public class SaleInventory : Inventory
    {
        public SaleInventory(int money, List<Item> items, List<Item> activeItems, List<Item> saleInventory) : base(money, items, activeItems)
        {
            ShopInventory = saleInventory;
        }

        public List<Item> ShopInventory { get; set; }

        public List<Item> Buy(List<Item> purchased)
        {
            //TODO imp, should handle buying something from trader inv
            return purchased;
        }
    }
}