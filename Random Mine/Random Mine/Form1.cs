using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;
using static System.Convert;

namespace Random_Mine
{
    public partial class Form1 : Form
    {
        /*foreach (var button in this.Controls.OfType<Button>())
        {

        }*/

        //Global Decs
        Random Mine = new Random();
        string[] MineButs = new string[9];
        int Mine1;
        int Mine2;
        int Score = 0;

        //---------------------------------------------------------START OF METHODS------------------------------------------
        //Disables all the buttons - used at the end of the game
        private void DisableButts()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }


        //Method that runs the reset button
        private void ResetButton(Button Buttons)
        {
            Buttons.BackgroundImageLayout = ImageLayout.Stretch;
            Buttons.BackgroundImage = null;
            Buttons.Enabled = true;
        }


        //Method that runs the reset button method
        private void ResetButtonValues()
        {
            ResetButton(button1);
            ResetButton(button2);
            ResetButton(button3);
            ResetButton(button4);
            ResetButton(button5);
            ResetButton(button6);
            ResetButton(button7);
            ResetButton(button8);
            ResetButton(button9);

            Mine1 = Mine.Next(1, 10);
            Mine2 = Mine.Next(1, 10);
            while (Mine1 == Mine2)
            {
                Mine2 = Mine.Next(1, 10);
            }

            Score = 0;
            txtScoreBox.Text = Score.ToString();
            lblProgressText.Text = "";
        }


        //Method that runs the mine buttons
        private void ButtonWork(string Array, Button Buttons)
        {
            //if you lose - All buttons lock and text outputs "You Lose!"
            //This event is checked FIRST because the next if "Score == 6" will only become active if you click on the last button that would raise your score to 8
            if (Array == Mine1.ToString() || Array == Mine2.ToString())
            {
                Buttons.BackgroundImage = Properties.Resources._512x512bb;
                

                lblProgressText.Text = "You Lose!";
                lblProgressText.ForeColor = Color.DarkRed;

                //two very long switches that display the mines when you win/lose
                switch (Mine1.ToString())
                {
                    case "1":
                        button1.BackgroundImage = Properties.Resources._512x512bb;
                        break;

                    case "2":
                        button2.BackgroundImage = Properties.Resources._512x512bb;
                        break;

                    case "3":
                        button3.BackgroundImage = Properties.Resources._512x512bb;
                        break;

                    case "4":
                        button4.BackgroundImage = Properties.Resources._512x512bb;
                        break;

                    case "5":
                        button5.BackgroundImage = Properties.Resources._512x512bb;
                        break;

                    case "6":
                        button6.BackgroundImage = Properties.Resources._512x512bb;
                        break;

                    case "7":
                        button7.BackgroundImage = Properties.Resources._512x512bb;
                        break;

                    case "8":
                        button8.BackgroundImage = Properties.Resources._512x512bb;
                        break;

                    case "9":
                        button9.BackgroundImage = Properties.Resources._512x512bb;
                        break;
                }
                switch (Mine2.ToString())
                {
                    case "1":
                        button1.BackgroundImage = Properties.Resources._512x512bb;
                        break;

                    case "2":
                        button2.BackgroundImage = Properties.Resources._512x512bb;
                        break;

                    case "3":
                        button3.BackgroundImage = Properties.Resources._512x512bb;
                        break;

                    case "4":
                        button4.BackgroundImage = Properties.Resources._512x512bb;
                        break;

                    case "5":
                        button5.BackgroundImage = Properties.Resources._512x512bb;
                        break;

                    case "6":
                        button6.BackgroundImage = Properties.Resources._512x512bb;
                        break;

                    case "7":
                        button7.BackgroundImage = Properties.Resources._512x512bb;
                        break;

                    case "8":
                        button8.BackgroundImage = Properties.Resources._512x512bb;
                        break;

                    case "9":
                        button9.BackgroundImage = Properties.Resources._512x512bb;
                        break;
                }

                DisableButts();
            }

            //if you win - The last button locks and text outputs "You Win!"
            else if (Score == 6)
            {
                Score++;
                lblProgressText.Text = "You Win!";
                lblProgressText.ForeColor = Color.ForestGreen;

                //two very long switches that display the mines when you win/lose
                switch (Mine1.ToString())
                {
                    case "1":
                        button1.BackgroundImage = Properties.Resources._512x512bb;
                        break;

                    case "2":
                        button2.BackgroundImage = Properties.Resources._512x512bb;
                        break;

                    case "3":
                        button3.BackgroundImage = Properties.Resources._512x512bb;
                        break;

                    case "4":
                        button4.BackgroundImage = Properties.Resources._512x512bb;
                        break;

                    case "5":
                        button5.BackgroundImage = Properties.Resources._512x512bb;
                        break;

                    case "6":
                        button6.BackgroundImage = Properties.Resources._512x512bb;
                        break;

                    case "7":
                        button7.BackgroundImage = Properties.Resources._512x512bb;
                        break;

                    case "8":
                        button8.BackgroundImage = Properties.Resources._512x512bb;
                        break;

                    case "9":
                        button9.BackgroundImage = Properties.Resources._512x512bb;
                        break;
                }
                switch (Mine2.ToString())
                {
                    case "1":
                        button1.BackgroundImage = Properties.Resources._512x512bb;
                        break;

                    case "2":
                        button2.BackgroundImage = Properties.Resources._512x512bb;
                        break;

                    case "3":
                        button3.BackgroundImage = Properties.Resources._512x512bb;
                        break;

                    case "4":
                        button4.BackgroundImage = Properties.Resources._512x512bb;
                        break;

                    case "5":
                        button5.BackgroundImage = Properties.Resources._512x512bb;
                        break;

                    case "6":
                        button6.BackgroundImage = Properties.Resources._512x512bb;
                        break;

                    case "7":
                        button7.BackgroundImage = Properties.Resources._512x512bb;
                        break;

                    case "8":
                        button8.BackgroundImage = Properties.Resources._512x512bb;
                        break;

                    case "9":
                        button9.BackgroundImage = Properties.Resources._512x512bb;
                        break;
                }

                DisableButts();
            }

            //if you don't lose or win - score goes up, button pressed locks
            else if (Array != Mine1.ToString())
            {
                Score++;
                Buttons.Enabled = false;
            }
            txtScoreBox.Text = Score.ToString();
            /*cmdGo.Text = "Went";
            cmdGo.ForeColor = Color.DarkBlue;
            cmdGo.BackgroundImageLayout = ImageLayout.Stretch;
            cmdGo.BackgroundImage = Properties.Resources._512x512bb;
            */
        }

        
        //-----------------------------------------------END OF METHODS------------------------------------------------
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Gives all the buttons a numeric value - used to compare against the random number mine
            MineButs[0] = button1.AccessibleDescription = "1";
            MineButs[1] = button2.AccessibleDescription = "2";
            MineButs[2] = button3.AccessibleDescription = "3";
            MineButs[3] = button4.AccessibleDescription = "4";
            MineButs[4] = button5.AccessibleDescription = "5";
            MineButs[5] = button6.AccessibleDescription = "6";
            MineButs[6] = button7.AccessibleDescription = "7";
            MineButs[7] = button8.AccessibleDescription = "8";
            MineButs[8] = button9.AccessibleDescription = "9";

            //Random number lays the mine and makes sure you can't have two on one spot
            Mine1 = Mine.Next(1,10);
            Mine2 = Mine.Next(1,10);
            while (Mine1 == Mine2)
            {
                Mine2 = Mine.Next(1,10);
            }
        }

        //reset button
        private void button10_Click(object sender, EventArgs e)
        {
            ResetButtonValues();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //Buttons1-9 all call the ButtonWork method which checks if that particular button is +1 to score or the mine
        private void button1_Click(object sender, EventArgs e)
        {
            ButtonWork(MineButs[0], button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ButtonWork(MineButs[1], button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ButtonWork(MineButs[2], button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ButtonWork(MineButs[3], button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ButtonWork(MineButs[4], button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ButtonWork(MineButs[5], button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ButtonWork(MineButs[6], button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ButtonWork(MineButs[7], button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ButtonWork(MineButs[8], button9);
        }

        private void lblProgressText_Click(object sender, EventArgs e)
        {

        }
    }
}
