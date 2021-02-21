using System;
using System.Collections.Generic;
using TextMUD.Eukaryotes;
using TextMUD.Eukaryotes.EukaryoteObjects;
using TextMUD.Eukaryotes.Implementations;
using TextMUD.FileIO.SaveGameHandle;
using TextMUD.LootHandler;

namespace TextMUD
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Trader trader = new Trader("Bob", new Inventory(
                    0,
                    new List<Item>
                    {
                        new("Passive Inv of Power", 1, new[] {2, 1, 1}, new[] {7, 4, 4})
                    },
                    new List<Item>
                    {
                        new("Shield of Power", 0, new[] {5, 2, 2}, new[] {10, 3, 3})
                    }),
                1, 10, 5, 5, 5, true,
                new[] {5, 5, 5}, new[] {10, 10, 10}
            );
            
            Monster monster = new Monster("Sean", new Inventory(
                    0,
                    new List<Item>
                    {
                        new("Passive Inv of Power", 1, new[] {2, 1, 1}, new[] {7, 4, 4})
                    },
                    new List<Item>
                    {
                        new("Shield of Power", 0, new[] {5, 2, 2}, new[] {10, 3, 3})
                    }),
                1, 10, 5, 5, 5, true,
                new[] {5, 5, 5}, new[] {10, 10, 10}
            );
            Console.WriteLine(trader.ToString());

            // SaveGenerator saveGenerator = new SaveGenerator();
            // saveGenerator.Save(monster);
            //
            // Console.WriteLine("Save Successful");

            SaveLoader saveLoader = new SaveLoader();
            Monster monster2 = SaveLoader.Load("Sean");
            
            Console.WriteLine(monster2.ToString());
        }

        private static void GameLoop()
        {
            Console.WriteLine("this should be the game loop containing the super high level logic");

        }
    }
}