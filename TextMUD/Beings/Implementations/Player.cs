﻿using TextMUD.Beings.Objects;

namespace TextMUD.Beings.Implementations
{
    public class Player : Eukaryote
    {
        public Player(string name, Inventory inventory, int level, int hp, int stamina, int mana, int spirit, bool killable, int defence, int spiritDef, int magicDef, int spiritAttack, int magicAttack, int physicalAttack) : base(name, inventory, level, hp, stamina, mana, spirit, killable, defence, spiritDef, magicDef, spiritAttack, magicAttack, physicalAttack)
        {
        }
    }
}