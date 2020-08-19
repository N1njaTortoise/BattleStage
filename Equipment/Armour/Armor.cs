using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleStage.Equipment.Armour
{
    class Armor
    {
        protected string name;
        protected string description;

        protected int baseDefence;

        public Armor()
        {
            name = "Base Armour";
            description = "Basic armour - well call it clothes.";
            baseDefence = 1;
        }

        public int Defence
        {
            get
            {
                return baseDefence;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public string ArmourDescription
        {
            get
            {
                return description;
            }
        }
    }
}
