using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleStage.Equipment.Weapons.Range
{
    class WoodenBow : Weapon
    {
        public WoodenBow()
        {
            name = "Wooden Bow";
            description = "A cheap but sturdy bow used for hunting rabbits.";
            baseDamage = 5;
        }
    }
}
