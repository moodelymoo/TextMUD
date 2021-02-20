using TextMUD.Beings.Objects;

namespace TextMUD.Beings
{
    public abstract class Eukaryote
    {
        private string _name;
        private Inventory _inventory;
        private int[] _stats;
        private bool _killable;

        protected Eukaryote(string name, Inventory inventory, int level, int hp, int stamina, int mana, int spirit,
            bool killable, int defence, int spiritDef, int magicDef, int spiritAttack, int magicAttack,
            int physicalAttack)
        {
            _name = name;
            _inventory = inventory;
            _killable = killable;
            _stats = new[]
            {
                level,
                hp,
                stamina,
                mana,
                spirit,
                physicalAttack,
                magicAttack,
                spiritAttack,
                defence,
                magicDef,
                spiritDef
            };
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public Inventory Inventory
        {
            get => _inventory;
            set => _inventory = value;
        }

        public int[] Stats
        {
            get => _stats;
            set => _stats = value;
        }

        public bool Killable
        {
            get => _killable;
            set => _killable = value;
        }

        public override string ToString()
        {
            return $"{nameof(_name)}: {_name}, {nameof(_inventory)}: {_inventory}, {nameof(_stats)}: {_stats}, {nameof(_killable)}: {_killable}";
        }
    }
}