using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleStage.Enums;

namespace BattleStage.Characters.Scourge
{
    public class Creeper : Minion
    {
        public Creeper(string name, Alignment alignment) : base(name, alignment)
        {
            _basicHealth = 40;
            _basicstrength = 25;
            _basicDexterity = 35;
            _basicDefence = 8;

            _randomHitChance = new Random(3);

            _defenceFactor = 0.15;

            _dexterityDamageFactor = 0.18;
            _strengthDamageFactor = 0.15;
        }
    }
}
