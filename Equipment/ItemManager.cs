using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleStage.Enums;
using BattleStage.Characters;
using BattleStage.Equipment.Weapons;
using BattleStage.Equipment.Weapons.Sword;
using BattleStage.Equipment.Weapons.Range;
using BattleStage.Equipment.Armour.Spear;
using BattleStage.Equipment.Armour;
using BattleStage.Equipment.Items;

namespace BattleStage.Equipment
{
    class ItemManager
    {
        // value is a mulitply of percent (1 = 10%)
        private const int dropChance = 8;

        // values are whole percentages (60 = 60%)
        private const int WoodenEquipmentDropChance = 60;
        private const int StoneEquipmentDropChance = 30;
        private const int ironEquipmentDropChance = 9;
        private const int diamondEquipmentDropChance = 1;

        Random randomItemDropChance;

        private int randomDropChancePercentage;
        private int randomPotionGenerated;
        private int randomPotionStrengthGenerated;


        private bool itemDropped;

        private ItemType itemType;

        private Weapon itemTempWeapon;
        private Armor itemTempArmour;
        private PotionItem itemTempItem;

        public ItemManager()
        {
            randomItemDropChance = new Random();
        }
        public bool ITEMDROPPED
        {
            get
            {
                return itemDropped;
            }
        }
        public ItemType ITEMTYPEDROPPED
        {
            get
            {
                return itemType;
            }
        }
        public Weapon WEAPONDROPPED
        {
            get
            {
                return itemTempWeapon;
            }
        }
        public Armor ARMOR_DROPPED
        {
            get
            {
                return itemTempArmour;
            }
        }
        public PotionItem POTION_DROPPED
        {
            get
            {
                return itemTempItem;
            }
        }

        public void ItemDrop(bool enemyAlive, HeroClassTypes heroClass)
        {
            // get item drop chance - DONE
            // get what type of item is dropped - DONE
            // chance of different type of weapon
            // ask to equip
            // equip

            itemDropped = PercentageItemDrop(enemyAlive);

            itemType = ItemTypeDropped(itemDropped);

            if (itemType == ItemType.Weapon)
            {
                ReturnWeaponType(heroClass);
            }
            else if (itemType == ItemType.Armour)
            {
                ReturnArmourType();
            }
            else if (itemType == ItemType.Item)
            {
                ReturnItemType();
            }
        }

        private bool PercentageItemDrop(bool enemyAlive)
        {
            if (enemyAlive == false)
            {
                randomDropChancePercentage = randomItemDropChance.Next(1, 11);
                //randomDropChancePercentage = 1;

                if (randomDropChancePercentage == dropChance)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private ItemType ItemTypeDropped(bool itemDropped)
        {
            if (itemDropped == true)
            {
                randomDropChancePercentage = randomItemDropChance.Next(1, 4);

                if (randomDropChancePercentage == 1)
                {
                    return ItemType.Weapon;
                }
                else if (randomDropChancePercentage == 2)
                {
                    return ItemType.Armour;
                }
                else
                {
                    return ItemType.Item;
                }
            }
            else
            {
                return ItemType.Item;
            }
        }

        private void ReturnWeaponType(HeroClassTypes heroClass)
        {
            randomDropChancePercentage = randomItemDropChance.Next(1, 101);

            int lowPercent = 0;
            int woodRange = lowPercent + WoodenEquipmentDropChance;
            int stoneRange = woodRange + StoneEquipmentDropChance;
            int ironRange = stoneRange + ironEquipmentDropChance;
            int diamondRange = ironRange + diamondEquipmentDropChance;

            if (randomDropChancePercentage > lowPercent && randomDropChancePercentage <= woodRange)
            {
                switch (heroClass)
                {
                    case HeroClassTypes.spearman:
                        itemTempWeapon = new WoodenSpear();
                        break;
                    case HeroClassTypes.swordsman:
                        itemTempWeapon = new WoodenSword();
                        break;
                    case HeroClassTypes.ranger:
                        itemTempWeapon = new WoodenBow();
                        break;
                    default:
                        itemTempWeapon = new Weapon();
                        break;
                }
            }
            else if (randomDropChancePercentage > woodRange && randomDropChancePercentage <= stoneRange)
            {
                switch (heroClass)
                {
                    case HeroClassTypes.spearman:
                        itemTempWeapon = new StoneSpear();
                        break;
                    case HeroClassTypes.swordsman:
                        itemTempWeapon = new StoneSword();
                        break;
                    case HeroClassTypes.ranger:
                        itemTempWeapon = new StoneBow();
                        break;
                    default:
                        itemTempWeapon = new Weapon();
                        break;
                }
            }
            else if (randomDropChancePercentage > stoneRange && randomDropChancePercentage <= ironRange)
            {
                switch (heroClass)
                {
                    case HeroClassTypes.spearman:
                        itemTempWeapon = new IronSpear();
                        break;
                    case HeroClassTypes.swordsman:
                        itemTempWeapon = new IronSword();
                        break;
                    case HeroClassTypes.ranger:
                        itemTempWeapon = new IronBow();
                        break;
                    default:
                        itemTempWeapon = new Weapon();
                        break;
                }
            }
            else
            {
                switch (heroClass)
                {
                    case HeroClassTypes.spearman:
                        itemTempWeapon = new DiamondSpear();
                        break;
                    case HeroClassTypes.swordsman:
                        itemTempWeapon = new DiamondSword();
                        break;
                    case HeroClassTypes.ranger:
                        itemTempWeapon = new DiamondBow();
                        break;
                    default:
                        itemTempWeapon = new Weapon();
                        break;
                }
            }
        }

        private void ReturnArmourType()
        {
            randomDropChancePercentage = randomItemDropChance.Next(1, 101);

            int lowPercent = 0;
            int woodRange = lowPercent + WoodenEquipmentDropChance;
            int stoneRange = woodRange + StoneEquipmentDropChance;
            int ironRange = stoneRange + ironEquipmentDropChance;
            int diamondRange = ironRange + diamondEquipmentDropChance;

            if (randomDropChancePercentage > lowPercent && randomDropChancePercentage <= woodRange)
            {
                itemTempArmour = new WoodArmour();
            }
            else if (randomDropChancePercentage > woodRange && randomDropChancePercentage <= stoneRange)
            {
                itemTempArmour = new StoneArmour();
            }
            else if (randomDropChancePercentage > stoneRange && randomDropChancePercentage <= ironRange)
            {
                itemTempArmour = new IronArmour();
            }
            else
            {
                itemTempArmour = new DiamondArmour();
            }
        }

        private void ReturnItemType()
        {
            randomPotionGenerated = randomItemDropChance.Next(1, 4);
            randomPotionStrengthGenerated = randomItemDropChance.Next(1, 101);

            int minimum = 0;
            int lowEquipChance = minimum + WoodenEquipmentDropChance;
            int mediumEquipChance = lowEquipChance + StoneEquipmentDropChance;
            int highEquipChance = mediumEquipChance + ironEquipmentDropChance;

            int potionStrength = 0;

            if (randomPotionStrengthGenerated > minimum && randomPotionStrengthGenerated < lowEquipChance)
            {
                potionStrength = 1;
            }
            else if (randomPotionStrengthGenerated >= lowEquipChance && randomPotionStrengthGenerated < mediumEquipChance)
            {
                potionStrength = 2;
            }
            else if (randomPotionStrengthGenerated >= mediumEquipChance && randomPotionStrengthGenerated < highEquipChance)
            {
                potionStrength = 3;
            }

            itemTempItem = new PotionItem(randomPotionGenerated, potionStrength);

        }   
    }
}
