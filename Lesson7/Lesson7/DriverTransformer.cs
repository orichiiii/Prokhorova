using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7
{
    public abstract class DriverTransformer : Transformer
    {
        protected DriverTransformer(Weapon weapon, Scanner scanner, string name) : base(weapon, scanner, name) { }

        public abstract void Drive();
    }
}
