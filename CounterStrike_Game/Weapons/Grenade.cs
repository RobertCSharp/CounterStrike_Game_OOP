﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterStrike_Game.Weapons
{
    public class Grenade : Weapon
    {
        public Grenade(string name, string skin, int damage, int price) : base(name, skin, damage, price)
        {
        }
    }
}
