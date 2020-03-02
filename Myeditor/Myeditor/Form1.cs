using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Myeditor
{
    public partial class Form1 : Form
    {

        string FPathOpen;
        string FPathSave;
        SaveFileDialog sf1 = new SaveFileDialog();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DialogResult.OK = The responce the program gets from a user hitting OK or Open to confirm selecting a file.
            /*if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FPathOpen = openFileDialog1.FileName; //Path will equal filepath to selected file
                StreamReader Sr = new StreamReader(FPathOpen);
                rtxtEditTable.Text = Sr.ReadToEnd();
                Sr.Close();
            }*/

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FPathOpen = openFileDialog1.FileName; //Path will equal filepath to selected file
                StreamReader Sr = new StreamReader(FPathOpen);
                string NewText = Sr.ReadToEnd();
                Sr.Close();

                if (sf1.ShowDialog() == DialogResult.OK)
                {
                    FPathSave = sf1.FileName;
                    StreamWriter Sw = new StreamWriter(FPathSave);
                    Sw.WriteLine(NewText);
                    Sw.Close();
                }
            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FPathSave = openFileDialog1.FileName;
            StreamWriter Sw = new StreamWriter(FPathSave);
            Sw.WriteLine(rtxtEditTable.Text);
            Sw.Close();
        }
    }
}
