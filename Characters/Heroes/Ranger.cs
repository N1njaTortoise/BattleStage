using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleStage.Enums;

namespace BattleStage.Characters
{
    public class Ranger : Character
    {
        public Ranger(string name, Alignment alignment) : base(name, alignment)
        {
            _basicHealth = 80;
            _basicstrength = 25;
            _basicDexterity = 55;
            _basicDefence = 8;

            _dexterityDamageFactor = 0.35;
            _strengthDamageFactor = 0.25;
        }

    }
}
