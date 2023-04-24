using System;
using System.Drawing;
using System.Windows.Forms;

namespace ALIAS
{
    public partial class GameSettings : Form
    {
        public MainMenu _parent;

        public GameSettings(MainMenu parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void GameSettings_Load(object sender, EventArgs e)
        {
            cboPlayers.BackColor = Color.Plum;
            cboPlayers.ForeColor = Color.Black;
            cboPlayers.Width = 250;
            cboPlayers.Height = 33;
            cboPlayers.DropDownWidth = 250;
            cboPlayers.DropDownHeight = 40;
            cboPlayers.Font = new Font("MV Boli", 10);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(cboPlayers.Text))
            {
                MessageBox.Show("Пожалуйста, выберите количество команд");
            }
            else
            {
                GameTeams wnd = new GameTeams(Int32.Parse(cboPlayers.Text), this);
                this.Hide();
                wnd.ShowDialog();
            }          
        }

        private void GameSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            _parent.Close();
        }
    }
}
