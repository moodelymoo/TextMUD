using System.Collections.Generic;
using System.Linq;

namespace TextMUD.Terrain
{
    public class Map
    {
        //TODO imp, stores a list of the generated rooms with directional relations
        // to each other to allow for backtracking

        public Map(List<Room> map)
        {
            Map1 = map;
        }

        public List<Room> Map1 { get; set; }

        public void AddToMap(Room room)
        {
            Map1.Add(room);
        }

        public void RemoveFromMap(Room room)
        {
            Map1.Remove(room);
        }

        public void RemoveLastFromMap()
        {
            Map1.RemoveAt(Map1.Count);
        }
    }
}