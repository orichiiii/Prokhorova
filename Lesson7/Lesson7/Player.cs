using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Lesson7
{
    class Player
    {
        public static void CreateTransformer()
        {
            Write("Please choose first transformer: (1)Optimus Prime, (2)Bumblbee, (3)Megatron: ");
            var firstTransformer = ReadLine();

            Transformer firstFighter;

            switch (firstTransformer)
            {
                case "1": firstFighter = new OptimusPrime(ChooseWeapon(), ChooseScanner(), "Optimus Prime"); break;
                case "2": firstFighter = new Bumblbee(ChooseWeapon(), ChooseScanner(), "Bumblbee"); break;
                case "3": firstFighter = new Megatron(ChooseWeapon(), ChooseScanner(), "Megatron"); break;
                default: throw new ArgumentException($"Invalid operation {firstTransformer}.");
            }

            Write("\n Please choose second transformer: (1)Optimus Prime, (2)Bumblbee, (3)Megatron: ");
            var secondTransformer = ReadLine();

            Transformer secondFighter;

            switch (secondTransformer)
            {
                case "1": secondFighter = new OptimusPrime(ChooseWeapon(), ChooseScanner(), "Optimus Prime"); break;
                case "2": secondFighter = new Bumblbee(ChooseWeapon(), ChooseScanner(), "Bumblbee"); break;
                case "3": secondFighter = new Megatron(ChooseWeapon(), ChooseScanner(), "Megatron"); break;
                default: throw new ArgumentException($"Invalid operation {firstTransformer}.");
            }

            Battle.Fight(firstFighter, secondFighter);
        }

        private static Weapon ChooseWeapon()
        {
            Write("Please choose a weapon: (1) Blaster, (2) Laser weapon: ");
            var weapon = ReadLine();

            Weapon transformerWeapon;
            switch (weapon)
            {
                case "1": transformerWeapon = new Blaster(); break;
                case "2": transformerWeapon = new LaserWeapon(); break;
                default: throw new ArgumentException($"Invalid operation {weapon}.");
            }

            return transformerWeapon;
        }

        public static Scanner ChooseScanner()
        {
            WriteLine("Please choose a scanner: (1) Sonar, (2) Optical Scanner, (3) Friend or foe scanner: ");
            var scanner = ReadLine();

            Scanner transformerScanner;
            switch (scanner)
            {
                case "1": transformerScanner = new Sonar(); break;
                case "2": transformerScanner = new OpticalScanner(); break;
                case "3": transformerScanner = new FriendOrFoe(); break;
                default: throw new ArgumentException($"Invalid operation {scanner}.");
            }

            return transformerScanner;
        }
    }
}
