using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleStage.Characters;
using BattleStage.Enums;
using BattleStage.MenuInput;
using BattleStage.Characters.Scourge;

namespace BattleStage
{
    class Program
    {
        static void Main(string[] args)
        {
            HeroClassTypes heroClassTypes;
            EnemyClassType enemyClassType;

            string userInput;
            string userName;

            int playerCombatSelecter;
            int enemyCombatSelecter;

            /*Have hero select screne
             * Neaten up text and layout
             * Create Item usage
             * generate level - number of enemies per level - every 10 levels have boss
             * experience gain
             * win lose
             * next level or game over
             * */
            OptionQueries.MainMenuStart();

            userInput = OptionQueries.HeroSelectionDisplay();

            Console.Clear();
            OptionQueries.MenuSubMenu();

            //userInput = CharacterCreation.HeroSelectMenu();
            heroClassTypes = CharacterCreation.ConvertUserHeroTypeToEnum(userInput);
            userName = CharacterCreation.HeroName();

            Hero playerHero = new Hero(heroClassTypes, userName);

            // while loop for level
            while (true)
            {
                enemyClassType = CharacterCreation.GenerateEnemyType();
                Enemy enemy = new Enemy(enemyClassType);
                
                // while loop for enemy alive
                while (enemy.IsAlive)
                {

                    playerCombatSelecter = OptionQueries.PlayerCombactSelection();
                    enemyCombatSelecter = enemy.EnemyCombatSelecter();

                    Console.WriteLine($"Enemy health: {enemy.GettingHealth(enemyClassType)}");
                    Console.WriteLine($"Player Health: {playerHero.GettingHealth(heroClassTypes)}");
                    Console.WriteLine();

                    if (playerCombatSelecter == 1)
                    {
                        if (enemyCombatSelecter == 1)
                        {
                            playerHero.AttackEnemy(heroClassTypes, enemy, enemyClassType);
                            enemy.AttackPlayer(heroClassTypes, playerHero, enemyClassType);
                        }
                        else if (enemyCombatSelecter == 2)
                        {
                            enemy.EnemyDefend(enemyClassType, true);
                            playerHero.AttackEnemy(heroClassTypes, enemy, enemyClassType);
                            enemy.EnemyDefend(enemyClassType, false);
                        }

                    }
                    else if (playerCombatSelecter == 2)
                    {
                        if (enemyCombatSelecter == 1)
                        {
                            playerHero.PlayerDefend(heroClassTypes, true);
                            enemy.AttackPlayer(heroClassTypes, playerHero, enemyClassType);
                            playerHero.PlayerDefend(heroClassTypes, false);
                        }
                        else if (enemyCombatSelecter == 2)
                        {
                            playerHero.PlayerDefend(heroClassTypes, true);
                            enemy.EnemyDefend(enemyClassType, true);
                            playerHero.PlayerDefend(heroClassTypes, false);
                            enemy.EnemyDefend(enemyClassType, false);
                        }

                    }



                    Console.WriteLine();
                    Console.WriteLine($"Enemy health: {enemy.GettingHealth(enemyClassType)}");
                    Console.WriteLine($"Player Health: {playerHero.GettingHealth(heroClassTypes)}");

                }
            }

            
        }
    }
}
