using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BattleStage.Enums;
using BattleStage.Characters;

namespace BattleStage.MenuInput
{
    static class OptionQueries
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

        public static string[] classTypeArray = {spearmanDisplay, swordmanDisplay, rangerDisplay};

        public static readonly string[] heroClassTypes = { "Spearman", "Swordsman", "Ranger", "Mage" };

        const int windowWidth = 110;

        public static void MainMenuStart()
        {
            ApplicationTitle();
            MainMenuHeading();
            Console.CursorVisible = false;
            Console.ReadKey(true);
            Console.Clear();
            Console.CursorVisible = true;

            //MenuSubMenu();
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
            MenuSubMenu();

            //Console.Write(spearmanDisplay);
            //Console.Write(swordmanDisplay);
            //Console.Write(rangerDisplay);

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
                else if(consoleKey == ConsoleKey.Enter)
                {
                    return UserSelectedClass(indexDisplay);
                }
            }
        }


        public static void MenuSubMenu()
        {
            Console.WriteLine($"{SubHeading}");
            Console.WriteLine(new string('*', windowWidth));

        }

        public static int PlayerCombactSelection()
        {
            Console.WriteLine(new string('-', 25));
            Console.WriteLine("1 - Attack");
            Console.WriteLine("2 - Defend");
            Console.WriteLine("3 - Item");
            Console.WriteLine(new string('-', 25));
            
            return Convert.ToInt32(Input.InputStringOfIntegers("What would you like to do: "));
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


    }
}
