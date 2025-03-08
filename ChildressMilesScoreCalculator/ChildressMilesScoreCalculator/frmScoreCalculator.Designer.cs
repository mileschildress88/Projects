namespace ChildressMilesScoreCalculator
{
    partial class frmScoreCalculator
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
            this.BTNAdd = new System.Windows.Forms.Button();
            this.BTNClearScores = new System.Windows.Forms.Button();
            this.BTNExit = new System.Windows.Forms.Button();
            this.LBLScore = new System.Windows.Forms.Label();
            this.LBLScoreTotal = new System.Windows.Forms.Label();
            this.LBLScoreCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTScore = new System.Windows.Forms.TextBox();
            this.TXTScoreTotal = new System.Windows.Forms.TextBox();
            this.TXTScoreCount = new System.Windows.Forms.TextBox();
            this.TXTAverage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTNAdd
            // 
            this.BTNAdd.Location = new System.Drawing.Point(156, 18);
            this.BTNAdd.Name = "BTNAdd";
            this.BTNAdd.Size = new System.Drawing.Size(84, 28);
            this.BTNAdd.TabIndex = 0;
            this.BTNAdd.Text = "A&dd";
            this.BTNAdd.UseVisualStyleBackColor = true;
            this.BTNAdd.Click += new System.EventHandler(this.BTNAdd_Click);
            // 
            // BTNClearScores
            // 
            this.BTNClearScores.Location = new System.Drawing.Point(66, 143);
            this.BTNClearScores.Name = "BTNClearScores";
            this.BTNClearScores.Size = new System.Drawing.Size(84, 28);
            this.BTNClearScores.TabIndex = 1;
            this.BTNClearScores.Text = "Clear Scores";
            this.BTNClearScores.UseVisualStyleBackColor = true;
            this.BTNClearScores.Click += new System.EventHandler(this.BTNClearScores_Click);
            // 
            // BTNExit
            // 
            this.BTNExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTNExit.Location = new System.Drawing.Point(156, 143);
            this.BTNExit.Name = "BTNExit";
            this.BTNExit.Size = new System.Drawing.Size(84, 28);
            this.BTNExit.TabIndex = 2;
            this.BTNExit.Text = "E&xit";
            this.BTNExit.UseVisualStyleBackColor = true;
            this.BTNExit.Click += new System.EventHandler(this.BTNExit_Click);
            // 
            // LBLScore
            // 
            this.LBLScore.AutoSize = true;
            this.LBLScore.Location = new System.Drawing.Point(41, 21);
            this.LBLScore.Name = "LBLScore";
            this.LBLScore.Size = new System.Drawing.Size(38, 13);
            this.LBLScore.TabIndex = 3;
            this.LBLScore.Text = "Score:";
            // 
            // LBLScoreTotal
            // 
            this.LBLScoreTotal.AutoSize = true;
            this.LBLScoreTotal.Location = new System.Drawing.Point(14, 51);
            this.LBLScoreTotal.Name = "LBLScoreTotal";
            this.LBLScoreTotal.Size = new System.Drawing.Size(65, 13);
            this.LBLScoreTotal.TabIndex = 4;
            this.LBLScoreTotal.Text = "Score Total:";
            // 
            // LBLScoreCount
            // 
            this.LBLScoreCount.AutoSize = true;
            this.LBLScoreCount.Location = new System.Drawing.Point(11, 80);
            this.LBLScoreCount.Name = "LBLScoreCount";
            this.LBLScoreCount.Size = new System.Drawing.Size(69, 13);
            this.LBLScoreCount.TabIndex = 5;
            this.LBLScoreCount.Text = "Score Count:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Average:";
            // 
            // TXTScore
            // 
            this.TXTScore.Location = new System.Drawing.Point(82, 18);
            this.TXTScore.Name = "TXTScore";
            this.TXTScore.Size = new System.Drawing.Size(51, 20);
            this.TXTScore.TabIndex = 7;
            // 
            // TXTScoreTotal
            // 
            this.TXTScoreTotal.Location = new System.Drawing.Point(82, 48);
            this.TXTScoreTotal.Name = "TXTScoreTotal";
            this.TXTScoreTotal.ReadOnly = true;
            this.TXTScoreTotal.Size = new System.Drawing.Size(51, 20);
            this.TXTScoreTotal.TabIndex = 8;
            // 
            // TXTScoreCount
            // 
            this.TXTScoreCount.Location = new System.Drawing.Point(82, 77);
            this.TXTScoreCount.Name = "TXTScoreCount";
            this.TXTScoreCount.ReadOnly = true;
            this.TXTScoreCount.Size = new System.Drawing.Size(51, 20);
            this.TXTScoreCount.TabIndex = 9;
            // 
            // TXTAverage
            // 
            this.TXTAverage.Location = new System.Drawing.Point(82, 107);
            this.TXTAverage.Name = "TXTAverage";
            this.TXTAverage.ReadOnly = true;
            this.TXTAverage.Size = new System.Drawing.Size(51, 20);
            this.TXTAverage.TabIndex = 10;
            // 
            // frmScoreCalculator
            // 
            this.AcceptButton = this.BTNAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTNExit;
            this.ClientSize = new System.Drawing.Size(273, 183);
            this.Controls.Add(this.TXTAverage);
            this.Controls.Add(this.TXTScoreCount);
            this.Controls.Add(this.TXTScoreTotal);
            this.Controls.Add(this.TXTScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LBLScoreCount);
            this.Controls.Add(this.LBLScoreTotal);
            this.Controls.Add(this.LBLScore);
            this.Controls.Add(this.BTNExit);
            this.Controls.Add(this.BTNClearScores);
            this.Controls.Add(this.BTNAdd);
            this.Name = "frmScoreCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Score Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNAdd;
        private System.Windows.Forms.Button BTNClearScores;
        private System.Windows.Forms.Button BTNExit;
        private System.Windows.Forms.Label LBLScore;
        private System.Windows.Forms.Label LBLScoreTotal;
        private System.Windows.Forms.Label LBLScoreCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTScore;
        private System.Windows.Forms.TextBox TXTScoreTotal;
        private System.Windows.Forms.TextBox TXTScoreCount;
        private System.Windows.Forms.TextBox TXTAverage;
    }
}

