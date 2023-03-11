using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterStrike_Game.Weapons
{
    public class Weapon
    {
        public string Name { get; set; }
        protected string Skin { get; set; }
        protected int Damage { get; set; }
        public int Price { get; set; }

        public Weapon(string name, string skin, int damage, int price)
        {
            Name = name;
            Skin = skin;
            Damage = damage;
            Price = price;
        }

        public Weapon(string name, string skin, int damage)
        {
            Name = name;
            Skin = skin;
            Damage = damage;
        }
        public override string ToString()
        {
            return $"name: {Name} skin: {Skin} damage: {Damage} price: {Price}";
        }
    }
}
