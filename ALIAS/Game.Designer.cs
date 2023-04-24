
namespace ALIAS
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MainPanel = new System.Windows.Forms.Panel();
            this.btnReady = new System.Windows.Forms.Button();
            this.btnFalseNext = new System.Windows.Forms.Button();
            this.DBWord = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.btnTrueNext = new System.Windows.Forms.Button();
            this.PlayerName = new System.Windows.Forms.Label();
            this.SummaryPanel = new System.Windows.Forms.Panel();
            this.lblMaxScore = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCurrentScore = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.richTextBoxWordsSummary = new System.Windows.Forms.RichTextBox();
            this.MainPanel.SuspendLayout();
            this.SummaryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainPanel.Controls.Add(this.btnReady);
            this.MainPanel.Controls.Add(this.btnFalseNext);
            this.MainPanel.Controls.Add(this.DBWord);
            this.MainPanel.Controls.Add(this.lblSeconds);
            this.MainPanel.Controls.Add(this.btnTrueNext);
            this.MainPanel.Controls.Add(this.PlayerName);
            this.MainPanel.Location = new System.Drawing.Point(11, 15);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(792, 449);
            this.MainPanel.TabIndex = 6;
            // 
            // btnReady
            // 
            this.btnReady.BackColor = System.Drawing.Color.Plum;
            this.btnReady.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReady.Location = new System.Drawing.Point(275, 148);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(206, 99);
            this.btnReady.TabIndex = 7;
            this.btnReady.Text = "START";
            this.btnReady.UseVisualStyleBackColor = false;
            this.btnReady.Click += new System.EventHandler(this.btnReady_Click);
            // 
            // btnFalseNext
            // 
            this.btnFalseNext.BackColor = System.Drawing.Color.Plum;
            this.btnFalseNext.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFalseNext.Location = new System.Drawing.Point(314, 273);
            this.btnFalseNext.Name = "btnFalseNext";
            this.btnFalseNext.Size = new System.Drawing.Size(135, 46);
            this.btnFalseNext.TabIndex = 10;
            this.btnFalseNext.Text = "FALSE";
            this.btnFalseNext.UseVisualStyleBackColor = false;
            this.btnFalseNext.Click += new System.EventHandler(this.btnFalseNext_Click);
            // 
            // DBWord
            // 
            this.DBWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DBWord.Location = new System.Drawing.Point(3, 178);
            this.DBWord.Name = "DBWord";
            this.DBWord.Size = new System.Drawing.Size(779, 37);
            this.DBWord.TabIndex = 8;
            this.DBWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSeconds.Location = new System.Drawing.Point(726, 7);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(38, 25);
            this.lblSeconds.TabIndex = 11;
            this.lblSeconds.Text = "00";
            // 
            // btnTrueNext
            // 
            this.btnTrueNext.BackColor = System.Drawing.Color.Plum;
            this.btnTrueNext.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrueNext.Location = new System.Drawing.Point(314, 79);
            this.btnTrueNext.Name = "btnTrueNext";
            this.btnTrueNext.Size = new System.Drawing.Size(135, 50);
            this.btnTrueNext.TabIndex = 9;
            this.btnTrueNext.Text = "TRUE";
            this.btnTrueNext.UseVisualStyleBackColor = false;
            this.btnTrueNext.Click += new System.EventHandler(this.btnTrueNext_Click);
            // 
            // PlayerName
            // 
            this.PlayerName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayerName.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerName.Location = new System.Drawing.Point(138, 19);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(500, 25);
            this.PlayerName.TabIndex = 6;
            this.PlayerName.Text = "label1";
            this.PlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SummaryPanel
            // 
            this.SummaryPanel.BackColor = System.Drawing.Color.Transparent;
            this.SummaryPanel.Controls.Add(this.lblMaxScore);
            this.SummaryPanel.Controls.Add(this.label8);
            this.SummaryPanel.Controls.Add(this.label9);
            this.SummaryPanel.Controls.Add(this.lblCurrentScore);
            this.SummaryPanel.Controls.Add(this.button4);
            this.SummaryPanel.Controls.Add(this.lblName);
            this.SummaryPanel.Controls.Add(this.richTextBoxWordsSummary);
            this.SummaryPanel.Location = new System.Drawing.Point(12, 12);
            this.SummaryPanel.Name = "SummaryPanel";
            this.SummaryPanel.Size = new System.Drawing.Size(791, 466);
            this.SummaryPanel.TabIndex = 7;
            this.SummaryPanel.Visible = false;
            // 
            // lblMaxScore
            // 
            this.lblMaxScore.AutoSize = true;
            this.lblMaxScore.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxScore.Location = new System.Drawing.Point(697, 58);
            this.lblMaxScore.Name = "lblMaxScore";
            this.lblMaxScore.Size = new System.Drawing.Size(0, 25);
            this.lblMaxScore.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(644, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 21);
            this.label8.TabIndex = 12;
            this.label8.Text = "Maximum score:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(671, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 21);
            this.label9.TabIndex = 11;
            this.label9.Text = "My score:";
            // 
            // lblCurrentScore
            // 
            this.lblCurrentScore.AutoSize = true;
            this.lblCurrentScore.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentScore.Location = new System.Drawing.Point(685, 137);
            this.lblCurrentScore.Name = "lblCurrentScore";
            this.lblCurrentScore.Size = new System.Drawing.Size(64, 25);
            this.lblCurrentScore.TabIndex = 10;
            this.lblCurrentScore.Text = "label1";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(285, 307);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(182, 66);
            this.button4.TabIndex = 9;
            this.button4.Text = "NEXT";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnNextPlayer_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(367, 14);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 13);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "label";
            // 
            // richTextBoxWordsSummary
            // 
            this.richTextBoxWordsSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxWordsSummary.Location = new System.Drawing.Point(177, 37);
            this.richTextBoxWordsSummary.Name = "richTextBoxWordsSummary";
            this.richTextBoxWordsSummary.Size = new System.Drawing.Size(414, 260);
            this.richTextBoxWordsSummary.TabIndex = 7;
            this.richTextBoxWordsSummary.Text = "";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ALIAS.Properties.Resources._15539294__1_мм;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(806, 490);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.SummaryPanel);
            this.DoubleBuffered = true;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.SummaryPanel.ResumeLayout(false);
            this.SummaryPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button btnFalseNext;
        private System.Windows.Forms.Label DBWord;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Button btnTrueNext;
        private System.Windows.Forms.Button btnReady;
        private System.Windows.Forms.Label PlayerName;
        private System.Windows.Forms.Panel SummaryPanel;
        private System.Windows.Forms.Label lblMaxScore;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCurrentScore;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.RichTextBox richTextBoxWordsSummary;
    }
}