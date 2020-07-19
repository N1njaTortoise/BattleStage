using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleStage.Enums;

namespace BattleStage.Characters.Scourge
{
    class Orc : Minion
    {
        public Orc(string name, Alignment alignment) : base(name, alignment)
        {
            _basicHealth = 70;
            _basicstrength = 55;
            _basicDexterity = 40;
            _basicDefence = 15;

            _randomHitChance = new Random(25);

            _defenceFactor = 0.2;

            _dexterityDamageFactor = 0.15;
            _strengthDamageFactor = 0.25;
        }
    }
}
