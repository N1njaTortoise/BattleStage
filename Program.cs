using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleStage.Characters;
using BattleStage.Enums;
using BattleStage.MenuInput;
using BattleStage.Characters.Scourge;
using BattleStage.Equipment;

namespace BattleStage
{
    class Program
    {
        static void Main(string[] args)
        {
            HeroClassTypes heroClassTypes;
            EnemyClassType enemyClassType;

            StateManager stateManager = new StateManager();
            ItemManager itemManager = new ItemManager();

            string userInput;
            string userName;

            int playerCombatSelecter;
            int enemyCombatSelecter;

            /*NEXT ITEM
             * -------------> 
             * Have hero select screne
             * */

            do
            {
                MenuQueries.MainMenuStart();

                userInput = MenuQueries.HeroSelectionDisplay();

                MenuQueries.ConsoleClearResetMenu();

                heroClassTypes = CharacterCreation.ConvertUserHeroTypeToEnum(userInput);
                userName = CharacterCreation.HeroName();

                Hero playerHero = new Hero(heroClassTypes, userName);

                // loop for level
                while (playerHero.IsAlive)
                {
                    MenuQueries.ConsoleClearResetMenu();

                    enemyClassType = CharacterCreation.GenerateEnemyType(stateManager.GenerateEnemyBasedOnCurrentGameLevel());
                    Enemy enemy = new Enemy(enemyClassType);

                    MenuQueries.BattleDisplayPage(heroClassTypes, playerHero, enemy, enemyClassType, true);

                    // loop for alive
                    while (enemy.IsAlive && playerHero.IsAlive)
                    {
                        Console.WriteLine($"level is {stateManager.GAMELEVEL}");
                        playerCombatSelecter = MenuQueries.PlayerCombactSelection();
                        enemyCombatSelecter = stateManager.EnemyCombatSelecter();

                        stateManager.Fighting(heroClassTypes, enemyClassType, stateManager, playerCombatSelecter, enemyCombatSelecter, playerHero, enemy);

                        stateManager.SetGameLevel(enemy.IsAlive, playerHero.IsAlive);
                        playerHero.EquipItem(itemManager, enemy.IsAlive);
                        playerHero.PlayerLevelManager(enemy, enemyClassType, heroClassTypes, stateManager);

                        MenuQueries.ConsoleClearResetMenu();
                        MenuQueries.BattleDisplayPage(heroClassTypes, playerHero, enemy, enemyClassType, false);
                    }
                }
            } while (stateManager.PlayAgain());
        }

        
    }
}
