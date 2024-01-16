using OOP.Enum;

namespace OOP.Equipment
{
    class Armor
    {
        private const int GOOD_GUY_ARMOR = 5;
        private const int BAD_GUY_ARMOR = 5;
        private int armorPoints;

        public int ArmorPoints
        {
            get
            {
                return armorPoints;
            }
        }

        public Armor(Faction Faction)
        {
            switch(Faction)
            {
                case Faction.Goodguy:
                    armorPoints = GOOD_GUY_ARMOR;
                    break;
                case Faction.Badguy:
                    armorPoints = BAD_GUY_ARMOR;
                    break;
                default:
                    break;
            }
        }
    }
}