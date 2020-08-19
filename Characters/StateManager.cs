using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleStage.Enums;
using BattleStage.Characters.Scourge;
using BattleStage.MenuInput;

namespace BattleStage.Characters
{
    class StateManager
    {
        private int gameLevel = 1;

        private int healthOld;
        private int healthNew;

        private int strengthOld;
        private int strengthNew;

        private int dexterityOld;
        private int dexterityNew;

        private int playerLevelOld;
        private int playerLevelNew;

        private bool playAgain = true;


        Random randomNumberForEnemyType = new Random();

        public int GAMELEVEL 
        { 
            get
            {
                return gameLevel;
            }
        }
        public int HEALTHOLD
        {
            get
            {
                return healthOld;
            }
            set
            {
                healthOld = value;
            }
        }
        public int HEALTHNEW
        {
            get
            {
                return healthNew;
            }
            set
            {
                healthNew = value;
            }
        }
        public int STRENGHTOLD
        {
            get
            {
                return strengthOld;
            }
            set
            {
                strengthOld = value;
            }
        }
        public int STRENGHTNEW
        {
            get
            {
                return strengthNew;
            }
            set
            {
                strengthNew = value;
            }
        }
        public int DEXTERITYOLD
        {
            get
            {
                return dexterityOld;
            }
            set
            {
                dexterityOld = value;
            }
        }
        public int DEXTERITYNEW
        {
            get
            {
                return dexterityNew;
            }
            set
            {
                dexterityNew = value;
            }
        }
        public int PLAYERLEVELOLD
        {
            get
            {
                return playerLevelOld;
            }
            set
            {
                playerLevelOld = value;
            }
        }
        public int PLAYERLEVELNEW
        {
            get
            {
                return playerLevelNew;
            }
            set
            {
                playerLevelNew = value;
            }
        }
        public bool PLAYAGAIN
        {
            get
            {
                return playAgain;
            }
            set
            {
                playAgain = value;
            }
        }


        public void SetGameLevel(bool enemyAlive, bool playerAlive)
        {
            if (enemyAlive == false)
            {
                gameLevel++;
            }
            else if (playerAlive == false)
            {
                gameLevel = 1;
            }
        }

        public int GenerateEnemyBasedOnCurrentGameLevel()
        {
            int generateNumber = randomNumberForEnemyType.Next(1, 101);

            if (gameLevel >= 1 && gameLevel < 10)
            {
                // 20% chance to generate creeper
                if (generateNumber >= 1 && generateNumber <= 80)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
            else if (gameLevel == 10)
            {
                // 1% chance to have skeleton
                if (generateNumber >= 1 && generateNumber <= 80)
                {
                    return 1;
                }
                else if (generateNumber > 80 && generateNumber <= 99)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
            else if (gameLevel >= 10 && gameLevel < 20)
            {
                // 60% creeper , 5 skeleton
                if (generateNumber >= 1 && generateNumber <= 40)
                {
                    return 1;
                }
                else if (generateNumber > 40 && generateNumber <= 95)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
            else if (gameLevel >= 20 && gameLevel < 30)
            {
                if (generateNumber >= 1 && generateNumber <= 20)
                {
                    return 1;
                }
                else if (generateNumber > 20 && generateNumber <= 50)
                {
                    return 2;
                }
                else if (generateNumber > 50 && generateNumber <= 95)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
            else
            {
                if (generateNumber >= 1 && generateNumber <= 10)
                {
                    return 1;
                }
                else if (generateNumber > 10 && generateNumber <= 20)
                {
                    return 2;
                }
                else if (generateNumber > 20 && generateNumber <= 40)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        public int EnemyCombatSelecter()
        {
            int enemyCombatChoice = randomNumberForEnemyType.Next(1, 3);

            return enemyCombatChoice;
        }

        public int AttackMissFactor()
        {
            int missFactor = randomNumberForEnemyType.Next(1, 11);

            return missFactor;
        }

        public void StoreLevelUpDataOLD(int health, int strength, int dexterity)
        {
            healthOld = health;
            strengthOld = strength;
            dexterityOld = dexterity;
        }
        public void StoreLevelUpDataOLD(int playerLevel)
        {
            playerLevelOld = playerLevel;
        }
        public void StoreLevelUpDataNEW(int health, int strength, int dexterity)
        {
            healthNew = health;
            strengthNew = strength;
            dexterityNew = dexterity;
        }
        public void StoreLevelUpDataNEW(int playerLevel)
        {
            playerLevelNew = playerLevel;
        }

        public void Fighting(HeroClassTypes heroClassTypes, EnemyClassType enemyClassType, StateManager stateManager, int playerCombatSelecter, int enemyCombatSelecter, Hero playerHero, Enemy enemy)
        {
            {
                if (playerCombatSelecter == 1)
                {
                    if (enemyCombatSelecter == 1)
                    {
                        playerHero.AttackEnemy1(heroClassTypes, enemy, enemyClassType, stateManager.AttackMissFactor());
                        enemy.AttackPlayer1(heroClassTypes, playerHero, enemyClassType);

                        MenuQueries.BattleDisplayPage(heroClassTypes, playerHero, enemy, enemyClassType, false, playerCombatSelecter, enemyCombatSelecter);
                    }
                    else if (enemyCombatSelecter == 2)
                    {
                        enemy.EnemyDefend(enemyClassType, true);
                        playerHero.AttackEnemy1(heroClassTypes, enemy, enemyClassType, stateManager.AttackMissFactor());
                        enemy.EnemyDefend(enemyClassType, false);

                        MenuQueries.BattleDisplayPage(heroClassTypes, playerHero, enemy, enemyClassType, false, playerCombatSelecter, enemyCombatSelecter);
                    }
                }
                else if (playerCombatSelecter == 2)
                {
                    if (enemyCombatSelecter == 1)
                    {
                        playerHero.PlayerDefend(heroClassTypes, true);
                        enemy.AttackPlayer1(heroClassTypes, playerHero, enemyClassType);
                        playerHero.PlayerDefend(heroClassTypes, false);

                        MenuQueries.BattleDisplayPage(heroClassTypes, playerHero, enemy, enemyClassType, false, playerCombatSelecter, enemyCombatSelecter);
                    }
                    else if (enemyCombatSelecter == 2)
                    {
                        playerHero.PlayerDefend(heroClassTypes, true);
                        enemy.EnemyDefend(enemyClassType, true);
                        playerHero.PlayerDefend(heroClassTypes, false);
                        enemy.EnemyDefend(enemyClassType, false);

                        MenuQueries.BattleDisplayPage(heroClassTypes, playerHero, enemy, enemyClassType, false, playerCombatSelecter, enemyCombatSelecter);
                    }
                }
                else
                {
                    playerHero.UseItem(heroClassTypes);
                }
            }
        }

        public bool PlayAgain()
        {
            Console.Clear();
            string playAgainOption = MenuQueries.GameOverDisplay();
            Console.Clear();

            if (playAgainOption.Equals("y",StringComparison.OrdinalIgnoreCase))
            {
                
                return true;
            }
            else if (playAgainOption.Equals("n", StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}
