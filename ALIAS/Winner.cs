using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALIAS
{
    public partial class Winner : Form
    {
        public MainMenu main_form;
        List<Firework> fireworks_list = new List<Firework>();
        
        public Winner(string winnerName, int winnerScore, MainMenu mainForm)
        {           
            InitializeComponent();
            main_form = mainForm;
            lblWinnerName.Text = winnerName;
            lblWinnerScore.Text = winnerScore.ToString();
        }

        // loading images     
        private void FormMouseDown(object sender, MouseEventArgs e)
        {
            Point mousePosition = new Point();
            mousePosition.X = e.X;
            mousePosition.Y = e.Y;

            Firework newFirework = new Firework();
            newFirework.position.X = mousePosition.X - (newFirework.width / 2);
            newFirework.position.Y = mousePosition.Y - (newFirework.width / 2);
            fireworks_list.Add(newFirework);
        }

        //drawing everything on the form
        private void FormPaintEvent(object sender, PaintEventArgs e)
        {
            foreach (Firework newFirework in fireworks_list.ToList())
            {
                if (newFirework.animationComplete == false)
                {
                    e.Graphics.DrawImage(newFirework.firework, newFirework.position.X, newFirework.position.Y, newFirework.width, newFirework.height);
                }
            }
        }

        private void AnimationTimerEvent(object sender, EventArgs e)
        {
            if (fireworks_list != null)
            {
                foreach (Firework firework in fireworks_list.ToList())
                {
                    if (firework.animationComplete == false)
                    {
                        firework.AnimateFirework();
                    }
                    else
                    {
                        fireworks_list.Remove(firework);
                    }
                }
            }
            this.Invalidate();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            var rnd = new Random();
            int rndX = 20 + rnd.Next(750);
            int rndY = 20 + rnd.Next(450);

            Point mousePosition = new Point();
            mousePosition.X = rndX;
            mousePosition.Y = rndY;

            Firework newFirework = new Firework();
            newFirework.position.X = mousePosition.X - (newFirework.width / 2);
            newFirework.position.Y = mousePosition.Y - (newFirework.width / 2);
            fireworks_list.Add(newFirework);
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            main_form.Show();
            this.Close();
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            DialogResult warning = MessageBox.Show("Вы действительно хотите выйти из программы? ", "Завершение программы", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (warning == DialogResult.Yes)
            {
                this.Close();
            }
        }

        
    }
}
