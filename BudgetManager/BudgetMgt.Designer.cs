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
            this.btnHome.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnHome.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnHome.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(929, 42);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(52, 46);
            this.btnHome.TabIndex = 1;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHomeClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(457, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Year :";
            // 
            // txtViewYear
            // 
            this.txtViewYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtViewYear.Location = new System.Drawing.Point(530, 126);
            this.txtViewYear.Name = "txtViewYear";
            this.txtViewYear.Size = new System.Drawing.Size(213, 30);
            this.txtViewYear.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(442, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Month : ";
            // 
            // cmbViewMonth
            // 
            this.cmbViewMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cmbViewMonth.Location = new System.Drawing.Point(530, 186);
            this.cmbViewMonth.Name = "cmbViewMonth";
            this.cmbViewMonth.Size = new System.Drawing.Size(213, 33);
            this.cmbViewMonth.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Category :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Type :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Allocated Amount : ";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(99, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(252, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "Add / Edit Budget Item";
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(170, 268);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(181, 33);
            this.cmbCategory.TabIndex = 10;
            // 
            // cmbType
            // 
            this.cmbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Income",
            "Expense"});
            this.cmbType.Location = new System.Drawing.Point(170, 326);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(181, 33);
            this.cmbType.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(111, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Year :";
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(170, 158);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(181, 30);
            this.txtYear.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(100, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Month :";
            // 
            // cmbMonth
            // 
            this.cmbMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cmbMonth.Location = new System.Drawing.Point(170, 213);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(177, 33);
            this.cmbMonth.TabIndex = 16;
            // 
            // btnSubmitBudget
            // 
            this.btnSubmitBudget.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSubmitBudget.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmitBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitBudget.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSubmitBudget.Location = new System.Drawing.Point(148, 456);
            this.btnSubmitBudget.Name = "btnSubmitBudget";
            this.btnSubmitBudget.Size = new System.Drawing.Size(89, 41);
            this.btnSubmitBudget.TabIndex = 17;
            this.btnSubmitBudget.Text = "Submit";
            this.btnSubmitBudget.UseVisualStyleBackColor = false;
            this.btnSubmitBudget.Click += new System.EventHandler(this.btnSubmitBudgetClick);
            // 
            // btnViewBudget
            // 
            this.btnViewBudget.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnViewBudget.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewBudget.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnViewBudget.Location = new System.Drawing.Point(802, 186);
            this.btnViewBudget.Name = "btnViewBudget";
            this.btnViewBudget.Size = new System.Drawing.Size(95, 33);
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
            this.dataGridBudget.Location = new System.Drawing.Point(417, 245);
            this.dataGridBudget.MultiSelect = false;
            this.dataGridBudget.Name = "dataGridBudget";
            this.dataGridBudget.RowTemplate.Height = 28;
            this.dataGridBudget.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridBudget.Size = new System.Drawing.Size(564, 252);
            this.dataGridBudget.TabIndex = 19;
            this.dataGridBudget.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEditValue);
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(170, 384);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(181, 30);
            this.txtAmount.TabIndex = 20;
            // 
            // txtBudgetItemId
            // 
            this.txtBudgetItemId.Location = new System.Drawing.Point(54, 60);
            this.txtBudgetItemId.Name = "txtBudgetItemId";
            this.txtBudgetItemId.Size = new System.Drawing.Size(51, 26);
            this.txtBudgetItemId.TabIndex = 21;
            this.txtBudgetItemId.Visible = false;
            // 
            // txtMonth
            // 
            this.txtMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonth.Location = new System.Drawing.Point(170, 213);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(181, 30);
            this.txtMonth.TabIndex = 22;
            this.txtMonth.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(309, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(388, 46);
            this.label9.TabIndex = 23;
            this.label9.Text = "Budget Management";
            // 
            // btnDeleteBudgetItem
            // 
            this.btnDeleteBudgetItem.BackColor = System.Drawing.Color.Red;
            this.btnDeleteBudgetItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteBudgetItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBudgetItem.ForeColor = System.Drawing.Color.Snow;
            this.btnDeleteBudgetItem.Location = new System.Drawing.Point(258, 456);
            this.btnDeleteBudgetItem.Name = "btnDeleteBudgetItem";
            this.btnDeleteBudgetItem.Size = new System.Drawing.Size(93, 41);
            this.btnDeleteBudgetItem.TabIndex = 24;
            this.btnDeleteBudgetItem.Text = "Delete";
            this.btnDeleteBudgetItem.UseVisualStyleBackColor = false;
            this.btnDeleteBudgetItem.Click += new System.EventHandler(this.btnDeleteBudgetClick);
            // 
            // BudgetMgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1016, 536);
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
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "BudgetMgt";
            this.Text = "Budget Management";
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