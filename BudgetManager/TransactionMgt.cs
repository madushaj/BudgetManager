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
        private int selectedTransactionId = -1;
        BudgetManagerModelContainer budgetManager;

        enum transactionOperations
        {
            Save = 0,
            Modify = 1
        }

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

        public TransactionMgt(int userId)
        {
            this.userId = userId;
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
            generateDataGridView(transactionsList);

            var query2 = from Category in budgetManager.Categories
                        where Category.UserId == 1 // to do : user should be passed
                        select Category;

            
            if (query2.Any()) {
                categoryList = query2.ToList();
                comboCategory.DataSource = categoryList;
                comboCategory.DisplayMember = "Name";
                comboCategory.ValueMember = "Id";
                comboCategory.SelectedIndex = 0;
            }


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

        private void generateDataGridView(List<Transaction> transactionsList)
        {
            dataGridViewTransaction.DataSource = transactionsList.Select(o => new
            { TransactionId = o.Id, Title = o.Title, Value = o.Value, Category = o.CatTran.Category.Name, TransacitonType = o.TrType, RecursionInterval = o.RecursionType.ToString(), Date = o.Date, Description = o.Desc }).ToList();
            this.dataGridViewTransaction.Columns["TransactionId"].Visible = false;

            int tempColWidth = dataGridViewTransaction.Width / dataGridViewTransaction.Columns.Count;
            for (int i = 0; i <= dataGridViewTransaction.Columns.Count - 1; i++)
            {
                dataGridViewTransaction.Columns[i].Width = tempColWidth;
            }
            this.dataGridViewTransaction.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            foreach (DataGridViewRow Myrow in dataGridViewTransaction.Rows)
            {            
                if (Convert.ToInt32(Myrow.Cells[4].Value) == 1) 
                {
                    Myrow.DefaultCellStyle.BackColor = Color.LightCoral;
                }
                else
                {
                    Myrow.DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }

            dataGridViewTransaction.Update();
            dataGridViewTransaction.Refresh();
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

        private bool createTransactionFromValues(ref Transaction transaction, transactionOperations op)
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

            transaction.RecursionType = (RecursionInterval)comboRecursionType.SelectedItem;
            transaction.Date = datePickerTransaction.Value.Date;
            transaction.UserId = this.userId;

            var query = from CatTran in budgetManager.CatTrans
                        where CatTran.Month == (Int16)(datePickerTransaction.Value.Month) &&
                        CatTran.Year == (Int16)(datePickerTransaction.Value.Year) &&
                        CatTran.CategoryId == ((Category)comboCategory.SelectedItem).Id
                        select CatTran;

            if (query.Any())
            {
                transaction.CatTran = query.First();
            }
            else
            {
                CatTrans catTran = new CatTrans();
                catTran.CategoryId = ((Category)comboCategory.SelectedItem).Id;
                catTran.Month = (Int16)(datePickerTransaction.Value.Month);
                catTran.Year = (Int16)(datePickerTransaction.Value.Year);
                transaction.CatTran = catTran;
            }

            return true;
        }

        private void addTransaction(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction();
            if (createTransactionFromValues(ref transaction, transactionOperations.Save))
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
            DateTime startDate = datePickerStart.Value.Date;
            DateTime endDate = datePickerEnd.Value.Date;

            if (startDate > endDate)
            {
                MessageBox.Show("Start date cannot be later than end date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loadData();
                return;
            }
            else
            {
                List<Transaction> transactionsListTmp = new List<Transaction>();
                foreach (var transaction in transactionsList) {
                    if (startDate <= transaction.Date && transaction.Date <= endDate) {
                        transactionsListTmp.Add(transaction);
                    }
                }
                generateDataGridView(transactionsListTmp);
            }

        }

        private void modifyTransaction(object sender, EventArgs e)
        {
            int tmpSelectedIndex = getselectedTransactionId();
            if (tmpSelectedIndex > 0) {
                var query = from Transaction in budgetManager.Transactions
                            where Transaction.Id == tmpSelectedIndex
                            select Transaction;

                Transaction transaction = query.First();
                createTransactionFromValues(ref transaction, transactionOperations.Modify);
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
            int tmpSelectedIndex = getselectedTransactionId();
            int catTransId;
            if (tmpSelectedIndex > 0)
            {
                var query = from Transaction in budgetManager.Transactions
                            where Transaction.Id == tmpSelectedIndex
                            select Transaction;

                Transaction transaction = query.First();
                catTransId = transaction.CatTransId;
                budgetManager.Transactions.Remove(transaction);

                var query2 = from CatTrans in budgetManager.CatTrans
                            where CatTrans.Id == catTransId
                            select CatTrans;

                if (query2.Any()) {
                    CatTrans catTrans = query2.First();
                    budgetManager.CatTrans.Remove(catTrans);
                }
                budgetManager.SaveChanges();
                setselectedTransactionId(-1);
                MessageBox.Show("Transaction deleted successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }
            else
            {
                MessageBox.Show("Select a transaction to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void selectTransaction(object sender, DataGridViewCellEventArgs e)
        {
            int transactionId = Convert.ToInt32(dataGridViewTransaction.SelectedRows[0].Cells[0].Value.ToString());
            Transaction transaction = transactionsList.Find(r => r.Id == transactionId);
            //MessageBox.Show(transaction.Title, "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtTitle.Text = transaction.Title;
            txtValue.Text = transaction.Value.ToString();
            txtDescription.Text = transaction.Desc;
            datePickerTransaction.Value = transaction.Date;
            comboCategory.SelectedItem = transaction.CatTran.Category;
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
