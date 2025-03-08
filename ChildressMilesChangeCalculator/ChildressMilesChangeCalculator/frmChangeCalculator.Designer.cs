namespace ChildressMilesChangeCalculator
{
    partial class frmChangeCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTAmountChangeDue = new System.Windows.Forms.TextBox();
            this.TXTQuarters = new System.Windows.Forms.TextBox();
            this.TXTDimes = new System.Windows.Forms.TextBox();
            this.TXTNickels = new System.Windows.Forms.TextBox();
            this.TXTPennies = new System.Windows.Forms.TextBox();
            this.BTNCalculate = new System.Windows.Forms.Button();
            this.BTNExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount of change due (0-99):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quarters:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dimes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nickels:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pennies:";
            // 
            // TXTAmountChangeDue
            // 
            this.TXTAmountChangeDue.Location = new System.Drawing.Point(182, 25);
            this.TXTAmountChangeDue.Name = "TXTAmountChangeDue";
            this.TXTAmountChangeDue.Size = new System.Drawing.Size(46, 20);
            this.TXTAmountChangeDue.TabIndex = 5;
            // 
            // TXTQuarters
            // 
            this.TXTQuarters.Location = new System.Drawing.Point(182, 69);
            this.TXTQuarters.Name = "TXTQuarters";
            this.TXTQuarters.ReadOnly = true;
            this.TXTQuarters.Size = new System.Drawing.Size(46, 20);
            this.TXTQuarters.TabIndex = 6;
            // 
            // TXTDimes
            // 
            this.TXTDimes.Location = new System.Drawing.Point(182, 98);
            this.TXTDimes.Name = "TXTDimes";
            this.TXTDimes.ReadOnly = true;
            this.TXTDimes.Size = new System.Drawing.Size(46, 20);
            this.TXTDimes.TabIndex = 7;
            // 
            // TXTNickels
            // 
            this.TXTNickels.Location = new System.Drawing.Point(182, 127);
            this.TXTNickels.Name = "TXTNickels";
            this.TXTNickels.ReadOnly = true;
            this.TXTNickels.Size = new System.Drawing.Size(46, 20);
            this.TXTNickels.TabIndex = 8;
            // 
            // TXTPennies
            // 
            this.TXTPennies.Location = new System.Drawing.Point(182, 155);
            this.TXTPennies.Name = "TXTPennies";
            this.TXTPennies.ReadOnly = true;
            this.TXTPennies.Size = new System.Drawing.Size(46, 20);
            this.TXTPennies.TabIndex = 9;
            // 
            // BTNCalculate
            // 
            this.BTNCalculate.Location = new System.Drawing.Point(56, 193);
            this.BTNCalculate.Name = "BTNCalculate";
            this.BTNCalculate.Size = new System.Drawing.Size(75, 23);
            this.BTNCalculate.TabIndex = 10;
            this.BTNCalculate.Text = "C&alculate";
            this.BTNCalculate.UseVisualStyleBackColor = true;
            this.BTNCalculate.Click += new System.EventHandler(this.BTNCalculate_Click);
            // 
            // BTNExit
            // 
            this.BTNExit.Location = new System.Drawing.Point(153, 193);
            this.BTNExit.Name = "BTNExit";
            this.BTNExit.Size = new System.Drawing.Size(75, 23);
            this.BTNExit.TabIndex = 11;
            this.BTNExit.Text = "E&xit";
            this.BTNExit.UseVisualStyleBackColor = true;
            this.BTNExit.Click += new System.EventHandler(this.BTNExit_Click);
            // 
            // frmChangeCalculator
            // 
            this.AcceptButton = this.BTNCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTNExit;
            this.ClientSize = new System.Drawing.Size(253, 228);
            this.Controls.Add(this.BTNExit);
            this.Controls.Add(this.BTNCalculate);
            this.Controls.Add(this.TXTPennies);
            this.Controls.Add(this.TXTNickels);
            this.Controls.Add(this.TXTDimes);
            this.Controls.Add(this.TXTQuarters);
            this.Controls.Add(this.TXTAmountChangeDue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmChangeCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXTAmountChangeDue;
        private System.Windows.Forms.TextBox TXTQuarters;
        private System.Windows.Forms.TextBox TXTDimes;
        private System.Windows.Forms.TextBox TXTNickels;
        private System.Windows.Forms.TextBox TXTPennies;
        private System.Windows.Forms.Button BTNCalculate;
        private System.Windows.Forms.Button BTNExit;
    }
}

