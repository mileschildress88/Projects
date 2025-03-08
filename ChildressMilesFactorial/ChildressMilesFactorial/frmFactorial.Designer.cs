namespace ChildressMilesFactorial
{
    partial class frmFactorial
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
            this.LBLNumber = new System.Windows.Forms.Label();
            this.LBLFactorial = new System.Windows.Forms.Label();
            this.TXTNumber = new System.Windows.Forms.TextBox();
            this.TXTFactorial = new System.Windows.Forms.TextBox();
            this.BTNCalculate = new System.Windows.Forms.Button();
            this.BTNExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLNumber
            // 
            this.LBLNumber.AutoSize = true;
            this.LBLNumber.Location = new System.Drawing.Point(28, 19);
            this.LBLNumber.Name = "LBLNumber";
            this.LBLNumber.Size = new System.Drawing.Size(47, 13);
            this.LBLNumber.TabIndex = 0;
            this.LBLNumber.Text = "Number:";
            // 
            // LBLFactorial
            // 
            this.LBLFactorial.AutoSize = true;
            this.LBLFactorial.Location = new System.Drawing.Point(28, 49);
            this.LBLFactorial.Name = "LBLFactorial";
            this.LBLFactorial.Size = new System.Drawing.Size(50, 13);
            this.LBLFactorial.TabIndex = 1;
            this.LBLFactorial.Text = "Factorial:";
            // 
            // TXTNumber
            // 
            this.TXTNumber.Location = new System.Drawing.Point(84, 16);
            this.TXTNumber.Name = "TXTNumber";
            this.TXTNumber.Size = new System.Drawing.Size(39, 20);
            this.TXTNumber.TabIndex = 2;
            // 
            // TXTFactorial
            // 
            this.TXTFactorial.Location = new System.Drawing.Point(84, 46);
            this.TXTFactorial.Name = "TXTFactorial";
            this.TXTFactorial.ReadOnly = true;
            this.TXTFactorial.Size = new System.Drawing.Size(169, 20);
            this.TXTFactorial.TabIndex = 3;
            // 
            // BTNCalculate
            // 
            this.BTNCalculate.Location = new System.Drawing.Point(65, 77);
            this.BTNCalculate.Name = "BTNCalculate";
            this.BTNCalculate.Size = new System.Drawing.Size(91, 23);
            this.BTNCalculate.TabIndex = 4;
            this.BTNCalculate.Text = "C&alculate";
            this.BTNCalculate.UseVisualStyleBackColor = true;
            this.BTNCalculate.Click += new System.EventHandler(this.BTNCalculate_Click);
            // 
            // BTNExit
            // 
            this.BTNExit.Location = new System.Drawing.Point(162, 77);
            this.BTNExit.Name = "BTNExit";
            this.BTNExit.Size = new System.Drawing.Size(91, 23);
            this.BTNExit.TabIndex = 5;
            this.BTNExit.Text = "E&xit";
            this.BTNExit.UseVisualStyleBackColor = true;
            this.BTNExit.Click += new System.EventHandler(this.BTNExit_Click);
            // 
            // frmFactorial
            // 
            this.AcceptButton = this.BTNCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTNExit;
            this.ClientSize = new System.Drawing.Size(293, 110);
            this.Controls.Add(this.BTNExit);
            this.Controls.Add(this.BTNCalculate);
            this.Controls.Add(this.TXTFactorial);
            this.Controls.Add(this.TXTNumber);
            this.Controls.Add(this.LBLFactorial);
            this.Controls.Add(this.LBLNumber);
            this.Name = "frmFactorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factorial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLNumber;
        private System.Windows.Forms.Label LBLFactorial;
        private System.Windows.Forms.TextBox TXTNumber;
        private System.Windows.Forms.TextBox TXTFactorial;
        private System.Windows.Forms.Button BTNCalculate;
        private System.Windows.Forms.Button BTNExit;
    }
}

