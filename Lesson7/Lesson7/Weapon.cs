using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7
{
    public abstract class Weapon
    {
        protected int Ammo = 6;
        public static int Damage;
        protected int NumberOfShots;


        public abstract void Reload();
        public abstract void Fire();
    }
}
