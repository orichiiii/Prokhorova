using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Lesson7
{
    public class OpticalScanner : Scanner
    {
        public override void Scan()
        {
            WriteLine("Search for enemies using an optical scanner.");
        }
    }
}
