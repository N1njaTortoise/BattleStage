using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleStage.MenuInput
{
    class AnimationsData
    {
        /*
         * 1) spearman ATTACK vs enemy ATTACK 
         * 2) spearman ATTACK vs enemy DEFEND 
         * 3) spearman DEFEND vs enemy ATTACK 
         * 4) spearman DEFEND vs enemy DEFEND
         * 
         */

        private List<string[]> spearmanVsMinionAnimations;
        private List<string[]> spearmanVsCreeperAnimations;
        private List<string[]> spearmanVsSkeletonAnimations;
        private List<string[]> spearmanVsOrcAnimations;

        private List<string[]> swordsmanVsMinionAnimations;
        private List<string[]> swordsmanVsCreeperAnimations;
        private List<string[]> swordsmanVsSkeletonAnimations;
        private List<string[]> swordsmanVsOrcAnimations;

        private List<string[]> rangerVsMinionAnimations;
        private List<string[]> rangerVsCreeperAnimations;
        private List<string[]> rangerVsSkeletonAnimations;
        private List<string[]> rangerVsOrcAnimations;


        private List<string[]> characterDisplayScreen;

        public AnimationsData()
        {
            spearmanVsMinionAnimations = new List<string[]>() { spearmanVsMinionAttackAttackAnimation, spearmanVsMinionAttackDefendAnimation, spearmanVsMinionDefendAttackAnimation, spearmanVsMinionDefendDefendAnimation };
            spearmanVsCreeperAnimations = new List<string[]>() { spearmanVsCreeperAttackAttackAnimation, spearmanVsCreeperAttackDefendAnimation, spearmanVsCreeperDefendAttackAnimation, spearmanVsCreeperDefendDefendAnimation };
            spearmanVsSkeletonAnimations = new List<string[]>() { spearmanVsSkeletonAttackAttackAnimation, spearmanVsSkeletonAttackDefendAnimation, spearmanVsSkeletonDefendAttackAnimation, spearmanVsSkeletonDefendDefendAnimation };
            spearmanVsOrcAnimations = new List<string[]>() { spearmanVsOrcAttackAttackAnimation, spearmanVsOrcAttackDefendAnimation, spearmanVsOrcDefendAttackAnimation, spearmanVsOrcDefendDefendAnimation };

            swordsmanVsMinionAnimations = new List<string[]>() { swordsmanVsMinionAttackAttackAnimation, swordsmanVsMinionAttackDefendAnimation, swordsmanVsMinionDefendAttackAnimation, swordsmanVsMinionDefendDefendAnimation };
            swordsmanVsCreeperAnimations = new List<string[]>() { swordsmanVsCreeperAttackAttackAnimation, swordsmanVsCreeperAttackDefendAnimation, swordsmanVsCreeperDefendAttackAnimation, swordsmanVsCreeperDefendDefendAnimation };
            swordsmanVsSkeletonAnimations = new List<string[]>() { swordsmanVsSkeletonAttackAttackAnimation, swordsmanVsSkeletonAttackDefendAnimation, swordsmanVsSkeletonDefendAttackAnimation, swordsmanVsSkeletonDefendDefendAnimation };
            swordsmanVsOrcAnimations = new List<string[]>() { swordsmanVsOrcAttackAttackAnimation, swordsmanVsOrcAttackDefendAnimation, swordsmanVsOrcDefendAttackAnimation, swordsmanVsOrcDefendDefendAnimation };

            rangerVsMinionAnimations = new List<string[]>() { rangerVsMinionAttackAttackAnimation, rangerVsMinionAttackDefendAnimation, rangerVsMinionDefendAttackAnimation, rangerVsMinionDefendDefendAnimation };
            rangerVsCreeperAnimations = new List<string[]>() { rangerVsCreeperAttackAttackAnimation, rangerVsCreeperAttackDefendAnimation, rangerVsCreeperDefendAttackAnimation, rangerVsCreeperDefendDefendAnimation };
            rangerVsSkeletonAnimations = new List<string[]>() { rangerVsSkeletonAttackAttackAnimation, rangerVsSkeletonAttackDefendAnimation, rangerVsSkeletonDefendAttackAnimation, rangerVsSkeletonDefendDefendAnimation };
            rangerVsOrcAnimations = new List<string[]>() { rangerVsOrcAttackAttackAnimation, rangerVsOrcAttackDefendAnimation, rangerVsOrcDefendAttackAnimation, rangerVsOrcDefendDefendAnimation };

            // initialise display
            characterDisplayScreen = new List<string[]>() { spearmanDisplay, swordsmanDisplay, rangerDisplay };
        }


        public List<string[]> SpearmanAnimations(int index)
        {
            List<List<string[]>> spearmanAnimations = new List<List<string[]>>() { spearmanVsMinionAnimations, spearmanVsCreeperAnimations, spearmanVsSkeletonAnimations, spearmanVsOrcAnimations };
            return spearmanAnimations[index];
        }
        public List<string[]> SwordsmanAnimations(int index)
        {
            List<List<string[]>> swordsmanAnimations = new List<List<string[]>>() { swordsmanVsMinionAnimations, swordsmanVsCreeperAnimations, swordsmanVsSkeletonAnimations, swordsmanVsOrcAnimations };
            return swordsmanAnimations[index];
        }
        public List<string[]> RangerAnimations(int index)
        {
            List<List<string[]>> rangernAnimations = new List<List<string[]>>() { rangerVsMinionAnimations, rangerVsCreeperAnimations, rangerVsSkeletonAnimations, rangerVsOrcAnimations };
            return rangernAnimations[index];
        }
        public string DisplayCharacter(int playerIndex, int enemyIndex)
        {
            string[] temp = characterDisplayScreen[playerIndex];
            string tempDisplay = temp[enemyIndex];
            return tempDisplay;
        }

        //private List<List<string[]>> spearmanAnimations = new List<List<string[]>>() { spearmanVsMinionAnimations, spearmanVsCreeperAnimations, spearmanVsSkeletonAnimations, spearmanVsOrcAnimations };
        //private List<string[]> spearmanVsMinionAnimations = new List<string[]>() { spearmanVsMinionAttackAttackAnimation, spearmanVsMinionAttackDefendAnimation, spearmanVsMinionDefendAttackAnimation, spearmanVsMinionDefendDefendAnimation };
        //private List<string[]> spearmanVsCreeperAnimations = new List<string[]>() { spearmanVsCreeperAttackAttackAnimation, spearmanVsCreeperAttackDefendAnimation, spearmanVsCreeperDefendAttackAnimation, spearmanVsCreeperDefendDefendAnimation };
        //private List<string[]> spearmanVsSkeletonAnimations = new List<string[]>() { spearmanVsSkeletonAttackAttackAnimation, spearmanVsSkeletonAttackDefendAnimation, spearmanVsSkeletonDefendAttackAnimation, spearmanVsSkeletonDefendDefendAnimation };
        //private List<string[]> spearmanVsOrcAnimations = new List<string[]>() { spearmanVsOrcAttackAttackAnimation, spearmanVsOrcAttackDefendAnimation, spearmanVsOrcDefendAttackAnimation, spearmanVsOrcDefendDefendAnimation };

        //private List<List<string[]>> swordsmanAnimations = new List<List<string[]>>() { swordsmanVsMinionAnimations, swordsmanVsCreeperAnimations, swordsmanVsSkeletonAnimations, swordsmanVsOrcAnimations };
        //private List<string[]> swordsmanVsMinionAnimations = new List<string[]>() { swordsmanVsMinionAttackAttackAnimation, swordsmanVsMinionAttackDefendAnimation, swordsmanVsMinionDefendAttackAnimation, swordsmanVsMinionDefendDefendAnimation };
        //private List<string[]> swordsmanVsCreeperAnimations = new List<string[]>() { swordsmanVsCreeperAttackAttackAnimation, swordsmanVsCreeperAttackDefendAnimation, swordsmanVsCreeperDefendAttackAnimation, swordsmanVsCreeperDefendDefendAnimation };
        //private List<string[]> swordsmanVsSkeletonAnimations = new List<string[]>() { swordsmanVsSkeletonAttackAttackAnimation, swordsmanVsSkeletonAttackDefendAnimation, swordsmanVsSkeletonDefendAttackAnimation, swordsmanVsSkeletonDefendDefendAnimation };
        //private List<string[]> swordsmanVsOrcAnimations = new List<string[]>() { swordsmanVsOrcAttackAttackAnimation, swordsmanVsOrcAttackDefendAnimation, swordsmanVsOrcDefendAttackAnimation, swordsmanVsOrcDefendDefendAnimation };

        //private List<List<string[]>> rangernAnimations = new List<List<string[]>>() { rangerVsMinionAnimations, rangerVsCreeperAnimations, rangerVsSkeletonAnimations, rangerVsOrcAnimations };
        //private List<string[]> rangerVsMinionAnimations = new List<string[]>() { rangerVsMinionAttackAttackAnimation, rangerVsMinionAttackDefendAnimation, rangerVsMinionDefendAttackAnimation, rangerVsMinionDefendDefendAnimation };
        //private List<string[]> rangerVsCreeperAnimations = new List<string[]>() { rangerVsCreeperAttackAttackAnimation, rangerVsCreeperAttackDefendAnimation, rangerVsCreeperDefendAttackAnimation, rangerVsCreeperDefendDefendAnimation };
        //private List<string[]> rangerVsSkeletonAnimations = new List<string[]>() { rangerVsSkeletonAttackAttackAnimation, rangerVsSkeletonAttackDefendAnimation, rangerVsSkeletonDefendAttackAnimation, rangerVsSkeletonDefendDefendAnimation };
        //private List<string[]> rangerVsOrcAnimations = new List<string[]>() { rangerVsOrcAttackAttackAnimation, rangerVsOrcAttackDefendAnimation, rangerVsOrcDefendAttackAnimation, rangerVsOrcDefendDefendAnimation };

        // SPEARMAN ANIMATION COLLECTION
        private string[] spearmanVsMinionAttackAttackAnimation = { spearmanVsMinionAttackAttack0, spearmanVsMinionAttackAttack1, spearmanVsMinionAttackAttack2 };
        private string[] spearmanVsMinionAttackDefendAnimation = { spearmanVsMinionAttackDefend0, spearmanVsMinionAttackDefend1, spearmanVsMinionAttackDefend2 };
        private string[] spearmanVsMinionDefendAttackAnimation = { spearmanVsMinionDefendAttack0, spearmanVsMinionDefendAttack1, spearmanVsMinionDefendAttack2 };
        private string[] spearmanVsMinionDefendDefendAnimation = { spearmanVsMinionDefendDefend0, spearmanVsMinionDefendDefend1, spearmanVsMinionDefendDefend2 };

        private string[] spearmanVsCreeperAttackAttackAnimation = { spearmanVsCreeperAttackAttack0, spearmanVsCreeperAttackAttack1, spearmanVsCreeperAttackAttack2 };
        private string[] spearmanVsCreeperAttackDefendAnimation = { spearmanVsCreeperAttackDefend0, spearmanVsCreeperAttackDefend1, spearmanVsCreeperAttackDefend2 };
        private string[] spearmanVsCreeperDefendAttackAnimation = { spearmanVsCreeperDefendAttack0, spearmanVsCreaperDefendAttack1, spearmanVsCreeperDefendAttack2 };
        private string[] spearmanVsCreeperDefendDefendAnimation = { spearmanVsCreeperDefendDefend0, spearmanVsCreaperDefendDefend1, spearmanVsCreeperDefendDefend2 };

        private string[] spearmanVsSkeletonAttackAttackAnimation = { spearmanVsSkeletonAttackAttack0, spearmanVsSkeletonAttackAttack1, spearmanVsSkeletonAttackAttack2 };
        private string[] spearmanVsSkeletonAttackDefendAnimation = { spearmanVsSkeletonAttackDefend0, spearmanVsSkeletonAttackDefend1, spearmanVsSkeletonAttackDefend2 };
        private string[] spearmanVsSkeletonDefendAttackAnimation = { spearmanVsSkeletonDefendAttack0, spearmanVsSkeletonDefendAttack1, spearmanVsSkeletonDefendAttack2 };
        private string[] spearmanVsSkeletonDefendDefendAnimation = { spearmanVsSkeletonDefendDefend0, spearmanVsSkeletonDefendDefend1, spearmanVsSkeletonDefendDefend2 };

        private string[] spearmanVsOrcAttackAttackAnimation = { spearmanVsOrcAttackAttack0, spearmanVsOrcAttackAttack1, spearmanVsOrcAttackAttack2 };
        private string[] spearmanVsOrcAttackDefendAnimation = { spearmanVsOrcAttackDefend0, spearmanVsOrcAttackDefend1, spearmanVsOrcAttackDefend2 };
        private string[] spearmanVsOrcDefendAttackAnimation = { spearmanVsOrcDefendAttack0, spearmanVsOrcDefendAttack1, spearmanVsOrcDefendAttack2 };
        private string[] spearmanVsOrcDefendDefendAnimation = { spearmanVsOrcDefendDefend0, spearmanVsOrcDefendDefend1, spearmanVsOrcDefendDefend2 };

        //  SWORDSMAN ANIMATION COLLECTION
        private string[] swordsmanVsMinionAttackAttackAnimation = { swordsmanVsMinionAttackAttack0, swordsmanVsMinionAttackAttack1, swordsmanVsMinionAttackAttack2 };
        private string[] swordsmanVsMinionAttackDefendAnimation = { swordsmanVsMinionAttackDefend0, swordsmanVsMinionAttackDefend1, swordsmanVsMinionAttackDefend2 };
        private string[] swordsmanVsMinionDefendAttackAnimation = { swordsmanVsMinionDefendAttack0, swordsmanVsMinionDefendAttack1, swordsmanVsMinionDefendAttack2 };
        private string[] swordsmanVsMinionDefendDefendAnimation = { swordsmanVsMinionDefendDefend0, swordsmanVsMinionDefendDefend1, swordsmanVsMinionDefendDefend2 };

        private string[] swordsmanVsCreeperAttackAttackAnimation = { swordsmanVsCreeperAttackAttack0, swordsmanVsCreeperAttackAttack1, swordsmanVsCreeperAttackAttack2 };
        private string[] swordsmanVsCreeperAttackDefendAnimation = { swordsmanVsCreeperAttackDefend0, swordsmanVsCreeperAttackDefend1, swordsmanVsCreeperAttackDefend2 };
        private string[] swordsmanVsCreeperDefendAttackAnimation = { swordsmanVsCreeperDefendAttack0, swordsmanVsCreeperDefendAttack1, swordsmanVsCreeperDefendAttack2 };
        private string[] swordsmanVsCreeperDefendDefendAnimation = { swordsmanVsCreeperDefendDefend0, swordsmanVsCreeperDefendDefend1, swordsmanVsCreeperDefendDefend2 };

        private string[] swordsmanVsSkeletonAttackAttackAnimation = { swordsmanVsSkeletonAttackAttack0, swordsmanVsSkeletonAttackAttack1, swordsmanVsSkeletonAttackAttack2 };
        private string[] swordsmanVsSkeletonAttackDefendAnimation = { swordsmanVsSkeletonAttackDefend0, swordsmanVsSkeletonAttackDefend1, swordsmanVsSkeletonAttackDefend2 };
        private string[] swordsmanVsSkeletonDefendAttackAnimation = { swordsmanVsSkeletonDefendAttack0, swordsmanVsSkeletonDefendAttack1, swordsmanVsSkeletonDefendAttack2 };
        private string[] swordsmanVsSkeletonDefendDefendAnimation = { swordsmanVsSkeletonDefendDefend0, swordsmanVsSkeletonDefendDefend1, swordsmanVsSkeletonDefendDefend2 };

        private string[] swordsmanVsOrcAttackAttackAnimation = { swordsmanVsOrcAttackAttack0, swordsmanVsOrcAttackAttack1, swordsmanVsOrcAttackAttack2 };
        private string[] swordsmanVsOrcAttackDefendAnimation = { swordsmanVsOrcAttackDefend0, swordsmanVsORcAttackDefend1, swordsmanVsOrcAttackDefend2 };
        private string[] swordsmanVsOrcDefendAttackAnimation = { swordsmanVsOrcDefendAttack0, swordsmanVsOrcDefendAttack1, swordsmanVsOrcDefendAttack2 };
        private string[] swordsmanVsOrcDefendDefendAnimation = { swordsmanVsOrcDefendDefend0, swordsmanVsOrcDefendDefend1, swordsmanVsOrcDefendDefend2 };

        //  RANGER ANIMATION COLLECTION
        private string[] rangerVsMinionAttackAttackAnimation = { rangerVsMinionAttackAttack0, rangerVsMinionAttackAttack1, rangerVsMinionAttackAttack2 };
        private string[] rangerVsMinionAttackDefendAnimation = { rangerVsMinionAttackDefend0, rangerVsMinionAttackDefend1, rangerVsMinionAttackDefend2 };
        private string[] rangerVsMinionDefendAttackAnimation = { rangerVsMinionDefendAttack0, rangerVsMinionDefendAttack1, rangerVsMinionDefendAttack2 };
        private string[] rangerVsMinionDefendDefendAnimation = { rangerVsMinionDefendDefend0, rangerVsMinionDefendDefend1, rangerVsMinionDefendDefend2 };

        private string[] rangerVsCreeperAttackAttackAnimation = { rangerVsCreeperAttackAttack0, rangerVsCreeperAttackAttack1, rangerVsCreeperAttackAttack2 };
        private string[] rangerVsCreeperAttackDefendAnimation = { rangerVsCreeperAttackDefend0, rangerVsCreeperAttackDefend1, rangerVsCreeperAttackDefend2 };
        private string[] rangerVsCreeperDefendAttackAnimation = { rangerVsCreeperDefendAttack0, rangerVsCreeperDefendAttack1, rangerVsCreeperDefendAttack2 };
        private string[] rangerVsCreeperDefendDefendAnimation = { rangerVsCreeperDefendDefend0, rangerVsCreeperDefendDefend1, rangerVsCreeperDefendDefend2 };

        private string[] rangerVsSkeletonAttackAttackAnimation = { rangerVsSkeletonAttackAttack0, rangerVsSkeletonAttackAttack1, rangerVsSkeletonAttackAttack2 };
        private string[] rangerVsSkeletonAttackDefendAnimation = { rangerVsSkeletonAttackDefend0, rangerVsSkeletonAttackDefend1, rangerVsSkeletonAttackDefend2 };
        private string[] rangerVsSkeletonDefendAttackAnimation = { rangerVsSkeletonDefendAttack0, rangerVsSkeletonDefendAttack1, rangerVsSkeletonDefendAttack2 };
        private string[] rangerVsSkeletonDefendDefendAnimation = { rangerVsSkeletonDefendDefend0, rangerVsSkeletonDefendDefend1, rangerVsSkeletonDefendDefend2 };

        private string[] rangerVsOrcAttackAttackAnimation = { rangerVsOrcAttackAttack0, rangerVsOrcAttackAttack1, rangerVsOrcAttackAttack2 };
        private string[] rangerVsOrcAttackDefendAnimation = { rangerVsOrcAttackDefend0, rangerVsOrcAttackDefend1, rangerVsOrcAttackDefend2 };
        private string[] rangerVsOrcDefendAttackAnimation = { rangerVsOrcDefendAttack0, rangerVsOrcDefendAttack1, rangerVsOrcDefendAttack2 };
        private string[] rangerVsOrcDefendDefendAnimation = { rangerVsOrcDefendDefend0, rangerVsOrcDefendDefend1, rangerVsOrcDefendDefend2 };


        // Characher Display Screen
        private string[] spearmanDisplay = new string[] { spearmanVsMinionAttackAttack0, spearmanVsCreeperAttackAttack0, spearmanVsSkeletonAttackAttack0, spearmanVsOrcAttackAttack0 };
        private string[] swordsmanDisplay = new string[] { swordsmanVsMinionAttackAttack0, swordsmanVsCreeperAttackAttack0, swordsmanVsSkeletonAttackAttack0, swordsmanVsOrcAttackAttack0 };
        private string[] rangerDisplay = new string[] { rangerVsMinionAttackAttack0, rangerVsCreeperAttackAttack0, rangerVsSkeletonAttackAttack0, rangerVsOrcAttackAttack0 };

        //***********************************************************************************************************************************************************************************
        //                                                                  ANIMATION CLIP STRINGS
        //***********************************************************************************************************************************************************************************

        // SPEARMAN ANIMANTION CLIPS
        //      Minion
        private const string spearmanVsMinionAttackAttack0 = @"

          _____                                                         
         |     |   /\                                                  
         |__ __|  /__\                              
            |      |                                                                  ______  
           /|\     |                                                              \\ |___ 0 |      
          / | \____|                                                               \\  _|__|__ 
         /  |      |                                                                \\/       \
           / \     |                                                                 \\//      |
          |   |    |                                                                  \_______/
          |   |    |                                                                    ||  ||
";
        private const string spearmanVsMinionAttackAttack1 = @"

                                 _____            
                                |     |       ___    
                                |__ __|      \  /
                                   |         /\/               ______//  
                                  /|\       /                 |___ 0//       
                                 / | \____ /                    _|_//|__ 
                                /  |      /                    /  //    \
                                  / \    /                    | //      |
                                 /   |  /                      \_______/
                                /    / /                         ||  ||
";
        private const string spearmanVsMinionAttackAttack2 = @"

                                          _____            
                                         |     |          
                                         |__ __|      
                                            |      \\  _______ 
                                           /|\      \\|__  0  |      
                                      ====/=|========|\ _|_  |__ 
                                           |          \\        \
                                           / \         \\//     |
                                          /   |         \_______/
                                         /    /          ||  ||
";

        private const string spearmanVsMinionAttackDefend0 = @"

          _____                                                         
         |     |   /\                                                  
         |__ __|  /__\                              
            |      |                                                                  ______  
           /|\     |                                                              \\ |___ 0 |      
          / | \____|                                                               \\  _|__|__ 
         /  |      |                                                                \\/       \
           / \     |                                                                 \\//      |
          |   |    |                                                                  \_______/
          |   |    |                                                                    ||  ||
";
        private const string spearmanVsMinionAttackDefend1 = @"

                                               _____ 
                                              |     |       ___
                                              |__ __|      \  /
                                                 |         /\/                        ______  
                                                /|\       /                       \\ |___ 0 |      
                                               / | \____ /                         \\  _|_ |__ 
                                              /  |      /                           \\/       \
                                                / \    /                             \\//      |
                                               /   |  /                               \_______/
                                              /    / /                                  ||  ||
";
        private const string spearmanVsMinionAttackDefend2 = @"

                                                                      _____  
                                                                     |     |
                                                                     |__ __|
                                                                        |        ||  _______ 
                                                                       /|\       || |___ 0  |      
                                                                  ====/=|========|||   __|__|_ 
                                                                        |        ||__ /       \
                                                                       / \       ||--|        |
                                                                      /   |      ||  \_______/
                                                                     /    /            ||  ||
";

        private const string spearmanVsMinionDefendAttack0 = @"

          _____                                                         
         |     |   /\                                                  
         |__ __|  /__\                              
            |      |                                                                  ______  
           /|\     |                                                              \\ |___ 0 |      
          / | \____|                                                               \\  _|__|__ 
         /  |      |                                                                \\/       \
           / \     |                                                                 \\//      |
          |   |    |                                                                  \_______/
          |   |    |                                                                    ||  ||
";
        private const string spearmanVsMinionDefendAttack1 = @"

          _____            
         |     |   /\    
         |__ __|  /__\
            |      |                            ______//  
           /|\     |                           |___ 0//       
          / | \____|                             _|_//|__ 
         /  |      |                            /  //    \
           / \     |                           | //      |
          /   |    |                            \_______/
         /    /    |                              ||  ||
";
        private const string spearmanVsMinionDefendAttack2 = @"

          _____            
         |     |     /\    
         |__ __|    /__\
            |        ||\\   _______  
            |\_______|| \\ |___ 0  |     
            | \______||  \\   _|_ |__ 
            |        ||   \\ /       \
           / \       ||    \\//      |
          /   |      ||     \_______/
         |    |      ||       ||  ||
";

        private const string spearmanVsMinionDefendDefend0 = @"

          _____                                                         
         |     |   /\                                                  
         |__ __|  /__\                              
            |      |                                                                  ______  
           /|\     |                                                              \\ |___ 0 |      
          / | \____|                                                               \\  _|__|__ 
         /  |      |                                                                \\/       \
           / \     |                                                                 \\//      |
          |   |    |                                                                  \_______/
          |   |    |                                                                    ||  ||
";
        private const string spearmanVsMinionDefendDefend1 = @"

          _____                                                         
         |     |    /\                                                  
         |__ __|   /__\                              
            |       ||                                                            ||  ______  
            |\______||                                                            || |___ 0 |      
            | \_____||                                                            ||   _|__|__ 
            |       ||                                                            ||__/       \
           / \      ||                                                            ||--|        |
          /   |     ||                                                            ||  \_______/
         |    |     ||                                                                  ||  ||
";
        private const string spearmanVsMinionDefendDefend2 = @"

        ? _____  ?                                                      
         |     |   /\  ?                                                               ?     ?
      ?  |__ __|  /__\                                                             ?      ?      ?
            |   ?  |                                                                  ______  ?
        ?  /|\     |  ?                                                           \\ |___ 0 |    ?    
          / | \____|                                                               \\  _|__|__ 
         /  |      |                                                                \\/       \
           / \     |                                                                 \\//      |
          |   |    |                                                                  \_______/
          |   |    |                                                                    ||  ||
";

        //      Creeper
        private const string spearmanVsCreeperAttackAttack0 = @"

          _____                                                         
         |     |   /\                                                  
         |__ __|  /__\                                                                 0        0
            |      |                                                                    \      /
           /|\     |                                                                   __|____|__ 
          / | \____|                                                                  /          \
         /  |      |                                                                  |    ||    |
           / \     |                                                                  |\________/|
          |   |    |                                                                //\__\/__\/__/\\
          |   |    |                                                               // // ||  || \\ \\
";
        private const string spearmanVsCreeperAttackAttack1 = @"

                                 _____            
                                |     |       ___    
                                |__ __|      \  /               0        0
                                   |         /\/                 \      /
                                  /|\       /                   __|____|__ 
                                 / | \____ /                   /          \
                                /  |      /                    |    ||    |
                                  / \    /                     |\________/|
                                 /   |  /                    //\__\/__\/__/\\
                                /    / /                    // // ||  || \\ \\   
";
        private const string spearmanVsCreeperAttackAttack2 = @"

                                          _____            
                                         |     |  0___            ___0 
                                         |__ __|      \__________/        
                                            |         /__  __  __\
                                           /|\        |  \/  \/  | 
                                      ====/=|========||          |
                                            |         |          |
                                           / \        |\_/\__/\_/|
                                          /   |     //\__________/\\
                                         /    /    // // ||  || \\ \\
";

        private const string spearmanVsCreeperAttackDefend0 = @"

          _____                                                         
         |     |   /\                                                  
         |__ __|  /__\                                                                 0        0
            |      |                                                                    \      /
           /|\     |                                                                   __|____|__ 
          / | \____|                                                                  /          \
         /  |      |                                                                  |    ||    |
           / \     |                                                                  |\________/|
          |   |    |                                                                //\__\/__\/__/\\
          |   |    |                                                               // // ||  || \\ \\
";
        private const string spearmanVsCreeperAttackDefend1 = @"

                                               _____            
                                              |     |       ___    
                                              |__ __|      \  /                        0        0
                                                 |         /\/                          \      /
                                                /|\       /                            __|____|__ 
                                               / | \____ /                            /          \
                                              /  |      /                             |    ||    |
                                                / \    /                              |\________/|
                                               /   |  /                             //\__\/__\/__/\\
                                              /    / /                             // // ||  || \\ \\  
";
        private const string spearmanVsCreeperAttackDefend2 = @"

                                                                        _____            
                                                                       |     |           
                                                                       |__ __|         __       __ 
                                                                          |           0  \     /  0
                                                                         /|\           __|____|__ 
                                                                    ====/=|==========|/          \
                                                                          |           |    ||    | //
                                                                         / \          | _/\_/\_  |//
                                                                        /   |       //\/________\//
                                                                       /    /      // // ||  || \\  
";

        private const string spearmanVsCreeperDefendAttack0 = @"

          _____                                                         
         |     |   /\                                                  
         |__ __|  /__\                                                                 0        0
            |      |                                                                    \      /
           /|\     |                                                                   __|____|__ 
          / | \____|                                                                  /          \
         /  |      |                                                                  |    ||    |
           / \     |                                                                  |\________/|
          |   |    |                                                                //\__\/__\/__/\\
          |   |    |                                                               // // ||  || \\ \\
";
        private const string spearmanVsCreaperDefendAttack1 = @"

          _____            
         |     |   /\    
         |__ __|  /__\                         0        0
            |      |                            \      /
           /|\     |                           __|____|__    
          / | \____|                          /          \
         /  |      |                          |    ||    |
           / \     |                          |\________/|
          /   |    |                        //\__\/__\/__/\\  
         /    /    |                       // // ||  || \\ \\
";
        private const string spearmanVsCreeperDefendAttack2 = @"

          _____                                                         
         |     |     /\0___            ___0                                          
         |__ __|    /__\   \__________/            
            |        ||    /__  __  __\           
            |\_______||    |  \/  \/  |            
            | \______||    |          |           
            |        ||    |          |            
           / \       ||    |\_/\__/\_/|         
          /   |      ||  //\__________/\\       
         |    |      || // // ||  || \\ \\         
";

        private const string spearmanVsCreeperDefendDefend0 = @"

          _____                                                         
         |     |   /\                                                  
         |__ __|  /__\                                                                 0        0
            |      |                                                                    \      /
           /|\     |                                                                   __|____|__ 
          / | \____|                                                                  /          \
         /  |      |                                                                  |    ||    |
           / \     |                                                                  |\________/|
          |   |    |                                                                //\__\/__\/__/\\
          |   |    |                                                               // // ||  || \\ \\
";
        private const string spearmanVsCreaperDefendDefend1 = @"

          _____            
         |     |   /\    
         |__ __|  /__\                                                                 0        0
            |      |                                                                    \      /
           /|\     |                                                                   __|____|__    
          / | \____|                                                                  /          \
         /  |      |                                                                  |    ||    |
           / \     |                                                                  |\________/|
          /   |    |                                                                //\__\/__\/__/\\  
         /    /    |                                                               // // ||  || \\ \\
";
        private const string spearmanVsCreeperDefendDefend2 = @"

        ? _____    ?                                                     
    ?    |     |     /\  ?                                                             ?     ?    ?
         |__ __| ?  /__\                                                               __  ?    __    ?
      ?     |        ||   ?                                                      ?    0  \     /  0 ?
            |\_______||                                                            ?   __|____|__ 
            | \______||                                                               /          \
            |        ||                                                               |    ||    | //
           / \       ||                                                               | _/\_/\_  |//
          /   |      ||                                                             //\/________\//
         |    |      ||                                                            // // ||  || \\  
";

        //      Skeleton
        private const string spearmanVsSkeletonAttackAttack0 = @"

          _____
         |     |   /\
         |__ __|  /__\                                                             ||   ________
            |      |                                                               ||  /  0  0  \
           /|\     |                                                               ||  |   ||   |
          / | \____|                                                               ||   \ |__| /
         /  |      |                                                              _||_  /|____|\
           / \     |                                                               ||__/ ==|==  \
          |   |    |                                                               ||     =|=
          |   |    |                                                                      / \
";
        private const string spearmanVsSkeletonAttackAttack1 = @"

                                 _____
                                |     |       ___                 //
                                |__ __|      \  /                //_______
                                   |         /\/                //  0  0  \
                                  /|\       /                  //|   ||   |
                                 / | \____ /                  //  \ |__| /
                                /  |      /                  //   /|____|\
                                  / \    /                  // \_/ ==|==  \
                                 /   |  /                           =|=
                                /    / /                            / \
";
        private const string spearmanVsSkeletonAttackAttack2 = @"

                                          _____
                                         |     |
                                         |__ __|       ________
                                            |  \\     /  0  0  \
                                           /|\  \\    |   ||   |
                                      ====/=|========| \ |__| /
                                            |     \\   /|____|\
                                           / \     \\_/ ==|==  \
                                          /   |          =|=
                                         /    /          / \
";

        private const string spearmanVsSkeletonAttackDefend0 = @"

          _____
         |     |   /\
         |__ __|  /__\                                                             ||   ________
            |      |                                                               ||  /  0  0  \
           /|\     |                                                               ||  |   ||   |
          / | \____|                                                               ||   \ |__| /
         /  |      |                                                              _||_  /|____|\
           / \     |                                                               ||__/ ==|==  \
          |   |    |                                                               ||     =|=
          |   |    |                                                                      / \
";
        private const string spearmanVsSkeletonAttackDefend1 = @"

                                               _____
                                              |     |       ___
                                              |__ __|      \  /                    ||   ________
                                                 |         /\/                     ||  /  0  0  \
                                                /|\       /                        ||  |   ||   |
                                               / | \____ /                         ||   \ |__| /
                                              /  |      /                         _||_  /|____|\
                                                / \    /                           ||__/ ==|==  \
                                               /   |  /                            ||     =|=
                                              /    / /                                    / \
";
        private const string spearmanVsSkeletonAttackDefend2 = @"

                                                                        _____
                                                                       |     |
                                                                       |__ __|       ||   ________
                                                                          |          ||  /  0  -- \
                                                                         /|\         ||  |   ||   |
                                                                    ====/=|==========||   \ |__| /
                                                                          |         _||_  /|____|\___
                                                                         / \         ||__/==|==
                                                                        /   |        ||   =|=
                                                                       /    /             / \
";

        private const string spearmanVsSkeletonDefendAttack0 = @"

          _____
         |     |   /\
         |__ __|  /__\                                                             ||   ________
            |      |                                                               ||  /  0  0  \
           /|\     |                                                               ||  |   ||   |
          / | \____|                                                               ||   \ |__| /
         /  |      |                                                              _||_  /|____|\
           / \     |                                                               ||__/ ==|==  \
          |   |    |                                                               ||     =|=
          |   |    |                                                                      / \
";
        private const string spearmanVsSkeletonDefendAttack1 = @"

          _____
         |     |   /\                            //
         |__ __|  /__\                          //_______
            |      |                           //  0  0  \
           /|\     |                          //|   ||   |
          / | \____|                         //  \ |__| /
         /  |      |                        //   /|____|\
           / \     |                       // \_/ ==|==  \
          /   |    |                               =|=
         /    /    |                               / \
";
        private const string spearmanVsSkeletonDefendAttack2 = @"

          _____
         |     |     /\
         |__ __|    /__\      ________
            |        ||\     /  0  0  \
            |\_______||\\    |   ||   |
            | \______|| \\    \ |__| /
            |        ||  \\   /|____|\
           / \       ||   \\_/ ==|==  \
          /   |      ||         =|=
         |    |      ||         / \
";

        private const string spearmanVsSkeletonDefendDefend0 = @"

          _____
         |     |   /\ 
         |__ __|  /__\                                                             ||   ________
            |      |                                                               ||  /  0  0  \
           /|\     |                                                               ||  |   ||   |
          / | \____|                                                               ||   \ |__| /
         /  |      |                                                              _||_  /|____|\
           / \     |                                                               ||__/ ==|==  \
          |   |    |                                                               ||     =|=
          |   |    |                                                                      / \
";
        private const string spearmanVsSkeletonDefendDefend1 = @"

          _____
         |     |   /\
         |__ __|  /__\                                                             ||   ________
            |      |                                                               ||  /  0  0  \
           /|\     |                                                               ||  |   ||   |
          / | \____|                                                               ||   \ |__| /
         /  |      |                                                              _||_  /|____|\
           / \     |                                                               ||__/ ==|==  \
          /   |    |                                                               ||     =|=
         /    /    |                                                                      / \
";
        private const string spearmanVsSkeletonDefendDefend2 = @"

        ? _____    ?                                                                     ?           ?
    ?    |     |     /\  ?                                                         ?         ?        ?
         |__ __| ?  /__\                                                              ||   ________       ?
      ?     |        ||   ?                                                     ?     ||  /  0  -- \
            |\_______||                                                               ||  |   ||   |   ?
            | \______||                                                               ||   \ |__| /
            |        ||                                                              _||_  /|____|\___
           / \       ||                                                               ||__/==|==
          /   |      ||                                                               ||   =|=
         |    |      ||                                                                   / \
";

        //      Orc
        private const string spearmanVsOrcAttackAttack0 = @"
                                                                           ___
          _____                                                           /   |  _     ___________
         |     |   /\                                                    |    |_| |   / ___   ___ \
         |__ __|  /__\                                                    \    _| |  |  \__| |__/  |
            |      |                                                       \  | | |  |  _________  |
           /|\     |                                                        \_| | | /   /_\/__\/_\  \
          / | \____|                                                            | | \___         ___/
         /  |      |                                                            | |/    \_______/    \
           / \     |                                                            |/   /  ___/\___  \    \
          |   |    |                                                            /ppp/\_____________/\qqq\
          |   |    |                                                                  ddd__| |__bbb
";
        private const string spearmanVsOrcAttackAttack1 = @"
                                                         _____                                   
                                 _____                  |    \  ___________
                                |     |       ___       \  __| / ___   ___ \
                                |__ __|      \  /       / /   |  \__| |__/  | 
                                   |         /\/       / /    |  _________  |
                                  /|\       /         / /    /   /_\/__\/_\  \
                                 / | \____ /         / /\____\___         ___/ 
                                /  |      /         /_/ \_____   \_______/    \
                                  / \    /                   |   ___/\___  \    \
                                 /   |  /                    \_____________/\qqq\
                                /    / /                       ddd__| |__bbb 
";
        private const string spearmanVsOrcAttackAttack2 = @"

                                          _____           ___________
                                         |     |         / ___   ___ \
                                         |__ __|\       |  \__| |__/  | 
                                            |  \ \      |  _________  |
                                           /|\  \ \    /   /_\/__\/_\  \
                                      ====/=|========| \___         ___/ 
                                            |     \ \  /    \_______/    \
                                           / \     \ \/   /  ___/\___  \    \
                                          /   |      /ppp/\_____________/\qqq\
                                         /    /            ddd__| |__bbb 
";

        private const string spearmanVsOrcAttackDefend0 = @"
                                                                           ___
          _____                                                           /   |  _     ___________
         |     |   /\                                                    |    |_| |   / ___   ___ \
         |__ __|  /__\                                                    \    _| |  |  \__| |__/  | 
            |      |                                                       \  | | |  |  _________  |
           /|\     |                                                        \_| | | /   /_\/__\/_\  \
          / | \____|                                                            | | \___         ___/ 
         /  |      |                                                            | |/    \_______/    \
           / \     |                                                            |/   /  ___/\___  \    \
          |   |    |                                                            /ppp/\_____________/\qqq\
          |   |    |                                                                  ddd__| |__bbb 
";
        private const string spearmanVsOrcAttackDefend1 = @"
                                                                           ___                              
                                               _____                      /   |  _     ___________
                                              |     |       ___          |    |_| |   / ___   ___ \
                                              |__ __|      \  /           \    _| |  |  \__| |__/  | 
                                                 |         /\/             \  | | |  |  _________  |
                                                /|\       /                 \_| | | /   /_\/__\/_\  \
                                               / | \____ /                      | | \___         ___/ 
                                              /  |      /                       | |/    \_______/    \
                                                / \    /                        |/   /  ___/\___  \    \
                                               /   |  /                         /ppp/\_____________/\qqq\
                                              /    / /                                ddd__| |__bbb 
";
        private const string spearmanVsOrcAttackDefend2 = @"
                                                                             ___
                                                                      _____ /   |  _      ___________
                                                                     |     |    |_| |    / ___       \
                                                                     |__ __|\    _| |   |  \__|  === |
                                                                        |    \  | | |  |  _________  |
                                                                       /|\    \_| | | /   /_\/  \/_\  \
                                                                  ====/=|=========| | \___  \____/ ___/__
                                                                        |         | |/   \_______/  __   \
                                                                       / \       /   /  ___/\___  \ | \   \
                                                                      /   |     /ppp/\_____________/   \qqq\
                                                                     /    /         ddd__| |__bbb 
";

        private const string spearmanVsOrcDefendAttack0 = @"
                                                                           ___
          _____                                                           /   |  _     ___________
         |     |   /\                                                    |    |_| |   / ___   ___ \
         |__ __|  /__\                                                    \    _| |  |  \__| |__/  | 
            |      |                                                       \  | | |  |  _________  |
           /|\     |                                                        \_| | | /   /_\/__\/_\  \
          / | \____|                                                            | | \___         ___/ 
         /  |      |                                                            | |/    \_______/    \
           / \     |                                                            |/   /  ___/\___  \    \
          |   |    |                                                            /ppp/\_____________/\qqq\
          |   |    |                                                                  ddd__| |__bbb 
";
        private const string spearmanVsOrcDefendAttack1 = @"
                                         ____
          _____                         |    \  ___________
         |     |   /\                   \  __| / ___   ___ \
         |__ __|  /__\                  / /   |  \__| |__/  | 
            |      |                   / /    |  _________  |
           /|\     |                  / /    /   /_\/__\/_\  \
          / | \____|                 / /\____\___         ___/ 
         /  |      |                /_/ \_____   \_______/    \
           / \     |                         |   ___/\___  \    \
          /   |    |                         \_____________/\qqq\
         /    /    |                          ddd__| |__bbb 
";
        private const string spearmanVsOrcDefendAttack2 = @"

          _____               ___________                            
         |     |     /\      / ___   ___ \                            
         |__ __|    /__\    |  \__| |__/  |
            |      \ ||     |  _________  |
            |\______\||\   /   /_\/__\/_\  \
            | \______|| \  \_____         _/___ 
            |        ||\ \  /    \_______/     \
           / \       || \ \/   /  ___/\___  \    \
          /   |      ||   /ppp/\_____________/\qqq\
         |    |      ||          ddd__| |__bbb 
";

        private const string spearmanVsOrcDefendDefend0 = @"
                                                                           ___
          _____                                                           /   |  _     ___________
         |     |   /\                                                    |    |_| |   / ___   ___ \
         |__ __|  /__\                                                    \    _| |  |  \__| |__/  | 
            |      |                                                       \  | | |  |  _________  |
           /|\     |                                                        \_| | | /   /_\/__\/_\  \
          / | \____|                                                            | | \___         ___/ 
         /  |      |                                                            | |/    \_______/    \
           / \     |                                                            |/   /  ___/\___  \    \
          |   |    |                                                            /ppp/\_____________/\qqq\
          |   |    |                                                                  ddd__| |__bbb 
";
        private const string spearmanVsOrcDefendDefend1 = @"
                                                                           ___
          _____                                                           /   |  _     ___________
         |     |   /\                                                    |    |_| |   / ___   ___ \
         |__ __|  /__\                                                    \    _| |  |  \__| |__/  | 
            |      |                                                       \  | | |  |  _________  |
           /|\     |                                                        \_| | | /   /_\/__\/_\  \
          / | \____|                                                            | | \___         ___/ 
         /  |      |                                                            | |/    \_______/    \
           / \     |                                                            |/   /  ___/\___  \    \
          /   |    |                                                            /ppp/\_____________/\qqq\
         /    /    |                                                                  ddd__| |__bbb 
";
        private const string spearmanVsOrcDefendDefend2 = @"
                                                                             ___          ?         ?      ?
        ? _____    ?                                                        /   |  _   ?  ___________    ?
    ?    |     |     /\  ?                                             ?   |    |_| |    / ___       \      ?
         |__ __| ?  /__\                                                    \    _| |   |  \__|  === |  ?
      ?     |        ||   ?                                                  \  | | |  |  _________  |
            |\_______||                                                       \_| | | /   /_\/  \/_\  \
            | \______||                                                           | | \___  \____/ ___/__
            |        ||                                                           | |/   \_______/  __   \
           / \       ||                                                          /   /  ___/\___  \ | \   \
          /   |      ||                                                         /ppp/\_____________/   \qqq\
         |    |      ||                                                             ddd__| |__bbb 
";

        // SWORDSMAN ANIMANTION CLIPS
        //      Minion
        private const string swordsmanVsMinionAttackAttack0 = @" 

          _____    /\
         |     |   ||
      __ |__ __|   ||
     /  \   |      ||                                                                 ______
    /    \ /|\    _||_                                                            \\ |___ 0 |
   |     |/ | \____||                                                              \\  _|__|__
   |     |  |      ||                                                               \\/       \
    \    / / \                                                                       \\//      |
     \__/ |   |                                                                       \_______/
          |   |                                                                         ||  ||
";
        private const string swordsmanVsMinionAttackAttack1 = @"

                                  __\\_
                                 |     |
                              __ |__ __|\
                             /  \   |   \\                    ______//
                            /    \ /|\  /\\                  |___ 0//
                           |     |/ | \/                       _|_//|__
                           |     |  |                         /  //    \
                           \    / / \                         | //      |
                            \__/ /   |                         \_______/
                                /   /                            ||  ||
";
        private const string swordsmanVsMinionAttackAttack2 = @"

                                          _____             
                                         |     |              
                                      __ |__ __|     //   
                                     /  \   |      \\/ _______ 
                                    /    \ /|\    //\\|__  0  |      
                                   |     |/ | \  //   \ _|_  |__ 
                                   |     |  |  \//    \\        \
                                    \    / / \ //       \\//     |
                                     \__/ /   |         \_______/
                                         /   /           ||  ||
";

        private const string swordsmanVsMinionAttackDefend0 = @"

          _____    /\
         |     |   ||
      __ |__ __|   ||
     /  \   |      ||                                                                 ______
    /    \ /|\    _||_                                                            \\ |___ 0 |
   |     |/ | \____||                                                              \\  _|__|__
   |     |  |      ||                                                               \\/       \
    \    / / \                                                                       \\//      |
     \__/ |   |                                                                       \_______/
          |   |                                                                         ||  ||
";
        private const string swordsmanVsMinionAttackDefend1 = @"

                                               __\\_
                                              |     |
                                           __ |__ __|\
                                          /  \   |   \\                               ______  
                                         /    \ /|\  /\\                          \\ |___ 0 |      
                                        |     |/ | \/                              \\  _|_ |__ 
                                        |     |  |                                  \\/       \
                                         \    / / \                                  \\//      |
                                          \__/ /   |                                  \_______/
                                              /   /                                     ||  ||
";
        private const string swordsmanVsMinionAttackDefend2 = @"

                                                                      _____ 
                                                                     |     | 
                                                                  __ |__ __|    //
                                                                 /  \   |      //||  _______ 
                                                                /    \ /|\    // || |___ 0  |      
                                                               |     |/ | \  //  ||    __|__|_ 
                                                               |     |  |  \//   ||__ /       \
                                                                \    / / \ //    ||--|        |
                                                                 \__/ /   |      ||  \_______/
                                                                     /   /             ||  ||
";

        private const string swordsmanVsMinionDefendAttack0 = @"

          _____    /\
         |     |   ||
      __ |__ __|   ||
     /  \   |      ||                                                                 ______
    /    \ /|\    _||_                                                            \\ |___ 0 |
   |     |/ | \____||                                                              \\  _|__|__
   |     |  |      ||                                                               \\/       \
    \    / / \                                                                       \\//      |
     \__/ |   |                                                                       \_______/
          |   |                                                                         ||  ||
";
        private const string swordsmanVsMinionDefendAttack1 = @"

          _____ /\
         |     |||
        _|__ __|||
       /  \ |   ||                              ______//
      /    \|\ _||_                            |___ 0//
     |     || \_||                               _|_//|__
     |     ||   ||                              /  //    \
      \    / \                                 | //      |
       \__/  |                                  \_______/
        /    /                                    ||  ||
";
        private const string swordsmanVsMinionDefendAttack2 = @"

       /\ _____ 
       |||     |
       |||__ __|    __
       ||   |      /  \\\   _______  
      _||_ /|\    /    \\\ |___ 0  |     
       ||_/ | \___|     |\\   _|_ |__ 
       ||   |     |     | \\ /       \
           / \    \    /   \\//      |
          /   |    \__/     \_______/
         /    |               ||  ||
";

        private const string swordsmanVsMinionDefendDefend0 = @"

          _____    /\
         |     |   ||
      __ |__ __|   ||
     /  \   |      ||                                                                 ______
    /    \ /|\    _||_                                                            \\ |___ 0 |
   |     |/ | \____||                                                              \\  _|__|__
   |     |  |      ||                                                               \\/       \
    \    / / \                                                                       \\//      |
     \__/ |   |                                                                       \_______/
          |   |                                                                         ||  ||
";
        private const string swordsmanVsMinionDefendDefend1 = @"

          _____ /\
         |     |||
        _|__ __|||
       /  \ |   ||                                                                    ______
      /    \|\ _||_                                                               \\ |___ 0 |
     |     || \_||                                                                 \\  _|__|__
     |     ||   ||                                                                  \\/       \
      \    / \                                                                       \\//      |
       \__/  |                                                                        \_______/
        /    /                                                                          ||  ||
";
        private const string swordsmanVsMinionDefendDefend2 = @"

     ? /\ _____   ?
       |||     |    ?                                                           ?        ?
   ?   |||__ __|    __                                                              ?             ?
       ||   |      /  \                                                      ?   ||  _______  ?
      _||_ /|\    /    \                                                         || |___ 0  |   ?   
       ||_/ | \___|     |                                                        ||    __|__|_ 
       ||   |     |     |                                                        ||__ /       \
           / \    \    /                                                         ||--|        |
          /   |    \__/                                                          ||  \_______/
         /    |                                                                        ||  ||
";
        //      Creeper
        private const string swordsmanVsCreeperAttackAttack0 = @"

          _____    /\
         |     |   ||
      __ |__ __|   ||                                                                  0        0
     /  \   |      ||                                                                   \      /
    /    \ /|\    _||_                                                                 __|____|__ 
   |     |/ | \____||                                                                 /          \
   |     |  |      ||                                                                 |    ||    |
    \    / / \                                                                        |\________/|
     \__/ |   |                                                                     //\__\/__\/__/\\
          |   |                                                                    // // ||  || \\ \\
";
        private const string swordsmanVsCreeperAttackAttack1 = @"

                                  __\\_
                                 |     |
                              __ |__ __|\                       0        0
                             /  \   |   \\                       \      /
                            /    \ /|\  /\\                     __|____|__ 
                           |     |/ | \/                       /          \
                           |     |  |                          |    ||    |
                           \    / / \                          |\________/|
                            \__/ /   |                       //\__\/__\/__/\\
                                /   /                       // // ||  || \\ \\ 
";
        private const string swordsmanVsCreeperAttackAttack2 = @"

                                          _____             
                                         |     |  0___            ___0  
                                      __ |__ __|    //\__________/   
                                     /  \   |      // /__  __  __\
                                    /    \ /|\    //  |  \/  \/  | 
                                   |     |/ | \  //   |          |
                                   |     |  |  \//    |          |
                                    \    / / \ //     |\_/\__/\_/|
                                     \__/ /   |     //\__________/\\
                                         /   /     // // ||  || \\ \\
";

        private const string swordsmanVsCreeperAttackDefend0 = @"

          _____    /\
         |     |   ||
      __ |__ __|   ||                                                                  0        0
     /  \   |      ||                                                                   \      /
    /    \ /|\    _||_                                                                 __|____|__ 
   |     |/ | \____||                                                                 /          \
   |     |  |      ||                                                                 |    ||    |
    \    / / \                                                                        |\________/|
     \__/ |   |                                                                     //\__\/__\/__/\\
          |   |                                                                    // // ||  || \\ \\
";
        private const string swordsmanVsCreeperAttackDefend1 = @"

                                               __\\_    
                                              |     |
                                           __ |__ __|\                                 0        0
                                          /  \   |   \\                                 \      /
                                         /    \ /|\  /\\                               __|____|__ 
                                        |     |/ | \/                                 /          \
                                        |     |  |                                    |    ||    |
                                         \    / / \                                   |\________/|
                                          \__/ /   |                                //\__\/__\/__/\\
                                              /   /                                // // ||  || \\ \\  
";
        private const string swordsmanVsCreeperAttackDefend2 = @"

                                                                        _____ 
                                                                       |     | 
                                                                    __ |__ __|    //  __       __ 
                                                                   /  \   |      //  0  \     /  0
                                                                  /    \ /|\    //     __|____|__ 
                                                                 |     |/ | \  //     /          \
                                                                 |     |  |  \//      |    ||    | //
                                                                  \    / / \ //       | _/\_/\_  |//
                                                                   \__/ /   |       //\/________\//
                                                                       /   /       // // ||  || \\ 
";

        private const string swordsmanVsCreeperDefendAttack0 = @"

          _____    /\
         |     |   ||
      __ |__ __|   ||                                                                  0        0
     /  \   |      ||                                                                   \      /
    /    \ /|\    _||_                                                                 __|____|__ 
   |     |/ | \____||                                                                 /          \
   |     |  |      ||                                                                 |    ||    |
    \    / / \                                                                        |\________/|
     \__/ |   |                                                                     //\__\/__\/__/\\
          |   |                                                                    // // ||  || \\ \\
";
        private const string swordsmanVsCreeperDefendAttack1 = @"

          _____ /\
         |     |||
        _|__ __|||                             0        0
       /  \ |   ||                              \      /
      /    \|\ _||_                            __|____|__  
     |     || \_||                            /          \
     |     ||   ||                            |    ||    |
      \    / \                                |\________/|
       \__/  |                              //\__\/__\/__/\\ 
        /    /                             // // ||  || \\ \\
";
        private const string swordsmanVsCreeperDefendAttack2 = @"

       /\ _____ 
       |||     |     0___            ___0 
       |||__ __|    __   \__________/ 
       ||   |      /  \  /__  __  __\ 
      _||_ /|\    /    \ |  \/  \/  | 
       ||_/ | \___|     ||          |
       ||   |     |     ||          | 
           / \    \    / |\_/\__/\_/|  
          /   |    \__///\__________/\\ 
         /    |       // // ||  || \\ \\ 
";

        private const string swordsmanVsCreeperDefendDefend0 = @"

          _____    /\
         |     |   ||
      __ |__ __|   ||                                                                  0        0
     /  \   |      ||                                                                   \      /
    /    \ /|\    _||_                                                                 __|____|__ 
   |     |/ | \____||                                                                 /          \
   |     |  |      ||                                                                 |    ||    |
    \    / / \                                                                        |\________/|
     \__/ |   |                                                                     //\__\/__\/__/\\
          |   |                                                                    // // ||  || \\ \\
";
        private const string swordsmanVsCreeperDefendDefend1 = @"

          _____ /\
         |     |||
        _|__ __|||                                                                     0        0
       /  \ |   ||                                                                      \      /
      /    \|\ _||_                                                                    __|____|__  
     |     || \_||                                                                    /          \
     |     ||   ||                                                                    |    ||    |
      \    / \                                                                        |\________/|
       \__/  |                                                                      //\__\/__\/__/\\ 
        /    /                                                                     // // ||  || \\ \\
";
        private const string swordsmanVsCreeperDefendDefend2 = @"

       /\ _____   ?                                                                        ?           ?
    ?  |||     |      ?                                                            ?               ?
       |||__ __| ?  __                                                                __     ? __     ?
  ?    ||   |      /  \  ?                                                    ?      0  \     /  0
      _||_ /|\    /    \                                                               __|____|__    ?
       ||_/ | \___|     |                                                         ?   /          \
       ||   |     |     |                                                             |    ||    | //
           / \    \    /                                                              | _/\_/\_  |//
          /   |    \__/                                                             //\/________\//
         /    |                                                                    // // ||  || \\
";
        //      Skeleton
        private const string swordsmanVsSkeletonAttackAttack0 = @"

          _____    /\
         |     |   ||
      __ |__ __|   ||                                                              ||   ________
     /  \   |      ||                                                              ||  /  0  0  \
    /    \ /|\    _||_                                                             ||  |   ||   |
   |     |/ | \____||                                                              ||   \ |__| /
   |     |  |      ||                                                             _||_  /|____|\
    \    / / \                                                                     ||__/ ==|==  \
     \__/ |   |                                                                    ||     =|=
          |   |                                                                           / \
";
        private const string swordsmanVsSkeletonAttackAttack1 = @"

                                  __\\_
                                 |     |                          //
                              __ |__ __|\                        //_______
                             /  \   |   \\                      //  0  0  \
                            /    \ /|\  /\\                    //|   ||   |
                           |     |/ | \/                      //  \ |__| /
                           |     |  |                        //   /|____|\
                           \    / / \                       // \_/ ==|==  \
                            \__/ /   |                              =|=
                                /   /                               / \
";
        private const string swordsmanVsSkeletonAttackAttack2 = @"

                                          _____
                                         |     |
                                      __ |__ __|    // ________
                                     /  \   |  \\  // /  0  0  \
                                    /    \ /|\  \\//  |   ||   |
                                   |     |/ | \  \/    \ |__| /
                                   |     |  |  \//\\   /|____|\
                                    \    / / \ //  \\_/ ==|==  \
                                     \__/ /   |          =|=
                                         /   /           / \
";

        private const string swordsmanVsSkeletonAttackDefend0 = @"

          _____    /\
         |     |   ||
      __ |__ __|   ||                                                              ||   ________
     /  \   |      ||                                                              ||  /  0  0  \
    /    \ /|\    _||_                                                             ||  |   ||   |
   |     |/ | \____||                                                              ||   \ |__| /
   |     |  |      ||                                                             _||_  /|____|\
    \    / / \                                                                     ||__/ ==|==  \
     \__/ |   |                                                                    ||     =|=
          |   |                                                                           / \
";
        private const string swordsmanVsSkeletonAttackDefend1 = @"

                                               __\\_
                                              |     |
                                           __ |__ __|\                             ||   ________
                                          /  \   |   \\                            ||  /  0  0  \
                                         /    \ /|\  /\\                           ||  |   ||   |
                                        |     |/ | \/                              ||   \ |__| /
                                        |     |  |                                _||_  /|____|\
                                         \    / / \                                ||__/ ==|==  \
                                          \__/ /   |                               ||     =|=
                                              /   /                                       / \
";
        private const string swordsmanVsSkeletonAttackDefend2 = @"

                                                                          _____
                                                                         |     |
                                                                      __ |__ __|    //|   ________
                                                                     /  \   |      //||  /  0  -- \
                                                                    /    \ /|\    // ||  |   ||   |
                                                                   |     |/ | \  //  ||   \ |__| /
                                                                   |     |  |  \//  _||_  /|____|\___
                                                                    \    / / \ //    ||__/==|==
                                                                     \__/ /   |      ||   =|=
                                                                         /   /            / \
";

        private const string swordsmanVsSkeletonDefendAttack0 = @"

          _____    /\
         |     |   ||
      __ |__ __|   ||                                                              ||   ________
     /  \   |      ||                                                              ||  /  0  0  \
    /    \ /|\    _||_                                                             ||  |   ||   |
   |     |/ | \____||                                                              ||   \ |__| /
   |     |  |      ||                                                             _||_  /|____|\
    \    / / \                                                                     ||__/ ==|==  \
     \__/ |   |                                                                    ||     =|=
          |   |                                                                           / \
";
        private const string swordsmanVsSkeletonDefendAttack1 = @"

          _____ /\
         |     |||                               //
        _|__ __|||                              //_______
       /  \ |   ||                             //  0  0  \
      /    \|\ _||_                           //|   ||   |
     |     || \_||                           //  \ |__| /
     |     ||   ||                          //   /|____|\
      \    / \                             // \_/ ==|==  \
       \__/  |                                     =|=
        /    /                                     / \
";
        private const string swordsmanVsSkeletonDefendAttack2 = @"

       /\ _____
       |||     |
       |||__ __|    __       ________
       ||   |      /  \     /  0  0  \
      _||_ /|\    /    \    |   ||   |
       ||_/ | \___|     |\   \ |__| /
       ||   |     |     |\\  /|____|\
           / \    \    /  \\_/ ==|==  \
          /   |    \__/         =|=
         /    |                 / \
";

        private const string swordsmanVsSkeletonDefendDefend0 = @"

          _____    /\
         |     |   ||
      __ |__ __|   ||                                                              ||   ________
     /  \   |      ||                                                              ||  /  0  0  \
    /    \ /|\    _||_                                                             ||  |   ||   |
   |     |/ | \____||                                                              ||   \ |__| /
   |     |  |      ||                                                             _||_  /|____|\
    \    / / \                                                                     ||__/ ==|==  \
     \__/ |   |                                                                    ||     =|=
          |   |                                                                           / \
";
        private const string swordsmanVsSkeletonDefendDefend1 = @"

          _____ /\
         |     |||
        _|__ __|||                                                                 ||   ________
       /  \ |   ||                                                                 ||  /  0  0  \
      /    \|\ _||_                                                                ||  |   ||   |
     |     || \_||                                                                 ||   \ |__| /
     |     ||   ||                                                                _||_  /|____|\
      \    / \                                                                     ||__/ ==|==  \
       \__/  |                                                                     ||     =|=
        /    /                                                                            / \
";
        private const string swordsmanVsSkeletonDefendDefend2 = @"

       /\ _____   ?                                                                     ?           ?
    ?  |||     |      ?                                                           ?         ?        ?
       |||__ __| ?  __                                                                ||   ________       ?
  ?    ||   |      /  \  ?                                                      ?     ||  /  0  -- \
      _||_ /|\    /    \                                                              ||  |   ||   |   ?
       ||_/ | \___|     |                                                             ||   \ |__| /
       ||   |     |     |                                                            _||_  /|____|\___
           / \    \    /                                                              ||__/==|==
          /   |    \__/                                                               ||   =|=
         /    |                                                                           / \
";
        //      Orc
        private const string swordsmanVsOrcAttackAttack0 = @"
                                                                           ___
          _____    /\                                                     /   |  _     ___________
         |     |   ||                                                    |    |_| |   / ___   ___ \
      __ |__ __|   ||                                                     \    _| |  |  \__| |__/  |
     /  \   |      ||                                                      \  | | |  |  _________  |
    /    \ /|\    _||_                                                      \_| | | /   /_\/__\/_\  \
   |     |/ | \____||                                                           | | \___         ___/
   |     |  |      ||                                                           | |/    \_______/    \
    \    / / \                                                                  |/   /  ___/\___  \    \
     \__/ |   |                                                                 /ppp/\_____________/\qqq\
          |   |                                                                       ddd__| |__bbb
";
        private const string swordsmanVsOrcAttackAttack1 = @"
                                                         ____
                                  __\\_                 |    \  ___________
                                 |     |                \  __| / ___   ___ \
                              __ |__ __|\               / /   |  \__| |__/  |
                             /  \   |   \\             / /    |  _________  |
                            /    \ /|\  /\\           / /    /   /_\/__\/_\  \
                           |     |/ | \/             / /\____\___         ___/
                           |     |  |               /_/ \_____   \_______/    \
                           \    / / \                        |   ___/\___  \    \
                            \__/ /   |                       \_____________/\qqq\
                                /   /                          ddd__| |__bbb
";
        private const string swordsmanVsOrcAttackAttack2 = @"

                                          _____            ___________
                                         |     |          / ___   ___ \
                                      __ |__ __|    //   |  \__| |__/  |
                                     /  \   |  \ \ //    |  _________  |
                                    /    \ /|\  \ //    /   /_\/__\/_\  \
                                   |     |/ | \  \/\    \___         ___/
                                   |     |  |  \//\ \   /    \_______/    \
                                    \    / / \ //  \ \/   /  ___/\___  \    \
                                     \__/ /   |      /ppp/\_____________/\qqq\
                                         /   /             ddd__| |__bbb
";

        private const string swordsmanVsOrcAttackDefend0 = @"
                                                                           ___
          _____    /\                                                     /   |  _     ___________
         |     |   ||                                                    |    |_| |   / ___   ___ \
      __ |__ __|   ||                                                     \    _| |  |  \__| |__/  |
     /  \   |      ||                                                      \  | | |  |  _________  |
    /    \ /|\    _||_                                                      \_| | | /   /_\/__\/_\  \
   |     |/ | \____||                                                           | | \___         ___/
   |     |  |      ||                                                           | |/    \_______/    \
    \    / / \                                                                  |/   /  ___/\___  \    \
     \__/ |   |                                                                 /ppp/\_____________/\qqq\
          |   |                                                                       ddd__| |__bbb
";
        private const string swordsmanVsORcAttackDefend1 = @"
                                                                           ___
                                               __\\_                      /   |  _     ___________
                                              |     |                    |    |_| |   / ___   ___ \
                                           __ |__ __|\                    \    _| |  |  \__| |__/  |
                                          /  \   |   \\                    \  | | |  |  _________  |
                                         /    \ /|\  /\\                    \_| | | /   /_\/__\/_\  \
                                        |     |/ | \/                           | | \___         ___/
                                        |     |  |                              | |/    \_______/    \
                                         \    / / \                             |/   /  ___/\___  \    \
                                          \__/ /   |                            /ppp/\_____________/\qqq\
                                              /   /                                   ddd__| |__bbb
";
        private const string swordsmanVsOrcAttackDefend2 = @"
                                                                              ___
                                                                        _____/  |  _      ___________
                                                                       |     |  |_| |    / ___       \
                                                                    __ |__ __|   _| |   |  \__|  === |
                                                                   /  \   |  \  | | |  |  _________  |
                                                                  /    \ /|\  \_| | | /   /_\/  \/_\  \
                                                                 |     |/ | \  // | | \___  \____/ ___/__
                                                                 |     |  |  \//  | |/   \_______/  __   \
                                                                  \    / / \ //  /   /  ___/\___  \ | \   \
                                                                   \__/ /   |   /ppp/\_____________/   \qqq\
                                                                       /   /        ddd__| |__bbb
";

        private const string swordsmanVsOrcDefendAttack0 = @"
                                                                           ___
          _____    /\                                                     /   |  _     ___________
         |     |   ||                                                    |    |_| |   / ___   ___ \
      __ |__ __|   ||                                                     \    _| |  |  \__| |__/  |
     /  \   |      ||                                                      \  | | |  |  _________  |
    /    \ /|\    _||_                                                      \_| | | /   /_\/__\/_\  \
   |     |/ | \____||                                                           | | \___         ___/
   |     |  |      ||                                                           | |/    \_______/    \
    \    / / \                                                                  |/   /  ___/\___  \    \
     \__/ |   |                                                                 /ppp/\_____________/\qqq\
          |   |                                                                       ddd__| |__bbb
";
        private const string swordsmanVsOrcDefendAttack1 = @"
                                         ____
          _____ /\                      |    \  ___________
         |     |||                      \  __| / ___   ___ \
        _|__ __|||                      / /   |  \__| |__/  |
       /  \ |   ||                     / /    |  _________  |
      /    \|\ _||_                   / /    /   /_\/__\/_\  \
     |     || \_||                   / /\____\___         ___/
     |     ||   ||                  /_/ \_____   \_______/    \
      \    / \                               |   ___/\___  \    \
       \__/  |                               \_____________/\qqq\
        /    /                                ddd__| |__bbb
";
        private const string swordsmanVsOrcDefendAttack2 = @"

       /\ _____               ___________
       |||     |             / ___   ___ \
       |||__ __|    __      |  \__| |__/  |
       ||   |      /  \     |  _________  |
      _||_ /|\    /    \   /   /_\/__\/_\  \
       ||_/ | \___|     |  \_____         _/___
       ||   |     |     |\  /    \_______/     \
           / \    \    /\ \/   /  ___/\___  \    \
          /   |    \__/   /ppp/\_____________/\qqq\
         /    |                  ddd__| |__bbb
";

        private const string swordsmanVsOrcDefendDefend0 = @"
                                                                           ___
          _____    /\                                                     /   |  _     ___________
         |     |   ||                                                    |    |_| |   / ___   ___ \
      __ |__ __|   ||                                                     \    _| |  |  \__| |__/  |
     /  \   |      ||                                                      \  | | |  |  _________  |
    /    \ /|\    _||_                                                      \_| | | /   /_\/__\/_\  \
   |     |/ | \____||                                                           | | \___         ___/
   |     |  |      ||                                                           | |/    \_______/    \
    \    / / \                                                                  |/   /  ___/\___  \    \
     \__/ |   |                                                                 /ppp/\_____________/\qqq\
          |   |                                                                       ddd__| |__bbb
";
        private const string swordsmanVsOrcDefendDefend1 = @"
                                                                           ___
          _____ /\                                                        /   |  _     ___________
         |     |||                                                       |    |_| |   / ___   ___ \
        _|__ __|||                                                        \    _| |  |  \__| |__/  |
       /  \ |   ||                                                         \  | | |  |  _________  |
      /    \|\ _||_                                                         \_| | | /   /_\/__\/_\  \
     |     || \_||                                                              | | \___         ___/
     |     ||   ||                                                              | |/    \_______/    \
      \    / \                                                                  |/   /  ___/\___  \    \
       \__/  |                                                                  /ppp/\_____________/\qqq\
        /    /                                                                        ddd__| |__bbb
";
        private const string swordsmanVsOrcDefendDefend2 = @"
                                                                             ___          ?         ?      ?
       /\ _____   ?                                                         /   |  _   ?  ___________    ?
    ?  |||     |      ?                                                ?   |    |_| |    / ___       \      ?
       |||__ __| ?  __                                                      \    _| |   |  \__|  === |  ?
  ?    ||   |      /  \  ?                                                   \  | | |  |  _________  |
      _||_ /|\    /    \                                                      \_| | | /   /_\/  \/_\  \
       ||_/ | \___|     |                                                         | | \___  \____/ ___/__
       ||   |     |     |                                                         | |/   \_______/  __   \
           / \    \    /                                                         /   /  ___/\___  \ | \   \
          /   |    \__/                                                         /ppp/\_____________/   \qqq\
         /    |                                                                     ddd__| |__bbb 
";
        // RANGER ANIMANTION CLIPS
        //      Minion
        private const string rangerVsMinionAttackAttack0 = @"

          _____   
         |     ||\ 
         |__ __|| \
            |   |  |                                                                  ______
           /|\  |  |                                                              \\ |___ 0 |
          / | \_|__|                                                               \\  _|__|__
         /  |   |  |                                                                \\/       \
           / \  |  |                                                                 \\//      |
          |   | | /                                                                   \_______/
          |   | |/                                                                      ||  ||
";
        private const string rangerVsMinionAttackAttack1 = @"

          _____   
         |     ||\ 
         |__ __|| \
            |  /   \                            ______//
           /|\/     \                          |___ 0//
           \| \______|    \\\\\________|\_       _|_//|__
            |\      /     /////        |/       /  //    \
           / \\    /                           | //      |
          |   |\  /                             \_______/
          |   | |/                                ||  ||
";
        private const string rangerVsMinionAttackAttack2 = @" 

          _____   
         |     ||\ 
         |__ __|| \_
            |   |  |\   _______  
           /|\  |  |\\ |___ 0  |  
          / | \_|__| \\   _|_ |__ 
         /  |   |  |  \\ /       \
           / \  |  |   \\//      |
          |   | | /     \_______/
          |   | |/        ||  ||
";

        private const string rangerVsMinionAttackDefend0 = @"

          _____   
         |     ||\ 
         |__ __|| \
            |   |  |                                                                  ______
           /|\  |  |                                                              \\ |___ 0 |
          / | \_|__|                                                               \\  _|__|__
         /  |   |  |                                                                \\/       \
           / \  |  |                                                                 \\//      |
          |   | | /                                                                   \_______/
          |   | |/                                                                      ||  ||
";
        private const string rangerVsMinionAttackDefend1 = @"

          _____   
         |     ||\ 
         |__ __|| \
            |  /   \                                                                  ______
           /|\/     \                                                             \\ |___ 0 |
           \| \______|                  \\\\\________|\_                           \\  _|__|__
            |\      /                   /////        |/                             \\/       \
           / \\    /                                                                 \\//      |
          |   |\  /                                                                   \_______/
          |   | |/                                                                      ||  ||
";
        private const string rangerVsMinionAttackDefend2 = @"

          _____   
         |     ||\ 
         |__ __|| \
            |   |  |                                                             ||  _______ 
           /|\  |  |                                                             || |___ 0  |  
          / | \_|__|                                               \\\\\________|||    __|__|_ 
         /  |   |  |                                               /////        |||__ /       \
           / \  |  |                                                             ||--|        |
          |   | | /                                                              ||  \_______/
          |   | |/                                                                     ||  ||
";

        private const string rangerVsMinionDefendAttack0 = @"

          _____   
         |     ||\ 
         |__ __|| \
            |   |  |                                                                  ______
           /|\  |  |                                                              \\ |___ 0 |
          / | \_|__|                                                               \\  _|__|__
         /  |   |  |                                                                \\/       \
           / \  |  |                                                                 \\//      |
          |   | | /                                                                   \_______/
          |   | |/                                                                      ||  ||
";
        private const string rangerVsMinionDefendAttack1 = @"

          _____   
         |     ||\ 
         |__ __|| \
            |   |  |                            ______//
           /|\  |  |                           |___ 0//
        __/ | \_|__|                             _|_//|__
            |   |  |                            /  //    \
           / \  |  |                           | //      |
          |   \ | /                             \_______/
          |    \|/                                ||  ||
";
        private const string rangerVsMinionDefendAttack2 = @"

         _____  |\ 
        |     | | \ 
        |__ __| |  \
           \    |  |   _______  
           /|\__|__|\ |___ 0  |  
        __/ |   |  |\\   _|_ |__ 
            |   |  | \\ /       \
           / \  | /   \\//      |
          /   \ |/     \_______/
         /     \         ||  ||
";

        private const string rangerVsMinionDefendDefend0 = @"

          _____   
         |     ||\ 
         |__ __|| \
            |   |  |                                                                  ______
           /|\  |  |                                                              \\ |___ 0 |
          / | \_|__|                                                               \\  _|__|__
         /  |   |  |                                                                \\/       \
           / \  |  |                                                                 \\//      |
          |   | | /                                                                   \_______/
          |   | |/                                                                      ||  ||
";
        private const string rangerVsMinionDefendDefend1 = @"

          _____   
         |     ||\ 
         |__ __|| \
            |   |  |                                                                  ______
           /|\  |  |                                                              \\ |___ 0 |
        __/ | \_|__|                                                               \\  _|__|__
            |   |  |                                                                \\/       \
           / \  |  |                                                                 \\//      |
          |   \ | /                                                                   \_______/
          |    \|/                                                                      ||  ||
";
        private const string rangerVsMinionDefendDefend2 = @"

      ?  _____  |\   ?
  ?     |     | | \     ?                                                       ?        ?
        |__ __| |  \                                                                ?             ?
    ?      \    |  |  ?                                                      ?   ||  _______  ?
           /|\__|__|                                                             || |___ 0  |   ?  
        __/ |   |  |                                                             ||    __|__|_ 
            |   |  |                                                             ||__ /       \
           / \  | /                                                              ||--|        |
          /   \ |/                                                               ||  \_______/
         /     \                                                                       ||  ||
";
        //      Creeper
        private const string rangerVsCreeperAttackAttack0 = @"

          _____   
         |     ||\ 
         |__ __|| \                                                                    0        0
            |   |  |                                                                    \      /
           /|\  |  |                                                                   __|____|__ 
          / | \_|__|                                                                  /          \
         /  |   |  |                                                                  |    ||    |
           / \  |  |                                                                  |\________/|
          |   | | /                                                                 //\__\/__\/__/\\
          |   | |/                                                                 // // ||  || \\ \\
";
        private const string rangerVsCreeperAttackAttack1 = @"

          _____   
         |     ||\ 
         |__ __|| \                            0        0
            |  /   \                            \      /
           /|\/     \                          __|____|__ 
           \| \______|    \\\\\________|\_    /          \
            |\      /     /////        |/     |    ||    |
           / \\    /                          |\________/|
          |   |\  /                         //\__\/__\/__/\\
          |   | |/                         // // ||  || \\ \\ 
";
        private const string rangerVsCreeperAttackAttack2 = @"

          _____   
         |     ||\ 0___            ___0
         |__ __|| \    \__________/   
            |   |  |   /__  __  __\
           /|\  |  |   |  \/  \/  | 
          / | \_|__|   |          |
         /  |   |  |   |          |
           / \  |  |   |\_/\__/\_/|
          |   | | /  //\__________/\\
          |   | |/  // // ||  || \\ \\
";

        private const string rangerVsCreeperAttackDefend0 = @"

          _____   
         |     ||\ 
         |__ __|| \                                                                    0        0
            |   |  |                                                                    \      /
           /|\  |  |                                                                   __|____|__ 
          / | \_|__|                                                                  /          \
         /  |   |  |                                                                  |    ||    |
           / \  |  |                                                                  |\________/|
          |   | | /                                                                 //\__\/__\/__/\\
          |   | |/                                                                 // // ||  || \\ \\
";
        private const string rangerVsCreeperAttackDefend1 = @"

          _____   
         |     ||\ 
         |__ __|| \                                                                    0        0
            |  /   \                                                                    \      /
           /|\/     \                                                                  __|____|__ 
           \| \______|                  \\\\\________|\_                              /          \
            |\      /                   /////        |/                               |    ||    |
           / \\    /                                                                  |\________/|
          |   |\  /                                                                 //\__\/__\/__/\\
          |   | |/                                                                 // // ||  || \\ \\ 
";
        private const string rangerVsCreeperAttackDefend2 = @"

          _____   
         |     ||\ 
         |__ __|| \                                                                    __       __ 
            |   |  |                                                                  0  \     /  0
           /|\  |  |                                                                   __|____|__ 
          / | \_|__|                                                    \\\\\________|/          \
         /  |   |  |                                                    /////        ||    ||    | //
           / \  |  |                                                                  | _/\_/\_  |//
          |   | | /                                                                 //\/________\//
          |   | |/                                                                 // // ||  || \\ 
";

        private const string rangerVsCreeperDefendAttack0 = @"

          _____   
         |     ||\ 
         |__ __|| \                                                                    0        0
            |   |  |                                                                    \      /
           /|\  |  |                                                                   __|____|__ 
          / | \_|__|                                                                  /          \
         /  |   |  |                                                                  |    ||    |
           / \  |  |                                                                  |\________/|
          |   | | /                                                                 //\__\/__\/__/\\
          |   | |/                                                                 // // ||  || \\ \\
";
        private const string rangerVsCreeperDefendAttack1 = @"

          _____   
         |     ||\ 
         |__ __|| \                            0        0
            |   |  |                            \      /
           /|\  |  |                           __|____|__  
        __/ | \_|__|                          /          \
            |   |  |                          |    ||    |
           / \  |  |                          |\________/|
          |   \ | /                         //\__\/__\/__/\\ 
          |    \|/                         // // ||  || \\ \\
";
        private const string rangerVsCreeperDefendAttack2 = @"

         _____  |\ 
        |     | | \ 0___            ___0
        |__ __| |  \    \__________/ 
           \    |  |    /__  __  __\ 
           /|\__|__|    |  \/  \/  | 
        __/ |   |  |    |          |
            |   |  |    |          | 
           / \  | /     |\_/\__/\_/|  
          /   \ |/    //\__________/\\ 
         /     \     // // ||  || \\ \\ 
";

        private const string rangerVsCreeperDefendDefend0 = @"

          _____   
         |     ||\ 
         |__ __|| \                                                                    0        0
            |   |  |                                                                    \      /
           /|\  |  |                                                                   __|____|__ 
          / | \_|__|                                                                  /          \
         /  |   |  |                                                                  |    ||    |
           / \  |  |                                                                  |\________/|
          |   | | /                                                                 //\__\/__\/__/\\
          |   | |/                                                                 // // ||  || \\ \\
";
        private const string rangerVsCreeperDefendDefend1 = @"

          _____   
         |     ||\ 
         |__ __|| \                                                                    0        0
            |   |  |                                                                    \      /
           /|\  |  |                                                                   __|____|__  
        __/ | \_|__|                                                                  /          \
            |   |  |                                                                  |    ||    |
           / \  |  |                                                                  |\________/|
          |   \ | /                                                                 //\__\/__\/__/\\ 
          |    \|/                                                                 // // ||  || \\ \\
";
        private const string rangerVsCreeperDefendDefend2 = @"

      ?  _____  |\   ?                                                                      ?           ?
  ?     |     | | \     ?                                                         ?               ?
        |__ __| |  \                                                                  __     ? __     ?
    ?      \    |  |  ?                                                       ?      0  \     /  0
           /|\__|__|                                                                   __|____|__    ?
        __/ |   |  |                                                              ?   /          \
            |   |  |                                                                  |    ||    | //
           / \  | /                                                                   | _/\_/\_  |//
          /   \ |/                                                                  //\/________\//
         /     \                                                                   // // ||  || \\
";
        //      Skeleton
        private const string rangerVsSkeletonAttackAttack0 = @"

          _____
         |     ||\
         |__ __|| \                                                                ||   ________
            |   |  |                                                               ||  /  0  0  \
           /|\  |  |                                                               ||  |   ||   |
          / | \_|__|                                                               ||   \ |__| /
         /  |   |  |                                                              _||_  /|____|\
           / \  |  |                                                               ||__/ ==|==  \
          |   | | /                                                                ||     =|=
          |   | |/                                                                        / \
";
        private const string rangerVsSkeletonAttackAttack1 = @"

          _____
         |     ||\                               //
         |__ __|| \                             //_______
            |  /   \                           //  0  0  \
           /|\/     \                         //|   ||   |
           \| \______|    \\\\\________|\_   //  \ |__| /
            |\      /     /////        |/   //   /|____|\
           / \\    /                       // \_/ ==|==  \
          |   |\  /                                =|=
          |   | |/                                 / \
";
        private const string rangerVsSkeletonAttackAttack2 = @"

          _____
         |     ||\
         |__ __|| \      ________
            |   |  |    /  0  0  \
           /|\  |  |    |   ||   |
          / | \_|__|\   \ |__| /
         /  |   |  |\\  /|____|\
           / \  |  | \\_/ ==|==  \
          |   | | /         =|=
          |   | |/          / \
";

        private const string rangerVsSkeletonAttackDefend0 = @"

          _____
         |     ||\
         |__ __|| \                                                                ||   ________
            |   |  |                                                               ||  /  0  0  \
           /|\  |  |                                                               ||  |   ||   |
          / | \_|__|                                                               ||   \ |__| /
         /  |   |  |                                                              _||_  /|____|\
           / \  |  |                                                               ||__/ ==|==  \
          |   | | /                                                                ||     =|=
          |   | |/                                                                        / \
";
        private const string rangerVsSkeletonAttackDefend1 = @"

          _____
         |     ||\
         |__ __|| \                                                                ||   ________
            |  /   \                                                               ||  /  0  0  \
           /|\/     \                                                              ||  |   ||   |
           \| \______|                  \\\\\________|\_                           ||   \ |__| /
            |\      /                   /////        |/                           _||_  /|____|\
           / \\    /                                                               ||__/ ==|==  \
          |   |\  /                                                                ||     =|=
          |   | |/                                                                        / \
";
        private const string rangerVsSkeletonAttackDefend2 = @"

          _____
         |     ||\
         |__ __|| \                                                                  ||   ________
            |   |  |                                                                 ||  /  0  -- \
           /|\  |  |                                                                 ||  |   ||   |
          / | \_|__|                                                   \\\\\________|||   \ |__| /
         /  |   |  |                                                   /////        |||_  /|____|\___
           / \  |  |                                                                 ||__/==|==
          |   | | /                                                                  ||   =|=
          |   | |/                                                                        / \
";

        private const string rangerVsSkeletonDefendAttack0 = @"

          _____
         |     ||\
         |__ __|| \                                                                ||   ________
            |   |  |                                                               ||  /  0  0  \
           /|\  |  |                                                               ||  |   ||   |
          / | \_|__|                                                               ||   \ |__| /
         /  |   |  |                                                              _||_  /|____|\
           / \  |  |                                                               ||__/ ==|==  \
          |   | | /                                                                ||     =|=
          |   | |/                                                                        / \
";
        private const string rangerVsSkeletonDefendAttack1 = @"

          _____
         |     ||\                               //
         |__ __|| \                             //_______
            |   |  |                           //  0  0  \
           /|\  |  |                          //|   ||   |
        __/ | \_|__|                         //  \ |__| /
            |   |  |                        //   /|____|\
           / \  |  |                       // \_/ ==|==  \ 
          |   \ | /                                =|=
          |    \|/                                 / \
";
        private const string rangerVsSkeletonDefendAttack2 = @"

         _____  |\
        |     | | \
        |__ __| |  \      ________
           \    |  |     /  0  0  \
           /|\__|__|\    |   ||   |
        __/ |   |  |\\    \ |__| /
            |   |  | \\   /|____|\
           / \  | /   \\_/ ==|==  \
          /   \ |/          =|=
         /     \            / \
";

        private const string rangerVsSkeletonDefendDefend0 = @"

          _____
         |     ||\
         |__ __|| \                                                                ||   ________
            |   |  |                                                               ||  /  0  0  \
           /|\  |  |                                                               ||  |   ||   |
          / | \_|__|                                                               ||   \ |__| /
         /  |   |  |                                                              _||_  /|____|\
           / \  |  |                                                               ||__/ ==|==  \
          |   | | /                                                                ||     =|=
          |   | |/                                                                        / \
";
        private const string rangerVsSkeletonDefendDefend1 = @"

          _____
         |     ||\
         |__ __|| \                                                                ||   ________
            |   |  |                                                               ||  /  0  0  \
           /|\  |  |                                                               ||  |   ||   |
        __/ | \_|__|                                                               ||   \ |__| /
            |   |  |                                                              _||_  /|____|\
           / \  |  |                                                               ||__/ ==|==  \
          |   \ | /                                                                ||     =|=
          |    \|/                                                                        / \
";
        private const string rangerVsSkeletonDefendDefend2 = @"

      ?  _____  |\   ?                                                                  ?           ?
  ?     |     | | \     ?                                                         ?         ?        ?
        |__ __| |  \                                                                  ||   ________       ?
    ?      \    |  |  ?                                                         ?     ||  /  0  -- \
           /|\__|__|                                                                  ||  |   ||   |   ?
        __/ |   |  |                                                                  ||   \ |__| /
            |   |  |                                                                 _||_  /|____|\___
           / \  | /                                                                   ||__/==|==
          /   \ |/                                                                    ||   =|=
         /     \                                                                          / \
";
        //      Orc
        private const string rangerVsOrcAttackAttack0 = @"
                                                                           ___
          _____                                                           /   |  _     ___________
         |     ||\                                                       |    |_| |   / ___   ___ \
         |__ __|| \                                                       \    _| |  |  \__| |__/  |
            |   |  |                                                       \  | | |  |  _________  |
           /|\  |  |                                                        \_| | | /   /_\/__\/_\  \
          / | \_|__|                                                            | | \___         ___/
         /  |   |  |                                                            | |/    \_______/    \
           / \  |  |                                                            |/   /  ___/\___  \    \
          |   | | /                                                             /ppp/\_____________/\qqq\
          |   | |/                                                                    ddd__| |__bbb
";
        private const string rangerVsOrcAttackAttack1 = @"
                                                         ____
          _____                                         |    \  ___________
         |     ||\                                      \  __| / ___   ___ \
         |__ __|| \                                     / /   |  \__| |__/  |
            |  /   \                                   / /    |  _________  |
           /|\/     \                                 / /    /   /_\/__\/_\  \
           \| \______|    \\\\\________|\_           / /\____\___         ___/
            |\      /     /////        |/           /_/ \_____   \_______/    \
           / \\    /                                         |   ___/\___  \    \
          |   |\  /                                          \_____________/\qqq\
          |   | |/                                             ddd__| |__bbb
";
        private const string rangerVsOrcAttackAttack2 = @"

          _____           ___________ 
         |     ||\       / ___   ___ \
         |__ __|| \     |  \__| |__/  |
            |   |  |    |  _________  |
           /|\  |  |   /   /_\/__\/_\  \
          / | \_|__|\  \_____         _/___
         /  |   |  | \  /    \_______/     \
           / \  |  |\ \/   /  ___/\___  \    \
          |   | | /  \/ppp/\_____________/\qqq\
          |   | |/           ddd__| |__bbb
";

        private const string rangerVsOrcAttackDefend0 = @"
                                                                           ___
          _____                                                           /   |  _     ___________
         |     ||\                                                       |    |_| |   / ___   ___ \
         |__ __|| \                                                       \    _| |  |  \__| |__/  |
            |   |  |                                                       \  | | |  |  _________  |
           /|\  |  |                                                        \_| | | /   /_\/__\/_\  \
          / | \_|__|                                                            | | \___         ___/
         /  |   |  |                                                            | |/    \_______/    \
           / \  |  |                                                            |/   /  ___/\___  \    \
          |   | | /                                                             /ppp/\_____________/\qqq\
          |   | |/                                                                    ddd__| |__bbb
";
        private const string rangerVsOrcAttackDefend1 = @"
                                                                           ___
          _____                                                           /   |  _     ___________
         |     ||\                                                       |    |_| |   / ___   ___ \
         |__ __|| \                                                       \    _| |  |  \__| |__/  |
            |  /   \                                                       \  | | |  |  _________  |
           /|\/     \                                                       \_| | | /   /_\/__\/_\  \
           \| \______|                  \\\\\________|\_                        | | \___         ___/
            |\      /                   /////        |/                         | |/    \_______/    \
           / \\    /                                                            |/   /  ___/\___  \    \
          |   |\  /                                                             /ppp/\_____________/\qqq\
          |   | |/                                                                    ddd__| |__bbb
";
        private const string rangerVsOrcAttackDefend2 = @"
                                                                              ___
          _____                                                              /  |  _      ___________
         |     ||\                                                           |  |_| |    / ___       \
         |__ __|| \                                                          |   _| |   |  \__|  === |
            |   |  |                                                         \  | | |  |  _________  |
           /|\  |  |                                                          \_| | | /   /_\/  \/_\  \
          / | \_|__|                                                \\\\\________|| | \___  \____/ ___/__
         /  |   |  |                                                /////        || |/   \_______/  __   \
           / \  |  |                                                             /   /  ___/\___  \ | \   \
          |   | | /                                                             /ppp/\_____________/   \qqq\
          |   | |/                                                                  ddd__| |__bbb
";

        private const string rangerVsOrcDefendAttack0 = @"
                                                                           ___
          _____                                                           /   |  _     ___________
         |     ||\                                                       |    |_| |   / ___   ___ \
         |__ __|| \                                                       \    _| |  |  \__| |__/  |
            |   |  |                                                       \  | | |  |  _________  |
           /|\  |  |                                                        \_| | | /   /_\/__\/_\  \
          / | \_|__|                                                            | | \___         ___/
         /  |   |  |                                                            | |/    \_______/    \
           / \  |  |                                                            |/   /  ___/\___  \    \
          |   | | /                                                             /ppp/\_____________/\qqq\
          |   | |/                                                                    ddd__| |__bbb
";
        private const string rangerVsOrcDefendAttack1 = @"
                                         _____
          _____                         |    \  ___________
         |     ||\                      \  __| / ___   ___ \
         |__ __|| \                     / /   |  \__| |__/  |
            |   |  |                   / /    |  _________  |
           /|\  |  |                  / /    /   /_\/__\/_\  \
        __/ | \_|__|                 / /\____\___         ___/
            |   |  |                /_/ \_____   \_______/    \
           / \  |  |                         |   ___/\___  \    \
          |   \ | /                          \_____________/\qqq\
          |    \|/                            ddd__| |__bbb
";
        private const string rangerVsOrcDefendAttack2 = @"

         _____  |\          ___________
        |     | | \        / ___   ___ \
        |__ __| |  \      |  \__| |__/  |
           \    |  |\     |  _________  |
           /|\__|__| \   /   /_\/__\/_\  \
        __/ |   |  |\ \  \_____         _/___
            |   |  | \ \  /    \_______/     \
           / \  | /   \ \/   /  ___/\___  \    \
          /   \ |/      /ppp/\_____________/\qqq\
         /     \               ddd__| |__bbb
";

        private const string rangerVsOrcDefendDefend0 = @"
                                                                           ___
          _____                                                           /   |  _     ___________
         |     ||\                                                       |    |_| |   / ___   ___ \
         |__ __|| \                                                       \    _| |  |  \__| |__/  |
            |   |  |                                                       \  | | |  |  _________  |
           /|\  |  |                                                        \_| | | /   /_\/__\/_\  \
          / | \_|__|                                                            | | \___         ___/
         /  |   |  |                                                            | |/    \_______/    \
           / \  |  |                                                            |/   /  ___/\___  \    \
          |   | | /                                                             /ppp/\_____________/\qqq\
          |   | |/                                                                    ddd__| |__bbb
";
        private const string rangerVsOrcDefendDefend1 = @"
                                                                           ___
          _____                                                           /   |  _     ___________
         |     ||\                                                       |    |_| |   / ___   ___ \
         |__ __|| \                                                       \    _| |  |  \__| |__/  |
            |   |  |                                                       \  | | |  |  _________  |
           /|\  |  |                                                        \_| | | /   /_\/__\/_\  \
        __/ | \_|__|                                                            | | \___         ___/
            |   |  |                                                            | |/    \_______/    \
           / \  |  |                                                            |/   /  ___/\___  \    \
          |   \ | /                                                             /ppp/\_____________/\qqq\
          |    \|/                                                                    ddd__| |__bbb
";
        private const string rangerVsOrcDefendDefend2 = @"
                                                                          ?  ___          ?         ?      ?
      ?  _____  |\   ?                                                      /   |  _   ?  ___________    ?
  ?     |     | | \     ?                                              ?   |    |_| |    / ___       \      ?
        |__ __| |  \                                                        \    _| |   |  \__|  === |  ?
    ?      \    |  |  ?                                                      \  | | |  |  _________  |
           /|\__|__|                                                          \_| | | /   /_\/  \/_\  \
        __/ |   |  |                                                              | | \___  \____/ ___/__
            |   |  |                                                              | |/   \_______/  __   \
           / \  | /                                                              /   /  ___/\___  \ | \   \
          /   \ |/                                                              /ppp/\_____________/   \qqq\
         /     \                                                                    ddd__| |__bbb
";




    }
}
