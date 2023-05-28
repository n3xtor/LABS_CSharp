using System;
using System.Drawing;

namespace PopTheBall
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        public void PenaltyTimer_Tick(object sender, EventArgs e)
        {
            if (currentBall.BackColor == Color.Green)
            {
                return; // Перевірка чи кулька зелена і виконання return
            }
            penalty +=10;
            penaltyLabel.Text = $"Penalty: {penalty}";

            if (penalty >= 100) // Якщо штраф досягне 100, гра завершується
            {
                EndGame();
            }
        }

        private void InitializeComponent()
        {
            this.scoreLabel = new System.Windows.Forms.Label();
            this.penaltyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(16, 11);
            this.scoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(86, 25);
            this.scoreLabel.TabIndex = 0;
            this.scoreLabel.Text = "Score: 0";
            // 
            // penaltyLabel
            // 
            this.penaltyLabel.AutoSize = true;
            this.penaltyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penaltyLabel.Location = new System.Drawing.Point(16, 48);
            this.penaltyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.penaltyLabel.Name = "penaltyLabel";
            this.penaltyLabel.Size = new System.Drawing.Size(99, 25);
            this.penaltyLabel.TabIndex = 1;
            this.penaltyLabel.Text = "Penalty: 0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(532, 463);
            this.Controls.Add(this.penaltyLabel);
            this.Controls.Add(this.scoreLabel);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "PopTheBall";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label penaltyLabel;
    }
}