using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BattleStage.MenuInput
{
    static class Input
    {
        public static string InputStringOfIntegers(string questionText)
        {
            while (true)
            {
                Console.Write($"                                       {questionText}: ");

                string input = Console.ReadLine();

                if (input.Equals("1") || input.Equals("2") || input.Equals("3"))
                {
                    return input;
                }
                else
                {
                    Utilities.InputError("You entered a incorrect option!", ConsoleColor.Red);
                    Thread.Sleep(2000);
                    Utilities.ClearErrorLines(2);
                }
            }
        }

        public static string InputStringName(string nameText)
        {
            while (true)
            {
                Console.Write($"{nameText}: ");

                string input = Console.ReadLine();

                if (input.Length < 10 && input.Length > 4)
                {
                    return input;
                }
                else
                {
                    Utilities.InputError("Enter a name greater than 4 but less than 10 characters!", ConsoleColor.Red);
                    Thread.Sleep(2000);
                    Utilities.ClearErrorLines(2);
                }
            }
        }

        public static string InputStringForYesNoStatements(string questionText)
        {
            while (true)
            {
                Console.Write($"                                       {questionText}: ");

                string input = Console.ReadLine();

                if (input.Equals("y", StringComparison.OrdinalIgnoreCase) || input.Equals("n", StringComparison.OrdinalIgnoreCase))
                {
                    return input;
                }
                else
                {
                    Utilities.InputError("You entered a incorrect option!", ConsoleColor.Red);
                    Thread.Sleep(2000);
                    Utilities.ClearErrorLines(2);
                }
            }
        }
    }
}
