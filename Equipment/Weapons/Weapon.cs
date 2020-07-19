using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleStage.Equipment.Weapons
{
    class Weapon
    {
        protected string name;
        protected string description;

        protected int baseDamage;

        public Weapon()
        {
            name = "Base Weapon";
            description = "Basic weapon to fend of chickens";
            baseDamage = 1;
        }

        public int Damage
        {
            get
            {
                return baseDamage;
            }
        }
    }
}
