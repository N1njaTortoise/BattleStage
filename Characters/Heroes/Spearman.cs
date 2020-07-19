using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleStage.Enums;

namespace BattleStage.Characters
{
    class Spearman : Character
    {
        public Spearman(string name, Alignment alignment) : base(name, alignment)
        {
            _basicHealth = 100;
            _basicstrength = 20;
            _basicDexterity = 40;
            _basicDefence = 6;

            _dexterityDamageFactor = 0.3;
            _strengthDamageFactor = 0.2;
        }




    }
}
