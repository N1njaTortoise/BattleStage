using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleStage.Enums;

namespace BattleStage.Characters
{
    public class Character
    {
        private readonly string _name;
        private readonly Alignment _faction;

        protected int _basicHealth;
        protected int _basicstrength;
        protected int _basicDexterity;
        protected int _basicDefence;

        protected double _defenceFactor;
        protected double _dexterityDamageFactor;
        protected double _strengthDamageFactor;
        protected double _isDefendingMultiplier = 2;
        protected double _levelUpMultiplier = 0.1;

        protected bool _isDefending = false;

        protected Random _randomHitChance;

        public Character(string name, Alignment faction)
        {
            _name = name;
            _faction = faction;

            _randomHitChance = new Random(15);

            _defenceFactor = 0.1;

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
            set { _basicstrength = value; }
        }
        public int Dexterity
        {
            get
            {
                return _basicDexterity;
            }
        }
        public int Defence
        {
            get
            {
                return _basicDefence;
            }
            set { _basicDexterity = value; }
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

        public void LevelUp()
        {
            // health dex str
            _basicHealth = _basicHealth + Convert.ToInt32(_basicHealth * _levelUpMultiplier);
            _basicstrength = _basicstrength + Convert.ToInt32(_basicstrength * _levelUpMultiplier);
            _basicDexterity = _basicDexterity + Convert.ToInt32(_basicDexterity * _levelUpMultiplier);
        }
        public int Attack(int missFactor)
        {
            int attackDamage = Convert.ToInt32((_strengthDamageFactor * _basicstrength) + (_dexterityDamageFactor * _basicDexterity));

            if (missFactor <= 8)
            {
                return attackDamage;
            }
            else
            {
                Console.WriteLine("You missed!");

                return attackDamage = 0;
            }
        }

        //private int AttackHit()
        //{
        //    int hitChance = _randomHitChance.Next(1, 11);

        //    return hitChance;
        //}

        public int Defending()
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
    }
}
