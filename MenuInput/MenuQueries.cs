using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BattleStage.Enums;
using BattleStage.Characters;
using BattleStage.Characters.Scourge;
using BattleStage.Equipment;

namespace BattleStage.MenuInput
{
    static class MenuQueries
    {
        const string applicationTitle = "BattleStage";
        const string SubHeading = @"
                                       ******************************
                                       ******************************
                                       **                          **
                                       **       BATTLESTAGE        **
                                       **                          **
                                       ******************************
                                       ******************************";
        const string actionDisplay = @"
                                       ******************************
                                       ******************************
                                       **                          **
                                       **       1 - Attack         **
                                       **       2 - Defend         **
                                       **       3 - Item           **
                                       **                          **
                                       ******************************
                                       ******************************";
        const string GameOver = @"
                                       ******************************
                                       ******************************
                                       **                          **
                                       **         GAME OVER        **
                                       **                          **
                                       ******************************
                                       ******************************";

        const string spearmanDisplay = @"
          _____  
         |     |   /\
         |__ __|  /__\ 
            |      | 
           /|\     | 
          / | \____| 
         /  |      |
           / \     | 
          |   |    | 
          |   |    |
";
        const string swordmanDisplay = @"
          _____    /\
         |     |   ||
      __ |__ __|   ||
     /  \   |      || 
    /    \ /|\    _||_ 
   |     |/ | \____|| 
   |     |  |      ||
    \    / / \      
     \__/ |   |    
          |   |    
";
        const string rangerDisplay = @"
          _____   
         |     ||\ 
         |__ __|| \
            |   |  |
           /|\  |  |
          / | \_|__| 
         /  |   |  |
           / \  |  | 
          |   | | / 
          |   | |/  
";

        public static string[] classTypeArray = { spearmanDisplay, swordmanDisplay, rangerDisplay };

        const int windowWidth = 110;

        public static void MainMenuStart()
        {
            ApplicationTitle();
            MainMenuHeading();
            Console.CursorVisible = false;
            Console.ReadKey(true);
            Console.Clear();
            Console.CursorVisible = true;
        }

        public static void ApplicationTitle()
        {
            Console.Title = applicationTitle;
            Console.WindowWidth = 110;

            Console.BufferWidth = 110;
            Console.WindowHeight = 50;
            Console.BufferHeight = 50;
        }

        public static void MainMenuHeading()
        {
            Console.WriteLine(@"
             _______            __           _____________    _____        _____     __________  
            |   __   \        /    \        |             |   |    |       |   |     |         |
            |  |  |  |       /  /\  \       |____     ____|   |    |       |   |     |   ______|
            |  |__|  |      /  /__\  \           |   |        |    |       |   |     |   |__  
            |   __  <      /   ____   \          |   |        |    |       |   |     |    __|
            |  |  |  |    /  /      \  \         |   |        |    |____   |   |___  |   |_____  
            |  |__|  |   /  /        \  \        |   |        |         |  |       | |         |
            |_______/   /__/          \__\       |___|        |_________|  |_______| |_________|
            
                           _____      _____________          __             ________      __________  
                         /  __  \    |             |       /    \          /  ____  \    |         |
                        /  /  \__\   |____     ____|      /  /\  \        |  /    \__|   |   ______|
                        \  \____          |   |          /  /__\  \       |  |           |   |__  
                         \____  \         |   |         /   ____   \      |  |   ____    |    __|
                        ___   \  \        |   |        /  /      \  \     |  |  |__  |   |   |_____  
                        \  \__/  /        |   |       /  /        \  \    \   \___/  |   |         |
                         \______/         |___|      /__/          \__\    \ ________/   |_________|


            How long can you survive the onslaught....

            Ready to start your adventure?

            Press any key to continue....");
        }

        public static string HeroSelectionDisplay()
        {
            MenuSubMenuClass();

            int indexDisplay = 0;

            while (true)
            {
                switch (indexDisplay)
                {
                    case 0:
                        Utilities.FadeText(classTypeArray[indexDisplay], true);
                        //Console.Write(classTypeArray[indexDisplay]);
                        GettingStats(HeroClassTypes.spearman);
                        break;
                    case 1:
                        Utilities.FadeText(classTypeArray[indexDisplay], true);
                        GettingStats(HeroClassTypes.swordsman);
                        break;
                    case 2:
                        Utilities.FadeText(classTypeArray[indexDisplay], true);
                        GettingStats(HeroClassTypes.ranger);
                        break;
                    default:
                        break;
                }

                Console.WriteLine("\nUse left and right arrow keys to scroll the class types.");
                Console.WriteLine("Press Enter for your selection.");

                ConsoleKey consoleKey;
                consoleKey = Console.ReadKey().Key;

                if (consoleKey == ConsoleKey.RightArrow)
                {
                    Utilities.FadeText(classTypeArray[indexDisplay], false);

                    if (indexDisplay == classTypeArray.Length - 1)
                    {
                        indexDisplay = 0;
                    }
                    else
                    {
                        indexDisplay++;
                    }
                }
                else if (consoleKey == ConsoleKey.LeftArrow)
                {
                    Utilities.FadeText(classTypeArray[indexDisplay], false);

                    if (indexDisplay == 0)
                    {
                        indexDisplay = classTypeArray.Length - 1;
                    }
                    else
                    {
                        indexDisplay--;
                    }
                }
                else if (consoleKey == ConsoleKey.Enter)
                {
                    return UserSelectedClass(indexDisplay);
                }
            }
        }


        public static void MenuSubMenu()
        {
            Console.WriteLine($"{SubHeading}");
            Console.WriteLine(new string('-', Console.WindowWidth - 1));

        }

        public static void MenuSubMenuClass()
        {
            MenuSubMenu();

            string heading = "Choose your class brave warrior!";
            Console.WriteLine($"{heading,windowWidth / 2}");
        }

        public static int PlayerCombactSelection()
        {
            //Console.WriteLine(new string('-', 25));
            //Console.WriteLine("1 - Attack");
            //Console.WriteLine("2 - Defend");
            //Console.WriteLine("3 - Item");
            //Console.WriteLine(new string('-', 25));

            Console.WriteLine($"{actionDisplay}");


            return Convert.ToInt32(Input.InputStringOfIntegers("What would you like to do: "));
        }
        public static string GameOverDisplay()
        {
            Console.WriteLine($"{GameOver}");

            return Input.InputStringForYesNoStatements("Would you like to play again? (y/n)").ToUpper();
        }

        public static void GettingStats(HeroClassTypes heroClass)
        {
            switch (heroClass)
            {
                case HeroClassTypes.spearman:
                    Spearman spearman = new Spearman("Spearman", Alignment.good);
                    Console.WriteLine($"Class Type : {spearman.Name}");
                    Console.WriteLine($"Health : {spearman.Health}");
                    Console.WriteLine($"Strength : {spearman.Strength}");
                    Console.WriteLine($"Dexterity : {spearman.Dexterity}");
                    Console.WriteLine($"Defence : {spearman.Defence}");
                    break;
                case HeroClassTypes.swordsman:
                    Swordsman swordsman = new Swordsman("Swordsman", Alignment.good);
                    Console.WriteLine($"Class Type : {swordsman.Name}");
                    Console.WriteLine($"Health : {swordsman.Health}");
                    Console.WriteLine($"Strength : {swordsman.Strength}");
                    Console.WriteLine($"Dexterity : {swordsman.Dexterity}");
                    Console.WriteLine($"Defence : {swordsman.Defence}");
                    break;
                case HeroClassTypes.ranger:
                    Ranger ranger = new Ranger("Ranger", Alignment.good);
                    Console.WriteLine($"Class Type : {ranger.Name}");
                    Console.WriteLine($"Health : {ranger.Health}");
                    Console.WriteLine($"Strength : {ranger.Strength}");
                    Console.WriteLine($"Dexterity : {ranger.Dexterity}");
                    Console.WriteLine($"Defence : {ranger.Defence}");
                    break;
                default:
                    break;
            }
        }

        public static string UserSelectedClass(int indexDisplay)
        {
            switch (indexDisplay)
            {
                case 0:
                    return "1";
                case 1:
                    return "2";
                case 2:
                    return "3";
                default:
                    return "1";
            }
        }

        public static void ConsoleClearResetMenu()
        {
            Console.Clear();
            MenuSubMenu();
        }

        public static void BattleDisplayPage(HeroClassTypes heroClass, Hero hero, Enemy enemy, EnemyClassType enemyClass, bool homePage)
        {
            CharacterInformationSheet(heroClass, hero, enemy, enemyClass);
            Animation.CharacterDisplay(heroClass, enemyClass);
            CharacterInformationBattleSheet(hero, enemy, homePage);
        }
        public static void BattleDisplayPage(HeroClassTypes heroClass, Hero hero, Enemy enemy, EnemyClassType enemyClass, bool homePage, int playerCombatSelecter, int enemyCombatSelecter)
        {
            Animation.AnimationBattle(heroClass, enemyClass, playerCombatSelecter, enemyCombatSelecter, hero, enemy, homePage);
        }


        public static void CharacterInformationSheet(HeroClassTypes heroClass, Hero hero, Enemy enemy, EnemyClassType enemyClass)
        {
            string health = "Health";
            string weapons = "Weapon";
            string armour = "Armour";
            string item = "Item";
            string spacer = "--";
            char lineSpacer = '-';
            string blank = " ";

            Console.WriteLine(new string(lineSpacer, Console.WindowWidth - 1));
            Console.WriteLine($"{spacer} {CharacterInformationPlayerNameSheet(hero, heroClass),-50}{spacer} {CharacterInformationEnemyNameSheet(enemy, enemyClass),-50} {spacer}");
            Console.WriteLine(new string(lineSpacer, Console.WindowWidth - 1));

            Console.WriteLine(string.Format($"{spacer} {health,-10} : {CharacterInformationPlayerHealthSheet(hero, heroClass),-37}{spacer} {health,-10} : {CharacterInformationEnemyHealthSheet(enemy, enemyClass),-37} {spacer}"));
            Console.WriteLine(string.Format($"{spacer} {weapons,-10} : {hero.Weapon.Name,-37}{spacer} {weapons,-10} : {blank,-37} {spacer}"));
            Console.WriteLine(string.Format($"{spacer} {armour,-10} : {hero.Armor.Name,-37}{spacer} {armour,-10} : {blank,-37} {spacer}"));
            Console.WriteLine(string.Format($"{spacer} {item,-10} : {CharacterInformationEnemyPotionTypeheet(hero),-37}{spacer} {item,-10} : {blank,-37} {spacer}"));

            Console.WriteLine(new string(lineSpacer, Console.WindowWidth - 1));
            Console.WriteLine(new string(lineSpacer, Console.WindowWidth - 1));
        }
        private static string CharacterInformationPlayerNameSheet(Hero hero, HeroClassTypes heroClass)
        {
            switch (heroClass)
            {
                case HeroClassTypes.spearman:
                    return hero.heroSpear.Name.ToUpper();
                case HeroClassTypes.swordsman:
                    return hero.heroSword.Name.ToUpper();
                case HeroClassTypes.ranger:
                    return hero.heroRanger.Name.ToUpper();
                default:
                    return "No Name Available";
            }
        }
        private static string CharacterInformationEnemyNameSheet(Enemy enemy, EnemyClassType enemyClass)
        {
            switch (enemyClass)
            {
                case EnemyClassType.minion:
                    return enemy.minionType.Name.ToUpper();
                case EnemyClassType.creeper:
                    return enemy.creeperType.Name.ToUpper();
                case EnemyClassType.skeleton:
                    return enemy.skeletontype.Name.ToUpper();
                case EnemyClassType.orc:
                    return enemy.orcType.Name.ToUpper();
                default:
                    return "No Name Available";
            }
        }
        private static string CharacterInformationPlayerHealthSheet(Hero hero, HeroClassTypes heroClass)
        {
            switch (heroClass)
            {
                case HeroClassTypes.spearman:
                    return hero.heroSpear.Health.ToString();
                case HeroClassTypes.swordsman:
                    return hero.heroSword.Health.ToString();
                case HeroClassTypes.ranger:
                    return hero.heroRanger.Health.ToString();
                default:
                    return "No Health Available";
            }
        }
        private static string CharacterInformationEnemyHealthSheet(Enemy enemy, EnemyClassType enemyClass)
        {
            switch (enemyClass)
            {
                case EnemyClassType.minion:
                    return enemy.minionType.Health.ToString();
                case EnemyClassType.creeper:
                    return enemy.creeperType.Health.ToString();
                case EnemyClassType.skeleton:
                    return enemy.skeletontype.Health.ToString();
                case EnemyClassType.orc:
                    return enemy.orcType.Health.ToString();
                default:
                    return "No Health Available";
            }
        }
        private static string CharacterInformationEnemyPotionTypeheet(Hero hero)
        {
            if (hero.UsableItem == true)
            {
                switch (hero.Potion.PotionTypes)
                {
                    case PotionTypes.Health:
                        return hero.Potion.ITEM_NAME + " (+" + hero.Potion.ITEM_PROPERTIES.ToString() + "Health)";
                    case PotionTypes.Defence:
                        return hero.Potion.ITEM_NAME + " (+" + hero.Potion.ITEM_PROPERTIES.ToString() + "Defence Points)";
                    case PotionTypes.Attack:
                        return hero.Potion.ITEM_NAME + " (+" + hero.Potion.ITEM_PROPERTIES.ToString() + "Attack Damage)";
                    default:
                        return "Need a potion";
                }
            }
            else
            {
                return hero.Potion.ITEM_NAME;
            }
        }
        public static void CharacterInformationBattleSheet(Hero player, Enemy enemy, bool homePage)
        {
            bool attacking = player.ISAttacking;
            bool missedAttack = player.ISMissing;
            bool enemyAttacking = enemy.ISAttacking;
            bool enemyMissedAttack = enemy.ISMissing;

            string heroDamageDealt = player.DamageDealt.ToString();
            string enemyDamageDealt = enemy.DamageDealt.ToString();
            char lineSpacer = '-';
            string spacer = "--";

            if (homePage == true)
            {
                Console.WriteLine(new string(lineSpacer, Console.WindowWidth - 1));
                Console.WriteLine(new string(lineSpacer, Console.WindowWidth - 1));
                Console.WriteLine(string.Format($"{spacer} {" ",-50}{spacer}  {" ",-49} {spacer}"));
                Console.WriteLine(string.Format($"{spacer} {" ",-50}{spacer}  {" ",-49} {spacer}"));
                Console.WriteLine(new string(lineSpacer, Console.WindowWidth - 1));
                Console.WriteLine(new string(lineSpacer, Console.WindowWidth - 1));
            }
            else
            {
                Console.WriteLine(new string(lineSpacer, Console.WindowWidth - 1));
                Console.WriteLine(new string(lineSpacer, Console.WindowWidth - 1));
                Console.WriteLine(string.Format($"{spacer} {CharacterInformationBattleSheetReturnAttackStatus(missedAttack, attacking),-50}{spacer}  {CharacterInformationHelperReturnEnemyAttackStatus(enemyMissedAttack, enemyAttacking),-49} {spacer}"));
                Console.WriteLine(string.Format($"{spacer} You deal {heroDamageDealt} {"Damage!",-39}{spacer}  Enemy deals {enemyDamageDealt} { "Damage!",-34} {spacer}"));
                Console.WriteLine(new string(lineSpacer, Console.WindowWidth - 1));
                Console.WriteLine(new string(lineSpacer, Console.WindowWidth - 1));
            }
        }

        public static void CharacterLevelUp(StateManager stateManager)
        {
            string spacer = "|";
            string level = "Level";
            string health = "Health";
            string strength = "Strength";
            string dexterity = "Dexterity";

            string levelOld = stateManager.PLAYERLEVELOLD.ToString();
            string levelNew = stateManager.PLAYERLEVELNEW.ToString();
            string healthOld = stateManager.HEALTHOLD.ToString();
            string healthNew = stateManager.HEALTHNEW.ToString();
            string strengthOld = stateManager.STRENGHTOLD.ToString();
            string strengthNew = stateManager.STRENGHTNEW.ToString();
            string dexterityOld = stateManager.DEXTERITYOLD.ToString();
            string dexterityNew = stateManager.DEXTERITYNEW.ToString();
            string arrows = "-------->";

            // Commented WriteLine shows format string without animated arrows!

            Console.Clear();
            Console.WriteLine($"{ SubHeading}");
            Console.WriteLine("\n\n\n\n\n\n\n\n\n");
            Console.WriteLine($"\t\t         {spacer} ****************************************************** {spacer}");
            Console.WriteLine($"\t\t         {spacer}                        Level Up!                       {spacer}");
            Console.WriteLine($"\t\t         {spacer} ------------------------------------------------------ {spacer}");

            //Console.WriteLine($"\t\t         {spacer} {level, -13} {levelOld, -6} {Animation.AnimateSmallText(arrows), 11}    {levelNew, -18} {spacer}");
            Console.Write($"\t\t         {spacer} {level,-13} {levelOld,-6}   ");
            Animation.AnimateSmallText(arrows);
            Console.WriteLine($"    {levelNew,-18} {spacer}");

            //Console.WriteLine($"\t\t         {spacer} {health,-13} {healthOld,-6} {arrows,11}    {healthNew, -18} {spacer}");
            Console.Write($"\t\t         {spacer} {health,-13} {healthOld,-6}   ");
            Animation.AnimateSmallText(arrows);
            Console.WriteLine($"    {healthNew,-18} {spacer}");

            //Console.WriteLine($"\t\t         {spacer} {strength,-13} {strengthOld,-6} {arrows,11}    {strengthNew, -18} {spacer}");
            Console.Write($"\t\t         {spacer} {strength,-13} {strengthOld,-6}   ");
            Animation.AnimateSmallText(arrows);
            Console.WriteLine($"    {strengthNew,-18} {spacer}");
         
            //Console.WriteLine($"\t\t         {spacer} {dexterity,-13} {dexterityOld,-6} {arrows,11}    {dexterityNew, -18} {spacer}");
            Console.Write($"\t\t         {spacer} {dexterity,-13} {dexterityOld,-6}   ");
            Animation.AnimateSmallText(arrows);
            Console.WriteLine($"    {dexterityNew,-18} {spacer}");

            Console.WriteLine($"\t\t         {spacer} ****************************************************** {spacer}");


        }
        //public static void CharacterInformationBattleSheet(Hero player, Enemy enemy)
        //{
        //    bool attacking = player.ISAttacking;
        //    bool missedAttack = player.ISMissing;
        //    bool enemyAttacking = enemy.ISAttacking;
        //    bool enemyMissedAttack = enemy.ISMissing;

        //    string heroDamageDealt = player.DamageDealt.ToString();
        //    string enemyDamageDealt = enemy.DamageDealt.ToString();
        //    string spacer = "**";

        //    Console.WriteLine(new string('*', Console.WindowWidth - 1));
        //    Console.WriteLine(new string('*', Console.WindowWidth - 1));
        //    Console.WriteLine(string.Format($"** {CharacterInformationBattleSheetReturnAttackStatus(missedAttack, attacking),-50}{spacer}  {CharacterInformationHelperReturnEnemyAttackStatus(enemyMissedAttack, enemyAttacking),-49} {spacer}"));
        //    Console.WriteLine(string.Format($"** You deal {heroDamageDealt} {"Damage!",-39}{spacer}  Enemy deals {enemyDamageDealt} { "Damage!",-34} {spacer}"));
        //    Console.WriteLine(new string('*', Console.WindowWidth - 1));
        //    Console.WriteLine(new string('*', Console.WindowWidth - 1));
        //}

        private static string CharacterInformationBattleSheetReturnAttackStatus(bool missedAttack, bool attacking)
        {
            if (attacking == true)
            {
                if (missedAttack == true)
                {
                    return "You Missed!";
                }
                else if (missedAttack == false)
                {
                    return "You Hit!";
                }
                else
                {
                    return "No valid Attack Status Type";
                }
            }
            else
            {
                return "You Defend!";
            }
        }
        private static string CharacterInformationHelperReturnEnemyAttackStatus(bool enemyMissed, bool enemyAttack)
        {
            if (enemyAttack == true)
            {
                if (enemyMissed == true)
                {
                    return "Enemy Missed!";
                }
                else if (enemyMissed == false)
                {
                    return "Enemy Hit!";
                }
                else
                {
                    return "No valid Attack Status Type";
                }
            }
            else
            {
                return "Enemy Defend!";
            }
        }

        public static string ItemDropped(ItemManager item, HeroClassTypes heroClass)
        {
            string spacer = "|";
            string itemName = "Item";
            string itemDescription = "Item Description";
            string itemProperties = "Properties";
            string input;

            switch (item.ITEMTYPEDROPPED)
            {
                case ItemType.Weapon:
                    itemProperties = "Damage";
                    break;
                case ItemType.Armour:
                    itemProperties = "Defence";
                    break;
                case ItemType.Item:
                    itemProperties = "Properties";
                    break;
                default:
                    break;
            }


            Console.Clear();
            Console.WriteLine($"{ SubHeading}");
            Console.WriteLine("\n\n\n\n\n\n\n\n\n");
            Console.WriteLine($"\t\t         {spacer} ****************************************************** {spacer}");
            Console.WriteLine($"\t\t         {spacer}                      Item Dropped!                     {spacer}");
            Console.WriteLine($"\t\t         {spacer} ------------------------------------------------------ {spacer}");
            Console.WriteLine($"\t\t         {spacer} {itemName, -16} : {ItemDroppedHelperItemTypeName(item, heroClass), -17}                   {spacer}");
            Console.WriteLine($"\t\t         {spacer} {itemDescription, -16} : {ItemDroppedHelperItemTypeDescription(item, heroClass),-36}{spacer}");
            Console.WriteLine($"\t\t         {spacer} {itemProperties, -16} : {ItemDroppedHelperItemTypeProperties(item, heroClass),-24}            {spacer}");
            Console.WriteLine($"\t\t         {spacer} ****************************************************** {spacer}");
            Console.WriteLine();
            input = Input.InputStringForYesNoStatements("Would you like to equip the item?");
            Console.WriteLine($"\n\t\t         {spacer} ****************************************************** {spacer}");

            return input;
            // like to equip?

        }

        private static string ItemDroppedHelperItemTypeName(ItemManager item, HeroClassTypes heroClass)
        {
            switch (item.ITEMTYPEDROPPED)
            {
                case ItemType.Weapon:
                    return item.WEAPONDROPPED.Name;
                case ItemType.Armour:
                    return item.ARMOR_DROPPED.Name;
                case ItemType.Item:
                    return item.POTION_DROPPED.ITEM_NAME;
                default:
                    return "You need a basic weapon!";
            }
        }
        private static string ItemDroppedHelperItemTypeDescription(ItemManager item, HeroClassTypes heroClass)
        {
            switch (item.ITEMTYPEDROPPED)
            {
                case ItemType.Weapon:
                    return item.WEAPONDROPPED.WeaponDescription;
                case ItemType.Armour:
                    return item.ARMOR_DROPPED.ArmourDescription;
                case ItemType.Item:
                    return item.POTION_DROPPED.ITEM_DESCRIPTION;
                default:
                    return "You need a basic weapon!";
            }
        }
        private static string ItemDroppedHelperItemTypeProperties(ItemManager item, HeroClassTypes heroClass)
        {
            switch (item.ITEMTYPEDROPPED)
            {
                case ItemType.Weapon:
                    return item.WEAPONDROPPED.Damage.ToString();
                case ItemType.Armour:
                    return item.ARMOR_DROPPED.Defence.ToString();
                case ItemType.Item:
                    if (item.POTION_DROPPED.PotionTypes == PotionTypes.Health )
                    {
                        return "+" + item.POTION_DROPPED.ITEM_PROPERTIES.ToString() + " Health";
                    }
                    else if (item.POTION_DROPPED.PotionTypes == PotionTypes.Defence)
                    {
                        return "+" + item.POTION_DROPPED.ITEM_PROPERTIES.ToString() + " Defence Points";
                    }
                    else if (item.POTION_DROPPED.PotionTypes == PotionTypes.Attack)
                    {
                        return "+" + item.POTION_DROPPED.ITEM_PROPERTIES.ToString() + " Attack Damage";
                    }
                    else
                    {
                        return "You need a basic weapon!";
                    }
                default:
                    return "You need a basic weapon!";
            }
        }

    }
}
