using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleStage.Equipment.Weapons.Range
{
    class IronBow : Weapon
    {
        public IronBow()
        {
            name = "Iron Bow";
            description = "A composit bow with sharp blades for close combat.";
            baseDamage = 15;
        }
    }
}
