using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Lesson7
{
    public class LaserWeapon : Weapon
    {
        public override void Reload()
        {
            if (Ammo == 0)
            {
                Ammo += 6;
                WriteLine($"I am recharging the blaster. The weapon now has {Ammo} charges.");
            }
        }

        public override void Fire()
        {
            NumberOfShots++;

            WriteLine("I am shooting a laser.");
            Ammo -= 1;

            Random laserDamage = new Random();

            if (NumberOfShots % 3 == 0)
                Damage = laserDamage.Next(5, 26) * 4;
            else
                Damage = laserDamage.Next(5, 26);

        }
    }
}
