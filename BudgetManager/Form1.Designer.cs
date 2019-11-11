namespace BudgetManager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {

            this.btnManageTransaction = new System.Windows.Forms.Button();
            this.btnBudgetMng = new System.Windows.Forms.Button();
            this.btnCategoryMgt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManageTransaction
            // 
            this.btnManageTransaction.Location = new System.Drawing.Point(32, 57);
            this.btnManageTransaction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnManageTransaction.Name = "btnManageTransaction";
            this.btnManageTransaction.Size = new System.Drawing.Size(147, 61);
            this.btnManageTransaction.TabIndex = 0;
            this.btnManageTransaction.Text = "Transactions Management";
            this.btnManageTransaction.UseVisualStyleBackColor = true;
            this.btnManageTransaction.Click += new System.EventHandler(this.btnTranactinMgtClick);
            // 
            // btnBudgetMng
            // 
            this.btnBudgetMng.Location = new System.Drawing.Point(32, 160);
            this.btnBudgetMng.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBudgetMng.Name = "btnBudgetMng";
            this.btnBudgetMng.Size = new System.Drawing.Size(147, 61);
            this.btnBudgetMng.TabIndex = 1;
            this.btnBudgetMng.Text = "Budget Management";
            this.btnBudgetMng.UseVisualStyleBackColor = true;
            this.btnBudgetMng.Click += new System.EventHandler(this.budgetMgtButtonClick);
            // 
            // btnCategoryMgt
            // 
            this.btnCategoryMgt.Location = new System.Drawing.Point(32, 262);
            this.btnCategoryMgt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCategoryMgt.Name = "btnCategoryMgt";
            this.btnCategoryMgt.Size = new System.Drawing.Size(147, 61);
            this.btnCategoryMgt.TabIndex = 2;
            this.btnCategoryMgt.Text = "Category Management";
            this.btnCategoryMgt.UseVisualStyleBackColor = true;
            this.btnCategoryMgt.Click += new System.EventHandler(this.categoryMgtButtonClick);
            // 
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.btnCategoryMgt);
            this.Controls.Add(this.btnBudgetMng);
            this.Controls.Add(this.btnManageTransaction);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);

            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManageTransaction;
        private System.Windows.Forms.Button btnBudgetMng;
        private System.Windows.Forms.Button btnCategoryMgt;

    }
}

