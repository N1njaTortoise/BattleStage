using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleStage.Enums;

namespace BattleStage.Characters
{
    class HeroClass
    {
        private readonly string _name;
        private readonly Alignment _faction;

        private int _basicHealth;
        private int _basicstrength;
        private int _basicDexterity;

        private bool _isAlive;

        // Spearman Stats
        private int _basicHealthSpearman = 100;
        private int _basicstrengthSpearman = 20;
        private int _basicDexteritySpearman = 40;

        // Swordsman Stats
        private int _basicHealthSwordsman = 140;
        private int _basicstrengthSwordsman = 40;
        private int _basicDexteritySwordsman = 30;

        // Ranger Stats
        private int _basicHealthRanger = 80;
        private int _basicstrengthRanger = 25;
        private int _basicDexterityRanger = 55;
        private int _trueShotRanger = 101010101;

        public HeroClass(string name, Alignment faction, HeroClassTypes heroClassTypes)
        {
            _name = name;
            _faction = faction;
            _isAlive = true;

            switch (heroClassTypes)
            {
                case HeroClassTypes.spearman:
                    _basicHealth = _basicHealthSpearman;
                    _basicstrength = _basicstrengthSpearman;
                    _basicDexterity = _basicDexteritySpearman;
                    break;
                case HeroClassTypes.swordsman:
                    _basicHealth = _basicHealthSwordsman;
                    _basicstrength = _basicstrengthSwordsman;
                    _basicDexterity = _basicDexteritySwordsman;
                    break;
                case HeroClassTypes.ranger:
                    _basicHealth = _basicHealthRanger;
                    _basicstrength = _basicstrengthRanger;
                    _basicDexterity = _basicDexterityRanger;
                    break;
                default:
                    break;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public int Strength
        {
            get
            {
                return _basicstrength;
            }
        }
        public int Dexterity
        {
            get
            {
                return _basicDexterity;
            }
        }
        public int Health
        {
            get
            {
                return _basicHealth;
            }
        }
    }
}
