using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7
{
    public abstract class SwimmingTransformer : Transformer
    {
        protected SwimmingTransformer(Weapon weapon, Scanner scanner, string name) : base(weapon, scanner, name) { }

        public abstract void Swim();
    }
}
