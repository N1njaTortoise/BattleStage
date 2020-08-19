using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleStage.Equipment.Weapons.Sword
{
    class StoneSword : Weapon
    {
        public StoneSword()
        {
            name = "Stone Sword";
            description = "Damn, why is this sword so heavy!";
            baseDamage = 10;
        }
    }
}
