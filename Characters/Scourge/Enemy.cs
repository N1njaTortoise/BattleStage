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

        public int EnemyCombatSelecter()
        {
            Random random = new Random();

            return random.Next(1, 3);
        }

        public void AttackPlayer(HeroClassTypes heroClassTypes, Hero hero, EnemyClassType enemyClass)
        {
            int damage;

            switch (enemyClass)
            {
                case EnemyClassType.minion:
                    damage = minionType.Attack();

                    if (damage == 0)
                    {
                        Console.WriteLine("No damage done!");
                    }

                    AttackPlayerHelper(damage, heroClassTypes, hero);

                    break;
                case EnemyClassType.creeper:
                    damage = creeperType.Attack();

                    if (damage == 0)
                    {
                        Console.WriteLine("No damage done!");
                    }

                    AttackPlayerHelper(damage, heroClassTypes, hero);

                    break;
                case EnemyClassType.skeleton:
                    damage = skeletontype.Attack();

                    if (damage == 0)
                    {
                        Console.WriteLine("No damage done!");
                    }

                    AttackPlayerHelper(damage, heroClassTypes, hero);

                    break;
                case EnemyClassType.orc:
                    damage = orcType.Attack();

                    if (damage == 0)
                    {
                        Console.WriteLine("No damage done!");
                    }

                    AttackPlayerHelper(damage, heroClassTypes, hero);

                    break;
                default:
                    break;
            }
        }

        private void EnemyHealthReduction(Hero hero, int damage, HeroClassTypes heroClass)
        {
            int playerHealth;

            switch (heroClass)
            {
                case HeroClassTypes.spearman:
                    if (hero.heroSpear.Health - damage <= 0)
                    {
                        playerHealth = 0;
                        hero.heroSpear.Health = playerHealth;
                    }
                    else
                    {
                        Console.WriteLine($"Enemy attacks for {damage}");

                        hero.heroSpear.Health -= damage;
                    }
                    break;
                case HeroClassTypes.swordsman:
                    if (hero.heroSword.Health - damage <= 0)
                    {
                        playerHealth = 0;
                        hero.heroSword.Health = playerHealth;
                    }
                    else
                    {
                        Console.WriteLine($"Enemy attack for {damage}");

                        hero.heroSword.Health -= damage;
                    }
                    break;
                case HeroClassTypes.ranger:
                    if (hero.heroRanger.Health - damage <= 0)
                    {
                        playerHealth = 0;
                        hero.heroRanger.Health = playerHealth;
                    }
                    else
                    {
                        Console.WriteLine($"Enemy attack for {damage}");

                        hero.heroRanger.Health -= damage;
                    }
                    break;
                default:
                    break;
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

        private void AttackPlayerHelper(int damage, HeroClassTypes heroClass, Hero hero)
        {
            int defence;

            switch (heroClass)
            {
                case HeroClassTypes.spearman:

                    defence = hero.heroSpear.Defending();
                    damage = DamageChecker(damage, defence);

                    EnemyHealthReduction(hero, damage, heroClass);

                    break;
                case HeroClassTypes.swordsman:

                    defence = hero.heroSword.Defending();
                    damage = DamageChecker(damage, defence);

                    EnemyHealthReduction(hero, damage, heroClass);

                    break;
                case HeroClassTypes.ranger:

                    defence = hero.heroRanger.Defending();
                    damage = DamageChecker(damage, defence);

                    EnemyHealthReduction(hero, damage, heroClass);

                    break;
                default:
                    break;
            }
        }

        public void EnemyDefend(EnemyClassType enemyClass, bool defending)
        {
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
