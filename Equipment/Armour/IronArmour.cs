using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleStage.Equipment.Armour
{
    class IronArmour : Armor
    {
        public IronArmour()
        {
            name = "Iron Armour";
            description = "Armour used by honered knights.";
            baseDefence = 8;
        }
    }
}
