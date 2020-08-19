using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleStage.Enums;

namespace BattleStage.Equipment.Items
{
    class PotionItem
    {
        protected string itemName;
        protected string itemDescription;
        protected string propertyType;

        protected PotionTypes potionTypes;

        protected int propertiesOfPotionItem;

        public PotionItem(int potionTypeGenerated, int potionStrength)
        {
            itemName = PotionType(potionTypeGenerated);
            //propertyType = "Health";

            propertiesOfPotionItem = PotionStrength(potionStrength, potionTypes);
            itemDescription = PotionDescription(potionTypes, potionStrength);
        }
        public PotionItem()
        {
            itemName = "None";
            itemDescription = string.Empty;

            propertiesOfPotionItem = 0;
        }
        public PotionTypes PotionTypes
        {
            get { return potionTypes; }
        }

        public string ITEM_NAME
        {
            get
            {
                return itemName;
            }
        }
        public string ITEM_DESCRIPTION
        {
            get
            {
                return itemDescription;
            }
        }
        public string ITEM_PROPERTY_TYPE
        {
            get
            {
                return propertyType;
            }
        }
        public int ITEM_PROPERTIES
        {
            get
            {
                return propertiesOfPotionItem;
            }
        }

        private string PotionType(int potionTypeGenerated)
        {
            if (potionTypeGenerated == 1)
            {
                potionTypes = PotionTypes.Health;
                return "Health Potion";
            }
            else if (potionTypeGenerated == 2)
            {
                potionTypes = PotionTypes.Defence;
                return "Defence Potion";
            }
            else
            {
                potionTypes = PotionTypes.Attack;
                return "Attack Potion";
            }
        }

        private string PotionDescription(PotionTypes potionTypes, int potionStrengthGenerated)
        {
            switch (potionTypes)
            {
                case PotionTypes.Health:
                    if (potionStrengthGenerated == 1)
                    {
                        return "A small health potion";
                    }
                    else if (potionStrengthGenerated == 2)
                    {
                        return "A medium health potion";
                    }
                    else
                    {
                        return "A large health potion";
                    }
                case PotionTypes.Defence:
                    if (potionStrengthGenerated == 1)
                    {
                        return "A small Defence potion";
                    }
                    else if (potionStrengthGenerated == 2)
                    {
                        return "A medium Defence potion";
                    }
                    else
                    {
                        return "A large Defence potion";
                    }
                case PotionTypes.Attack:
                    if (potionStrengthGenerated == 1)
                    {
                        return "A small Strength potion";
                    }
                    else if (potionStrengthGenerated == 2)
                    {
                        return "A medium Strength potion";
                    }
                    else
                    {
                        return "A large Strength potion";
                    }
                default:
                    return "A empty vial";
            }
        }

        private int PotionStrength(int potionStrengthGenerated, PotionTypes potionTypes)
        {
            switch (potionTypes)
            {
                case PotionTypes.Health:
                    if (potionStrengthGenerated == 1)
                    {
                        return 20;
                    }
                    else if (potionStrengthGenerated == 2)
                    {
                        return 60;
                    }
                    else
                    {
                        return 100;
                    }
                case PotionTypes.Defence:
                    if (potionStrengthGenerated == 1)
                    {
                        return 5;
                    }
                    else if (potionStrengthGenerated == 2)
                    {
                        return 10;
                    }
                    else
                    {
                        return 20;
                    }
                case PotionTypes.Attack:
                    if (potionStrengthGenerated == 1)
                    {
                        return 5;
                    }
                    else if (potionStrengthGenerated == 2)
                    {
                        return 10;
                    }
                    else
                    {
                        return 20;
                    }
                default:
                    return 0;
            }
        }
    }
}
