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
            this.expenseGroup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.expenseGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnManageTransaction
            // 
            this.btnManageTransaction.Location = new System.Drawing.Point(28, 46);
            this.btnManageTransaction.Name = "btnManageTransaction";
            this.btnManageTransaction.Size = new System.Drawing.Size(131, 49);
            this.btnManageTransaction.TabIndex = 0;
            this.btnManageTransaction.Text = "Transactions Management";
            this.btnManageTransaction.UseVisualStyleBackColor = true;
            this.btnManageTransaction.Click += new System.EventHandler(this.btnTranactinMgtClick);
            // 
            // btnBudgetMng
            // 
            this.btnBudgetMng.Location = new System.Drawing.Point(28, 128);
            this.btnBudgetMng.Name = "btnBudgetMng";
            this.btnBudgetMng.Size = new System.Drawing.Size(131, 49);
            this.btnBudgetMng.TabIndex = 1;
            this.btnBudgetMng.Text = "Budget Management";
            this.btnBudgetMng.UseVisualStyleBackColor = true;
            this.btnBudgetMng.Click += new System.EventHandler(this.budgetMgtButtonClick);
            // 
            // btnCategoryMgt
            // 
            this.btnCategoryMgt.Location = new System.Drawing.Point(28, 210);
            this.btnCategoryMgt.Name = "btnCategoryMgt";
            this.btnCategoryMgt.Size = new System.Drawing.Size(131, 49);
            this.btnCategoryMgt.TabIndex = 2;
            this.btnCategoryMgt.Text = "Category Management";
            this.btnCategoryMgt.UseVisualStyleBackColor = true;
            this.btnCategoryMgt.Click += new System.EventHandler(this.categoryMgtButtonClick);
            // 
            // expenseGroup
            // 
            this.expenseGroup.Controls.Add(this.label1);
            this.expenseGroup.Location = new System.Drawing.Point(207, 26);
            this.expenseGroup.Name = "expenseGroup";
            this.expenseGroup.Size = new System.Drawing.Size(683, 604);
            this.expenseGroup.TabIndex = 3;
            this.expenseGroup.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monthly Spending";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 692);
            this.Controls.Add(this.expenseGroup);
            this.Controls.Add(this.btnCategoryMgt);
            this.Controls.Add(this.btnBudgetMng);
            this.Controls.Add(this.btnManageTransaction);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.loadForm);
            this.expenseGroup.ResumeLayout(false);
            this.expenseGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManageTransaction;
        private System.Windows.Forms.Button btnBudgetMng;
        private System.Windows.Forms.Button btnCategoryMgt;
        private System.Windows.Forms.GroupBox expenseGroup;
        private System.Windows.Forms.Label label1;
    }
}

