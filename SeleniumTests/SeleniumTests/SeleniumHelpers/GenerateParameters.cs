using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTests
{
    public static class GenerateParameters
    {
        private static Random _random = new Random();

        public static string GetPhone() => _random.Next(1000000000, int.MaxValue).ToString();
        
        public static string GetEmail() => DateTime.Now.ToString("dd.yyyy.HH.mm.ss") + "@gmail.com"; 
    }
}
