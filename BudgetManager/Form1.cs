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

        public Form1()
        {
            InitializeComponent();
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

            categoriesList = categoriesList = query.ToList();
            loadExpenseBars();
        }

        private void loadExpenseBars()
        {
            foreach (Category item in categoriesList)
            {
                double budgetVal = GetBudgetValue(item);
                double actualVal = GetActualValue(item);

                ExpenseVisualControl expensecontrol = new ExpenseVisualControl();
                expensecontrol.Location = new System.Drawing.Point(12, 150);
                expensecontrol.Name = item.Name + "ExpenseVisualControl";
                expensecontrol.categoryLabel.Text = item.Name;
                expensecontrol.valueLabel.Text = String.Format("Rs. {0:0.00} of {1:0.00}", actualVal, budgetVal);
                expensecontrol.newProgressBar1.Value = (actualVal < budgetVal) ? Convert.ToInt32((actualVal / budgetVal) * 100) : 100;
                this.Controls.Add(expensecontrol);

            }
        }

        private double GetBudgetValue(Category category)
        {
            double actualVal = 0.0;
            foreach (Transaction item in category.Transactions)
            {
                actualVal += item.Value;
            }
            return actualVal;
        }

        private double GetActualValue(Category category)
        {
            double actualVal = 0.0;
            foreach (Transaction item in category.Transactions) 
            {
                actualVal += item.Value;
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
