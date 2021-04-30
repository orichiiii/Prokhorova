using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Lesson7
{
    public class OptimusPrime : DriverTransformer
    {
        public OptimusPrime(Weapon weapon, Scanner scanner, string name) : base(weapon, scanner, name) { }

        public override void Fire()
        {
            Weapon.Fire();
        }

        public override void Run()
        {
            if (IsRobot)
            {
                WriteLine("Optimus Prime Transformed into a car.");
                IsRobot = false;
            }
        }

        public override void FindEnemy()
        {
            Scanner.Scan();
        }

        public override void Transform()
        {
            if (!IsRobot)
            {
                WriteLine("Optimus Prime Transformed into a robot.");
                IsRobot = true;
            }
        }

        public override void Drive()
        {
            if (IsRobot)
                IsRobot = false;

            WriteLine("Optimus Prime goes to the enemy.");
        }
    }
}
