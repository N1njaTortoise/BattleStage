using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleStage.Enums;
using BattleStage.Characters.Scourge;
using BattleStage.Equipment.Weapons;
using BattleStage.MenuInput;
using BattleStage.Equipment;
using BattleStage.Equipment.Armour;
using BattleStage.Equipment.Weapons.Sword;
using BattleStage.Equipment.Weapons.Range;
using BattleStage.Equipment.Items;

namespace BattleStage.Characters
{
    class Hero
    {
        // public readonly HeroClass hero;
        private bool _isAlive;
        private bool _Attacking;
        private bool _Miss;
        private bool _usableItem;

        private int _damageDealt;
        private int _currentLevel;
        private int _currentExperience;
        private int _expForLevelUp = 100; 

        public readonly Spearman heroSpear;
        public readonly Swordsman heroSword;
        public readonly Ranger heroRanger;

        private Weapon weapon;
        private Armor armour;
        private PotionItem potion;

        private HeroClassTypes heroClassSelected;

        public bool ISAttacking 
        { get
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
        public int PlayerLevel
        {
            get
            {
                return _currentLevel;
            }
            set
            {
                _currentLevel = value;
            }
        }
        public int PlayerExperience
        {
            get
            {
                return _currentExperience;
            }
            set
            {
                _currentExperience = value;
            }
        }
        public bool UsableItem
        {
            get
            {
                return _usableItem;
            }
        }


        public Weapon Weapon
        {
            get
            {
                return weapon;
            }
            set
            {
                weapon = value;
            }
        }
        public Armor Armor
        {
            get
            {
                return armour;
            }
            set
            {
                armour = value;
            }
        }
        public PotionItem Potion
        {
            get
            {
                return potion;
            }
            set
            {
                potion = value;
            }
        }


        public Hero(HeroClassTypes heroClassTypes, string name)
        {
            heroClassSelected = heroClassTypes;
            _isAlive = true;
            PlayerLevel = 1;
            PlayerExperience = 0;

            switch (heroClassTypes)
            {
                case HeroClassTypes.spearman:
                    //hero = new HeroClass(name, Alignment.good, HeroClassTypes.spearman);
                    heroSpear = new Spearman(name, Alignment.good);
                    weapon = new WoodenSpear();
                    armour = new Armor();
                    potion = new PotionItem();
                    break;
                case HeroClassTypes.swordsman:
                    //hero = new HeroClass(name, Alignment.good, HeroClassTypes.swordsman);
                    heroSword = new Swordsman(name, Alignment.good);
                    weapon = new WoodenSword();
                    armour = new Armor();
                    potion = new PotionItem();
                    break;
                case HeroClassTypes.ranger:
                    //hero = new HeroClass(name, Alignment.good, HeroClassTypes.ranger);
                    heroRanger = new Ranger(name, Alignment.good);
                    weapon = new WoodenBow();
                    armour = new Armor();
                    potion = new PotionItem();
                    break;
                default:
                    break;
            }
        }

        public void PlayerLevelManager(Enemy enemy, EnemyClassType enemyClass, HeroClassTypes heroClass, StateManager stateManager)
        {
            if (enemy.IsAlive == false)
            {
                switch (enemyClass)
                {
                    case EnemyClassType.minion:
                        PlayerExperience += 40;
                        break;
                    case EnemyClassType.creeper:
                        PlayerExperience += 60;
                        break;
                    case EnemyClassType.skeleton:
                        PlayerExperience += 100;
                        break;
                    case EnemyClassType.orc:
                        PlayerExperience += 150;
                        break;
                    default:
                        break;
                }
            }

            if (PlayerExperience >= _expForLevelUp)
            {
                stateManager.StoreLevelUpDataOLD(_currentLevel);
                PlayerLevel++;
                stateManager.StoreLevelUpDataNEW(_currentLevel);

                _expForLevelUp = _expForLevelUp + Convert.ToInt32(_expForLevelUp * 2);
                
                switch (heroClass)
                {
                    case HeroClassTypes.spearman:
                        stateManager.StoreLevelUpDataOLD(heroSpear.Health, heroSpear.Strength, heroSpear.Dexterity);
                        heroSpear.LevelUp();
                        stateManager.StoreLevelUpDataNEW(heroSpear.Health, heroSpear.Strength, heroSpear.Dexterity);
                        break;
                    case HeroClassTypes.swordsman:
                        stateManager.StoreLevelUpDataOLD(heroSword.Health, heroSword.Strength, heroSword.Dexterity);
                        heroSword.LevelUp();
                        stateManager.StoreLevelUpDataNEW(heroSword.Health, heroSword.Strength, heroSword.Dexterity);
                        break;
                    case HeroClassTypes.ranger:
                        stateManager.StoreLevelUpDataOLD(heroRanger.Health, heroRanger.Strength, heroRanger.Dexterity);
                        heroRanger.LevelUp();
                        stateManager.StoreLevelUpDataNEW(heroRanger.Health, heroRanger.Strength, heroRanger.Dexterity);
                        break;
                    default:
                        break;
                }
                MenuQueries.CharacterLevelUp(stateManager);
                Console.ReadKey();
            }
        }

        public void EquipItem(ItemManager item, bool enemyAlive)
        {
            item.ItemDrop(enemyAlive, heroClassSelected);

            string input;

            if (item.ITEMDROPPED == true)
            {
                if (item.ITEMTYPEDROPPED == ItemType.Weapon)
                {
                    input = MenuQueries.ItemDropped(item, heroClassSelected);

                    if (input.Equals("y",StringComparison.OrdinalIgnoreCase))
                    {
                        Weapon = item.WEAPONDROPPED;
                    }

                }
                else if (item.ITEMTYPEDROPPED == ItemType.Armour)
                {
                    input = MenuQueries.ItemDropped(item, heroClassSelected);

                    if (input.Equals("y", StringComparison.OrdinalIgnoreCase))
                    {
                        Armor = item.ARMOR_DROPPED;
                    }
                }
                else if (item.ITEMTYPEDROPPED == ItemType.Item)
                {
                    input = MenuQueries.ItemDropped(item, heroClassSelected);

                    if (input.Equals("y", StringComparison.OrdinalIgnoreCase))
                    {
                        Potion = item.POTION_DROPPED;
                        _usableItem = true;
                    }
                }
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
        public void SettingHealth(HeroClassTypes heroClass, int healthNewHealthValue)
        {
            switch (heroClass)
            {
                case HeroClassTypes.spearman:
                    heroSpear.Health = healthNewHealthValue;
                    break;
                case HeroClassTypes.swordsman:
                    heroSword.Health = healthNewHealthValue;
                    break;
                case HeroClassTypes.ranger:
                    heroRanger.Health = healthNewHealthValue;
                    break;
                default:
                    break;
            }
        }

        private int ReturnDamageDealt(HeroClassTypes heroClass, int missFactor)
        {
            int damage = 0;
            ISAttacking = true;

            switch (heroClass)
            {
                case HeroClassTypes.spearman:
                    damage = heroSpear.Attack(missFactor);
                    break;
                case HeroClassTypes.swordsman:
                    damage = heroSword.Attack(missFactor);
                    break;
                case HeroClassTypes.ranger:
                    damage = heroRanger.Attack(missFactor);
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
                damage += weapon.Damage;
                ISMissing = false;
                return damage;
            }

        }

        public void AttackEnemy1(HeroClassTypes heroClassTypes, Enemy enemy, EnemyClassType enemyClass, int missFactor)
        {
            int damage = ReturnDamageDealt(heroClassTypes, missFactor);
            int reducedDamage = EnemyDamageReductionFromDefence(damage, enemyClass, enemy);

            EnemyHealthReduction1(enemy, reducedDamage, enemyClass);
        }

        private void EnemyHealthReduction1(Enemy enemy, int damage, EnemyClassType enemyType)
        {
            int healthSetter = 0;
            int enemyHealth = enemy.GettingHealth(enemyType);

            int currentHealth = enemyHealth - damage;
            int healthReduction = enemyHealth - damage;

            if (currentHealth <= 0)
            {
                healthSetter = 0;
                enemy.SettingHealth(enemyType, healthSetter);
                enemy.IsAlive = false;
            }
            else
            {
                Console.WriteLine($"You attack for {damage}");

                enemy.SettingHealth(enemyType, healthReduction);
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

        private int EnemyDamageReductionFromDefence(int damage, EnemyClassType enemyClass, Enemy enemy)
        {
            int defence = 0;
            int reducedDamage = 0;

            switch (enemyClass)
            {
                case EnemyClassType.minion:
                    defence = enemy.minionType.Defence();
                    reducedDamage = DamageChecker(damage, defence);
                    break;
                case EnemyClassType.creeper:
                    defence = enemy.creeperType.Defence();
                    reducedDamage = DamageChecker(damage, defence);
                    break;
                case EnemyClassType.skeleton:
                    defence = enemy.skeletontype.Defence();
                    reducedDamage = DamageChecker(damage, defence);
                    break;
                case EnemyClassType.orc:
                    defence = enemy.orcType.Defence();
                    reducedDamage = DamageChecker(damage, defence);
                    break;
                default:
                    break;
            }

            DamageDealt = reducedDamage;

            return reducedDamage;
        }

        public void PlayerDefend(HeroClassTypes heroClass, bool defending)
        {
            DamageDealt = 0;

            if (defending == true)
            {
                ISAttacking = false;
            }

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

        private void SettingPlayerHealthWithPotion(HeroClassTypes heroClass, int healthFromPotion)
        {
            switch (heroClass)
            {
                case HeroClassTypes.spearman:
                    heroSpear.Health += healthFromPotion;
                    break;
                case HeroClassTypes.swordsman:
                    heroSword.Health += healthFromPotion;
                    break;
                case HeroClassTypes.ranger:
                    heroRanger.Health += healthFromPotion;
                    break;
                default:
                    break;
            }
        }
        private void SettingPlayerDefenceWithPotion(HeroClassTypes heroClass, int defenceFromPotion)
        {
            switch (heroClass)
            {
                case HeroClassTypes.spearman:
                    heroSpear.Defence += defenceFromPotion;
                    break;
                case HeroClassTypes.swordsman:
                    heroSword.Defence += defenceFromPotion;
                    break;
                case HeroClassTypes.ranger:
                    heroRanger.Defence += defenceFromPotion;
                    break;
                default:
                    break;
            }
        }
        private void SettingPlayerStrengthWithPotion(HeroClassTypes heroClass, int strengthFromPotion)
        {
            switch (heroClass)
            {
                case HeroClassTypes.spearman:
                    heroSpear.Strength += strengthFromPotion;
                    break;
                case HeroClassTypes.swordsman:
                    heroSword.Strength += strengthFromPotion;
                    break;
                case HeroClassTypes.ranger:
                    heroRanger.Strength += strengthFromPotion;
                    break;
                default:
                    break;
            }
        }

        public void UseItem(HeroClassTypes heroClass)
        {
            int tempPotionProperty = potion.ITEM_PROPERTIES;

            switch (potion.PotionTypes)
            {
                case PotionTypes.Health:
                    SettingPlayerHealthWithPotion(heroClass, tempPotionProperty);
                    break;
                case PotionTypes.Defence:
                    SettingPlayerDefenceWithPotion(heroClass, tempPotionProperty);
                    break;
                case PotionTypes.Attack:
                    SettingPlayerStrengthWithPotion(heroClass, tempPotionProperty);
                    break;
                default:
                    break;
            }

            _usableItem = false;
            potion = new PotionItem();
        }

    }
}
