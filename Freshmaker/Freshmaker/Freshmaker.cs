using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Freshmaker
{
    public class Freshmaker
    {
        public static readonly List<Fresh> menu = new List<Fresh>
        {
            new Fresh ("MANGO", 10),
            new Fresh ("APPLE", 2),
            new Fresh ("WATERMELON", 30),
            new Fresh ("PEACH", 4),
            new Fresh ("MELON", 25),
            new Fresh ("STRAWBERRY", 15),
            new Fresh ("BANANA", 15)
        };

        public static readonly List<Fresh> BestFrashes = new List<Fresh>
        {
            new Fresh ("MANGO-MARAKUYA", 80),
            new Fresh ("EPIC", 500),
            new Fresh ("BANANA-STRAWBERRY", 70),
            new Fresh ("DRAGON FRUIT", 100),
        };

        public static void CookFromMenu(Fresh fresh)
        {
            WriteLine($"I cooked fresh {fresh.Name} for you.");
        }

        public static void ShowMenu(List<Fresh> menu)
        {
            WriteLine("Name | Price");

            foreach (Fresh fresh in menu)           
               WriteLine($"{fresh.Name} | {fresh.Price}");
        }
    }
}
