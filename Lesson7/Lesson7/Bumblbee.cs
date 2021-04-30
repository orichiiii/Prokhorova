using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Lesson7
{
    public class Bumblbee : SwimmingTransformer
    {
        public Bumblbee(Weapon weapon, Scanner scanner, string name) : base(weapon, scanner, name) { }

        public override void Transform()
        {
            if (!IsRobot)
            {
                WriteLine("Bumblbee trasformed into a robot.");
                IsRobot = true;
            }
        }

        public override void Run()
        {
            WriteLine("Bumblbee is running to the enemy.");
        }

        public override void FindEnemy()
        {
            Scanner.Scan();
        }

        public override void Fire()
        {
            Weapon.Fire();
        }

        public override void Swim()
        {
            if (IsRobot)
                IsRobot = false;

            WriteLine("Bumblebee is sailing towards the enemy.");
        }
    }
}
