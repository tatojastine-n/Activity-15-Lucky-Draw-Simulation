using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucky_Draw_Simulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] winningNumbers = { 7, 13, 21, 42, 58, 77 };
            int[] userNumbers = new int[20];

            Console.WriteLine("LUCKY NUMBER GAME");
            Console.WriteLine("Enter numbers between 1 and 99 for a chance to win!\n");

            for (int i = 0; i < 20; i++)
            {
                bool isValid;
                do
                {
                    Console.Write($"Player {i + 1}, enter your lucky number (1-99): ");
                    string input = Console.ReadLine();

                    isValid = int.TryParse(input, out userNumbers[i]) &&
                             userNumbers[i] >= 1 &&
                             userNumbers[i] <= 99;

                    if (!isValid)
                    {
                        Console.WriteLine("Invalid number! Please try again.");
                    }
                } while (!isValid);
            }
            Console.WriteLine("\n=== RESULTS ===");
            int winnerCount = 0;

            for (int i = 0; i < 20; i++)
            {
                if (Array.IndexOf(winningNumbers, userNumbers[i]) != -1)
                {
                    Console.WriteLine($"Player {i + 1} WINS with number {userNumbers[i]}!");
                    winnerCount++;
                }
            }

            if (winnerCount == 0)
            {
                Console.WriteLine("No winning numbers this round.");
            }
            else
            {
                Console.WriteLine($"\nTotal winners: {winnerCount}");
            }

            Console.WriteLine("\nToday's winning numbers: " + string.Join(", ", winningNumbers));
        }
    }
}
