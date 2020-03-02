using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Convert;


namespace Bank
{
    public partial class Form1 : Form
    {
        //----------------------------------------------------Set Up Block------------------------------------------------------------
        //Decs
        public const int MAX_ACCOUNTS = 100; //Used for for loop limiting
        public static int Counter = 0; //Helps make new accounts
        public static Account[] Banking = new Account[MAX_ACCOUNTS]; //Array basicly is the program. Holds all the account info

        //My own variable - The "state" of the account
        public enum AccountState
        {
            Frozen,
            Active,
            Closed,
            UnderAudit,
            New
        }

        //Structure binding all these variables together
        public struct Account
        {
            public AccountState State;
            public string Name;
            public string Address;
            public int AccountNumber;
            public double Balance;
            public double Overdraft;
        }

        //Method - Shows some info from a selected account
        private void TestShow(Account a)
        {
            MessageBox.Show("Name: " + a.Name + "\n" + "Address: " + a.Address + "\n" + "Account #: " + a.AccountNumber + "\n" + "Balance: " + a.Balance.ToString("C") + "\n" + "Overdraft: " + a.Overdraft + "\n" + "State: " + a.State);
            /*MessageBox.Show(a.Address);
            MessageBox.Show(a.AccountNumber.ToString());
            MessageBox.Show(a.Balance.ToString());
            MessageBox.Show(a.Overdraft.ToString());*/
        }

        //method makes the text boxes on form2 input info into a new Banking array number
        public static void New_Account(TextBox txtName, TextBox txtAddress, TextBox txtBal, TextBox txtOD)
        {
            //counter is used to fill in new accounts
            for (int i = 0; i < MAX_ACCOUNTS; i++)
            {
                if (Banking[i].AccountNumber == 0)
                {
                    Counter = i;
                    break;
                }
            }

            try // Just takes care of any invalid inputs. Lazy/Effective
            {
                Banking[Counter].State = AccountState.New;
                Banking[Counter].Name = txtName.Text;
                Banking[Counter].Address = txtAddress.Text;
                //Banking[Counter].AccountNumber = ToInt32(txtAccNum.Text);
                Banking[Counter].AccountNumber = Counter + 1; //+1 so account number 0 can't exist, it caused problems.
                Banking[Counter].Balance = ToDouble(txtBal.Text);
                Banking[Counter].Overdraft = ToDouble(txtOD.Text);
            }
            catch (Exception) //I don't think all of these are correct, but they all have try/catch incase they don't work.
            {
                if (Banking[Counter].Name == "")
                {
                    Banking[Counter].Name = "Guy1";
                }

                if (Banking[Counter].Address == "")
                {
                    Banking[Counter].Address = "101 Lame Lane";
                }

                try
                {
                    if (Banking[Counter].Balance == ToDouble(""))
                    {
                        Banking[Counter].Balance = 100.00;
                    }
                }
                catch (Exception)
                {
                    Banking[Counter].Balance = 101.00;
                }

                try
                {
                    if (Banking[Counter].Overdraft == ToInt32(""))
                    {
                        Banking[Counter].Overdraft = 11;
                    }
                }
                catch (Exception)
                {
                    Banking[Counter].Overdraft = 112;
                }
            }

        }

        //-------------------------------------------------------------------End Setup Block-----------------------------------------

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // Opens form 2 (New account form)
        {
            Form2 frmNewUser = new Form2();
            frmNewUser.ShowDialog();
        }

        private void btnTest1_Click(object sender, EventArgs e) // Displays account information with non-0 account numbers
        {
            for (int i = 0; i < MAX_ACCOUNTS; i++)
            {
                if (Banking[i].AccountNumber != 0)
                {
                    TestShow(Banking[i]);
                }
            }
        }

        private void btnTest2_Click(object sender, EventArgs e) // Beter version of Test Button 1
        {
            listBox1.Items.Clear();
            //TestShow(Banking[1]);
            for (int i = 0; i < MAX_ACCOUNTS; i++)
            {
                if (Banking[i].AccountNumber != 0) //I have no idea how to make new lines like this (\n does not seem to work)
                {
                    listBox1.Items.Add("Name: " + Banking[i].Name + " \n" + "Address: " + Banking[i].Address + " \n" + "Account#: " + Banking[i].AccountNumber + " \n" + "Balance: " + Banking[i].Balance.ToString("C") + " \n" + "Overdraft: " + Banking[i].Overdraft + " \n" + "State: " + Banking[i].State);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e) // Loads form 3 (Edit Account)
        {
            Form3 frmEditUser = new Form3();
            frmEditUser.ShowDialog();
        }
    }
}
