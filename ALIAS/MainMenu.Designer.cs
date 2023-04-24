
namespace ALIAS
{
    partial class MainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.begin_Button = new System.Windows.Forms.Button();
            this.btnAdminEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // begin_Button
            // 
            this.begin_Button.BackColor = System.Drawing.Color.MediumPurple;
            this.begin_Button.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.begin_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.begin_Button.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.begin_Button.Location = new System.Drawing.Point(318, 248);
            this.begin_Button.Name = "begin_Button";
            this.begin_Button.Size = new System.Drawing.Size(166, 70);
            this.begin_Button.TabIndex = 0;
            this.begin_Button.Text = "НАЧАТЬ";
            this.begin_Button.UseVisualStyleBackColor = false;
            this.begin_Button.Click += new System.EventHandler(this.beginBtnClick);
            // 
            // btnAdminEnter
            // 
            this.btnAdminEnter.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAdminEnter.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdminEnter.Location = new System.Drawing.Point(698, 12);
            this.btnAdminEnter.Name = "btnAdminEnter";
            this.btnAdminEnter.Size = new System.Drawing.Size(90, 31);
            this.btnAdminEnter.TabIndex = 1;
            this.btnAdminEnter.Text = "Login";
            this.btnAdminEnter.UseVisualStyleBackColor = false;
            this.btnAdminEnter.Click += new System.EventHandler(this.btnAdminEnter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ALIAS.Properties.Resources.apps_62657_14275535134475214_ec2f4626_02a1_4feb_99e8_89b7fb0ec5ac;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdminEnter);
            this.Controls.Add(this.begin_Button);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button begin_Button;
        private System.Windows.Forms.Button btnAdminEnter;
    }
}

