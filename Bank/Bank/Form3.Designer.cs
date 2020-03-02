namespace Bank
{
    partial class Form3
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblOverdraft = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblAccountNum = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtNewFullName = new System.Windows.Forms.TextBox();
            this.txtNewAddress = new System.Windows.Forms.TextBox();
            this.txtNewAccNum = new System.Windows.Forms.TextBox();
            this.txtNewBal = new System.Windows.Forms.TextBox();
            this.txtNewOD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.rbClosed = new System.Windows.Forms.RadioButton();
            this.rbFrozen = new System.Windows.Forms.RadioButton();
            this.rbNew = new System.Windows.Forms.RadioButton();
            this.rbUnderAudit = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 36);
            this.comboBox1.MaxDropDownItems = 88;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(432, 254);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(165, 254);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblOverdraft
            // 
            this.lblOverdraft.AutoSize = true;
            this.lblOverdraft.Location = new System.Drawing.Point(162, 127);
            this.lblOverdraft.Name = "lblOverdraft";
            this.lblOverdraft.Size = new System.Drawing.Size(123, 17);
            this.lblOverdraft.TabIndex = 9;
            this.lblOverdraft.Text = "Account Overdraft";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(162, 99);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(114, 17);
            this.lblBalance.TabIndex = 10;
            this.lblBalance.Text = "Account Balance";
            // 
            // lblAccountNum
            // 
            this.lblAccountNum.AutoSize = true;
            this.lblAccountNum.Location = new System.Drawing.Point(162, 71);
            this.lblAccountNum.Name = "lblAccountNum";
            this.lblAccountNum.Size = new System.Drawing.Size(113, 17);
            this.lblAccountNum.TabIndex = 11;
            this.lblAccountNum.Text = "Account Number";
            this.lblAccountNum.Click += new System.EventHandler(this.lblAccountNum_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(162, 43);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(115, 17);
            this.lblAddress.TabIndex = 12;
            this.lblAddress.Text = "Account Address";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(162, 15);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(126, 17);
            this.lblFullName.TabIndex = 13;
            this.lblFullName.Text = "Account Full Name";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.txtNewFullName);
            this.flowLayoutPanel1.Controls.Add(this.txtNewAddress);
            this.flowLayoutPanel1.Controls.Add(this.txtNewAccNum);
            this.flowLayoutPanel1.Controls.Add(this.txtNewBal);
            this.flowLayoutPanel1.Controls.Add(this.txtNewOD);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(294, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(188, 160);
            this.flowLayoutPanel1.TabIndex = 15;
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
            // txtNewAccNum
            // 
            this.txtNewAccNum.Enabled = false;
            this.txtNewAccNum.Location = new System.Drawing.Point(3, 59);
            this.txtNewAccNum.Name = "txtNewAccNum";
            this.txtNewAccNum.Size = new System.Drawing.Size(174, 22);
            this.txtNewAccNum.TabIndex = 4;
            // 
            // txtNewBal
            // 
            this.txtNewBal.Location = new System.Drawing.Point(3, 87);
            this.txtNewBal.Name = "txtNewBal";
            this.txtNewBal.Size = new System.Drawing.Size(174, 22);
            this.txtNewBal.TabIndex = 5;
            // 
            // txtNewOD
            // 
            this.txtNewOD.Location = new System.Drawing.Point(3, 115);
            this.txtNewOD.Name = "txtNewOD";
            this.txtNewOD.Size = new System.Drawing.Size(174, 22);
            this.txtNewOD.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Select account";
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.Location = new System.Drawing.Point(3, 3);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(67, 21);
            this.rbActive.TabIndex = 19;
            this.rbActive.TabStop = true;
            this.rbActive.Text = "Active";
            this.rbActive.UseVisualStyleBackColor = true;
            // 
            // rbClosed
            // 
            this.rbClosed.AutoSize = true;
            this.rbClosed.Location = new System.Drawing.Point(3, 30);
            this.rbClosed.Name = "rbClosed";
            this.rbClosed.Size = new System.Drawing.Size(72, 21);
            this.rbClosed.TabIndex = 20;
            this.rbClosed.TabStop = true;
            this.rbClosed.Text = "Closed";
            this.rbClosed.UseVisualStyleBackColor = true;
            // 
            // rbFrozen
            // 
            this.rbFrozen.AutoSize = true;
            this.rbFrozen.Location = new System.Drawing.Point(3, 57);
            this.rbFrozen.Name = "rbFrozen";
            this.rbFrozen.Size = new System.Drawing.Size(73, 21);
            this.rbFrozen.TabIndex = 21;
            this.rbFrozen.TabStop = true;
            this.rbFrozen.Text = "Frozen";
            this.rbFrozen.UseVisualStyleBackColor = true;
            // 
            // rbNew
            // 
            this.rbNew.AutoSize = true;
            this.rbNew.Location = new System.Drawing.Point(3, 84);
            this.rbNew.Name = "rbNew";
            this.rbNew.Size = new System.Drawing.Size(56, 21);
            this.rbNew.TabIndex = 22;
            this.rbNew.TabStop = true;
            this.rbNew.Text = "New";
            this.rbNew.UseVisualStyleBackColor = true;
            this.rbNew.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rbUnderAudit
            // 
            this.rbUnderAudit.AutoSize = true;
            this.rbUnderAudit.Location = new System.Drawing.Point(3, 111);
            this.rbUnderAudit.Name = "rbUnderAudit";
            this.rbUnderAudit.Size = new System.Drawing.Size(104, 21);
            this.rbUnderAudit.TabIndex = 23;
            this.rbUnderAudit.TabStop = true;
            this.rbUnderAudit.Text = "Under Audit";
            this.rbUnderAudit.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.rbActive);
            this.flowLayoutPanel2.Controls.Add(this.rbClosed);
            this.flowLayoutPanel2.Controls.Add(this.rbFrozen);
            this.flowLayoutPanel2.Controls.Add(this.rbNew);
            this.flowLayoutPanel2.Controls.Add(this.rbUnderAudit);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 112);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(121, 141);
            this.flowLayoutPanel2.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Account Status:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 289);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblOverdraft);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblAccountNum);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblOverdraft;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblAccountNum;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox txtNewOD;
        private System.Windows.Forms.TextBox txtNewFullName;
        private System.Windows.Forms.TextBox txtNewAddress;
        private System.Windows.Forms.TextBox txtNewAccNum;
        private System.Windows.Forms.TextBox txtNewBal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbActive;
        private System.Windows.Forms.RadioButton rbClosed;
        private System.Windows.Forms.RadioButton rbFrozen;
        private System.Windows.Forms.RadioButton rbNew;
        private System.Windows.Forms.RadioButton rbUnderAudit;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
    }
}