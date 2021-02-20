using System;

namespace TextMUD.Beings.Objects
{
    public struct Item
    {
        private int _level;
        private int[] _damage;
        private int[] _defence;
        private string _specialAbility;

        public Item(int level, int[] damage, int[] defence, string specialAbility)
        {
            _level = level;
            _damage = damage;
            _defence = defence;
            _specialAbility = specialAbility;
        }

        public Item(int level, int[] damage, int[] defence) : this()
        {
            if (damage.Length != 3 || defence.Length != 3)
                throw new ArgumentException($"both damage and defence arguments must contain " +
                                            $"3 items, currently contain\n " +
                                            $"Damage: {damage.Length}\n" +
                                            $"Defence: {defence.Length}");
            
            _level = level;
            _damage = damage;
            _defence = defence;
        }
    }
}