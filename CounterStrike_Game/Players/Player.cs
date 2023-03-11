using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CounterStrike_Game.Armours;
using CounterStrike_Game.Weapons;

namespace CounterStrike_Game.Players
{
    public class Player
    {
        protected string UserName { get; set; }
        protected int Health { get; set; }
        protected Armour Armour { get; set; }
        protected int Budget { get; set; }
        protected string UniFormeColor { get; set; }
        protected List<Weapon> Weapons { get; set; }

        public Player(string userName, Armour armour, string uniFormeColor)
        {
            UserName = userName;
            Health = 100;
            Armour = armour;
            Budget = 1600;
            UniFormeColor = uniFormeColor;
            Weapons = new List<Weapon>()
            {
                new Pistol("glock", "weeq3", 15, 400),
                new Knife("knife", "default", 30)
            };
        }

        public override string ToString()
        {
            return $"Player details: [userName: {UserName}, health: {Health}, armour: {Armour}, budget: {Budget}, uniformeColor: {UniFormeColor}]";
        }

        public void Attack()
        {

        }

        public void BuyWeapon(Weapon weapon)
        {
            if (Budget > weapon.Price)
            {
                Console.WriteLine($"You bought a new weapon: {weapon.Name}");
                Weapons.Add(weapon);
            }
            else
            {
                Console.WriteLine("Sorry you don't have enough money for this weapon");
            }
        }
    }
}
