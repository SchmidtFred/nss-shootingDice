using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll() {
            int input = 0;
            try {
                Console.WriteLine("Enter the number you rolled: ");
                input = int.Parse(Console.ReadLine());
            } catch (FormatException ex) {
                while (ex != null) {
                    try {
                        Console.WriteLine("We need a number here please: ");
                        input = int.Parse(Console.ReadLine());
                        ex = null;
                    } catch (FormatException newEx) { 
                        ex = newEx;
                    }
                }
            }
            return input;
        }
    }
}