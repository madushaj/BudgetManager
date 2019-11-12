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
    public partial class CreateUser : Form
    {
        BudgetManagerModelContainer budgetManager;

        public CreateUser()
        {
            InitializeComponent();
            loadData();
            clearFields();
        }

        private void loadData()
        {
            budgetManager = new BudgetManagerModelContainer();

        }

        private void backToLogin(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void createUser(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("'Name' field cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
            if (txtRePassword.Text == "")
            {
                MessageBox.Show("'Confirm Password' field cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtPassword.Text != txtRePassword.Text)
            {
                MessageBox.Show("Password fields are not matching!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User user = new User();
            user.Name = txtUsername.Text;
                        
            var query = from User in budgetManager.Users
            where User.UserName == user.UserName
            select User;

            User userFromDB;
            if (query.Any()) {
                userFromDB = query.First();
                if (user.UserName != userFromDB.UserName)
                {
                    MessageBox.Show("Username already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            
            user.UserName = txtUsername.Text;
            user.Password = txtPassword.Text;


            budgetManager.Users.Add(user);
            budgetManager.SaveChanges();
            MessageBox.Show("User created successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearFields();


            /*if (createTransactionFromValues(ref transaction))
            {
                budgetManager.Transactions.Add(transaction);
                budgetManager.SaveChanges();
                MessageBox.Show("Transaction added successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
                clearFields();
            }*/
        }

        private void clearFields(object sender, EventArgs e)
        {
            clearFields();
        }

        private void closeForm(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void clearFields()
        {
            txtName.Text = txtUsername.Text = txtPassword.Text = txtRePassword.Text = "";
        }
    }
}
