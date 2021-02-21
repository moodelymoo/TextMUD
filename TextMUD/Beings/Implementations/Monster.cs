using TextMUD.Beings.Objects;

namespace TextMUD.Beings.Implementations
{
    public class Monster : Eukaryote
    {
        public Monster(string name, Inventory inventory, int level, int hp, int stamina, int mana, int spirit,
            bool killable, int[] attack, int[] defence) : base(name, inventory, level, hp, stamina, mana, spirit,
            killable, attack, defence)
        {
        }

        public Monster(string name, int level, int[] attack, int[] defence) : base(name, level, attack, defence)
        {
            
        }
    }
}