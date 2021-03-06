﻿using System;
using System.Collections.Generic;
using TextMUD.Eukaryotes;
using TextMUD.Eukaryotes.EukaryoteObjects;
using TextMUD.Eukaryotes.Implementations;
using TextMUD.FileIO.SaveGameHandle;
using TextMUD.MiscObjects;
using Serilog;



namespace TextMUD
{
    internal static class RunGame
    {
        // ReSharper disable once UnusedParameter.Local
        private static void Main(string[] args)
        {
            // Setup logger - should work project wide
            // Before release, change min logging level to Information(pref)/Error
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .WriteTo.File(@$"C:\Users\Peter\RiderProjects\TextMUD\TextMUD\Loggers\Logs\{nameof(TextMUD)}.txt",
                    rollingInterval: RollingInterval.Day)
                .CreateLogger();
            
            // Manual test code
            TestEukaryote();
        }

        // ReSharper disable once UnusedMember.Local
        private static void GameLoop()
        {
            Console.WriteLine("this should be the game loop containing the super high level logic");
        }

        private static void TestEukaryote()
        {
            // ReSharper disable once UnusedVariable
            Eukaryote trader = new Trader("Bob", new Inventory(
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
            
            Eukaryote monster = new Monster("Sean", new Inventory(
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

            SaveGenerator.Save(monster);
            
            // Test importing and object conversion from a json file
            // ReSharper disable once UnusedVariable
            Eukaryote monster2 = SaveLoader.Load("Sean");
        }
    }
}