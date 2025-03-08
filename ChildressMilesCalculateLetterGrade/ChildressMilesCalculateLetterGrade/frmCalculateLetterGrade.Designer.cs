namespace ChildressMilesCalculateLetterGrade
{
    partial class FRMCalculateGrade
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
            this.LBLNumberGrade = new System.Windows.Forms.Label();
            this.LBLLetterGrade = new System.Windows.Forms.Label();
            this.TXTNumberGrade = new System.Windows.Forms.TextBox();
            this.TXTLetterGrade = new System.Windows.Forms.TextBox();
            this.BTNCalculate = new System.Windows.Forms.Button();
            this.BTNExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLNumberGrade
            // 
            this.LBLNumberGrade.AutoSize = true;
            this.LBLNumberGrade.Location = new System.Drawing.Point(27, 22);
            this.LBLNumberGrade.Name = "LBLNumberGrade";
            this.LBLNumberGrade.Size = new System.Drawing.Size(77, 13);
            this.LBLNumberGrade.TabIndex = 0;
            this.LBLNumberGrade.Text = "&Number grade:";
            this.LBLNumberGrade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LBLLetterGrade
            // 
            this.LBLLetterGrade.AutoSize = true;
            this.LBLLetterGrade.Location = new System.Drawing.Point(27, 51);
            this.LBLLetterGrade.Name = "LBLLetterGrade";
            this.LBLLetterGrade.Size = new System.Drawing.Size(69, 13);
            this.LBLLetterGrade.TabIndex = 1;
            this.LBLLetterGrade.Text = "Letter Grade:";
            this.LBLLetterGrade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TXTNumberGrade
            // 
            this.TXTNumberGrade.Location = new System.Drawing.Point(110, 19);
            this.TXTNumberGrade.Name = "TXTNumberGrade";
            this.TXTNumberGrade.Size = new System.Drawing.Size(49, 20);
            this.TXTNumberGrade.TabIndex = 1;
            this.TXTNumberGrade.TextChanged += new System.EventHandler(this.TXTNumberGrade_TextChanged);
            // 
            // TXTLetterGrade
            // 
            this.TXTLetterGrade.Location = new System.Drawing.Point(110, 48);
            this.TXTLetterGrade.Name = "TXTLetterGrade";
            this.TXTLetterGrade.ReadOnly = true;
            this.TXTLetterGrade.Size = new System.Drawing.Size(49, 20);
            this.TXTLetterGrade.TabIndex = 2;
            this.TXTLetterGrade.TabStop = false;
            // 
            // BTNCalculate
            // 
            this.BTNCalculate.Location = new System.Drawing.Point(30, 88);
            this.BTNCalculate.Name = "BTNCalculate";
            this.BTNCalculate.Size = new System.Drawing.Size(75, 23);
            this.BTNCalculate.TabIndex = 2;
            this.BTNCalculate.Text = "&Calculate";
            this.BTNCalculate.UseVisualStyleBackColor = true;
            this.BTNCalculate.Click += new System.EventHandler(this.BTNCalculate_Click);
            // 
            // BTNExit
            // 
            this.BTNExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTNExit.Location = new System.Drawing.Point(110, 88);
            this.BTNExit.Name = "BTNExit";
            this.BTNExit.Size = new System.Drawing.Size(75, 23);
            this.BTNExit.TabIndex = 3;
            this.BTNExit.Text = "E&xit";
            this.BTNExit.UseVisualStyleBackColor = true;
            this.BTNExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // FRMCalculateGrade
            // 
            this.AcceptButton = this.BTNCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTNExit;
            this.ClientSize = new System.Drawing.Size(273, 158);
            this.Controls.Add(this.BTNExit);
            this.Controls.Add(this.BTNCalculate);
            this.Controls.Add(this.TXTLetterGrade);
            this.Controls.Add(this.TXTNumberGrade);
            this.Controls.Add(this.LBLLetterGrade);
            this.Controls.Add(this.LBLNumberGrade);
            this.Name = "FRMCalculateGrade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculate Letter Grade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLNumberGrade;
        private System.Windows.Forms.Label LBLLetterGrade;
        private System.Windows.Forms.TextBox TXTNumberGrade;
        private System.Windows.Forms.TextBox TXTLetterGrade;
        private System.Windows.Forms.Button BTNCalculate;
        private System.Windows.Forms.Button BTNExit;
    }
}

