using System.IO;
using System.Text.Json;
using TextMUD.Eukaryotes;
using TextMUD.Eukaryotes.Implementations;

namespace TextMUD.FileIO.SaveGameHandle
{
    public class SaveLoader
    {
        public static Eukaryote Load(string name)
        {
            string path = @"C:\Users\Peter\RiderProjects\TextMUD\TextMUD\FileIO\Jsons\" + $"{name}.json";
            //get data from path
            string data = File.ReadAllText(path);
            //return as deserialized object
            return JsonSerializer.Deserialize<Monster>(data);
        }
    }
}