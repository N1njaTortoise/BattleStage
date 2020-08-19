using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using BattleStage.Enums;
using BattleStage.Characters;
using BattleStage.Characters.Scourge;

namespace BattleStage.MenuInput
{
    static class Animation
    {
        public static void CharacterDisplay(HeroClassTypes heroClass, EnemyClassType enemyClass)
        {
            AnimationsData animationsData = new AnimationsData();
            int playerIndex;
            int enemyIndex;
            string display;

            playerIndex = ReturnHeroAnimationListNumber(heroClass);
            enemyIndex = ReturnEnemyAnimationListNumber(enemyClass);

            display = animationsData.DisplayCharacter(playerIndex, enemyIndex);
            Console.WriteLine(display);
        }

        private static int ReturnHeroAnimationListNumber(HeroClassTypes heroClass)
        {
            switch (heroClass)
            {
                case HeroClassTypes.spearman:
                    return 0;
                case HeroClassTypes.swordsman:
                    return 1;
                case HeroClassTypes.ranger:
                    return 2;
                default:
                    return 0;
            }
        }
        private static int ReturnEnemyAnimationListNumber(EnemyClassType enemyClass)
        {
            switch (enemyClass)
            {
                case EnemyClassType.minion:
                    return 0;
                case EnemyClassType.creeper:
                    return 1;
                case EnemyClassType.skeleton:
                    return 2;
                case EnemyClassType.orc:
                    return 3;
                default:
                    return 0;
            }
        }
        private static int ReturnAnimationIndexNumber(int playerCombat, int enemyCombat)
        {
            if (playerCombat == 1 && enemyCombat == 1)
            {
                return 0;
            }
            else if (playerCombat == 1 && enemyCombat == 2)
            {
                return 1;
            }
            else if (playerCombat == 2 && enemyCombat == 1)
            {
                return 2;
            }
            else if (playerCombat == 2 && enemyCombat == 2)
            {
                return 3;
            }
            else
            {
                return 0;
            }
        }

        private static string[] ReturnAnimationArray(int heroAnimationList, int enemyAnimationList, int animationClipIndex)
        {
            string[] temp;
            List<string[]> tempList = new List<string[]>();
            AnimationsData animations = new AnimationsData();
            if (heroAnimationList == 0)
            {
                tempList = animations.SpearmanAnimations(enemyAnimationList);
                temp = tempList[animationClipIndex];
                return temp;
            }
            else if (heroAnimationList == 1)
            {
                tempList = animations.SwordsmanAnimations(enemyAnimationList);
                temp = tempList[animationClipIndex];
                return temp;
            }
            else if (heroAnimationList == 2)
            {
                tempList = animations.RangerAnimations(enemyAnimationList);
                temp = tempList[animationClipIndex];
                return temp;
            }
            else
            {
                return new string[] { "no", "string"};
            }
        }

        public static void AnimationBattle(HeroClassTypes heroClass, EnemyClassType enemyClass, int playerCombatSelecter, int enemyCombatSelecter, Hero hero, Enemy enemy, bool homePage)
        {
            MenuQueries.ConsoleClearResetMenu();

            int heroAnimationListNumber;
            int enemyAnimationListNumber;
            int animationIndex;

            heroAnimationListNumber = ReturnHeroAnimationListNumber(heroClass);
            enemyAnimationListNumber = ReturnEnemyAnimationListNumber(enemyClass);

            animationIndex = ReturnAnimationIndexNumber(playerCombatSelecter, enemyCombatSelecter);

            AnimationPlay(ReturnAnimationArray(heroAnimationListNumber, enemyAnimationListNumber, animationIndex), heroClass, enemyClass, hero, enemy, homePage);
        }

        private static void AnimationPlay(string[] animationClip, HeroClassTypes heroClass, EnemyClassType enemyClass, Hero hero, Enemy enemy, bool homePage)
        {
            int delayBetweenAnimationCycles = 250;

            for (int i = 0; i < animationClip.Length; i++)
            {
                MenuQueries.CharacterInformationSheet(heroClass, hero, enemy, enemyClass);
                Utilities.ColorWriteLines(animationClip[i], ConsoleColor.Gray);
                MenuQueries.CharacterInformationBattleSheet(hero, enemy, homePage);
                Thread.Sleep(delayBetweenAnimationCycles);
                MenuQueries.ConsoleClearResetMenu();
            }

            for (int i = animationClip.Length - 1; i >= 0; i--)
            {
                MenuQueries.CharacterInformationSheet(heroClass, hero, enemy, enemyClass);
                Utilities.ColorWriteLines(animationClip[i], ConsoleColor.Gray);
                MenuQueries.CharacterInformationBattleSheet(hero, enemy, homePage);
                Thread.Sleep(delayBetweenAnimationCycles);

                if (i != 0)
                {
                    MenuQueries.ConsoleClearResetMenu();

                }
            }
        }

        public static void AnimateSmallText(string textToAnimate)
        {
            char[] textToCharArray = textToAnimate.ToCharArray();
            int timeBetweenCharacters = 100;

            for (int i = 0; i < textToCharArray.Length; i++)
            {
                Console.Write(textToCharArray[i]);
                Thread.Sleep(timeBetweenCharacters);
            }
        }










    }
}
