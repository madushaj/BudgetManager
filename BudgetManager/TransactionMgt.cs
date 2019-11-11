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
    public partial class TransactionMgt : Form
    {
        private int userId;
        private List<Transaction> transactionsList;
        private List<Category> categoryList;
        BudgetManagerModelContainer budgetManager;

        public TransactionMgt()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            userId = 1;
            budgetManager = new BudgetManagerModelContainer();

            var query = from Transaction in budgetManager.Transactions
                        where Transaction.UserId == 1 // to do : user should be passed
                        select Transaction;

            transactionsList = query.ToList();
            dataGridViewTransaction.DataSource = transactionsList;

            var query2 = from Category in budgetManager.Categories
                        where Category.UserId == 1 // to do : user should be passed
                        select Category;

            categoryList = query2.ToList();
            comoboCategory.DataSource = categoryList;
            comoboCategory.SelectedIndex = 0;


            radioIncome.Checked = true;
            comboRecursionType.DataSource = Enum.GetValues(typeof(TransactionType));
            comboRecursionType.SelectedIndex = 0;
            txtTitle.Text = "";
            txtValue.Text = "";
            txtDescription.Text = "";
        }

        private void btnHomeClick(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void closeForm(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public bool ValidateField(String val, String field)
        {
            if (val == "")
            {
                String errorStr = "'" + field + "'" + " field cannot be empty!";
                MessageBox.Show(errorStr, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private Transaction createTransactionFromValues()
        {
            if (!ValidateField(txtTitle.ToString(), "Title"))
            {
                return null;
            }
            if (!ValidateField(txtValue.ToString(), "Value"))
            {
                return null;
            }
            if (!ValidateField(txtDescription.ToString(), "Description"))
            {
                return null;
            }

            Transaction transaction = new Transaction();
            transaction.Title = txtTitle.ToString();
            transaction.Value = Convert.ToDouble(txtValue.ToString());
            transaction.Desc = txtDescription.ToString();

            if (radioIncome.Checked)
            {
                transaction.TrType = TransactionType.Income;
            }
            else
            {
                transaction.TrType = TransactionType.Expense;
            }

            /*switch (comboRecursionType.SelectedIndex){
                case (0):
                    transaction.RecursionType = RecursionInterval.None;
                    break;
                case (1):
                    transaction.RecursionType = RecursionInterval.Weekly;
                    break;
                case (2):
                    transaction.RecursionType = RecursionInterval.Monthly;
                    break;
                case (3):
                    transaction.RecursionType = RecursionInterval.Annually;
                    break;
                default:
                    break;
            }*/
            transaction.RecursionType = (RecursionInterval)comboRecursionType.SelectedItem;
            transaction.Category = (Category)comoboCategory.SelectedItem;
            transaction.Date = datePickerTransaction.Value.Date;

            return transaction;
        }

        private void addTransaction(object sender, EventArgs e)
        {
            Transaction transaction = createTransactionFromValues();
            if (transaction != null)
            {
                budgetManager.Transactions.Add(transaction);
                budgetManager.SaveChanges();
                MessageBox.Show("Transaction added successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }

            return;
        }

        private void searchTransaction(object sender, EventArgs e)
        {

        }

        private void modifyTransaction(object sender, EventArgs e)
        {

        }

        private void deleteTransaction(object sender, EventArgs e)
        {

        }
    }
}
