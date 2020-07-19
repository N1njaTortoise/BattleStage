using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleStage.Equipment.Weapons
{
    class WoodenSpear : Weapon
    {
        public WoodenSpear()
        {
            name = "Wooden Spear";
            description = "A sharp pointy stick to poke things with.";
            baseDamage = 5;
        }
    }
}
