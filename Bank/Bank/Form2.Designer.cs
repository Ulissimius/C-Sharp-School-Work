namespace Bank
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNewOD = new System.Windows.Forms.TextBox();
            this.txtNewAccNum = new System.Windows.Forms.TextBox();
            this.txtNewFullName = new System.Windows.Forms.TextBox();
            this.txtNewAddress = new System.Windows.Forms.TextBox();
            this.txtNewBal = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblAccountNum = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblOverdraft = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNewOD
            // 
            this.txtNewOD.Location = new System.Drawing.Point(3, 115);
            this.txtNewOD.Name = "txtNewOD";
            this.txtNewOD.Size = new System.Drawing.Size(174, 22);
            this.txtNewOD.TabIndex = 6;
            // 
            // txtNewAccNum
            // 
            this.txtNewAccNum.Location = new System.Drawing.Point(3, 59);
            this.txtNewAccNum.Name = "txtNewAccNum";
            this.txtNewAccNum.Size = new System.Drawing.Size(174, 22);
            this.txtNewAccNum.TabIndex = 4;
            // 
            // txtNewFullName
            // 
            this.txtNewFullName.Location = new System.Drawing.Point(3, 3);
            this.txtNewFullName.Name = "txtNewFullName";
            this.txtNewFullName.Size = new System.Drawing.Size(174, 22);
            this.txtNewFullName.TabIndex = 2;
            // 
            // txtNewAddress
            // 
            this.txtNewAddress.Location = new System.Drawing.Point(3, 31);
            this.txtNewAddress.Name = "txtNewAddress";
            this.txtNewAddress.Size = new System.Drawing.Size(174, 22);
            this.txtNewAddress.TabIndex = 3;
            // 
            // txtNewBal
            // 
            this.txtNewBal.Location = new System.Drawing.Point(3, 87);
            this.txtNewBal.Name = "txtNewBal";
            this.txtNewBal.Size = new System.Drawing.Size(174, 22);
            this.txtNewBal.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.txtNewFullName);
            this.flowLayoutPanel1.Controls.Add(this.txtNewAddress);
            this.flowLayoutPanel1.Controls.Add(this.txtNewAccNum);
            this.flowLayoutPanel1.Controls.Add(this.txtNewBal);
            this.flowLayoutPanel1.Controls.Add(this.txtNewOD);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(147, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(188, 148);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(15, 15);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(126, 17);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Account Full Name";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(15, 43);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(115, 17);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Account Address";
            this.lblAddress.Click += new System.EventHandler(this.lblAddress_Click);
            // 
            // lblAccountNum
            // 
            this.lblAccountNum.AutoSize = true;
            this.lblAccountNum.Location = new System.Drawing.Point(15, 71);
            this.lblAccountNum.Name = "lblAccountNum";
            this.lblAccountNum.Size = new System.Drawing.Size(113, 17);
            this.lblAccountNum.TabIndex = 0;
            this.lblAccountNum.Text = "Account Number";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(15, 99);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(114, 17);
            this.lblBalance.TabIndex = 0;
            this.lblBalance.Text = "Account Balance";
            // 
            // lblOverdraft
            // 
            this.lblOverdraft.AutoSize = true;
            this.lblOverdraft.Location = new System.Drawing.Point(15, 127);
            this.lblOverdraft.Name = "lblOverdraft";
            this.lblOverdraft.Size = new System.Drawing.Size(123, 17);
            this.lblOverdraft.TabIndex = 0;
            this.lblOverdraft.Text = "Account Overdraft";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 183);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(279, 183);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 220);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblOverdraft);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblAccountNum);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "New Account Form";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewOD;
        private System.Windows.Forms.TextBox txtNewAccNum;
        private System.Windows.Forms.TextBox txtNewFullName;
        private System.Windows.Forms.TextBox txtNewAddress;
        private System.Windows.Forms.TextBox txtNewBal;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblAccountNum;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblOverdraft;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
    }
}