using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleStage.Enums;
using BattleStage.Characters.Scourge;
using BattleStage.Equipment.Weapons;

namespace BattleStage.Characters
{
    class Hero
    {
        // public readonly HeroClass hero;
        private bool _isAlive;

        public readonly Spearman heroSpear;
        public readonly Swordsman heroSword;
        public readonly Ranger heroRanger;

        public readonly Weapon weapon;
        //public readonly Armour armour;
        //public readonly Item item;

        private HeroClassTypes heroClassSelected;

        public Hero(HeroClassTypes heroClassTypes, string name)
        {
            heroClassSelected = heroClassTypes;
            _isAlive = true;

            switch (heroClassTypes)
            {
                case HeroClassTypes.spearman:
                    //hero = new HeroClass(name, Alignment.good, HeroClassTypes.spearman);
                    heroSpear = new Spearman(name, Alignment.good);
                    weapon = new WoodenSpear();
                    break;
                case HeroClassTypes.swordsman:
                    //hero = new HeroClass(name, Alignment.good, HeroClassTypes.swordsman);
                    heroSword = new Swordsman(name, Alignment.good);
                    weapon = new WoodenSpear();

                    break;
                case HeroClassTypes.ranger:
                    //hero = new HeroClass(name, Alignment.good, HeroClassTypes.ranger);
                    heroRanger = new Ranger(name, Alignment.good);
                    weapon = new WoodenSpear();

                    break;
                default:
                    break;
            }
        }

        public int GettingHealth(HeroClassTypes heroClass)
        {
            switch (heroClass)
            {
                case HeroClassTypes.spearman:
                    return heroSpear.Health;
                case HeroClassTypes.swordsman:
                    return heroSword.Health;
                case HeroClassTypes.ranger:
                    return heroRanger.Health;
                default:
                    return 1;
            }
        }

        public void AttackEnemy(HeroClassTypes heroClassTypes, Enemy enemy, EnemyClassType enemyClass)
        {
            int damage;

            switch (heroClassTypes)
            {
                case HeroClassTypes.spearman:
                    damage = heroSpear.Attack();

                    if (damage == 0)
                    {
                        Console.WriteLine("No damage done!");
                    }
                    else
                    {
                        damage += weapon.Damage;
                    }

                    AttackEnemyHelper(damage, enemyClass, enemy);

                    break;
                case HeroClassTypes.swordsman:
                    damage = heroSword.Attack();

                    if (damage == 0)
                    {
                        Console.WriteLine("No damage done!");
                    }
                    else
                    {
                        damage += weapon.Damage;
                    }

                    AttackEnemyHelper(damage, enemyClass, enemy);

                    break;
                case HeroClassTypes.ranger:
                    damage = heroRanger.Attack();

                    if (damage == 0)
                    {
                        Console.WriteLine("No damage done!");
                    }
                    else
                    {
                        damage += weapon.Damage;
                    }

                    AttackEnemyHelper(damage, enemyClass, enemy);

                    break;
                default:
                    break;
            }
        }

        private void EnemyHealthReduction(Enemy enemy, int damage, EnemyClassType enemyType)
        {
            int enemyHealth;

            switch (enemyType)
            {
                case EnemyClassType.minion:
                    if (enemy.minionType.Health - damage <= 0)
                    {
                        enemyHealth = 0;
                        enemy.minionType.Health = enemyHealth;
                    }
                    else
                    {
                        Console.WriteLine($"You attack for {damage}");

                        enemy.minionType.Health -= damage;
                    }
                    break;
                case EnemyClassType.creeper:
                    if (enemy.creeperType.Health - damage <= 0)
                    {
                        enemyHealth = 0;
                        enemy.creeperType.Health = enemyHealth;
                    }
                    else
                    {
                        Console.WriteLine($"You attack for {damage}");

                        enemy.creeperType.Health -= damage;
                    }
                    break;
                case EnemyClassType.skeleton:
                    if (enemy.skeletontype.Health - damage <= 0)
                    {
                        enemyHealth = 0;
                        enemy.skeletontype.Health = enemyHealth;
                    }
                    else
                    {
                        Console.WriteLine($"You attack for {damage}");

                        enemy.skeletontype.Health -= damage;
                    }
                    break;
                case EnemyClassType.orc:
                    if (enemy.orcType.Health - damage <= 0)
                    {
                        enemyHealth = 0;
                        enemy.orcType.Health = enemyHealth;
                    }
                    else
                    {
                        Console.WriteLine($"You attack for {damage}");

                        enemy.orcType.Health -= damage;
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
                return damage = 0;
            }
            else
            {
                return damage -= defence;
            }
            //switch (enemyType)
            //{
            //    case EnemyClassType.minion:

            //        if (damage - defence <= 0)
            //        {
            //            return damage = 0;
            //        }
            //        else
            //        {
            //            return damage -= defence;
            //        }
            //    case EnemyClassType.creeper:

            //        if (damage - defence <= 0)
            //        {
            //            return damage = 0;
            //        }
            //        else
            //        {
            //            return damage -= defence;
            //        }
            //    //case EnemyClassType.skeleton:
            //    //    break;
            //    //case EnemyClassType.orc:
            //    //    break;
            //    default:
            //        return 1;
            //}
        }

        private void AttackEnemyHelper(int damage, EnemyClassType enemyClass, Enemy enemy)
        {
            int defence;

            switch (enemyClass)
            {
                case EnemyClassType.minion:

                    defence = enemy.minionType.Defence();
                    damage = DamageChecker(damage, defence);

                    EnemyHealthReduction(enemy, damage, enemyClass);

                    break;
                case EnemyClassType.creeper:

                    defence = enemy.creeperType.Defence();
                    damage = DamageChecker(damage, defence);

                    EnemyHealthReduction(enemy, damage, enemyClass);

                    break;
                case EnemyClassType.skeleton:

                    defence = enemy.skeletontype.Defence();
                    damage = DamageChecker(damage, defence);

                    EnemyHealthReduction(enemy, damage, enemyClass);

                    break;
                case EnemyClassType.orc:

                    defence = enemy.orcType.Defence();
                    damage = DamageChecker(damage, defence);

                    EnemyHealthReduction(enemy, damage, enemyClass);

                    break;
                default:
                    break;
            }
        }

        public void PlayerDefend(HeroClassTypes heroClass, bool defending)
        {
            switch (heroClass)
            {
                case HeroClassTypes.spearman:
                    if (defending == true)
                    {
                        Console.WriteLine("You are defending!");
                        heroSpear.IsDefending = true;
                    }
                    else
                    {
                        heroSpear.IsDefending = false;
                    }
                    break;
                case HeroClassTypes.swordsman:
                    if (defending == true)
                    {
                        Console.WriteLine("You are defending!");
                        heroSword.IsDefending = true;
                    }
                    else
                    {
                        heroSword.IsDefending = false;
                    }
                    break;
                case HeroClassTypes.ranger:
                    if (defending == true)
                    {
                        Console.WriteLine("You are defending!");
                        heroRanger.IsDefending = true;
                    }
                    else
                    {
                        heroRanger.IsDefending = false;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
