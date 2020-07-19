using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleStage.Enums;

namespace BattleStage.Characters.Scourge
{
    class Skeleton : Minion
    {
        public Skeleton(string name, Alignment alignment) : base(name, alignment)
        {
            _basicHealth = 60;
            _basicstrength = 35;
            _basicDexterity = 45;
            _basicDefence = 12;

            _randomHitChance = new Random(11);

            _defenceFactor = 0.05;

            _dexterityDamageFactor = 0.1;
            _strengthDamageFactor = 0.2;
        }
    }
}
