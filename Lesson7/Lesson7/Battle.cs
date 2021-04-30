using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Lesson7
{
    public class Battle
    {
        public Transformer firstFighter;
        public Transformer secondFighter;

        public static void Fight(Transformer firstFighter, Transformer secondFighter)
        {
            firstFighter.Transform();
            secondFighter.Transform();
            firstFighter.FindEnemy();
            secondFighter.FindEnemy();

            WriteLine("\n fIGHT! fIGHT! fIGHT! fIGHT! fIGHT! fIGHT! fIGHT! fIGHT! fIGHT! fIGHT! \n");
            while (firstFighter.HitPoint > 0 & secondFighter.HitPoint > 0)
            {
                Random numberOf = new Random();
                var fighter = numberOf.Next(1, 3);

                if (fighter == 1)
                {
                    WriteLine($"\n{firstFighter.Name}'s move.");
                    firstFighter.Fire();
                    LoseHitPoints(secondFighter);
                }
                else
                {
                    WriteLine($"\n{secondFighter.Name}'s move.");
                    secondFighter.Fire();
                    LoseHitPoints(firstFighter);
                }
            }

            var strickenTransformer = firstFighter.HitPoint <= 0 ? (secondFighter) : (firstFighter);
            WriteLine($"{strickenTransformer.Name} won.");
        }

        public static void LoseHitPoints(Transformer fighter)
        {
            fighter.HitPoint -= Weapon.Damage;

            if (fighter.HitPoint <= 0)
                WriteLine($"\n{fighter.Name} is died.");
            else
                WriteLine($"\n{fighter.Name}'s hit points: {fighter.HitPoint}");
        }
    }
}
