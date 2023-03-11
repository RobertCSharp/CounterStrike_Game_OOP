using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterStrike_Game.Armours
{
    public class Armour
    {
        public int Health { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }

        public Armour(int health, string color, int price)
        {
            Health = health;
            Color = color;
            Price = price;
        }

        public override string ToString()
        {
            return $"health: {Health} color: {Color} price: {Price}";
        }
    }
}
