namespace ChildressMilesSimpleCalculator
{
    partial class frmSimpleCalculator
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
            this.TXTOperand1 = new System.Windows.Forms.TextBox();
            this.TXTOperator = new System.Windows.Forms.TextBox();
            this.TXTOperand2 = new System.Windows.Forms.TextBox();
            this.TXTResult = new System.Windows.Forms.TextBox();
            this.BTNCalculate = new System.Windows.Forms.Button();
            this.BTNExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operand 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Operator:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Operand 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Result:";
            // 
            // TXTOperand1
            // 
            this.TXTOperand1.Location = new System.Drawing.Point(92, 6);
            this.TXTOperand1.Name = "TXTOperand1";
            this.TXTOperand1.Size = new System.Drawing.Size(100, 20);
            this.TXTOperand1.TabIndex = 4;
            this.TXTOperand1.TextChanged += new System.EventHandler(this.TXTOperand1_TextChanged);
            // 
            // TXTOperator
            // 
            this.TXTOperator.Location = new System.Drawing.Point(92, 35);
            this.TXTOperator.Name = "TXTOperator";
            this.TXTOperator.Size = new System.Drawing.Size(28, 20);
            this.TXTOperator.TabIndex = 5;
            this.TXTOperator.TextChanged += new System.EventHandler(this.TXTOperator_TextChanged);
            // 
            // TXTOperand2
            // 
            this.TXTOperand2.Location = new System.Drawing.Point(92, 64);
            this.TXTOperand2.Name = "TXTOperand2";
            this.TXTOperand2.Size = new System.Drawing.Size(100, 20);
            this.TXTOperand2.TabIndex = 6;
            this.TXTOperand2.TextChanged += new System.EventHandler(this.TXTOperand2_TextChanged);
            // 
            // TXTResult
            // 
            this.TXTResult.Location = new System.Drawing.Point(92, 93);
            this.TXTResult.Name = "TXTResult";
            this.TXTResult.ReadOnly = true;
            this.TXTResult.Size = new System.Drawing.Size(100, 20);
            this.TXTResult.TabIndex = 7;
            // 
            // BTNCalculate
            // 
            this.BTNCalculate.Location = new System.Drawing.Point(29, 131);
            this.BTNCalculate.Name = "BTNCalculate";
            this.BTNCalculate.Size = new System.Drawing.Size(75, 23);
            this.BTNCalculate.TabIndex = 8;
            this.BTNCalculate.Text = "C&alculate";
            this.BTNCalculate.UseVisualStyleBackColor = true;
            this.BTNCalculate.Click += new System.EventHandler(this.BTNCalculate_Click);
            // 
            // BTNExit
            // 
            this.BTNExit.Location = new System.Drawing.Point(116, 131);
            this.BTNExit.Name = "BTNExit";
            this.BTNExit.Size = new System.Drawing.Size(75, 23);
            this.BTNExit.TabIndex = 9;
            this.BTNExit.Text = "E&xit";
            this.BTNExit.UseVisualStyleBackColor = true;
            this.BTNExit.Click += new System.EventHandler(this.BTNExit_Click);
            // 
            // frmSimpleCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 166);
            this.Controls.Add(this.BTNExit);
            this.Controls.Add(this.BTNCalculate);
            this.Controls.Add(this.TXTResult);
            this.Controls.Add(this.TXTOperand2);
            this.Controls.Add(this.TXTOperator);
            this.Controls.Add(this.TXTOperand1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSimpleCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTOperand1;
        private System.Windows.Forms.TextBox TXTOperator;
        private System.Windows.Forms.TextBox TXTOperand2;
        private System.Windows.Forms.TextBox TXTResult;
        private System.Windows.Forms.Button BTNCalculate;
        private System.Windows.Forms.Button BTNExit;
    }
}

