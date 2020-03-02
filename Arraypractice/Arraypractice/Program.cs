using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;
using System.IO;

namespace Arraypractice
{
    class Program
    {
        //-------------------------------------Methods---------------------------------
        static void EnterGrades()
        {
            int NumberOfGrades;
            double total = 0;
            double Grade;


            Console.WriteLine("How many grades would you like to enter?");
            while (!int.TryParse(Console.ReadLine(), out NumberOfGrades))
            {
                Console.Clear();
                Console.WriteLine("Enter a number.");
            }

            double[] grades = new double[NumberOfGrades];

            for (int I = 0; I < NumberOfGrades; I++)
            {
                Console.WriteLine("Enter grade {0}: ", I);
                while (!double.TryParse(Console.ReadLine(), out Grade))
                {
                    Clear();
                    WriteLine("Please enter a number.");
                }
                grades[I] = Grade;
            }

            for (int i = 0; i < NumberOfGrades; i++)
            {
                total += grades[i];
            }

            Console.WriteLine("Your average grade is: {0}", total / NumberOfGrades);
            ReadKey();
            Clear();

            WriteLine("Would you like the view any individual grades again? y/n");
            string YN = ReadLine();

            if (YN == "y")
            {
                WriteLine("What grade would you like to see?");
                byte GradeNum = ToByte(ReadLine());
                GradeNum--;
                WriteLine(grades[GradeNum]);
            }
        }

        //-------------------------------------------------Main Prog--------------------------------------------
        static void Main(string[] args)
        {
            
            byte YesOrNo = 1; //Global Decider

            while (1 == 1)
            {
                string ProgramSelect;

                Clear();

                WriteLine("Which program would you like to use?" +
                    "\nEnter 'info' to see information on each program." +
                    "\nEnter 1-3 to select a program.");

                ProgramSelect = ReadLine().ToLower();

                //----------------------------------------Program Info------------------------------------

                if (ProgramSelect == "info" || ProgramSelect == "")
                {
                    Clear();
                    WriteLine("Program 1: Asks for grade inputs and finds the average. The program loops and makes use of an aray.");
                    WriteLine("\nProgram 2: Uses a 2D array to record monster names/colors/locations/body counts, allow the user to input bodycount and compares to find a winning monster.");
                    WriteLine("\nProgram 3: Testing - filled with junk just for testing.");
                    WriteLine("\nPress any key to continue...");
                    ReadKey();
                }

                //-----------------------------------------Program 1-------------------------------------

                else if (ProgramSelect == "1")
                {
                    Clear();
                    string Answer;
                    while (1 == 1)
                    {
                        EnterGrades();
                        WriteLine("Would you like to go again? y/n");

                        do
                        {
                            bool I = false;

                            if (I == true)
                            {
                                WriteLine("Please enter y or n.");
                            }

                            Answer = ReadLine().ToLower();

                            I = true;

                        } while ((Answer.Length > 1) && (Answer != "y" || Answer != "n"));

                        if (Answer == "n")
                        {
                            break;
                        }

                    }

                    WriteLine("Good job. You are done now.");
                    ReadKey();
                }

                //----------------------------------------Program 2-------------------------------

                if (ProgramSelect == "2")
                {
                    while (1 == 1)
                    {
                        Clear();
                        //Creates 3 rows, 4 colums
                        //0 = Name, 1 = Color(not used), 2 = Location(not used), 3 = Body Count
                        //Overkill, Frank, Venom
                        string[,] Monster = new string[3, 4];

                        Monster[0, 0] = "Overkill";
                        Monster[0, 1] = "Black/Red";
                        Monster[0, 2] = "New York, New York";
                        Monster[0, 3] = "Over the max";

                        Monster[1, 0] = "Frank";
                        Monster[1, 1] = "Caucasian";
                        Monster[1, 2] = "Office";
                        Monster[1, 3] = "???";

                        Monster[2, 0] = "Venom";
                        Monster[2, 1] = "Black/White";
                        Monster[2, 2] = "On you";
                        Monster[2, 3] = "The Spider";

                        int BodyFinale = 0; //Largest number killed so far
                        string TieStat = ""; //Status of a tie or not
                        string Winner = ""; //The base of the finale output

                        for (int i = 0; i < Monster.GetLength(0); i++)
                        {
                            int BodyCount; //Number a monster has killed

                            //Loop makes sure the user enters a valid int
                            Write("Enter " + Monster[i, 0] + "'s Body Count: ");
                            while (!int.TryParse(ReadLine(), out BodyCount))
                            {
                                Clear();
                                WriteLine("Please enter a number!");
                                Write("\nEnter " + Monster[i, 0] + "'s Body Count: ");
                            }
                            Monster[i, 3] = BodyCount.ToString("N0");

                            //if structure changes tie status and self controls 
                            if (BodyCount > BodyFinale)
                            {
                                BodyFinale = BodyCount;
                                TieStat = "We have a winner!";
                            }
                            else if (BodyFinale > 0)
                            {
                                if (BodyCount == BodyFinale)
                                {
                                    BodyFinale = BodyCount;
                                    TieStat = "It's a tie!";
                                }
                            }
                        }

                        Clear();

                        //if total bodycount entered was 0 for all monsters, it's a tie and it's over.
                        if (BodyFinale == 0)
                        {
                            WriteLine("It's a tie! Nobody Died!");
                        }

                       
                        else if (BodyFinale != 0)
                        {
                            WriteLine(TieStat); //Writes out the string that says if it's a tie or not

                            //for loop builds the finale winner text
                            for (int i = 0; i < Monster.GetLength(0); i++)
                            {

                                //if only lets winning monsters in
                                if (Monster[i, 3] == BodyFinale.ToString("N0"))
                                {

                                    //Adds the winning monster names to the list
                                    //This if structure adds custom text to each winner
                                    //I could rework this to if "(Monster[i, 3] == BodyFinale" then filter it with "if (Monster)
                                    if (i == 0)
                                    {
                                        //if Overkill wins
                                        if (Monster[0, 3] == BodyFinale.ToString("N0"))
                                        {
                                            Winner += "\n" + (Monster[0, 0] + " Scored " + Monster[0, 3] + " OverKills!");
                                        }
                                    }
                                    else if (i == 1)
                                    {
                                        //if Frank wins
                                        if (Monster[1, 3] == BodyFinale.ToString("N0"))
                                        {
                                            Winner += "\n" + (Monster[1, 0] + " Managed " + Monster[1, 3] + " Office Kills!");
                                        }
                                    }
                                    else if (i == 2)
                                    {
                                        //if Venom wins
                                        if (Monster[2, 3] == BodyFinale.ToString("N0"))
                                        {
                                            Winner += "\n" + (Monster[2, 0] + " Squashed " + Monster[2, 3] + " Spiders!");
                                        }
                                    }
                                }
                            }
                        }

                        //Writes out the finale Winner text
                        WriteLine(Winner + "\n\nPress any key to continue!");
                        ReadKey();

                        //End program loop
                        //Ensures the user enters what I want them to :)
                        do
                        {
                            Clear();
                            if (YesOrNo != 1 && YesOrNo != 2)
                            {
                                WriteLine("Enter 1 or 2!");
                            }
                            
                            WriteLine("Would you like to compare again?\nYes = 1\nNo = 2\n");
                            while (!byte.TryParse(ReadLine(), out YesOrNo))
                            {
                                Clear();
                                WriteLine("Please enter 1 or 2!");
                                Write("\nWould you like to compare again?\nYes = 1\nNo = 2\n");
                            }
                        } while (YesOrNo != 1 && YesOrNo != 2);

                        if (YesOrNo == 2)
                        {
                            break;
                        }
                    }
                }

                //-------------------------------------------Program 3----------------------------

                else if (ProgramSelect == "3")
                {
                    Clear();
                    /*Switch statement practice

                    string Os;
                    WriteLine("What is your favorite operating system?");
                    Os = ReadLine();

                    switch (Os)
                    {
                        case "Linux":
                            WriteLine("You must be an educated genius");
                            break;

                        case "Windows":
                            WriteLine("Basic.");
                            break;

                        case "Mac":
                            WriteLine("Rich blood son");
                            break;

                        default:
                            WriteLine("Never heard of it, must be garbage.");
                            break;
                    }
                    ReadKey();*/

                    string [] Write = new string [2] ;
               
                    StreamWriter Writer = new StreamWriter("Test.txt");

                    Write[0] = "Less space, more words.";
                    Writer.WriteLine(Write[0]);
                    Write[1] = "More words, less space";
                    Writer.WriteLine(Write[1]);
                    Writer.Close();

                    int NumberOfLines = File.ReadAllLines("Test.txt").Count();
                    StreamReader Reader = new StreamReader("Test.txt");
                    string[] Line = new string [NumberOfLines];

                    for (int i = 0; i < Line.GetLength(0); i++)
                    {
                        Line[i] = Reader.ReadLine();
                    }

                    Reader.Close();

                    while (1 == 1)
                    {
                        int Input;

                        WriteLine("There are {0} lines in the file, which line would you like to see?\n[Press Enter to show all]", NumberOfLines);

                        try
                        {
                            Input = ToInt32(ReadLine());
                        }
                        catch
                        {

                        }

                        while (!int.TryParse(ReadLine(), out Input))
                        {
                            if (Input.ToString() == "")
                            {
                                break;
                            }
                            Clear();
                            WriteLine("Try again!");
                            WriteLine("There are {0} lines in the file, which line would you like to see?\n[Press Enter to show all]", NumberOfLines);
                        }

                        if (Input.ToString() == "")
                        {
                            for (int i = 0; i < Line.GetLength(0); i++)
                            {
                                WriteLine(Line[i]);
                            }
                        }
                        else
                        {
                            WriteLine(Line[Input]);
                        }

                        WriteLine("Now looping!");

                    }

                    for (int i = 0; i < Line.GetLength(0); i++)
                    {
                        WriteLine(Line[i]);
                    }


                    ReadKey();
                }

                //-------------------------------------------End of Programs----------------------------


                else
                {
                    Clear();
                    WriteLine("Invalid input, try again!");
                }

                Clear();

                WriteLine("Would you like to select another program? Enter 2 to quit, anything else to continue.");
                if (ReadLine().ToLower() == "2")
                {
                    break;
                }
            }
        }
    }
}
