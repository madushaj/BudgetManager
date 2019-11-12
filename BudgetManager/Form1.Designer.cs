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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(177, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 542);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 633);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCategoryMgt);
            this.Controls.Add(this.btnBudgetMng);
            this.Controls.Add(this.btnManageTransaction);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.loadForm);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManageTransaction;
        private System.Windows.Forms.Button btnBudgetMng;
        private System.Windows.Forms.Button btnCategoryMgt;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

