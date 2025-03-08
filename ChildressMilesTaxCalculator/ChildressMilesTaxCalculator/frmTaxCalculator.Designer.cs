namespace ChildressMilesTaxCalculator
{
    partial class frmTaxCalculator
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
            this.BTNCalculate = new System.Windows.Forms.Button();
            this.BTNExit = new System.Windows.Forms.Button();
            this.TXTTaxableIncome = new System.Windows.Forms.TextBox();
            this.TXTIncomeTaxOwed = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Taxable Income:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Income tax owed:";
            // 
            // BTNCalculate
            // 
            this.BTNCalculate.Location = new System.Drawing.Point(51, 97);
            this.BTNCalculate.Name = "BTNCalculate";
            this.BTNCalculate.Size = new System.Drawing.Size(75, 23);
            this.BTNCalculate.TabIndex = 2;
            this.BTNCalculate.Text = "C&alculate";
            this.BTNCalculate.UseVisualStyleBackColor = true;
            this.BTNCalculate.Click += new System.EventHandler(this.BTNCalculate_Click);
            // 
            // BTNExit
            // 
            this.BTNExit.Location = new System.Drawing.Point(152, 97);
            this.BTNExit.Name = "BTNExit";
            this.BTNExit.Size = new System.Drawing.Size(75, 23);
            this.BTNExit.TabIndex = 3;
            this.BTNExit.Text = "E&xit";
            this.BTNExit.UseVisualStyleBackColor = true;
            this.BTNExit.Click += new System.EventHandler(this.BTNExit_Click);
            // 
            // TXTTaxableIncome
            // 
            this.TXTTaxableIncome.Location = new System.Drawing.Point(127, 18);
            this.TXTTaxableIncome.Name = "TXTTaxableIncome";
            this.TXTTaxableIncome.Size = new System.Drawing.Size(100, 20);
            this.TXTTaxableIncome.TabIndex = 4;
            // 
            // TXTIncomeTaxOwed
            // 
            this.TXTIncomeTaxOwed.Location = new System.Drawing.Point(127, 57);
            this.TXTIncomeTaxOwed.Name = "TXTIncomeTaxOwed";
            this.TXTIncomeTaxOwed.ReadOnly = true;
            this.TXTIncomeTaxOwed.Size = new System.Drawing.Size(100, 20);
            this.TXTIncomeTaxOwed.TabIndex = 5;
            // 
            // frmTaxCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 142);
            this.Controls.Add(this.TXTIncomeTaxOwed);
            this.Controls.Add(this.TXTTaxableIncome);
            this.Controls.Add(this.BTNExit);
            this.Controls.Add(this.BTNCalculate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTaxCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tax Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTNCalculate;
        private System.Windows.Forms.Button BTNExit;
        private System.Windows.Forms.TextBox TXTTaxableIncome;
        private System.Windows.Forms.TextBox TXTIncomeTaxOwed;
    }
}

