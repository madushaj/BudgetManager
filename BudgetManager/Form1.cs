using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetManager
{
    public partial class Form1 : Form
    {
        private List<Category> categoriesList;
        private List<BudgetItem> ThisMonthItemList;
        private int userId = -1;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void btnTranactinMgtClick(object sender, EventArgs e)
        {
            this.Hide();
            TransactionMgt transactionMgtform = new TransactionMgt();
            transactionMgtform.ShowDialog();
        }

        private void budgetMgtButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            BudgetMgt budgetMgt = new BudgetMgt();
            budgetMgt.ShowDialog();
        }

        private void categoryMgtButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            CategoryMgt categoryMgt = new CategoryMgt();
            categoryMgt.ShowDialog();
        }

        /// 
        /// 
        /// Handling Expense visualization
        /// 
        /// 


        private void click(object sender, MouseEventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                //newProgressBar1.Value = i;
                Thread.Sleep(100);
            }
        }

        private void loadForm(object sender, EventArgs e)
        {
            loadCategoryList();
        }

        private void loadCategoryList()
        {
            BudgetManagerModelContainer budgetManager = new BudgetManagerModelContainer();

            var query = from Category in budgetManager.Categories
                        where Category.UserId == 1 // to do : user should be passed
                        select Category;

            if (query.Any()) {
                categoriesList = query.ToList();
                loadExpenseBars();
            }
            
        }

        private void loadExpenseBars()
        {
            int i = 0;
            foreach (Category item in categoriesList)
            {
                double budgetVal = GetBudgetValue(item);
                double actualVal = GetActualValue(item);
                
                ExpenseVisualControl expensecontrol = new ExpenseVisualControl();
                expensecontrol.Location = new System.Drawing.Point(20, 21 + 85*i);
                expensecontrol.Name = item.Name + "ExpenseVisualControl";
                expensecontrol.categoryLabel.Text = item.Name.ToUpper();
                expensecontrol.valueLabel.Text = String.Format("Rs. {0:0.00} of {1:0.00}", actualVal, budgetVal);
                expensecontrol.newProgressBar1.Value = (budgetVal == 0) ? 0 : (actualVal < budgetVal) ? Convert.ToInt32((actualVal / budgetVal) * 100) : 100;
                i++;
                this.expenseGroup.Controls.Add(expensecontrol);

            }
        }

        private double GetBudgetValue(Category category)
        {
            getBudgetItems();
            if (ThisMonthItemList != null)
            {
                BudgetItem bitem = ThisMonthItemList.Find(f => f.CategoryId == category.Id);
                if (bitem != null) return bitem.Allocation;
            }
            return 0.0;
        }

        private void getBudgetItems()
        {
            BudgetManagerModelContainer budgetManager = new BudgetManagerModelContainer();
            var query = from Budget in budgetManager.Budgets
                        where Budget.UserId == 1 && Budget.Month == DateTime.Now.Month// to do : user should be passed
                        select Budget;
            if (query.Any())
            {
                ThisMonthItemList = query.First().BudgetItems.ToList();
            }
        }

        private double GetActualValue(Category category)
        {
            double actualVal = 0.0;
            double income = 0.0;
            double expense = 0.0;
            if (category.CatTrans.ToList() == null)
            {
                return actualVal;
            }
            CatTrans catTrans =  category.CatTrans.ToList().Find(f => f.Month == DateTime.Now.Month && f.Year == DateTime.Now.Year);
            if (catTrans != null)
            {
                foreach (Transaction item in catTrans.Transactions.ToList())
                {
                    if (item.TrType == TransactionType.Income) {
                        income += item.Value;
                    }
                    else {
                        expense += item.Value;
                    }
                }
                actualVal = expense - income ;
            }
            return actualVal;
        }

    }


    public class NewProgressBar : ProgressBar
    {
        public NewProgressBar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rec = e.ClipRectangle;

            rec.Width = (int)(rec.Width * ((double)Value / Maximum)) - 4;
            if (ProgressBarRenderer.IsSupported)
                ProgressBarRenderer.DrawHorizontalBar(e.Graphics, e.ClipRectangle);
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.LimeGreen, Color.Red, LinearGradientMode.Horizontal);
            rec.Height = rec.Height - 4;
            e.Graphics.FillRectangle(brush, 2, 2, rec.Width, rec.Height);
        }
    }
}
