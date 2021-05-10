using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTests
{
    public static class Parameters
    {
        private static Random _random = new Random();

        public static string GeneratePhone() => _random.Next(100000000, int.MaxValue).ToString();
        public static string GenerateEmail() => DateTime.Now.ToString("HH.dd.mm.ss.yy") + "@gmail.com";
    }
}
