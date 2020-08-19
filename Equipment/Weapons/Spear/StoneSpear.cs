using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleStage.Equipment.Weapons
{
    class StoneSpear : Weapon
    {
        public StoneSpear()
        {
            name = "Stone Spear";
            description = "A little more durable than a pointy stick.";
            baseDamage = 10;
        }
    }
}
