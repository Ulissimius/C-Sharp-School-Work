using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PersonalInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Delcarations
            string BirthDay;
            string Name;
            bool Status = false;
            string WorkPhone;
            long WorkPhoneCheck;
            long CellPhoneCheck;
            string CellPhone;

            //Program Info
            WriteLine("This program takes and displays some information about you.");
            WriteLine();

            //Collecting Personal Info...
            WriteLine("Please enter your name.");
            Name = ReadLine();
            WriteLine("Please enter your birthday.");
            BirthDay = ReadLine();
            WriteLine("Please enter your unformated 10 digit work phone number.");
            WorkPhone = (ReadLine());
            //These While loops check to make sure your phone numbers are 10 digits and valid numbers.
            while (Status == false)
            {
                if (WorkPhone.Length != 10)
                {
                    WriteLine("Please enter only 10 digits and do not include formating.");
                    WorkPhone = ReadLine();
                }
                else
                {
                    while (!long.TryParse(WorkPhone, out WorkPhoneCheck))
                    {
                        WriteLine("Please enter only 10 digits and do not include formating.");
                        WorkPhone = ReadLine();
                    }
                    Status = true;
                }
            }
            WriteLine("Please enter your cell phone number.");
            CellPhone = (ReadLine());
            Status = true;
            while (Status == false)
            {
                if (CellPhone.Length != 10)
                {
                    WriteLine("Please enter only 10 digits and do not include formating.");
                    CellPhone = ReadLine();
                }
                else
                {
                    while (!long.TryParse(WorkPhone, out CellPhoneCheck))
                    {
                        WriteLine("Please enter only 10 digits and do not include formating.");
                        CellPhone = ReadLine();
                    }
                    Status = true;
                }
            }
            //end of info collecting...


            /* 
             * Selling personal info...
             * No code here yet.
            */


            //Converting Cell and Work phone into int so the formating below will work.
            long WorkPhoneInt = Convert.ToInt64(WorkPhone);
            long CellPhoneInt = Convert.ToInt64(CellPhone);

            //Outputting personal info...
            Clear();
            WriteLine("{0}'s information:", Name);
            WriteLine("My name is: {0}.", Name);
            WriteLine("My birthday is: {0}", BirthDay);
            WriteLine(String.Format("My work phone is: {0:(###) ###-####}", WorkPhoneInt));
            //WriteLine("My work phone is: {0}.", WorkPhone);
            WriteLine(String.Format("My cell phone is: {0:(###) ###-####}\r\n", CellPhoneInt));
            //WriteLine("My cell phone is: {0}.\r\n", CellPhone);

            //End of program
            WriteLine("Press enter to end.");
            Read();

        }
    }
}
