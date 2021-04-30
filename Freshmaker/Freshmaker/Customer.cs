using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Freshmaker
{
    public class Customer
    {
        public double Cash = 100;
        public double CreditCard = 100;

        public static Customer customer = new Customer();

        public static void ChooseSize(Fresh fresh)
        {
            WriteLine("Please choose size: (1)S, (2)M, (3)L: ");
            var userChoice = ReadLine();

            switch (userChoice)
            {
                case "1": Purchase(fresh, 1); break;
                case "2": Purchase(fresh, 1.2); break;
                case "3": Purchase(fresh, 1.5); break;
                default: throw new ArgumentException($"Invalid operation {userChoice}");
            }
        }

        public static void ChooseMenu()
        {
            WriteLine("\n Please choose menu: (1)BY INGRIDIENTS, (2)SPECIAL TASTES: \n");
            var userChoice = ReadLine();

            switch (userChoice)
            {
                case "1": ChooseIngridients(); break;
                case "2": ChooseSpecialTaste(); break;
                default: throw new ArgumentException($"Invalid operation {userChoice}");
            }
        }

        public static void ChooseIngridients()
        {
            int freshPrice = 0;
            int i = 1;
            while (true)
            {
                WriteLine($"\n Please choose the {i} of fresh (enter name): \n");
                i++;

                Freshmaker.ShowMenu(Freshmaker.menu);
                var userChoice = ReadLine();


                var selectedFresh = Freshmaker.menu.Find(x => x.Name == userChoice.ToUpper());
                if (Freshmaker.menu.Contains(selectedFresh))
                    freshPrice += selectedFresh.Price;
                else
                    WriteLine($"{userChoice} fresh does not exist in our store.");

                WriteLine("Do you want to add ingridient?: (1)YES/(2)NO");
                var userInput = ReadLine();

                if (userInput == "2")
                    break;
                else if (userInput != "1")
                    WriteLine("You entered incorrect number.");
            }
            Fresh userFresh = new Fresh("user", freshPrice);
            ChooseSize(userFresh);
        }

        public static void ChooseSpecialTaste()
        {
            WriteLine("\n Please choose the taste of fresh (enter name): \n");
            Freshmaker.ShowMenu(Freshmaker.BestFrashes);
            var userChoice = ReadLine();

            var selectedFresh = Freshmaker.BestFrashes.Find(x => x.Name == userChoice.ToUpper());
            if (Freshmaker.BestFrashes.Contains(selectedFresh) & customer.Cash >= selectedFresh.Price)
            {
                ChooseSize(selectedFresh);
                Freshmaker.CookFromMenu(selectedFresh);
            }
            else
                WriteLine($"{userChoice} fresh does not exist in our store or you don't have enough money.");

        }

        private static void Purchase(Fresh selectedFresh, double size)
        {
            WriteLine("Please choose payment method: (1)Cash, (2)Credit Card");
            var userPayment = ReadLine();

            switch (userPayment)
            {
                case "1": PayCash(selectedFresh, size); break;
                case "2": PayCreditCard(selectedFresh, size); break;
                default: throw new ArgumentException($"Invalid operation {userPayment}");
            }
        }

        public static void PayCash(Fresh selectedFresh, double size)
        {
            customer.Cash -= selectedFresh.Price * size;
            WriteLine($"Thank you for Purchase. Your balance is {customer.Cash}");
        }

        public static void PayCreditCard(Fresh selectedFresh, double size)
        {
            customer.CreditCard -= selectedFresh.Price * size;
            WriteLine($"Thank you for Purchase. Your balance is {customer.Cash}");
        }
    }
}
