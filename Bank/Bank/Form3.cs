using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Bank.Form1;
using static System.Convert;

namespace Bank
{
    public partial class Form3 : Form
    {
        //I tried to make the radio buttons work. They work, you can press them and the code has no errors, but no matter what you select it won't save the checked button's value as the new account state.


        RadioButton[] Radio = new RadioButton[5];

        //Method sets AccountState states = to radio buttons
        private void RadioStates(Account A)
        {
            if (A.State == AccountState.Active)
            {
                rbActive.Checked = true;
            }
            if (A.State == AccountState.Closed)
            {
                rbClosed.Checked = true;
            }
            if (A.State == AccountState.Frozen)
            {
                rbFrozen.Checked = true;
            }
            if (A.State == AccountState.New)
            {
                rbNew.Checked = true;
            }
            if (A.State == AccountState.UnderAudit)
            {
                rbUnderAudit.Checked = true;
            }

        }

        //Method sets the currently selected Radio button as the new state of the account
        private void SetStates(Account A)
        {

            if (rbActive.Checked == true)
            {
                A.State = AccountState.Active;
            }
            if (rbClosed.Checked == true)
            {
                A.State = AccountState.Closed;
            }
            if (rbFrozen.Checked == true)
            {
                A.State = AccountState.Frozen;
            }
            if (rbNew.Checked == true)
            {
                A.State = AccountState.New;
            }
            if (rbUnderAudit.Checked == true)
            {
                A.State = AccountState.UnderAudit;
            }
        }

        //---------------------------------------------------------End Methods----------------------------------
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //Radio Buttons
            Radio[0] = rbActive;
            Radio[1] = rbClosed;
            Radio[2] = rbFrozen;
            Radio[3] = rbNew;
            Radio[4] = rbUnderAudit;


            //for loop populates the combobox with the created account names
            for (int i = 0; i < MAX_ACCOUNTS; i++)
            {
                if (Banking[i].AccountNumber != 0)
                {
                    comboBox1.Items.Add(Banking[i].Name);
                }
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //for loop populates the textboxes with information form the selected account
            for (int i = 0; i < MAX_ACCOUNTS; i++)
            {
                if (comboBox1.SelectedItem.ToString() == Banking[i].Name)
                {
                    txtNewFullName.Text = Banking[i].Name;
                    txtNewAddress.Text = Banking[i].Address;
                    txtNewAccNum.Text = Banking[i].AccountNumber.ToString();
                    txtNewBal.Text = Banking[i].Balance.ToString("N");
                    txtNewOD.Text = Banking[i].Overdraft.ToString("N");
                    RadioStates(Banking[i]);
                }
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            //for loop saves the edited information to the same account
            for (int i = 0; i < MAX_ACCOUNTS; i++)
            {
                if (comboBox1.SelectedItem.ToString() == Banking[i].Name)
                {
                    Banking[i].Name = txtNewFullName.Text;
                    Banking[i].Address = txtNewAddress.Text;
                    //Banking[i].AccountNumber = ToInt32(txtAccNum.Text); //Account Number is not to be changed
                    Banking[i].Balance = ToDouble(txtNewBal.Text);
                    Banking[i].Overdraft = ToDouble(txtNewOD.Text);
                    SetStates(Banking[i]); //For loop finds and sets the new account state


                }
            }
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblAccountNum_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
