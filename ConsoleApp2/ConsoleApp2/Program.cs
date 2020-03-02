using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace ConsoleApp2
{
    class Program
    {
        static string Addition (int A, string B)
        {
            string Convert;

            if (B == "ft")
            {
                A *= 12;
                Convert = A + " in";
            }
            else
            {
                A /= 12;
                Convert = A + " ft";
            }

            return Convert;
        }

        static void Main(string[] args)
        {
            int A;
            string B;

            WriteLine("Enter a measurement.");
            while (!int.TryParse(ReadLine(), out A))
            {
                WriteLine("Enter a valid Int");
            }

            WriteLine("Enter feet (ft) or inches (in).");
            B = ReadLine();

            string Answer = Addition(A, B);
            WriteLine("\nYour converted measurment is: " + Answer);
            ReadLine();
        }
    }
}
