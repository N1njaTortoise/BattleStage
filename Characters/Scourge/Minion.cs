using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleStage.Enums;

namespace BattleStage.Characters.Scourge
{
    public class Minion
    {
        private readonly string _name;
        private readonly Alignment _faction;

        protected int _basicHealth;
        protected int _basicstrength;
        protected int _basicDexterity;
        protected int _basicDefence;

        protected double _dexterityDamageFactor;
        protected double _strengthDamageFactor;
        protected double _defenceFactor;
        protected double _isDefendingMultiplier = 2;

        protected bool _isDefending = false;

        protected Random _randomHitChance;

        public Minion(string name, Alignment faction)
        {
            _name = name;
            _faction = faction;
            _basicHealth = 35;
            _basicstrength = 20;
            _basicDexterity = 30;
            _basicDefence = 5;

            _randomHitChance = new Random(5);

            _defenceFactor = 0.1;

            _dexterityDamageFactor = 0.15;
            _strengthDamageFactor = 0.1;
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
            set
            {
                _basicHealth = value;
            }
        }
        public bool IsDefending
        {
            get
            {
                return _isDefending;
            }
            set
            {
                _isDefending = value;
            }
        }

        public int Defence()
        {
            int defence = Convert.ToInt32((_defenceFactor * _basicDexterity) + (_basicDefence));
            
            if (_isDefending == true)
            {
                return defence *= Convert.ToInt32(_isDefendingMultiplier);
            }
            else
            {
                return defence;
            }

        }

        public int Attack()
        {
            int attackDamage = Convert.ToInt32((_strengthDamageFactor * _basicstrength) + (_dexterityDamageFactor * _basicDexterity) * 2.5);

            // Replace 6 with a miss factor percentage
            if (AttackHit() < 6)
            {
                return attackDamage;
            }
            else
            {
                Console.WriteLine("Enemy missed!");

                return attackDamage = 0;
            }
        }

        private int AttackHit()
        {
            int hitChance = _randomHitChance.Next(1, 11);

            return hitChance;
        }
    }
}
