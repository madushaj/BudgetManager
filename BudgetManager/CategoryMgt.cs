using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public delegate void CategoryAdded(Boolean  addedNewCategory);


namespace BudgetManager
{
    public partial class CategoryMgt : Form
    {
        private List<Category> categoriesList = new List<Category>();
        public CategoryMgt()
        {
            InitializeComponent();
        }

        private void btnHomeClick(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void CategoryMgt_Load(object sender, EventArgs e)
        {
            loadCategoryList();
        }

        private void AddCategory(object sender, EventArgs e)
        {
            CategoryCustomControl usercontrol = new CategoryCustomControl();
            usercontrol.Location = new System.Drawing.Point(5, 150);
            usercontrol.Name = "categoryCustomControlAdd";
            usercontrol.userId = 1;
            usercontrol.categoryAdded += new CategoryAdded(refreshCategoryList);
            this.Controls.Add(usercontrol);

        }
        private void refreshCategoryList(bool added)
        {
            if (added) {
                loadCategoryList();
            }
        }

        private void loadCategoryList()
        {
            BudgetManagerModelContainer budgetManager = new BudgetManagerModelContainer();

            var query = from Category in budgetManager.Categories
                        where Category.UserId == 1 // to do : user should be passed
                        select Category;

            categoriesList = categoriesList = query.ToList();
            gridViewCategory.DataSource = categoriesList.Select(o => new
            { Id = o.Id, Name = o.Name, Description = o.Desc}).ToList();
            this.gridViewCategory.Columns["Id"].Visible = false;
            this.gridViewCategory.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void deleteCategory(object sender, EventArgs e)
        {
            if (GetUSerConfirmation())
            {
                BudgetManagerModelContainer budgetManager = new BudgetManagerModelContainer();
                Int32 categoryId = Convert.ToInt32(gridViewCategory.SelectedRows[0].Cells[0].Value.ToString());

                var query = from Category in budgetManager.Categories
                            where Category.Id == categoryId 
                            select Category;
                Category item = query.First();
                budgetManager.Categories.Remove(item);
                budgetManager.SaveChanges();

                //MessageBox.Show("Deleted category successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                loadCategoryList();
            }
        }

        private bool GetUSerConfirmation()
        {
            var result = MessageBox.Show("Are you sure that you want to delete the selected category?", "Deleting Selected category", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes ? true : false;
        }

        private void closeForm(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
