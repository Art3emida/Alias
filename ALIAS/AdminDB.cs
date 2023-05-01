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
    public partial class AdminDB : Form
    {
        public AdminDB()
        {
            InitializeComponent();            
        }

        private void aliasDictionaryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aliasDictionaryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aLIASDataSet);

        }

        private void AdminDB_Load(object sender, EventArgs e)
        {
            // данная строка кода позволяет загрузить данные в таблицу "aLIASDataSet.AliasDictionary". При необходимости она может быть перемещена или удалена.
            this.aliasDictionaryTableAdapter.Fill(this.aLIASDataSet.AliasDictionary);
        }

        private void btnReturnToGame_Click(object sender, EventArgs e)
        {
            MainMenu form = new MainMenu();
            form.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult warning = MessageBox.Show("Вы действительно хотите выйти из программы? ", "Завершение программы", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (warning == DialogResult.Yes)
            {
                this.Close();
            }            
        }       

        private void AdminDB_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Вы действительно хотите выйти из программы?", "Завершение программы", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
   
            if (dialog == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
