using System.IO;
using System.Text.Json;
using TextMUD.Eukaryotes;

namespace TextMUD.FileIO.SaveGameHandle
{
    public class SaveGenerator
    {
        //TODO imp, should generate and write, at the bare minimum; the player data into a json file, including all
        // inventory contents 

        public static void Save(Eukaryote player)
        {
            string path = @"C:\Users\Peter\RiderProjects\TextMUD\TextMUD\Jsons\"+ $"{player.Name}";
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