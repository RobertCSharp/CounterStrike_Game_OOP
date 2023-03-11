using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CounterStrike_Game.Armours;
using CounterStrike_Game.Players;
using CounterStrike_Game.Weapons;

namespace CounterStrike_Game
{
    public class Counter_Terrorist : Player
    {
        public Counter_Terrorist(string userName, Armour armour, string uniformeColor) : base(userName, armour, uniformeColor) { }
    }
}
