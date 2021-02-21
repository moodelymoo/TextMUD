using System.Linq;
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
            bool killable, int[] attack, int[] defence)
        {
            _name = name;
            _inventory = inventory;
            _killable = killable;
            _stats = new int[]
            {
                level,
                hp,
                stamina,
                mana,
                spirit,
                attack[0],
                attack[1],
                attack[2],
                defence[0],
                defence[1],
                defence[2]
            };
        }

        protected Eukaryote(string name, int level, int[] attack, int[] defence)
        {
            //for genning level specific eukaryotes
            throw new System.NotImplementedException();
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
            return "Player Stat Sheet\n".ToUpper() +
                   $"Name: {_name}\t Money: {_inventory.Money} \t Level: {_stats[0]}\n" +
                   $"Hp: {_stats[1]}\t\t Stamina: {_stats[2]}\t Mana: {_stats[3]}\t\t \n" +
                   $"Physical:\t Attack: {_stats[5]}\t Defence: {_stats[8]}\t \n" +
                   $"Magical:\t Attack: {_stats[6]}\t Defence: {_stats[9]}\t \n" +
                   $"Spirit:\t\t Attack: {_stats[7]}\t Defence: {_stats[10]}\t \n\n" +
                   $"Killable: {_killable}\n\n" +
                   $"Active Inventory:\n" +
                   $"{_inventory.GetAllActiveInv()}\n" +
                   $"Passive Inventory:\n" +
                   $"{_inventory.GetAllPassiveInv()}";
        }
    }
}