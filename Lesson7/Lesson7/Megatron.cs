using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Lesson7
{
    class Megatron : FlyingTransformer
    {
        public Megatron(Weapon weapon, Scanner scanner, string name) : base(weapon, scanner, name) { } 

        public override void FindEnemy()
        {
            Scanner.Scan();
        }

        public override void Fire()
        {
            Weapon.Fire();
        }

        public override void Fly()
        {
            if (IsRobot)
                IsRobot = false;

            WriteLine("Megatron is flying towards the enemy.");
        }

        public override void Run()
        {
            WriteLine("Megatron is running to the enemy.");
        }

        public override void Transform()
        {
            if (!IsRobot)
            {
                WriteLine("Megatron transformed into a robot.");
                IsRobot = true;
            }
        }
    }
}
