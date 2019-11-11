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
    public partial class Form1 : Form
    {
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
    }
}
