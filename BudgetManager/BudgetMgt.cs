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
    public partial class BudgetMgt : Form
    {
        public BudgetMgt()
        {
            InitializeComponent();
            //hide month textbox
            txtMonth.Visible = false;
            btnDeleteBudgetItem.BackColor = Color.Red;

            //set values to category combo Box
            BudgetManagerModelContainer db = new BudgetManagerModelContainer();
            var query = from Category in db.Categories
                        where Category.UserId == 1
                        select Category;
            List<Category> categoryList = query.ToList();
            cmbCategory.DataSource = categoryList;
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";

            //view grig for current month
            string currentMonth = DateTime.Now.Month.ToString();
            string currentYear = DateTime.Now.Year.ToString();
            //MessageBox.Show("year :" + currentYear);
            //MessageBox.Show("month" + currentMonth);

            txtViewYear.Text = currentYear;
            cmbViewMonth.SelectedIndex = Convert.ToInt16(currentMonth) - 1;

            setDataGridValue(Convert.ToInt16(currentYear), Convert.ToInt16(currentMonth));

            //set type valu combo box
            cmbType.DataSource =Enum.GetValues( typeof(TransactionType));
            cmbType.SelectedIndex = 0;
        }

        private void btnHomeClick(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void btnSubmitBudgetClick(object sender, EventArgs e)
        {
            if (txtYear.Text != "" &&  Int16.Parse(txtYear.Text) > 0 && (cmbMonth.SelectedIndex) >= 0)
           {
                Console.WriteLine("cmbCategory :" + cmbCategory.SelectedValue);
                //int categoryid = cmbCategory.SelectedValue;
                if(txtAmount.Text != "" && cmbType.SelectedIndex >=0)
                {
                                      
                    int year = Int16.Parse(txtYear.Text);
                    Console.WriteLine("year :" + year);
                    int month = (cmbMonth.SelectedIndex) + 1;
                    Console.WriteLine("month :" + month);

                    if(txtBudgetItemId.Text != "")
                    {
                        saveBudgetItem(Int16.Parse(txtBudgetItemId.Text));
                    }else
                    {
                        getBudgetforMonth(year, month);
                    }
                }
                else
                {
                    MessageBox.Show("Please insert valid input parameters");
                }
            }
            else
            {
                MessageBox.Show("Please Provide a Valid Year and Month");
            }
        }

        private void BudgetMgt_Load(object sender, EventArgs e)
        {

        }

        private void btnViewBudjetClick(object sender, EventArgs e)
        {
            
        }

        //get budget item list for month 
        private List<BudgetItem> getBudgetItemListForMonth(int year, int month)
        {
            BudgetManagerModelContainer db = new BudgetManagerModelContainer();
            var query = from Budget in db.Budgets
                        where Budget.Month == month && Budget.Year == year && Budget.UserId == 1
                        select Budget;

            List<BudgetItem> budgets = new List<BudgetItem>();
            if(query.Any())
            {
                budgets = query.First().BudgetItems.ToList();
                return budgets;
            }
            else
            {
                return budgets;
            }
            
        }

        private void getBudgetforMonth(int year, int month)
        {
            BudgetManagerModelContainer db = new BudgetManagerModelContainer();
            List<BudgetItem> budgetItemList = new List<BudgetItem>();

            var query = from Budget in db.Budgets
                        where Budget.Month == month && Budget.Year == year && Budget.UserId == 1
                        select Budget;

            Budget budgets = new Budget();
            if (query.Any())
            {
                budgets = query.First();
            }
            else
            {
                budgets = null;
            }

            BudgetItem budgetItem = new BudgetItem();
            budgetItem.ItemType = (TransactionType)cmbType.SelectedItem;
            budgetItem.Allocation = Double.Parse(txtAmount.Text);
            budgetItem.CategoryId = ((Category)cmbCategory.SelectedItem).Id;

            if (budgets != null)
            {
                budgetItem.BudgetId = budgets.Id;
                budgetItemList = budgets.BudgetItems.ToList();
                budgetItemList.Add(budgetItem);
                budgets.BudgetItems = budgetItemList;
                db.BudgetItems.Add(budgetItem);
                db.SaveChanges();
             
            }
            else
            {
                budgets = new Budget();
                budgetItemList.Add(budgetItem);
                budgets.UserId = 1;
                budgets.Year = Convert.ToInt16(year);
                budgets.Month = Convert.ToInt16(month);
                budgets.BudgetItems = budgetItemList;
                db.Budgets.Add(budgets);
                db.SaveChanges();
            }

            cleanFields();
            setDataGridValue(year, month);
            MessageBox.Show("Successful");

        }

        private void cleanFields()
        {
            txtMonth.Visible = false;
            txtYear.Text = "";
            txtAmount.Text = "";
            cmbMonth.Visible = true;
            cmbMonth.SelectedIndex = 0;
            cmbCategory.SelectedIndex = 1;
            cmbType.SelectedIndex = 0;
            txtBudgetItemId.Text = "";
            txtYear.ReadOnly = false;
        }

        private void btnViewBudgetClick(object sender, EventArgs e)
        {
            Console.WriteLine("** :" + (cmbViewMonth.SelectedIndex +1));
            if (Int32.Parse(txtViewYear.Text) > 0 && (cmbViewMonth.SelectedIndex) >= 0)
            {
                //dataGridBudget.Rows.Clear();
                int year = Int16.Parse(txtViewYear.Text);
                int month = (cmbViewMonth.SelectedIndex) + 1;
                setDataGridValue(year, month);
                
            }
            else
            {
                MessageBox.Show("Please Provide a Valid Year and Month");
            }
        }

        private void setDataGridValue(int year, int month)
        {
            List<BudgetItem> budgetItems = getBudgetItemListForMonth(year, month);
            //dataGridBudget.DataSource = budgetItems;

            txtViewYear.Text = year.ToString();
            cmbViewMonth.SelectedIndex = (month - 1);

            dataGridBudget.DataSource = budgetItems.Select(o => new
            { Id = o.Id, Category = o.Category.Name, TransacitonType = (TransactionType)o.ItemType, Allocation = o.Allocation }).ToList();
            dataGridBudget.AutoResizeColumns();
        }

        private void dataGridEditValue(object sender, DataGridViewCellEventArgs e)
        {
            int budgetItemId = Convert.ToInt32(dataGridBudget.SelectedRows[0].Cells[0].Value.ToString());
            Console.WriteLine("selected id :" + budgetItemId);

            BudgetManagerModelContainer db = new BudgetManagerModelContainer();
            var query = from BudgetItem in db.BudgetItems
                        where BudgetItem.Id == budgetItemId
                        select BudgetItem;

            BudgetItem budgetItem = query.First();

            txtYear.Text = budgetItem.Budget.Year.ToString();
            txtYear.ReadOnly = true;
            cmbMonth.SelectedIndex = (budgetItem.Budget.Month - 1);
            //cmbMonth
            txtMonth.Visible = true;
            txtMonth.Text = (String)cmbMonth.SelectedItem;
            txtMonth.ReadOnly = true;
            cmbMonth.Visible = false;
            cmbCategory.SelectedValue = budgetItem.CategoryId;
            cmbType.SelectedItem = budgetItem.ItemType;
            Console.WriteLine("55 :" + budgetItem.ItemType);
            txtAmount.Text = budgetItem.Allocation.ToString();
            txtBudgetItemId.Text = budgetItem.Id.ToString();

        }

        private String saveBudget(Budget budget)
        {

            return "Success";
        }

        private void saveBudgetItem(Int16 id)
        {
            int year = Int16.Parse(txtYear.Text);
            Console.WriteLine("year :" + year);
            int month = (cmbMonth.SelectedIndex) + 1;
            Console.WriteLine("month :" + month);

            BudgetManagerModelContainer db = new BudgetManagerModelContainer();
            var query = from BudgetItem in db.BudgetItems
                        where BudgetItem.Id == id 
                        select BudgetItem;
            BudgetItem budgetItem = query.First();

            budgetItem.ItemType = (TransactionType)cmbType.SelectedItem;
            budgetItem.Allocation = Double.Parse(txtAmount.Text);
            budgetItem.CategoryId = ((Category)cmbCategory.SelectedItem).Id;
            db.SaveChanges();

            cleanFields();
            setDataGridValue(year, month);
            MessageBox.Show("Successful");


        }

        private void btnDeleteBudgetClick(object sender, EventArgs e)
        {
            BudgetManagerModelContainer db = new BudgetManagerModelContainer();

            Int16 budgetITemId = Convert.ToInt16(txtBudgetItemId.Text);

            var query = from BudgetItem in db.BudgetItems
                        where BudgetItem.Id == budgetITemId 
                        select BudgetItem;

            var deleteBudgetItem = query.First();
            db.BudgetItems.Remove(deleteBudgetItem);
            db.SaveChanges();

            int year = Int16.Parse(txtYear.Text);
            Console.WriteLine("year :" + year);
            int month = (cmbMonth.SelectedIndex) + 1;
            Console.WriteLine("month :" + month);

            setDataGridValue(year, month);
            cleanFields();
        }
    }
}
