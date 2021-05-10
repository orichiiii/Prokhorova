using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTests
{
    public class Parameters
    {
        private Random _random = new Random();

        public string GeneratePhone() => _random.Next(100000000, int.MaxValue).ToString();
        public string GenerateEmail() => DateTime.Now.ToString("HH, dd, mm, ss, yy") + "@gmail.com";
    }
}
