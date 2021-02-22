using System.IO;
using System.Text.Json;
using TextMUD.Eukaryotes;

namespace TextMUD.FileIO.SaveGameHandle
{
    public static class SaveGenerator
    {
        public static void Save(Eukaryote player)
        {
            string path = @"C:\Users\Peter\RiderProjects\TextMUD\TextMUD\Jsons\"+ $"{player.Name}.json";
            //make json indented and pretty
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
            };
            //Serialise to Json format
            string playerData = JsonSerializer.Serialize(player, options);
            //Write to file
            File.WriteAllText(path, playerData);
        }
    }
}