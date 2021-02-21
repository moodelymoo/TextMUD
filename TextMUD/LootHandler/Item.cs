using System;

namespace TextMUD.LootHandler
{
    public struct Item
    {
        private string _name;
        private int _level;
        private int[] _damage;
        private int[] _defence;
        private string _specialAbility;

        public Item(string name, int level, int[] damage, int[] defence, string specialAbility)
        {
            _name = name;
            _level = level;
            _damage = damage;
            _defence = defence;
            _specialAbility = specialAbility;
        }

        public Item(string name, int level, int[] damage, int[] defence) : this()
        {
            // checking lengths of 
            if (damage.Length != 3 || defence.Length != 3)
                throw new ArgumentException($"both damage and defence arguments must contain " +
                                            $"3 items, currently contain\n " +
                                            $"Damage: {damage.Length}\n" +
                                            $"Defence: {defence.Length}");

            _name = name;
            _level = level;
            _damage = damage;
            _defence = defence;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int Level
        {
            get => _level;
            set => _level = value;
        }

        public int[] Damage
        {
            get => _damage;
            set => _damage = value;
        }

        public int[] Defence
        {
            get => _defence;
            set => _defence = value;
        }

        public string SpecialAbility
        {
            get => _specialAbility;
            set => _specialAbility = value;
        }

        public override string ToString()
        {
            return $"{Name}, TODO, format this output in item.cs";
        }
    }
}