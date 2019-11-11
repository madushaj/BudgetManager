﻿using System;
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
        private int selectedTransactionId = -1;
        BudgetManagerModelContainer budgetManager;
       
        private void setselectedTransactionId(int id)
        {
            this.selectedTransactionId = id;
        }

        private int getselectedTransactionId()
        {
            return this.selectedTransactionId;
        }

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
            dataGridViewTransaction.DataSource = transactionsList.Select(o => new
            { Title = o.Title, Value = o.Value, Category = o.Category.Name, TransacitonType = o.TrType,  RecursionInterval = o.RecursionType.ToString(), Description = o.Desc, TransactionId = o.Id }).ToList();
            this.dataGridViewTransaction.Columns["TransactionId"].Visible = false;

            int tempColWidth = dataGridViewTransaction.Width / dataGridViewTransaction.Columns.Count;
            for (int i = 0; i <= dataGridViewTransaction.Columns.Count - 1; i++)
            {
                dataGridViewTransaction.Columns[i].Width = tempColWidth;
            }
            this.dataGridViewTransaction.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            var query2 = from Category in budgetManager.Categories
                        where Category.UserId == 1 // to do : user should be passed
                        select Category;

            categoryList = query2.ToList();
            comboCategory.DataSource = categoryList;
            comboCategory.DisplayMember = "Name";
            comboCategory.ValueMember = "Id";
            comboCategory.SelectedIndex = 0;


            radioIncome.Checked = true;
            comboRecursionType.DataSource = Enum.GetValues(typeof(RecursionInterval));
            comboRecursionType.SelectedIndex = 0;
            txtTitle.Text = "";
            txtValue.Text = "";
            txtDescription.Text = "";
            setselectedTransactionId(-1);
            datePickerTransaction.Value = DateTime.Today.AddDays(0);
            datePickerStart.Value = DateTime.Today.AddDays(0);
            datePickerEnd.Value = DateTime.Today.AddDays(0);
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
            if (String.IsNullOrEmpty(val))
            {
                String errorStr = "'" + field + "'" + " field cannot be empty!";
                MessageBox.Show(errorStr, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool createTransactionFromValues(ref Transaction transaction)
        {
            Double tempVal = 0;

            if (!ValidateField(txtTitle.Text, "Title"))
            {
                return false;
            }
            if (!ValidateField(txtValue.Text, "Value"))
            {
                return false;
            }
            if (!ValidateField(txtDescription.Text, "Description"))
            {
                return false;
            }
            if (Double.TryParse(txtValue.Text, out tempVal))
            {
                transaction.Value = tempVal;
            }
            else
            {
                MessageBox.Show("Value should be double", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            
            transaction.Title = txtTitle.Text;
            
            transaction.Desc = txtDescription.Text;

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
            transaction.Category = (Category)comboCategory.SelectedItem;
            transaction.Date = datePickerTransaction.Value.Date;
            transaction.UserId = this.userId;

            return true;
        }

        private void addTransaction(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction();
            if (createTransactionFromValues(ref transaction))
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
            int tmpSelectedIndex = getselectedTransactionId();
            if (tmpSelectedIndex > 0) {
                var query = from Transaction in budgetManager.Transactions
                            where Transaction.Id == tmpSelectedIndex
                            select Transaction;

                Transaction transaction = query.First();
                createTransactionFromValues(ref transaction);
                budgetManager.SaveChanges();
                setselectedTransactionId(-1);
                MessageBox.Show("Transaction modified successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }
            else
            {
                MessageBox.Show("Select a transaction to modify", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteTransaction(object sender, EventArgs e)
        {

        }

        private void selectTransaction(object sender, DataGridViewCellEventArgs e)
        {
            int transactionId = Convert.ToInt32(dataGridViewTransaction.SelectedRows[0].Cells[6].Value.ToString());
            Transaction transaction = transactionsList.Find(r => r.Id == transactionId);
            //MessageBox.Show(transaction.Title, "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtTitle.Text = transaction.Title;
            txtValue.Text = transaction.Value.ToString();
            txtDescription.Text = transaction.Desc;
            datePickerTransaction.Value = transaction.Date;
            comboCategory.SelectedItem = transaction.Category;
            comboRecursionType.SelectedItem = transaction.RecursionType;
            if (transaction.TrType == TransactionType.Income)
            {
                radioIncome.Checked = true;
            }
            else
            {
                radioExpense.Checked = true;
            }
            setselectedTransactionId(transactionId);
        }

        private void clearFields(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
