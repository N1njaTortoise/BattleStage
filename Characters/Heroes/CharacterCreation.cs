using BattleStage.MenuInput;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleStage.Enums;

namespace BattleStage.Characters
{
    static class CharacterCreation
    {
        public static readonly string[] heroClassTypes = { "Spearman", "Swordsman", "Ranger" };

        public static string HeroSelectMenu()
        {
            Console.WriteLine("Select your class brave warrior!");
            for (int i = 1; i <= heroClassTypes.Length; i++)
            {
                Console.WriteLine($"{i} - {heroClassTypes[i - 1]}");
            }
            Console.WriteLine();

            return Input.InputStringOfIntegers("Choose your class");
        }

        public static string HeroName()
        {
            Console.WriteLine("A brave hero now walks the road....maybe....");

            return Input.InputStringName("What is your name");
        }

        public static HeroClassTypes ConvertUserHeroTypeToEnum(string userInputForHeroClass)
        {
            switch (userInputForHeroClass)
            {
                case "1":
                    return HeroClassTypes.spearman;
                case "2":
                    return HeroClassTypes.swordsman;
                case "3":
                    return HeroClassTypes.ranger;
                default:
                    return HeroClassTypes.spearman;
            }
        }

        public static EnemyClassType GenerateEnemyType()
        {
            Random random = new Random(9);

            // Maximum number of enemey types
            int randomNumber = random.Next(1, 5);

            switch (randomNumber)
            {
                case 1:
                    return EnemyClassType.minion;
                case 2:
                    return EnemyClassType.creeper;
                case 3:
                    return EnemyClassType.skeleton;
                case 4:
                    return EnemyClassType.orc;
                default:
                    return EnemyClassType.minion;
            }
        }

        
    }
}
