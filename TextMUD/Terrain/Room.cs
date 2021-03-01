using System;
using System.Collections.Generic;
using TextMUD.MiscObjects;

namespace TextMUD.Terrain
{
    public class Room
    {
        //TODO imp, "Room"

        public Room(List<SpecialEvent> @event, int[] dimensions, char entryDirection)
        {
            Event = @event;
            Dimensions = dimensions;
            EntryDirection = entryDirection;
        }


        public char EntryDirection { get; set; }

        public int[] Dimensions { get; set; }

        public List<SpecialEvent> Event { get; set; }
    }
}