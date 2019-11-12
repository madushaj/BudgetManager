using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetManager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            clearFields();
        }

        private void loginUser(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("'Username' field cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("'Password' field cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void createUser(object sender, EventArgs e)
        {
            this.Hide();
            CreateUser createUser = new CreateUser();
            createUser.ShowDialog();
        }

        private void closeForm(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void clearFields()
        {
            txtUsername.Text = txtPassword.Text = "";
        }
    }
}
