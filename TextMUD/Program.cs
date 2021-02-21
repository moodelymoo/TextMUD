using System;
using System.Collections;
using TextMUD.Beings.Implementations;
using TextMUD.Beings.Objects;

namespace TextMUD
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Trader trader = new Trader("Bob", new Inventory(0,
                    new ArrayList(), new ArrayList()),
                1, 10, 5, 5, 5, true, 5, 10, 10,
                10, 10, 10);

            Console.WriteLine(trader.ToString());
        }

        private static void GameLoop()
        {
            Console.WriteLine("this should be the game loop containing the super high level logic");
            
        }
    }
}