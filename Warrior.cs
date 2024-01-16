using OOP.Enum;
using OOP.Equipment;

namespace OOP
{
    class Warrior
    {
        private const int GOOD_GUY_STARTING_HEALTH = 20;
        private const int BAD_GUY_STARTING_HEALTH = 20;
        private readonly Faction FACTION;

        private int health;
        private string name;
        private bool isAlive;

        public bool IsAlive
        {
            get
            {
                return isAlive;
            }
        }

        private Weapon weapon;
        private Armor armor;

        public Warrior(string Name, Faction Faction)
        {
            name = Name;
            FACTION = Faction;
            isAlive = true;

            switch(Faction)
            {
                case Faction.Goodguy:
                    weapon = new Weapon(Faction);
                    armor = new Armor(Faction);
                    health = GOOD_GUY_STARTING_HEALTH;
                    break;
                case Faction.Badguy:
                    weapon = new Weapon(Faction);
                    armor = new Armor(Faction);
                    health = BAD_GUY_STARTING_HEALTH;
                    break;
                default:
                    break;
            }
        }

        public void Attack(Warrior enemy)
        {
            int damage = weapon.Damage / enemy.armor.ArmorPoints;

            enemy.health -= damage;
            AttackResult(enemy, damage);
        }

        private void AttackResult(Warrior enemy, int damage)
        {
            if(enemy.health <= 0)
            {
                enemy.isAlive = false;
                Tools.ColerfulWriteLine($"{enemy.name} is dead!", ConsoleColor.Red);
                Tools.ColerfulWriteLine($"{name} is victorius!", ConsoleColor.Green);
            } else {
                Console.WriteLine($"{name} attacked {enemy.name}. {damage} damage was inflicted to {enemy.name}, remaining health of {enemy.name} is {enemy.health}");
            }
            Thread.Sleep(100);
        }
    }
}