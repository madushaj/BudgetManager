namespace BudgetManager
{
    partial class ExpenseVisualizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpenseVisualizer));
            this.expenseGroup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCategoryMgt = new System.Windows.Forms.Button();
            this.btnBudgetMng = new System.Windows.Forms.Button();
            this.btnManageTransaction = new System.Windows.Forms.Button();
            this.expenseGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // expenseGroup
            // 
            this.expenseGroup.Controls.Add(this.label1);
            this.expenseGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.expenseGroup.Location = new System.Drawing.Point(230, 85);
            this.expenseGroup.Name = "expenseGroup";
            this.expenseGroup.Size = new System.Drawing.Size(683, 604);
            this.expenseGroup.TabIndex = 3;
            this.expenseGroup.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(432, -6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monthly Spending";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(365, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 42);
            this.label2.TabIndex = 4;
            this.label2.Text = "Budget Planner";
            // 
            // btnCategoryMgt
            // 
            this.btnCategoryMgt.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCategoryMgt.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoryMgt.Image = ((System.Drawing.Image)(resources.GetObject("btnCategoryMgt.Image")));
            this.btnCategoryMgt.Location = new System.Drawing.Point(29, 486);
            this.btnCategoryMgt.Name = "btnCategoryMgt";
            this.btnCategoryMgt.Size = new System.Drawing.Size(162, 166);
            this.btnCategoryMgt.TabIndex = 2;
            this.btnCategoryMgt.Text = "Categories";
            this.btnCategoryMgt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCategoryMgt.UseVisualStyleBackColor = true;
            this.btnCategoryMgt.Click += new System.EventHandler(this.categoryMgtButtonClick);
            // 
            // btnBudgetMng
            // 
            this.btnBudgetMng.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBudgetMng.Image = ((System.Drawing.Image)(resources.GetObject("btnBudgetMng.Image")));
            this.btnBudgetMng.Location = new System.Drawing.Point(29, 292);
            this.btnBudgetMng.Name = "btnBudgetMng";
            this.btnBudgetMng.Size = new System.Drawing.Size(162, 162);
            this.btnBudgetMng.TabIndex = 1;
            this.btnBudgetMng.Text = "Budget ";
            this.btnBudgetMng.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBudgetMng.UseVisualStyleBackColor = true;
            this.btnBudgetMng.Click += new System.EventHandler(this.budgetMgtButtonClick);
            // 
            // btnManageTransaction
            // 
            this.btnManageTransaction.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnManageTransaction.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageTransaction.Image = ((System.Drawing.Image)(resources.GetObject("btnManageTransaction.Image")));
            this.btnManageTransaction.Location = new System.Drawing.Point(29, 105);
            this.btnManageTransaction.Name = "btnManageTransaction";
            this.btnManageTransaction.Size = new System.Drawing.Size(162, 158);
            this.btnManageTransaction.TabIndex = 0;
            this.btnManageTransaction.Text = "Transactions";
            this.btnManageTransaction.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnManageTransaction.UseVisualStyleBackColor = true;
            this.btnManageTransaction.Click += new System.EventHandler(this.btnTranactinMgtClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 712);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.expenseGroup);
            this.Controls.Add(this.btnCategoryMgt);
            this.Controls.Add(this.btnBudgetMng);
            this.Controls.Add(this.btnManageTransaction);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Budget Manager";
            this.Load += new System.EventHandler(this.loadForm);
            this.expenseGroup.ResumeLayout(false);
            this.expenseGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnManageTransaction;
        private System.Windows.Forms.Button btnBudgetMng;
        private System.Windows.Forms.Button btnCategoryMgt;
        private System.Windows.Forms.GroupBox expenseGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

