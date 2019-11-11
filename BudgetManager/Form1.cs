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

        private void btn1click(object sender, EventArgs e)
        {
            User user = new User();
            BudgetManagerModelContainer budgetManagerModelContainer = new BudgetManagerModelContainer();
            user.Name = "sew";
            user.UserName = "sew";
            user.Password = "sew";
            budgetManagerModelContainer.Users.Add(user);
            Console.Write("save :" +user.Name);
            budgetManagerModelContainer.SaveChanges();
            
        }
    }
}
