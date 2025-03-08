namespace ChildressMilesPushMe
{
    partial class FRMPushMe
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
            this.BTNPushMe1 = new System.Windows.Forms.Button();
            this.BTNPushMe2 = new System.Windows.Forms.Button();
            this.BTNPushMe3 = new System.Windows.Forms.Button();
            this.BTNPushMe4 = new System.Windows.Forms.Button();
            this.BTNExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTNPushMe1
            // 
            this.BTNPushMe1.Location = new System.Drawing.Point(78, 32);
            this.BTNPushMe1.Name = "BTNPushMe1";
            this.BTNPushMe1.Size = new System.Drawing.Size(138, 48);
            this.BTNPushMe1.TabIndex = 0;
            this.BTNPushMe1.Text = "Push Me";
            this.BTNPushMe1.UseVisualStyleBackColor = true;
            this.BTNPushMe1.Click += new System.EventHandler(this.BTNPushMe1_Click);
            // 
            // BTNPushMe2
            // 
            this.BTNPushMe2.Location = new System.Drawing.Point(242, 32);
            this.BTNPushMe2.Name = "BTNPushMe2";
            this.BTNPushMe2.Size = new System.Drawing.Size(138, 48);
            this.BTNPushMe2.TabIndex = 1;
            this.BTNPushMe2.Text = "Push Me";
            this.BTNPushMe2.UseVisualStyleBackColor = true;
            this.BTNPushMe2.Click += new System.EventHandler(this.BTNPushMe2_Click);
            // 
            // BTNPushMe3
            // 
            this.BTNPushMe3.Location = new System.Drawing.Point(78, 98);
            this.BTNPushMe3.Name = "BTNPushMe3";
            this.BTNPushMe3.Size = new System.Drawing.Size(138, 48);
            this.BTNPushMe3.TabIndex = 2;
            this.BTNPushMe3.Text = "Push Me";
            this.BTNPushMe3.UseVisualStyleBackColor = true;
            this.BTNPushMe3.Click += new System.EventHandler(this.BTNPushMe3_Click);
            // 
            // BTNPushMe4
            // 
            this.BTNPushMe4.Location = new System.Drawing.Point(242, 98);
            this.BTNPushMe4.Name = "BTNPushMe4";
            this.BTNPushMe4.Size = new System.Drawing.Size(138, 48);
            this.BTNPushMe4.TabIndex = 3;
            this.BTNPushMe4.Text = "Push Me";
            this.BTNPushMe4.UseVisualStyleBackColor = true;
            this.BTNPushMe4.Click += new System.EventHandler(this.BTNPushMe4_Click);
            // 
            // BTNExit
            // 
            this.BTNExit.Location = new System.Drawing.Point(173, 152);
            this.BTNExit.Name = "BTNExit";
            this.BTNExit.Size = new System.Drawing.Size(109, 45);
            this.BTNExit.TabIndex = 4;
            this.BTNExit.Text = "E&xit";
            this.BTNExit.UseVisualStyleBackColor = true;
            this.BTNExit.Click += new System.EventHandler(this.BTNExit_Click);
            // 
            // FRMPushMe
            // 
            this.AcceptButton = this.BTNPushMe1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTNExit;
            this.ClientSize = new System.Drawing.Size(478, 227);
            this.Controls.Add(this.BTNExit);
            this.Controls.Add(this.BTNPushMe4);
            this.Controls.Add(this.BTNPushMe3);
            this.Controls.Add(this.BTNPushMe2);
            this.Controls.Add(this.BTNPushMe1);
            this.Name = "FRMPushMe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Push Me";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNPushMe1;
        private System.Windows.Forms.Button BTNPushMe2;
        private System.Windows.Forms.Button BTNPushMe3;
        private System.Windows.Forms.Button BTNPushMe4;
        private System.Windows.Forms.Button BTNExit;
    }
}

