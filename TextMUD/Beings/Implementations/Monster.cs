using TextMUD.Beings.Objects;

namespace TextMUD.Beings.Implementations
{
    public class Monster : Eukaryote
    {
        public Monster(string name, Inventory inventory, int level, int hp, int stamina, int mana, int spirit, bool killable, int physicalDefence, int spiritDef, int magicDef, int spiritAttack, int magicAttack, int physicalAttack) : base(name, inventory, level, hp, stamina, mana, spirit, killable, physicalDefence, spiritDef, magicDef, spiritAttack, magicAttack, physicalAttack)
        {
        }
    }
}