using CounterStrike_Game;
using CounterStrike_Game.Armours;
using CounterStrike_Game.Weapons;
using System;

namespace Game_Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            Armour armour = new Armour(100, "Blue", 300);
            Grenade grenade = new Grenade("Smoke", "fade", 25, 15);
            BigRifle ak47 = new BigRifle("AK47", "Vulcan", 150, 2700);
            SmallRifle smallRifle = new SmallRifle("MP7", "BloodSport", 40, 15);
            Pistol desertEagle = new Pistol("Desert Eagle", "Code Red", 35, 700);
            Knife knife = new Knife("karambit", "Autotronic", 1400, 20);
            Terrorist player1 = new Terrorist("Poppy", armour, "Black");
            Console.WriteLine(player1);

            Armour armour2 = new Armour(100, "Black", 300);
            Grenade grenade2 = new Grenade("Flash", "fade", 25, 15);
            BigRifle bigRifle2 = new BigRifle("M4A1-S", "Printstream", 150, 729);
            SmallRifle smallRifle2 = new SmallRifle("MP9", "Food Chain", 40, 23);
            Pistol pistol2 = new Pistol("Desert Eagle", "Blaze", 35, 728);
            Knife knife2 = new Knife("Talon", "Marble Fade", 969, 20);
            Counter_Terrorist player2 = new Counter_Terrorist("Banderas", armour2, "Black");
            Console.WriteLine(player2);

            player1.BuyWeapon(ak47);
            player2.BuyWeapon(desertEagle);
        }
    }
}
