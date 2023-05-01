
namespace ALIAS
{
    partial class Winner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Winner));
            this.AnimationTimer = new System.Windows.Forms.Timer(this.components);
            this.lblWinnerScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWinnerName = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.btnCLose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AnimationTimer
            // 
            this.AnimationTimer.Enabled = true;
            this.AnimationTimer.Interval = 20;
            this.AnimationTimer.Tick += new System.EventHandler(this.AnimationTimerEvent);
            // 
            // lblWinnerScore
            // 
            this.lblWinnerScore.BackColor = System.Drawing.Color.Transparent;
            this.lblWinnerScore.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWinnerScore.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblWinnerScore.Location = new System.Drawing.Point(205, 240);
            this.lblWinnerScore.Name = "lblWinnerScore";
            this.lblWinnerScore.Size = new System.Drawing.Size(400, 45);
            this.lblWinnerScore.TabIndex = 2;
            this.lblWinnerScore.Text = "333";
            this.lblWinnerScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(223, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 98);
            this.label1.TabIndex = 0;
            this.label1.Text = "WINNER WINNER \r\nCHICKEN DINNER!";
            // 
            // lblWinnerName
            // 
            this.lblWinnerName.BackColor = System.Drawing.Color.Transparent;
            this.lblWinnerName.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWinnerName.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblWinnerName.Location = new System.Drawing.Point(205, 152);
            this.lblWinnerName.Name = "lblWinnerName";
            this.lblWinnerName.Size = new System.Drawing.Size(400, 45);
            this.lblWinnerName.TabIndex = 1;
            this.lblWinnerName.Text = "sssssss";
            this.lblWinnerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWinnerName.Paint += new System.Windows.Forms.PaintEventHandler(this.FormPaintEvent);
            this.lblWinnerName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMouseDown);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.BackColor = System.Drawing.Color.Plum;
            this.btnBackToMenu.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBackToMenu.Location = new System.Drawing.Point(22, 388);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(122, 50);
            this.btnBackToMenu.TabIndex = 3;
            this.btnBackToMenu.Text = "MENU";
            this.btnBackToMenu.UseVisualStyleBackColor = false;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // btnCLose
            // 
            this.btnCLose.BackColor = System.Drawing.Color.Plum;
            this.btnCLose.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCLose.Location = new System.Drawing.Point(659, 388);
            this.btnCLose.Name = "btnCLose";
            this.btnCLose.Size = new System.Drawing.Size(119, 50);
            this.btnCLose.TabIndex = 4;
            this.btnCLose.Text = "EXIT";
            this.btnCLose.UseVisualStyleBackColor = false;
            this.btnCLose.Click += new System.EventHandler(this.btnCLose_Click);
            // 
            // Winner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ALIAS.Properties.Resources._15539294__1_мм;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCLose);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.lblWinnerScore);
            this.Controls.Add(this.lblWinnerName);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Winner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALIAS";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Winner_FormClosed);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormPaintEvent);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer AnimationTimer;
        private System.Windows.Forms.Label lblWinnerScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWinnerName;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnBackToMenu;
        private System.Windows.Forms.Button btnCLose;
    }
}