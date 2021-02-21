using TextMUD.Eukaryotes.EukaryoteObjects;

namespace TextMUD.Eukaryotes.Implementations
{
    public class Trader : Eukaryote
    {
        public Trader(string name, Inventory inventory, int level, int hp, int stamina, int mana, int spirit,
            bool killable, int[] attack, int[] defence) : base(name, inventory, level, hp, stamina, mana, spirit,
            killable, attack, defence)
        {
            
        }
    }
}