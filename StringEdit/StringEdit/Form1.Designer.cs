namespace StringEdit
{
    partial class Form1
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
            this.rtbInputText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbTextOutput = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbInputText
            // 
            this.rtbInputText.Location = new System.Drawing.Point(12, 32);
            this.rtbInputText.Name = "rtbInputText";
            this.rtbInputText.Size = new System.Drawing.Size(439, 202);
            this.rtbInputText.TabIndex = 0;
            this.rtbInputText.Text = "";
            this.rtbInputText.TextChanged += new System.EventHandler(this.rtbInputText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please Put Text here:";
            // 
            // rtbTextOutput
            // 
            this.rtbTextOutput.Location = new System.Drawing.Point(12, 272);
            this.rtbTextOutput.Name = "rtbTextOutput";
            this.rtbTextOutput.Size = new System.Drawing.Size(439, 202);
            this.rtbTextOutput.TabIndex = 2;
            this.rtbTextOutput.Text = "";
            this.rtbTextOutput.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Text Information:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 483);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbTextOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbInputText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbInputText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbTextOutput;
        private System.Windows.Forms.Label label2;
    }
}

