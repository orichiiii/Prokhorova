using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7
{
    public abstract class Transformer
    {
        protected readonly Weapon Weapon;
        protected readonly Scanner Scanner;
        public readonly string Name;
        public int HitPoint = 100;
        protected bool IsRobot;

        protected Transformer(Weapon weapon, Scanner scanner, string name)
        {
            Weapon = weapon;
            Scanner = scanner;
            Name = name;
        }

        public abstract void Fire();
        public abstract void Run();
        public abstract void FindEnemy();
        public abstract void Transform();
    }
}
