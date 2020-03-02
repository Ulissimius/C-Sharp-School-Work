using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Bill_Tiping_Calc_Prog
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dec's
            float BillOrigin;
            float Bill20;
            float Bill15;
            float BillTotal15;
            float BillTotal20;

            //Intro and User Input
            Write("Welcome to this tip calculating program." +
                "\nThis program will take your bill and calculate a 15% and 20% tip, along with the total cost after the tip." +
                "\n\nPlease enter your bill charge: ");
            while (!float.TryParse(ReadLine(), out BillOrigin))
            {
                WriteLine("Please only enter your bill charge in numbers.");
            }

            //Math to find % and totals
            //Bill15 = BillOrigin * 0.15F;
            //Bill20 = BillOrigin * 0.20F;
            //BillTotal15 = BillOrigin * 1.15F;
            //BillTotal20 = BillOrigin * 1.20F;

            Clear();
            WriteLine("  |-----------------------------------------------------");
            WriteLine("  | Original Bill | % Tip | Tip Amount | Total with Tip");
            WriteLine("  |-----------------------------------------------------");
            WriteLine(string.Format("  | {0,-13} | {1,-5} | {2,-10} | {3, -14} ", BillOrigin.ToString("C"), "15%", (BillOrigin * 0.15F).ToString("C"), (BillOrigin * 1.15F).ToString("C")));
            WriteLine(string.Format("  | {0,-13} | {1,-5} | {2,-10} | {3, -14} ", BillOrigin.ToString("C"), "20%", (BillOrigin * 0.20F).ToString("C"), (BillOrigin * 1.20F).ToString("C")));
            /*WriteLine(string.Format("  | {0,-13} | {1,-5} | {2,-10} | {3, -14} ", BillOrigin.ToString("C"), "15%", Bill15.ToString("C"), BillTotal15.ToString("C")));
            WriteLine(string.Format("  | {0,-13} | {1,-5} | {2,-10} | {3, -14} ", BillOrigin.ToString("C"), "20%", Bill20.ToString("C"), BillTotal20.ToString("C")));*/
            WriteLine("  |-----------------------------------------------------");
            WriteLine("\n\nPress enter to end...");
            ReadLine();
        }
    }
}
