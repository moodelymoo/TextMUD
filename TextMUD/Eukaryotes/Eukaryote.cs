using System.Collections.Generic;
using System.Reflection;
using System.Text.Json.Serialization;
using TextMUD.Eukaryotes.EukaryoteObjects;

namespace TextMUD.Eukaryotes
{
    public abstract class Eukaryote
    {
        private string _name;
        private Inventory _inventory;
        private int[] _stats;
        private bool _killable;


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

        protected Eukaryote(string name, int level, int[] attack, int[] defence)
        {
            //for genning level specific eukaryotes
            throw new System.NotImplementedException();
        }

        protected Eukaryote()
        {
            // required for Json file loading
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