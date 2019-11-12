using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetManager
{
    public partial class ExpenseVisualControl : UserControl
    {

        public double budgetedValue { get; set; }
        public double actualValue { get; set; }
        public Category category { get; set; }

        public ExpenseVisualControl()
        {
            InitializeComponent();
        }

        private void loadControl(object sender, EventArgs e)
        {
           //double budgetVal = GetBudgetValue();
          // double actualVal = GetActualValue();
          // categoryLabel.Text = category.Name;
          // valueLabel.Text = String.Format("Rs. {0:0.00} of {1:0.00}", actualVal, budgetVal);

        }

        private double GetActualValue()
        {
            return 0.0;
        }

        private double GetBudgetValue()
        {
            throw new NotImplementedException();
        }
    }
}
