using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleStage.Enums;

namespace BattleStage.Characters.Scourge
{
    class Enemy
    {
        public readonly Minion minionType;
        public readonly Creeper creeperType;
        public readonly Skeleton skeletontype;
        public readonly Orc orcType;

        private EnemyClassType _enemyClass;

        protected bool _isAlive;
        private bool _Attacking;
        private bool _Miss;
        private int _damageDealt;

        public Enemy(EnemyClassType enemyClass)
        {
            _enemyClass = enemyClass;
            _isAlive = true;

            switch (enemyClass)
            {
                case EnemyClassType.minion:
                    minionType = new Minion("Minion", Alignment.evil);
                    break;
                case EnemyClassType.creeper:
                    creeperType = new Creeper("Creeper", Alignment.evil);
                    break;
                case EnemyClassType.skeleton:
                    skeletontype = new Skeleton("Skeleton", Alignment.evil);
                    break;
                case EnemyClassType.orc:
                    orcType = new Orc("Orc", Alignment.evil);
                    break;
                default:
                    break;
            }
        }

        public bool IsAlive
        {
            get
            {
                return _isAlive;
            }
            set
            {
                _isAlive = value;
            }
        }

        public bool ISAttacking
        {
            get
            {
                return _Attacking;
            }
            set
            {
                _Attacking = value;
            }
        }
        public bool ISMissing
        {
            get
            {
                return _Miss;
            }
            set
            {
                _Miss = value;
            }
        }
        public int DamageDealt
        {
            get
            {
                return _damageDealt;
            }
            set
            {
                _damageDealt = value;
            }
        }

        public int GettingHealth(EnemyClassType enemyClass)
        {
            switch (enemyClass)
            {
                case EnemyClassType.minion:
                    return minionType.Health;
                case EnemyClassType.creeper:
                    return creeperType.Health;
                case EnemyClassType.skeleton:
                    return skeletontype.Health;
                case EnemyClassType.orc:
                    return orcType.Health;
                default:
                    return 1;
            }
        }
        public void SettingHealth(EnemyClassType enemyClass, int healthNewHealthValue)
        {
            switch (enemyClass)
            {
                case EnemyClassType.minion:
                    minionType.Health = healthNewHealthValue;
                    break;
                case EnemyClassType.creeper:
                    creeperType.Health = healthNewHealthValue;
                    break;
                case EnemyClassType.skeleton:
                    skeletontype.Health = healthNewHealthValue;
                    break;
                case EnemyClassType.orc:
                    orcType.Health = healthNewHealthValue;
                    break;
                default:
                    break;
            }
        }

        public void AttackPlayer1(HeroClassTypes heroClassTypes, Hero hero, EnemyClassType enemyClass)
        {
            int damage = ReturnDamageDealt(enemyClass);
            int reducedDamage = EnemyDamageReductionFromDefence(damage, heroClassTypes, hero);

            PlayerHealthReduction1(hero, reducedDamage, heroClassTypes);
        }
        private int ReturnDamageDealt(EnemyClassType enemyClass)
        {
            int damage = 0;
            ISAttacking = true;

            switch (enemyClass)
            {
                case EnemyClassType.minion:
                    damage = minionType.Attack();
                    break;
                case EnemyClassType.creeper:
                    damage = creeperType.Attack();
                    break;
                case EnemyClassType.skeleton:
                    damage = skeletontype.Attack();
                    break;
                case EnemyClassType.orc:
                    damage = orcType.Attack();
                    break;
                default:
                    break;
            }

            if (damage == 0)
            {
                Console.WriteLine("No damage done!");
                ISMissing = true;
                return 0;
            }
            else
            {
                ISMissing = false;
                return damage;
            }

        }
        private int EnemyDamageReductionFromDefence(int damage, HeroClassTypes heroClass, Hero hero)
        {
            int defence = 0;
            int reducedDamage = 0;

            switch (heroClass)
            {
                case HeroClassTypes.spearman:
                    defence = hero.heroSpear.Defending();
                    //reducedDamage = DamageChecker(damage, defence);
                    break;
                case HeroClassTypes.swordsman:
                    defence = hero.heroSword.Defending();
                    break;
                case HeroClassTypes.ranger:
                    defence = hero.heroRanger.Defending();
                    break;
                default:
                    break;
            }

            reducedDamage = DamageChecker(damage, defence);

            DamageDealt = reducedDamage;

            return reducedDamage;
        }

        private void PlayerHealthReduction1(Hero hero, int damage, HeroClassTypes heroClass)
        {
            int healthSetter = 0;
            int enemyHealth = hero.GettingHealth(heroClass);

            int currentHealth = enemyHealth - damage;
            int healthReduction = enemyHealth - damage;

            if (currentHealth <= 0)
            {
                healthSetter = 0;
                hero.SettingHealth(heroClass, healthSetter);
                hero.IsAlive = false;
            }
            else
            {
                Console.WriteLine($"Enemy Attacks for {damage}");

                hero.SettingHealth(heroClass, healthReduction);
            }
        }

        private int DamageChecker(int damage, int defence)
        {
            if (damage - defence <= 0)
            {
                return 0;
            }
            else
            {
                return damage -= defence;
            }
        }

        public void EnemyDefend(EnemyClassType enemyClass, bool defending)
        {
            DamageDealt = 0;

            if (defending == true)
            {
                ISAttacking = false;
            }

            switch (enemyClass)
            {
                case EnemyClassType.minion:
                    if (defending == true)
                    {
                        Console.WriteLine("The enemy is defending!");
                        minionType.IsDefending = true;
                    }
                    else
                    {
                        minionType.IsDefending = false;
                    }
                    break;
                case EnemyClassType.creeper:
                    if (defending == true)
                    {
                        Console.WriteLine("The enemy is defending!");
                        creeperType.IsDefending = true;
                    }
                    else
                    {
                        creeperType.IsDefending = false;
                    }
                    break;
                case EnemyClassType.skeleton:
                    if (defending == true)
                    {
                        Console.WriteLine("The enemy is defending!");
                        skeletontype.IsDefending = true;
                    }
                    else
                    {
                        skeletontype.IsDefending = false;
                    }
                    break;
                case EnemyClassType.orc:
                    if (defending == true)
                    {
                        Console.WriteLine("The enemy is defending!");
                        orcType.IsDefending = true;
                    }
                    else
                    {
                        orcType.IsDefending = false;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
