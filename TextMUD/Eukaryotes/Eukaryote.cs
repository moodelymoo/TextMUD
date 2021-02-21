using System.Collections.Generic;
using TextMUD.Eukaryotes.EukaryoteObjects;

namespace TextMUD.Eukaryotes
{
    public abstract class Eukaryote
    {
        protected Eukaryote(string name, Inventory inventory, int level, int hp, int stamina, int mana, int spirit,
            bool killable, IReadOnlyList<int> attack, IReadOnlyList<int> defence)
        {
            Name = name;
            Inventory = inventory;
            Killable = killable;
            Stats = new[]
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

        protected Eukaryote()
        {
            // required for Json file loading
        }


        public string Name { get; set; }
        
        public Inventory Inventory { get; set; }

        public int[] Stats { get; set; }

        public bool Killable { get; set; }


        public override string ToString()
        {
            return "Player Stat Sheet\n".ToUpper() +
                   $"Name: {Name}\t Money: {Inventory.Money} \t Level: {Stats[0]}\n" +
                   $"Hp: {Stats[1]}\t\t Stamina: {Stats[2]}\t Mana: {Stats[3]}\t\t \n" +
                   $"Physical:\t Attack: {Stats[5]}\t Defence: {Stats[8]}\t \n" +
                   $"Magical:\t Attack: {Stats[6]}\t Defence: {Stats[9]}\t \n" +
                   $"Spirit:\t\t Attack: {Stats[7]}\t Defence: {Stats[10]}\t \n\n" +
                   $"Killable: {Killable}\n\n" +
                   $"Active Inventory:\n" +
                   $"{Inventory.GetAllActiveInv()}\n" +
                   $"Passive Inventory:\n" +
                   $"{Inventory.GetAllPassiveInv()}";
        }
    }
}