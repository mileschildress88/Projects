namespace ChildressMilesIsPalindrome
{
    partial class frmPalindrome
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
            this.TXTInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNCheck = new System.Windows.Forms.Button();
            this.BTNExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TXTInput
            // 
            this.TXTInput.Location = new System.Drawing.Point(76, 12);
            this.TXTInput.Name = "TXTInput";
            this.TXTInput.Size = new System.Drawing.Size(238, 20);
            this.TXTInput.TabIndex = 0;
            this.TXTInput.Tag = "Input";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Text Input:";
            // 
            // BTNCheck
            // 
            this.BTNCheck.Location = new System.Drawing.Point(15, 50);
            this.BTNCheck.Name = "BTNCheck";
            this.BTNCheck.Size = new System.Drawing.Size(136, 35);
            this.BTNCheck.TabIndex = 2;
            this.BTNCheck.Text = "C&heck";
            this.BTNCheck.UseVisualStyleBackColor = true;
            this.BTNCheck.Click += new System.EventHandler(this.BTNCheck_Click);
            // 
            // BTNExit
            // 
            this.BTNExit.Location = new System.Drawing.Point(178, 50);
            this.BTNExit.Name = "BTNExit";
            this.BTNExit.Size = new System.Drawing.Size(136, 35);
            this.BTNExit.TabIndex = 3;
            this.BTNExit.Text = "E&xit";
            this.BTNExit.UseVisualStyleBackColor = true;
            this.BTNExit.Click += new System.EventHandler(this.BTNExit_Click);
            // 
            // frmPalindrome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 97);
            this.Controls.Add(this.BTNExit);
            this.Controls.Add(this.BTNCheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTInput);
            this.Name = "frmPalindrome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Palindrome Checker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNCheck;
        private System.Windows.Forms.Button BTNExit;
    }
}

