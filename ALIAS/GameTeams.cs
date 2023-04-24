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
    public partial class GameTeams : Form
    {
        private int playersNumber;
        public GameSettings _parent;

        public GameTeams(int numbersOfPlayers, GameSettings parent)
        {
            playersNumber = numbersOfPlayers;
            _parent = parent;

            InitializeComponent();

            for (int i = 0; i < numbersOfPlayers; i++)
            {
                Label firstLabel = new Label();
                firstLabel.Location = new Point(48, 45 + i*(firstLabel.Height + 30));                
                firstLabel.Text = "Team #" + (i + 1);
                firstLabel.AutoSize = true;               
                firstLabel.BackColor = Color.Transparent;
                firstLabel.Font = new Font(firstLabel.Font.FontFamily, 12);
                TextBox textBox = new TextBox();
                textBox.Location = new Point(180, 45 + i*(textBox.Height + 30));
                textBox.Size = new Size(250,/*this.Width,*/ textBox.Height);
                textBox.Font = new Font(textBox.Font.FontFamily, 16);
                textBox.Name = "Team" + (i + 1);
                this.Controls.Add(firstLabel);
                this.Controls.Add(textBox);
            }     
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string[] players = new string[playersNumber]; 
            for (int i = 0; i < playersNumber; i++)
            {                               
                string playerName = ((TextBox)Controls["Team" + (i + 1)]).Text;
                if (String.IsNullOrWhiteSpace(playerName))
                {
                    MessageBox.Show("Введите имя команды!");
                    return;
                }
                players[i] = playerName;
            }

            Game gameStart = new Game(players, playersNumber, this);
            this.Hide();
            gameStart.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {            
            this.Hide();
            _parent.Show();
        }

        private void GameTeams_FormClosed(object sender, FormClosedEventArgs e)
        {
            _parent.Close();
        }
    }
}
