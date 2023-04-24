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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnLoginAdmin_Click(object sender, EventArgs e)
        {
            string admin_login = "a";
            string admin_password = "z";
            string user_login = LoginField.Text;
            string user_password = PasswordField.Text;

            if (user_login == admin_login && user_password == admin_password)
            {
                AdminDB admin_db = new AdminDB();
                admin_db.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль! \nПожалуйста, повторите попытку.");
            }
           
        }
    }
}
