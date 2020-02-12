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
    public partial class CategoryCustomControl : UserControl
    {
        public event CategoryAdded categoryAdded;
        public int userId { get; set; }
        public CategoryCustomControl()
        {
            InitializeComponent();
        }

        private void Save(object sender, EventArgs e)
        {
            if (txtCategoryName.Text == "" || txtCategoryDesc.Text == "") {
                MessageBox.Show("Values Cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BudgetManagerModelContainer budgetManager = new BudgetManagerModelContainer();

            var query = from Category in budgetManager.Categories
                        where Category.UserId == userId 
                        select Category.Name;
            if (!(query.ToList().Contains(txtCategoryName.Text)))
            {
                Category category = new Category();
                category.Name = txtCategoryName.Text;
                category.Desc = txtCategoryDesc.Text;
                category.UserId = userId;
                budgetManager.Categories.Add(category);
                budgetManager.SaveChanges();
                this.categoryAdded(true);
            }
            else {
                MessageBox.Show("Category Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtCategoryName.Text = "";
            txtCategoryDesc.Text = "";
        }


        private void Cancel(object sender, EventArgs e)
        {
            txtCategoryName.Text = "";
            txtCategoryDesc.Text = "";
            this.categoryAdded(false);
        }
    }
}
