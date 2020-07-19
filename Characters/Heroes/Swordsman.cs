using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleStage.Enums;

namespace BattleStage.Characters
{
    class Swordsman : Character
    {
        public Swordsman(string name, Alignment alignment) : base(name, alignment)
        {
            _basicHealth = 140;
            _basicstrength = 40;
            _basicDexterity = 30;
            _basicDefence = 10;

            _dexterityDamageFactor = 0.2;
            _strengthDamageFactor = 0.3;

        }




    }
}
