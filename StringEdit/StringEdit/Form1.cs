using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringEdit
{

    /*Create a new application in C# that creates a form that allows the user to enter in a string. Evaluate the string and display the following information:

    *Done* The numbers of each letter of the alphabet
    *Done* The total number of spaces.Be sure to trim spaces from the left and right
    *Done* The total number of words in the string, use space as a word delimiter
    *Done* The total number of characters in the string, not counting spaces*/

    public partial class Form1 : Form
    {
        //Public Dec's ---------------------------------------------------------------------------------------------
        public int[] LetCount = new int[26]; //Array used to record the number of letters as a number
        public string[] AlphabetLets = new string[26]; //Saves me typing all the letters of the aplhabet to output.
        //End Public Dec's -----------------------------------------------------------------------------------------

        //Method(s) ------------------------------------------------------------------------------------------------
        private int ALPHABET(string Text)
        {
            int ii = 0; //external counter, for alphabet loops

            //for loop runs through A - Z comparing it to each letter in the string
            //when it finds a match it adds it to the count of that unique letter and breaks the for
            for (char c = 'A'; c <= 'Z'; c++)
            {
                if (Text == c.ToString())
                {
                    LetCount[ii]++;
                    break;
                }

                //if ensure the for loop won't break by breaking the bounds of an array
                if (ii < 25)
                {
                    ii++; //increase the number position in the array
                }
            }
            return LetCount[ii];
        }
        //End Method(s) --------------------------------------------------------------------------------------------

        //Start Program --------------------------------------------------------------------------------------------
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //upon form load the for loop builds an array of letter from A to Z that are used in the "rtbTextOutput.Text" string.
            //These letters are paired next to the count of each letter.
            int ii = 0;
            for (char c = 'A'; c <= 'Z'; c++)
            {
                AlphabetLets[ii] = c.ToString();

                ii++;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {}

        private void rtbInputText_TextChanged(object sender, EventArgs e)
        {
            //----------------------------------------------------------------------------------------
            //Program takes place almost exclusivly inside this rich text box's TextChanged field.
            //When the program runs it builds an array for the alphabet.
            //After that, whenver this rich text box (rtbInput) updates the rich text box below (rtbOutput) it gets filled with all the information from the code below.
            //The code below fills rtbOutput with all the information that is required for this homework assignment.
            //----------------------------------------------------------------------------------------

            //Dec's ----------------------------------------------------------------------------------
            string OutputText = rtbInputText.Text.Trim(); //The text from the top rich text box
            char[] delim = new char[] {' ', '\r', '\n'}; //Char that tells FullWords what to exclude
            int SpaceNum = OutputText.Count(char.IsWhiteSpace); //Counts white spaces (spaces, line breaks, etc) in the program.
            int FullWords = OutputText.Split(delim, StringSplitOptions.RemoveEmptyEntries).Length; //Counts the amount of words
            //string[] FullWords = OutputText.Split(' ', delim, StringSplitOptions.RemoveEmptyEntries); //Array that holds the number of words ***This worked, but counted spaces between words (Ex. "Hello    You" Would be more than 2 words)
            string[] FullLetters = new string[OutputText.Length]; //Array that holds each letter so they can be counted
            //end Dec's-------------------------------------------------------------------------------

            //reset's LetCount so it doesn't stack numbers.
            for (int i = 0; i < LetCount.Length; i++)
            {
                LetCount[i] = 0;
            }

            rtbTextOutput.Text = ""; //Resets the output box it doesn't duplicate text.

            //for loop fills FullLetters with each and every letter that exists in the top rich text box
            for (int i = 0; i < OutputText.Length; i++)
            {
                FullLetters[i] = Convert.ToString(OutputText[i]);
            }

            //This for counts the letters used
            for (int i = 0; i < FullLetters.Length; i++)
            {
                ALPHABET(FullLetters[i].ToUpper());
            }

            //Setting up/Displaying the final output -------------------------------------------------------------------


            //This for displays the unique letters used along with how many times they are used
            for (int i = 0; i < AlphabetLets.Length; i++)
            {
                rtbTextOutput.Text += AlphabetLets[i] + ":" + LetCount[i].ToString() + "  ";
            }

            //This displays how many character, words, and spaces there are
            rtbTextOutput.Text += "\n\n" + "Number of Characters: " + FullLetters.Length + "\n" + "Number of Words: " + FullWords + "\n" + "Number of Spaces: " + SpaceNum;
        }
        //End Program ------------------------------------------------------------------------------------------------

      /*while (OutputText.contains("  ")
        {
            OutputText.replace("  ", " ")
        }
      */

        private void label3_Click(object sender, EventArgs e)
        {}

        private void label4_Click(object sender, EventArgs e)
        {}

        private void button1_Click(object sender, EventArgs e)
        {}
    }
}
