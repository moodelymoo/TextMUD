﻿using System;
using System.IO;
using System.Text.Json;
using TextMUD.Eukaryotes;
using TextMUD.Eukaryotes.Implementations;

namespace TextMUD.FileIO.SaveGameHandle
{
    public class SaveLoader
    {
        public SaveLoader()
        {
            
        }
        
        // TODO imp, should import from a json file given a player name

        public Monster Load(string name)
        {
            string path = @"C:\Users\Peter\RiderProjects\TextMUD\TextMUD\Jsons\" + name;
            //get data from path
            string data = File.ReadAllText(path);
            //return as deserialized object
            return JsonSerializer.Deserialize<Monster>(data);
        }
        
    }
}