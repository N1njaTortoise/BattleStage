using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleStage.Equipment.Weapons
{
    class IronSpear : Weapon
    {
        public IronSpear()
        {
            name = "Iron Spear";
            description = "With this, you could take on a lion.";
            baseDamage = 15;
        }
    }
}
