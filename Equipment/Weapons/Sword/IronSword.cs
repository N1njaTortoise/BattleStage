using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleStage.Equipment.Weapons.Sword
{
    class IronSword : Weapon
    {
        public IronSword()
        {
            name = "Iron Sword";
            description = "Every soldiers best friend!";
            baseDamage = 15;
        }
    }
}
