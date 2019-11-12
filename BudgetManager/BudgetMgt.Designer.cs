namespace BudgetManager
{
    partial class BudgetMgt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BudgetMgt));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtViewYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbViewMonth = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.btnSubmitBudget = new System.Windows.Forms.Button();
            this.btnViewBudget = new System.Windows.Forms.Button();
            this.dataGridBudget = new System.Windows.Forms.DataGridView();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtBudgetItemId = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDeleteBudgetItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBudget)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnHome.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(939, 19);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(58, 55);
            this.btnHome.TabIndex = 1;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHomeClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Year :";
            // 
            // txtViewYear
            // 
            this.txtViewYear.Location = new System.Drawing.Point(459, 56);
            this.txtViewYear.Name = "txtViewYear";
            this.txtViewYear.Size = new System.Drawing.Size(121, 26);
            this.txtViewYear.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Month : ";
            // 
            // cmbViewMonth
            // 
            this.cmbViewMonth.FormattingEnabled = true;
            this.cmbViewMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbViewMonth.Location = new System.Drawing.Point(459, 94);
            this.cmbViewMonth.Name = "cmbViewMonth";
            this.cmbViewMonth.Size = new System.Drawing.Size(121, 28);
            this.cmbViewMonth.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Category :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Type :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Allocated Amount : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Add / Edit Budget Item";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(165, 215);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(181, 28);
            this.cmbCategory.TabIndex = 10;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Income",
            "Expense"});
            this.cmbType.Location = new System.Drawing.Point(165, 267);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(181, 28);
            this.cmbType.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(104, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Year :";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(165, 108);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(181, 26);
            this.txtYear.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(93, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Month :";
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbMonth.Location = new System.Drawing.Point(165, 162);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(177, 28);
            this.cmbMonth.TabIndex = 16;
            // 
            // btnSubmitBudget
            // 
            this.btnSubmitBudget.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSubmitBudget.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmitBudget.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSubmitBudget.Location = new System.Drawing.Point(165, 371);
            this.btnSubmitBudget.Name = "btnSubmitBudget";
            this.btnSubmitBudget.Size = new System.Drawing.Size(81, 41);
            this.btnSubmitBudget.TabIndex = 17;
            this.btnSubmitBudget.Text = "Submit";
            this.btnSubmitBudget.UseVisualStyleBackColor = false;
            this.btnSubmitBudget.Click += new System.EventHandler(this.btnSubmitBudgetClick);
            // 
            // btnViewBudget
            // 
            this.btnViewBudget.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnViewBudget.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewBudget.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnViewBudget.Location = new System.Drawing.Point(646, 88);
            this.btnViewBudget.Name = "btnViewBudget";
            this.btnViewBudget.Size = new System.Drawing.Size(100, 34);
            this.btnViewBudget.TabIndex = 18;
            this.btnViewBudget.Text = "View";
            this.btnViewBudget.UseVisualStyleBackColor = false;
            this.btnViewBudget.Click += new System.EventHandler(this.btnViewBudgetClick);
            // 
            // dataGridBudget
            // 
            this.dataGridBudget.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridBudget.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridBudget.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBudget.Location = new System.Drawing.Point(391, 149);
            this.dataGridBudget.MultiSelect = false;
            this.dataGridBudget.Name = "dataGridBudget";
            this.dataGridBudget.RowTemplate.Height = 28;
            this.dataGridBudget.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridBudget.Size = new System.Drawing.Size(571, 279);
            this.dataGridBudget.TabIndex = 19;
            this.dataGridBudget.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEditValue);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(165, 319);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(181, 26);
            this.txtAmount.TabIndex = 20;
            // 
            // txtBudgetItemId
            // 
            this.txtBudgetItemId.Location = new System.Drawing.Point(295, 62);
            this.txtBudgetItemId.Name = "txtBudgetItemId";
            this.txtBudgetItemId.Size = new System.Drawing.Size(51, 26);
            this.txtBudgetItemId.TabIndex = 21;
            this.txtBudgetItemId.Visible = false;
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(161, 162);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(181, 26);
            this.txtMonth.TabIndex = 22;
            this.txtMonth.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(46, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(240, 27);
            this.label9.TabIndex = 23;
            this.label9.Text = "Budget Management";
            // 
            // btnDeleteBudgetItem
            // 
            this.btnDeleteBudgetItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDeleteBudgetItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteBudgetItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDeleteBudgetItem.Location = new System.Drawing.Point(269, 371);
            this.btnDeleteBudgetItem.Name = "btnDeleteBudgetItem";
            this.btnDeleteBudgetItem.Size = new System.Drawing.Size(77, 41);
            this.btnDeleteBudgetItem.TabIndex = 24;
            this.btnDeleteBudgetItem.Text = "Delete";
            this.btnDeleteBudgetItem.UseVisualStyleBackColor = false;
            this.btnDeleteBudgetItem.Click += new System.EventHandler(this.btnDeleteBudgetClick);
            // 
            // BudgetMgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 450);
            this.Controls.Add(this.btnDeleteBudgetItem);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.txtBudgetItemId);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.dataGridBudget);
            this.Controls.Add(this.btnViewBudget);
            this.Controls.Add(this.btnSubmitBudget);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbViewMonth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtViewYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHome);
            this.Name = "BudgetMgt";
            this.Text = "BudgetMgt";
            this.Load += new System.EventHandler(this.BudgetMgt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBudget)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtViewYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbViewMonth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Button btnSubmitBudget;
        private System.Windows.Forms.Button btnViewBudget;
        private System.Windows.Forms.DataGridView dataGridBudget;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtBudgetItemId;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDeleteBudgetItem;
    }
}