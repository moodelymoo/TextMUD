using System;

namespace TextMUD.LootHandler
{
    public struct Item
    {
        public Item(string name, int level, int[] damage, int[] defence, string specialAbility)
        {
            Name = name;
            Level = level;
            Damage = damage;
            Defence = defence;
            SpecialAbility = specialAbility;
        }

        public Item(string name, int level, int[] damage, int[] defence) : this()
        {
            // checking lengths of 
            if (damage.Length != 3 || defence.Length != 3)
                throw new ArgumentException($"both damage and defence arguments must contain " +
                                            $"3 items, currently contain\n " +
                                            $"Damage: {damage.Length}\n" +
                                            $"Defence: {defence.Length}");

            Name = name;
            Level = level;
            Damage = damage;
            Defence = defence;
        }

        public string Name { get; set; }

        public int Level { get; set; }

        public int[] Damage { get; set; }

        public int[] Defence { get; set; }

        public string SpecialAbility { get; set; }

        public override string ToString()
        {
            return $"{Name}, TODO, format this output in item.cs";
        }
    }
}