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

        BudgetManagerModelContainer budgetManager;

        public Login()
        {
            InitializeComponent();
            budgetManager = new BudgetManagerModelContainer();
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

            User user = new User();
            user.UserName = txtUsername.Text;

            var query = from User in budgetManager.Users
                        where User.UserName == user.UserName
                        select User;

            User userFromDB;
            if (query.Any())
            {
                userFromDB = query.First();
                if (txtPassword.Text != userFromDB.Password)
                {
                    MessageBox.Show("Incorrect password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    this.Hide();
                    ExpenseVisualizer mainWindow = new ExpenseVisualizer();
                    mainWindow.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("User does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
