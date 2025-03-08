namespace ChildressMilesAreaAndPerimeter
{
    partial class frmAreaAndPerimeter
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
            this.TXTLength = new System.Windows.Forms.TextBox();
            this.TXTWidth = new System.Windows.Forms.TextBox();
            this.TXTArea = new System.Windows.Forms.TextBox();
            this.TXTPerimeter = new System.Windows.Forms.TextBox();
            this.BTNCalculate = new System.Windows.Forms.Button();
            this.BTNExit = new System.Windows.Forms.Button();
            this.LBLLength = new System.Windows.Forms.Label();
            this.LBLWidth = new System.Windows.Forms.Label();
            this.LBLArea = new System.Windows.Forms.Label();
            this.LBLPerimeter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TXTLength
            // 
            this.TXTLength.Location = new System.Drawing.Point(82, 19);
            this.TXTLength.Name = "TXTLength";
            this.TXTLength.Size = new System.Drawing.Size(100, 20);
            this.TXTLength.TabIndex = 0;
            // 
            // TXTWidth
            // 
            this.TXTWidth.Location = new System.Drawing.Point(82, 47);
            this.TXTWidth.Name = "TXTWidth";
            this.TXTWidth.Size = new System.Drawing.Size(100, 20);
            this.TXTWidth.TabIndex = 1;
            // 
            // TXTArea
            // 
            this.TXTArea.Location = new System.Drawing.Point(82, 73);
            this.TXTArea.Name = "TXTArea";
            this.TXTArea.ReadOnly = true;
            this.TXTArea.Size = new System.Drawing.Size(100, 20);
            this.TXTArea.TabIndex = 2;
            // 
            // TXTPerimeter
            // 
            this.TXTPerimeter.Location = new System.Drawing.Point(82, 102);
            this.TXTPerimeter.Name = "TXTPerimeter";
            this.TXTPerimeter.ReadOnly = true;
            this.TXTPerimeter.Size = new System.Drawing.Size(100, 20);
            this.TXTPerimeter.TabIndex = 3;
            // 
            // BTNCalculate
            // 
            this.BTNCalculate.Location = new System.Drawing.Point(27, 140);
            this.BTNCalculate.Name = "BTNCalculate";
            this.BTNCalculate.Size = new System.Drawing.Size(75, 23);
            this.BTNCalculate.TabIndex = 4;
            this.BTNCalculate.Text = "C&alculate";
            this.BTNCalculate.UseVisualStyleBackColor = true;
            this.BTNCalculate.Click += new System.EventHandler(this.BTNCalculate_Click);
            // 
            // BTNExit
            // 
            this.BTNExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTNExit.Location = new System.Drawing.Point(108, 140);
            this.BTNExit.Name = "BTNExit";
            this.BTNExit.Size = new System.Drawing.Size(75, 23);
            this.BTNExit.TabIndex = 5;
            this.BTNExit.Text = "E&xit";
            this.BTNExit.UseVisualStyleBackColor = true;
            this.BTNExit.Click += new System.EventHandler(this.BTNExit_Click);
            // 
            // LBLLength
            // 
            this.LBLLength.AutoSize = true;
            this.LBLLength.Location = new System.Drawing.Point(24, 19);
            this.LBLLength.Name = "LBLLength";
            this.LBLLength.Size = new System.Drawing.Size(43, 13);
            this.LBLLength.TabIndex = 6;
            this.LBLLength.Text = "Length:";
            // 
            // LBLWidth
            // 
            this.LBLWidth.AutoSize = true;
            this.LBLWidth.Location = new System.Drawing.Point(24, 50);
            this.LBLWidth.Name = "LBLWidth";
            this.LBLWidth.Size = new System.Drawing.Size(38, 13);
            this.LBLWidth.TabIndex = 7;
            this.LBLWidth.Text = "Width:";
            // 
            // LBLArea
            // 
            this.LBLArea.AutoSize = true;
            this.LBLArea.Location = new System.Drawing.Point(24, 76);
            this.LBLArea.Name = "LBLArea";
            this.LBLArea.Size = new System.Drawing.Size(32, 13);
            this.LBLArea.TabIndex = 8;
            this.LBLArea.Text = "Area:";
            // 
            // LBLPerimeter
            // 
            this.LBLPerimeter.AutoSize = true;
            this.LBLPerimeter.Location = new System.Drawing.Point(24, 105);
            this.LBLPerimeter.Name = "LBLPerimeter";
            this.LBLPerimeter.Size = new System.Drawing.Size(54, 13);
            this.LBLPerimeter.TabIndex = 9;
            this.LBLPerimeter.Text = "Perimeter:";
            // 
            // frmAreaAndPerimeter
            // 
            this.AcceptButton = this.BTNCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTNExit;
            this.ClientSize = new System.Drawing.Size(222, 180);
            this.Controls.Add(this.LBLPerimeter);
            this.Controls.Add(this.LBLArea);
            this.Controls.Add(this.LBLWidth);
            this.Controls.Add(this.LBLLength);
            this.Controls.Add(this.BTNExit);
            this.Controls.Add(this.BTNCalculate);
            this.Controls.Add(this.TXTPerimeter);
            this.Controls.Add(this.TXTArea);
            this.Controls.Add(this.TXTWidth);
            this.Controls.Add(this.TXTLength);
            this.Name = "frmAreaAndPerimeter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Area and Perimeter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTLength;
        private System.Windows.Forms.TextBox TXTWidth;
        private System.Windows.Forms.TextBox TXTArea;
        private System.Windows.Forms.TextBox TXTPerimeter;
        private System.Windows.Forms.Button BTNCalculate;
        private System.Windows.Forms.Button BTNExit;
        private System.Windows.Forms.Label LBLLength;
        private System.Windows.Forms.Label LBLWidth;
        private System.Windows.Forms.Label LBLArea;
        private System.Windows.Forms.Label LBLPerimeter;
    }
}

