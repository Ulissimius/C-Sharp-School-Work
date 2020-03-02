using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Batting_Average_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string STOP_MESSAGE = "Enter players name. Enter stop as the player name to end the program";
            string ENTER_INFO = "Please enter the number of plate appearances, hits, and total non-at-bats of the player.";
            string PlayerName;
            int PlateAppears;
            int NumberOfHits;
            int TotNonAtBats;
            int AtBats;
            double BattingAverage;

            Console.WriteLine(STOP_MESSAGE);
            PlayerName = Console.ReadLine();
            WriteLine();

            while (PlayerName != "stop")
            {
                //This is InputInfo()
                Console.WriteLine(ENTER_INFO);
                while (!int.TryParse(ReadLine(), out PlateAppears))
                {
                    WriteLine("You need to enter whole numbers.");
                }
                while (!int.TryParse(ReadLine(), out NumberOfHits))
                {
                    WriteLine("You need to enter whole numbers.");
                }
                while (!int.TryParse(ReadLine(), out TotNonAtBats))
                {
                    WriteLine("You need to enter whole numbers.");
                }
                //PlateAppears = int.Parse(Console.ReadLine());
                //NumberOfHits = Convert.ToInt32(Console.ReadLine());
                //TotNonAtBats = Convert.ToInt32(Console.ReadLine());

                //This is BattingCalcs()
                AtBats = PlateAppears - TotNonAtBats;
                WriteLine();
                Console.Write("This is the amount of times {0} has been at bat: {1}\r\n\r\n", PlayerName, AtBats);

                BattingAverage = Convert.ToDouble(NumberOfHits) / Convert.ToDouble(AtBats);
                Write("This is {0}'s batting average: {1}\r\n", PlayerName, BattingAverage);
                WriteLine("\r\nPress enter to clear and start over.");
                ReadLine();
                
                Clear();
                WriteLine(STOP_MESSAGE);
                PlayerName = Console.ReadLine();
                //endwhile
            }

            WriteLine("Thanks for using this terrible program! Press enter to close the program!");
            ReadLine(); // The end of the program
        }
    }
}
