using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7
{
    public abstract class FlyingTransformer : Transformer
    {
        protected FlyingTransformer(Weapon weapon, Scanner scanner, string name) : base(weapon, scanner, name) { }

        public abstract void Fly();
    }
}
