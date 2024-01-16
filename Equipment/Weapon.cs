using OOP.Enum;

namespace OOP.Equipment
{
    class Weapon
    {
        private const int GOOD_GUY_DAMAGE = 5;
        private const int BAD_GUY_DAMAGE = 5;
        private int damage;

        public int Damage
        {
            get
            {
                return damage;
            }
        }

        public Weapon(Faction Faction)
        {
            switch(Faction)
            {
                case Faction.Goodguy:
                    damage = GOOD_GUY_DAMAGE;
                    break;
                case Faction.Badguy:
                    damage = BAD_GUY_DAMAGE;
                    break;
                default:
                    break;
            }
        }
    }
}