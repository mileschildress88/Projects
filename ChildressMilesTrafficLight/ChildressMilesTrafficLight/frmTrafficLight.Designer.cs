namespace ChildressMilesTrafficLight
{
    partial class frmTrafficLight
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
            this.BTNExit = new System.Windows.Forms.Button();
            this.TXTRedLight = new System.Windows.Forms.TextBox();
            this.TXTYellowLight = new System.Windows.Forms.TextBox();
            this.TXTGreenLight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTNExit
            // 
            this.BTNExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTNExit.Location = new System.Drawing.Point(115, 90);
            this.BTNExit.Name = "BTNExit";
            this.BTNExit.Size = new System.Drawing.Size(73, 31);
            this.BTNExit.TabIndex = 3;
            this.BTNExit.Text = "E&xit";
            this.BTNExit.UseVisualStyleBackColor = true;
            this.BTNExit.Click += new System.EventHandler(this.BTNExit_Click);
            // 
            // TXTRedLight
            // 
            this.TXTRedLight.Location = new System.Drawing.Point(101, 12);
            this.TXTRedLight.Name = "TXTRedLight";
            this.TXTRedLight.ReadOnly = true;
            this.TXTRedLight.Size = new System.Drawing.Size(100, 20);
            this.TXTRedLight.TabIndex = 4;
            // 
            // TXTYellowLight
            // 
            this.TXTYellowLight.Location = new System.Drawing.Point(101, 38);
            this.TXTYellowLight.Name = "TXTYellowLight";
            this.TXTYellowLight.ReadOnly = true;
            this.TXTYellowLight.Size = new System.Drawing.Size(100, 20);
            this.TXTYellowLight.TabIndex = 5;
            // 
            // TXTGreenLight
            // 
            this.TXTGreenLight.Location = new System.Drawing.Point(101, 64);
            this.TXTGreenLight.Name = "TXTGreenLight";
            this.TXTGreenLight.ReadOnly = true;
            this.TXTGreenLight.Size = new System.Drawing.Size(100, 20);
            this.TXTGreenLight.TabIndex = 6;
            // 
            // frmTrafficLight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTNExit;
            this.ClientSize = new System.Drawing.Size(295, 224);
            this.Controls.Add(this.TXTGreenLight);
            this.Controls.Add(this.TXTYellowLight);
            this.Controls.Add(this.TXTRedLight);
            this.Controls.Add(this.BTNExit);
            this.Name = "frmTrafficLight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrafficLight";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTNExit;
        private System.Windows.Forms.TextBox TXTRedLight;
        private System.Windows.Forms.TextBox TXTYellowLight;
        private System.Windows.Forms.TextBox TXTGreenLight;
    }
}

