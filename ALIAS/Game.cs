using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ALIAS
{
    public partial class Game : Form
    {
        public GameTeams _parent;
        public Dictionary<int, PlayerInfo> playersData = new Dictionary<int, PlayerInfo>();
        public Dictionary<string, bool> wordsHistory = new Dictionary<string, bool>();
        private int seconds;
        private int currentPlayerIndex = 0;
        private const int maxScore = 10;

        public Game(string[] names, int number, GameTeams parent)
        {
            _parent = parent;
            InitializeComponent();

            for (int i = 0; i < names.Length; i++)
            {
                string name = names[i];
                PlayerInfo player = new PlayerInfo(name, 0);
                playersData.Add(i + 1, player);
            }
            NextPlayer();

            btnTrueNext.Visible = false;
            btnFalseNext.Visible = false;
        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            btnReady.Visible = false;
            DBWord.Visible = true;
            btnTrueNext.Visible = true;
            btnFalseNext.Visible = true;

            wordsHistory.Clear();
            richTextBoxWordsSummary.Text = "";
            NextWord();

            seconds = 5;
            timer1.Start();
        }

        private void btnTrueNext_Click(object sender, EventArgs e)
        {                      
            playersData[currentPlayerIndex].Score += 1;
            wordsHistory[DBWord.Text] = true;
            NextWord();           
        }
        private void btnFalseNext_Click(object sender, EventArgs e)
        {
            wordsHistory[DBWord.Text] = false;
            NextWord();                 
        }

        private void NextWord()
        {
            DBConnection.openConnection();

            SqlCommand com = new SqlCommand("SELECT COUNT(*) FROM AliasDictionary", DBConnection.connection);
            int total = (int)com.ExecuteScalar();

            int rndOffset = (new Random()).Next(total);
            string sqlQuery = $"SELECT word FROM AliasDictionary ORDER BY id OFFSET {rndOffset} ROWS FETCH NEXT 1 ROWS ONLY";
            com = new SqlCommand(sqlQuery, DBConnection.connection);
            string result = (string)com.ExecuteScalar();
            DBWord.Text = result;

            DBConnection.closeConnection();
        }
        private void NextPlayer()
        {
            currentPlayerIndex++;
            
            if (currentPlayerIndex > playersData.Count)
            {
                int bestPlayerIndex = 0, bestPlayerScore = 0;
                
                foreach (var item in playersData)
                {
                    if (item.Value.Score > bestPlayerScore)
                    {
                        bestPlayerIndex = item.Key;
                        bestPlayerScore = item.Value.Score;
                    }
                }

                if (bestPlayerScore >= maxScore)
                {
                    Winner winner = new Winner(playersData[bestPlayerIndex].Name, bestPlayerScore, _parent._parent._parent);
                    this.Hide();
                    winner.ShowDialog();
                    return;
                }
               currentPlayerIndex = 1;                                          
            }
            PlayerName.Text = playersData[currentPlayerIndex].Name;           
        }
      
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSeconds.Text = seconds--.ToString();
            lblSeconds.ForeColor = Color.Black;
            if (seconds < 10)
            {
                lblSeconds.ForeColor = Color.Red;
            }
            if (seconds < 0)
            {
                timer1.Stop();
                btnReady.Visible = true;
                DBWord.Visible = false;
                btnTrueNext.Visible = false;
                btnFalseNext.Visible = false;

                MainPanel.Visible = false;
                SummaryPanel.Visible = true;

                lblMaxScore.Text = maxScore.ToString();
                lblName.Text = playersData[currentPlayerIndex].Name;
                lblCurrentScore.Text = $"{playersData[currentPlayerIndex].Score}";
                foreach (var item in wordsHistory)
                {
                    AppendWord(item.Key, item.Value ? Color.Black : Color.Red);
                }
            }
        }

        //Визуал текста в RichTextBox
        private void AppendWord(string word, Color color)
        {
            int start = richTextBoxWordsSummary.TextLength;

            richTextBoxWordsSummary.AppendText(word + Environment.NewLine);

            int end = richTextBoxWordsSummary.TextLength;
            richTextBoxWordsSummary.Select(start, end - start);
            richTextBoxWordsSummary.SelectionColor = color;
            richTextBoxWordsSummary.SelectionLength = 0;
        }

        private void btnNextPlayer_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = true;
            SummaryPanel.Visible = false;

            NextPlayer();
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            _parent.Close();
        }
    }
}
