using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Pay_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program Start
            //Intro Line.
            //THIS IS FLAWED. The user can que inputs while this counts down. They shouldn't be able to break the whole thing, but they may skip some steps.
            for (int I = 5; I > 0; I--)
            {
                Clear();
                Write("Welcome to the Pay Check Calculation program.\n\nYou will be asked to input various information about an employee,\nthen the program will calculate and output that employee's net pay.\nThe net pay includes a 20% tax and potential deductions.\n\nYou may enter 111 to end the program at any time.\n\nYou may continue in: {0}", I);
                System.Threading.Thread.Sleep(1000);
            }
            Write("\rPress any key to continue...");
            ReadKey();
            Clear();

            //Start of the program - A loop to allow the user to repeat the program
            //It is Infinite, but entering 111 at any point in the program breaks the loop.
            while (1 == 1)
            {
                //Declarations
                //Put all declarations inside the major loop so anything that needs to will reset
                const float TAX = 0.8F;
                const int SINGLE = 60; //Deduction for Single: $60
                const int FAMILY = 150; //Deductino for Family: $150
                byte A1Or2 = 0; //Used for most of the decisions
                byte B1Or2 = 0; //Used for all the sub-decisions
                double HrsOrYSlry; //Hours Or Yearly Salary. This variable can be used for either.
                double GrossPay;
                float HrRtOrPayPrd; //Hourly Rate Or Pay Period. This variable can be used for either.
                string FirstName = "";
                string LastName = "";
                string ID;
                const string PLEASE_INPUT = "Please only enter 1, 2, or 111 to end the program.\n"; //This string is used a lot.

                //Part 1 - User inputs

                //User name input
                //Do loop makes sure the name doesn't break the formatting at the end.
                do
                {
                    //This loop makes sure the user enters at least 1 character.
                    do
                    {
                        Write("Input the employee's first name: ");
                        FirstName = ReadLine();

                        //Prog End Check - This if will end the program. It's re-used at every input.
                        if (FirstName == "111")
                        {
                            break;
                        }

                        //If alerts the user they should enter a longer name
                        if (FirstName.Length < 1)
                        {
                            Clear();
                            WriteLine("Please enter at least one character, or 111 to end the program.\n");
                        }
                    } while (FirstName.Length < 1);

                    Clear();

                    //Makes the name all uppercase to keep the name format standardized in the end
                    FirstName = FirstName.ToUpper();

                    //Prog End Check
                    if (FirstName == "111")
                    {
                        break;
                    }

                    //This loop makes sure the user enters at least 1 character.
                    do
                    {
                        Write("Input {0}'s Last name: ", FirstName);
                        LastName = ReadLine();

                        //Prog End Check
                        if (LastName == "111")
                        {
                            break;
                        }

                        //If alerts the user they should enter a longer name
                        if (LastName.Length < 1)
                        {
                            Clear();
                            WriteLine("Please enter at least one character, or 111 to end the program.\n");
                        }
                    } while (LastName.Length < 1);

                    //Last Name Formatting
                    LastName = LastName.ToUpper();

                    //Prog End Check
                    if (LastName == "111")
                    {
                        break;
                    }

                    //Combine First and Last name for the final output.
                    FirstName += " " + LastName;

                    //if alerts the user they should enter a shorter name
                    //The check accounts for the space added above.
                    if (FirstName.Length > 26)
                    {
                        Clear();
                        WriteLine("That employee's First and Last name are too long. Please shorten their full name to less than 26 characters. Or enter 111 to end the program.\n");
                    }
                } while (FirstName.Length > 26);

                Clear();

                //Prog End Check
                if (LastName == "111" || FirstName == "111")
                {
                    break;
                }

                //Employee's ID #
                Write("Input {0}'s 4 character employee ID number: ", LastName);
                ID = ReadLine();

                //Loop makes sure ID matches stated length or is the command to exit
                while (ID.Length != 4 && ID != "111")
                {
                    Clear();
                    WriteLine("Please make sure you input a 4 character ID. Or you may enter 111 to end the program.\n");
                    Write("Input {0}'s 4 digit employee ID number: ", LastName);
                    ID = ReadLine();
                }
                Clear();

                //Prog End Check
                if (ID == "111")
                {
                    break;
                }

                //Is the employee Hourly or Salaried? 
                while (B1Or2 != 1)
                {
                    //Loop ensures the user only enters valid inputs & won't allow letters or a number larger than a byte.
                    do
                    {
                        WriteLine("Is {0} recieving Hourly pay or Salary pay?\n\nInput 1 for Hourly\nInput 2 for Salary", LastName);

                        while (!byte.TryParse(ReadLine(), out A1Or2)) //Makes sure user doesn't enter a large number or a letter.
                        {
                            Clear();
                            WriteLine(PLEASE_INPUT);
                            WriteLine("Is {0} recieving Hourly pay or Salary pay?\n\nInput 1 for Hourly\nInput 2 for Salary", LastName);
                        }

                        Clear();
                        
                        //This adds a message to clarify what the user should do if they don't input 1, 2, or 111
                        if (A1Or2 != 1 && A1Or2 != 2 && A1Or2 != 111)
                        {
                            WriteLine(PLEASE_INPUT);
                        }

                    } while (A1Or2 != 1 && A1Or2 != 2 && A1Or2 != 111);
                    Clear();

                    //Prog End Check
                    if (A1Or2 == 111)
                    {
                        break;
                    }

                    //If statement to make sure the user is sure about what they selected.
                    if (A1Or2 == 1)
                    {
                        //Loop ensures the user only enters valid inputs & won't allow letters or a number larger than a byte.
                        do
                        {
                            WriteLine("You have selected: Hourly Pay.\n\nIs this correct?\n\n1 for yes\n2 for no");

                            while (!byte.TryParse(ReadLine(), out B1Or2)) //Makes sure user doesn't enter a large number or a letter.
                            {
                                Clear();
                                WriteLine(PLEASE_INPUT);
                                WriteLine("You have selected: Hourly Pay.\n\nIs this correct?\n\n1 for yes\n2 for no");
                            }

                            Clear();

                            //This adds a message to clarify what the user should do if they don't input 1, 2, or 111
                            if (A1Or2 != 1 && A1Or2 != 2 && A1Or2 != 111)
                            {
                                WriteLine(PLEASE_INPUT);
                            }

                        } while (B1Or2 != 1 && B1Or2 != 2 && B1Or2 != 111);
                    }
                    else
                    {
                        //Loop ensures the user only enters valid inputs & won't allow letters or a number larger than a byte.
                        do
                        {
                            WriteLine("You have selected: Salary Pay.\n\nIs this correct?\n\n1 for yes\n2 for no");

                            while (!byte.TryParse(ReadLine(), out B1Or2)) //Makes sure user doesn't enter a large number or a letter.
                            {
                                Clear();
                                WriteLine(PLEASE_INPUT);
                                WriteLine("You have selected: Salary Pay.\n\nIs this correct?\n\n1 for yes\n2 for no");
                            }

                            Clear();

                            //This adds a message to clarify what the user should do if they don't input 1, 2, or 111
                            if (B1Or2 != 1 && B1Or2 != 2 && B1Or2 != 111)
                            {
                                WriteLine(PLEASE_INPUT);
                            }

                        } while (B1Or2 != 1 && B1Or2 != 2 && B1Or2 != 111);
                    }

                    //Prog End Check
                    if (B1Or2 == 111)
                    {
                        break;
                    }

                    Clear();

                    //If the user is sure and makes A1Or2 = 1, then the program will continue.
                    //If they say no then the option loops.
                }

                //Prog End Check
                if (B1Or2 == 111 || A1Or2 == 111)
                {
                    break;
                }

                //Part 2 - What if Hourly or Salary?

                //A1Or2 will direct the if statement to "What If Hourly" if they input 1 or "What If Salary" if they input 2.

                if (A1Or2 == 1) //If they select hourly
                {
                    do //
                    {
                        Write("Enter the number of hours {0} has worked: ", LastName);

                        while (!double.TryParse(ReadLine(), out HrsOrYSlry)) //Makes sure user doesn't enter a large number or a letter.
                        {
                            Clear();
                            Write("Please enter a valid number or 111 to quit.\n\nEnter the number of hours {0} has worked: ", LastName);
                        }

                        Clear();

                        //Makes sure the user doesn't enter a negative.
                        if (HrsOrYSlry < 0)
                        {
                            WriteLine("You can't work negative hours!\n");
                        }

                    } while (HrsOrYSlry < 0);


                    //Prog End Check
                    if (HrsOrYSlry == 111)
                    {
                        break;
                    }

                    do //Only lets the user move on if they enter a positive number.
                    {
                        Write("Enter {0}'s hourly rate: ", LastName);

                        while (!Single.TryParse(ReadLine(), out HrRtOrPayPrd)) //Makes sure user doesn't enter a large number or a letter.
                        {
                            Clear();
                            Write("Please enter a valid number or 111 to quit.\n\nEnter {0}'s hourly rate: ", LastName);
                        }

                        Clear();

                        //Makes sure the user doesn't enter a negative.
                        if (HrRtOrPayPrd < 0)
                        {
                            WriteLine("This is a Pay Check program, not a Billing program.\n");
                        }

                    } while (HrRtOrPayPrd < 0);


                    //Prog End Check
                    if (HrRtOrPayPrd == 111)
                    {
                        break;
                    }

                    //Finding the Gross Pay of an Hourly employee
                    GrossPay = (HrsOrYSlry * HrRtOrPayPrd) * TAX;
                }
                else //If they select salary
                {
                    do //Only lets the user move on if they enter a positive number.
                    {
                        Write("Enter the yearly salary of {0}: ", LastName);

                        while (!double.TryParse(ReadLine(), out HrsOrYSlry)) //Makes sure user doesn't enter a large number or a letter.
                        {
                            Clear();
                            Write("Please enter a valid number or 111 to quit.\n\nEnter the yearly salary of {0}: ", LastName);
                        }

                        Clear();

                        //Makes sure the user doesn't enter a negative.
                        if (HrsOrYSlry < 0)
                        {
                            WriteLine("You can't have a negative salary!\n");
                        }

                    } while (HrsOrYSlry < 0);


                    //Prog End Check
                    if (HrsOrYSlry == 111)
                    {
                        break;
                    }

                    do //Only lets the user move on if they enter a positive number.
                    {
                        Write("Enter the number of pay periods: ", LastName);

                        while (!Single.TryParse(ReadLine(), out HrRtOrPayPrd)) //Makes sure user doesn't enter a large number or a letter.
                        {
                            Clear();
                            Write("Please enter a valid number or 111 to quit.\n\nEnter the number of pay periods: ", LastName);
                        }

                        Clear();

                        //Makes sure the user doesn't enter a negative.
                        if (HrRtOrPayPrd < 0)
                        {
                            WriteLine("This is a Pay Check program, not a Billing program.\n");
                        }

                    } while (HrRtOrPayPrd < 0);


                    //Prog End Check
                    if (HrRtOrPayPrd == 111)
                    {
                        break;
                    }

                    //Finding the Gross Pay of a salary employee
                    GrossPay = (HrsOrYSlry / HrRtOrPayPrd) * TAX;
                }

                //reset B1Or2 for future use
                B1Or2 = 0;
                Clear();

                //Part 3 - Does the employee have benefit deductions?
                //Loop ensures the user only enters valid inputs & won't allow letters or a number larger than a byte.
                do
                {
                    WriteLine("Does {0} have benefit deductions?\n\n1 for yes\n2 for no", LastName);

                    while (!byte.TryParse(ReadLine(), out A1Or2)) //Makes sure user doesn't enter a large number or a letter.
                    {
                        Clear();
                        WriteLine(PLEASE_INPUT);
                        WriteLine("Does {0} have benefit deductions?\n\n1 for yes\n2 for no", LastName);
                    }

                    Clear();

                    //This adds a message to clarify what the user should do if they don't input 1, 2, or 111
                    if (A1Or2 != 1 && A1Or2 != 2 && A1Or2 != 111)
                    {
                        WriteLine(PLEASE_INPUT);
                    }

                } while (A1Or2 != 1 && A1Or2 != 2 && A1Or2 != 111);

                //Prog End Check
                if (A1Or2 == 111)
                {
                    break;
                }

                //If they say yes above, this if will find single or family and deduct it.
                if (A1Or2 == 1)
                {
                    Clear();
                    //Are you sure loop #2.
                    while (B1Or2 != 1) //Loop allows the user to confirm if they are sure or not
                    {
                        //Loop ensures the user only enters valid inputs & won't allow letters or a number larger than a byte.
                        do
                        {
                            //Line asking if the user has single or family deduction.
                            WriteLine("Is it a Single or Family deduction?\nSingle is if you are living independently. Single will deduct $60.\nFamily is if you are not living independently.Family will deduct $150.\n\n1 for Single\n2 for Family");
                            while (!byte.TryParse(ReadLine(), out A1Or2)) //Makes sure user doesn't enter a large number or a letter.
                            {
                                Clear();
                                WriteLine(PLEASE_INPUT);
                                WriteLine("Is it a Single or Family deduction?\nSingle is if you are living independently. Single will deduct $60.\nFamily is if you are not living independently. Family will deduct $150.\n\n1 for Single\n2 for Family");
                            }

                            Clear();

                            //This adds a message to clarify what the user should do if they don't input 1, 2, or 111
                            if (A1Or2 != 1 && A1Or2 != 2 && A1Or2 != 111)
                            {
                                WriteLine(PLEASE_INPUT);
                            }

                        } while (A1Or2 != 1 && A1Or2 != 2 && A1Or2 != 111);
                        
                        Clear();

                        //Prog End Check
                        if (A1Or2 == 111)
                        {
                            break;
                        }

                        //If statement to make sure the user is sure about what they selected.

                        if (A1Or2 == 1) //If user selects Single Deduction
                        {
                            //Loop ensures the user only enters valid inputs & won't allow letters or a number larger than a byte.
                            do
                            {
                                WriteLine("You have selected: Single deduction.\n\nIs this correct?\n\nInput 1 for yes\nInput 2 for no");

                                while (!byte.TryParse(ReadLine(), out B1Or2)) //Makes sure user doesn't enter a large number or a letter.
                                {
                                    Clear();
                                    WriteLine(PLEASE_INPUT);
                                    WriteLine("You have selected: Single deduction.\n\nIs this correct?\n\nInput 1 for yes\nInput 2 for no");
                                }

                                Clear();

                                //This adds a message to clarify what the user should do if they don't input 1, 2, or 111
                                if (B1Or2 != 1 && B1Or2 != 2 && B1Or2 != 111)
                                {
                                    WriteLine(PLEASE_INPUT);
                                }

                            } while (B1Or2 != 1 && B1Or2 != 2 && B1Or2 != 111) ;
                        }
                        else //If user selects Family Deduction
                        {
                            //Loop ensures the user only enters valid inputs & won't allow letters or a number larger than a byte.
                            do
                            {
                                WriteLine("You have selected: Family deduction.\n\nIs this correct?\n\nInput 1 for yes\nInput 2 for no");

                                while (!byte.TryParse(ReadLine(), out B1Or2)) //Makes sure user doesn't enter a large number or a letter.
                                {
                                    Clear();
                                    WriteLine(PLEASE_INPUT);
                                    WriteLine("You have selected: Family deduction.\n\nIs this correct?\n\nInput 1 for yes\nInput 2 for no");
                                }

                                Clear();

                                //This adds a message to clarify what the user should do if they don't input 1, 2, or 111
                                if (B1Or2 != 1 && B1Or2 != 2 && B1Or2 != 111)
                                {
                                    WriteLine(PLEASE_INPUT);
                                }

                            } while (B1Or2 != 1 && B1Or2 != 2 && B1Or2 != 111);
                        }
                        Clear();

                        //Prog End Check
                        if (B1Or2 == 111)
                        {
                            break;
                        }

                        //If the user is sure and makes B1Or2 = 1, then the program will continue.
                        //If they chose "No, i'm not sure" then the option loops.

                    }//end while

                    //Prog End Check
                    if (B1Or2 == 111 || A1Or2 == 111)
                    {
                        break;
                    }

                    //Math to deduct single or family (if they said yes to it)
                    if (A1Or2 == 1)
                    {
                        //Single pay -$60
                        GrossPay -= SINGLE;
                    }
                    else
                    {
                        //Family deduction -$150
                        GrossPay -= FAMILY;
                    }
                }
                //end "Single or Family" if

                Clear();

                //Part 4 - Output the results
                //Length - 28 / 10 / 24 / 15
                //Made a nice box to display outputs

                WriteLine("▓■■■■■■■■■■■▓");
                WriteLine("▓ Pay Check ▓");
                WriteLine("▓■■■■■■■■■■■▓■■■■■■■■■■■■■■■■▓■■■■■■■■■■▓■■■■■■■■■■■■■■■■■■■■■■■■▓■■■■■■■■■■■■■■■▓");
                WriteLine($"▓ {"Employee Name",-26} ▓ {"ID #",-8} ▓ {"Date & Time",-22} ▓ {"Net Pay",-13} ▓");
                WriteLine("▓----------------------------▓----------▓------------------------▓---------------▓");
                WriteLine($"▓ {FirstName,-26} ▓ {ID,-8} ▓ {DateTime.Now,-22} ▓ {GrossPay.ToString("C"),-13} ▓"); //This line outputs the finale variables along with Date & Time
                WriteLine("▓■■■■■■■■■■■■■■■■■■■■■■■■■■■■▓■■■■■■■■■■▓■■■■■■■■■■■■■■■■■■■■■■■■▓■■■■■■■■■■■■■■■▓");

                WriteLine("\nPress any button to continue...");
                ReadKey();

                //Option to end the program
                do //Loop ensures the user only enters valid inputs
                {
                    WriteLine("\nIf you would like to calculate another employee's pay check enter 1 or 2.\nOtherwise enter 111 to end the program at any time.");
                    while (!byte.TryParse(ReadLine(), out A1Or2))
                    {
                        Clear();
                        WriteLine(PLEASE_INPUT);
                        WriteLine("\nIf you would like to calculate another employee's pay check enter 1 or 2.\nOtherwise enter 111 to end the program at any time.");
                    }

                    Clear();

                    //This adds a message to clarify what the user should do if they don't input 1, 2, or 111
                    if (A1Or2 != 1 && A1Or2 != 2 && A1Or2 != 111)
                    {
                        WriteLine("\n" + PLEASE_INPUT);
                    }

                } while (A1Or2 != 1 && A1Or2 != 2 && A1Or2 != 111);

                Clear();

                //Prog End Check
                if (A1Or2 == 111)
                {
                    break;
                }
            }
            //end of loop

            //Program will end after this "for" loops 5 times
            for (int I = 5; I > 0; I--)
            {
                Clear();
                Write("Thank you for using this program! Goodbye!\nEnding in: {0} Seconds...", I);
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
