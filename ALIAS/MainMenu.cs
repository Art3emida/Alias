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
using System.IO;

namespace ALIAS
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void beginBtnClick(object sender, EventArgs e)
        {
            GameSettings properties = new GameSettings(this);
            this.Hide();
            properties.ShowDialog();
        }

        private void btnAdminEnter_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            this.Hide();
            admin.Show();
        }

        private void firstSetup()
        {
            DBConnection.openConnection();

            var words = File.ReadAllLines(@"C:\Users\Art3emida\Desktop\singular.txt");
            int limit = 1000;
            int pos = 0;
            var wordsQueue = new List<string>();

            foreach (var word in words)
            {
                pos++;
                wordsQueue.Add(word);


                if (pos == limit)
                {
                    string sql = $"INSERT INTO AliasDictionary(word, hint) VALUES (N'" + String.Join("'), (N'", wordsQueue) + "')";
                    var command = new SqlCommand(sql, DBConnection.connection);
                    command.ExecuteNonQuery();

                    wordsQueue.Clear();
                    pos = 0;
                }
            }

            DBConnection.closeConnection();
        }
    }
}
