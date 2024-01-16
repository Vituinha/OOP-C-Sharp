using System;
using OOP.Enum;

namespace OOP
{
    public class Program
    {
        static Random rng = new Random();
        static void Main(string[] args)
        {
            Warrior goodGuy = new Warrior("Bob", Faction.Goodguy);
            Warrior badGuy = new Warrior("Joe", Faction.Badguy);

            while(goodGuy.IsAlive && badGuy.IsAlive)
            {
                if(rng.Next(0, 10) < 5)
                {
                    goodGuy.Attack(badGuy);
                } else {
                    badGuy.Attack(goodGuy);
                }
            }
        }
    }
}