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

namespace Enter_Your_Name
{
    public partial class Form1 : Form
    {
        Random Rnd = new Random();
        int StartNum;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartNum = Rnd.Next(0, 101);
            txtNumber.Text = StartNum.ToString();
        }

        private void cmdGo_Click(object sender, EventArgs e)
        {
            string FirstName = txtFirstName.Text;
            string LastName = txtLastName.Text;
            string Age = txtAge.Text;

            if (txtFirstName.Text != "" && txtLastName.Text != "" && txtAge.Text != "")
            {
                lblResult.Text = "Your first/Last name and age is:\n";
                lblResult.Text += FirstName + " " + LastName + " " + Age;
            }
            
            cmdGo.Text = "Went";
            cmdGo.ForeColor = Color.DarkBlue;
            cmdGo.BackgroundImageLayout = ImageLayout.Stretch;
            cmdGo.BackgroundImage = Properties.Resources._512x512bb;

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFirstName_Click(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            

            try
            {
                int Age = ToInt32(txtAge.Text);

                if (Age > 100)
                {
                    //lblAgeError.ForeColor = color.FromArgb(000,000,000);
                    lblAgeError.ForeColor = Color.Green;
                    lblAgeError.Text = "Don't get any older, now!";
                }
                else if (Age < 18)
                {
                    lblAgeError.ForeColor = Color.Red;
                    lblAgeError.Text = "Stop it. Get some help. Don't do it.";
                }
                else
                {
                    lblAgeError.Text = "";   
                }
            }
            catch
            {
                if (txtAge.Text == "")
                {
                    lblAgeError.Text = "";
                    return;
                }
                txtAge.Text = "";
                lblAgeError.Text = "You can't enter that!";

                return;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmdGo.BackgroundImage = null;
            cmdGo.Text = "Go";
            cmdGo.ForeColor = Color.Black;
            cmdGo.BackgroundImageLayout = ImageLayout.Stretch;

            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAge.Text = "";
            lblResult.Text = "";
            StartNum = Rnd.Next(1, 101);
            txtNumber.Text = StartNum.ToString();
        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
