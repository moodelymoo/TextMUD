using TextMUD.Beings.Objects;

namespace TextMUD.Beings.Implementations
{
    public class Player : Eukaryote
    {
        public Player(string name, Inventory inventory, int level, int hp, int stamina, int mana, int spirit,
            bool killable, int[] attack, int[] defence) : base(name, inventory, level, hp, stamina, mana, spirit,
            killable, attack, defence)
        {
        }
    }
}